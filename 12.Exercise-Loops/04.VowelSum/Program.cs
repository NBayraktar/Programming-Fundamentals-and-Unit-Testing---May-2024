namespace _04.VowelSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read integer number n: the count of characters
            int n = int.Parse(Console.ReadLine());

            // Read N characters and for each vowel character adds its value from the table to the result
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                switch (letter)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
