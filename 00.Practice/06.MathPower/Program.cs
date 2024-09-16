namespace _06.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read two integer numbers from the console
            int baseNumber = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            int output = MathPower(baseNumber, power);
            Console.WriteLine(output);
        }

        static int MathPower(int baseNum, int pow)
        {
            double result = Math.Pow(baseNum, pow);
            return (int)result;
        }
    }
}
