using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idrees
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
