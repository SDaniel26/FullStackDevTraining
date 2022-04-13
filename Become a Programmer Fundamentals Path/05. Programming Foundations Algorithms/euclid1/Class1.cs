using System;
using System.Collections.Generic;
using System.Text;

namespace euclid1
{
    class Class1
    {
        public int GCD(int a, int b)
        {
            while (b != 0)
            {
                int t = a;
                a = b;
                b = t / b;

            }
            return a;
        }
    }
}
