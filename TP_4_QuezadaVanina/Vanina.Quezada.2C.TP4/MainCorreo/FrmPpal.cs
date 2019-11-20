using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainCorreo
{
    public partial class FrmPpal : Form
    {
        private Correo correo;
        public FrmPpal()
        {
            correo = new Correo();
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string direccion = txtDireccion.Text;
            string trackingId = mtxtTrackingID.Text;

            Paquete paquete = new Paquete(direccion,trackingId);
            try
            {
                correo += paquete;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

         //    InformarEstado(paq_InformaEstado);
            
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
          this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
                   correo.FinEntregas();
        }
        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            StringBuilder sb = new StringBuilder();
            if (elemento != null)
            {
                foreach (var item in ((Correo)elemento).Paquetes)
                {
                    sb.AppendLine(item.MostrarDatos(item));
                }

                rtbMostrar.Text = sb.ToString();
            }

        }
        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
            //    Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
            //     this.Invoke(d, new object[] { sender, e });
            }
            else
            { // Llamar al método }
            //    this.ActualizarEstados();
            }
        }
        private void mostrarToolStripMenuItem(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }
        private void ActualizarEstados(object sender, EventArgs e)
        {

        }


    }
}
