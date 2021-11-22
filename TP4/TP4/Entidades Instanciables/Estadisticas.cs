using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Estadisticas
    {
        public int contadorDesigner = 0;
        public int contadorArstist = 0;
        public int contadorLevelDesigner = 0;
        public int contadorTester = 0;
        public int ProgramadoresFemeninos(Juego lp)
        {
            int contador = 0;
            foreach(Programador item in lp.Programadores)
            {
                if(item.Genero is Genero.Femenino)
                {
                    contador++;
                }
            }
            return contador;
        }
        public int ProgramadoresNoBinario(Juego lp)
        {
            int contador = 0;
            foreach (Programador item in lp.Programadores)
            {
                if (item.Genero is Genero.NoBinario)
                {
                    contador++;
                }
            }
            return contador;
        }
        public int ProgramadoresMasculinos(Juego lp)
        {
            int contador = 0;
            foreach (Programador item in lp.Programadores)
            {
                if (item.Genero is Genero.Masculino)
                {
                    contador++;
                }
            }
            return contador;
        }
        public string ProgramadoresPorPuesto(Juego lp)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Programador item in lp.Programadores)
            {
                if (item.Puesto is Puesto.Designer)
                {
                    contadorDesigner++;
                }
                else if (item.Puesto is Puesto.Artist)
                {
                    contadorArstist++;
                }
                else if (item.Puesto is Puesto.LevelDesigner)
                {
                    contadorLevelDesigner++;
                }
                else
                {
                    contadorTester++;
                }
            }
                sb.AppendLine($"Cantidad Designer: {contadorDesigner}");
                sb.AppendLine($"Cantidad Artist: {contadorArstist}");
                sb.AppendLine($"Cantidad Level Designer: {contadorLevelDesigner}");
                sb.AppendLine($"Cantidad Testers: {contadorTester}");

                return sb.ToString();
            }
        public string PromedioEdades(Juego lp)
        {
            float promedioDesigner;
            float promedioArtist;
            float promedioLevelDesigner;
            float promedioTester;
            int acumuladorDesigner = 0;
            int acumuladorArtist = 0;
            int acumuladorLevelDesigner = 0;
            int acumuladorTester = 0;
            StringBuilder sb = new StringBuilder();
            foreach (Programador item in lp.Programadores)
            {
                if (item.Puesto is Puesto.Designer)
                {
                    acumuladorDesigner += item.Edad;
                    contadorDesigner++;
                }
                else if (item.Puesto is Puesto.Artist)
                {
                    acumuladorArtist += item.Edad;
                    contadorArstist++;
                }
                else if (item.Puesto is Puesto.LevelDesigner)
                {
                    acumuladorLevelDesigner += item.Edad;
                    contadorLevelDesigner++;
                }
                else
                {
                    acumuladorTester += item.Edad;
                    contadorTester++;
                }
            }
                promedioDesigner = (float)acumuladorTester / contadorTester;
                promedioArtist = (float)acumuladorArtist / contadorArstist;
                promedioLevelDesigner = (float)acumuladorLevelDesigner / contadorLevelDesigner;
                promedioTester = (float)acumuladorTester / contadorTester;

                sb.AppendLine($"Promedio edad Designer: {promedioDesigner}");
                sb.AppendLine($"Promedio edad Arstist: {promedioArtist}");
                sb.AppendLine($"Promedio edad Level Designer: {promedioLevelDesigner}");
                sb.AppendLine($"Promedio edad Tester: {promedioTester}");

                return sb.ToString();

        }
    }
}
