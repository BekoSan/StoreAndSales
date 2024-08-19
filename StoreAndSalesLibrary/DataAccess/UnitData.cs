using Dapper;
using StoreAndSalesLibrary.Internal;
using StoreAndSalesLibrary.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace StoreAndSalesLibrary.DataAccess
{
 public  class UnitData
    {

        private SqlDataAccess _sql = new SqlDataAccess();

        public void CreateUnit(Unit unit)
        {
            var p = new DynamicParameters();

            p.Add("@Id",0, DbType.Int32, ParameterDirection.Output);
            p.Add("@UnitName", unit .UnitName);

            _sql.SaveData("spCreateUnit", p, _sql.GetConnectionName());
        }

        public void EditUnit(Unit unit)
        {
            var p = new DynamicParameters();

            p.Add("@UnitId", unit.Id);
            p.Add("@UnitName", unit.UnitName);

            _sql.SaveData("spEditUnit", p, _sql.GetConnectionName());
        }

        public List<Unit> GetAllUnits()
        {
            return _sql.LoadData<Unit, dynamic>("spGetAllUnits", null, _sql.GetConnectionName());
        }

        public Unit GetUnitById(int unitId)
        {
            var p = new DynamicParameters();

            p.Add("@UnitId", unitId);

            return _sql.LoadData<Unit, dynamic>("spGetUnitById", p, _sql.GetConnectionName()).First();
        }

    }
}
