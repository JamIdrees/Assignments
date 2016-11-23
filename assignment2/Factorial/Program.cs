using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, factorial;
            Console.WriteLine("Enter the Number");
            factorial = int.Parse(Console.ReadLine());
            if (factorial == 0)
            {
                Console.WriteLine("\n Factorial of a Given Number is:" + 1);
                Console.ReadLine();
            }
            else
            {
                for (i = factorial - 1; i >= 1; i--)
                {
                    factorial = factorial * i;
                }
                Console.WriteLine("\n Factorial  of a given number is: " + factorial);
                Console.ReadLine();
            }

        }
    }
}

