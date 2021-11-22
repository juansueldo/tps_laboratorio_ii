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
        Juego proyecto = new Juego();
        Estadisticas estadisticas = new Estadisticas();
        Thread hilo;
        delegate void delegado(int valor);
        delegate void delegadoString(string cadena);
        public FormInformes()
        {
            InitializeComponent();
           try
            {
                proyecto = SerializarAJson.Deserializar<Juego>("Proyectos.json");
            }
            catch (ArchivosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void FormInformes_Load(object sender, EventArgs e)
        {
            this.pbrFemenino.Maximum = proyecto.Programadores.Count;
            this.pbrMasculino.Maximum = proyecto.Programadores.Count;
            this.pbrNoBinario.Maximum = proyecto.Programadores.Count;
        }
        #region "Proceso 1"
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

        #region"Proceso 2"
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

        #region "Proceso 3"
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
        public void Datos(string cadena)
        {
            this.rchDatos.Text = cadena;
        }
        public void Promedios(string cadena)
        {
            this.rchPromedio.Text = cadena;
        }
        public void Proceso4()
        {
                delegadoString MD = new delegadoString(Datos);
                this.Invoke(MD, new object[] { estadisticas.ProgramadoresPorPuesto(proyecto) });
                Thread.Sleep(100);
        }
        public void Proceso5()
        {
            delegadoString delegado = new delegadoString(Promedios);
            this.Invoke(delegado, new object[] { estadisticas.PromedioEdades(proyecto) });
            Thread.Sleep(100);
        }
        #endregion

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
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

        private void btnSQL_Click(object sender, EventArgs e)
        {
            FormMostrarTodo formMostrar = new FormMostrarTodo();
            formMostrar.Show();
        }
    }
}
