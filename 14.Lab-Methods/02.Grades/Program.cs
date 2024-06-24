namespace _02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read a grad (floating-point number) from the console
            double number = double.Parse(Console.ReadLine());
            Grades(number);
        }

        static void Grades(double num)
        {
            if (num >= 2.00 && num <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (num >= 3.00 && num <= 3.49)
            {
                Console.WriteLine("Average");
            }
            else if (num >= 3.50 && num <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (num >= 4.50 && num <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
