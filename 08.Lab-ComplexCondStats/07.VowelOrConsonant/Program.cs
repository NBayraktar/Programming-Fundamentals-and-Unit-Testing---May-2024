namespace _07.VowelOrConsonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input character from the console
            char letter = char.Parse(Console.ReadLine());

            // Checking it letter is Vowel or Consonant and output the text to the console
            if (letter == 'A' || letter == 'a' || letter == 'E' || letter == 'e' || letter == 'I' || letter == 'i' || letter == 'O' || letter == 'o' || letter == 'U' || letter == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }
    }
}
