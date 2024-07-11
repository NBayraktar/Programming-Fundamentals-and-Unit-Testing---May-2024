namespace _07.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read two integers numbers from the console in range [1...10]
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            // Calculate the factorial of each number, divide the 1st calculated factorial by the 2nd calculated factorial (integer division) and print the result 
            int firstFactorial = CalculateFactorial(firstNum);
            int secondFactorial = CalculateFactorial(secondNum);

            int result = firstFactorial / secondFactorial;
            Console.WriteLine(result);
        }

        static int CalculateFactorial(int number) {
            int sum = 1;
            for (int i = 1; i <= number; i++) {
                sum *= i;
            }
            return sum;
        }
    }
}
