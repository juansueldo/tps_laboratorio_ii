using System;
using Entidades;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaProgramadores lista = new ListaProgramadores(3);
            Programador e1 = new Programador("Juan", "Sueldo", Genero.Masculino, Puesto.Designer,1,32);
            Programador e2 = new Programador("Ariel", "Gallardo", Genero.Masculino, Puesto.LevelDesigner,2, 42);
            Programador e3 = new Programador("Yamila", "Sueldo", Genero.Femenino, Puesto.Tester, 3, 20); ;

            try
            {
                lista += e1;
                Console.WriteLine("Se agego el programador a la lista");
            }
            catch (EmpleadoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CantidadEmpleadosException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                lista += e2;
                Console.WriteLine("Se agego el programador a la lista");
            }
            catch (EmpleadoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CantidadEmpleadosException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                lista += e1;
                Console.WriteLine("Se agego al empleado");
            }
            catch (EmpleadoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CantidadEmpleadosException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(lista.MostrarLista());
            try
            {
                lista -= e3;
                Console.WriteLine("Se elimino al programador");
            }
            catch (EmpleadoException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                lista -= e1;
                Console.WriteLine("Se elimino el empleado");
            }
            catch (EmpleadoException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                SerializarAJson.Serializar("ListaProgramadores.json",lista);
                Console.WriteLine("Datos Guardados");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
