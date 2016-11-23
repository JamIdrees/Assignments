using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even
{
    class even
    {
        static void Main(string[] args)
        {
            int i;
            int[] array = new int[10];
            Console.WriteLine("enter 10 values:");
            for (i = 1; i < 10; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("even numbers are: \n");
            for (i = 1; i < 10; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine("{0}", array[i]);
                    Console.WriteLine("");
                }
            }
            Console.ReadLine();
        }
    }
}
