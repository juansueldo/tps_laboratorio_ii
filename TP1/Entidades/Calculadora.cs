using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public static class Calculadora
    {
        #region Metodos
        /// <summary>
        /// Realiza la operación ingresada entre los dos numeros ingresados
        /// </summary> 
        /// <param name="num1">Primer dato recibido</param>
        /// <param name="num2">Segundo dato recibido</param>
        /// <param name="operador">Operacion a realizar</param>
        /// <returns>Retorna el resultado de la operación</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double retorno = 0;
            switch (Calculadora.ValidarOperando(operador))
            {
                case '+':
                    retorno = num1 + num2;
                    break;
                case '-':
                    retorno = num1 - num2;
                    break;
                case '*':
                    retorno = num1 * num2;
                    break;
                case '/':
                    retorno = num1 / num2;
                    break;
                default:
                    break;
            }
            return retorno;
        }
        /// <summary>
        /// Valida el operador ingresado
        /// </summary>
        /// <param name="operador">Operador a validar</param>
        /// <returns>Retorna el operador ingresado si este es valido, en caso de no serlo retornara "+"</returns>
        private static char ValidarOperando(char operador)
        {
            if(operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                return operador;
            }
            else
            {
                return '+';
            }
        }
        #endregion
    }
}
