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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// Agrega en el comboBox los valores que solamente se pueden seleccionar e inicializa el false los botones de conversion
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();

            cmbOperador.Items.Add(" ");
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("*");
            cmbOperador.Items.Add("/");

            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Realiza la conversion a binario del numero decimal, y lockea el boton de convertir a binario
        /// </summary>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando resultado = new Operando(lblResultado.Text);
            lblResultado.Text = resultado.DecimalBinario(lblResultado.Text);
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = true;
        }
        /// <summary>
        /// Realiza la conversion a decimal del numero binario, y lockea el boton de convertir a decimal
        /// </summary>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando resultado = new Operando(lblResultado.Text);
            lblResultado.Text = resultado.BinarioDecimal(lblResultado.Text).ToString();
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
        }
        /// <summary>
        /// Llama al metodo limpiar, que resetea los valores
        /// </summary>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Realiza el llamado al metodo Operar
        /// </summary>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
            if (cmbOperador.Text == " ")
            {
                cmbOperador.Text = "+";
            }
            StringBuilder sb = new StringBuilder();
            sb.Append(txtNumero1.Text + " ");
            sb.Append(cmbOperador.Text + " ");
            sb.Append(txtNumero2.Text + " ");
            sb.Append("=" + " ");
            sb.Append(lblResultado.Text);

            lstOperaciones.Items.Add(sb);
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = true;
        }
        /// <summary>
        /// Realiza el llamado al metodo Limpiar
        /// </summary>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Asigna valores por defecto a los parametros ingresados por el usuario
        /// </summary>
        public void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.lblResultado.Text = "0";
            cmbOperador.Text = " ";
        }
        /// <summary>
        /// Realiza el llamado al metodo Operar 
        /// </summary>
        /// <param name="numero1">Primer numero recibido</param>
        /// <param name="numero2">Segundo numero recibido</param>
        /// <param name="operador">Operacion seleccionada</param>
        /// <returns>Retorna el resultado de la operacion</returns>
        private static double Operar(String numero1, String numero2, String operador)
        {
            Operando numeroUno = new Operando(numero1);
            Operando numeroDos = new Operando(numero2);
            return Calculadora.Operar(numeroUno, numeroDos, char.Parse(operador));
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

