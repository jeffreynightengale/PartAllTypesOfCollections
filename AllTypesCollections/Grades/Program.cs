using System;
using System.Collections.Generic;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2.Create a list that will hold all of the users grades.Keep prompting the user if they have another grade
            to enter until they say 'no'.Once you have all of the inputs, use a for each loop to iterate through the
            list and calculate the average.Output the users grade average.*/

            List<double> grades = new List<double>();
            string answer;


            do
            {
                Console.WriteLine($"Please enter your grade");
                string reply = Console.ReadLine();
                double grade = Convert.ToDouble(reply);

                grades.Add(grade);

                Console.WriteLine("Do you want to add another grade?");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] != 'n');

            double sum = 0;

            foreach (double grade in grades)
            {
                sum = sum + grade / grades.Count;
            }
            Console.WriteLine($"Your average is {sum}.");
        }
    }
}
