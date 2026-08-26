namespace StoreAndSalesLibrary.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
        public bool IsDefault { get; set; }
        public bool Status { get; set; }
    }
}
