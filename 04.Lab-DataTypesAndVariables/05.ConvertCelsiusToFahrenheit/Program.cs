namespace _05.ConvertCelsiusToFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input from the console (temperature in Celsius)
            double celsius = double.Parse(Console.ReadLine());

            // Converting given temperature in Fahrenheit
            double fahrenheit = celsius * 1.8 + 32;

            // Output the result formatted to 2nd digit
            Console.WriteLine($"{fahrenheit:F2}");
        }
    }
}
