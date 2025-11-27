using Dapper;
using StoreAndSalesLibrary.Internal;
using StoreAndSalesLibrary.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace StoreAndSalesLibrary.DataAccess
{
    public class SupplierData
    {
        private SqlDataAccess _sql = new SqlDataAccess();

        public void CreateSupplier(Supplier supplier)
        {
            var p = new DynamicParameters();

            p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
            p.Add("@SupplierName", supplier.SupplierName);
            p.Add("@Address", supplier.Address);
            p.Add("@Phone", supplier.Phone);
            p.Add("@Balance", supplier.Balance);

            _sql.SaveData("spCreateSupplier", p, _sql.GetConnectionName());
        }

        public void EditSupplier(Supplier supplier)
        {
            var p = new DynamicParameters();

            p.Add("@SupplierId", supplier.Id);
            p.Add("@SupplierName", supplier.SupplierName);
            p.Add("@Address", supplier.Address);
            p.Add("@Phone", supplier.Phone);

            _sql.SaveData("spEditSupplier", p, _sql.GetConnectionName());
        }

        public void ArchiveSupplier(int supplierId)
        {
            var p = new DynamicParameters();

            p.Add("@SupplierId", supplierId);

            _sql.SaveData("spArchiveSupplier", p, _sql.GetConnectionName());
        }

        public List<Supplier> GetAllSuppliers()
        {
            return _sql.LoadData<Supplier, dynamic>("spGetAllSuppliers", null, _sql.GetConnectionName());
        }

        public Supplier GetSupplier(int supplierId)
        {
            var p = new DynamicParameters();

            p.Add("@SupplierId", supplierId);

            return _sql.LoadData<Supplier, dynamic>("spGetSupplierById", p, _sql.GetConnectionName()).First();
        }

        public List<Supplier> GetSuppliersByName(string supplierName)
        {
            var p = new DynamicParameters();

            p.Add("@SupplierName", supplierName);

            return _sql.LoadData<Supplier, dynamic>("spGetSupplierByName", p, _sql.GetConnectionName());
        }

    }
}
