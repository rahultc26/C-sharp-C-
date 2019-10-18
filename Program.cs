using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("enter the no.");
                int n = Convert.ToInt32(Console.ReadLine());


                if (n % 2 != 0)
                    Console.WriteLine("prime");
                else
                    Console.WriteLine("not prime");
                Console.ReadLine();

            }
        }
    }
}
