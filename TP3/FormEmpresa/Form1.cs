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

namespace FormEmpresa
{
    public partial class FormEmpleados : Form
    {
        Empresa empresa = new Empresa("Mountain", 10);
        public FormEmpleados()
        {
            InitializeComponent();
            this.lblPuesto.Visible = false;
            this.cmbPuesto.Visible = false;
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            this.cmbSector.DataSource = Enum.GetValues(typeof(Sector));
            this.cmbPuesto.DataSource = Enum.GetValues(typeof(Tipo));
            this.cmbGenero.DataSource = Enum.GetValues(typeof(Genero));
            this.lblNombreEmpresa.Text = empresa.Nombre;
        }
        private void cmbSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbSector.SelectedItem is Sector.Programador)
            {
                this.lblPuesto.Visible = true;
                this.cmbPuesto.Visible = true;
            }
            else
            {
                this.lblPuesto.Visible = false;
                this.cmbPuesto.Visible = false;
            }
        }
        private void RefrescarEmpresa()
        {
            this.lstEmpleados.Items.Clear();
            foreach (Empleado item in empresa.empleados)
            {
                lstEmpleados.Items.Add(item.MostrarEmpleado());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.cmbSector.SelectedItem is Sector.Programador)
            {
                try
                {
                    Empleado e1 = new Programador(txtLegajo.Text, txtNombre.Text, txtApellido.Text
                        , txtSueldo.Text, (Genero)this.cmbGenero.SelectedItem, (Tipo)this.cmbPuesto.SelectedItem);
                    try
                    {
                        empresa += e1;
                    }
                    catch (EmpleadoException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (CantidadEmpleadosException exc)
                    {
                        MessageBox.Show(exc.Message);
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


            }
            else if (this.cmbSector.SelectedItem is Sector.RRHH)
            {
                try
                {
                    Empleado e2 = new RecursosHumanos(txtLegajo.Text, txtNombre.Text, txtApellido.Text,
                    txtSueldo.Text, (Genero)this.cmbGenero.SelectedItem);
                    try
                    {
                        empresa += e2;
                    }
                    catch (EmpleadoException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (CantidadEmpleadosException exc)
                    {
                        MessageBox.Show(exc.Message);
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
            }
            else
            {
                MessageBox.Show("No se ingreso un sector");
            }
            RefrescarEmpresa();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            foreach (Empleado item in empresa.empleados)
            {
                if (item.Legajo == int.Parse(this.txtLegajo.Text))
                {
                    empresa -= item;
                    break;
                }
                else
                {
                    MessageBox.Show("El legajo no existe");
                }
            }
            RefrescarEmpresa();
        }
        private void FormEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            Estadisticas estadisticas = new Estadisticas();

            this.rchSector.Text = estadisticas.CantidadEmpleadosPorGenero(empresa);
            this.rchPuesto.Text = estadisticas.EmpleadosPorSector(empresa);
        }

    }
}
