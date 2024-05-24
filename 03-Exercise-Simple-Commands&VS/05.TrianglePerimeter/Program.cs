namespace _05.TrianglePerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inputs for sides of the triangle
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int sideC = int.Parse(Console.ReadLine());

            // Calculation the triangle's perimeter
            int trianglePerimeter = sideA + sideB + sideC;

            // Output the calculated perimeter on the console
            Console.WriteLine($"{trianglePerimeter}");
        }
    }
}
