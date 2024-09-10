namespace _05.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read a text (string) and repeat count (integer number) from the console
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string repeatedText = RepeatString(text, count);
            Console.WriteLine(repeatedText);
        }

        static string RepeatString(string txt, int count)
        {
            string stringText = "";

            for (int i = 0; i < count; i++)
            {
                stringText += txt;
            }
            return stringText;
        }

    }
}
