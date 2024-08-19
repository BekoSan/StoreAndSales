namespace StoreAndSalesLibrary.Models
{
    public class SaleDetail
    {
        public int Id { get; set; }

        public int SaleId { get; set; }

        public int ItemId { get; set; }

        public int UnitId { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

    }
}
