using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation_and_Subsets
{
    class Program
    {
        static HashSet<string> sets = new HashSet<string>();

        private static void Permutations(string str, string perm)
        {
            sets.Add(str);
            if (str.Length == 0)
            {
                Console.WriteLine(perm);
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

        static void Main(string[] args)
        {
            string str = "";
            int count;
            Console.Write("enter the number=");
            count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                str = str + i;
            }
            Permutations(str, "");
            Console.WriteLine("----------------");
            for (int i = 0; i < sets.Count; i++)
            {
                Console.WriteLine(sets.ElementAt(i));
            }
        }
    }
}
