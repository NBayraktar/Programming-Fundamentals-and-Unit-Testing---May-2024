namespace _05.NumbersFrom1ToNover3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read integer number n - end of the range
            int number = int.Parse(Console.ReadLine());

            // Print all numbers from 1 to n, over 3 (inclusively)
            for (int i = 1; i <= number; i += 3) {
                Console.WriteLine(i);
            }
        }
    }
}
