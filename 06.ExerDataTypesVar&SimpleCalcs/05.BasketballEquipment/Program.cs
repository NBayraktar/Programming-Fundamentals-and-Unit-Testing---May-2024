namespace _05.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input annual basketball training fee
            int trainingFee = int.Parse(Console.ReadLine());

            // Calculating the expenses
            double sneakers = trainingFee * 0.6;
            double team = sneakers * 0.8;
            double ball = team * 0.25;
            double accessories = ball * 0.2;
            double totalFee = trainingFee + sneakers + team + ball + accessories;

            // Output the total expenses to the console
            Console.WriteLine($"{totalFee}");
        }
    }
}
