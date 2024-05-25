namespace _04.Tiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reading 4 floating-point numbers from the console: bathroom width, bathroom height, tile width, tile height
            double widthBathroom = double.Parse(Console.ReadLine());
            double heightBathroom = double.Parse(Console.ReadLine());
            double widthTile = double.Parse(Console.ReadLine());
            double heightTile = double.Parse(Console.ReadLine());

            // Calculating how many tiles will be needed (add 10% surplus)
            double bathroomArea = widthBathroom * heightBathroom;
            double surplus = bathroomArea * 1.1;
            double tileArea = widthTile * heightTile;
            double totalTiles = surplus / tileArea;

            // Print the count of the needed tiles, rounded to the nearest integer
            Console.WriteLine($"{Math.Round(totalTiles)}");
        }
    }
}


