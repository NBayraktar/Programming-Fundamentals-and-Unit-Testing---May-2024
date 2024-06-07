namespace _04.NumberOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read 2 real numbers and math operator (string) from the console
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string mathOperator = Console.ReadLine();

            // Calculate and print output to the console formated to the second digit
            if (mathOperator == "+")
            {
                Console.WriteLine($"{num1} + {num2} = {num1 + num2:F2}");
            }
            else if (mathOperator == "-")
            {
                Console.WriteLine($"{num1} - {num2} = {num1 - num2:F2}");
            }
            else if (mathOperator == "*")
            {
                Console.WriteLine($"{num1} * {num2} = {num1 * num2:F2}");
            }
            else
            {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2:F2}");
            }
        }
    }
}
