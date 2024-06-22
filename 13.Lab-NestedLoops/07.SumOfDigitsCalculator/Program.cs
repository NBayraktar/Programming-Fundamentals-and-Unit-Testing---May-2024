namespace _07.SumOfDigitsCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Continuously read integers until "End" is entered from the console
            string number = Console.ReadLine();

            while (number != "End")
            {
                int currentNum = int.Parse(number);
                int sum = 0;
                while (currentNum != 0)
                {
                    int lastDigit = currentNum % 10;
                    sum += lastDigit;
                    currentNum /= 10;

                }
                Console.WriteLine($"Sum of digits = {sum}");
                number = Console.ReadLine();

            }
            Console.WriteLine("Goodbye");
        }
    }
}