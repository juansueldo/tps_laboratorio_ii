using System;
using Entidades;
namespace TestTP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa = new Empresa("Mountain",3);
            Empleado e1 = new Programador("56", "Juan", "Sueldo", "67890", Genero.Masculino, Tipo.BackEnd);
            Empleado e2 = new RecursosHumanos("67", "Ariel", "Gallardo", "65400",Genero.Masculino);
            Empleado e3 = new Programador("77", "Yamila", "Sueldo", "71900",Genero.Femenino, Tipo.FontEnd);
            
            try
            {
                empresa += e1;
                Console.WriteLine("Se agego al empleado");
            }
            catch(EmpleadoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(CantidadEmpleadosException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                empresa += e2;
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
            try
            {
                empresa += e1;
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
            Console.WriteLine(empresa.MostrarDatos(empresa));
            try
            {
                empresa -= e3;
                Console.WriteLine("Se elimino el empleado");
            }
            catch(EmpleadoException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                empresa -= e1;
                Console.WriteLine("Se elimino el empleado");
            }
            catch (EmpleadoException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Empresa.GuardarDatos(empresa);
                Console.WriteLine("Datos Guardados");      
            }
            catch(ArchivosException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
    }
}
