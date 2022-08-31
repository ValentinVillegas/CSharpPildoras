using System;
using System.Collections.Generic;

namespace Colecciones_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numeros = new Queue<int>();

            foreach(int num in new int[] { 10, 8, 6, 4, 2, 0 })
            {
                numeros.Enqueue(num);
            }

            numeros.Dequeue();

            foreach(int num in numeros)
            {
                Console.WriteLine(num);
            }

        }
    }
}
