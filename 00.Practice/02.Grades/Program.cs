﻿namespace _02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read a floating point number (grade) from the console
            double grade = double.Parse(Console.ReadLine());

            // Calling method
            PrintGrade(grade);
        }

        // Method that receives a grade between 2.00 and 6.00 and prints the corresponding grade in words
        static void PrintGrade(double grade)
        {
            if (grade >= 2.00 && grade <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grade >= 3.00 && grade <= 3.49)
            {
                Console.WriteLine("Average");
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
