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


        }
    }
}
