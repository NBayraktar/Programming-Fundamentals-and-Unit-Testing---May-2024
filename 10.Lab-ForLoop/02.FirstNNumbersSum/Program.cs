namespace _02.FirstNNumbersSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read an integer number 'n' from the console
            int num = int.Parse(Console.ReadLine());

            // Sums all numbers from 1 to n and output the result to the console
            int sum = 1; 
            Console.Write(1);
            for (int i = 2; i <= num; i++)
            {
                Console.Write("+" + i);
                sum += i;
            }
            Console.WriteLine("=" + sum);
        }
    }
}
