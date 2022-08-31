using System;

namespace PropiedadesAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado objEmpleado = new Empleado("Juan");
            
            objEmpleado.SALARIO = 700;
            Console.WriteLine($"El salario del empleado {objEmpleado.getNombre()} es de $ {objEmpleado.SALARIO}");

            objEmpleado.SALARIO += 500;
            Console.WriteLine($"El salario del empleado {objEmpleado.getNombre()} es de $ {objEmpleado.SALARIO}");
        }
    }
}
