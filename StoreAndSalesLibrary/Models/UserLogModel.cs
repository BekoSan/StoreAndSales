using System;

namespace StoreAndSalesLibrary.Models
{
    /// <summary>
    /// يمثل سجل عملية واحد في جدول UserLog
    /// (مطابق لأعمدة الجدول: Id, UserId, Description, LogTime)
    /// </summary>
    public class UserLogModel
    {
        /// <summary>المعرّف الفريد للسجل (Primary Key)</summary>
        public int Id { get; set; }

        /// <summary>معرّف المستخدم الذي قام بالعملية (Foreign Key -> Users.Id)</summary>
        public int UserId { get; set; }

        /// <summary>اسم المستخدم (يأتي من جدول Users عبر JOIN)</summary>
        public string UserName { get; set; }

        /// <summary>نص وصف العملية المنفذة</summary>
        public string Description { get; set; }

        /// <summary>تاريخ ووقت تنفيذ العملية</summary>
        public DateTime LogTime { get; set; }
    }
}
