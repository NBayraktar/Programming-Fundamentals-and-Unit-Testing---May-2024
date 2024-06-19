namespace _02.EvenPowersOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read integer number from the console
            int num = int.Parse(Console.ReadLine());

            // Print on the console the number two on even powers in the range [0; n];
            for (int i = 0; i <= num; i++) {
                if (i % 2 == 0) {
                    Console.WriteLine(Math.Pow(2, i));
                }
            }
        }
    }
}
