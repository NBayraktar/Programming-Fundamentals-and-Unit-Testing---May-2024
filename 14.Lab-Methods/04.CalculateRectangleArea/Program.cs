﻿namespace _04.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read two integer numbers from the console: width and length;
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            CalculateRectangleArea(width, height);
        }

        static void CalculateRectangleArea(int width, int height)
        {
            int area = width * height;
            Console.WriteLine(area);
        }
    }
}
