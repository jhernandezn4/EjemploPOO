using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPOO.clases
{
    class ClsAutomovil
    {
        public String marca { get;  }
        public string color { get; }
        public int velocidadMaxima { get; }
        public int velocidadActual { get; private set; }
        public bool encendido { get; private set; }
        

        public ClsAutomovil(String marca, String color , int velMax)
        {
            this.marca = marca;
            this.color = color;
            this.velocidadMaxima = velMax;
        }

        public void EncenderMotor()
        {
            encendido = true;
            velocidadActual = 0;
        }
        public bool AcelerarMotor()
        {
            int nuevaVelocidad = this.velocidadActual + 10;
            if (nuevaVelocidad > this.velocidadMaxima)
            {
                return false;
            }
            else
            {
                this.velocidadActual = nuevaVelocidad;
                return true;
            }
        }
        public bool FrenarMotor()
        {
            int nuevaVelocidad = this.velocidadActual - 10;
            if (nuevaVelocidad <0)
            {
                return false;
            }
            else
            {
                this.velocidadActual = nuevaVelocidad;
                return true;
            }
        }

    }
}
