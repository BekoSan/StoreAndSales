
using System.Collections.Generic;

namespace StoreAndSalesLibrary.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string ItemName { get; set; }

        public bool Status { get; set; }

        public List<ItemUnit> ItemUnits = new List<ItemUnit>(); 

    }
}
