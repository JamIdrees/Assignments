using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            int QuizScore,MidTermScore,FinalScore, average;
            Console.WriteLine("Enter Quiz Score");
            QuizScore = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Mid-Term Score");
            MidTermScore = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Final Score");
            FinalScore = int.Parse(Console.ReadLine());
            average = ((QuizScore + MidTermScore + FinalScore) / 3);
            Console.WriteLine("Average Score is " + average + "%");
            Console.ReadLine();
            if (average >= 90)
            {
                Console.WriteLine("your grade is: 'A'");
        }
            else if (average >= 70 && average <= 90)
            {
            Console.WriteLine("your grade is: 'B'");
            Console.Read();
            }
            else if (average >= 50 && average <= 70)
            {
            Console.WriteLine("your grade is : 'C'");
            Console.Read();
            }
            else
            Console.WriteLine("your grade is : 'F'");
            Console.Read();

        }
    }
}
