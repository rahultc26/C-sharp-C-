using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenodd
{
    class Program
    {
        static void Main(string[] args)
        {
            
         
            for (int i = 0; i <= 150; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i+"num is even");
                else
                    Console.WriteLine(i+"num is odd");
            }
            Console.Read();
        }
    }
}
