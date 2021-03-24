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
        public Form1()
        {
            InitializeComponent();
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            ClsAutomovil carrito = new ClsAutomovil();
            carrito.marca = "Meches";
            carrito.color = "Blanco";
            carrito.vel_max = 100;
            MessageBox.Show("Carrito creado con el color " + carrito.color);
        }
    }
}
