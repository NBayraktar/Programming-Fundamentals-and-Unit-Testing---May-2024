namespace _03.OddNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read numbers from the console until an odd number is entered and print result
            int num = int.Parse(Console.ReadLine());

            while (num % 2 == 0)
            {
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(num);
        }
    }
}
