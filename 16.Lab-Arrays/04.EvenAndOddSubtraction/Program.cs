namespace _04.EvenAndOddSubtraction
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

            // Calculate the differece between the sum of the even and the sum of the odd numbers in an array
            int evenNum = 0;
            int oddNum = 0;
            
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNum += number;
                }
                else
                {
                    oddNum += number;
                }
            }
            int difference = evenNum - oddNum;
            Console.WriteLine(difference);
        }
    }
}
