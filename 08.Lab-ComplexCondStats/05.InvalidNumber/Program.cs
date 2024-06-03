namespace _05.InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Input integer number from the console
           int number = int.Parse(Console.ReadLine());
           
           // Checking if the number is valid
           if ((number == 0) || (number >= 100 && number <=200))
            {

            }
           else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
