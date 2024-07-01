namespace _02.SumAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read an array of integers (from a single line separated with a space)
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            // Print the sum of all elements in the given array to the console
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}
