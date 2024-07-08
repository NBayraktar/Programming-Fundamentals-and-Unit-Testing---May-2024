using System.Collections.Generic;

namespace _01.StupidPasswords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read an integer number N from the console
            int number = int.Parse(Console.ReadLine());

            // Generates all possible passwords consisting of the following 3 parts:
            // The first part is an even number in the range[2…N]
            // The second digit is an odd number in the range [1…N]
            // The third is the product of the first two
            for (int even = 2; even <= number; even += 2) {
                for (int odd = 1; odd <= number; odd += 2) {
                    int product = even * odd;
                    Console.Write($"{even}{odd}{product} ");
                }
            }
            
        }
    }
}