namespace _01.NumbersFromNto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read integer number from the console
            int num = int.Parse(Console.ReadLine());
            
            // Print the numbers from N to 1, each on separate line
            for (int i = num; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
