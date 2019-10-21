using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int i, fact = 1, number;
                Console.WriteLine("Enter any Number: ");
                number = int.Parse(Console.ReadLine());
                for (i = 1; i <= number; i++)
                {
                    fact = fact * i;
                }
                Console.WriteLine("Factorial of " + number + " is: " + fact);
            }
            Console.Read();
        }
    }
}
