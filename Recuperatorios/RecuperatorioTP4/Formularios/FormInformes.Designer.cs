
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformes));
            this.rchTodo = new System.Windows.Forms.RichTextBox();
            this.pbrFemenino = new System.Windows.Forms.ProgressBar();
            this.pbrMasculino = new System.Windows.Forms.ProgressBar();
            this.pbrNoBinario = new System.Windows.Forms.ProgressBar();
            this.lblFemenino = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNoBinario = new System.Windows.Forms.Label();
            this.lblMasculino = new System.Windows.Forms.Label();
            this.rchRangos = new System.Windows.Forms.RichTextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnJson = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rchTodo
            // 
            this.rchTodo.Location = new System.Drawing.Point(27, 241);
            this.rchTodo.Name = "rchTodo";
            this.rchTodo.Size = new System.Drawing.Size(364, 164);
            this.rchTodo.TabIndex = 0;
            this.rchTodo.Text = "";
            // 
            // pbrFemenino
            // 
            this.pbrFemenino.Location = new System.Drawing.Point(16, 22);
            this.pbrFemenino.Name = "pbrFemenino";
            this.pbrFemenino.Size = new System.Drawing.Size(235, 41);
            this.pbrFemenino.TabIndex = 1;
            // 
            // pbrMasculino
            // 
            this.pbrMasculino.Location = new System.Drawing.Point(16, 87);
            this.pbrMasculino.Name = "pbrMasculino";
            this.pbrMasculino.Size = new System.Drawing.Size(235, 41);
            this.pbrMasculino.TabIndex = 2;
            // 
            // pbrNoBinario
            // 
            this.pbrNoBinario.Location = new System.Drawing.Point(16, 159);
            this.pbrNoBinario.Name = "pbrNoBinario";
            this.pbrNoBinario.Size = new System.Drawing.Size(235, 41);
            this.pbrNoBinario.TabIndex = 3;
            // 
            // lblFemenino
            // 
            this.lblFemenino.AutoSize = true;
            this.lblFemenino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFemenino.Location = new System.Drawing.Point(272, 32);
            this.lblFemenino.Name = "lblFemenino";
            this.lblFemenino.Size = new System.Drawing.Size(86, 21);
            this.lblFemenino.TabIndex = 15;
            this.lblFemenino.Text = "Femenino";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNoBinario);
            this.groupBox1.Controls.Add(this.lblMasculino);
            this.groupBox1.Controls.Add(this.pbrFemenino);
            this.groupBox1.Controls.Add(this.lblFemenino);
            this.groupBox1.Controls.Add(this.pbrMasculino);
            this.groupBox1.Controls.Add(this.pbrNoBinario);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 223);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadisticas por genero";
            // 
            // lblNoBinario
            // 
            this.lblNoBinario.AutoSize = true;
            this.lblNoBinario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNoBinario.Location = new System.Drawing.Point(272, 168);
            this.lblNoBinario.Name = "lblNoBinario";
            this.lblNoBinario.Size = new System.Drawing.Size(92, 21);
            this.lblNoBinario.TabIndex = 17;
            this.lblNoBinario.Text = "No Binario";
            // 
            // lblMasculino
            // 
            this.lblMasculino.AutoSize = true;
            this.lblMasculino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMasculino.Location = new System.Drawing.Point(272, 98);
            this.lblMasculino.Name = "lblMasculino";
            this.lblMasculino.Size = new System.Drawing.Size(89, 21);
            this.lblMasculino.TabIndex = 16;
            this.lblMasculino.Text = "Masculino";
            // 
            // rchRangos
            // 
            this.rchRangos.Location = new System.Drawing.Point(428, 241);
            this.rchRangos.Name = "rchRangos";
            this.rchRangos.Size = new System.Drawing.Size(360, 164);
            this.rchRangos.TabIndex = 17;
            this.rchRangos.Text = "";
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtras.Location = new System.Drawing.Point(588, 152);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(191, 60);
            this.btnAtras.TabIndex = 24;
            this.btnAtras.Text = "Volver Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnJson
            // 
            this.btnJson.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJson.Location = new System.Drawing.Point(588, 34);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(191, 60);
            this.btnJson.TabIndex = 25;
            this.btnJson.Text = "Cargar desde JSON";
            this.btnJson.UseVisualStyleBackColor = true;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
            // 
            // FormInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJson);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.rchRangos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rchTodo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.FormInformes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTodo;
        private System.Windows.Forms.ProgressBar pbrFemenino;
        private System.Windows.Forms.ProgressBar pbrMasculino;
        private System.Windows.Forms.ProgressBar pbrNoBinario;
        private System.Windows.Forms.Label lblFemenino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNoBinario;
        private System.Windows.Forms.Label lblMasculino;
        private System.Windows.Forms.RichTextBox rchRangos;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnJson;
    }
}