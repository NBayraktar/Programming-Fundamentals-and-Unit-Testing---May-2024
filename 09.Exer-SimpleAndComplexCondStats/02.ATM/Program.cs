namespace _02.ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reads 3 integer numbers which represents the following values: balance, withdraw and limit
            int balance = int.Parse(Console.ReadLine());
            int withdraw = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());

            // Output the result to the console, based on the given input parameters
            if (balance >= withdraw)
            {
                if (withdraw <= limit)
                {
                    Console.WriteLine("The withdraw was successful.");
                }
                else
                {
                    Console.WriteLine("The limit was exceeded.");
                }
            }
            else
            {
                if (withdraw > limit)
                {
                    Console.WriteLine("The limit was exceeded.");
                }
                else
                {
                    Console.WriteLine("Insufficient availability.");
                }
            }
        }
    }
}
