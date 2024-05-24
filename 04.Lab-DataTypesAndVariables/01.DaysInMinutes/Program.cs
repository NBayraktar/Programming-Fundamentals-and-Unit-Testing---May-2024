namespace _01.DaysInMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input a single integer (the days to be converted)
            int days = int.Parse(Console.ReadLine());

            // Converting the days to minutes (1 day = 24 hours * 60 minutes)
            int minutes = days * 24 * 60;

            // Output the result to the console
            Console.WriteLine($"Minutes = {minutes}");
        }
    }
}
