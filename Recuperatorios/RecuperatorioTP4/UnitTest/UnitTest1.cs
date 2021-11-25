using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ProgramadorException))]
        public void TestEmpleadoExist()
        {
            #region Arrange
            Proyecto e = new Proyecto();
            Programador e1 = new Programador(1,"Hideo","Kojima",Genero.Masculino,52,Puesto.Designer);

            #endregion

            #region Act
            e += e1;
            e += e1;
            #endregion

        }
        [TestMethod]
        public void TestEmpresaLista()
        {
            #region Arrange
            Proyecto proyecto = new Proyecto();
            #endregion

            #region Assert
            Assert.AreNotEqual(null, proyecto.Programadores);
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
