using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Stack
{
    internal class Pila
    {
        public int Capacidad { get; set; }
        private int?[] pila ;
        public Pila(int capacidad)
        {
            Capacidad = capacidad;
            pila = new int?[capacidad];
        }
        public void Push(int numero)
        {
            for(int i=0; i<pila.Length; i++)
            {
                if (pila[i] == null)
                {
                    pila[i] = numero;
                    break;
                }
                else if (pila[pila.Length-1] != null)
                {
                    Console.WriteLine("Has sobrepasado el tamaño de la pila, el elemento no puede ser añadido");
                    break;
                }
            }
        }
        public int? Tamaño()
        {
            
            for (int i = 0; i < pila.Length; i++)
            {
                if (pila[i] == null&&i>0)
                {
                    int? numeroDeElementos = i;
                    return numeroDeElementos;
                }
                else if (pila[i] == null)
                {
                    return 0;
                }
            }
            return Capacidad;    
        }
        public void Pop()
        {
            for(int i=0;i<pila.Length;i++)
            {
                if (pila[i] == null && i > 0)
                {
                    pila[i-1] = null;
                    break;
                }
                else if (pila[i] == null)
                {
                    Console.WriteLine("No hay elementos en la pila");
                    break;
                }
                else if (pila[pila.Length-1] != null)
                {
                    pila[pila.Length - 1] = null;
                    break;
                }
            }  
        }
        public void Peek()
        {
            for(int i=0;i< pila.Length;i++)
            {
                if (pila[i] == null && i > 0)
                {
                    Console.WriteLine("El ultimo número es: " + pila[i-1]);
                    break;
                }
                else if (pila[i] == null)
                {
                    Console.WriteLine("No hay elementos en la pila");
                    break;
                }
                else if (pila[pila.Length - 1] != null)
                {
                    Console.WriteLine("El ultimo número es: " + pila[pila.Length - 1]);
                    break;
                }
            }
        }
        public void Comprobacion()
        {
            for(int i=0;i<pila.Length;i++)
            {
                if (pila[i] != null)
                {
                    Console.WriteLine("La pila no está vacía");
                    break;
                }
                else
                {
                    Console.WriteLine("La pila está vacía");
                    break;
                }
            }
        }
    }
}
