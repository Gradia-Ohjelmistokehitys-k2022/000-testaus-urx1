﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseNS;

namespace WarehouseNS
{
    public class Stock
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }

        public Stock(string itemName, int quantity)
        {
            ItemName = itemName;
            Quantity = quantity;
        }
    }
}


