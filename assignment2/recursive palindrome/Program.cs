using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursive_palindrome
{
    class Program
    {
        public static bool Ispalindrome(string text)
        {
            if (text.Length <= 1)
                return true;
            else
            {
                if (text[0] != text[text.Length - 1])
                    return false;
                else
                    return Ispalindrome(text.Substring(1, text.Length - 2));
            }
        }
         public static void Main()
        {
            Console.WriteLine(Ispalindrome("radar"));
            Console.ReadLine();
        }
    }
}
