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
    public partial class FormProyecto : Form
    {
        Proyecto proyecto = new Proyecto();
        List<Programador> lista = new List<Programador>();
        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Equipo.json";
        string ruta2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Proyecto.json";
        public FormProyecto()
        {
            InitializeComponent();
        }

        private void FormProyecto_Load(object sender, EventArgs e)
        {
            this.btnCargar.Enabled = false;
            this.cmbGenero.DataSource = Enum.GetValues(typeof(GeneroJuego));
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FormEquipo equipo = new FormEquipo();
            equipo.Show();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            proyecto.Nombre = txtNombre.Text;
            proyecto.Id = int.Parse(txtId.Text);
            proyecto.GeneroJuego = (GeneroJuego)cmbGenero.SelectedItem;
            proyecto.FechaLanzamiento =  this.dtpFecha.Value;
            proyecto.Programadores = lista;
            try
            {
                SerializarAJson.Serializar(ruta2, proyecto);
                MessageBox.Show("Proyecto Guardado");
            }
            catch(SerializarException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                
                lista = SerializarAJson.Deserializar<List<Programador>>(ruta);
            }
            catch (SerializarException ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.dgvEquipo.DataSource = proyecto.Programadores;
            this.btnCargar.Enabled = true;
            
        }
    }
}
