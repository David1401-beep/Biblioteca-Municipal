namespace Biblioteca_Legal.Formularios
{
    partial class frmGestiondeUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlGestionUsuarios = new System.Windows.Forms.Panel();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnActualizarUsuario = new System.Windows.Forms.Button();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.txtContraseñaUsuario = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGestionUsuario = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.pnlGestionUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGestionUsuarios
            // 
            this.pnlGestionUsuarios.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlGestionUsuarios.Controls.Add(this.btnEliminarUsuario);
            this.pnlGestionUsuarios.Controls.Add(this.btnActualizarUsuario);
            this.pnlGestionUsuarios.Controls.Add(this.btnRegistrarUsuario);
            this.pnlGestionUsuarios.Controls.Add(this.cbRol);
            this.pnlGestionUsuarios.Controls.Add(this.txtContraseñaUsuario);
            this.pnlGestionUsuarios.Controls.Add(this.txtUsuario);
            this.pnlGestionUsuarios.Controls.Add(this.txtNombreUsuario);
            this.pnlGestionUsuarios.Controls.Add(this.label5);
            this.pnlGestionUsuarios.Controls.Add(this.label4);
            this.pnlGestionUsuarios.Controls.Add(this.label3);
            this.pnlGestionUsuarios.Controls.Add(this.label2);
            this.pnlGestionUsuarios.Controls.Add(this.lblGestionUsuario);
            this.pnlGestionUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlGestionUsuarios.Location = new System.Drawing.Point(3, 2);
            this.pnlGestionUsuarios.Name = "pnlGestionUsuarios";
            this.pnlGestionUsuarios.Size = new System.Drawing.Size(796, 250);
            this.pnlGestionUsuarios.TabIndex = 0;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(313, 184);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(114, 48);
            this.btnEliminarUsuario.TabIndex = 11;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnActualizarUsuario
            // 
            this.btnActualizarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarUsuario.Location = new System.Drawing.Point(166, 184);
            this.btnActualizarUsuario.Name = "btnActualizarUsuario";
            this.btnActualizarUsuario.Size = new System.Drawing.Size(114, 48);
            this.btnActualizarUsuario.TabIndex = 10;
            this.btnActualizarUsuario.Text = "Actualizar";
            this.btnActualizarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(16, 184);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(114, 48);
            this.btnRegistrarUsuario.TabIndex = 9;
            this.btnRegistrarUsuario.Text = "Registrar";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = true;
            // 
            // cbRol
            // 
            this.cbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "Administrador",
            "Bibliotecario"});
            this.cbRol.Location = new System.Drawing.Point(107, 152);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(121, 24);
            this.cbRol.TabIndex = 8;
            // 
            // txtContraseñaUsuario
            // 
            this.txtContraseñaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaUsuario.Location = new System.Drawing.Point(107, 121);
            this.txtContraseñaUsuario.Name = "txtContraseñaUsuario";
            this.txtContraseñaUsuario.Size = new System.Drawing.Size(320, 22);
            this.txtContraseñaUsuario.TabIndex = 7;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(107, 90);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(320, 22);
            this.txtUsuario.TabIndex = 6;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(107, 58);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(320, 22);
            this.txtNombreUsuario.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // lblGestionUsuario
            // 
            this.lblGestionUsuario.AutoSize = true;
            this.lblGestionUsuario.Location = new System.Drawing.Point(3, 7);
            this.lblGestionUsuario.Name = "lblGestionUsuario";
            this.lblGestionUsuario.Size = new System.Drawing.Size(173, 20);
            this.lblGestionUsuario.TabIndex = 0;
            this.lblGestionUsuario.Text = "Gestion de Usuarios";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 246);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(798, 203);
            this.dgvUsuarios.TabIndex = 1;
            // 
            // frmGestiondeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.pnlGestionUsuarios);
            this.Name = "frmGestiondeUsuario";
            this.Text = "frmGestiondeUsuario";
            this.pnlGestionUsuarios.ResumeLayout(false);
            this.pnlGestionUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGestionUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGestionUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContraseñaUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnActualizarUsuario;
        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.ComboBox cbRol;
    }
}