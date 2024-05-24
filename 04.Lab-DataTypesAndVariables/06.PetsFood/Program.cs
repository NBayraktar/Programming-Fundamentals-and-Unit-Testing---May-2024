namespace _06.PetsFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input packs of dog and cat food from the console
            int packsDogFood = int.Parse(Console.ReadLine());
            int packsCatFood = int.Parse(Console.ReadLine());

            // Calculating the expenses for pet's food
            double priceDogFood = packsDogFood * 2.5;
            double priceCatFood = packsCatFood * 4;
            double expenses = priceDogFood + priceCatFood;

            // Output the result to the console
            Console.WriteLine($"{expenses:F2} lv.");
        }
    }
}
