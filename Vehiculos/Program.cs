using System;

namespace Vehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================== Probando el avión ====================\n");
            Avion objAvion = new Avion();

            objAvion.ArrancarMotor("tracata tracata");
            objAvion.Despegar();
            objAvion.Conducir();
            objAvion.Aterrizar();
            objAvion.DetenerMotor("plooof");

            Console.WriteLine("\n==================== Probando el coche ====================\n");
            Coche objCoche = new Coche();

            objCoche.ArrancarMotor("bruuum bruuum");
            objCoche.Acelearar();
            objCoche.Conducir();
            objCoche.Frenar();
            objCoche.DetenerMotor("gruuum");

            Console.WriteLine("\n==================== Polimorfismo en acción ====================\n");

            Vehiculo almacenVehiculo = objCoche;
            almacenVehiculo.Conducir();

            almacenVehiculo = objAvion;
            almacenVehiculo.Conducir();
        }
    }
}
