namespace _05.GuessThePass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input string that represents a password
            string pass = Console.ReadLine();

            // Checking a password
            if (pass == "s3cr3t!")
            {
                Console.WriteLine("Welcome");
            }
            else {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
