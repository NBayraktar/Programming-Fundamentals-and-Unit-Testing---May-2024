namespace _04.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read 2 integer numbers from the console: floors count and estates count per floor
            int floor = int.Parse(Console.ReadLine());
            int room = int.Parse(Console.ReadLine());
            
            // print a table, representing a building:
            for (int f = floor; floor >= 1; floor--)
            {
                for (int r = 1; r <= room; room++)
                {
                    if (f == floor)
                    {
                        Console.Write($"L{f}{r}");
                    }
                    else if (r % 2 == 0) {
                        Console.Write($"O{f}{r}");
                    }
                    else
                    {
                        Console.Write($"A{f}{r}");
                    }
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
