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
            return $"Empleados genero no binario {noBinario}, genero femenino {femenino}, genero masculino {masculino}";
        }
        public string EmpleadosPorSector(Empresa empresa)
        {
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
            return $"Cantidad de Programadores {programadores}, cantidad de RRHH {rrhh}";
        }
    }
}
