using Dapper;
using StoreAndSalesLibrary.Internal;
using StoreAndSalesLibrary.Models;
using System.Data;
using System.Linq;

namespace StoreAndSalesLibrary.DataAccess
{
    public  class VoucherData
    {
        private SqlDataAccess _sql = new SqlDataAccess();

        public void CreateSaleVoucher(Voucher saleVoucher)
        {
            var p = new DynamicParameters();

            p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
            p.Add("@VoucherType", saleVoucher.VoucherType);
            p.Add("@Amount", saleVoucher.Amount);
            //p.Add("@SaleId", saleVoucher.SaleId);
            p.Add("@CustomerId", saleVoucher.CustomerId);
            p.Add("@Notes", saleVoucher.Notes);

            _sql.SaveData("spCreateSaleVoucher", p, _sql.GetConnectionName());
        }

        public void CreatePurchaseVoucher(Voucher purchaseVoucher)
        {
            var p = new DynamicParameters();

            p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
            p.Add("@VoucherType", purchaseVoucher.VoucherType);
            p.Add("@Amount", purchaseVoucher.Amount);
            p.Add("@PurchaseId", purchaseVoucher.PurchaseId);
            p.Add("@SupplierId", purchaseVoucher.SupplierId);
            p.Add("@Notes", purchaseVoucher.Notes);

            _sql.SaveData("spCreatePurchaseVoucher", p, _sql.GetConnectionName());
        }

        public decimal GetTotalSaleVoucher(int saleId, int customerId, string voucherType)
        {

            var p = new DynamicParameters();

            p.Add("@SaleId", saleId);
            p.Add("@CustomerId", customerId);
            p.Add("@VoucherType", voucherType);

            return _sql.LoadData<decimal, dynamic>("spGetTotalSaleVoucher", p, _sql.GetConnectionName()).FirstOrDefault();
        }

        public decimal GetTotalPurchaseVoucher(int purchaseId, int supplierId, string voucherType)
        {

            var p = new DynamicParameters();

            p.Add("@PurchaseId", purchaseId);
            p.Add("@SupplierId", supplierId);
            p.Add("@VoucherType", voucherType);

            return _sql.LoadData<decimal, dynamic>("spGetTotalPurchaseVoucher", p, _sql.GetConnectionName()).FirstOrDefault();
        }

        public int GetLastVoucherId()
        {
            int output;

            var list = _sql.LoadData<int, dynamic>("spGetLastVoucherId", null, _sql.GetConnectionName());

            if (list.Count == 0)
                output = 1;
            else
                output = list.First();

            return output;
        }

    }
}
