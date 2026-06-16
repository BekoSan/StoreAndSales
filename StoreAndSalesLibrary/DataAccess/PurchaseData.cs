using Dapper;
using StoreAndSalesLibrary.Internal;
using StoreAndSalesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace StoreAndSalesLibrary.DataAccess
{
    public class PurchaseData
    {
        private SqlDataAccess _sql = new SqlDataAccess();
        private SqlConnection _connection = new SqlConnection();
        private SqlTransaction _transaction;
        private int _purchaseId = 0;

        public PurchaseData(string connectionStringName = "")
        {
            if (connectionStringName != "")
            {
                _connection.ConnectionString = _sql.GetConnectionString(connectionStringName);
                _connection.Open();
            }
        }

        public bool CreatePurchase(Purchase purchase)
        {
            _transaction = _connection.BeginTransaction();
            
            using (SqlCommand cmd = new SqlCommand("spCreatePurchase", _connection, _transaction))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Id", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@SupplierId", SqlDbType.Int).Value = purchase.SupplierId;
                cmd.Parameters.Add("@Total", SqlDbType.Money).Value = purchase.Total;
                cmd.Parameters.Add("@Disscount", SqlDbType.Money).Value = purchase.Disscount;
                cmd.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = purchase.Notes;
                cmd.Parameters.Add("@PaymentType", SqlDbType.Bit).Value = purchase.PaymentType;
                cmd.Parameters.Add("@IsDisscount", SqlDbType.Bit).Value = purchase.IsDisscount;
                cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = purchase.Status;

                cmd.ExecuteNonQuery();

                _purchaseId = int.Parse(cmd.Parameters["@Id"].Value.ToString());
                purchase.Id = _purchaseId;
            }

           return CreatePurchaseDetails(purchase.PurchaseDetails);
        }

        public bool CreatePurchaseDetails(List<PurchaseDetail> purchaseDetails)
        {
            bool output = true;

            try
            {
                purchaseDetails.ForEach(purchaseDetail =>
                {

                    using (SqlCommand cmd = new SqlCommand("spCreatePurchaseDetail", _connection, _transaction))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@Id", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@PurchaseId", SqlDbType.Int).Value = _purchaseId;
                        cmd.Parameters.Add("@ItemId", SqlDbType.Int).Value = purchaseDetail.ItemId;
                        cmd.Parameters.Add("@UnitId", SqlDbType.Int).Value = purchaseDetail.UnitId;
                        cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = purchaseDetail.Quantity;
                        cmd.Parameters.Add("@Price", SqlDbType.Money).Value = purchaseDetail.Price;

                        cmd.ExecuteNonQuery();
                    }
                });
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                output= false;
                //TODO: Log the Exception
            }
            return output;
        }
        public List<Purchase> GetAllPurchases()
        {
            return _sql.LoadData<Purchase, dynamic>("spGetAllPurchases", null, _sql.GetConnectionName());
        }

        public List<Purchase> GetPurchasesByDate(DateTime dateFrom, DateTime dateTo)
        {
            var p = new DynamicParameters();

            p.Add("@DateFrom", dateFrom.Date);
            p.Add("@DateTo", dateTo.Date);

            return _sql.LoadData<Purchase, dynamic>("spGetPurchasesByDate", p, _sql.GetConnectionName());
        }

        public List<T> GetPurchasesByDate<T>(DateTime dateFrom, DateTime dateTo)
        {
            var p = new DynamicParameters();

            p.Add("@DateFrom", dateFrom.Date);
            p.Add("@DateTo", dateTo.Date);

            return _sql.LoadData<T, dynamic>("spPurchaseLookup", p, _sql.GetConnectionName());
        }

        public decimal GetTotalPurchasesByDate(DateTime dateFrom, DateTime dateTo)
        {
            var p = new DynamicParameters();

            p.Add("@DateFrom", dateFrom.Date);
            p.Add("@DateTo", dateTo.Date);

            return _sql.LoadData<decimal, dynamic>("spGetTotalPurchasesByDate", p, _sql.GetConnectionName()).First();
        }

        public int  GetLastPurchaseId()
        {
            int output;

            var list = _sql.LoadData<int, dynamic>("spGetLastPurchaseId", null, _sql.GetConnectionName());

            if (list.Count == 0)
                output = 1;
            else
                output = list.First();

            return output;
        }

        public Purchase GetPurchaseById(int purchaseId)
        {
            var p = new DynamicParameters();

            p.Add("@PurchaseId", purchaseId);

            return _sql.LoadData<Purchase, dynamic>("spGetPurchaseById", p, _sql.GetConnectionName()).First();
        }

        public void EditPurchaseStatus(int purchaseId, bool newStatus)
        {
            var p = new DynamicParameters();

            p.Add("@PurchaseId", purchaseId, DbType.Int32);
            p.Add("@Status", newStatus, DbType.Boolean);

            _sql.SaveData("spEditPurchaseStatus", p, _sql.GetConnectionName());
        }

        public void EditPurchaseDisscount(int purchaseId, decimal  disscount)
        {
            var p = new DynamicParameters();

            p.Add("@PurchaseId", purchaseId, DbType.Int32);
            p.Add("@Disscount", disscount, DbType.Decimal);

            _sql.SaveData("spEditPurchaseDisscount", p, _sql.GetConnectionName());
        }

    }
}
