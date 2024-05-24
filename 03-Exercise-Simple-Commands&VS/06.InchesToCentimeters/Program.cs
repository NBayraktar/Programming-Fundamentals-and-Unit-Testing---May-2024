namespace _06.InchesToCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input a length in inches from the console
            double inches = double.Parse(Console.ReadLine());

            // Converting to centimeters
            double centimeters = inches * 2.54;

            // Output the converted length in centimeters on the console
            Console.WriteLine($"{centimeters}");
        }
    }
}
