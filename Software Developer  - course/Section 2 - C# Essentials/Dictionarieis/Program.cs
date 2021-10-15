using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionarieis
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> carteTel = new Dictionary<string, long>();

            carteTel.Add("Alex", 4155335466);

            carteTel["Jessica"] = 54654313545;

            carteTel.Remove("Jessica");


            if (carteTel.ContainsKey("Alex")) { 

            Console.WriteLine("Alex's number is " + carteTel["Alex"]);
            Console.ReadLine();
            }

        }
    }
}
