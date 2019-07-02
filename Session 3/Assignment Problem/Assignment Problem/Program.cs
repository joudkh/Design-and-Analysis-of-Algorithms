using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Problem
{
    class Program
    {
        static HashSet<string> sets = new HashSet<string>();
        static int minVal = int.MaxValue;

        const int size = 4;
        static int[,] assign = new int[size, size] { {9,2,7,8},
                                                   {6,4,3,7},
                                                   {5,8,1,8},
                                                   {7,6,9,4}};

        // function to print the 2 dimentional array
        static void Print()
        {
            // assign.GetLength(0) return the number of rows in the array
            // assign.GetLength(1) return the number of columns in the array
            for (int i = 0; i < assign.GetLength(0); i++)
            {
                for (int j = 0; j < assign.GetLength(1); j++)
                {
                    Console.Write("" + assign[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------");
        }


        // generates all the permutation of a given length
        private static void Permutations(string str, string perm)
        {
            sets.Add(str);
            if (str.Length == 0)
            {
                Console.Write(perm+" = ");
                Assignment(perm);
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    string str1 = str.Substring(0, i) + str.Substring(i + 1);
                    string str2 = perm + str[i];

                    Permutations(str1, str2);
                }
            }
        }

        private static void Assignment(string str)
        {
            int result = 0;
            for (int i=0;i<str.Length;i++)
            {
                int number = str[i] - '0';
                result += assign[number, i];
            }
            Console.WriteLine(result);
            if(minVal>result)
            {
                minVal = result;
            }
        }

        static void Main(string[] args)
        {
            Print();
            string str = "";
            for (int i = 0; i < size; i++)
            {
                str = str + i;
            }
            Permutations(str, "");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("The Best Solution is: " + minVal);
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < sets.Count; i++)
            {
                Console.WriteLine(sets.ElementAt(i));
            }
        }
    }
}
