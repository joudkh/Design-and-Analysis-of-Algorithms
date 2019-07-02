using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class Program
    {
        // declare the graph and its size
        // note that we added one exstra raw and columne because our graph starts from node number 1 not 0
        const int size = 10;
        static int[,] graph = new int[size, size] { {0,0,0,0,0,0,0,0,0,0},
                                                    {0,0,0,0,0,4,0,0,0,0},
                                                    {0,0,0,5,0,4,0,0,0,0},
                                                    {0,0,5,0,11,0,0,0,0,8},
                                                    {0,0,0,11,0,3,0,9,0,0},
                                                    {0,4,4,0,3,0,7,0,0,0},
                                                    {0,0,0,0,0,7,0,0,12,0},
                                                    {0,0,0,0,9,0,0,0,2,6},
                                                    {0,0,0,0,0,0,12,2,0,0},
                                                    {0,0,0,8,0,0,0,6,0,0} };

        // boolean array to insure that we wont visit and node twice
        static bool[] visited = new bool[size];

        // the distance array that our function will fill with the distance from "start node" 
        static int[] distance = new int[size];

        static int[] Predecessor = new int[size];

        // our main function
        static void dijkstra(int start)
        {
            // inisialize arrays and variables
            int someNodesLeft = size;
            for (int i=0;i<size;i++)
            {
                visited[i] = false;
                distance[i] = int.MaxValue;
                Predecessor[i] = -1;
            }

            distance[start] = 0;
            

            // make a loop for the number of nodes
            while (someNodesLeft>0)
            {
                // find the value and index of the mimimum value in the distance array
                int minValue = int.MaxValue;
                int minIndex = 0;
                for(int i=1;i<size;i++)
                {
                    if (distance[i]<minValue && visited[i]==false)
                    {
                        minValue = distance[i];
                        minIndex = i;
                    }
                }

                // visit the found node
                visited[minIndex] = true;

                // make a loop for all the nodes connected to "node v" and if there are a edge between them (v and u) and u is not visited yet
                // compare the new distance and the old distance and keep the minimum one
                for (int u=1;u<size;u++)
                {
                    if(graph[minIndex,u]!=0 && visited[u]==false)
                    {
                        if (distance[u] > graph[minIndex, u] + distance[minIndex])
                        {
                            distance[u] = graph[minIndex, u] + distance[minIndex];
                            Predecessor[u] = minIndex;
                        }
                    }
                }

                someNodesLeft--;
            }
        }

        //print road with recursion 
        static void printRoadRecursion(int From, int To)
        {
            if (From != To)
            {
                printRoadRecursion(From, Predecessor[To]);
                Console.Write(" -> "+To);
            }
        }

        //print road without recursion 
        static void printRoad(int from, int to)
        {
            List<int> road = new List<int>();
            while (Predecessor[to] != -1)
            {
                road.Add(to);
                to = Predecessor[to];

            }
            road.Reverse();
            for (int i=0;i<road.Count;i++)
            {
                Console.Write(" -> " + road[i]);
            }
        }

        static void Main(string[] args)
        {
            int from = 1;
            dijkstra(from);
            for(int i=1;i<size;i++)
            {
                Console.WriteLine("The Cost From "+ from + " to "+i+" : "+distance[i]);
                Console.Write("The Path (Recursion): " + from);
                printRoadRecursion(from, i);
                Console.WriteLine("");

                Console.Write("The Path (Loop):      " + from);
                printRoad(from, i);
                Console.WriteLine("");

                Console.WriteLine("");
            }
        }
    }
}
