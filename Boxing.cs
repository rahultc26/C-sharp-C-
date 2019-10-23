using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2020;

            object obj = num;  //boxing

            num = 100;   //value of num to be change
            System.Console.WriteLine("value_Type value 0f num is:{0}", num);
            System.Console.WriteLine("Object-type value of obj is:{0}", obj);
            Console.Read();
        }
    }
}
