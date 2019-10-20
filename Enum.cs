using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        enum Days
        {
            Monday,tuesday,wednesday,thursday,friday,saturday,sunday
        }
        static void doWork()
        {

            Days first = Days.Monday;
            Console.WriteLine(first);
            first++;
            Console.WriteLine(first);
          

        }
      
        static void Main(string[] args)
        {
            doWork();
            Console.Read();
        }
   
}
    }

