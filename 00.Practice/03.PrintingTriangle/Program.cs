namespace _03.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read an integer number N from the console
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                    if (j == number)
                    {
                        PrintingTriangle(number);
                    }
                }
                Console.WriteLine();
            }

            static void PrintingTriangle(int number)
            {
                Console.WriteLine();
                for (int i = number - 1; i > 0; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write($"{j} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
