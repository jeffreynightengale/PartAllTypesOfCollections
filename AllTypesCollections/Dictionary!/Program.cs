using System;
using System.Collections.Generic;

namespace Dictionary_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            3.Create a dictionary that will hold multiple values.The key will be the course code(e.g.MIS3013, MIS3383, etc.)
            and the values will be all of the students final grades(e.g. 0.95, 0.8, etc.).Add at least 3 courses codes and
            at least 3 grades in each one.Calculate the average for each course code and output it to the user, make sure
            to format it as a percent.
            If you have time, convert #3 to getting input from the user and making sure the key doesn't exist prior to 
            adding it */

            Dictionary<string, List<double>> courseGrades = new Dictionary<string, List<double>>();

            courseGrades.Add("MIS3013", new List<double>());
            courseGrades["MIS3013"].Add(75);
            courseGrades["MIS3013"].Add(83);
            courseGrades["MIS3013"].Add(90);

            List<double> mis3033Grades = new List<double>();
            mis3033Grades.Add(80);
            mis3033Grades.Add(95);
            mis3033Grades.Add(100);
            courseGrades.Add("MIS3033", mis3033Grades);

            courseGrades.Add("MIS3083", new List<double>());
            courseGrades["MIS3083"].Add(95);
            courseGrades["MIS3083"].Add(70);
            courseGrades["MIS3083"].Add(97);

            double average = 0;
            double other = 0;
            
            foreach (string courseCode in courseGrades.Keys)
            {
                List<double> grades = courseGrades[courseCode];
                double sum = 0;

                foreach (double grade in grades)
                {
                    other = grade;
                    sum = sum + grade;
                    average = sum / grades.Count / 100;
                    Console.WriteLine(grade.ToString("N0"));
                }
                Console.WriteLine($"The average for {courseCode} is {average.ToString("P2")}");
            }



        }
    }
}
