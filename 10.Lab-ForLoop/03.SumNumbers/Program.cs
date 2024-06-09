namespace _03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read integer number n - the count of numbers to sum
            int countOfNums = int.Parse(Console.ReadLine());

            // Check count of numbers and print their sum to the console
            double sum = 0;
            for (int i = 1; i <= countOfNums; i++)
            {
                double num = double.Parse(Console.ReadLine());

                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
