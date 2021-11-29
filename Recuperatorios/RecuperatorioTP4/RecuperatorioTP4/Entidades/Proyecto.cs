using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum GeneroJuego { RPG, SHOOTER, ROGUELIKE}
    public class Proyecto
    {
        #region Atributos
        private string nombre;
        private int id;
        private GeneroJuego generoJuego;
        private List<Programador> programadores;
        private DateTime fechaLanzamiento;
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        public List<Programador> Programadores { get => programadores; set => programadores = value; }
        public DateTime FechaLanzamiento { get => fechaLanzamiento; set => fechaLanzamiento = value; }
        public GeneroJuego GeneroJuego { get => generoJuego; set => generoJuego = value; }
        #endregion

        #region Constructores
        public Proyecto(string nombre, int id, GeneroJuego generoJuego, DateTime fechaLanzamiento) : this()
        {
            this.nombre = nombre;
            this.id = id;
            this.generoJuego = generoJuego;
            this.fechaLanzamiento = fechaLanzamiento;
        }
        public Proyecto()
        {
            Programadores = new List<Programador>();
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Proyecto proyecto, Programador programador)
        {
            bool retorno = false;
            foreach(Programador item in proyecto.Programadores)
            {
                if(item == programador)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Proyecto proyecto, Programador programador)
        {
            return !(proyecto == programador);
        }
        public static Proyecto operator +(Proyecto proyecto, Programador programador)
        {
            if(proyecto != programador)
            {
                proyecto.Programadores.Add(programador);
            }
            else
            {
                throw new ProgramadorException("Ya existe el programador en el equipo");
            }
            return proyecto;
        }
        public static Proyecto operator -(Proyecto proyecto, Programador programador)
        {
            if(proyecto == programador)
            {
                proyecto.Programadores.Remove(programador);
            }
            else
            {
                throw new ProgramadorException("No existe el programador en el equipo");
            }
            return proyecto;
        }
        #endregion

        #region Metodos
        public string MostrarProyecto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre del proyecto {this.Nombre}");
            sb.AppendLine($"ID {this.Id}");
            sb.AppendLine($"Genero {this.GeneroJuego}");
            sb.AppendLine($"Fecha de lanzamiento {this.FechaLanzamiento}");
            sb.AppendLine("EQUIPO:\n");
            foreach (Programador item in this.Programadores)
            {
                sb.AppendLine($"{item.MostrarProgramador()}");
            }
            return sb.ToString();
        }
        #endregion
    }
}
