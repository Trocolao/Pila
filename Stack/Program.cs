using System;
using LogicaDeNegocio;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacidad = 10;
            Pila pila=new Pila(capacidad);
            Console.WriteLine(pila.Push(1));
            Console.WriteLine(pila.Push(2));
            Console.WriteLine(pila.Push(3));
            Console.WriteLine(pila.Push(5));
            Console.WriteLine(pila.Push(8));
            Console.WriteLine(pila.Push(11));
            Console.WriteLine("El tamaño de la pila es: "+pila.Tamaño());
            Console.WriteLine(pila.Peek());
            Console.WriteLine(pila.Comprobacion());
            Console.WriteLine(pila.Pop());
            Console.WriteLine(pila.Pop());
            Console.WriteLine(pila.Pop());
            Console.WriteLine(pila.Pop());
            Console.WriteLine(pila.Comprobacion());
            Console.WriteLine("El tamaño de la pila es: " + pila.Tamaño());
            Console.WriteLine(pila.Pop());
            Console.WriteLine(pila.Pop());
            Console.WriteLine(pila.Pop());
            Console.WriteLine(pila.Pop());
            Console.WriteLine(pila.Push(3));
            Console.WriteLine(pila.Peek());
            Console.WriteLine(pila.Pop());
            Console.WriteLine(pila.Pop());
            Console.WriteLine(pila.Peek());
            Console.WriteLine(pila.Push(1));
            Console.WriteLine(pila.Push(2));
            Console.WriteLine(pila.Push(3));
            Console.WriteLine(pila.Push(4));
            Console.WriteLine(pila.Push(11));
            Console.WriteLine(pila.Push(1));
            Console.WriteLine(pila.Push(2));
            Console.WriteLine(pila.Push(3));
            Console.WriteLine(pila.Push(4));
            Console.WriteLine(pila.Push(11));
            Console.WriteLine(pila.Push(2));
            Console.WriteLine(pila.Push(3));
            Console.WriteLine(pila.Push(4));
            Console.WriteLine(pila.Push(11));
            Console.WriteLine(pila.Peek());
            Console.WriteLine("El tamaño de la pila es: " + pila.Tamaño());
        }
    }
}
