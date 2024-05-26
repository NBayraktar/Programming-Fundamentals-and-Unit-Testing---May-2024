namespace _07.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input number of packs of pens, packs of markers, board cleaner(liters) and discount percentage
            int packPens = int.Parse(Console.ReadLine());
            int packMarkers = int.Parse(Console.ReadLine());
            int boardCleaner = int.Parse(Console.ReadLine());
            int discountPercent = int.Parse(Console.ReadLine());
      
            // Calculation for total cost
            double pens = 5.8; // price per pack of pens;
            double markers = 7.2; // price per pack of markers;
            double cleaner = 1.2; // price per liter;

            double pensCost = packPens * pens;
            double markersCost = packMarkers * markers;
            double cleanerCost = boardCleaner * cleaner;
            double materialCost = pensCost + markersCost + cleanerCost;
            double totalCostAfterDiscount = materialCost - (materialCost * discountPercent / 100);

            // Output the result to the console
            Console.WriteLine($"{totalCostAfterDiscount}");
        }
    }
}
