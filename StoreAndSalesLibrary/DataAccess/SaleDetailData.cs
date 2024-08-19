using Dapper;
using StoreAndSalesLibrary.Internal;
using StoreAndSalesLibrary.Models;
using System.Collections.Generic;

namespace StoreAndSalesLibrary.DataAccess
{
   public  class SaleDetailData
    {
        private SqlDataAccess _sql = new SqlDataAccess();

        public List<SaleDetail> GetSaleDetails(int saleId)
        {
            var p = new DynamicParameters();

            p.Add("@SaleId", saleId);

            return _sql.LoadData<SaleDetail, dynamic>("spGetAllSaleDetails", p, _sql.GetConnectionName());
        }
    }
}
