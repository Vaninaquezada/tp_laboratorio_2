using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        #region Metodos
        /// <summary>
        /// Valida y realizada la operacion recibida 
        /// </summary>
        /// <param name="num1">Primer Numero a operar</param>
        /// <param name="num2">Segundo Numero a operar</param>
        /// <param name="operador">Reperacion a realizar</param>
        /// <returns>Resultado de operacion realizada</returns>
        public double Operar(Numero num1, Numero num2,string operador)
        {
            double resultado = 0;
            switch (ValidarOperador(operador)){
                case "*" :
                    resultado = num1 * num2;

                    break;
                case "/":
                    resultado = num1 / num2;

                    break;
                case "+":
                    resultado = num1 + num2;

                    break;
                case "-":
                    resultado = num1 - num2;

                    break;

            }

            return resultado;

        }
        /// <summary>
        /// Valida que el operador recibido sea *,/,+,-. 
        /// </summary>
        /// <returns>Retorna el operador validado. Si el el operador no es valido retorna +</returns>
        public static string ValidarOperador(string operador) {




            if (operador =="+"|| operador == "*"|| operador == "/"|| operador == "-")
            {
                return operador;
            }
            else
            {

                return "+";
            }



        }
        #endregion
    }
}
