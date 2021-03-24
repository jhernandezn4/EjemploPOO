using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPOO.clases
{
    class ClsAutomovil
    {
        public String marca { get; set; }
        public int vel_max { get; set; }

        public int velocidadActual { get; set; }
        public bool encendido { get; set; }

        public string color { get; set; }



        public void EncenderMotor()
        {
            encendido = true;
            vel_max = 0;
        }
    }
}
