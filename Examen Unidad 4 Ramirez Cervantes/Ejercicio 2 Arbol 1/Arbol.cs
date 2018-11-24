using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_Arbol_1
{
    class Arbol
    {
        public void Add(Nodo nodo, string nombre, string[] nombres)
        {
            if (nodo.next != null)
            {
                foreach (Nodo item in nodo.next)
                {
                    Add(item, nombre, nombres);
                }
            }
            else
            {
                if (nodo.Name == nombre)
                {
                    nodo.next = new Nodo[nombres.Length];
                    for (int i = 0; i < nombres.Length; i++)
                    {
                        nodo.next[i] = new Nodo(nombres[i], nodo.Level + 1, nodo.Path + " -> " + nombres[i]);
                    }
                }
            }
        }
        public void PreOrden(Nodo nodo)
        {
            if (nodo.next != null)
            {
                Console.Write(" -> " + nodo.Name);
                for (int i = 0; i < nodo.next.Length; i++)
                {
                    PreOrden(nodo.next[i]);
                }
            }
            else
            {
                Console.Write(" -> " + nodo.Name);
            }
        }
        public void PosOrden(Nodo nodo)
        {
            if (nodo.next != null)
            {
                for (int i = 0; i < nodo.next.Length; i++)
                {
                    PosOrden(nodo.next[i]);
                }
                Console.Write(" -> " + nodo.Name);
            }
            else
            {
                Console.Write(" -> " + nodo.Name);
            }
        }
        public void Print(Nodo nodo)
        {
            if (nodo.next != null)
            {
                PrintNodeInPriority(nodo);
                for (int i = 0; i < nodo.next.Length; i++)
                {
                    Print(nodo.next[i]);
                }
            }
            else
            {
                PrintNodeInPriority(nodo);
            }
        }
        private void PrintNodeInPriority(Nodo nodo)
        {
            if (nodo.Level == 0)
            {
                Console.Write("\n  *[{0}]\n", nodo.Name);
            }
            else
            {
                for (int i = 0; i < nodo.Level; i++)
                    Console.Write("   ");
                Console.Write("-->[{0}]\n", nodo.Name);
            }
        }
    }
}
