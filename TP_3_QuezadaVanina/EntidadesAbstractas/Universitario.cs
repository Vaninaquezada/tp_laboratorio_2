using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        #region Constructores
        public Universitario()
        { }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;

        }
        #endregion
        #region Metodos

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool same = false;
            if (this.GetType().Equals(obj.GetType()))
            {
                same = true;
            }
            return same;
        }

        /// <summary>
        /// Muestra datos del universitario en string
        /// </summary>
        /// <returns>datos del universitario en string</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendFormat("LEGAJO NÚMERO: {0} \n", this.legajo);

            return sb.ToString();
        }

        protected abstract string ParticiparEnClase();


        /// <summary>
        /// Compara 2 universitarios. Dos Universitario serán iguales si y sólo si son del mismo Tipo y su Legajo o DNI son iguales.
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns> bool </returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
           
            if (pg1.Equals(pg2))
            {
                if ((pg1.DNI == pg2.DNI) || (pg1.legajo == pg2.legajo))
                {
                    return true;
                }
            }
            return false;


        }
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        #endregion

    }
}
