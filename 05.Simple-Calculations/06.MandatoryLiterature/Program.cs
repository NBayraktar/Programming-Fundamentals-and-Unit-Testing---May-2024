namespace _06.MandatoryLiterature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read number of pages in the current book, pages that he reads in 1 hour, the number of days he needs to finish the book
            int bookPages = int.Parse(Console.ReadLine());
            int readingPagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            // Calculating dayly reading hours
            int readingTime = bookPages / readingPagesPerHour;
            int hoursPerDay = readingTime / days;

            // Output the result to the console
            Console.WriteLine($"{hoursPerDay}");
        }
    }
}
