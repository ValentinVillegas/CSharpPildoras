using System;
using System.Collections.Generic;

namespace Colecciones_Stack_Y_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Stack<int> numeros = new Stack<int>();

            foreach(int num in new int[] { 10, 8, 6, 4, 2, 0 })
            {
                numeros.Push(num);
            }

            Console.WriteLine("\nLista de número original:\n");

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }

            numeros.Pop();

            Console.WriteLine("\nLista de números pop:\n");

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
            */

            //Declarar el diccionario
            Dictionary<string, int> edades = new Dictionary<string, int>();

            //Rellenar el diccionario
            edades.Add("Juan", 18);
            edades.Add("Diandra", 35);

            edades["Maria"] = 25;
            edades["Anotonio"] = 29;

            //Recorriendo el diccionario
            foreach (KeyValuePair<string, int> persona in edades)
            {
                Console.WriteLine($"Nombre: {persona.Key}, Edad: {persona.Value}");
            }
        }
    }
}
