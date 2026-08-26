using Dapper;
using StoreAndSalesLibrary.Internal;
using StoreAndSalesLibrary.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace StoreAndSalesLibrary.DataAccess
{
    public class StoreData
    {
        private readonly SqlDataAccess _sql = new SqlDataAccess();

        public List<Store> GetAllStores()
        {
            return _sql.LoadData<Store, dynamic>("spGetAllStores", null, _sql.GetConnectionName());
        }

        public int GetDefaultStoreId()
        {
            return _sql.LoadData<int, dynamic>("spGetDefaultStoreId", null, _sql.GetConnectionName()).FirstOrDefault();
        }

        public void CreateStore(Store store)
        {
            var p = new DynamicParameters();
            p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
            p.Add("@StoreName", store.StoreName);
            p.Add("@StoreAddress", store.StoreAddress);
            p.Add("@IsDefault", store.IsDefault);
            _sql.SaveData("spCreateStore", p, _sql.GetConnectionName());
        }

        public void EditStore(Store store)
        {
            var p = new DynamicParameters();
            p.Add("@StoreId", store.Id);
            p.Add("@StoreName", store.StoreName);
            p.Add("@StoreAddress", store.StoreAddress);
            p.Add("@IsDefault", store.IsDefault);
            _sql.SaveData("spEditStore", p, _sql.GetConnectionName());
        }

        public void ArchiveStore(int storeId)
        {
            var p = new DynamicParameters();
            p.Add("@StoreId", storeId);
            _sql.SaveData("spArchiveStore", p, _sql.GetConnectionName());
        }
    }
}
