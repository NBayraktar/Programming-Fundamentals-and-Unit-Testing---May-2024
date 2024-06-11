namespace _07.NumberProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read an initial number from the input and read lines of strings (Inc, Dec, End)
            int number = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            // Execute a sequence of commands
            while (command != "End")
            {
                if (command == "Inc")
                {
                    number++;
                    command = Console.ReadLine();
                }
                else if (command == "Dec")
                {
                    number--;
                    command = Console.ReadLine();
                }  
            }
            Console.WriteLine(number);
        }
    }
}
