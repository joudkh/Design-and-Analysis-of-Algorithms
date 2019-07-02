using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAZE
{
    class Program
    {
        // find the number of roads to get out the maze
        static void Main(string[] args)
        {
            // number of rows and columns
            const int n=5;
            const int m=5;


            // declare the 2D array and fill it with zero's
            int[,] maze = new int[n, m];
            char[,] road = new char[n, m];


            for (int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    maze[i, j] = Int16.MaxValue;
                    road[i, j] = '*';
                }
            }

            // and some walls to the maze
            maze[0, 3] = -1;
            maze[2, 1] = -1;


            // print the array
            //////////////////////////////////////////////////
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(maze[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------");
            //////////////////////////////////////////////////
            //////////////////////////////////////////////////

            // fill the first column
            for (int i=0;i<n;i++)
            {
                if(maze[i,0]==-1)
                {
                    break;
                }
                maze[i,0] = i;
                road[i, 0] = '|';
            }

            // fill the first row
            for (int i = 0; i < m; i++)
            {
                if (maze[0, i] == -1)
                {
                    break;
                }
                maze[0, i] = i;
                road[0, i] = '-';
            }

            // fill the array
            for(int i=1;i<n;i++)
            {
                for(int j=1;j<m;j++)
                {
                    if(maze[i, j]==-1)
                    {
                        continue;
                    }
                    int x = maze[i - 1, j];     // Top
                    int y = maze[i, j - 1];     // Left
                    if (x != -1 && y != -1)
                    {
                        if (x < y)
                        {
                            maze[i, j] = x + 1;
                            road[i, j] = '+';
                        }
                        else
                        {
                            maze[i, j] = y + 1;
                            road[i, j] = '-';
                        }
                    }
                    else if(x==-1)
                    {
                        maze[i, j] = y + 1;
                        road[i, j] = '-';
                    }
                    else if(y==-1)
                    {
                        maze[i, j] = x + 1;
                        road[i, j] = '|';
                    }
                }
            }

            // print the array
            //////////////////////////////////////////////////
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(maze[i, j]+" ");
                }
                Console.WriteLine();
            }
            //////////////////////////////////////////////////
            //////////////////////////////////////////////////

            Console.WriteLine("-------------------------");

            road[0, 0] = 'o';
            road[n - 1, m - 1] = 'o';

            // print the road
            //////////////////////////////////////////////////
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(road[i, j] + " ");
                }
                Console.WriteLine();
            }
            //////////////////////////////////////////////////
            //////////////////////////////////////////////////
        }
    }
}