namespace _06.BoilingWater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input the number from the console temperature (in C)
            int tempCel = int.Parse(Console.ReadLine());
           
            // Checking the water is it hot enough 
            if (tempCel > 100)
            {
                Console.WriteLine("The water is boiling");
            } 
            else
            {
                Console.WriteLine("The water is not hot enough");
            }
        }
    }
}
