namespace _06.ExamCountdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read an integer number days - the count of days before an exam
            int days = int.Parse(Console.ReadLine());

            // Count the days before exam and print the result to the console
            for (int i = days; i >0; i--)
            {
                Console.WriteLine($"{i} days before the exam");
            }
            Console.WriteLine("The exam has come");
        }
    }
}
