using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foobar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, i;
            Console.WriteLine("Enter N Value:");
            a = int.Parse(Console.ReadLine());
            Console.ReadLine();
            for (i = 1; i <= a; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write(" foobar ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write(" foo ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write(" bar ");
                }
                else
                    Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
