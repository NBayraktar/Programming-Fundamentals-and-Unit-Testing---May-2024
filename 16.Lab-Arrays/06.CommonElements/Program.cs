namespace _06.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //	Read two integer arrays with the same length from the console
            int[] arrayOne = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] arrayTwo = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            // Prints common elements in two arrays, space-separated
            for (int i = 0; i < arrayOne.Length; i++)
            {
                int currentNum = arrayOne[i];
                foreach (int number in arrayTwo)
                {
                    if (currentNum == number)
                    {
                        Console.Write($"{currentNum} ");
                    }
                }
            }
        }
    }
}
