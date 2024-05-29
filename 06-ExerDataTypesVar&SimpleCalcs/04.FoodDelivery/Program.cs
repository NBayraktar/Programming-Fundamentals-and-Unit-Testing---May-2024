namespace _04.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input from the console for chicken menu, fish menu, vegetarian menu
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegeterian = int.Parse(Console.ReadLine());

            // Calculation cost for takeaway order
            double chickenMenuPrice = 10.35;
            double fishMenuPrice = 12.4;
            double vegeMenuPrice = 8.15;
            double delivery = 2.5;
            double chickenOrderCost = chicken * chickenMenuPrice;
            double fishOrderCost = fish * fishMenuPrice;
            double vegeOrderCost = vegeterian * vegeMenuPrice;
            double desertCost = (chickenOrderCost + fishOrderCost + vegeOrderCost) * 0.2;
            double totalOrderCost = chickenOrderCost + fishOrderCost + vegeOrderCost + desertCost + delivery;

            // Print the total cost to the console
            Console.WriteLine($"{totalOrderCost}");
        }
    }
}
