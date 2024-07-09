namespace _05.HappyNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read an integer number from the console
            int number = int.Parse(Console.ReadLine());

            // Generate all 4-digit happy numbers {d1}{d2}{d3}{d4} for given integer N: a number is happy if d1 + d2 == d3 + d4 == N
            // 4 digit number between 1000 - 9999
            // d1 [1, 9]; d2 [0, 9]; d3 [0, 9; d4 [0, 9]

            for (int d1 = 1; d1 <= 9; d1++)
            {
                for (int d2 = 0; d2 <= 9; d2++)
                {
                    for (int d3 = 0; d3 <= 9; d3++)
                    {
                        for (int d4 = 0; d4 <= 9; d4++)
                        {
                           if (d1 + d2 == number &&  d3 + d4 == number)
                            {
                                Console.Write($"{d1}{d2}{d3}{d4} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
