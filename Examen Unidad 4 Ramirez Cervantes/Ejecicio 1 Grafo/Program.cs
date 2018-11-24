using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio_1_Grafo
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph grafo = new Graph(8);
            grafo.AddEdge(0, 1);
            grafo.AddEdge(0, 2);
            grafo.AddEdge(0, 3);
            grafo.AddEdge(0, 5);
            grafo.AddEdge(1, 0);
            grafo.AddEdge(1, 2);
            grafo.AddEdge(1, 5);
            grafo.AddEdge(2, 0);
            grafo.AddEdge(2, 1);
            grafo.AddEdge(2, 3);
            grafo.AddEdge(3, 0);
            grafo.AddEdge(3, 2);
            grafo.AddEdge(3, 4);
            grafo.AddEdge(3, 5);
            grafo.AddEdge(3, 6);
            grafo.AddEdge(4, 3);
            grafo.AddEdge(4, 5);
            grafo.AddEdge(5, 0);
            grafo.AddEdge(5, 1);
            grafo.AddEdge(5, 3);
            grafo.AddEdge(5, 4);
            grafo.AddEdge(5, 6);
            grafo.AddEdge(5, 7);
            grafo.AddEdge(6, 3);
            grafo.AddEdge(6, 5);
            grafo.AddEdge(6, 7);
            grafo.AddEdge(7, 5);
            grafo.AddEdge(7, 6);
            grafo.PrintAdjcecnyMatrix();
            Console.WriteLine(" Breadth-first search traversal starting from vertex Boston: ");
            grafo.BFS(4);
            Console.WriteLine(" Depth-first search traversal starting from vertex Nueva York: ");
            grafo.DFS(5);
        }
    }
}
