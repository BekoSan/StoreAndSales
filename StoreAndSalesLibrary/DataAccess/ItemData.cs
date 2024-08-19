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
    public class ItemData
    {
        private SqlDataAccess _sql = new SqlDataAccess();
        private SqlConnection _connection = new SqlConnection();
        private SqlTransaction _transaction;
        private int _itemId = 0;

        public ItemData(string connectionStringName = "")
        {
            if (connectionStringName != "")
            {
                _connection.ConnectionString = _sql.GetConnectionString(connectionStringName);
                _connection.Open();
            }
        }

        public void CreateItem(Item item)
        {
            _transaction = _connection.BeginTransaction();

            using (SqlCommand cmd = new SqlCommand("spCreateItem", _connection, _transaction))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.Add("@Id", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@ItemName", SqlDbType.NVarChar).Value = item.ItemName;

                cmd.ExecuteNonQuery();

                _itemId = int.Parse(cmd.Parameters["@Id"].Value.ToString());

            }

            CreateItemUnits(item.ItemUnits); 
        }

        public void EditItem(Item item)
        {
            _transaction = _connection.BeginTransaction();

            using (SqlCommand cmd = new SqlCommand("spEditItem", _connection, _transaction))
            {

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ItemId", SqlDbType.Int).Value = item.Id;
                cmd.Parameters.Add("@ItemName", SqlDbType.NVarChar).Value = item.ItemName;

                cmd.ExecuteNonQuery();

                _itemId = item.Id;

            }

            EditItemUnits(item.ItemUnits);
        }

        public void CreateItemUnits(List<ItemUnit> itemUnits)
        {
            try
            {
                itemUnits.ForEach(itemUnit =>
                {
                    using (SqlCommand cmd = new SqlCommand("spCreateItemUnit", _connection, _transaction))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@ItemId", SqlDbType.Int).Value = _itemId;
                        cmd.Parameters.Add("@UnitId", SqlDbType.Int).Value = itemUnit.UnitId;
                        cmd.Parameters.Add("@UnitPrice", SqlDbType.Money).Value = itemUnit.UnitPrice;

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

        public void CreateItemUnit(ItemUnit itemUnit) 
        {
            using (SqlCommand cmd = new SqlCommand("spCreateItemUnit", _connection, _transaction))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ItemId", SqlDbType.Int).Value = _itemId;
                cmd.Parameters.Add("@UnitId", SqlDbType.Int).Value = itemUnit.UnitId;
                cmd.Parameters.Add("@UnitPrice", SqlDbType.Money).Value = itemUnit.UnitPrice;

                cmd.ExecuteNonQuery();
            }
        }

        public void EditItemUnits(List<ItemUnit> itemUnits)
        {
            try
            {
                itemUnits.ForEach(itemUnit =>
                {
                    if (itemUnit.Id == 0)
                    {
                        CreateItemUnit(itemUnit);
                    }
                    else
                    {
                        using (SqlCommand cmd = new SqlCommand("spEditItemUnitPrice", _connection, _transaction))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@ItemId", SqlDbType.Int).Value = _itemId;
                            cmd.Parameters.Add("@UnitId", SqlDbType.Int).Value = itemUnit.UnitId;
                            cmd.Parameters.Add("@UnitPrice", SqlDbType.Money).Value = itemUnit.UnitPrice;

                            cmd.ExecuteNonQuery();
                        }
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

        public void ArchiveItem(int itemId)
        {
            var p = new DynamicParameters();

            p.Add("@ItemId", itemId);

            _sql.SaveData("spArchiveItem", p, _sql.GetConnectionName());
        }

        public List<Item> GetAllItems()
        {
            return _sql.LoadData<Item, dynamic>("spGetAllItems", null, _sql.GetConnectionName());
        }

        public Item GetItem(int itemId)
        {
            var p = new DynamicParameters();

            p.Add("@ItemId", itemId);

            return _sql.LoadData<Item, dynamic>("spGetItemById", p, _sql.GetConnectionName()).First();
        }

        public List<Customer> GetItemsByName(string itemName)
        {
            var p = new DynamicParameters();

            p.Add("@ItemName", itemName);

            return _sql.LoadData<Customer, dynamic>("spGetItemByName", p, _sql.GetConnectionName());
        }

        ///Get the quantity of items depend on sales and purchaces
        public int GetItemQuantity(int itemId,int unitId)
        {
            var p = new DynamicParameters();

            p.Add("@ItemId", itemId);
            p.Add("@UnitId", unitId);

            return _sql.LoadData<int, dynamic>("spGetItemQuantity", p, _sql.GetConnectionName()).First();
        }

        ///Get the latest price of unit depend on latest purchase date
        public decimal  GetItemLatestPurchasePrice(int itemId, int unitId)
        {
            var p = new DynamicParameters();

            p.Add("@ItemId", itemId);
            p.Add("@UnitId", unitId);

            return _sql.LoadData<decimal, dynamic>("spGetItemLatestPrice", p, _sql.GetConnectionName()).First();
        }

    }
}
