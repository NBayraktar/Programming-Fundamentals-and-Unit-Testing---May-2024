namespace _07.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reads a type (string) and two values of this type from the console
            string type = Console.ReadLine();
            if (type == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                GetBiggerNum(num1, num2);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                GetBiggerChar(firstChar, secondChar);
            }
            else
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                GetBiggerString(first, second);
            }

        }

        static void GetBiggerNum(int num1, int num2) {
            if (num1 > num2) {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }
        }

        static void GetBiggerChar(char firstChar, char secondChar) {
            if (firstChar > secondChar) {
                Console.WriteLine(firstChar);
            }
            else
            {
                Console.WriteLine(secondChar);
            }
        }

        static void GetBiggerString(string first, string second) {
            int result = String.Compare(first, second);
            if (result == 1) {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
        }
    }
}
