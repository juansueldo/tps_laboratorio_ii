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
using System.Threading;


namespace Formularios
{
    public partial class FormInformes : Form
    {
        Proyecto proyecto = new Proyecto();
        Informes estadisticas = new Informes();
        Thread hilo;
        delegate void delegado(int valor);
        delegate void delegadoString(string cadena);
        string ruta = "Proyecto.json";

        public FormInformes()
        {
            InitializeComponent();
            
        }
        public void InformeGral(string dato)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => rchTodo.Text = dato));
            }
            
        }
        private void FormInformes_Load(object sender, EventArgs e)
        {
            lblCountFemenino.Visible = false;
            lblCountMasculino.Visible = false;
            lblCountNoBinario.Visible = false;
        }
        #region Proceso 1
        public void Proceso1()
        {
            for (int i = 0; i < estadisticas.ProgramadoresFemeninos(proyecto); i++)
            {
                delegado MD = new delegado(Actualizar1);
                this.Invoke(MD, new object[] { i });
                Thread.Sleep(70);
            }
        }

        public void Actualizar1(int valor)
        {
             pbrFemenino.Value = valor;
             lblCountFemenino.Text = estadisticas.ProgramadoresFemeninos(proyecto).ToString();  
        }

        #endregion

        #region Proceso 2
        public void Proceso2()
        {
            for (int i = 0; i < estadisticas.ProgramadoresMasculinos(proyecto); i++)
            {
                delegado MD = new delegado(Actualizar2);
                this.Invoke(MD, new object[] { i });
                Thread.Sleep(40);
            }
        }

        public void Actualizar2(int valor)
        {
            pbrMasculino.Value = valor;
            lblCountMasculino.Text = estadisticas.ProgramadoresMasculinos(proyecto).ToString();
        }

        #endregion

        #region Proceso 3
        public void Proceso3()
        {
            for (int i = 0; i < estadisticas.ProgramadoresNoBinario(proyecto); i++)
            {
                delegado MD = new delegado(Actualizar3);
                this.Invoke(MD, new object[] { i });
                Thread.Sleep(100);
            }
        }

        public void Actualizar3(int valor)
        {
            pbrNoBinario.Value = valor;
            lblCountNoBinario.Text = estadisticas.ProgramadoresNoBinario(proyecto).ToString();
        }
        #endregion

        private void btnJson_Click(object sender, EventArgs e)
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
            this.pbrFemenino.Maximum = proyecto.Programadores.Count;
            this.pbrMasculino.Maximum = proyecto.Programadores.Count; 
            this.pbrNoBinario.Maximum = proyecto.Programadores.Count; 
            lblCountFemenino.Visible = true;
            lblCountMasculino.Visible = true;
            lblCountNoBinario.Visible = true;

            estadisticas.evento += new Informes.delegado(InformeGral);
            try
            {
                Thread t = new Thread(() => estadisticas.InformeGeneral(proyecto));
                t.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


            hilo = new Thread(new ThreadStart(Proceso1));
            hilo.Start();
            hilo = new Thread(new ThreadStart(Proceso2));
            hilo.Start();
            hilo = new Thread(new ThreadStart(Proceso3));
            hilo.Start();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
