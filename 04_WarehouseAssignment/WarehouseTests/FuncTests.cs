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
        [ExpectedException(typeof(ArgumentException))]

        public void Test_AddItems_WithQuantityZero_ThrowsException()
        {
            WareHouse wareHouse = new();

            wareHouse.AddToStocks("pencils", 0);

            /*
            int checkQuantity = wareHouse.StockCount("pencils");

            foreach (var item in wareHouse._stockOfItems)
            {
                
            }
            if (checkQuantity < 1)       
            {
                throw new Exception("Can't add when nothing to add.");
            }
            */
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

        [TestMethod]
        public void Test_TakeFromStock_MoreThanQuantity()
        {
            WareHouse wareHouse = new();

            int toAdd = 20;

            wareHouse.AddToStocks("pencils", toAdd);

            int toTake = 11;

            if (wareHouse._stockOfItems[0].Quantity - toTake < 0)
            {
                throw new Exception("Can't take more than there is quantity.");
            }

            wareHouse.TakeFromStock("pencils", toTake);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_TakeFromStock_NegativeSumOrZero()
        {
            WareHouse wareHouse = new();

            int toAdd = 20;

            wareHouse.AddToStocks("pencils", toAdd);

            int toTake = -11;
            /*
            if (toTake <= 0)
            {
                throw new Exception("Can't take a negative quantity.");
            }
            */
            wareHouse.TakeFromStock("pencils", toTake);
        }

        [TestMethod]
        public void Test_TakeFromStock_ItemDoesntExist()
        {
            WareHouse wareHouse = new();

            int toAdd = 20;

            wareHouse.AddToStocks("pencils", toAdd);

            int toTake = 1;

            string itemName = "pencils";

            foreach (var item in wareHouse._stockOfItems)
            {
                if (item.ItemName != itemName)
                {
                    throw new Exception("Item not in warehouse.");
                }
            }

            wareHouse.TakeFromStock(itemName, toTake);
        
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_StockCount_PositiveQuantity()
        {
            WareHouse wareHouse = new();

            int toAdd = -20;

            wareHouse.AddToStocks("pencils", toAdd);
            wareHouse.StockCount("pencils");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void Test_TakeFromStock_QuantityZero()
        {
            WareHouse wareHouse = new();

            //int toAdd = 20;

            wareHouse.AddToStocks("pencils", 0);

            string itemName = "pencils";
            /*
            foreach (var item in wareHouse._stockOfItems)
            {
                if (item.Quantity == 0)
                {
                    throw new Exception("Quantity of item in stock is zero.");
                }
            }
            */
            wareHouse.TakeFromStock(itemName, 1);

        }
    }
}

