using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review5
{
    internal class PrimeNumberChecker
    {
        //Prime Number Checker
       // Write a console app to check if a number is prime.Implement input validation and ensure proper error handling.

        public static bool PrimeNumChecker()
        {
            Console.WriteLine("Enter a num to check weather it is prime number or not");
            string input = Console.ReadLine();

            bool b = false;
           
          if(!int.TryParse(input ,out int n))
          {
               Console.WriteLine("Enter valid integer input");
          }

            if (n == 0 || n == 1)
                b = false;
            else {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) {
                        b = true;
                        break;
                    }
                }
                if (!b) {
                    Console.WriteLine(n + " is a Prime number ");
                } else {
                    Console.WriteLine(n + " is not a Prime number ");
                }


            }
            return b;
        }
    }
}
