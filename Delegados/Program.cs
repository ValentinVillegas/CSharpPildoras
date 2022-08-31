using System;

namespace Delegados
{
    public class Program
    {

        //Definición del objeto delegado
        delegate void ObjetoDelegado(string msj);

        static void Main(string[] args)
        {
            //Creación del objeto delegado
            ObjetoDelegado elDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);
            
            //Utilizacion del delegado
            elDelegado("¡Hola!");

            //Creación del objeto delegado
            elDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);

            //Utilizacion del delegado
            elDelegado("¡Adios!");
        }
    }

    public class MensajeBienvenida
    {
        public static void SaludoBienvenida(string msj)
        {
            Console.WriteLine($"Mensaje de bienvenida:" +
                $"\n" +
                $"{msj}");
        }
    }

    public class MensajeDespedida
    {
        public static void SaludoDespedida(string msj)
        {
            Console.WriteLine($"Mensaje de despedida:" +
                $"\n" +
                $"{msj}");
        }
    }
}
