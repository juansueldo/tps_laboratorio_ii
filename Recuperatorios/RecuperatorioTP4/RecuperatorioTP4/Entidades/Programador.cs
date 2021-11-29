using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Genero { Femenino, NoBinario, Masculino}
    public enum Puesto { Designer, Artist, Tester}
    public class Programador
    {
        #region Atributos
        private string nombre;
        private string apellido;
        private Genero genero;
        private Puesto puesto;
        private short legajo;
        private short edad;
        #endregion

        #region Constructor
        public Programador(short legajo, string nombre, string apellido, Genero genero, short edad, Puesto puesto)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.genero = genero;
            this.legajo = legajo;
            this.edad = edad;
            this.Puesto = puesto;
        }
        public Programador(string nombre, string apellido,Genero genero,Puesto puesto) :this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.genero = genero;
            this.puesto = puesto;
        }
        public Programador() { }
        #endregion

        #region Propiedades
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
        public string Apellido { get => apellido; 
            set
            {
                if (ValidarNombreApellido(value) != String.Empty)
                {
                    this.apellido = value;
                }
            }
        }
        public string EdadString { set => this.Edad = ValidarLegajo(value); }
        public string LegajoString { set => this.legajo = ValidarLegajo(value); }
        public Genero Genero { get => genero; set => genero = value; }
        public short Legajo { get => legajo; set => legajo = value; }
        public short Edad { get => edad;
            set 
            {
                if(ValidarEdad(value))
                {
                    this.edad = value;
                }
                
            } 
        }
        public Puesto Puesto { get => puesto; set => puesto = value; }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Programador p1, Programador p2)
        {
            bool retorno = false;
            if(p1.Legajo == p2.Legajo)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Programador p1, Programador p2)
        {
            return !(p1 == p2);
        }
        #endregion

        #region Metodos
        public string MostrarProgramador()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre completo {this.Nombre +" "+ this.Apellido}");
            sb.AppendLine($"Legajo {this.Legajo}");
            sb.AppendLine($"Genero {this.Genero}");
            sb.AppendLine($"Edad {this.Edad}");
            sb.AppendLine($"Puesto {this.Puesto}");

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
        public short ValidarLegajo(string dato)
        {
            if (short.TryParse(dato, out short retorno))
            {
                return retorno;
            }
            else
            {
                throw new LegajoValidarException("Valor no valido");
            }
        }
        public bool ValidarEdad(short dato)
        {
            bool retorno = false;
            if(dato >= 18 && dato <= 65)
            {
                retorno = true;
            }
            else
            {
                throw new EdadException("Edad no valida");
            }
            return retorno;
        }
        #endregion
    }
}
