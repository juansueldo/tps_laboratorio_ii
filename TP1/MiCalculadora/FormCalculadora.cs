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
        private void btnCerrar_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando resultado = new Operando(lblResultado.Text);
            lblResultado.Text = resultado.DecimalBinario(lblResultado.Text);
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = true;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando resultado = new Operando(lblResultado.Text);
            lblResultado.Text = resultado.BinarioDecimal(lblResultado.Text).ToString();
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        
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
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            this.txtNumero1.Text= "";
            this.txtNumero2.Text = "";
            this.lblResultado.Text = "0";
            cmbOperador.Text = " ";
        }

        private static double Operar(String numero1, String numero2, String operador)
        {
            Operando numeroUno = new Operando(numero1);
            Operando numeroDos = new Operando(numero2);
            return Calculadora.Operar(numeroUno, numeroDos, char.Parse(operador));
        }
       private void Form_FormClosing(object sender, FormClosingEventArgs e)
       {
            if (MessageBox.Show("¿Está seguro de querer salir?","Salir", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
