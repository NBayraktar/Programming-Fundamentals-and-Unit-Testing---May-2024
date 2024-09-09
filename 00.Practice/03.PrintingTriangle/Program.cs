namespace _03.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read an integer number N from the console
            int number = int.Parse(Console.ReadLine());

            for (int row = 1; row <= number; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{col} ");
                }
                Console.WriteLine();
            }
            PrintingTriangle(number);
        }

        static void PrintingTriangle(int num)
        {
            for (int row = num - 1; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{col} ");
                }
                Console.WriteLine();
            }
        }
    }
}
