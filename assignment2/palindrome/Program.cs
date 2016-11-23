using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, reverse = "";
            int i;
            Console.WriteLine("Enter a String: \n");
            str = Console.ReadLine();
            for (i = str.Length - 1; i >= 0; i--)
            {
                reverse = reverse + str[i];
            }
            if (str == reverse)
            {
                Console.WriteLine("Its a Palindrome");
                Console.WriteLine(" Entered String Is : " + str);
                Console.WriteLine("Reversed String Is  :" + reverse);
            }
            else
            {
                Console.WriteLine(" Its Not a Palindrome");
                Console.WriteLine(" Entered String Is  " + str);
                Console.WriteLine("Reversed String Is:  " + reverse);

            }
            Console.ReadLine();
        }
    }
}
