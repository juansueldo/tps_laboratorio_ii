using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
     
        [TestMethod]
        [ExpectedException(typeof(EmpleadoException))]
        public void TestEmpleadoExist()
        {
            #region Arrange
            Empresa e = new Empresa("Mountain", 1);
            Empleado e1 = new Programador("56", "Juan", "Sueldo", "58930",Genero.Masculino, Tipo.BackEnd);
            Empleado e2 = new RecursosHumanos("67", "Ariel", "Gallardo", "65400",Genero.NoBinario);
            #endregion

            #region Act
            e += e1;
            e += e1;
            
            e -= e1;
            #endregion

            #region Assert
            #endregion

        }
        [TestMethod]
        public void TestEmpresa()
        {
            Empresa empresa = new Empresa(7);

            Assert.IsInstanceOfType(empresa.capacidad, typeof(int));
        }
        [TestMethod]
        public void TestEmpresaLista()
        {
            Empresa empresa = new Empresa();
            Assert.AreNotEqual(null, empresa.empleados);
        }
        
    }
}
