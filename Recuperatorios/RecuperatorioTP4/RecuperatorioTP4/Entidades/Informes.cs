using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Informes
    {
        public delegate void delegado(string dato);
        public event delegado evento;
        
        #region Metodos por genero
        public int ProgramadoresFemeninos(Proyecto p)
        {
            int contador = 0;
            foreach (Programador item in p.Programadores)
            {
                if (item.Genero is Genero.Femenino)
                {
                    contador++;
                }
            }
            return contador;
        }
        public int ProgramadoresNoBinario(Proyecto p)
        {
            int contador = 0;
            foreach (Programador item in p.Programadores)
            {
                if (item.Genero is Genero.NoBinario)
                {
                    contador++;
                }
            }
            return contador;
        }
        public int ProgramadoresMasculinos(Proyecto p)
        {
            int contador = 0;
            foreach (Programador item in p.Programadores)
            {
                if (item.Genero is Genero.Masculino)
                {
                    contador++;
                }
            }
            return contador;
        }
        #endregion

        #region Analisis por Puesto
        public string ProgramadoresPorPuesto(Proyecto p)
        {
            int contadorDesigner = 0;
            int contadorArstist = 0;
            int contadorTester = 0;
            StringBuilder sb = new StringBuilder();
            foreach (Programador item in p.Programadores)
            {
                if (item.Puesto is Puesto.Designer)
                {
                    contadorDesigner++;
                }
                else if (item.Puesto is Puesto.Artist)
                {
                    contadorArstist++;
                }
                else
                {
                    contadorTester++;
                }
            }
            sb.AppendLine($"Cantidad Designer: {contadorDesigner}");
            sb.AppendLine($"Cantidad Artist: {contadorArstist}");
            sb.AppendLine($"Cantidad Testers: {contadorTester}");
            return sb.ToString();
        }
        #endregion

        #region Analisis por Edad
        public string RangosEtarios(Proyecto p)
        {
            int contador1 = 0;
            int contador2 = 0;
            int contador3 = 0;
            int contador4 = 0;
            StringBuilder sb = new StringBuilder();
            foreach (Programador item in p.Programadores)
            {
                if (item.Edad >= 18 && item.Edad <= 24)
                {
                    contador1++;
                }
                else if (item.Edad > 24 && item.Edad <= 34)
                {
                    contador2++;
                }
                else if (item.Edad > 34 && item.Edad <= 44)
                {
                    contador3++;
                }
                else if (item.Edad > 44)
                {
                    contador4++;
                }
            }
            sb.AppendLine($"Cantidad programadores rango etario de 18 a 24: {contador1}");
            sb.AppendLine($"Cantidad programadores rango etario de 25 a 34: {contador2}");
            sb.AppendLine($"Cantidad programadores rango etario de  35 a 44: {contador3}");
            sb.AppendLine($"Cantidad programadores mayores de 45: {contador4}");

            return sb.ToString();
        }
        #endregion
        public void InformeGeneral(Proyecto p)
        {
            Texto t = new Texto();
            do
            {
                evento("Cargando datos...");
                Thread.Sleep(500);
                evento(RangosEtarios(p));
                Thread.Sleep(2000);
                evento("Cargando datos...");
                Thread.Sleep(500);
                evento(ProgramadoresPorPuesto(p));
                Thread.Sleep(2000);
                evento("Guardando informe...");
                Extensores.GuardarInformes(p);
                Thread.Sleep(500);
                evento("Informe guardado.");
                break;
            } while (true); 
        }
    }
}
