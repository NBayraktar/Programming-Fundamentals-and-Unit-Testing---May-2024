namespace _05.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //	Reads a text (string) and repeat count (integer number) from the console
            string text = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            RepeatString(text, num);
        }

        static void RepeatString(string txt, int n)
        {
            for (int i = 1; i <= n; i++) { 
                Console.Write($"{txt}");
            }
        }
    }
}
