namespace _05.VacationExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // From the console read: season (string), accommodation type (string) and count of the days (integer)
            string season = Console.ReadLine();
            string accommodation = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
             
            // Calculation of expenses 
            if (season == "Spring")
            {
                if (accommodation == "Hotel")
                {
                    double totalPrice = (days * 30) * 0.8;
                    Console.WriteLine($"{totalPrice:F2}");
                }
                else
                {
                    double totalPrice = (days * 10) * 0.8;
                    Console.WriteLine($"{totalPrice:F2}");
                }
            }
            else if(season == "Summer")
            {
                if (accommodation == "Hotel")
                {
                    double totalPrice = days * 50;
                    Console.WriteLine($"{totalPrice:F2}");
                }
                else
                {
                    double totalPrice = days * 30;
                    Console.WriteLine($"{totalPrice:F2}");
                }
            }
            else if (season == "Autumn")
            {
                if (accommodation == "Hotel")
                {
                    double totalPrice = (days * 20) * 0.7;
                    Console.WriteLine($"{totalPrice:F2}");
                }
                else
                {
                    double totalPrice = (days * 15) * 0.7;
                    Console.WriteLine($"{totalPrice:F2}");
                }
            }
            else
            {
                if (accommodation == "Hotel")
                {
                    double totalPrice = (days * 40) * 0.9;
                    Console.WriteLine($"{totalPrice:F2}");
                }
                else
                {
                    double totalPrice = (days * 10) * 0.9;
                    Console.WriteLine($"{totalPrice:F2}");
                }
            }
        }
    }
}
