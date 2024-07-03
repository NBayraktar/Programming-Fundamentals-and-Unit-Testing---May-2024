namespace _03.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read List of integers
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            // Remove all negative numbers from in and print the remaining elements in reverse order. If there are no elements left in the list, print "empty".
            List<int> positiveNumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    positiveNumbers.Add(number);
                }
            }

            if (positiveNumbers.Count != 0)
            {
                positiveNumbers.Reverse();
                Console.WriteLine($"{string.Join(" ", positiveNumbers)}");
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
