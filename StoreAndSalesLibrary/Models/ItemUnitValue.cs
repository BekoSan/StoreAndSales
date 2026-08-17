using System;

namespace StoreAndSalesLibrary.Models
{
    public class ItemUnitValue
    {
        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public int ItemQuantity { get; set; }
        public decimal ItemPrice { get; set; }
    }
}
