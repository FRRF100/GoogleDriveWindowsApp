namespace Prueba_Conexion_GoogleDrive
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtFileSelected = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.lblArchivos = new System.Windows.Forms.Label();
            this.lblUploadPath = new System.Windows.Forms.Label();
            this.txtUploadFolder = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblArchivosDrive = new System.Windows.Forms.Label();
            this.txtDriveFiles = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(495, 474);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(135, 34);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Subir Archivos";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(12, 376);
            this.txtEstado.Multiline = true;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEstado.Size = new System.Drawing.Size(776, 81);
            this.txtEstado.TabIndex = 0;
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(12, 352);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblEstado.Size = new System.Drawing.Size(80, 21);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFileSelected
            // 
            this.txtFileSelected.Location = new System.Drawing.Point(12, 130);
            this.txtFileSelected.Multiline = true;
            this.txtFileSelected.Name = "txtFileSelected";
            this.txtFileSelected.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFileSelected.Size = new System.Drawing.Size(379, 219);
            this.txtFileSelected.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prueba_Conexion_GoogleDrive.Properties.Resources._1024px_Logo_of_Google_Drive_svg;
            this.pictureBox1.Location = new System.Drawing.Point(15, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitulo.Location = new System.Drawing.Point(84, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(307, 70);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Aplicación para subir archivos a su cuenta de google drive.";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(12, 474);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(135, 34);
            this.btnBrowser.TabIndex = 5;
            this.btnBrowser.Text = "Abrir Explorador";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // lblArchivos
            // 
            this.lblArchivos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivos.Location = new System.Drawing.Point(12, 106);
            this.lblArchivos.Name = "lblArchivos";
            this.lblArchivos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblArchivos.Size = new System.Drawing.Size(156, 21);
            this.lblArchivos.TabIndex = 6;
            this.lblArchivos.Text = "Archivos seleccionados:";
            this.lblArchivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUploadPath
            // 
            this.lblUploadPath.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblUploadPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUploadPath.Location = new System.Drawing.Point(492, 38);
            this.lblUploadPath.Name = "lblUploadPath";
            this.lblUploadPath.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblUploadPath.Size = new System.Drawing.Size(119, 21);
            this.lblUploadPath.TabIndex = 7;
            this.lblUploadPath.Text = "Carpeta Destino:";
            this.lblUploadPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUploadFolder
            // 
            this.txtUploadFolder.Location = new System.Drawing.Point(617, 40);
            this.txtUploadFolder.Name = "txtUploadFolder";
            this.txtUploadFolder.Size = new System.Drawing.Size(171, 20);
            this.txtUploadFolder.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // lblArchivosDrive
            // 
            this.lblArchivosDrive.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblArchivosDrive.Location = new System.Drawing.Point(419, 106);
            this.lblArchivosDrive.Name = "lblArchivosDrive";
            this.lblArchivosDrive.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblArchivosDrive.Size = new System.Drawing.Size(156, 21);
            this.lblArchivosDrive.TabIndex = 9;
            this.lblArchivosDrive.Text = "Archivos en Drive:";
            this.lblArchivosDrive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDriveFiles
            // 
            this.txtDriveFiles.Location = new System.Drawing.Point(422, 130);
            this.txtDriveFiles.Multiline = true;
            this.txtDriveFiles.Name = "txtDriveFiles";
            this.txtDriveFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDriveFiles.Size = new System.Drawing.Size(366, 219);
            this.txtDriveFiles.TabIndex = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(653, 474);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(135, 34);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtDriveFiles);
            this.Controls.Add(this.lblArchivosDrive);
            this.Controls.Add(this.txtUploadFolder);
            this.Controls.Add(this.lblUploadPath);
            this.Controls.Add(this.lblArchivos);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFileSelected);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.btnUpload);
            this.Name = "Form1";
            this.Text = "Servicio de Google Drive";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtFileSelected;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Label lblArchivos;
        private System.Windows.Forms.Label lblUploadPath;
        private System.Windows.Forms.TextBox txtUploadFolder;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblArchivosDrive;
        private System.Windows.Forms.TextBox txtDriveFiles;
        private System.Windows.Forms.Button btnSalir;
    }
}

