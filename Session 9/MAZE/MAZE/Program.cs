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

            for(int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    maze[i, j] = 0;
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
                maze[i,0] = 1;
            }

            // fill the first row
            for (int i = 0; i < m; i++)
            {
                if (maze[0, i] == -1)
                {
                    break;
                }
                maze[0, i] = 1;
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
                    int x = maze[i - 1, j];
                    int y = maze[i, j - 1];
                    if(x!=-1)
                    {
                        maze[i, j] += x;
                    }
                    if(y!=-1)
                    {
                        maze[i, j] += y;
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
        }
    }
}