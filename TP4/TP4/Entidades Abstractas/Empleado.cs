using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Genero { Femenino, NoBinario, Masculino }
    public enum Puesto { Designer, Artist, LevelDesigner,Tester }

    public abstract class Empleado
    {
        private string nombre;
        private string apellido;
        private Genero genero;
        private Puesto puesto;
        private short legajo;
        private short edad;

        public Empleado(string nombre, string apellido, Genero genero, Puesto puesto, short legajo, short edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.genero = genero;
            this.puesto = puesto;
            this.legajo = legajo;
        }

        public string Nombre 
        { get => nombre; 
            set
            {
                if (ValidarNombreApellido(value) != String.Empty)
                {
                    this.nombre = value;
                }
            }
        }
        public string Apellido 
        { get => apellido; 
            set
            {
                if (ValidarNombreApellido(value) != String.Empty)
                {
                    this.apellido = value;
                }
            }
        }
        public Genero Genero { get => genero; set => genero = value; }
        public Puesto Puesto { get => puesto; set => puesto = value; }
        public short Legajo { get => legajo; set => legajo = value; }
        public string EdadString { set => this.Edad = ValidarLegajo(value); }
        public string LegajoString { set => this.legajo = ValidarLegajo(value); }
        public short Edad { get => edad; set => edad = value; }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre completo: {this.Nombre + ' ' + this.Apellido}");
            sb.AppendLine($"Legajo: {this.Legajo}");
            sb.AppendLine($"Edad: {this.Edad}");
            sb.AppendLine($"Genero: {this.Genero}");

            return sb.ToString();
        }
        public static bool operator ==(Empleado e1, Empleado e2)
        {
            bool retorno = false;
            if (e1.legajo == e2.legajo)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }
        public short ValidarLegajo(string dato)
        {
            if (short.TryParse(dato, out short retorno))
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
            if (float.TryParse(dato, out float retorno))
            {
                return retorno;
            }
            else
            {
                throw new SueldoValidarException();
            }
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
    }
}
