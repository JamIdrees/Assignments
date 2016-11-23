using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_dimensional_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 2;
            int cols = 10;
            float[,] students = new float[rows, cols];
            Random random = new Random(3);
            float[] sum = new float[2];
            for (int i = 0; i < rows; i++)
            {
                sum[i] = 0;
                for (int j = 0; j < cols; j++)
                {
                    students[i, j] = random.Next(99);
                    Console.Write("{0} ", students[i, j]);
                    sum[i] = sum[i] + students[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Average of Group One is : {0}", sum[0] / cols);
            Console.WriteLine("Average of Group Two is : {0}", sum[1] / cols);
            Console.WriteLine();
            Console.ReadLine();


        }
    }
}

