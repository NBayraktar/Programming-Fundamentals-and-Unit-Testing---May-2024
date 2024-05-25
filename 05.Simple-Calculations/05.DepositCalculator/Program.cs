namespace _05.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Reading deposited amount, term of deposit, annual interest rate from the console
            double depositAmount = double.Parse(Console.ReadLine());
            int termOfDeposit = int.Parse(Console.ReadLine());
            double interestRate = double.Parse(Console.ReadLine());

            // Calculating the deposited amount
            double amount = depositAmount + termOfDeposit * (depositAmount * (interestRate / 100)) / 12;

            // Printing the amount on the console at the end of the term
            Console.WriteLine(amount);

        }
    }
}


