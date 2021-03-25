using System;
using System.Collections.Generic;

namespace AllTypesCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.Create parallel arrays, one will have the course subject(e.g.MIS, MATH, etc.) and the other will hold 
             course numbers(e.g. 3033, 3013, etc.).Ask the user to input 3 for each, store them in the array.Then use 
            a different loop to output the results to the user concatenated together(e.g.MIS3033, MATH3013).*/

            Console.WriteLine($"Please input your first subject");
            string firstSubject = Console.ReadLine().ToUpper();

            Console.WriteLine($"Please input your second subject");
            string secondSubject = Console.ReadLine().ToUpper();

            Console.WriteLine($"Please input your third subject");
            string thirdSubject = Console.ReadLine().ToUpper();

            string[] subjects = { firstSubject, secondSubject, thirdSubject };

            Console.WriteLine($"Please input your first number");
            string first = Console.ReadLine();
            double firstNumber = Convert.ToDouble(first);

            Console.WriteLine($"Please input your second number");
            string second = Console.ReadLine();
            double secondNumber = Convert.ToDouble(second);

            Console.WriteLine($"Please input your third number");
            string third = Console.ReadLine();
            double thirdNumber = Convert.ToDouble(third);

            double[] numbers = { firstNumber, secondNumber, thirdNumber };

            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine($"{subjects[i]}{numbers[i]}");
            }


        }
    }
}
