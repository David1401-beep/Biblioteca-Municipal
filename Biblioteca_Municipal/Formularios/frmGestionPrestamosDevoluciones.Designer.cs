namespace Biblioteca_Legal.Formularios
{
    partial class frmGestionPrestamosDevoluciones
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
            this.pnlPrestamosDevoluciones = new System.Windows.Forms.Panel();
            this.dgvPrestamosDevoluciones = new System.Windows.Forms.DataGridView();
            this.lblPrestasmosDevoluciones = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblLibro = new System.Windows.Forms.Label();
            this.lblPrestamo = new System.Windows.Forms.Label();
            this.lblDevolucion = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarPrestamo = new System.Windows.Forms.Button();
            this.btnRegistrarDevolucion = new System.Windows.Forms.Button();
            this.pnlPrestamosDevoluciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosDevoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrestamosDevoluciones
            // 
            this.pnlPrestamosDevoluciones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlPrestamosDevoluciones.Controls.Add(this.btnRegistrarDevolucion);
            this.pnlPrestamosDevoluciones.Controls.Add(this.btnRegistrarPrestamo);
            this.pnlPrestamosDevoluciones.Controls.Add(this.dateTimePicker2);
            this.pnlPrestamosDevoluciones.Controls.Add(this.dateTimePicker1);
            this.pnlPrestamosDevoluciones.Controls.Add(this.txtLibro);
            this.pnlPrestamosDevoluciones.Controls.Add(this.txtUsuario);
            this.pnlPrestamosDevoluciones.Controls.Add(this.lblDevolucion);
            this.pnlPrestamosDevoluciones.Controls.Add(this.lblPrestamo);
            this.pnlPrestamosDevoluciones.Controls.Add(this.lblLibro);
            this.pnlPrestamosDevoluciones.Controls.Add(this.lblUsuario);
            this.pnlPrestamosDevoluciones.Controls.Add(this.lblPrestasmosDevoluciones);
            this.pnlPrestamosDevoluciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPrestamosDevoluciones.Location = new System.Drawing.Point(1, 0);
            this.pnlPrestamosDevoluciones.Name = "pnlPrestamosDevoluciones";
            this.pnlPrestamosDevoluciones.Size = new System.Drawing.Size(799, 249);
            this.pnlPrestamosDevoluciones.TabIndex = 0;
            // 
            // dgvPrestamosDevoluciones
            // 
            this.dgvPrestamosDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamosDevoluciones.Location = new System.Drawing.Point(1, 243);
            this.dgvPrestamosDevoluciones.Name = "dgvPrestamosDevoluciones";
            this.dgvPrestamosDevoluciones.Size = new System.Drawing.Size(798, 209);
            this.dgvPrestamosDevoluciones.TabIndex = 1;
            // 
            // lblPrestasmosDevoluciones
            // 
            this.lblPrestasmosDevoluciones.AutoSize = true;
            this.lblPrestasmosDevoluciones.Location = new System.Drawing.Point(3, 9);
            this.lblPrestasmosDevoluciones.Name = "lblPrestasmosDevoluciones";
            this.lblPrestasmosDevoluciones.Size = new System.Drawing.Size(313, 20);
            this.lblPrestasmosDevoluciones.TabIndex = 0;
            this.lblPrestasmosDevoluciones.Text = "Gestion de Préstamos Y devoluciones";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(11, 49);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 16);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibro.Location = new System.Drawing.Point(11, 83);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(42, 16);
            this.lblLibro.TabIndex = 2;
            this.lblLibro.Text = "Libro";
            // 
            // lblPrestamo
            // 
            this.lblPrestamo.AutoSize = true;
            this.lblPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamo.Location = new System.Drawing.Point(11, 120);
            this.lblPrestamo.Name = "lblPrestamo";
            this.lblPrestamo.Size = new System.Drawing.Size(146, 16);
            this.lblPrestamo.TabIndex = 3;
            this.lblPrestamo.Text = "Fecha de Prestamo:";
            // 
            // lblDevolucion
            // 
            this.lblDevolucion.AutoSize = true;
            this.lblDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevolucion.Location = new System.Drawing.Point(11, 157);
            this.lblDevolucion.Name = "lblDevolucion";
            this.lblDevolucion.Size = new System.Drawing.Size(158, 16);
            this.lblDevolucion.TabIndex = 4;
            this.lblDevolucion.Text = "Fecha de Devolución:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(98, 46);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(218, 21);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtLibro
            // 
            this.txtLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibro.Location = new System.Drawing.Point(98, 78);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(218, 21);
            this.txtLibro.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 21);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(179, 152);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(265, 21);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // btnRegistrarPrestamo
            // 
            this.btnRegistrarPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPrestamo.Location = new System.Drawing.Point(14, 192);
            this.btnRegistrarPrestamo.Name = "btnRegistrarPrestamo";
            this.btnRegistrarPrestamo.Size = new System.Drawing.Size(180, 45);
            this.btnRegistrarPrestamo.TabIndex = 9;
            this.btnRegistrarPrestamo.Text = "Registrar Prestamo";
            this.btnRegistrarPrestamo.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarDevolucion
            // 
            this.btnRegistrarDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarDevolucion.Location = new System.Drawing.Point(264, 192);
            this.btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            this.btnRegistrarDevolucion.Size = new System.Drawing.Size(180, 45);
            this.btnRegistrarDevolucion.TabIndex = 10;
            this.btnRegistrarDevolucion.Text = "Registrar Devolución";
            this.btnRegistrarDevolucion.UseVisualStyleBackColor = true;
            // 
            // frmGestionPrestamosDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPrestamosDevoluciones);
            this.Controls.Add(this.pnlPrestamosDevoluciones);
            this.Name = "frmGestionPrestamosDevoluciones";
            this.Text = "frmGestionPrestamosDevoluciones";
            this.pnlPrestamosDevoluciones.ResumeLayout(false);
            this.pnlPrestamosDevoluciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosDevoluciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrestamosDevoluciones;
        private System.Windows.Forms.DataGridView dgvPrestamosDevoluciones;
        private System.Windows.Forms.Label lblPrestasmosDevoluciones;
        private System.Windows.Forms.Label lblDevolucion;
        private System.Windows.Forms.Label lblPrestamo;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnRegistrarDevolucion;
        private System.Windows.Forms.Button btnRegistrarPrestamo;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}