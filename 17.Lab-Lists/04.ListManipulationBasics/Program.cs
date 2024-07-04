namespace _04.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read a list of integers from the console
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string line = "";
            while ((line = Console.ReadLine()) != "end")
            {
                string[] command = line.Split();
                if (command[0] == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Remove")
                {
                    numbers.Remove(int.Parse(command[1]));
                }
                else if (command[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
