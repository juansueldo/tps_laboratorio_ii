using System;
using Entidades;

namespace TestTP4
{
    class Program
    {
        static void Main(string[] args)
        {
            Proyecto proyecto = new Proyecto("Final Fantasy XVI", 5, GeneroJuego.RPG, DateTime.Today);
            Proyecto proyecto2 = new Proyecto();
            Programador p1 = new Programador(1, "Juan", "Sueldo", Genero.Masculino, 32, Puesto.Tester);
            Programador p2 = new Programador(2, "Tetsuya", "Nomura", Genero.Masculino, 51, Puesto.Designer);
            Programador p3 = new Programador(3, "Hironobu", "Sakaguchi", Genero.Masculino, 58, Puesto.Designer);
            Programador p4 = new Programador(4, "Yoshitaka", "Amano", Genero.Masculino, 69, Puesto.Artist);
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Proyecto.json";
            try
            {
                proyecto += p1;
            }
            catch(ProgramadorException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                proyecto += p2;
            }
            catch (ProgramadorException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                proyecto += p3;
            }
            catch (ProgramadorException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                proyecto += p4;
            }
            catch (ProgramadorException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                proyecto += p1;
            }
            catch (ProgramadorException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Console.WriteLine(proyecto.MostrarProyecto());
            try
            {
                SerializarAJson.Serializar(ruta, proyecto);
                Console.WriteLine("Projecto guardado");
            }
            catch(SerializarException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            try
            {
                proyecto2 = SerializarAJson.Deserializar<Proyecto>(ruta);
            }
            catch (SerializarException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(proyecto2.MostrarProyecto());
            Console.ReadKey();
        }
    }
}
