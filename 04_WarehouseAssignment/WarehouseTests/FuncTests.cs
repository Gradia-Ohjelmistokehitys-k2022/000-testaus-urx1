using WarehouseNS;

namespace WarehouseTests
{
    [TestClass]
    public class FuncTests
    {
        [TestMethod]
        public void Test_AddItems_WithPositiveQuantity()
        {
            WareHouse wareHouse = new();

            wareHouse.AddToStocks("pencils", 200);


            foreach (var item in wareHouse._stockOfItems)
            {
                if (item.ItemName != "pencils" && item.Quantity != 200)
                {
                    throw new Exception("Items not added to stock correctly.");
                }
            }
        }

        [TestMethod]
        public void Test_AddItems_WithQuantityZero_ThrowsException()
        {
            WareHouse wareHouse = new();

            wareHouse.AddToStocks("pencils", 0);

            int checkQuantity = wareHouse.StockCount("pencils");

            foreach (var item in wareHouse._stockOfItems)
            {
                
            }
            if (checkQuantity < 1)       
            {
                throw new Exception("Can't add when nothing to add.");
            }
        }

        [TestMethod]
        public void Test_AddItems_WithNegativeQuantity_ThrowsException()
        {
            WareHouse wareHouse = new();

            wareHouse.AddToStocks("pencils", 100);

            int checkQuantity = wareHouse.StockCount("pencils");

            foreach (var item in wareHouse._stockOfItems)
            {
                checkQuantity = item.Quantity;
            }
            if (checkQuantity < 0)
            {
                throw new Exception("Can't add when nothing to add.");
            }
        }

        [TestMethod]
        public void Test_AddItems_BeyondMaxInt()
        {
            WareHouse wareHouse = new();

            wareHouse.AddToStocks("pencils", 88888888);

            int maxInt = 99999999;

            int checkQuantity;

            foreach (var item in wareHouse._stockOfItems)
            {
                checkQuantity = item.Quantity;

                if (checkQuantity >= maxInt)
                {
                    throw new Exception("Cannot add such a vast quantity to stock.");
                }
            }
        }
        [TestMethod]
        public void Test_TakeFromStock_Works()
        {
            WareHouse wareHouse = new();

            int toAdd = 20;

            wareHouse.AddToStocks("pencils", toAdd);

            int toTake = 9;

            int expected = toAdd - toTake;

            wareHouse.TakeFromStock("pencils", toTake);

            int checkQuantity;

            foreach (var item in wareHouse._stockOfItems)
            {
                checkQuantity = item.Quantity;

                if (checkQuantity != expected)
                {
                    throw new Exception("Wrong amount taken.");
                }
            }
        }
    }
}

/*

InStock:

- Tarkista onko esinett‰ varastossa positiivinen m‰‰r‰ (esim. datarown:n avulla).
- Tarkista onko varastossa esine m‰‰r‰ll‰ nolla.
- Tarkasta voiko esinett‰ olla varastossa negatiivinen m‰‰r‰.

TakeFromStock:

- Ota oikeanlainen m‰‰r‰ esineit‰ varasosta.
- Ota viimeinen esine varastosta.
- Ota isompi m‰‰r‰ kuin varastossa on tavaraa.
- Ota varastosta negatiivinen m‰‰r‰.
- Ota varastosta tavara, jota ei ole olemassa.
- Ota varastosta nolla esinett‰.

StockCount:

- Tarkista esineiden lukum‰‰r‰ esineelt‰, jota on positiviinen m‰‰r‰.
- Tarkista esineiden m‰‰r‰, joita on nolla kappaletta.
- Tarkista esineiden lukum‰‰r‰, joita on negatiivinen m‰‰r‰.

*/