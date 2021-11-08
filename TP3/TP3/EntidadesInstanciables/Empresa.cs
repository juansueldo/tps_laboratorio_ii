using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empresa
    {
        public string nombre;
        public List<Empleado> empleados;
        public int capacidad;

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Empleado> Empleados { get => empleados; set => empleados = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }

        public Empresa(int cantidad) : this() { }
        public Empresa(string nombre, int cantidad) : this(cantidad)
        {
            this.Nombre = nombre;

        }
        public Empresa()
        {
            this.empleados = new List<Empleado>();
        }

        public string MostrarDatos(Empresa empresa)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("--------------------------");
            sb.AppendLine($"{empresa.Nombre}");
            sb.AppendLine($"Cantidad de empleados: {empresa.empleados.Count}");
            sb.AppendLine("--------------------------");
            foreach (Empleado item in empresa.empleados)
            {
                sb.AppendLine($"{item.MostrarEmpleado()}");
                sb.AppendLine("--------------------------");
            }
            return sb.ToString();
        }

        public static bool operator ==(Empresa empresa, Empleado empleado)
        {
            bool retorno = false;
            foreach (Empleado item in empresa.empleados)
            {
                if (item.Equals(empleado) && item == empleado)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Empresa empresa, Empleado empleado)
        {
            return !(empresa == empleado);
        }
        public static Empresa operator +(Empresa empresa, Empleado empleado)
        {
            if (empresa.capacidad > empresa.empleados.Count)
            {
                throw new CantidadEmpleadosException("Ya se alcanzo la cantidad limite de empleados");
            }
            else
            {
                if (empresa == empleado)
                {
                    throw new EmpleadoException("Ya existe el empleado");
                }
                else
                {
                    empresa.empleados.Add(empleado);
                }
            }
            return empresa;
        }
        public static Empresa operator -(Empresa empresa, Empleado empleado)
        {
             if (empresa != empleado)
             {
                throw new EmpleadoException("No se pudo eliminar al empleado");
             }
             else
             {
                empresa.empleados.Remove(empleado);
             }
            return empresa;
        }
        public static void GuardarDatos(Empresa empresa)
        {
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), String.Format(@"Empresa.xml", empresa));
            Xml<Empresa>.SerializarAXml(empresa, ruta);
        }
        
    }
}
