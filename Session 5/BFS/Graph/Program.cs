using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
    {
        const int size = 8;
        static int[,] graph = new int[size, size] { {0,1,1,1,0,0,0,0 },
                                                    {0,0,0,0,1,1,0,0 },
                                                    {0,1,0,1,1,0,0,0 },
                                                    {0,1,1,0,0,1,0,0 },
                                                    {0,0,1,0,0,1,0,0 },
                                                    {0,0,0,1,1,0,1,0 },
                                                    {0,0,0,0,0,1,0,1 },
                                                    {0,0,0,0,0,0,1,0 } };

        static bool[] visited;

        static void BFS(int node)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(node);
            while (!(q.Count == 0))
            {
                int top = q.Dequeue();
                if (visited[top] == false)
                {
                    visited[top] = true;
                    Console.WriteLine(top + " is visited");
                }
                for (int i = 0; i < size; i++)
                {
                    if (graph[top, i] != 0 && visited[i] == false)
                    {
                        q.Enqueue(i);
                    }
                }
            }
        }

        static void Main(string[] args)
        {

            visited = new bool[size] { false, false, false, false, false, false, false, false };
            BFS(0);
        }
    }
}
