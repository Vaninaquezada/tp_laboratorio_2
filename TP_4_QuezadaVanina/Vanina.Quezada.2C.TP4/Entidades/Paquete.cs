using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{


    public class Paquete : IMostrar<Paquete>
    {
        public delegate void DelegadoEstado(object estado, EventArgs e);
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;
        public event DelegadoEstado InformarEstado;
        #region Enumerador
            public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }
        #endregion
        #region Propiedades
        public string DireccionEntrega
        {
            get { return direccionEntrega; }
            set { direccionEntrega = value; }
        }
        public EEstado Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public string TrackingID
        {
            get { return trackingID; }
            set { trackingID = value; }
        }

        #endregion

        public Paquete(string direccionEntrega,string trackingID)
        {
            this.direccionEntrega = direccionEntrega;
            this.trackingID = trackingID;
        }
        #region Metodos
        public void MockCicloDeVida()
        {
            while (this.estado != EEstado.Entregado)
            {
                Thread.Sleep(4000);
                this.estado++;

                if (this.InformarEstado != null)
                {
                    this.InformarEstado.Invoke(this.estado, new EventArgs());
                }
                
            }
            try
            {
                    PaqueteDao.Insertar(this);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            Paquete p = (Paquete)elemento;
            return string.Format("{0} para {1}", p.trackingID, p.direccionEntrega);
        }
        public static bool operator ==(Paquete p1,Paquete p2) {

            if (p1.trackingID == p2.trackingID)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Paquete p1, Paquete p2) {
            return !(p1==p2);
        }
        public override string ToString()
        {
            return this.MostrarDatos(this);
        }

        #endregion


    }
}
