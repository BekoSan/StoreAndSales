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
    public class SaleData
    {
        private SqlDataAccess _sql = new SqlDataAccess();
        private SqlConnection _connection = new SqlConnection();
        private SqlTransaction _transaction;
        private int _saleId = 0;

        public SaleData(string connectionStringName = "")
        {
            if (connectionStringName != "")
            {
                _connection.ConnectionString = _sql.GetConnectionString(connectionStringName);
                _connection.Open();
            }
        }

        public void CreateSale(Sale sale)
        {
            _transaction = _connection.BeginTransaction();
            
            using (SqlCommand cmd = new SqlCommand("spCreateSale", _connection, _transaction))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Id", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = sale.CustomerId;
                cmd.Parameters.Add("@Total", SqlDbType.Money).Value = sale.Total;
                cmd.Parameters.Add("@Disscount", SqlDbType.Money).Value = sale.Disscount;
                cmd.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = sale.Notes;
                cmd.Parameters.Add("@PaymentType", SqlDbType.Bit).Value = sale.PaymentType;
                cmd.Parameters.Add("@IsDisscount", SqlDbType.Bit).Value = sale.IsDisscount;
                cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = sale.Status;
 
                cmd.ExecuteNonQuery();

                _saleId = int.Parse(cmd.Parameters["@Id"].Value.ToString());
            }

            CreateSaleDetails(sale.SaleDetails);
        }

        public void CreateSaleDetails(List<SaleDetail> SaleDetails)
        {
            try
            {
                SaleDetails.ForEach(SaleDetail =>
                {

                    using (SqlCommand cmd = new SqlCommand("spCreateSaleDetail", _connection, _transaction))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@Id", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@SaleId", SqlDbType.Int).Value = _saleId;
                        cmd.Parameters.Add("@ItemId", SqlDbType.Int).Value = SaleDetail.ItemId;
                        cmd.Parameters.Add("@UnitId", SqlDbType.Int).Value = SaleDetail.UnitId;
                        cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = SaleDetail.Quantity;
                        cmd.Parameters.Add("@Price", SqlDbType.Money).Value = SaleDetail.Price;

                        cmd.ExecuteNonQuery();
                    }
                });
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                //TODO: Log the Exception
            }

        }
        public List<Sale> GetAllSales()
        {
            return _sql.LoadData<Sale, dynamic>("spGetAllSales", null, _sql.GetConnectionName());
        }

        public List<Sale> GetSalesByDate(DateTime dateFrom, DateTime dateTo)
        {
            var p = new DynamicParameters();

            p.Add("@DateFrom", dateFrom.Date);
            p.Add("@DateTo", dateTo.Date);

            return _sql.LoadData<Sale, dynamic>("spGetSalesByDate", p, _sql.GetConnectionName());
        }

        public List<T> GetSalesByDate<T>(DateTime dateFrom, DateTime dateTo)
        {
            var p = new DynamicParameters();

            p.Add("@DateFrom", dateFrom.Date);
            p.Add("@DateTo", dateTo.Date);

            return _sql.LoadData<T, dynamic>("spSaleLookup", p, _sql.GetConnectionName());
        }

        public int GetLastSaleId()
        {
            int output;

            var list = _sql.LoadData<int, dynamic>("spGetLastSaleId", null, _sql.GetConnectionName());

            if (list.Count == 0)
                output = 1;
            else
                output = list.First();

            return output;
        }

        public Sale GetSaleById(int purchaseId)
        {
            var p = new DynamicParameters();

            p.Add("@SaleId", purchaseId);

            return _sql.LoadData<Sale, dynamic>("spGetSaleById", p, _sql.GetConnectionName()).First();
        }

        public decimal GetTotalSalesByDate(DateTime dateFrom, DateTime dateTo)
        {
            var p = new DynamicParameters();

            p.Add("@DateFrom", dateFrom.Date);
            p.Add("@DateTo", dateTo.Date);

            return _sql.LoadData<decimal, dynamic>("spGetTotalSalesByDate", p, _sql.GetConnectionName()).First();
        }

    }
}
