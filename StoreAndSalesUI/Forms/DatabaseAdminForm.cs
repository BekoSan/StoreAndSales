using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.IO;

namespace StoreAndSalesUI.Forms
{
    public partial class DatabaseAdminForm : Form
    {
        public DatabaseAdminForm()
        {
            InitializeComponent();
        }

        #region Private Methods


        public void BackupDatabase(string backupFilePath)
        {
          
            string dbName = "ProStoreAndSalesDB";
            string connectionString = @"Data Source=(LocalDB)\LocalDB2022;AttachDbFilename=|DataDirectory|\ProStoreAndSalesDB.mdf;Integrated Security=True";

            string query = $@"BACKUP DATABASE [{dbName}] TO DISK = '{backupFilePath}' WITH FORMAT, MEDIANAME = 'Z_SQLServerBackups', NAME = 'Full Backup of {dbName}';";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تمت عملية النسخ الاحتياطي بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ أثناء النسخ: " + ex.Message);
                }
            }
        }

        public void RestoreDatabase(string backupFilePath, string targetFolder)
        {
            string dbName = "ProStoreAndSalesDB"; // اسم قاعدة البيانات داخل السيرفر
            string logicalNameMdf = "ProStoreAndSalesDB"; // الاسم المنطقي لملف البيانات
            string logicalNameLog = "ProStoreAndSalesDB_log"; // الاسم المنطقي لملف السجل

            // إنشاء المسارات الكاملة للملفات الجديدة
            string newMdfPath = Path.Combine(targetFolder, dbName + ".mdf");
            string newLdfPath = Path.Combine(targetFolder, dbName + ".ldf");

            // الاتصال بقاعدة master للقيام بالعملية
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True";

            string query = $@"
        ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
        RESTORE DATABASE [{dbName}] 
        FROM DISK = '{backupFilePath}' 
        WITH REPLACE,
        MOVE '{logicalNameMdf}' TO '{newMdfPath}', 
        MOVE '{logicalNameLog}' TO '{newLdfPath}';
        ALTER DATABASE [{dbName}] SET MULTI_USER;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"تم استعادة قاعدة البيانات ونقل الملفات إلى:\n{targetFolder}", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ أثناء الاستعادة: " + ex.Message);
                }
            }
        }

        #endregion

        private void backupButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "حدد مكان حفظ النسخة الإحتياطية";
            sfd.Filter = "Backup Files (*.bak)|*.bak";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                BackupDatabase(sfd.FileName);
            }
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "إختيار ملف قاعدة البيانات للإستراجاع";
            ofd.Filter = "Backup Files (*.bak)|*.bak";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                RestoreDatabase(ofd.FileName,Application.StartupPath+@"\DB");
            }
        }
    }
}
