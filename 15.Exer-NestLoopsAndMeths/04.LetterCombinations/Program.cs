namespace _04.LetterCombinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //	Read a start letter s, end letter e and excluded letter x
            char startL = char.Parse(Console.ReadLine());
            char endL = char.Parse(Console.ReadLine());
            char excludeL = char.Parse(Console.ReadLine());

            // Generate all combinations of 3 letters in the range [s…e], excluding x
            // Print all combinations on the first line
            // Print combinations count on the second line
            int count = 0;
            for (int i = startL; i <= endL; i++)
            {
                for (int j = startL; j <= endL; j++)
                {
                    for (int k = startL; k <= endL; k++)
                    {
                        if (i == excludeL || j == excludeL || k == excludeL)
                        {
                            continue;
                        }
                        Console.Write($"{(char)i}{(char)j}{(char)k} ");
                        count++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(count);
        }
    }
}
