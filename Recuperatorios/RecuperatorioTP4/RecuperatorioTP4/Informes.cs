using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Informes
    {
        public int contadorDesigner = 0;
        public int contadorArstist = 0;
        public int contadorTester = 0;
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
        public string ProgramadoresPorPuesto(Proyecto p)
        {
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
    }
}
