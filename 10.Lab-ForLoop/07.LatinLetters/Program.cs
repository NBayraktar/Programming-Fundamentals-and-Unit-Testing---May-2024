namespace _07.LatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read two letters (chars), each on separate line
            char letterOne = char.Parse(Console.ReadLine());
            char letterTwo = char.Parse(Console.ReadLine());

            // Print all letters in the specified range inclusively
            for (char i = letterOne; i <= letterTwo; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
