using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Key_presss
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            Console.Write("Press a key:");
            a = (char)Console.Read();
            switch (a)
            {
                case '0': Console.WriteLine("You pressed 0");
                    Console.ReadLine();
                    break;
                case '1': Console.WriteLine("You pressed 1");
                    Console.ReadLine();
                    break;
                case '2': Console.WriteLine("You pressed 2");
                    Console.ReadLine();
                    break;
                case '3': Console.WriteLine("You pressed 3");
                    Console.ReadLine();
                    break;
                case '4': Console.WriteLine("You pressed 4");
                    Console.ReadLine();
                    break;
                case '5': Console.WriteLine("You pressed 5");
                    Console.ReadLine();
                    break;
                case '6': Console.WriteLine("You pressed 6");
                    Console.ReadLine();
                    break;
                case '7': Console.WriteLine("You pressed 7");
                    Console.ReadLine();
                    break;
                case '8': Console.WriteLine("You pressed 8");
                    Console.ReadLine();
                    break;
                case '9': Console.WriteLine("You pressed 9");
                    Console.ReadLine();
                    break;
                default: Console.WriteLine("Not allowed!");
                    Console.ReadLine();
                    break;
            }
        }
    }

}

