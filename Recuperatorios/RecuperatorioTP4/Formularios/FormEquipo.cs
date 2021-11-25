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
        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Equipo.json";
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
            try
            {
                Programador programador = new Programador((short)nudLegajo.Value,txtNombre.Text, txtApellido.Text, (Genero)cmbGenero.SelectedItem, (short)nudEdad.Value,(Puesto)cmbPuesto.SelectedItem);
               //programador.Legajo = (short)nudLegajo.Value;
                //programador.Edad = (short)nudEdad.Value;
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
            catch(EdadException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch(LegajoValidarException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
