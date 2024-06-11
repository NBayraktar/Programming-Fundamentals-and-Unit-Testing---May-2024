namespace _01.PowerOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read 2 integers from the console num and pow
            int num = int.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());

            // Print the result of num to the power of pow
            double result = Math.Pow(num, pow);
            Console.WriteLine(result);
        }
    }
}
