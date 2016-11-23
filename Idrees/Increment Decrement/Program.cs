using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment_Decrement
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Please Enter The Value Of A");
            a = int.Parse(Console.ReadLine());
            {
                Console.WriteLine("The value of a is \t" + a +"\n");
                ++a;
                Console.WriteLine("The value of ++a is \t" + a +"\n");
                Console.WriteLine("Now the value of a is \t" + a +"\n");
                Console.WriteLine("The value of a++ is \t" + a++ +"\n");
                Console.WriteLine("Now the value of a is \t" + a +"\n");
                --a;
                Console.WriteLine("The value of --a is \t" + a +"\n");
                Console.WriteLine("Now the value of a is \t" + a +"\n");
                Console.WriteLine("The value of a-- is \t" + a-- +"\n");
                Console.WriteLine("Now the value of a is \t" + a +"\n");
                Console.ReadLine();
            Console.ReadLine();
            }
        }
    }
}

