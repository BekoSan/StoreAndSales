using System;

namespace StoreAndSalesLibrary.Models
{
    public class Voucher
    {
        public int Id { get; set; }

        public string VoucherType { get; set; }

        public decimal Amount { get; set; }

        public int SaleId { get; set; } = 0;

        public int PurchaseId { get; set; } = 0;

        public int CustomerId { get; set; } = 0;

        public int SupplierId { get; set; } = 0;

        public string Notes { get; set; }

        public DateTime VoucherDate { get; set; }
    }
}
