namespace _01.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reads a list of integers from the console and receives commands to manipulate the list
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split(" ");
                string operation = tokens[0];
                if (operation == "Delete")
                {
                    DeleteOperation(numbers, tokens);
                }
                else if (operation == "Insert")
                {
                    InsertOperation(numbers, tokens);
                }
            }
            Console.WriteLine($"{string.Join(" ", numbers)}");
        }

        private static void InsertOperation(List<int> numbers, string[] tokens)
        {
            int index = int.Parse(tokens[2]);
            int insertElement = int.Parse(tokens[1]);
            numbers.Insert(index, insertElement);
        }

        private static void DeleteOperation(List<int> numbers, string[] tokens)
        {
            int elementForRemoving = int.Parse(tokens[1]);
            while (numbers.Contains(elementForRemoving))
            {
                numbers.Remove(elementForRemoving);
            }
        }
    }
}