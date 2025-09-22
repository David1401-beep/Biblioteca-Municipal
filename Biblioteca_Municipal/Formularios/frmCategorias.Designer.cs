namespace Biblioteca_Legal.Formularios
{
    partial class frmCategorias
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
            this.pnlCategorias = new System.Windows.Forms.Panel();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnActualizarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.pnlCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCategorias
            // 
            this.pnlCategorias.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlCategorias.Controls.Add(this.btnEliminarCategoria);
            this.pnlCategorias.Controls.Add(this.btnActualizarCategoria);
            this.pnlCategorias.Controls.Add(this.btnAgregarCategoria);
            this.pnlCategorias.Controls.Add(this.txtNombreCategoria);
            this.pnlCategorias.Controls.Add(this.lblNombreCategoria);
            this.pnlCategorias.Controls.Add(this.lblCategorias);
            this.pnlCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCategorias.Location = new System.Drawing.Point(4, 1);
            this.pnlCategorias.Name = "pnlCategorias";
            this.pnlCategorias.Size = new System.Drawing.Size(799, 240);
            this.pnlCategorias.TabIndex = 0;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(3, 238);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.Size = new System.Drawing.Size(799, 213);
            this.dgvCategorias.TabIndex = 1;
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.Location = new System.Drawing.Point(8, 8);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(96, 20);
            this.lblCategorias.TabIndex = 0;
            this.lblCategorias.Text = "Categorías";
            // 
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.AutoSize = true;
            this.lblNombreCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCategoria.Location = new System.Drawing.Point(3, 76);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(156, 16);
            this.lblNombreCategoria.TabIndex = 1;
            this.lblNombreCategoria.Text = "Nombre de Categoría";
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCategoria.Location = new System.Drawing.Point(165, 73);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(258, 22);
            this.txtNombreCategoria.TabIndex = 2;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.Location = new System.Drawing.Point(20, 142);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(113, 44);
            this.btnAgregarCategoria.TabIndex = 3;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnActualizarCategoria
            // 
            this.btnActualizarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCategoria.Location = new System.Drawing.Point(165, 142);
            this.btnActualizarCategoria.Name = "btnActualizarCategoria";
            this.btnActualizarCategoria.Size = new System.Drawing.Size(113, 44);
            this.btnActualizarCategoria.TabIndex = 4;
            this.btnActualizarCategoria.Text = "Actualizar";
            this.btnActualizarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategoria.Location = new System.Drawing.Point(310, 142);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(113, 44);
            this.btnEliminarCategoria.TabIndex = 5;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.pnlCategorias);
            this.Name = "frmCategorias";
            this.Text = "frmCategorias";
            this.pnlCategorias.ResumeLayout(false);
            this.pnlCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCategorias;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnActualizarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Label lblNombreCategoria;
        private System.Windows.Forms.Label lblCategorias;
    }
}