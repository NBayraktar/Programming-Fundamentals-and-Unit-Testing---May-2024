namespace _05.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read an integer positive number from the console
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            while (num != 0)
            {
                int lastDigit = num % 10;
                sum += lastDigit;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
