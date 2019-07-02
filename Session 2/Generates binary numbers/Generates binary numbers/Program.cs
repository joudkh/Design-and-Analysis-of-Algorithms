using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generates_binary_numbers
{
    class Program
    {
        static int level = 0;

        static void Gen_binary(string str)
        {
            if (str.Length == level)
                Console.WriteLine(str);
            else
            {
                Gen_binary(str + "0");
                Gen_binary(str + "1");
            }
        }

        static string mySet = "321";

        static void Gen_Subset(string str)
        {
            if (str.Length == level)
            {
                string tmp = "";
                for (int i = 0; i < str.Length; i++)
                {
                    if(str[i]=='1')
                    {
                        tmp += mySet[i];
                    }
                }
                Console.WriteLine(tmp);
            }
            else
            {
                Gen_Subset(str + "0");
                Gen_Subset(str + "1");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("enter the number=");
            level = int.Parse(Console.ReadLine());
            Gen_Subset("");
        }
    }
}
