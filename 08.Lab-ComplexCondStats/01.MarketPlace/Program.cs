namespace _01.MarketPlace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read 2 string from the console
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            // Choosing the price for weekday or weekend
            double weekdayBananaPrice = 2.5;
            double weekendBananaPrice = 2.7;
            double weekdayApplePrice = 1.3;
            double weekendApplePrice = 1.6;
            double weekdayKiwiPrice = 2.2;
            double weekendKiwiPrice = 3;

            if (fruit == "Banana")
            {
                if(dayOfWeek == "Weekday")
                {
                    Console.WriteLine($"{weekdayBananaPrice:F2}");
                }
                else
                {
                    Console.WriteLine($"{weekendBananaPrice:F2}");
                }
            }
            else if (fruit == "Apple")
            {
                if (dayOfWeek == "Weekday")
                {
                    Console.WriteLine($"{weekdayApplePrice:F2}");
                }
                else
                {
                    Console.WriteLine($"{weekendApplePrice:F2}");
                }
            }
            else if (fruit == "Kiwi")
            {
                if (dayOfWeek == "Weekday") {
                    Console.WriteLine($"{weekdayKiwiPrice:F2}");
                }
                else
                {
                    Console.WriteLine($"{weekendKiwiPrice:F2}");
                }
            }

        }
    }
}
