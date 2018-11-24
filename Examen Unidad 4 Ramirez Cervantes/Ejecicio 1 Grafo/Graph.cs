using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio_1_Grafo
{
    class Graph
    {
        private int vertices;
        private List<int>[] adj;
        int suma = 0;
        public Graph(int v)
        {
            vertices = v;
            adj = new List<int>[v];
            for(int i = 0; i < v; i++)
            {
                adj[i] = new List<int>();
            }
        }
        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
        }
        public void BFS(int s)
        {
            bool[] visited = new bool[vertices];
            Queue<int> queue = new Queue<int>();
            visited[s] = true;
            queue.Enqueue(s);
            while(queue.Count != 0)
            {
                s = queue.Dequeue();
                switch (s)
                {
                    case 0:
                        Console.WriteLine(" next -> San Francisco");
                        break;
                    case 1:
                        Console.WriteLine(" next -> Los Angeles");
                        break;
                    case 2:
                        Console.WriteLine(" next -> Denver");
                        break;
                    case 3:
                        Console.WriteLine(" next -> Chicago");
                        break;
                    case 4:
                        Console.WriteLine(" next -> Boston");
                        break;
                    case 5: 
                        Console.WriteLine(" next -> Nueva York");
                        break;
                    case 6:
                        Console.WriteLine(" next -> Atlanta");
                        break;
                    case 7:
                        Console.WriteLine(" next -> Miami");
                        break;
                }
                foreach (int next in adj[s])
                {
                    if(!visited[next])
                    {
                        visited[next] = true;
                        queue.Enqueue(next);
                    }
                }
            }
        }
        public void DFS(int s)
        {
            bool[] visited = new bool[vertices];
            Stack<int> stack = new Stack<int>();
            visited[s] = true;
            stack.Push(s);
            while(stack.Count != 0)
            {
                s = stack.Pop();
                switch(s)
                {
                    case 0:
                        Console.WriteLine(" next -> San Francisco");
                        break;
                    case 1:
                        Console.WriteLine(" next -> Los Angeles");
                        break;
                    case 2:
                        Console.WriteLine(" next -> Denver");
                        break;
                    case 3:
                        Console.WriteLine(" next -> Chicago");
                        break;
                    case 4:
                        Console.WriteLine(" next -> Boston");
                        break;
                    case 5:
                        Console.WriteLine(" next -> Nueva York");
                        break;
                    case 6:
                        Console.WriteLine(" next -> Atlanta");
                        break;
                    case 7:
                        Console.WriteLine(" next -> Miami");
                        break;
                }
                foreach(int i in adj[s])
                {
                    if(!visited[i])
                    {
                        visited[i] = true;
                        stack.Push(i);
                    }
                }
            }
        }
        public void PrintAdjcecnyMatrix()
        {
            for (int i = 0; i < vertices; i++)
            {
                Console.Write(i + ":[");
                string s = "";
                foreach (var k in adj[i])
                {
                    s = s + (k + ",");
                }
                s = s.Substring(0, s.Length - 1);
                s = s + "]";
                Console.Write(s);
                Console.WriteLine();
            }
        }
    }
}
