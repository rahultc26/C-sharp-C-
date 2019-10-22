using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public class Program
    {
        public float salary = 50000;
    }
    public class Programmer : Program
    {
        public float bonus = 10000;
    }
    public class Testinheritance
    {
        static void Main(string[] args)
        {
            Programmer p1 = new Programmer();
            Console.WriteLine("Salary: "+ p1.salary);
            Console.WriteLine("Bounus: "+ p1.bonus);
            Console.Read();

        }
    }
}

