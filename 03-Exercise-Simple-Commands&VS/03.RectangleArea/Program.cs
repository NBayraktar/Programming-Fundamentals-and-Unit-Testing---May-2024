namespace _03.RectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input length and width of the rectangle
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            // Calculate the rectangle's area
            int area = length * width;

            // Prints the calculated area on the console
            Console.WriteLine($"{area}");
        }
    }
}
