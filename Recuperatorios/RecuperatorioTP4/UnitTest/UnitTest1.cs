using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ProgramadorException))]
        public void TestProgramadorRepetido()
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
        public void TestProgramadoresLista()
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
        public void TestSerializarException()
        {
            #region Arrange
            string ruta = null;
            object objeto = null;
            #endregion

            #region Act
            SerializarAJson.Serializar(ruta, objeto);
            #endregion
        }
        [TestMethod]
        public void TestValidarEdad()
        {
            #region Arrage
            Programador p = new Programador();

            #endregion

            #region Act
            bool repuesta = p.ValidarEdad(18);
            #endregion
            #region Assert
            Assert.IsTrue(repuesta);
            #endregion
        }
        [TestMethod]
        public void TestProgramadorExist()
        {
            #region Arrage
            Programador programador = new Programador(1, "Hideo", "Kojima", Genero.Masculino, 52, Puesto.Designer);
            Proyecto proyecto = new Proyecto("Metal Gear", 1, GeneroJuego.SHOOTER, System.DateTime.Today);
            #endregion

            #region Act
            bool repuesta = proyecto == programador;
            bool respuesta2 = proyecto != programador;
            #endregion

            #region Assert
            Assert.IsFalse(repuesta);
            Assert.IsTrue(respuesta2);
            #endregion
        }
        
    }
}
