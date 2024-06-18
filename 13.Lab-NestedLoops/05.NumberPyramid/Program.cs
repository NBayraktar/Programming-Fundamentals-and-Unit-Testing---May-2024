namespace _05.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reads an integer number n from the console 
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            // Print a pyramid of numbers to the console
            for (int row = 1; row <= num; row++) {
                for (int col = 1; col <= row; col++) {
                    int currentNum = 1;
                    sum += currentNum;
                   if (sum <= num)
                    {
                        Console.Write($"{sum} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
