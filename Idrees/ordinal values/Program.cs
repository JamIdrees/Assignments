using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordinal_values
{
class Program
    {
        static void Main(string[] args)
        {
            int num, value;
            Console.WriteLine("enter value");
            value = int.Parse(Console.ReadLine());
            num = value % 100;
            Console.ReadLine();
            {
                if (num < 11 || num > 13 || num == 0)
                {
                    switch (num % 10)
                    {
                        case 1:
                            Console.WriteLine("" + num + "st");
                            Console.ReadLine();
                            break;
                        case 2: Console.WriteLine("" + num + "nd");
                            Console.ReadLine();
                            break;
                        case 3: Console.WriteLine("" + num + "rd");
                            Console.ReadLine();
                            break;
                        case 0: Console.WriteLine("" + num + "th");
                            Console.ReadLine();
                            break;
                    }
                }
                else
                Console.WriteLine("" + value + "th");
                Console.ReadLine();
            }
        } 
    }
}
