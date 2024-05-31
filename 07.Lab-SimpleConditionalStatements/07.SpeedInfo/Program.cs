namespace _07.SpeedInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Input floating poin number (speed)
           double speed = double.Parse(Console.ReadLine());

            // Checking if the speed is slow or fast
            if (speed <= 30)
            {
                Console.WriteLine("Slow");
            }
            else {
                Console.WriteLine("Fast");
            }
        }
    }
}

