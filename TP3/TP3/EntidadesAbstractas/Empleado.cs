using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Sector { Programador, RRHH}
    public enum Genero { Femenino, Masculino, NoBinario}
    public abstract class Empleado
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private float sueldo;
        private Genero genero;

        public string LegajoString { set => this.legajo = ValidarLegajo(value); }
        public int Legajo { get => this.legajo; }
        public string Nombre
        {
            get => nombre;
            set
            {
                if (ValidarNombreApellido(value) != String.Empty)
                {
                    this.nombre = value;
                }
            }
        }
        public string Apellido 
        {   get => apellido;
            set
            {
                if (ValidarNombreApellido(value) != String.Empty)
                {
                    this.apellido = value;
                }
            }
        }
        public string SueldoString { set => sueldo = ValidarSueldo(value); }
        public Genero GetGenero { get => genero; set => genero = value; }
        public abstract Sector Tipo { get; }
        public Empleado(string nombre,string apellido,Genero genero)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.genero = genero;
        }
        public Empleado(int legajo, string nombre, string apellido, float sueldo, Genero genero)
            :this(nombre, apellido,genero)
        {
            this.legajo = legajo;
            this.sueldo = sueldo;
        }
        public Empleado(string legajo, string nombre, string apellido, string sueldo, Genero genero)
            : this(nombre,apellido,genero)
        {
            this.LegajoString = legajo;
            this.SueldoString = sueldo;
        }
        public static bool operator == (Empleado empleadoA, Empleado empleadoB)
        {
            bool retorno = false;
            if (empleadoA.legajo == empleadoB.legajo)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Empleado empleadoA, Empleado empleadoB)
        {
            return !(empleadoA == empleadoB);
        }
        public override bool Equals(object obj)
        {
            if (this.GetType() == obj.GetType())
            {
                return true;
            }
            return false;
        }
        public virtual string MostrarEmpleado()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"[Legajo] {this.legajo}");
            sb.AppendLine($"[Nombre y apellido] {this.nombre + ' ' + this.apellido}");
            sb.AppendLine($"[Genero] {this.genero}");
            sb.AppendLine($"[Sueldo] ${this.sueldo}");
            
            return sb.ToString();
        }
        private string ValidarNombreApellido(string dato)
        {
            foreach (char item in dato)
            {
                if (!Char.IsLetter(item) || Char.IsWhiteSpace(item))
                {
                    return String.Empty;
                }
            }
            return dato;
        }
        public int ValidarLegajo(string dato)
        {
            if (int.TryParse(dato, out int retorno))
            {
                return retorno;
            }
            else
            {
                throw new LegajoValidarException();
            }
        }
        private float ValidarSueldo(string dato)
        {
            if(float.TryParse(dato, out float retorno))
            {
                return retorno;
            }
            else
            {
                throw new SueldoValidarException();
            }
        }
    }
}
