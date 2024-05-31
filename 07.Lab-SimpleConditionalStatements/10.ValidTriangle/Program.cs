namespace _10.ValidTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reads three integers: the sides of a triangle
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int sideC = int.Parse(Console.ReadLine());

            // Checking if each side is shorter than the sum of the other two
            if (sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideA + sideB)
            {
                Console.WriteLine("Valid Triangle");
            }
            else
            {
                Console.WriteLine("Invalid Triangle");
            }
            
        }
    }
}