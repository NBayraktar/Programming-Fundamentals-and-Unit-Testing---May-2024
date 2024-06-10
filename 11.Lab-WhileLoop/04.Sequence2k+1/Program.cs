namespace _04.Sequence2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read an integer number n from the console – the max number
            int number = int.Parse(Console.ReadLine());

            // Print the elements of the sequence (starting with 1), which are ≤ n
            int firstNum = 1;
            while (number >= firstNum)
            {
                Console.WriteLine(firstNum);
                firstNum = firstNum * 2 + 1;
            }
        }
    }
}
