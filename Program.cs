using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pal
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            int rev = 0;
            int n;
            Console.WriteLine("enter the nums");
             n=Convert.ToInt32(Console.ReadLine());
       
            int temp = n;
            while (n != 0)
            {
                int x = n % 10;
                n = n / 10;
                rev = rev * 10 + x;

            }
                if (temp == rev)
                {
                    Console.WriteLine("palindrome");
                }
                else
                {
                    Console.WriteLine("not a palindrome");

                }
            
            Console.Read();
            
        }
    }
}
