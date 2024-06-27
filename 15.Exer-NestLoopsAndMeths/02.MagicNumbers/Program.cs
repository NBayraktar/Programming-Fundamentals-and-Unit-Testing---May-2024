namespace _02.MagicNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read an integer number N from the console
            int number = int.Parse(Console.ReadLine());

            // Find all 3 digit magic numbers
            for (int a = 1; a <= number; a++)
            {
                for (int b = 1; b <= number; b++)
                {
                    for (int c = 1; c <= number; c++)
                    {
                        if (a >= 10 || b >= 10 || c >= 10)
                        {
                            continue;
                        }

                        int magicNum = a * b * c;
                        if (number == magicNum)
                        {
                            Console.Write($"{a}{b}{c} ");
                        }
                    }
                }
            }

        }
    }
}
