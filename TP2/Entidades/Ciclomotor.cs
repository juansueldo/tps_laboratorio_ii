using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        #region "Constructores"
        /// <summary>
        /// Constructor con parametros a asignar
        /// </summary>
        /// <param name="marca">Enumerado que recibe la marca</param>
        /// <param name="chasis">String que recibe el chasis</param>
        /// <param name="color">Enum que recibe el color</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) :base(chasis,marca,color)
        {
        }
        #endregion
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        #region "Propiedades"
        protected override ETamanio Tamanio
        {
            get
            {
                return 0;
            }
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Muestra los datos del cliclomotor
        /// </summary>
        /// <returns>Retorna los datos a mostrar</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
