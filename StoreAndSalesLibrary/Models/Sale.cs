using System;
using System.Collections.Generic;

namespace StoreAndSalesLibrary.Models
{
    public class Sale
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public DateTime SaleDate { get; set; }

        public decimal Total { get; set; }

        public decimal Disscount { get; set; }

        public List<SaleDetail> SaleDetails = new List<SaleDetail>();
        public string Notes { get; set; }

        public bool PaymentType { get; set; }

        public bool IsDisscount { get; set; }

        public bool Status { get; set; }

        public int UserId { get; set; }
        public int OriginalSaleId { get; set; }
        public bool IsReturn { get; set; }
    }
}
