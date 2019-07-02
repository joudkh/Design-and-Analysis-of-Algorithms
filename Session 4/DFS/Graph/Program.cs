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

        static void DFS(int node)
        {
            visited[node] = true;
            Console.WriteLine(node + " is visited");
            for (int i = 0; i < size; i++)
            {
                if (graph[node, i] != 0 && visited[i] == false)
                {
                    DFS(i);
                }
            }
        }

        static void Main(string[] args)
        {
            visited = new bool[size] { false, false, false, false, false, false, false, false };
            DFS(0);

            Console.WriteLine("-----------------------------");
        }
    }
}
