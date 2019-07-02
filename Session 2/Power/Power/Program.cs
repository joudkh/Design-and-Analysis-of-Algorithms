using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power
{
    class Program
    {
        static double Power(double x, int n)
        {
            double y = 1;
            for (int i=1;i<=n;i++)
                y = y * x;
            return y;
        }

        static double Power2(double x, int n)
        {
            if(n==0)
            {
                return 1;
            }
            return x * Power2(x, n - 1);
        }


        static void Main(string[] args)
        {
            int num,n;
            double pow;
            Console.Write("enter the number:\n");
            num=int.Parse(Console.ReadLine());
            Console.Write("enter the power:\n");
            n=int.Parse(Console.ReadLine());
            pow= Power2(num, n);
            Console.WriteLine(pow);
        }
    }
}
