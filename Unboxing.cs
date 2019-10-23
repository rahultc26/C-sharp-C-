using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           // Unboxing example
            int num = 23;
            object obj = num;  //boxing

            num = (int)obj;  //unboxing

            //display result
            Console.WriteLine("Value of ob object is :" + obj);
            Console.WriteLine("value of num is :" + num); 
            Console.Read();
        }
    }
}
