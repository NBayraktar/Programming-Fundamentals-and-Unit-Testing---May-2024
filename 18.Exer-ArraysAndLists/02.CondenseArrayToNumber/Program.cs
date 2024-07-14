namespace _02.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read a sequence of integer numbers from the console
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            // Condense them by summing adjacent couples of elements until a single integer is obtainded, then print the result to the console
            while (numbers.Length > 1)
            {
                int[] condensedNums = new int[numbers.Length - 1];
                for (int i = 0; i < numbers.Length - 1; i++) {
                    int sumAdjasentNums = numbers[i] + numbers[i + 1];
                    condensedNums[i] = sumAdjasentNums;
                }
                numbers = condensedNums;
            }
            Console.WriteLine(numbers[0]);
        }
    }
}
