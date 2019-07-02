using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        // Recursion Solution (Exponential Complexity)
        static int fib1(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return fib1(n - 2) + fib1(n - 1);
            }
        }

        // Dynamic Solution "Top Down" (Linear Complexity)
        static long[] visited = new long[100000];

        static long fib2(int n)
        {
            if (visited[n]!=-1)
            {
                return visited[n];
            }


            if (n == 0 || n == 1)
            {
                visited[n] = n;
                return n;
            }
            else
            {
                long res = fib2(n - 2) + fib2(n - 1);
                visited[n] = res;
                return res;
            }
        }

        // Dynamic Solution "Bottom Up" (Linear Complexity)
        static long fib3(int n)
        {
            long[] arr = new long[n + 1];
            arr[0] = 0;
            arr[1] = 1;
            for(int i=2;i<n+1;i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            return arr[n];
        }

        static long fib4(int n)
        {
            long x1 = 0;
            long x2 = 1;
            long x3 = 0;
            while (n>=2)
            {
                x3 = x2 + x1;
                x1 = x2;
                x2 = x3;
                n--;
            }
            return x3;
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 10000;i++ )
            {
                visited[i] = -1;
            }

            int num = 20;
            Console.WriteLine("Dynamic Solution 'Bottom Up' (Linear Complexity): " + fib3(num));
            Console.WriteLine("Dynamic Solution 'Top Down' (Linear Complexity): " + fib2(num));
            Console.WriteLine("Recursion Solution (Exponential Complexity): " + fib1(num));
            Console.WriteLine("-------------------------------------------------");

            num = 40;
            Console.WriteLine("Dynamic Solution 'Bottom Up' (Linear Complexity): " + fib3(num));
            Console.WriteLine("Dynamic Solution 'Top Down' (Linear Complexity): " + fib2(num));
            Console.WriteLine("Recursion Solution (Exponential Complexity): " + fib1(num));
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
