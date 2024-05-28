namespace _03.Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input from the console - required amount of nylon (in square meters), required amount of paint (liters), quantity of thinner (liters), hours needed for the craftsmen to do the work
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int craftsmenHours = int.Parse(Console.ReadLine());

            // Calculating const of repear
            double protectingNylonPrice = 1.5;
            double paintPrice = 14.5;
            double thinnerPrice = 5;
            double bags = 0.4;

            double nylonCost = (nylon + 2) * protectingNylonPrice;
            double paintCost = (paint * 1.1) * paintPrice;
            double thinnerCost = thinner * thinnerPrice;
            double materialCost = nylonCost + paintCost + thinnerCost + bags;
            double craftsmenCost = (materialCost * 0.3) * craftsmenHours;
            double totalCostRepear = materialCost + craftsmenCost;

            // Output the result to the console
            Console.WriteLine($"{totalCostRepear}");
        }
    }
}
