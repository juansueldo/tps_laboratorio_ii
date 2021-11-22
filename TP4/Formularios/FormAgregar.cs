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
    public partial class FormAgregar : Form
    {
        ListaProgramadores lista = new ListaProgramadores(10);
        
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            this.cmbSector.DataSource = Enum.GetValues(typeof(Puesto));
            this.cmbGenero.DataSource = Enum.GetValues(typeof(Genero));
            this.btnSalir.Enabled = false;
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
             try
             {
                  if (txtLegajo.Text.All(char.IsDigit) && txtNombre.Text.All(char.IsLetter) && txtApellido.Text.All(char.IsLetter))
                  {
                    Programador p = new Programador(txtNombre.Text, txtApellido.Text, (Genero)this.cmbGenero.SelectedItem,
                                       (Puesto)cmbSector.SelectedItem, short.Parse(txtLegajo.Text), (short)numEdad.Value);
                        try
                        {
                            lista += p;
                            try
                            {
                                ConexionBD.Guardar(p);
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        MessageBox.Show("Guardado a la lista");

                        }
                        catch (CantidadEmpleadosException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        catch (EmpleadoException exc)
                        {
                            MessageBox.Show(exc.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar valores validos");
                    }
                }
                catch (LegajoValidarException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (SueldoValidarException exc)
                {
                    MessageBox.Show(exc.Message);
                }
            try
            {
                SerializarAJson.Serializar("Programadores.json", lista);
            }
            catch(SerializarException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
            this.btnSalir.Enabled = true;
        }

        private void FormAgregar_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
