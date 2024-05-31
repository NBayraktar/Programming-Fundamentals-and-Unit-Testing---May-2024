namespace _03.Nums1_9AsWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input integer number from console
            int num = int.Parse(Console.ReadLine());

            // Check number's value is in range [1 … 9]
            if (num >= 1 && num <= 9)
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                }
            } else
            {
                Console.WriteLine("Out of range");
            }
        }
    }
}
