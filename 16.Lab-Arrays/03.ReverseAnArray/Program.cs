using System.Security.Cryptography;

namespace _03.ReverseAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read an integer number N from the console
            int num = int.Parse(Console.ReadLine());

            // Store the numbers in the array of integers
            int[] arrayOfNums = new int[num];
            for (int i = 0; i < num; i++) {
                arrayOfNums[i] = int.Parse(Console.ReadLine());
            }

            // Reverse the numbers in the array and print the elements on a single line, space separated
            for (int i = arrayOfNums.Length - 1; i >= 0; i--) {
                Console.Write($"{arrayOfNums[i]} ");
            }
        }
    }
}
