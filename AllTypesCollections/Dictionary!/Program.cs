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

            Dictionary<string, double> totals = new Dictionary<string, double>();
            string answer;

            do
            {
                Console.WriteLine($"Enter the course code. ex. MIS3013");
                string code = Console.ReadLine().ToUpper();

                if (totals.ContainsKey(code) == false)
                {
                    totals.Add(code, 1);
                }
                else
                {
                    totals[code] = totals[code] + 1;
                }


                Console.WriteLine($"Do you want to enter another course?");
                answer = Console.ReadLine();
            } while (answer.ToLower()[0] == 'y');


        }
    }
}
