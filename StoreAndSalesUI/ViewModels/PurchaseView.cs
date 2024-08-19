using System;

namespace StoreAndSalesUI.ViewModels
{
    public class PurchaseView
    {
        public int PurchaseId { get; set; }
        public string SupplierName { get; set; }
        public DateTime PurchaseDate{ get; set; }
        public decimal Total { get; set; }
        public decimal Disscount { get; set; }
    }
}
