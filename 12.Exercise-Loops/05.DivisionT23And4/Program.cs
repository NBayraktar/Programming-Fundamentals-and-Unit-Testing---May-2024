namespace _05.DivisionT23And4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read an integer number N from the console
            int num = int.Parse(Console.ReadLine());


            // Find in percentages how many of these integers can divide without a remainder to numbers 2, 3 and 4
            int divisible2 = 0;
            int divisible3 = 0;
            int divisible4 = 0;

            for (int i = 0; i < num; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum % 2 == 0)
                {
                    divisible2++;
                }
                if (currentNum % 3 == 0)
                {
                    divisible3++;
                }
                if (currentNum % 4 == 0)
                {
                    divisible4++;
                }
            }
            double percent2 = (double)divisible2 / num * 100;
            double percent3 = (double)divisible3 / num * 100;
            double percent4 = (double)divisible4 / num * 100;

            Console.WriteLine($"{percent2:F2}%");
            Console.WriteLine($"{percent3:F2}%");
            Console.WriteLine($"{percent4:F2}%");

        }
    }
}
