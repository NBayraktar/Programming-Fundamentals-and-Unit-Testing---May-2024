namespace _07.SpecialBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read an integer number from the console(stop number)
            int stopNum = int.Parse(Console.ReadLine());

            // Keep reading integers until it finds the stop number. When the stop number is found, increase the value of the previous number before it with 20% and print it 
            int lastNum = 0;
            while (true)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum == stopNum)
                {
                    break;
                }
                lastNum = currentNum;
            }
            double result = lastNum * 1.2;
            Console.WriteLine(result);
        }
    }
}
