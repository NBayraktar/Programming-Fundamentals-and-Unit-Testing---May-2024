namespace _06.Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read length, width, height in cm, and percentage from the console
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            // Calculating the liters of water that are needed to fill the aquarium
            double volumeAquarium = length * width * height;
            double volumeLiters = volumeAquarium / 1000;
            double occupiedSpace = percentage / 100; 
            double reaquiredLiters = volumeLiters * (1 - occupiedSpace);
            // Output the necesary liters of water to the console
            Console.WriteLine($"{reaquiredLiters:F2}");
        }
    }
}
