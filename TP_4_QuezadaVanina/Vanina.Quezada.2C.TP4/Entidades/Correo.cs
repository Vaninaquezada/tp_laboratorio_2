using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Correo :IMostrar<List<Paquete>>
    {
        private List<Thread> mockPaquetes;

        private List<Paquete> paquetes;

        public List<Paquete> Paquetes
        {
            get { return paquetes; }
            set { paquetes = value; }
        }

        public Correo()
        {
            this.mockPaquetes = new List<Thread>();
            this.paquetes = new List<Paquete>();
        }

        #region Metodos
        /// <summary>
        /// Finaliza todos los hilos de la lista mockPaquetes
        /// </summary>
        public void FinEntregas() {
            foreach (Thread item in this.mockPaquetes)
            {
                item.Abort();
            }
        }
        /// <summary>
        /// Muestra los datos de la lista de paquetes
        /// </summary>
        /// <param name="elementos"></param>
        /// <returns>string con los datos</returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Paquete p in ((Correo)elementos).paquetes)
            {
                sb.AppendLine(string.Format("{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString()));
            }

            return sb.ToString();
        }
        /// <summary>
        /// Agrega un paquete a al correo, crea einicializa un hilo y lo agrega a la lista de hilos
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Correo operator +(Correo c, Paquete p)
        {
            foreach (Paquete item in c.paquetes)
            {
                if (item == p)
                {
                    throw new TrackingIdRepetidoException(string.Format("El Tracking ID {0} ya figura en la lista de envios",item.TrackingID));
                }
            }
            try
            {
                c.paquetes.Add(p);
                Thread hilo = new Thread(p.MockCicloDeVida);
                c.mockPaquetes.Add(hilo);
                hilo.Start();
                return c;
            }
            catch (Exception e)
            {

                throw e;
            }  

        }

        #endregion
    }
}
