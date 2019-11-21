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
                MessageBox.Show(ex.Message,"Paquete repetido",MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            paquete.InformarEstado += paq_InformaEstado;
           
               this.ActualizarEstados();

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
            
            if (elemento != null)
            {
                string datos = elemento.MostrarDatos(elemento);
                rtbMostrar.Text = datos;
                GuardaString.Guardar(datos, "salida.txt");
            }

        }
        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstados();
            }
        }
        private void mostrarToolStripMenuItem(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }

        private void ActualizarEstados()
        {
            this.lstEstadoIngresado.Items.Clear();
            this.lstEstadoEnViaje.Items.Clear();
            this.lstEstadoEntregado.Items.Clear();

            foreach (Paquete item in this.correo.Paquetes)
            {
                switch (item.Estado)
                {
                    case Paquete.EEstado.Ingresado:
                        this.lstEstadoIngresado.Items.Add(item);

                        break;
                    case Paquete.EEstado.EnViaje:
                        this.lstEstadoEnViaje.Items.Add(item);
                        break;
                    case Paquete.EEstado.Entregado:
                        this.lstEstadoEntregado.Items.Add(item);
                        break;

                }
            }

        }
    }
}
