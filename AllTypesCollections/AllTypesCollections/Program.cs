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
            a different loop to output the results to the user concatenated together(e.g.MIS3033, MATH3013).
            2.Create a list that will hold all of the users grades.Keep prompting the user if they have another grade 
            to enter until they say 'no'.Once you have all of the inputs, use a for each loop to iterate through the 
            list and calculate the average.Output the users grade average.
            3.Create a dictionary that will hold multiple values.The key will be the course code(e.g.MIS3013, MIS3383, etc.)
            and the values will be all of the students final grades(e.g. 0.95, 0.8, etc.).Add at least 3 courses codes and
            at least 3 grades in each one.Calculate the average for each course code and output it to the user, make sure
            to format it as a percent.
            If you have time, convert #3 to getting input from the user and making sure the key doesn't exist prior to 
            adding it*/

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
