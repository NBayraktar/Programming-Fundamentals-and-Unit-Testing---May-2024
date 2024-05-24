namespace _02.FourOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read two floating-point numbers: first number and second number
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            // Performing 4 aritmetic operations on the given numbers: + - * /
            double addition = firstNum + secondNum;
            double subtraction = firstNum - secondNum;
            double multiplication = firstNum * secondNum;
            double division = firstNum / secondNum;

            // Printing the results all formatted to the 2nd digit
            Console.WriteLine($"{firstNum:F2} + {secondNum:F2} = {addition:F2}");
            Console.WriteLine($"{firstNum:F2} - {secondNum:F2} = {subtraction:F2}");
            Console.WriteLine($"{firstNum:F2} * {secondNum:F2} = {multiplication:F2}");
            Console.WriteLine($"{firstNum:F2} / {secondNum:F2} = {division:F2}");
        }
    }
}
