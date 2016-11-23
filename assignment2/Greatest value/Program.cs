using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_value
{
    class Program
    {
        public static float[] array = { 1.5f, 0.7f, 8.0f };
        static void Main(string[] args)
        {
            Console.WriteLine("greatest value is: {0:F1} ", findMax());
            Console.ReadLine();
        }
        public static float findMax()
        {
            float max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }

    }
}
