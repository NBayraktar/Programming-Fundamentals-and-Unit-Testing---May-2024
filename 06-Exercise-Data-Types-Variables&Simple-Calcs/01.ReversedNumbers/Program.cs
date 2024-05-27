namespace _01.ReversedNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read 3 floating point numbers from the console
            double firstNum = double.Parse(Console.ReadLine());
            double secontNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());

            // Output the result to console in reversed order
            Console.WriteLine(thirdNum);
            Console.WriteLine(secontNum);
            Console.WriteLine(firstNum);
        }
    }
}
