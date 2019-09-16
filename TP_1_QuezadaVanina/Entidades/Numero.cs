using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Numero
    {
        private double numero;

        private string SetNumero { set { this.numero = validarNumero(value); } }
        #region Constructores

        public Numero() : this(0)
        { }
        public Numero(double numero)
        {
            this.numero = numero;
        }
        public Numero(string numero)
        {
            this.SetNumero = numero;
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Valida que el valor de strNumero sea numerico
        /// </summary>
        /// <param name="strNumero">numero en formato string</param>
        /// <returns>numero validado en formato double, si no se pudo validar el numero devuelve 0</returns>
        private double validarNumero(string strNumero)
        {
            double salida = 0;

            if (double.TryParse(strNumero, out salida))
            { return salida; }
            else
            { return salida;}
        }

        /// <summary>
        /// se trata de parsear el numero a double, si se puede se llama a DecimalBinario(double numero)
        /// </summary>
        /// <param name="numero">string numero a parsear</param>
        /// <returns>retorna el nuemro pasado de decimal a bienario o un mensaje si no se pudo convertir</returns>
        public string DecimalBinario(string numero)
        {
            double num;
            
            if (Double.TryParse(numero, out num))
            {

                return DecimalBinario(num);

            }
            else
            {
                return "Valor inválido";
            }

        }

        /// <summary>
        /// convierte nuemro de decimal a binario
        /// </summary>
        /// <param name="numero">numero decima a convertir en binario</param>
        /// <returns>Retorna numero convertido a binario</returns>
        public string DecimalBinario(double numero)
        {
            return Convert.ToString(Convert.ToInt64(numero), 2);


        }
        /// <summary>
        /// Transforna nuemro binario a decimal
        /// </summary>
        /// <param name="binario">nuemro binario</param>
        /// <returns>retorna nuemro decimal, sino pudo tranformar el nuemero retorna mesaje</returns>
        public string BinarioDecimal(string binario)
        {

            long num = 0, i = 0, remainder, decimalNumber = 0;
            if (Int64.TryParse(binario, out num))
            {
                while (num != 0)
                {
                    remainder = num % 10;
                    num /= 10;
                    decimalNumber += remainder * (int)Math.Pow(2, i);
                    ++i;
                }

                return decimalNumber.ToString();

            }
            else
            {
                return "Valor inválido";
            }
        }
        #endregion
        #region Sobrecargas
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecarga que realiza la operacion division
        /// </summary>
        /// <param name="n1">numero a dividir </param>
        /// <param name="n2">numero divisor</param>
        /// <returns>Retorna resultado de la divicion si el numero2 es 0 retorna double.MinValue </returns>
        public static double operator /(Numero n1, Numero n2)
        {
            // Si se divide por 0 se devuelve double.MinValue
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }
        #endregion
    }
}

