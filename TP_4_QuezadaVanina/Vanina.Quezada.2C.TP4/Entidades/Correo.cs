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

        public void FinEntregas() {
            foreach (Thread item in this.mockPaquetes)
            {
                item.Abort();
            }
        }

        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var p in ((Correo)elementos).paquetes)
            {
                sb.AppendLine(string.Format("{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString()));
            }

            return sb.ToString();
        }

        public static Correo operator +(Correo c, Paquete p)
        {
            foreach (var item in c.paquetes)
            {
                if (item == p)
                {
                    throw new TrackingIdRepetidoException("Tracking del paquete esta repetido");
                }
            }
               
            c.paquetes.Add(p);
            Thread hilo = new Thread(p.MockCicloDeVida);
            c.mockPaquetes.Add(hilo);
            hilo.Start();
            return c;
        }

        #endregion
    }
}
