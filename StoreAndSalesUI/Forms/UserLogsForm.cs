using StoreAndSalesLibrary.DataAccess;
using StoreAndSalesLibrary.Models;
using StoreAndSalesUI.Helpers;
using System;
using System.Text;
using System.Windows.Forms;


namespace StoreAndSalesUI.Forms
{
    /// <summary>
    /// شاشة إدارة سجلات العمليات (UserLog) في نظام المبيعات
    /// تعرض السجلات مع إمكانية الفلترة حسب المستخدم والفترة الزمنية ونص الوصف،
    /// مع دعم التصفّح بالصفحات (Paging) والتصدير إلى CSV.
    /// السجلات للعرض فقط (Read-Only) - لا تعديل أو حذف من خلال هذه الشاشة.
    /// </summary>
    public partial class UserLogsForm : Form
    {
        private readonly UserLogData _userLogData;

        private int _currentPage = 1;
        private int _pageSize = 50;
        private int _totalCount = 0;

        public UserLogsForm()
        {
            InitializeComponent();
            _userLogData = new UserLogData();
        }

        private void UserLogsForm_Load(object sender, EventArgs e)
        {
            // تهيئة فلتر التواريخ بشكل افتراضي (آخر 30 يوم)
            dtpTo.Value = DateTime.Today;
            dtpFrom.Value = DateTime.Today.AddDays(-30);

            // تهيئة قائمة عدد السجلات بالصفحة
            cmbPageSize.Items.AddRange(new object[] { 25, 50, 100, 200 });
            cmbPageSize.SelectedItem = _pageSize;
            cmbPageSize.SelectedIndexChanged += CmbPageSize_SelectedIndexChanged;

            LoadUsers();
            LoadLogs();
        }

        /// <summary>تحميل قائمة المستخدمين في قائمة الفلترة مع خيار "الكل" في الأعلى</summary>
        private void LoadUsers()
        {
            try
            {
                var table = _userLogData.GetUsers();

                // إضافة صف "الكل" في أول الجدول لعرض كل السجلات بدون فلترة على المستخدم
                var allRow = table.NewRow();
                allRow["Id"] = 0;
                allRow["UserName"] = "-- الكل --";
                table.Rows.InsertAt(allRow, 0);

                cmbUsers.DisplayMember = "UserName";
                cmbUsers.ValueMember = "Id";
                cmbUsers.DataSource = table;
                cmbUsers.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل قائمة المستخدمين:\n" + ex.Message,
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>تحميل سجلات العمليات حسب الفلاتر الحالية وحالة الترقيم</summary>
        private void LoadLogs()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                int? userId = null;
                if (cmbUsers.SelectedValue != null)
                {
                    int selected = Convert.ToInt32(cmbUsers.SelectedValue);
                    if (selected > 0)
                        userId = selected;
                }

                var logs = _userLogData.GetLogs(
                    userId,
                    dtpFrom.Value.Date,
                    dtpTo.Value.Date,
                    txtSearch.Text,
                    _currentPage,
                    _pageSize,
                    out _totalCount);

                dgvLogs.AutoGenerateColumns= false;
                dgvLogs.DataSource = logs;

                UpdatePagingInfo();
                txtDetails.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل السجلات:\n" + ex.Message,
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        /// <summary>تحديث عناصر شريط الترقيم (إجمالي السجلات، رقم الصفحة، تفعيل/تعطيل الأزرار)</summary>
        private void UpdatePagingInfo()
        {
            int totalPages = (int)Math.Ceiling((double)_totalCount / _pageSize);
            if (totalPages == 0)
                totalPages = 1;

            lblTotalCount.Text = string.Format("إجمالي السجلات: {0}", _totalCount);
            lblPageInfo.Text = string.Format("صفحة {0} من {1}", _currentPage, totalPages);

            btnFirst.Enabled = _currentPage > 1;
            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < totalPages;
            btnLast.Enabled = _currentPage < totalPages;
        }

        // ===================== أحداث أزرار الفلترة =====================

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _currentPage = 1;
            LoadLogs();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbUsers.SelectedIndex = 0;
            txtSearch.Clear();
            dtpTo.Value = DateTime.Today;
            dtpFrom.Value = DateTime.Today.AddDays(-30);
            _currentPage = 1;
            LoadLogs();
        }

        // ===================== أحداث أزرار الترقيم (Paging) =====================

        private void btnFirst_Click(object sender, EventArgs e)
        {
            _currentPage = 1;
            LoadLogs();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                LoadLogs();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)_totalCount / _pageSize);
            if (_currentPage < totalPages)
            {
                _currentPage++;
                LoadLogs();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)_totalCount / _pageSize);
            _currentPage = Math.Max(totalPages, 1);
            LoadLogs();
        }

        private void CmbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            _pageSize = Convert.ToInt32(cmbPageSize.SelectedItem);
            _currentPage = 1;
            LoadLogs();
        }

        // ===================== عرض التفاصيل والتصدير =====================

        /// <summary>عند تحديد صف، يتم عرض نص الوصف الكامل في لوحة التفاصيل
        /// (مفيد لأن عمود الوصف من نوع nvarchar(MAX) وقد يكون طويلاً)</summary>
        private void dgvLogs_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLogs.CurrentRow != null)
            {
                var log = dgvLogs.CurrentRow.DataBoundItem as UserLogModel;
                if (log != null)
                {
                    txtDetails.Text = log.Description;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "ملفات CSV (*.csv)|*.csv";
                sfd.FileName = string.Format("UserLogs_{0:yyyyMMdd_HHmmss}.csv", DateTime.Now);

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ExportToCsv(sfd.FileName);
                        MessageBox.Show("تم تصدير البيانات بنجاح.", "تم",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث خطأ أثناء التصدير:\n" + ex.Message,
                            "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>تصدير السجلات المعروضة في الصفحة الحالية إلى ملف CSV</summary>
        private void ExportToCsv(string path)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Id,UserId,UserName,Description,LogTime");

            foreach (DataGridViewRow row in dgvLogs.Rows)
            {
                var log = row.DataBoundItem as UserLogModel;
                if (log != null)
                {
                    sb.AppendLine(string.Format("{0},{1},{2},{3},{4}",
                        log.Id,
                        log.UserId,
                        EscapeCsv(log.UserName),
                        EscapeCsv(log.Description),
                        log.LogTime.ToString("yyyy-MM-dd HH:mm:ss")));
                }
            }

            System.IO.File.WriteAllText(path, sb.ToString(), Encoding.UTF8);
        }

        /// <summary>تهيئة قيمة نصية لتكون صالحة داخل ملف CSV (التعامل مع الفواصل وعلامات الاقتباس والأسطر الجديدة)</summary>
        private string EscapeCsv(string value)
        {
            if (string.IsNullOrEmpty(value))
                return "\"\"";

            return "\"" + value.Replace("\"", "\"\"").Replace("\r\n", " ").Replace("\n", " ") + "\"";
        }

        private void dgvLogs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvLogs.CurrentRow != null)
            //{
            //    var log = dgvLogs.CurrentRow.DataBoundItem as UserLogModel;
            //    if (log != null)
            //    {
            //        txtDetails.Text = log.Description;
            //    }
            //}
        }
    }
}
