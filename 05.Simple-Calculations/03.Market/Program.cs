namespace _03.Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read four floating-point numbers from console(tomato price and tomaton quantity, cucumber price and cucumber quantity)
            double tomatoPrice = double.Parse(Console.ReadLine());
            double tomatoQuantity = double.Parse(Console.ReadLine());
            double cucumberPrice = double.Parse(Console.ReadLine());
            double cucumberQuantity = double.Parse(Console.ReadLine());

            // Calculating the total cost of the production by given quantities and prices
            double tomatoesCost = tomatoPrice * tomatoQuantity;
            double cucumbersCost = cucumberPrice * cucumberQuantity;
            double totalCost = tomatoesCost + cucumbersCost;

            // Print the total cost, formatted to the 2nd digit
            Console.WriteLine($"{totalCost:F2}");
        }
    }
}

