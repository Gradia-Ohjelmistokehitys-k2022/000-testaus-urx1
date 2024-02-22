
using WarehouseNS;

namespace WarehouseNS

{
    internal class Program
    {
        // Tee ohjelmaan yksikkötestit.
        static void Main(string[] args)
        {
            WareHouse wareHouse = new();
            wareHouse.AddToStocks("pencils", 2147483647);
            wareHouse.AddToStocks("pencils", -100);

            foreach (var item in wareHouse._stockOfItems)
            {
                Console.WriteLine(item.Quantity);
            }
            Console.WriteLine(wareHouse.InStock("pencils"));
            wareHouse.StockCount("pencils");
            //wareHouse.WareHouseSimulator();
        }
    }
}