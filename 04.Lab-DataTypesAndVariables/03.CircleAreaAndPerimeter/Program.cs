namespace _03.CircleAreaAndPerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read one floating-point number: the radius of a circle
            double circleRadius = double.Parse(Console.ReadLine());

            // Calculation the area and the perimeter of a circle
            double circleArea = circleRadius * circleRadius * Math.PI;
            double circlePerimeter = 2 * Math.PI * circleRadius;

            // Output the result on the console formatted to 2nd digit
            Console.WriteLine($"Area = {circleArea:F2}");
            Console.WriteLine($"Perimeter = {circlePerimeter:F2}");
        }
    }
}
