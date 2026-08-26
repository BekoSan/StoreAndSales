using System;
using System.Collections.Generic;

namespace StoreAndSalesLibrary.Models
{
    public class Purchase
    {
        public int Id { get; set; }

        public int SupplierId { get; set; }

        public int StoreId { get; set; }

        public DateTime PurchaseDate { get; set; }

        public decimal Total { get; set; }

        public decimal Disscount { get; set; }

        public List<PurchaseDetail> PurchaseDetails = new List<PurchaseDetail>();
        public string Notes { get; set; }

        public bool PaymentType { get; set; }

        public bool IsDisscount { get; set; }

        public bool Status { get; set; }

        public int UserId { get; set; }

    }
}
