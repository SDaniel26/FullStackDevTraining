using System;

namespace euclid1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(GCD(60, 96));
        }
        static int GCD(int a, int b)
        {
            int t;
            while (b != 0)
            {
                t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

    }
}
