namespace _08.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read a sequence of incomes / expenses, until "End" is read

            string input = Console.ReadLine();

            double balance = 0;
            while (input != "End")
            {
                double currentNum = double.Parse(input);
                if (currentNum >= 0)
                {
                    Console.WriteLine($"Increase: {currentNum:F2}");
                    balance += currentNum;
                }
                else
                {
                    Console.WriteLine($"Decrease: {Math.Abs(currentNum):F2}");
                    balance -= Math.Abs(currentNum);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Balance: {balance:F2}");
        }
    }
}
