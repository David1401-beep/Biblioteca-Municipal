namespace Biblioteca_Legal.Formularios
{
    partial class frmEditoriales
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
            this.pnlEditoriales = new System.Windows.Forms.Panel();
            this.dgvEditoriales = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreEditorial = new System.Windows.Forms.Label();
            this.txtNombreEditorial = new System.Windows.Forms.TextBox();
            this.btnAgregarEditorial = new System.Windows.Forms.Button();
            this.btnActualizarEditorial = new System.Windows.Forms.Button();
            this.btnEliminarEditorial = new System.Windows.Forms.Button();
            this.pnlEditoriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoriales)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEditoriales
            // 
            this.pnlEditoriales.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlEditoriales.Controls.Add(this.btnEliminarEditorial);
            this.pnlEditoriales.Controls.Add(this.btnActualizarEditorial);
            this.pnlEditoriales.Controls.Add(this.btnAgregarEditorial);
            this.pnlEditoriales.Controls.Add(this.txtNombreEditorial);
            this.pnlEditoriales.Controls.Add(this.lblNombreEditorial);
            this.pnlEditoriales.Controls.Add(this.label1);
            this.pnlEditoriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEditoriales.Location = new System.Drawing.Point(0, 3);
            this.pnlEditoriales.Name = "pnlEditoriales";
            this.pnlEditoriales.Size = new System.Drawing.Size(799, 248);
            this.pnlEditoriales.TabIndex = 0;
            // 
            // dgvEditoriales
            // 
            this.dgvEditoriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditoriales.Location = new System.Drawing.Point(0, 245);
            this.dgvEditoriales.Name = "dgvEditoriales";
            this.dgvEditoriales.Size = new System.Drawing.Size(799, 204);
            this.dgvEditoriales.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editoriales";
            // 
            // lblNombreEditorial
            // 
            this.lblNombreEditorial.AutoSize = true;
            this.lblNombreEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEditorial.Location = new System.Drawing.Point(4, 70);
            this.lblNombreEditorial.Name = "lblNombreEditorial";
            this.lblNombreEditorial.Size = new System.Drawing.Size(146, 16);
            this.lblNombreEditorial.TabIndex = 1;
            this.lblNombreEditorial.Text = "Nombre de Editorial";
            // 
            // txtNombreEditorial
            // 
            this.txtNombreEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEditorial.Location = new System.Drawing.Point(158, 70);
            this.txtNombreEditorial.Name = "txtNombreEditorial";
            this.txtNombreEditorial.Size = new System.Drawing.Size(195, 22);
            this.txtNombreEditorial.TabIndex = 2;
            // 
            // btnAgregarEditorial
            // 
            this.btnAgregarEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEditorial.Location = new System.Drawing.Point(22, 144);
            this.btnAgregarEditorial.Name = "btnAgregarEditorial";
            this.btnAgregarEditorial.Size = new System.Drawing.Size(114, 47);
            this.btnAgregarEditorial.TabIndex = 3;
            this.btnAgregarEditorial.Text = "Agregar";
            this.btnAgregarEditorial.UseVisualStyleBackColor = true;
            // 
            // btnActualizarEditorial
            // 
            this.btnActualizarEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEditorial.Location = new System.Drawing.Point(158, 144);
            this.btnActualizarEditorial.Name = "btnActualizarEditorial";
            this.btnActualizarEditorial.Size = new System.Drawing.Size(114, 47);
            this.btnActualizarEditorial.TabIndex = 4;
            this.btnActualizarEditorial.Text = "Actualizar";
            this.btnActualizarEditorial.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEditorial
            // 
            this.btnEliminarEditorial.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEditorial.Location = new System.Drawing.Point(291, 143);
            this.btnEliminarEditorial.Name = "btnEliminarEditorial";
            this.btnEliminarEditorial.Size = new System.Drawing.Size(114, 48);
            this.btnEliminarEditorial.TabIndex = 5;
            this.btnEliminarEditorial.Text = "Eliminar";
            this.btnEliminarEditorial.UseVisualStyleBackColor = false;
            // 
            // frmEditoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEditoriales);
            this.Controls.Add(this.pnlEditoriales);
            this.Name = "frmEditoriales";
            this.Text = "frmEditoriales";
            this.pnlEditoriales.ResumeLayout(false);
            this.pnlEditoriales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoriales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEditoriales;
        private System.Windows.Forms.DataGridView dgvEditoriales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreEditorial;
        private System.Windows.Forms.Label lblNombreEditorial;
        private System.Windows.Forms.Button btnEliminarEditorial;
        private System.Windows.Forms.Button btnActualizarEditorial;
        private System.Windows.Forms.Button btnAgregarEditorial;
    }
}