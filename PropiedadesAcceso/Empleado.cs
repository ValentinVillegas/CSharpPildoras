using System;
using System.Collections.Generic;
using System.Text;

namespace PropiedadesAcceso
{
    class Empleado
    {

        private string nombre;
        private double salario;

        public Empleado(string nombre)
        {
            this.nombre = nombre;
        }

        private double evaluaSalario(double salario)
        {
            if(salario < 0)
            {
                Console.WriteLine("El salario del empleado no puede ser menor a cero.");
                salario = 0;
            }

            return salario;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public double SALARIO
        {
            get
            {
                return this.salario;
            }

            set
            {
                this.salario = evaluaSalario(value);
            }
        }
    }
}
