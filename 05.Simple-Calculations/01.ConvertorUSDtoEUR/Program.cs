namespace _01.ConvertorUSDtoEUR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read a floating-point number from console (the dollars to be converted)
            double usd = double.Parse(Console.ReadLine());

            // Converting USD to EUR (fixed rate of dollars to euro: 0.88)
            double euro = usd * 0.88;

            // Output the result to the console
            Console.WriteLine($"{euro:F2}");
        }
    }
}
