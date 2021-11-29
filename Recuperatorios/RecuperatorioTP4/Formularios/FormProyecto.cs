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
        
        List<Programador> lista = new List<Programador>();
        string ruta = "Equipo.json";
        string ruta2 = "Proyecto.json";
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
            Proyecto proyecto = new Proyecto(txtNombre.Text, int.Parse(txtId.Text), (GeneroJuego)cmbGenero.SelectedItem,
                this.dtpFecha.Value.Date);
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
            this.dgvEquipo.DataSource = lista;
            this.btnCargar.Enabled = true;
            
        }
    }
}
