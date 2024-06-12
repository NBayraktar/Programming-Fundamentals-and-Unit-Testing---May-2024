namespace _02.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read an integer number n from the console
            int num = int.Parse(Console.ReadLine());

            // Print a multiplication table of size 10 for given integer n

            for (int i = 1; i <= 10; i++)
            {
                int result = num * i;
                Console.WriteLine($"{num } x {i} = {result}");
            }
        }
    }
}
