using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_Arbol_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol op = new Arbol();
            op.Insertar('a');
            op.Insertar('b');
            op.Insertar('c');
            op.Insertar('d');
            op.Insertar('e');
            op.Insertar('f');
            op.Insertar('g');
            op.Insertar('h');
            Console.WriteLine(" Impresion Preorden: ");
            op.ImprimirPre();
            Console.WriteLine(" Impresion Postorden: ");
            op.ImprimirPost();
        }
    }
}
