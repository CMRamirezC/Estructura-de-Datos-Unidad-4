using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_Arbol_1
{
    class Nodo
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Path { get; set; }
        public Nodo[] next;
        public Nodo(string nombre)
        {
            Name = nombre;
            Level = 0;
            Path = nombre;
        }
        public Nodo(string nombre, int nivel, string camino)
        {
            Name = nombre;
            Level = nivel;
            Path = camino;
        }
    }
}
