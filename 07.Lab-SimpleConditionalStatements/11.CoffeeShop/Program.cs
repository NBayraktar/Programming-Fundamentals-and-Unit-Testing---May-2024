namespace _11.CoffeeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input drink name (coffee or tea) and extra (sugar or no)
            string hotDrink = Console.ReadLine();
            string extra = Console.ReadLine();

            // Calculation drink price
            double coffeePrice = 1.00;
            double teaPrice = 0.6;
            double sugar = 0.4;
            if (hotDrink == "coffee" && extra == "sugar")
            {
                double coffeeCost = coffeePrice + sugar;
                Console.WriteLine($"Final price: ${coffeeCost:F2}");
            }
            else if (hotDrink == "coffee" && extra == "no")
            {
                Console.WriteLine($"Final price: ${coffeePrice:F2}");
            }
            else if (hotDrink == "tea" && extra == "sugar")
            {
                double teaCost = teaPrice + sugar;
                Console.WriteLine($"Final price: ${teaCost:F2}");
            }
            else
            {
                Console.WriteLine($"Final price: ${teaPrice:F2}");
            }
        }
    }
}
