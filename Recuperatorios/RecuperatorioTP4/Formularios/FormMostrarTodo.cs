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
        Proyecto proyecto = new Proyecto();
        string ruta = "Proyecto.json";
        public FormMostrarTodo()
        {
            InitializeComponent();
        }

        private void FormMostrarTodo_Load(object sender, EventArgs e)
        {
            try
            {
                proyecto = SerializarAJson.Deserializar<Proyecto>(ruta);
            }
            catch (SerializarException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            dgvTodo.DataSource = proyecto.Programadores;
            lstDatos.Items.Add($"NOMBRE: {proyecto.Nombre}");
            lstDatos.Items.Add($"Id: {proyecto.Id}");
            lstDatos.Items.Add($"Genero: {proyecto.GeneroJuego}");
            lstDatos.Items.Add($"Fecha de lanzamiento: {proyecto.FechaLanzamiento}");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                proyecto.Programadores = ConexionBD.Leer();
                dgvTodo.DataSource = proyecto.Programadores;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
