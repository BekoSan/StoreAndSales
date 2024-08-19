using Dapper;
using StoreAndSalesLibrary.Internal;
using StoreAndSalesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace StoreAndSalesLibrary.DataAccess
{
    public class PurchaseDetailData
    {
        private SqlDataAccess _sql = new SqlDataAccess();

        public List<PurchaseDetail> GetPurchasesDetails(int purchaseId)
        {
            var p = new DynamicParameters();

            p.Add("@PurchaseId", purchaseId);

            return _sql.LoadData<PurchaseDetail, dynamic>("spGetAllPurchaseDetails", p, _sql.GetConnectionName());
        }
    }
}
