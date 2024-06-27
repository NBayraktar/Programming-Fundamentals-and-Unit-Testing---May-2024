namespace _09.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read a string on the first line from the console representing a product. Read an integer on the second line from the console, representing the quantity of the product
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            CalculateTotalPrice(product, quantity);
            
        }

        static void CalculateTotalPrice(string p, int q)
        {
            double total = 0;
            if (p != "" && q > 0)
            {
                switch (p)
                {
                    case "coffee":
                        total += q * 1.50;
                        break;
                    case "water":
                        total += q * 1.00;
                        break;
                    case "coke":
                        total += q * 1.40;
                        break;
                    case "snacks":
                        total += q * 2.00;
                        break;
                }
            }
            Console.WriteLine($"{total:F2}");
        }
    }
}
