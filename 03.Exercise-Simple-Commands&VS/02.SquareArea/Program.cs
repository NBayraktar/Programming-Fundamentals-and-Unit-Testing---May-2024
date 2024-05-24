namespace _02.SquareArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input length of one side of a square
            int length = int.Parse(Console.ReadLine());

            // Calculation of area
            int area = length * length;

            // Output the result
            Console.WriteLine($"{area}");
        }
    }
}
