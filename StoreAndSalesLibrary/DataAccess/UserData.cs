using Dapper;
using StoreAndSalesLibrary.Internal;
using StoreAndSalesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAndSalesLibrary.DataAccess
{
    public class UserData 
    {
        private  SqlDataAccess _sql = new SqlDataAccess();

        public void CreateUser(UserModel user)
        {
            var p = new DynamicParameters();

            p.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
            p.Add("@UserName", user.UserName);
            p.Add("@Password", user.Password);
            p.Add("@RoleId", user.RoleId);

            _sql.SaveData("sp_CreateUser", p, _sql.GetConnectionName());
        }

        public void EditUser(UserModel user)
        {
            var p = new DynamicParameters();

            p.Add("@UserId", user.Id);
            p.Add("@UserName", user.UserName);
            p.Add("@Password", user.Password);
            p.Add("@RoleId", user.RoleId);

            _sql.SaveData("sp_EditUser", p, _sql.GetConnectionName());
        }

        public void DeleteUser(int userId)
        {
            var p = new { UserId = userId };

            _sql.SaveData("sp_RemoveUser", p, _sql.GetConnectionName());
        }

        public UserModel GetUserById(int userId)
        {
            var p = new { UserId = userId };

            return _sql.LoadData<UserModel, dynamic>("sp_GetUserById", p, _sql.GetConnectionName()).First();
        }

        public UserModel UserLogin(UserModel user)
        {
            var p = new
            {
                user.UserName,
                user.Password
            };

            return _sql.LoadData<UserModel, dynamic>("sp_Login", p, _sql.GetConnectionName()).FirstOrDefault();
        }

        public List<UserModel> GetAllUsers()
        {
            return _sql.LoadData<UserModel, dynamic>("sp_GetAllUsers", null, _sql.GetConnectionName());
        }

        public List<UserRoleModel> GetAllRoles()
        {
            return _sql.LoadData<UserRoleModel, dynamic>("sp_GetAllRoles", null, _sql.GetConnectionName()); ;
        }

    }
}
