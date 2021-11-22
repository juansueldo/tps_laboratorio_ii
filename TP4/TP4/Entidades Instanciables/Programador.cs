using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Programador : Empleado
    {
        
        public Programador(string nombre, string apellido, Genero genero, Puesto puesto, short legajo, short edad) 
            : base(nombre,apellido,genero,puesto,legajo,edad) 
        {
            
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Tipo: {this.Puesto}");

            return sb.ToString();
        }
    }
}
