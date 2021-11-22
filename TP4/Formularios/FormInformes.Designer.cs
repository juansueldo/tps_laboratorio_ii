
namespace Formularios
{
    partial class FormInformes
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
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.pbrFemenino = new System.Windows.Forms.ProgressBar();
            this.pbrNoBinario = new System.Windows.Forms.ProgressBar();
            this.pbrMasculino = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rchDatos = new System.Windows.Forms.RichTextBox();
            this.btnSQL = new System.Windows.Forms.Button();
            this.rchPromedio = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.Location = new System.Drawing.Point(572, 42);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(163, 44);
            this.btnAnalisis.TabIndex = 3;
            this.btnAnalisis.Text = "Analisis desde JSON";
            this.btnAnalisis.UseVisualStyleBackColor = true;
            this.btnAnalisis.Click += new System.EventHandler(this.btnAnalisis_Click);
            // 
            // pbrFemenino
            // 
            this.pbrFemenino.Location = new System.Drawing.Point(31, 42);
            this.pbrFemenino.Name = "pbrFemenino";
            this.pbrFemenino.Size = new System.Drawing.Size(368, 35);
            this.pbrFemenino.TabIndex = 4;
            // 
            // pbrNoBinario
            // 
            this.pbrNoBinario.Location = new System.Drawing.Point(31, 102);
            this.pbrNoBinario.Name = "pbrNoBinario";
            this.pbrNoBinario.Size = new System.Drawing.Size(368, 35);
            this.pbrNoBinario.TabIndex = 5;
            // 
            // pbrMasculino
            // 
            this.pbrMasculino.Location = new System.Drawing.Point(31, 173);
            this.pbrMasculino.Name = "pbrMasculino";
            this.pbrMasculino.Size = new System.Drawing.Size(368, 35);
            this.pbrMasculino.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Femenino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "No Binario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Masculino";
            // 
            // rchDatos
            // 
            this.rchDatos.Location = new System.Drawing.Point(31, 253);
            this.rchDatos.Name = "rchDatos";
            this.rchDatos.Size = new System.Drawing.Size(721, 149);
            this.rchDatos.TabIndex = 10;
            this.rchDatos.Text = "";
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(572, 113);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(163, 44);
            this.btnSQL.TabIndex = 11;
            this.btnSQL.Text = "Mostrar datos SQL";
            this.btnSQL.UseVisualStyleBackColor = true;
            this.btnSQL.Click += new System.EventHandler(this.btnSQL_Click);
            // 
            // rchPromedio
            // 
            this.rchPromedio.Location = new System.Drawing.Point(31, 411);
            this.rchPromedio.Name = "rchPromedio";
            this.rchPromedio.Size = new System.Drawing.Size(721, 149);
            this.rchPromedio.TabIndex = 12;
            this.rchPromedio.Text = "";
            // 
            // FormInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 572);
            this.Controls.Add(this.rchPromedio);
            this.Controls.Add(this.btnSQL);
            this.Controls.Add(this.rchDatos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbrMasculino);
            this.Controls.Add(this.pbrNoBinario);
            this.Controls.Add(this.pbrFemenino);
            this.Controls.Add(this.btnAnalisis);
            this.Name = "FormInformes";
            this.Text = "FormInformes";
            this.Load += new System.EventHandler(this.FormInformes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAnalisis;
        private System.Windows.Forms.ProgressBar pbrFemenino;
        private System.Windows.Forms.ProgressBar pbrNoBinario;
        private System.Windows.Forms.ProgressBar pbrMasculino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rchDatos;
        private System.Windows.Forms.Button btnSQL;
        private System.Windows.Forms.RichTextBox rchPromedio;
    }
}