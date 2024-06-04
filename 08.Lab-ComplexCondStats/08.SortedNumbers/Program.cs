namespace _08.SortedNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reading 3 integer numbers from the console
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            // Based on the order of the numbers, print Ascending, Descending, Not sorted
            if (num1 < num2 && num2 < num3)
            {
                Console.WriteLine("Ascending");
            }
            else if (num1 > num2 && num2 > num3)
            {
                Console.WriteLine("Descending");
            }
            else
            {
                Console.WriteLine("Not sorted");
            }
        }
    }
}
