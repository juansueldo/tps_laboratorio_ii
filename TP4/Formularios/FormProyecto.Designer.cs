
namespace Formularios
{
    partial class FormProyecto
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpFechaLanazmiento = new System.Windows.Forms.DateTimePicker();
            this.btnCrear = new System.Windows.Forms.Button();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaLanzamiento = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.lblId = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(42, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(141, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // dtpFechaLanazmiento
            // 
            this.dtpFechaLanazmiento.Location = new System.Drawing.Point(40, 136);
            this.dtpFechaLanazmiento.Name = "dtpFechaLanazmiento";
            this.dtpFechaLanazmiento.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaLanazmiento.TabIndex = 2;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(44, 310);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(165, 57);
            this.btnCrear.TabIndex = 5;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(42, 213);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 23);
            this.cmbGenero.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(42, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(120, 15);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre del proyecto";
            // 
            // lblFechaLanzamiento
            // 
            this.lblFechaLanzamiento.AutoSize = true;
            this.lblFechaLanzamiento.Location = new System.Drawing.Point(40, 106);
            this.lblFechaLanzamiento.Name = "lblFechaLanzamiento";
            this.lblFechaLanzamiento.Size = new System.Drawing.Size(122, 15);
            this.lblFechaLanzamiento.TabIndex = 9;
            this.lblFechaLanzamiento.Text = "Fecha de lanzamiento";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(42, 186);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 15);
            this.lblGenero.TabIndex = 10;
            this.lblGenero.Text = "Genero";
            // 
            // nudId
            // 
            this.nudId.Location = new System.Drawing.Point(255, 46);
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(120, 23);
            this.nudId.TabIndex = 11;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(255, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(67, 15);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "Id proyecto";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(268, 310);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(165, 57);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 379);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.nudId);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblFechaLanzamiento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dtpFechaLanazmiento);
            this.Controls.Add(this.txtNombre);
            this.Name = "FormProyecto";
            this.Text = "Creador de proyectos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProyecto_FormClosing);
            this.Load += new System.EventHandler(this.FormProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaLanazmiento;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaLanzamiento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.NumericUpDown nudId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnSalir;
    }
}