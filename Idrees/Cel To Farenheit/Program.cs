using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cel_To_Farenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celcius, Fahrenheit;
            Console.WriteLine("Enter Degrees In Celcius \n");
            celcius = float.Parse(Console.ReadLine());
            Console.WriteLine("\n Entered Celcius Value Is : " + celcius + "° \n");
            Fahrenheit = celcius * 1.8 + 32;
            Console.WriteLine("Converted Value In Farenheit Is : " + Fahrenheit + "°F");
            Console.ReadLine();

        }
    }
}