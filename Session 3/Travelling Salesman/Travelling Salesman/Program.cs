using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Travelling_Salesman
{
    class Program
    {
        static int min = int.MaxValue;
        const int size = 5;
        static char[] way = new char[size + 1];
        static int[,] Tour = new int[size, size] { {0,10,3,6,9},
                                                   {5,0,5,4,2},
                                                   {4,9,0,7,8},
                                                   {7,1,3,0,4},
                                                   {3,2,6,5,0}};

        private static void Permutations(string str, string perm)
        {
            if (str.Length == 0)
                Travelling_Salesman(perm);
            else
                for (int i = 0; i < str.Length; i++)
                    Permutations(str.Substring(0, i) + str.Substring(i + 1),perm + str[i]);
        }

        static void Travelling_Salesman(string str)
        {
            string[] arr=new string[str.Length];
            for (int i = 0; i < str.Length; i++)
                arr[i] = str.Substring(i,1);
            int sum=Tour[0,Convert.ToInt32(arr[0])];
            for (int i=0;i<(size-2);i++)
                sum =sum + Tour[Convert.ToInt32(arr[i]), Convert.ToInt32(arr[i+1])];
            sum = sum + Tour[Convert.ToInt32(arr[size - 2]), 0];
            if (sum < min)
            {
                min = sum;
                way[0] = '0';
                for (int i = 0; i < str.Length; i++)
                    way[i + 1] = Convert.ToChar(arr[i]);
                way[size] = '0';
            }
        }

        static void Print(int[,] Tour)
        {
            for (int i = 0; i < Tour.GetLength(0); i++)
            {
                for (int j = 0; j < Tour.GetLength(1); j++)
                {
                    Console.Write(" " + Tour[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            string stt=null;
            Print(Tour);
            Console.WriteLine("-----------Solve-------------");
            for (int i = 1; i < size ; i++)
            {
                stt=stt + i;
            }
            Permutations(stt, "");
            Console.WriteLine("the shortest path:");
            Console.WriteLine(string.Join(",", way));
            Console.WriteLine("the distance:"+min);
        }
    }
}
