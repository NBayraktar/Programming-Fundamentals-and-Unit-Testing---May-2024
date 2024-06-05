namespace _01.NumberType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read a integer number from the console
            int number = int.Parse(Console.ReadLine());

            // Based on the given number print "negative", "positive", "zero" to the console
            if (number > 0)
            {
                Console.WriteLine("positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("zero");
            }

        }
    }
}
