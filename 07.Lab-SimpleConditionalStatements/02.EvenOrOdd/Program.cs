namespace _02.EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input number from the console
            int number = int.Parse(Console.ReadLine());

            // Checks the number for 'even' or 'odd'
            if (number % 2 == 0) {
                Console.WriteLine("even");
            } else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
