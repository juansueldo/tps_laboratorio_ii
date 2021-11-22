
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
            this.rchMostrarTodo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rchMostrarTodo
            // 
            this.rchMostrarTodo.Location = new System.Drawing.Point(24, 22);
            this.rchMostrarTodo.Name = "rchMostrarTodo";
            this.rchMostrarTodo.Size = new System.Drawing.Size(742, 402);
            this.rchMostrarTodo.TabIndex = 0;
            this.rchMostrarTodo.Text = "";
            // 
            // FormMostrarTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rchMostrarTodo);
            this.Name = "FormMostrarTodo";
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.FormMostrarTodo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchMostrarTodo;
    }
}