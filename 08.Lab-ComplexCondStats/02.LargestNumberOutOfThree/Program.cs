﻿namespace _02.LargestNumberOutOfThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read 3 integer numbers from the console
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            // Checking wich number is bigger
            if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine(first);
                }
                else
                {
                    Console.WriteLine(third);
                }
            }
            else if (second > first)
            {
                if (second > third)
                {
                    Console.WriteLine(second);
                }
                else
                {
                    Console.WriteLine(third);
                }
            }
            else
            {
                Console.WriteLine(third);
            }
        }
    }
}
