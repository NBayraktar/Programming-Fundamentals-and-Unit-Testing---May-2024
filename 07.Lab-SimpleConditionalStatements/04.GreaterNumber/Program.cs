namespace _04.GreaterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input numbers from the console
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            // Finds the greater number
            if (num1 > num2)
            {
                Console.WriteLine($"Greater number: {num1}");
            }
            else
            {
                Console.WriteLine($"Greater number: {num2}");
            }
        }
    }
}

