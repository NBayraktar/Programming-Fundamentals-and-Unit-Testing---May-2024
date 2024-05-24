namespace _02.CalculateSpeed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input distance and time
            double distance = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            // Calculate the speed needed to travel the specified distance for the specified time: speed = distance / time
            double speed = distance / time;

            // Output the result of speed formatted to 2nd digit
            Console.WriteLine($"{speed:F2}");
        }
    }
}
