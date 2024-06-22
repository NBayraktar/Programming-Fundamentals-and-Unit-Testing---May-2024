namespace _06.TravelSavings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read a destination (string) and needed budget (floating-point number) for the destination
            string destination = "";


            // Calculate the money collection for multiple travel destinations
            while ((destination = Console.ReadLine()) != "End")
            {
                double moneyNeeded = double.Parse(Console.ReadLine());
                double sum = 0;
                while (moneyNeeded > sum)
                {
                    double addedMoney = double.Parse(Console.ReadLine());
                    sum += addedMoney;
                    Console.WriteLine($"Collected: {sum:F2}");
                }
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}
