namespace _04.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input from the console - distance in meters
            double meters = double.Parse(Console.ReadLine());

            // Converting given meters to kilometers
            double kilometers = meters / 1000;

            // Printing the kilometers formatted to the 2nd digit after the decimal point
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
