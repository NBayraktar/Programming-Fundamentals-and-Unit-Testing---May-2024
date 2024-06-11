namespace _06.NumberInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read integer number from the console
            int number = int.Parse(Console.ReadLine());

            // Check if the number is in the range [1...100]
            while (number < 1 || number > 100)
            {
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(number);
        }
    }
}
