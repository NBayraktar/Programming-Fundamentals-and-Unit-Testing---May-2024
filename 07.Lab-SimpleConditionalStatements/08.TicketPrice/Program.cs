namespace _08.TicketPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input string from the console
            string ticketType = Console.ReadLine();

            // Checking the ticket type
            double studentTicket = 1.00;
            double regularTicket = 1.60;

            if (ticketType == "student")
            {
                Console.WriteLine($"${studentTicket:f2}");
            }
            else if (ticketType == "regular")
            {
                Console.WriteLine($"${regularTicket:f2}");
            }
            else
            {
                Console.WriteLine("Invalid ticket type!");
            }
        }
    }
}
