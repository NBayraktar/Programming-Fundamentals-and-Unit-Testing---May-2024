namespace _06.SpecialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read integer number from the console
            int number = int.Parse(Console.ReadLine());

            // Check whether specNum reading from the console is specical
            int copyNum = number;
            bool isSpecial = false;
            while (copyNum > 0)
            {
                int lastDigit = copyNum % 10;
                if (number % lastDigit == 0)
                {
                    isSpecial = true;
                }
                else
                {
                    isSpecial = false;
                    break;
                }
                copyNum /= 10;
            }
            if (isSpecial)
            {
                Console.WriteLine($"{number} is special");
            }
            else
            {
                Console.WriteLine($"{number} is not special");
            }
        }
    }
}
