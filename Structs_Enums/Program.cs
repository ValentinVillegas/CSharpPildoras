using System;

namespace Structs_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado objEmpleado = new Empleado(1200,250);
            objEmpleado.CambiaSalario(objEmpleado, 100);
            Console.WriteLine(objEmpleado);
        }
    }
}
