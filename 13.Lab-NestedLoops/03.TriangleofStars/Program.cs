namespace _03.TriangleofStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the size (integer number) of a triangle from the console
            int size = int.Parse(Console.ReadLine());

            // Print triangle of stars to the console
            for (int row = 1; row <= size; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"*");
                }
                Console.WriteLine();
            }
        }
    }
}
