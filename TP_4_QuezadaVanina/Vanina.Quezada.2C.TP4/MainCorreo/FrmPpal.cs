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
        /// <summary>
        /// Agrega el paquete a la lista en el correo, asocia el metodo paq_InformaEstado 
        /// al evento InformarEstado y actualiza los estados de los paquetes
        /// </summary>

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
        /// <summary>
        /// On click del boton btnMostrarTodos llama al metodo MostrarInformacion para mostra los datos
        /// </summary>

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
          this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }
        /// <summary>
        /// Llama al metodo correo.FinEntregas(); para finalizar todos los hilos
        /// </summary>

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
                   correo.FinEntregas();
        }
        /// <summary>
        /// Muestra los datos de los paquetes en rtbMostrar y guarda los datos en un archivo
        /// </summary>

        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            
            if (elemento != null)
            {
                string datos = elemento.MostrarDatos(elemento);
                rtbMostrar.Text = datos;
                GuardaString.Guardar(datos, "salida.txt");
            }

        }
        /// <summary>
        /// Se cra un delegado se le asigna el metodo paq_InformaEstado y se lo ejecuta
        /// </summary>

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
        /// <summary>
        /// Muestra la informacion al apretar el boton mostrar del listbox 
        /// </summary>
 
        private void mostrarToolStripMenuItem(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }
        /// <summary>
        /// Limpia los datos de los listbox y actualiza y muestra los datos en estos
        /// </summary>
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
