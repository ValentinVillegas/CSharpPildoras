using System;
using System.Collections.Generic;

namespace Colecciones_Listas_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>();
            int elemento;

            do
            {
                Console.Write("Ingrese un número para añadir a la lista (-1 para salir): ");
                elemento = int.Parse(Console.ReadLine());

                listaNumeros.Add(elemento);

            } while (elemento != -1);


            listaNumeros.RemoveAt(listaNumeros.Count - 1);
            Console.WriteLine("\nLos números ingresados son:\n");

            foreach(int numero in listaNumeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}