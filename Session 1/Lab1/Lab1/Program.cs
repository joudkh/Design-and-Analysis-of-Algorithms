using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Syntax and simple string algorithm
            ////////////////////////////////////////////

            // print on CMD
            //Console.Write("Hello World!!");
            Console.WriteLine("Hello World!!");

            string str = "AnvrsAobinrbiAreaaaaaaarvr";

            // convert all string characters to lower case
            str = str.ToLower();

            // define array of integers (the size 26 for the number of english characters)
            int[] arr = new int[26];

            // inisialize array values into zeros
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                int index = ch - 'a';
                arr[index]++;
            }

            // find maximum number in array (and its index)
            int maxNum = 0;
            int maxIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxNum)
                {
                    maxNum = arr[i];
                    maxIndex = i;
                }
            }

            char result = Convert.ToChar(maxIndex + 97);

            Console.WriteLine(result+" : "+ maxNum);


            // int max = arr.Max();         // max in array
            // Array.Sort(arr);             // sort an array
            // Array.Reverse(arr);          // reverse an array
        }
    }
}
