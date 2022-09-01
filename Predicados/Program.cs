using System;
using System.Collections.Generic;

namespace Predicados
{
    public class Program
    {
        static void Main(string[] args)
        { 
            List<Persona> gente = new List<Persona>()
            {
                new Persona("Juan", 18),
                new Persona("Maria", 28),
                new Persona("Ana", 37),
            };

            Predicate<Persona> elPredicado = new Predicate<Persona>(ExisteJuan);
            bool existe = gente.Exists(elPredicado);

            Console.WriteLine(existe ? "Si hay almenos una persona que se llame juan" : "No hay almenos una persona que se llame juan");

        }

        static bool ExisteJuan(Persona p)
        {
            if(p.Nombre == "Juan")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
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