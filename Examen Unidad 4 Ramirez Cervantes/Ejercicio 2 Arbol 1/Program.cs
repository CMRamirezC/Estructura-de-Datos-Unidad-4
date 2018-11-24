using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_Arbol_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol Operacion = new Arbol();

            Console.WriteLine("\n ---> Ejercicio 2-1 <---");
            Nodo arbol = new Nodo("a");
            Operacion.Add(arbol, "a", new string[] { "b", "c", "d" });
            Operacion.Add(arbol, "b", new string[] { "e", "f", "g" });
            Operacion.Add(arbol, "e", new string[] { "k", "l", "m" });
            Operacion.Add(arbol, "g", new string[] { "n" });
            Operacion.Add(arbol, "n", new string[] { "r", "s" });
            Operacion.Add(arbol, "d", new string[] { "h", "i", "j" });
            Operacion.Add(arbol, "h", new string[] { "o" });
            Operacion.Add(arbol, "j", new string[] { "p", "q" });
            Operacion.Print(arbol);
            Console.WriteLine("\n Arbol en preorden: ");
            Operacion.PreOrden(arbol);
            Console.WriteLine("\n Arbol en posorden: ");
            Operacion.PosOrden(arbol);
            Console.ReadKey();
        }
    }
}
