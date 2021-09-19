using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        #region Atributos
        private double numero;
        #endregion
        #region Propiedades
        /// <summary>
        /// Propiedad que asigna un valor valido al numero
        /// </summary>
        public string Numero
        {
            set
            {
                numero = ValidarOperando(value);
            }
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Recibe un numero binario de tipo string y devuelve un numero decimal de tipo string
        /// </summary>
        /// <param name="binario">Numero binario recibido</param>
        /// <returns>Retorna el decimal de tipo string si el string ingresado es binario, sino retorna "Valor inválido"</returns>
        public string BinarioDecimal(string binario)
        {
            if (EsBinario(binario) == true)
            {
                double resultado = 0;
                int cantidadCaracteres = binario.Length; 
                foreach (char caracter in binario)
                {
                    cantidadCaracteres--;
                    if (caracter == '1')
                    {
                        resultado += (int)Math.Pow(2, cantidadCaracteres);
                    }
                    
                }
                return resultado.ToString();
            }
            else
            {
                return "Valor inválido";
            }
        }
        /// <summary>
        /// Recibe un numero decimal de tipo double y devuelve un numero binario de tipo string
        /// </summary>
        /// <param name="numero">Numero decimal recibido</param>
        /// <returns>Retorna el numero binario de tipo string si se realizo la conversion, sino retorna "Valor inválido"</returns>
        public string DecimalBinario(double numero)
        {
            int auxNumero = (int)numero;
            while (auxNumero < 0)
            {
                auxNumero *= -1;
            }
            if (auxNumero > 0)
            {
                string resultado = "";
                do
                {
                    resultado = (auxNumero % 2) + resultado;
                    auxNumero = (int)auxNumero / 2;
                } while (auxNumero > 0);

                return resultado;
            }
            else
            {
                return "Valor inválido";
            }    
          
        }
        /// <summary>
        /// Recibe un numero decimal de tipo string y lo convierte en un numero binario de tipo string
        /// </summary>
        /// <param name="numero">Numero decimal recibido</param>
        /// <returns>Retorna el numero binario de tipo string, sino se pudo realizar la conversion retorna "Valor inválido"</returns>
        public string DecimalBinario(string numero)
        {
            if (!double.TryParse(numero, out double auxNumero))
            {
                return "Valor inválido";
            }
            return DecimalBinario(auxNumero);
        }
        /// <summary>
        /// Recibe un numero binario de tipo string y verifica si este es binario o no
        /// </summary>
        /// <param name="binario">Numero binario recibido</param>
        /// <returns>Retorna true si el numero es binario y false si no se trata de un binario</returns>
        private bool EsBinario(string binario)
        {
            bool retorno = true;
            foreach (char item in binario)
            {
                if(item != '0' && item != '1')
                {
                    retorno = false;
                }
            }
            return retorno;
        }
        #endregion
        #region Constructores
        /// <summary>
        /// Constructor por defecto que asignara 0 al atributo numero
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Constructor con parametro double para asignar 
        /// </summary>
        /// <param name="numero">Numero double recibido</param>
        public Operando(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Constructor con parametro string para asignar
        /// </summary>
        /// <param name="strNumero">Numero string recibido</param>
        public Operando(string strNumero) : this()
        {
            Numero = strNumero;
        }
        #endregion
        #region Sobrecargas
        /// <summary>
        /// Sobre carga del operador "-", realiza la resta entre dos numeros
        /// </summary>
        /// <param name="n1">Primer numero recibido</param>
        /// <param name="n2">Segundo numero recibido</param>
        /// <returns>Retorna el resultado de la resta entre los dos numeros</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// Sobre carga del operador "*", realiza la multiplicacion entre dos numeros
        /// </summary>
        /// <param name="n1">Primer numero recibido</param>
        /// <param name="n2">Segundo numero recibido</param>
        /// <returns>Retorna el resultado de la multiplicacion entre los dos numeros</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        /// <summary>
        /// Sobre carga del operador "/", realiza la division entre dos numeros
        /// </summary>
        /// <param name="n1">Primer numero recibido</param>
        /// <param name="n2">Segundo numero recibido</param>
        /// <returns>Retorna el resultado de la division entre los dos numeros, si el segundo numero es cero retorna "double.MiValue"</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }

        }
        /// <summary>
        /// Sobrecarga del operador "+", realiza la suma entre dos numeros
        /// </summary>
        /// <param name="n1">Primer numero recibido</param>
        /// <param name="n2">Segundo numero recibido</param>
        /// <returns>Retorna el resultado de la suma entre los dos numeros</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        #endregion
        #region Validaciones
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarOperando(string strNumero)
        {
            double retorno;
            if (double.TryParse(strNumero, out retorno))
            {
                return retorno;
            }
            else
            {
                return 0;
            }
        }
        #endregion
    }
}
