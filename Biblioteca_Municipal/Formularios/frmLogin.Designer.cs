namespace Biblioteca_Legal
{
    partial class frmLogin
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lbRecuperarContraseña = new System.Windows.Forms.LinkLabel();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.txtContraseñaLogin = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.lbRecuperarContraseña);
            this.pnlLogin.Controls.Add(this.btnIniciarSesion);
            this.pnlLogin.Controls.Add(this.txtContraseñaLogin);
            this.pnlLogin.Controls.Add(this.txtCorreoElectronico);
            this.pnlLogin.Controls.Add(this.lblContraseña);
            this.pnlLogin.Controls.Add(this.lblCorreoElectronico);
            this.pnlLogin.Controls.Add(this.pictureBox1);
            this.pnlLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLogin.Location = new System.Drawing.Point(147, 12);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(507, 426);
            this.pnlLogin.TabIndex = 1;
            // 
            // lbRecuperarContraseña
            // 
            this.lbRecuperarContraseña.AutoSize = true;
            this.lbRecuperarContraseña.Location = new System.Drawing.Point(40, 301);
            this.lbRecuperarContraseña.Name = "lbRecuperarContraseña";
            this.lbRecuperarContraseña.Size = new System.Drawing.Size(178, 18);
            this.lbRecuperarContraseña.TabIndex = 6;
            this.lbRecuperarContraseña.TabStop = true;
            this.lbRecuperarContraseña.Text = "Recuperar Contraseña";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(178, 349);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(155, 35);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar Sesisón";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // txtContraseñaLogin
            // 
            this.txtContraseñaLogin.Location = new System.Drawing.Point(43, 262);
            this.txtContraseñaLogin.Name = "txtContraseñaLogin";
            this.txtContraseñaLogin.Size = new System.Drawing.Size(376, 24);
            this.txtContraseñaLogin.TabIndex = 4;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(43, 195);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(382, 24);
            this.txtCorreoElectronico.TabIndex = 3;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(40, 241);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(100, 18);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(40, 174);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(157, 18);
            this.lblCorreoElectronico.TabIndex = 1;
            this.lblCorreoElectronico.Text = "Correo Electronico:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblioteca_Legal.Properties.Resources.WhatsApp_Image_2025_09_21_at_11_29_56_AM_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(178, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlLogin);
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.LinkLabel lbRecuperarContraseña;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.TextBox txtContraseñaLogin;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

