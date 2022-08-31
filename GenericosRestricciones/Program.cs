using System;

namespace GenericosRestricciones
{
    class Program
    {
        static void Main(string[] args)
        {

            /*AlmacenObjetos<Estudiante> empleados = new AlmacenObjetos<Estudiante>(3);*/

            AlmacenObjetos<Director> empleados = new AlmacenObjetos<Director>(3);
            empleados.agregarElemento(new Director(4500));
            empleados.agregarElemento(new Director(5000));
            empleados.agregarElemento(new Director(5500));
        }
    }

    class AlmacenObjetos<T> where T : IParaEmpleados
    {
        private int contador = 0;
        private T[] contenedorObjetos;

        public AlmacenObjetos(int cantidadElementos)
        {
            contenedorObjetos = new T[cantidadElementos];
        }

        public void agregarElemento(T elemento)
        {
            contenedorObjetos[contador] = elemento;
            contador++;
        }

        public T obtenerElemento(int posicion)
        {
            return contenedorObjetos[posicion];
        }
    }

    interface IParaEmpleados
    {
        double getSalario();
    }

    class Director:IParaEmpleados
    {
        private double salario;

        public Director(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return this.salario;
        }

    }

    class Secretaria : IParaEmpleados
    {
        private double salario;

        public Secretaria(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return this.salario;
        }
    }

    class Electricista : IParaEmpleados
    {
        private double salario;

        public Electricista(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return this.salario;
        }

    }

    class Estudiante
    {
        private double edad;

        public Estudiante(double edad)
        {
            this.edad = edad;
        }

        public double getEdad()
        {
            return this.edad;
        }
    }
}
