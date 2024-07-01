namespace _05.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //	Read two arrays with the same length from the console
            int[] arrayOfNums1= Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] arrayOfNums2 = Console.ReadLine()
               .Split(" ")
               .Select(int.Parse)
               .ToArray();

            // Check whether they are identical or not 
            for (int i = 0; i < arrayOfNums1.Length; i++) { 
                int currentNumFromArrayOne = arrayOfNums1[i];
                int currentNumFromArrayTwo = arrayOfNums2[i];
                if (currentNumFromArrayOne != currentNumFromArrayTwo)
                {
                    Console.WriteLine("Arrays are not identical.");
                    return;
                }
            }
            Console.WriteLine("Arrays are identical.");
        }
    }
}
