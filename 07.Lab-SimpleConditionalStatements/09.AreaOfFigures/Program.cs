namespace _09.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input type of the figure (string): "square", "rectangle" and "circle"
            string figureType = Console.ReadLine();
                
            // Checking the fire type and calculate area of the given figure
            if (figureType == "square") {
                double side = double.Parse(Console.ReadLine());
                double squareArea = side * side;
                Console.WriteLine($"{squareArea:F2}");
            } 
            else if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double length = double.Parse(Console.ReadLine());
                double rectangleArea = width * length;
                Console.WriteLine($"{rectangleArea:F2}");
            }
            else
            {
                double radius = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * radius * radius;
                Console.WriteLine($"{circleArea:F2}");
            }
        }
    }
}
