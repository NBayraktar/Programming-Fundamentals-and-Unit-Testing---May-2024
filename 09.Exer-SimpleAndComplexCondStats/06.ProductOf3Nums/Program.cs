namespace _06.ProductOf3Nums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read three real numbers from the console
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            // Print the sign of the product of the three given numbers: "positive", "negative" or "zero"
            if (num1 > 0 && num2 > 2 && num3 < 0)
            {
                Console.WriteLine("negative");
            }
            else if (num1 < 0 && num2 < 0 && num3 > 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("zero");
            }

        }
    }
}
