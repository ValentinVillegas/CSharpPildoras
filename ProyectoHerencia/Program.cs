using System;

namespace ProyectoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo objCaballo = new Caballo("Babieca");
            Humano objHumano = new Humano("Juan");
            Gorila objGorila = new Gorila("Copito");
            Ballena objBallena = new Ballena("Wally");
            Lagartija objLagartija = new Lagartija("Juancho");

            objCaballo.getNombre();
            objHumano.getNombre();
            objGorila.getNombre();
            objBallena.getNombre();
            objBallena.Nadar();
            //Console.WriteLine($"Número de patas del caballo {objCaballo.NumeroPatas()}");
            objLagartija.getNombre();
            objLagartija.Respirar();
            objHumano.getNombre();
            objHumano.Respirar();
        }
    }

    interface IMamiferosTerrestres
    {
        int NumeroPatas();
    }

    interface IAnimalesyDeportes
    {
        string TipoDeporte();

        bool EsOlimpico();
    }

    interface ISaltoConPatas
    {
        int NumeroPatas();
    }

    abstract class Animales
    {
        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public abstract void getNombre();
    }

    class Mamiferos:Animales
    {
        private string nombreSerVivo;

        public Mamiferos(string nombre)
        {
            this.nombreSerVivo = nombre;
        }

        public virtual void Pensar()
        {
            Console.WriteLine("Pensamiento básico instintivo");
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crías hasta que se valgan por si solas");
        }

        public override void getNombre()
        {
            Console.WriteLine($"El nombre del mamifero es: {this.nombreSerVivo}");
        }
    }

    class Lagartija : Animales
    {
        string nombreReptil;

        public Lagartija(string nombre)
        {
            this.nombreReptil = nombre;
        }
        
        public override void getNombre()
        {
            Console.WriteLine($"El nombre del reptil es: {this.nombreReptil}");
        }
    }

    class Ballena : Mamiferos
    {
        public Ballena(string nombreBallena) : base(nombreBallena)
        {

        }

        public void Nadar()
        {
            Console.WriteLine("Soy capaz de nadar.");
        }
    }

    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesyDeportes, ISaltoConPatas
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {

        }

        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        int IMamiferosTerrestres.NumeroPatas()
        {
            return 4;
        }

        public string TipoDeporte()
        {
            return "Hípica";
        }

        public bool EsOlimpico()
        {
            return true;
        }

        int ISaltoConPatas.NumeroPatas()
        {
            return 2;
        }
    }

    class Humano : Mamiferos
    {
        public Humano(string nombreHumano) : base(nombreHumano)
        {

        }

        public override void Pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }

    class Gorila : Mamiferos, IMamiferosTerrestres
    {
        public Gorila(string nombreGorila) : base(nombreGorila)
        {

        }

        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        public override void Pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }

        public int NumeroPatas()
        {
            return 2;
        }
    }
}