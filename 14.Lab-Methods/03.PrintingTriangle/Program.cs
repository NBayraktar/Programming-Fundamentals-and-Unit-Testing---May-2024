namespace _03.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read integer number N from the console
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
            PrintingTriangle(num);
        }

        static void PrintingTriangle(int n)
        {
            for (int i = n; i > 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
