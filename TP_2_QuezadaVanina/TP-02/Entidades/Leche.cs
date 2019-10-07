using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2018
{
   public class Leche : Producto
    {
        public enum ETipo { Entera, Descremada }
        ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca">marca de la leche tipo EMarca</param>
        /// <param name="codigo">codigo de la leche de tipo string</param>
        /// <param name="color">color del empaque de tipo console color</param>
        ///<param name="tipo">tipo de la leche tipo ETipo</param>
        public Leche(EMarca marca, string codigo, ConsoleColor color)
            : this(marca, codigo, color, ETipo.Entera)
        {   }
        public Leche(EMarca marca, string codigo, ConsoleColor color,ETipo tipo)
           : base(codigo, marca, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }
        /// <summary>
        /// Formatea los datos de la clase leche y la clase base en string 
        /// </summary>
        /// <returns>los datos en string</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("CALORIAS : {0}\r\n", this.CantidadCalorias);
            sb.AppendFormat("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
