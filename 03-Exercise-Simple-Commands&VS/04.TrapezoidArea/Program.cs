namespace _04.TrapezoidArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reads three integer numbers, which represent the first base, second base and height of the trapezoid
            int baseOne = int.Parse(Console.ReadLine());
            int baseTwo = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            // Calculates trapezoid's area 
            int trapArea = (baseOne + baseTwo) / 2 * height;

            // Prints the calculated area on the console
            Console.WriteLine($"{trapArea}");
        }
    }
}
