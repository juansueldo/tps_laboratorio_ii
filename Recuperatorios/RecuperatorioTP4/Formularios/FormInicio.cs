using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FormProyecto p = new FormProyecto();
            p.Show();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            FormInformes i = new FormInformes();
            i.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            FormMostrarTodo m = new FormMostrarTodo();
            m.Show();
        }
    }
}
