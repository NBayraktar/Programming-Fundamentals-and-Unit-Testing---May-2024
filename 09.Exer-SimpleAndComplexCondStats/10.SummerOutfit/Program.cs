namespace _10.SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read 2 lines from the console: Temperature - an integer in the range [10... 42]; Text, time of day - with possibilities - "Morning", "Afternoon", "Evening"
            int degrees = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            // Checking time of day and degree and printing the result to the console
            if (degrees >= 10 && degrees <= 18)
            {
                if (timeOfDay == "Afternoon" || timeOfDay == "Evening")
                {
                    string cloth = "Shirt";
                    string shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {cloth} and {shoes}.");
                }
                else
                {
                    string cloth = "Sweatshirt";
                    string shoes = "Sneakers";
                    Console.WriteLine($"It's {degrees} degrees, get your {cloth} and {shoes}.");
                }

            }
            else if (degrees > 18 && degrees <= 24)
            {
                if (timeOfDay == "Morning" || timeOfDay == "Evening")
                {
                    string cloth = "Shirt";
                    string shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {cloth} and {shoes}.");
                }
                else
                {
                    string cloth = "T-Shirt";
                    string shoes = "Sandals";
                    Console.WriteLine($"It's {degrees} degrees, get your {cloth} and {shoes}.");
                }
            }
            else
            {
                if (timeOfDay == "Morning")
                {
                    string cloth = "T-Shirt";
                    string shoes = "Sandals";
                    Console.WriteLine($"It's {degrees} degrees, get your {cloth} and {shoes}.");
                }
                else if (timeOfDay == "Afternoon")
                {
                    string cloth = "Swim Suit";
                    string shoes = "Barefoot";
                    Console.WriteLine($"It's {degrees} degrees, get your {cloth} and {shoes}.");
                }
                else
                {
                    string cloth = "Shirt";
                    string shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {cloth} and {shoes}.");
                }
            }
        }
    }
}
