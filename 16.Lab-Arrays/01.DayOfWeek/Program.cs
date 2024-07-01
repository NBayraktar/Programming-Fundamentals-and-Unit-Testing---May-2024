namespace _01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read an integer number (day) from the console
            int day = int.Parse(Console.ReadLine());

            // Array of days
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            // Check the day is it in range and print the message to the console
            if (day < 1 || day > 7)
            {
                Console.WriteLine("Invalid day!");
                return;
            }
            Console.WriteLine(days[day - 1]);
        }
    }
}
