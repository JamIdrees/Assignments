using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_Integer
{
    class Program
    {
        int n;
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("enter a string:");
            str = Console.ReadLine();
            int parseId;
            if(int.TryParse(str, out parseId))
            {
                Console.WriteLine("  " + str + "  string contains integer");
            }
            else
            {
                Console.WriteLine("  " + str + "  not an integer");
            }
            Console.ReadLine();
        } 
    }
}
       