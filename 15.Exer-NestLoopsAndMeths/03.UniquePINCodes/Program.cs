﻿namespace _03.UniquePINCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read 3 integer numbers each is an upper limit;
            int max1 = int.Parse(Console.ReadLine());
            int max2 = int.Parse(Console.ReadLine());
            int max3 = int.Parse(Console.ReadLine());

            // Generate unique 3-digit PIN codes
            for (int i = 1; i <= max1; i++) {
                for (int j = 1; j <= max2; j++) {
                    for (int k = 1; k <= max3; k++) {
                        if (i % 2 == 0 && k % 2 == 0) {
                            if (j == 2 || j == 3 || j == 5 || j == 7)
                            {
                                Console.WriteLine($"{i}{j}{k}");
                            }
                        }
                    }
                }
            }
        }
    }
}
