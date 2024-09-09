namespace _04.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read two integers from the console
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            CalculateRectangleArea(width, length);
        }

        // Method wich displays rectangle area with given width and length to the console
        static void CalculateRectangleArea(int w, int h)
        {
            int area = w * h;
            Console.WriteLine(area);
        }
    }
}
