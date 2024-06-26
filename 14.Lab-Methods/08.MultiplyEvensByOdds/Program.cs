namespace _08.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read an integer number from the console
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
        }

        static int GetSumOfEvenDigits(int num) {
            int sum = 0;
            while (num > 0) {
                int lastDigit = num % 10;
                num /= 10;
                if (lastDigit % 2 == 0) {
                    sum += lastDigit;
                }
            }
            return sum;
        }

        static int GetSumOfOddDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                num /= 10;
                if (lastDigit % 2 == 1)
                {
                    sum += lastDigit;
                }
            }
            return sum;
        }
    }
}
