using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo on CLick del boton Operar, realiza la operacion seleccionada
        /// </summary>

        private void btnOperar_Click(object sender, EventArgs e)
        {
            
                string numero2 = txtNumero2.Text;
                string numero1 = txtNumero1.Text;
                string operador;

            // Si se ingresa un operador no valido, primero se calcula el resultado y despues se modifica el operador al operador por default + 
            if (cmbOperador.SelectedIndex == -1)
                {
                    operador = cmbOperador.SelectedText;
                    lblResultado.Text = Operar(numero1, numero2, operador).ToString();

                    cmbOperador.SelectedIndex = 2;
                }
                else
                {
                    operador = cmbOperador.SelectedItem.ToString();
                    lblResultado.Text = Operar(numero1, numero2, operador).ToString();
                }

         }
        /// <summary>
        /// Metodo on CLick del boton Limpiar, llama al metodo privado Limpiar() y borra el contenido del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Metodo privado Limpiar borra el contenido del label resultado, del combobox selector de la operacion y los textbox de numeros 
        /// </summary>
        private void Limpiar()
        {
            lblResultado.Text = "";
            txtNumero2.Text = "";
            txtNumero1.Text = "";
            cmbOperador.SelectedIndex = -1;
        }
        /// <summary>
        /// Metodo que realiza la operacion seleccionada
        /// </summary>
        /// <param name="numero1">String numero con el se opera</param>
        /// <param name="numero2">tring numero con el se opera</param>
        /// <param name="operador">Operaracion a realizar</param>
        /// <returns>Resultado de la operacion realizada</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Calculadora calculadora = new Calculadora();
            return calculadora.Operar(new Numero(numero1), new Numero(numero2), operador);

        }
        /// <summary>
        /// Metodo on CLick del boton Cerrar, cierra el formulario llamando al metodo de la lase Form Close()
        /// </summary>

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Metodo que conbierte el resltado en numero binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string resultado = lblResultado.Text;
            Numero num = new Numero(resultado);
            lblResultado.Text = num.DecimalBinario(resultado);
        }
        /// <summary>
        /// Metodo que conbierte el resultado en decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero num = new Numero(lblResultado.Text);
            lblResultado.Text = num.BinarioDecimal(lblResultado.Text);
        }
    }

    }
