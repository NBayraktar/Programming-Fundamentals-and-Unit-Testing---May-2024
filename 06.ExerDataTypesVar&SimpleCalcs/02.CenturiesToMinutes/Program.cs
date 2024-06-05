namespace _02.CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read an integer number, that represents centuries for conversion
            int century = int.Parse(Console.ReadLine());

            // Converting centuries to years, years to days, days to hours, hours to minutes
             int years = century * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            // Printing the result to the console
            Console.WriteLine($"{century} centuries = {(int)years} years = {(int)days} days = {(int)hours} hours = {(int)minutes} minutes");
        }
    }
}

