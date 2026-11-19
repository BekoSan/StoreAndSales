
using System;
using System.Collections.Generic;

namespace StoreAndSalesLibrary.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string ItemName { get; set; }

        public bool Status { get; set; }

        public int ReorderLevel { get; set; }

        public bool HasExpiryDate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public int ExpiryAlertDays { get; set; } = 30;

        public List<ItemUnit> ItemUnits = new List<ItemUnit>();

    }
}
