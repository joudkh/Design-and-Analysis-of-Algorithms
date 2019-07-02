using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Permutations
{
    class Program
    {
        static HashSet<string> mySet = new HashSet<string>();

        static int[,] assign = new int[4, 4] { {9,2,7,8},
                                               {6,4,3,7},
                                               {5,8,1,8},
                                               {7,6,9,4},
                                            };

        static void permutation(string s1,string s2)
        {
            mySet.Add(s1);
            if (s1.Length==0)
            {
                Console.WriteLine(s2);
                assignment(s2);
            }
            else
            {
                for(int i=0;i<s1.Length;i++)
                {
                    string tmp1=s1.Substring(0,i)+s1.Substring(i+1);
                    string tmp2 = s2 + s1[i];

                    permutation(tmp1, tmp2);
                }
            }
        }

        static void assignment(string str)
        {
            // s = "0123"
            int result = 0;
            for(int i=0;i< str.Length;i++)
            {
                result += assign[(str[i]-'0'), i];
            }
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            permutation("0123", "");

            Console.WriteLine("-----------------");

            //for(int i=0;i<mySet.Count;i++)
            //{
            //    Console.WriteLine(mySet.ElementAt(i));
            //}
        }
    }
}
