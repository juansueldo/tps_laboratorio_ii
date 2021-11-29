
namespace Formularios
{
    partial class FormMostrarTodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMostrarTodo));
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.dgvTodo = new System.Windows.Forms.DataGridView();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).BeginInit();
            this.SuspendLayout();
            // 
            // lstDatos
            // 
            this.lstDatos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.ItemHeight = 30;
            this.lstDatos.Location = new System.Drawing.Point(47, 25);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(485, 124);
            this.lstDatos.TabIndex = 0;
            // 
            // dgvTodo
            // 
            this.dgvTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodo.Location = new System.Drawing.Point(47, 177);
            this.dgvTodo.Name = "dgvTodo";
            this.dgvTodo.RowTemplate.Height = 25;
            this.dgvTodo.Size = new System.Drawing.Size(628, 203);
            this.dgvTodo.TabIndex = 1;
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtras.Location = new System.Drawing.Point(639, 421);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(191, 60);
            this.btnAtras.TabIndex = 25;
            this.btnAtras.Text = "Volver Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(47, 386);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(170, 23);
            this.btnCargar.TabIndex = 26;
            this.btnCargar.Text = "Cargar desde Base de Datos";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // FormMostrarTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 493);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dgvTodo);
            this.Controls.Add(this.lstDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMostrarTodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Ingresados";
            this.Load += new System.EventHandler(this.FormMostrarTodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.DataGridView dgvTodo;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnCargar;
    }
}