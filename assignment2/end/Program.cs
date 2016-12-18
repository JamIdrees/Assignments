using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace end
{
  
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            int numcount=0;
            int[] numbers = new int[50];
            string input="";
            do{
                Console.WriteLine("enter a number");
                input=Console.ReadLine();
                int num;
                if(int.TryParse(input, out num))
                {
                    sum +=num;
                    numbers[numcount++]=num;
                    Console.WriteLine(" sum is "+ sum);
                }
            }while(!(input=="end"));
            Console.WriteLine("sum is \n " + sum);
            for (int i = 0; i < numcount;i++ )
            {
                Console.Write(numbers[i]);
                Console.ReadLine(); 
            }
                  
            }
         
         }
    }


