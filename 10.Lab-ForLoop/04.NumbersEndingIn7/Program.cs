namespace _04.NumbersEndingIn7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read integer number n 
            int number = int.Parse(Console.ReadLine());

            // Check and print all numbers from 7 to n, ending in 7
            for (int i = 7; i <= number; i += 10)
            {
                Console.WriteLine(i);
            }
        }
    }
}
