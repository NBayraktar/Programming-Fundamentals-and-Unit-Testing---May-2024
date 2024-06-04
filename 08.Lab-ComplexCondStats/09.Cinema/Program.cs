namespace _09.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reading from the console the type of the movie, count of the rows, and count of the seats per row (integer numbers)
            string movieType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int seats = int.Parse(Console.ReadLine());

            // Calculating the total price of the all seats
            double premierePrice = 12;
            double normal = 7.5;
            double discount = 5;
            if (movieType == "Premiere")
            {
                double ticketCost = rows * seats * premierePrice;
                Console.WriteLine($"{ticketCost:F2}");
            }
            else if (movieType == "Normal")
            {
                double ticketCost = rows * seats * normal;
                Console.WriteLine($"{ticketCost:F2}");
            }
            else
            {
                double ticketCost = rows * seats * discount;
                Console.WriteLine($"{ticketCost:F2}");
            }

        }
    }
}
