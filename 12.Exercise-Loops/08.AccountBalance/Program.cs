namespace _08.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read a sequence of incomes / expenses, until "End" is read

            double balance = 0;
            while (true)
            {
                double money = double.Parse(Console.ReadLine());

                if (money > 0)
                {
                    balance += money;
                    Console.WriteLine($"Increase: {money:F2}");
                }
                else if (money < 0)
                {
                    balance = balance - Math.Abs(money);
                    Console.WriteLine($"Decrease: {Math.Abs(money):F2}");
                    string end = Console.ReadLine();
                    break;
                }
            }
            Console.WriteLine($"Balance: {balance:F2}");

        }
    }
}
