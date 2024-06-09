namespace _02.DecreasingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read an integer number N from console
            int number = int.Parse(Console.ReadLine());

            // Print the numbers from N down to 1(inclusively), each on separate line
            while (number >= 1)
            {
                Console.WriteLine(number);
                number--;
            }
        }
    }
}
