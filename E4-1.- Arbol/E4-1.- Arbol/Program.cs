using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_1.__Arbol
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol abo = new Arbol();//se crea un objeto de tipo arbol 
            abo.Insertar(100);//se agregan todos los elementos al arbol y el primer elemento sera la raiz
            abo.Insertar(50);
            abo.Insertar(25);
            abo.Insertar(75);
            abo.Insertar(150);
            Console.WriteLine("Impresion preorden: ");
            abo.ImprimirPre();
            Console.WriteLine("Impresion entreorden: ");
            abo.ImprimirEntre();
            Console.WriteLine("Impresion postorden: ");
            abo.ImprimirPost();
            Console.ReadKey();
        }
    }
}
