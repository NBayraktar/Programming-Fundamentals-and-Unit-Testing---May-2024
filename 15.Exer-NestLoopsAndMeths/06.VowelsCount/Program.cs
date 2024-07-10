namespace _06.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read a string from the console
            string text = Console.ReadLine();
            int vowelCount = GetVowelsCount(text);
            Console.WriteLine(vowelCount);

            static int GetVowelsCount(string txt)
            {
                int count = 0;

                for (int i = 0; i <= txt.Length - 1; i++)
                {
                    char vowel = txt[i];
                    if (vowel == 'A' || vowel == 'a' || vowel == 'E' || vowel == 'e' || vowel == 'I' || vowel == 'i' || vowel == 'U' || vowel == 'u' || vowel == 'O' || vowel == 'o')
                    {
                        count++;
                    }
                }
                return count;
            }
        }

    }
}

