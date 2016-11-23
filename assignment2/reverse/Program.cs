using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] array = new int[5];
            Console.WriteLine("Enetr five numbers:");
            for (i = 0; i < 5; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Entered values are:");
            foreach (int j in array)
            {
                Console.Write("\n" + j);
            }
            Array.Reverse(array);
            Console.WriteLine("\n Reversed values are:");
            foreach (int k in array)
            {
                Console.Write("\n" + k);
            }
            Console.ReadLine();
        }
    }
}
