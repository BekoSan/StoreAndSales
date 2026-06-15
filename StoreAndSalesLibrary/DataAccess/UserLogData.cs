using StoreAndSalesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace StoreAndSalesLibrary.DataAccess
{
    /// <summary>
    /// طبقة الوصول لبيانات جدول UserLog (سجلات العمليات)
    /// تعتمد على ADO.NET مباشرة (SqlConnection / SqlCommand / SqlDataAdapter)
    /// متوافقة مع .NET Framework 4.5
    /// </summary>
    public class UserLogData
    {
        private readonly string _connectionString;

        /// <summary>
        /// يقرأ سلسلة الاتصال من ملف App.config بالاسم "SalesDb"
        /// تأكد من إضافة connectionStrings في App.config (انظر ملف README)
        /// </summary>
        public UserLogData()
        {
            _connectionString = ConfigurationManager.ConnectionStrings[ConfigurationManager.AppSettings["ConnectionName"]].ConnectionString;
        }

        /// <summary>يسمح بتمرير سلسلة اتصال مخصصة مباشرة</summary>
        public UserLogData(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// جلب قائمة المستخدمين لتعبئة قائمة الفلترة (ComboBox)
        /// ملاحظة: عدّل اسم الجدول/الأعمدة إذا كانت مختلفة في قاعدة بياناتك
        /// (الافتراض: جدول Users يحتوي على Id و UserName)
        /// </summary>
        public DataTable GetUsers()
        {
            const string query = @"
                SELECT Id, UserName 
                FROM Users 
                ORDER BY UserName";

            using (var connection = new SqlConnection(_connectionString))
            using (var adapter = new SqlDataAdapter(query, connection))
            {
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        /// <summary>
        /// جلب سجلات العمليات مع دعم الفلترة (المستخدم - الفترة الزمنية - نص البحث)
        /// ودعم التصفّح بالصفحات (Paging) عبر OFFSET / FETCH
        /// </summary>
        /// <param name="userId">معرّف المستخدم للفلترة، أو null لعرض الجميع</param>
        /// <param name="fromDate">بداية الفترة (شامل)</param>
        /// <param name="toDate">نهاية الفترة (شامل لليوم بالكامل)</param>
        /// <param name="searchText">نص للبحث داخل عمود الوصف</param>
        /// <param name="pageNumber">رقم الصفحة المطلوبة (يبدأ من 1)</param>
        /// <param name="pageSize">عدد السجلات في كل صفحة</param>
        /// <param name="totalCount">إجمالي عدد السجلات المطابقة للفلتر (يُرجع عبر out)</param>
        public List<UserLogModel> GetLogs(
            int? userId,
            DateTime? fromDate,
            DateTime? toDate,
            string searchText,
            int pageNumber,
            int pageSize,
            out int totalCount)
        {
            var logs = new List<UserLogModel>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // بناء شرط WHERE بشكل ديناميكي وآمن (Parameters لمنع SQL Injection)
                var whereBuilder = new StringBuilder(" WHERE 1 = 1 ");

                if (userId.HasValue && userId.Value > 0)
                    whereBuilder.Append(" AND ul.UserId = @UserId ");

                if (fromDate.HasValue)
                    whereBuilder.Append(" AND ul.LogTime >= @FromDate ");

                if (toDate.HasValue)
                    whereBuilder.Append(" AND ul.LogTime < @ToDate ");

                if (!string.IsNullOrWhiteSpace(searchText))
                    whereBuilder.Append(" AND ul.Description LIKE @SearchText ");

                string whereClause = whereBuilder.ToString();

                // 1) حساب إجمالي عدد السجلات المطابقة (لاستخدامه في حساب عدد الصفحات)
                string countQuery = "SELECT COUNT(*) FROM UserLog ul " + whereClause;

                using (var countCmd = new SqlCommand(countQuery, connection))
                {
                    AddFilterParameters(countCmd, userId, fromDate, toDate, searchText);
                    totalCount = (int)countCmd.ExecuteScalar();
                }

                // 2) جلب سجلات الصفحة المطلوبة فقط (مرتبة من الأحدث للأقدم)
                string dataQuery = @"
                    SELECT ul.Id, ul.UserId, u.UserName, ul.Description, ul.LogTime
                    FROM UserLog ul
                    LEFT JOIN Users u ON u.Id = ul.UserId "
                    + whereClause + @"
                    ORDER BY ul.LogTime DESC, ul.Id DESC
                    OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";

                using (var dataCmd = new SqlCommand(dataQuery, connection))
                {
                    AddFilterParameters(dataCmd, userId, fromDate, toDate, searchText);
                    dataCmd.Parameters.AddWithValue("@Offset", (pageNumber - 1) * pageSize);
                    dataCmd.Parameters.AddWithValue("@PageSize", pageSize);

                    using (var reader = dataCmd.ExecuteReader())
                    {
                        int idxId = reader.GetOrdinal("Id");
                        int idxUserId = reader.GetOrdinal("UserId");
                        int idxUserName = reader.GetOrdinal("UserName");
                        int idxDescription = reader.GetOrdinal("Description");
                        int idxLogTime = reader.GetOrdinal("LogTime");

                        while (reader.Read())
                        {
                            logs.Add(new UserLogModel
                            {
                                Id = reader.GetInt32(idxId),
                                UserId = reader.GetInt32(idxUserId),
                                UserName = reader.IsDBNull(idxUserName) ? "" : reader.GetString(idxUserName),
                                Description = reader.IsDBNull(idxDescription) ? "" : reader.GetString(idxDescription),
                                LogTime = reader.GetDateTime(idxLogTime)
                            });
                        }
                    }
                }
            }

            return logs;
        }

        /// <summary>إضافة معاملات الفلترة المشتركة بين استعلام العدّ واستعلام البيانات</summary>
        private void AddFilterParameters(SqlCommand cmd, int? userId, DateTime? fromDate, DateTime? toDate, string searchText)
        {
            if (userId.HasValue && userId.Value > 0)
                cmd.Parameters.AddWithValue("@UserId", userId.Value);

            if (fromDate.HasValue)
                cmd.Parameters.AddWithValue("@FromDate", fromDate.Value.Date);

            if (toDate.HasValue)
                cmd.Parameters.AddWithValue("@ToDate", toDate.Value.Date.AddDays(1));

            if (!string.IsNullOrWhiteSpace(searchText))
                cmd.Parameters.AddWithValue("@SearchText", "%" + searchText.Trim() + "%");
        }

        /// <summary>
        /// إضافة سجل عملية جديد. تُستخدم من أي شاشة أخرى في النظام
        /// عند تنفيذ عملية (بيع، تعديل، حذف، تسجيل دخول... إلخ)
        /// ملاحظة: عمود LogTime يُعبّأ تلقائياً بالقيمة الافتراضية sysdatetime()
        /// </summary>
        public void AddLog(int userId, string description)
        {
            const string query = @"
                INSERT INTO UserLog (UserId, Description) 
                VALUES (@UserId, @Description)";

            using (var connection = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@Description", description ?? string.Empty);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// حذف السجلات الأقدم من تاريخ معيّن (لتنظيف السجلات القديمة بشكل دوري)
        /// يُعيد عدد السجلات المحذوفة
        /// </summary>
        public int DeleteOldLogs(DateTime olderThan)
        {
            const string query = "DELETE FROM UserLog WHERE LogTime < @OlderThan";

            using (var connection = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@OlderThan", olderThan);
                connection.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
