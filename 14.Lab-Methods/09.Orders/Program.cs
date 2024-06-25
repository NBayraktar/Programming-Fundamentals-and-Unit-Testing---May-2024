namespace _09.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read a string on the first line from the console representing a product. Read an integer on the second line from the console, representing the quantity of the product
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double sum = CalculateTotalPrice(product, quantity);
            Console.WriteLine($"{sum:F2}");
        }

        static double CalculateTotalPrice(string p, int q) {
            double coffee = 1.50;
            double water = 1.00;
            double coke = 1.40;
            double snacks = 2.00;
            double total = 0;
            if (p == "coffee" && q > 0)
            {
                 total += q * coffee;
                
            }
            else if (p == "water" && q > 0)
            {
                total += q * water;
            }
            else if (p == "coke" && q > 0)
            {
                total += q * coke;
            }
            else if (p == "snacks" && q > 0)
            {
                total += q * snacks;
            }
           return (int)total;
        }
    }
}
