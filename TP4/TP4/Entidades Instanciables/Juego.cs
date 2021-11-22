using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public enum GeneroJuego { Shooter, RPG, Roguelike }
    public delegate void delegado(string dato);
    
    public class Juego
    {
        public event delegado EventoString;
        private string nombre;
        private DateTime fechaLanzamiento;
        private int idSoftware;
        private GeneroJuego generoJuego;
        private List<Programador> programadores;
        
        public Juego(string nombre, DateTime fechaLanzamiento, int idSoftware, GeneroJuego generoJuego) : this()
        {
            this.nombre = nombre;
            this.fechaLanzamiento = fechaLanzamiento;
            this.idSoftware = idSoftware;
            this.generoJuego = generoJuego;
        }
        public Juego()
        {
            programadores = new List<Programador>();
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaLanzamiento { get => fechaLanzamiento; set => fechaLanzamiento = value; }
        public int IdSoftware { get => idSoftware; set => idSoftware = value; }
        public GeneroJuego GeneroJuego { get => generoJuego; set => generoJuego = value; }
        public List<Programador> Programadores
        {
            get => programadores;
            set
            {
                programadores = value;
            }
        }

        public static bool operator ==(Juego juego, Programador programador)
        {
            bool retorno = false;
            foreach (Programador item in juego.Programadores)
            {
                if (item == programador)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Juego juego, Programador programador)
        {
            return !(juego == programador);
        }
        public static Juego operator +(Juego juego, Programador programador)
        {
            if (juego == programador)
            {
                throw new EmpleadoException("Ya existe el programador");
            }
            else
            {
                juego.Programadores.Add(programador);
            }
            return juego;
        }
        public static bool operator ==(Juego j1, Juego j2)
        {
            bool retorno = false;
            if (j1.idSoftware == j2.idSoftware)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Juego j1, Juego j2)
        {
            return !(j1 == j2);
        }
        public string MostrarDatosJuego()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Fecha de lanzamiento: {this.FechaLanzamiento}");
            sb.AppendLine($"Genero: {this.GeneroJuego}");
            sb.AppendLine($"Equipo de trabajo:");
            foreach(Programador item in this.Programadores)
            {
                sb.AppendLine($"{item.MostrarDatos()}");
            }
            return sb.ToString();
        }
    }
}
