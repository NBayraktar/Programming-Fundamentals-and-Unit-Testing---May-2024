namespace _01.FreezingWeather
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the number from the console (temperature in Celsius)
            int tempC = int.Parse(Console.ReadLine());

            // Checks whether the temperature is below zero
            if (tempC <= 0)
            {
                Console.WriteLine("Freezing weather!");
            }
        }
    }
}
