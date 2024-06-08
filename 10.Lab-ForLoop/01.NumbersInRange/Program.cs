namespace _01.NumbersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read 2 integer numbers from the console
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            // Print the numbers in the given range (include start and end number), each on the new line
            for (int i = num1; i <= num2; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
