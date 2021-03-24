using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjemploPOO.clases;


namespace EjemploPOO
{
    public partial class Form1 : Form
    {
        ClsAutomovil carrito;
        private bool creado;
        public Form1()
        {
            InitializeComponent();
        }

       private void actualizarTablero()
        {
            this.txtVelocidadActual.Text = Convert.ToString(carrito.velocidadActual);
            decimal porcentaje = (Convert.ToDecimal(carrito.velocidadActual) / Convert.ToDecimal(carrito.velocidadMaxima)) * 100;
            this.txtPoder.Text = Convert.ToString(Convert.ToInt32(porcentaje)) + "%";
            this.velocimetro.Value = Convert.ToInt32(porcentaje);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutomovil("BMW", "Rojo", 250);
            this.txtColor.Text = carrito.color;
            this.txtMarca.Text = carrito.marca;
            this.txtEstado.Text = "Autmomovil Creado";
            this.txtVelocidadMaxima.Text = Convert.ToString(carrito.velocidadMaxima);
            this.txtVelocidadActual.Text = Convert.ToString(carrito.velocidadActual);
            creado = true;
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            if (creado)
            {
                carrito.EncenderMotor();
                this.txtEstado.Text = "Encendido";
                actualizarTablero();
            }
            else
            {
                if (carrito != null)
                {
                    MessageBox.Show("El Automovil ya esta encendido");
                }
                else
                {
                    MessageBox.Show("El Automovil no ha sido creado");
                }
                
            }
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            if (!carrito.AcelerarMotor())
            {
                MessageBox.Show("Velocidad Maxima Alcanzada");
            }
            actualizarTablero();
        }

        private void btnFrenar_Click(object sender, EventArgs e)
        {
            carrito.FrenarMotor();
            actualizarTablero();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            carrito.ApagarMotor();
            actualizarTablero();
            this.txtEstado.Text = "Apagado";
        }
    }
}
