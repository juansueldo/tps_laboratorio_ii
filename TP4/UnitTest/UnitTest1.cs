using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

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
            ListaProgramadores e = new ListaProgramadores(2);
            Programador e1 = new Programador("Juan", "Sueldo", Genero.Masculino, Puesto.Designer,55,32);
            
            #endregion

            #region Act
            e += e1;
            e += e1;
            #endregion

        }
        [TestMethod]
        public void TestEmpresa()
        {
            #region Arrange
            ListaProgramadores empresa = new ListaProgramadores(7);
            #endregion

            #region Assert
            Assert.IsInstanceOfType(empresa.Cantidad, typeof(int));
            #endregion
        }
        [TestMethod]
        public void TestEmpresaLista()
        {
            #region Arrange
            ListaProgramadores empresa = new ListaProgramadores();
            #endregion

            #region Assert
            Assert.AreNotEqual(null, empresa.Programadores);
            #endregion
        }
        [TestMethod]
        [ExpectedException(typeof(SerializarException))]
        public void ValidarExcepcion()
        {
            #region Arrange
            string ruta = null;
            object objeto = null;
            #endregion

            #region Act
            SerializarAJson.Serializar(ruta, objeto);
            #endregion
        }
    }
}
