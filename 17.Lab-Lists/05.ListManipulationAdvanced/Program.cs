namespace _05.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read a list of integers
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string line = "";
            while ((line = Console.ReadLine()) != "end")
            {
                string[] tokens = line
                    .Split(" ")
                    .ToArray();
                string command = tokens[0];
                if (command == "Contains")
                {
                    int item = int.Parse(tokens[1]);
                    if (numbers.Contains(item))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    PrintEvenNums(numbers);
                }
                else if (command == "PrintOdd")
                {
                    PrintOddNums(numbers);
                }
                else if (command == "GetSum")
                {
                    GetSum(numbers);
                }
                else if (command == "Filter")
                {
                    string condition = tokens[1];
                    int number = int.Parse(tokens[2]);

                    if (condition == "<")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            int currentNum = numbers[i];
                            if (currentNum >= number) { 
                                numbers.Remove(currentNum);
                                i--;
                            }
                        }
                    }
                    if (condition == "<=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            int currentNum = numbers[i];
                            if (currentNum > number)
                            {
                                numbers.Remove(currentNum);
                                i--;
                            }
                        }
                    }
                    if (condition == ">")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            int currentNum = numbers[i];
                            if (currentNum <= number)
                            {
                                numbers.Remove(currentNum);
                                i--;
                            }
                        }
                    }
                    if (condition == ">=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            int currentNum = numbers[i];
                            if (currentNum < number)
                            {
                                numbers.Remove(currentNum);
                                i--;
                            }
                        }
                    }

                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void GetSum(List<int> numbers)
        {
            int sum = 0;
            sum = numbers.Sum();
            Console.WriteLine(sum);
        }

        private static void PrintOddNums(List<int> numbers)
        {
            List<int> oddNums = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 1)
                {
                    oddNums.Add(number);
                }

            }
            Console.WriteLine(string.Join(" ", oddNums));
        }

        private static void PrintEvenNums(List<int> numbers)
        {
            List<int> evenNums = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNums.Add(number);
                }

            }
            Console.WriteLine(string.Join(" ", evenNums));
        }
    }
}
