using WarehouseNS;

namespace WarehouseTests
{
    [TestClass]
    public class FuncTests
    {
        [TestMethod]
        public void Test_AddItems_WithPositiveInt()
        {
            WareHouse wareHouse = new();
            wareHouse.AddToStocks("pencils", 200);
        }
    }
}