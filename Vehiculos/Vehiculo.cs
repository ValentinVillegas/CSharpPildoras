using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculos
{
    class Vehiculo
    {

        public void ArrancarMotor(string sonido)
        {
            Console.WriteLine($"Motor en marcha {sonido}.");
        }

        public void DetenerMotor(string sonido)
        {
            Console.WriteLine($"Motor detenido {sonido}.");
        }

        public virtual void Conducir()
        {
            Console.WriteLine("Código genérico para el método conducir");
        }
    }
}
