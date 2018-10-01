using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;

namespace Prueba_Conexion_GoogleDrive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            txtUploadFolder.Text = Environment.UserName;
        }

        static string[] Scopes = { DriveService.Scope.DriveFile }; //permiso otorgado: acceso limitado a archivos creados desde la app.
        static string ApplicationName = "Prueba-Conexion-GoogleDrive";
        string[] NameFiles;        
        string UploadFolderID;
        
        private void ListFiles(DriveService service, ref string pageToken)
        {
            // Se definen los parámetros para la busqueda de elementos dentro de la carpeta parent.
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = 1;            
            listRequest.Fields = "nextPageToken, files(name, id)";
            listRequest.PageToken = pageToken;
            listRequest.Q = "trashed=false";                       

            //Se crea la lista de los archivos encontrados.
            var request = listRequest.Execute();
            if (request.Files != null && request.Files.Count > 0)
            {
                foreach (var file in request.Files)
                {
                    if(file.Name == Environment.UserName)//se verifica si ya existe la carpeta en drive.
                    {
                        UploadFolderID = file.Id;
                        txtEstado.Text = UploadFolderID;
                    }
                    else
                    {
                        if(file.MimeType != "application/vnd.google-apps.folder")
                        {
                            txtDriveFiles.Text += string.Format("{0}", file.Name) + "\r\n";
                        }                        
                    }                    
                }

                pageToken = request.NextPageToken;
                if (request.NextPageToken != null)
                {
                    Console.ReadLine();
                }
            }//
            else
            {
                txtDriveFiles.Text += ("No se han encontrado archivos." + "\r\n");
            }
        }//        

        //funcion para subir archivos a la carpeta destino.
        private void UploadFile(string path, DriveService service, string folderUpload, string contentType)
        {
            var fileMetadata = new Google.Apis.Drive.v3.Data.File();
            fileMetadata.Name = Path.GetFileName(path);            

            fileMetadata.Parents = new List<string>
            {
                folderUpload
            };

            FilesResource.CreateMediaUpload request;
            using (var stream = new System.IO.FileStream(path, System.IO.FileMode.Open))
            {                
                request = service.Files.Create(fileMetadata, stream, contentType);
                request.Fields = "id";
                request.Upload();
            }

            var file = request.ResponseBody;            
        }

        //funcion para obtener la extension de los archivos a subir.
        private static string GetMimeType(string fileName)
        {
            string mimeType = "application/unknown";
            string ext = System.IO.Path.GetExtension(fileName).ToLower();
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);
            if (regKey != null && regKey.GetValue("Content Type") != null)
                mimeType = regKey.GetValue("Content Type").ToString();
            return mimeType;
        }

        //se obtienes las credenciales de acceso a la cuenta de google drive a traves de un archivo.
        private UserCredential GetCredentials()
        {
            UserCredential credential;
            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, "driveApiCredentials", "drive-credentials.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    Environment.UserName,
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                //textBox1.Text = string.Format("Credential file saved to: " + credPath);
            }
            return credential;
        }

        //Se abre el explorador para seleccionar los archivos a subir.
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileSelected.Text = "Archivos seleccionados para subir a la carpeta: => " + txtUploadFolder.Text + "\r\n\r\n";
                NameFiles = openFileDialog1.FileNames; //se guardan los nombres de los archivos en un array.
                foreach(string filename in openFileDialog1.FileNames)
                {
                    txtFileSelected.Text += filename + "\r\n";
                }
            }
        }

        //Funcion que inicia la subida de los archivos, comprobando las credenciales y procdiendo a crear la carpeta destino sino existe.
        private void btnUpload_Click(object sender, EventArgs e)
        {
            UserCredential credential;

            credential = GetCredentials();

            // Se inicia el servicio de autentificación de la api.
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            service.HttpClient.Timeout = TimeSpan.FromMinutes(100);//se asigna el tiempo límite de las operaciones de subida de archivos.

            //Se inician las busquedas de archivos y directorios en google drive.
            string pageToken = null;
            do
            {
                ListFiles(service, ref pageToken);                
            } while (pageToken != null);

            string folderid;

            //Si la carpeta destino existe se mandan los archivos y sino se procede a mandar una request para crear la carpeta.
            if (UploadFolderID != null)
            {
                folderid = UploadFolderID;                
            }
            else
            {
                //Se obtiene el id de la carpeta a través de su nombre.            
                var fileMetadatas = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = txtUploadFolder.Text,
                    MimeType = "application/vnd.google-apps.folder"
                };                
                var requests = service.Files.Create(fileMetadatas);
                requests.Fields = "id";
                var files = requests.Execute();                        
                folderid = files.Id;
                UploadFolderID = folderid;                
            }            

            //se construye el cuerpo de cada archivo a partir de su metadata para la request.
            foreach (string filename in NameFiles)
            {
                Thread thread = new Thread(() =>
                {
                    UploadFile(filename, service, folderid, GetMimeType(filename));                    
                });
                thread.IsBackground = true;
                thread.Start();
            }         
                    
            txtEstado.Text += "\r\n" + "Archivos guardados exitosamente.";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
