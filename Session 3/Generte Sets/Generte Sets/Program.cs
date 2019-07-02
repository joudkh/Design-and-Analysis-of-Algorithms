using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generte_Sets
{
    class Program
    {
        static List<string> sets = new List<string>();

        private static void Generte_Sets(string str)
        {
            if (str.Length == 0)
                return;
            else if (!sets.Contains(str))
            {
                sets.Add(str);
                for (int i = 0; i < str.Length; i++)
                {
                    string str1 = str.Substring(0, i);
                    string str2 = str.Substring(i + 1);
                    Generte_Sets(str1+str2);
                }
                    
            }
        }

        static void Main(string[] args)
        {
            string str = null;
            int count;
            Console.Write("enter the number=");
            count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                str = str + (i + 1);
            }
            Generte_Sets(str);
            for (int i = 0; i < sets.Count; i++)
            {
                Console.WriteLine(sets[i]);
            }
        }
    }
}
