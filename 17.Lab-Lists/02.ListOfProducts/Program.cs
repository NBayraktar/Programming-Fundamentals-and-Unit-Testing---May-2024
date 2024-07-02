namespace _02.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read an integer number n and n lines of products
            int number = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();
            for (int i = 0; i < number; i++) {
                products.Add(Console.ReadLine());
            }

            // Print a numbered list of all the products ordered by name
            products.Sort();
            for(int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }           
        }
    }
}
