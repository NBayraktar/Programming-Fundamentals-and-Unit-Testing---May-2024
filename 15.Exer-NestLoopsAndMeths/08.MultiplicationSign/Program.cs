namespace _08.MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read three integer numbers from the console
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            PrintSign(num1, num2, num3);

            // Find if num1 * num2 * num3 (the product) is negative, positive or zero
            static void PrintSign(int n1, int n2, int n3)
            {
                int product = n1 * n2 * n3;
                if (product > 0)
                {
                    Console.WriteLine("positive");
                }
                else if (product < 0)
                {
                    Console.WriteLine("negative");
                }
                else
                {
                    Console.WriteLine("zero");
                }
            }
        }
    }
}
