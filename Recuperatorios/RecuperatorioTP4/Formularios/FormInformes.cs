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
        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Proyecto.json";

        public FormInformes()
        {
            InitializeComponent();
            
        }

        private void FormInformes_Load(object sender, EventArgs e)
        {
            this.pbrFemenino.Maximum = proyecto.Programadores.Count;
            this.pbrMasculino.Maximum = proyecto.Programadores.Count;
            this.pbrNoBinario.Maximum = proyecto.Programadores.Count;
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
        }
        #endregion

        #region Proceso  4
        public void Proceso4()
        {
            delegadoString MD = new delegadoString(Datos);
            this.Invoke(MD, new object[] { estadisticas.ProgramadoresPorPuesto(proyecto) });
            Thread.Sleep(100);
        }
        public void Datos(string cadena)
        {
            this.rchTodo.Text = cadena;
        }
        #endregion

        #region Proceso 5
        public void Proceso5()
        {
            delegadoString delegado = new delegadoString(Rangos);
            this.Invoke(delegado, new object[] { estadisticas.RangosEtarios(proyecto) });
            Thread.Sleep(100);
        }
        public void Rangos(string cadena)
        {
            this.rchRangos.Text = cadena;
        }
        #endregion

        private void btnJson_Click(object sender, EventArgs e)
        {
            try
            {
                proyecto = SerializarAJson.Deserializar<Proyecto>("Proyectos.json");
            }
            catch (SerializarException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            hilo = new Thread(new ThreadStart(Proceso1));
            hilo.Start();
            hilo = new Thread(new ThreadStart(Proceso2));
            hilo.Start();
            hilo = new Thread(new ThreadStart(Proceso3));
            hilo.Start();
            hilo = new Thread(new ThreadStart(Proceso4));
            hilo.Start();
            hilo = new Thread(new ThreadStart(Proceso5));
            hilo.Start();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
