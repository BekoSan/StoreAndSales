using Dapper;
using StoreAndSalesLibrary.Internal;
using StoreAndSalesLibrary.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace StoreAndSalesLibrary.DataAccess
{
    public class CustomerData
    {
        private SqlDataAccess _sql = new SqlDataAccess();

        public void CreateCustomer(Customer customer)
        {
            var p = new DynamicParameters();

            p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
            p.Add("@CustomerName", customer.CustomerName);
            p.Add("@Address", customer.Address);
            p.Add("@Phone", customer.Phone);
            p.Add("@Balance", customer.Balance);

            _sql.SaveData("spCreateCustomer", p, _sql.GetConnectionName());
        }

        public void EditCustomer(Customer customer)
        {
            var p = new DynamicParameters();

            p.Add("@CustomerId", customer.Id);
            p.Add("@CustomerName", customer.CustomerName);
            p.Add("@Address", customer.Address);
            p.Add("@Phone", customer.Phone);

            _sql.SaveData("spEditCustomer", p, _sql.GetConnectionName());
        }

        public void ArchiveCustomer(int customerId)
        {
            var p = new DynamicParameters();

            p.Add("@CustomerId", customerId);

            _sql.SaveData("spArchiveCustomer", p, _sql.GetConnectionName());
        }

        public List<Customer> GetAllCustomers()
        {
            return _sql.LoadData<Customer, dynamic>("spGetAllCustomers", null, _sql.GetConnectionName());
        }

        public Customer GetCustomer(int customerId)
        {
            var p = new DynamicParameters();

            p.Add("@CustomerId", customerId);

            return _sql.LoadData<Customer, dynamic>("spGetCustomerById", p, _sql.GetConnectionName()).First();
        }

        public List<Customer> GetCustomersByName(string customerName)
        {
            var p = new DynamicParameters();

            p.Add("@CustomerName", customerName);

            return _sql.LoadData<Customer, dynamic>("spGetCustomerByName", p, _sql.GetConnectionName());
        }

    }

}
