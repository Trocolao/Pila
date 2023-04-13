using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LogicaDeNegocio
{
    public class Pila
    {
        public int Capacidad { get; set; }
        public int?[] Stack { get; set; }
        public Pila(int capacidad)
        {
            Capacidad = capacidad;
            Stack = new int?[capacidad];
        }
        public string Push(int numero)
        {
            for(int i=0; i<Stack.Length; i++)
            {
                if (Stack[i] == null)
                {
                    Stack[i] = numero;
                    return "numero introducido correctamente";
                }
                else if (Stack[Stack.Length-1] != null)
                {
                    return "Has sobrepasado el tamaño de la pila, el elemento no puede ser añadido";
                }
            }
            return "";
        }
        public int? Tamaño()
        {
            
            for (int i = 0; i < Stack.Length; i++)
            {
                if (Stack[i] == null&&i>0)
                {
                    int? numeroDeElementos = i;
                    return numeroDeElementos;
                }
                else if (Stack[i] == null)
                {
                    return 0;
                }
            }
            return Capacidad;    
        }
        public int? Pop()
        {
            for(int i=0; i<Stack.Length; i++)
            {
                if (Stack[i] == null && i > 0)
                {
                    int? ultimoValor = Stack[i - 1];
                    Stack[i-1] = null;
                    return ultimoValor;
                }
                else if (Stack[i] == null)
                {
                    return null;
                }
                else if (Stack[Stack.Length-1] != null)
                {
                    int? ultimoValor = Stack[Stack.Length - 1];
                    Stack[Stack.Length - 1] = null;
                    return ultimoValor;
                }
            }
            return null;
        }
        public int? Peek()
        {
            for(int i=0; i< Stack.Length; i++)
            {
                if (Stack[i] == null && i > 0)
                {
                    return Stack[i-1];
                }
                else if (Stack[i] == null)
                {
                    return null;
                }
                else if (Stack[Stack.Length - 1] != null)
                {
                    return Stack[Stack.Length - 1];    
                }
            }
            return null;
        }
        public string Comprobacion()
        {
            for(int i=0; i<Stack.Length; i++)
            {
                if (Stack[i] != null)
                {
                    return "La pila no esta vacia";
                }
            }
            return "La pila esta vacia";
        }

       
    }
}
