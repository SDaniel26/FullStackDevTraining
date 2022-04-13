using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euclid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GCD(60, 96).ToString());

        }

        public int GCD(int a, int b)
        {
            while (b != 0)
            {
                int t = a;
                a = b;
                b = t / a;
            }

            return a;
        }


        
    }
}
