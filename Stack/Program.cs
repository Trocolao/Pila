using System;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacidad = 10;
            Pila pila=new Pila(capacidad);
            pila.Push(1);
            pila.Push(2);
            pila.Push(3);
            pila.Push(4);
            pila.Push(11);
            Console.WriteLine("El tamaño de la pila es: "+pila.Tamaño());
           pila.Peek();
            pila.Comprobacion();
            pila.Pop();
            pila.Pop();
            pila.Pop();
            pila.Pop();
            pila.Comprobacion();
            Console.WriteLine("El tamaño de la pila es: " + pila.Tamaño());
            pila.Pop();
            pila.Pop();
            pila.Pop();
            pila.Pop();
            pila.Push(3);
            pila.Peek();
            pila.Pop();
            pila.Pop();
            pila.Peek();
            pila.Push(1);
            pila.Push(2);
            pila.Push(3);
            pila.Push(4);
            pila.Push(11);
            pila.Push(1);
            pila.Push(2);
            pila.Push(3);
            pila.Push(4);
            pila.Push(11);
            pila.Push(2);
            pila.Push(3);
            pila.Push(4);
            pila.Push(11);
            pila.Peek();
            Console.WriteLine("El tamaño de la pila es: " + pila.Tamaño());
        }
    }
}
