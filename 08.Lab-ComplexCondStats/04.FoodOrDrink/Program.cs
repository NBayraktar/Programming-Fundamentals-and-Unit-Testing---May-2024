namespace _04.FoodOrDrink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read product (string) from the console
            string product = Console.ReadLine();

            // Choosing wich proguct to print to console
            switch (product)
            {
                case "curry":
                    Console.WriteLine("food");
                    break;
                case "noodles":
                    Console.WriteLine("food");
                    break;
                case "sushi":
                    Console.WriteLine("food");
                    break;
                case "spaghetti":
                    Console.WriteLine("food");
                    break;
                case "bread":
                    Console.WriteLine("food");
                    break;
                case "tea":
                    Console.WriteLine("drink");
                    break;
                case "water":
                    Console.WriteLine("drink");
                    break;
                case "coffee":
                    Console.WriteLine("drink");
                    break;
                case "juice":
                    Console.WriteLine("drink");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
