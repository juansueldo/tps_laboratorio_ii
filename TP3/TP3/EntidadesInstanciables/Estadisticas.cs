using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estadisticas
    {
        public int cantidadProgramadores;
        public int cantidadRRHH;

        public string CantidadEmpleadosPorGenero(Empresa empresa)
        {
            StringBuilder sb = new StringBuilder();
            int femenino = 0;
            int masculino = 0;
            int noBinario = 0;
            foreach (Empleado item in empresa.empleados)
            {
                if (item.GetGenero is Genero.Femenino)
                {
                    femenino++;
                }
                else if (item.GetGenero is Genero.Masculino)
                {
                    masculino++;
                }
                else
                {
                    noBinario++;
                }
            }
            sb.AppendLine($"Empleados genero no binario: {noBinario}");
            sb.AppendLine($"Empleados genero femenino: {femenino}");
            sb.AppendLine($"Empleados genero masculino: {masculino}");
            return sb.ToString();
        }
        public string EmpleadosPorSector(Empresa empresa)
        {
            StringBuilder sb = new StringBuilder();
            int programadores = 0;
            int rrhh = 0;
            foreach (Empleado item in empresa.empleados)
            {
                if (item.Tipo is Sector.Programador)
                {
                    programadores++;
                }
                else
                {
                    rrhh++;
                }
            }
            sb.AppendLine($"Cantidad Programadores: {programadores}");
            sb.AppendLine($"Cantidad RRHH: {rrhh}");
            return sb.ToString();
        }
    }
}
