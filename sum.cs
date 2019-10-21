using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace display
{
    class Program
    {
       void sum()
        {
            Console.WriteLine("enter two nums");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x + y;
            Console.WriteLine("the sum is " + z);
            Console.Read();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.sum();
        
        }
    }
}
