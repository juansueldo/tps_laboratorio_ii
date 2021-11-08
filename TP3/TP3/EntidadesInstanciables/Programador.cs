using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Tipo { FontEnd, BackEnd}
    public class Programador : Empleado
    {
        public Tipo tipo;

        public Programador(string legajo, string nombre, string apellido, string sueldo,Genero genero,Tipo tipo) 
            : base(legajo, nombre, apellido, sueldo,genero)
        {
            this.tipo = tipo;
        }
        public override Sector Tipo
        {
            get
            {
                return Sector.Programador;
            }
        }
        public Tipo GetTipo
        {
            get
            {
                return this.tipo;
            }
        }
        public override string MostrarEmpleado()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarEmpleado());
            sb.AppendLine($"[Puesto] Programador [Sector] {this.GetTipo}");

            return sb.ToString();
        }
    }
}
