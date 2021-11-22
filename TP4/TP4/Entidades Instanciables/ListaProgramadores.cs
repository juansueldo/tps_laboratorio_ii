using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ListaProgramadores
    {
        
        private List<Programador> programadores;
        private int cantidad;

        public List<Programador> Programadores { get => programadores; set => programadores = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public ListaProgramadores()
        {
            Programadores = new List<Programador>();
        }
        public ListaProgramadores(int cantidad) : this()
        {
            this.Cantidad = cantidad;
        }
        public static bool operator ==(ListaProgramadores empresa, Programador programador)
        {
            bool retorno = false;
            foreach (Programador item in empresa.Programadores)
            {
                if (item == programador)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(ListaProgramadores empresa, Programador programador)
        {
            return !(empresa == programador);
        }
        public static ListaProgramadores operator +(ListaProgramadores empresa, Programador empleado)
        {
            if(empresa.Cantidad > empresa.Programadores.Count)
            {
                if (empresa == empleado)
                {
                    throw new EmpleadoException("Ya existe el empleado");
                }
                else
                {
                    empresa.programadores.Add(empleado);
                }
            }
            else
            {
                throw new CantidadEmpleadosException("Ya se supero el limite de programadores");
            }
            return empresa;
        }
        public static ListaProgramadores operator -(ListaProgramadores lista, Programador programador)
        {
            if (lista != programador)
            {
                throw new EmpleadoException("No se pudo eliminar al programador");
            }
            else
            {
                lista.Programadores.Remove(programador);
            }
            return lista;
        }
        public string MostrarLista()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Equipo de trabajo");
            foreach(Programador item in this.Programadores)
            {
                sb.AppendLine(item.MostrarDatos());
        
            }
            return sb.ToString();
        }
    }
}
