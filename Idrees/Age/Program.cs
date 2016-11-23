using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter Your Age:");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("You Are " + i + " Years Old");
            Console.Read();
        }
    }
}
