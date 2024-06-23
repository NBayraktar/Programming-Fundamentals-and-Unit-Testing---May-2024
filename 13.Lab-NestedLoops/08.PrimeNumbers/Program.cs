namespace _08.PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reads two integer numbers: start of the range and end of the range
            int numStart = int.Parse(Console.ReadLine());
            int numEnd = int.Parse(Console.ReadLine());

            //	Print all prime numbers in given range to the console
            for (int i = numStart; i < numEnd; i++) {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0) {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
