using System;

namespace Lambdas
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            List<Persona> gente = new List<Persona>()
            {
                new Persona("Juan", 18),
                new Persona("Maria", 28),
                new Persona("Ana", 37),
            };
            */

            //OperacionesMatematicas operacion = new OperacionesMatematicas(num => num * num);
            //Console.WriteLine(operacion(4));

            OperacionesMatematicas operacion = new OperacionesMatematicas((n1, n2) => n1 + n2);
            Console.WriteLine(operacion(4, 6));
        }

        public delegate int OperacionesMatematicas(int n1, int n2);

        /*
        public static int Cuadrado(int num)
        {
            return num * num;
        }
        */

        /*
        public static int SumaNumeros(int num1, int num2)
        {
            return num1 + num2;
        }
        */
    }

    public class Persona
    {
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

    }
}
