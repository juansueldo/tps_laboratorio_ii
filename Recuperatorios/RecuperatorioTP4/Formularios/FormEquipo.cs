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
    public partial class FormEquipo : Form
    {
        Proyecto proyecto = new Proyecto();
        Programador programador = new Programador();
        string ruta = "Equipo.json";
        public FormEquipo()
        {
            InitializeComponent();
        }
        private void FormEquipo_Load(object sender, EventArgs e)
        {
            this.cmbGenero.DataSource = Enum.GetValues(typeof(Genero));
            this.cmbPuesto.DataSource = Enum.GetValues(typeof(Puesto));
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            short edad = (short)nudEdad.Value;
            if (edad < 18 || edad > 65)
            {
                MessageBox.Show("Edad no valida");
            }
            else
            {
                Programador programador = new Programador((short)nudLegajo.Value, txtNombre.Text, txtApellido.Text,
                    (Genero)cmbGenero.SelectedItem, edad, (Puesto)cmbPuesto.SelectedItem);
            try
            {
                proyecto += programador;
                try
                {
                    SerializarAJson.Serializar(ruta, proyecto.Programadores);
                    MessageBox.Show("Programador agregado");
                }
                catch (SerializarException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (ProgramadorException ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
