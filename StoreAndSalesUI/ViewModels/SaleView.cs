using System;

namespace StoreAndSalesUI.ViewModels
{
  public   class SaleView
    {
        public int SaleId { get; set; }
        public string CustomerName { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal Total { get; set; }
        public decimal Disscount { get; set; }
        public string UserName { get; set; }
        public bool IsReturn { get; set; }
    }
}
