using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculos
{
    class Coche : Vehiculo
    {

        public void Acelearar()
        {
            Console.WriteLine("Acelerando.");
        }

        public void Frenar()
        {
            Console.WriteLine("Frenando");
        }

        public override void Conducir()
        {
            //base.Conducir();
            Console.WriteLine("Tomando las curvas con destreza.");
        }

    }
}
