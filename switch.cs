using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Console.WriteLine("enter the 2 values");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("1.addition");
                Console.WriteLine("2.subs");
                Console.WriteLine("3.mul");
                Console.WriteLine("4.div");
                Console.WriteLine("your choice");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:Console.WriteLine("sum is " + (a + b));
                        
                        break;
                    case 2: Console.WriteLine("sub is " + (a - b));
                        break;
                    case 3: Console.WriteLine("mul is " + (a * b));
                        break;
                    case 4: Console.WriteLine("div is " + (a / b));
                        break;Console.Read();
                }
            }
        }
    }
}
