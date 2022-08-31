using System;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            AlmacenObjetos<Empleado> listaObjetos = new AlmacenObjetos<Empleado>(4);
            listaObjetos.AgregarElemento(new Empleado(1500));
            listaObjetos.AgregarElemento(new Empleado(1600));
            listaObjetos.AgregarElemento(new Empleado(1700));
            listaObjetos.AgregarElemento(new Empleado(1800));
            Console.WriteLine(listaObjetos.GetElemento(2).SALARIO);
            */

            AlmacenObjetos<String> listaObjetos = new AlmacenObjetos<String>(4);
            listaObjetos.AgregarElemento("Juan");
            listaObjetos.AgregarElemento("Elena");
            listaObjetos.AgregarElemento("Antonio");
            listaObjetos.AgregarElemento("Sandra");

            Console.WriteLine(listaObjetos.GetElemento(3));

        }
    }

    class AlmacenObjetos<T>
    {
        private T[] almacenElementos;
        private int contador = 0;

        public AlmacenObjetos(int cantidadElementos)
        {
            almacenElementos = new T[cantidadElementos];
        }

        public void AgregarElemento(T elemento)
        {
            almacenElementos[contador] = elemento;
            contador++;
        }

        public T GetElemento(int posicion)
        {
            return almacenElementos[posicion];
        }
    }

    class Empleado
    {
        private double _salario;

        public Empleado(double salario)
        {
            this._salario = salario;
        }

        public double SALARIO
        {
            get
            {
                return this._salario;
            }

            set
            {
                this._salario = value;
            }
        }
    }
