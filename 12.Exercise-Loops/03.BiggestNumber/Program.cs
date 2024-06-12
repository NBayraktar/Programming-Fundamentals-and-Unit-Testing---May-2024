namespace _03.BiggestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read an integer number n (the amount of input numbers) and n integer numbers from the console
            int inputAmount = int.Parse(Console.ReadLine());

            // Read n integer numbers from the console and find the biggest number
            int biggestNum = int.MinValue; 
            for (int i = 0; i < inputAmount; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum > biggestNum)
                {
                    biggestNum = currentNum;
                }
            }
            Console.WriteLine(biggestNum);
        }
    }
}
