namespace StoreAndSalesLibrary.Models
{
    // كائن مساعد لعرض شاشة المرتجع فقط - مش جدول في قاعدة البيانات
    // يمثل سطر من الفاتورة الأصلية مع حساب "المتبقي القابل للإرجاع"
    public class ReturnableSaleDetail
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public int OriginalQuantity { get; set; }
        public int AlreadyReturned { get; set; }
        public int RemainingQuantity { get; set; }
        public int UnitId { get; set; }
    }
}
