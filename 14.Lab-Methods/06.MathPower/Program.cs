namespace _06.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reads two integer numbers from the console: base number and power
            int baseNum = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            MathPower(baseNum, power);
        }

        static void MathPower(int baseNum, int power)
        {
            double result = Math.Pow(baseNum, power);
            Console.WriteLine(result);
        }
    }
}
