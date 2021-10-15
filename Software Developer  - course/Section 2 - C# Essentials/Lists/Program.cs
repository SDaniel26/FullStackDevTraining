using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numere = new List<int>();

            numere.Add(1);
            numere.Add(2);
            numere.Add(3);
            numere.Add(4);
            numere.Add(5);

            numere.Remove(2);

            List<int> numere1 = new List<int>();

            numere1.Add(11);
            numere1.Add(21);
            numere1.Add(31);
            numere1.Add(41);
            numere1.Add(51);

            numere.AddRange(numere1);

            Console.WriteLine(numere.Count);
            Console.ReadLine();
        }
    }
}
