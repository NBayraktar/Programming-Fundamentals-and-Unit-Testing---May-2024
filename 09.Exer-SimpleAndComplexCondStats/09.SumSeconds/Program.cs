namespace _09.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read 3 integers from the console
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());

            // Calculate athletes total time in the format "minutes:seconds"
            double totalTime = time1 + time2 + time3;
            double minutes = totalTime / 60;
            double seconds = totalTime % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{(int)minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{(int)minutes}:{seconds}");
            }
        }
    }
}
