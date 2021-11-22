using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FormMostrarTodo : Form
    {
        ListaProgramadores listaProgramadores = new ListaProgramadores(10);
        public FormMostrarTodo()
        {
            InitializeComponent();
        }

        private void FormMostrarTodo_Load(object sender, EventArgs e)
        {
            try
            {
                listaProgramadores = ConexionBD.Leer();
                rchMostrarTodo.Text = listaProgramadores.MostrarNombres(listaProgramadores);
            }
            catch(Exception ex)
            {
                rchMostrarTodo.Text = ex.Message;
            }
        }
    }
}
