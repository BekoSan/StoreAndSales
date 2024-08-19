using Dapper;
using StoreAndSalesLibrary.Internal;
using StoreAndSalesLibrary.Models;
using System.Collections.Generic;
using System.Data;

namespace StoreAndSalesLibrary.DataAccess
{
    public class ItemUnitData
    {

        private SqlDataAccess _sql = new SqlDataAccess();

        public void EditItemUnitPrice(int itemId, int unitId, decimal unitPrice)
        {
            var p = new DynamicParameters();
            p.Add("@ItemId", itemId);
            p.Add("@UnitId", unitId);
            p.Add("@UnitPrice", unitPrice);

            _sql.SaveData("spEditItemUnitPrice", p, _sql.GetConnectionName());
        }

        public List<ItemUnit> GetItemUnits(int itemId)
        {
            var p = new DynamicParameters();

            p.Add("@ItemId", itemId);

            return _sql.LoadData<ItemUnit, dynamic>("spGetItemUnits", p, _sql.GetConnectionName());
        }

        public List<T> GetItemUnits<T>(int itemId)
        {
            var p = new DynamicParameters();

            p.Add("@ItemId", itemId);

            return _sql.LoadData<T, dynamic>("spGetItemUnitsLookup", p, _sql.GetConnectionName());
        }
    }
}
