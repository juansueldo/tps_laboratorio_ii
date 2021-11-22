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
        ListaProgramadores lista = new ListaProgramadores();
        public FormProyecto()
        {
            InitializeComponent();
        }

        private void FormProyecto_Load(object sender, EventArgs e)
        {
            this.btnSalir.Enabled = false;
            this.cmbGenero.DataSource = Enum.GetValues(typeof(GeneroJuego));
            lista = SerializarAJson.Deserializar<ListaProgramadores>("Programadores.json");
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
                Juego juego = new Juego(txtNombre.Text, dtpFechaLanazmiento.Value,
                                (int)nudId.Value, (GeneroJuego)cmbGenero.SelectedIndex);
                juego.Programadores = lista.Programadores;
                juego.EventoString += MostrarAgregado;
                try
                {
                    SerializarAJson.Serializar("Proyectos.json", juego);
                }
                catch (ArchivosException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    MessageBox.Show("Proyecto creado");
                    this.btnCrear.Enabled = false;
                    this.btnSalir.Enabled = true;
                }
        }

        private void FormProyecto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Quiere volver al menu principal?", "Salir", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static void MostrarAgregado(string cambio)
        {
            MessageBox.Show($"{cambio}");
        }
    }
}
