using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StoreAndSalesLibrary.Models;
using StoreAndSalesLibrary.DataAccess;
using StoreAndSalesUI.Helpers;

namespace StoreAndSalesUI.Forms
{
    public partial class SaleReturnForm : Form
    {
        // إندكسات الأعمدة - لازم تتطابق مع ترتيبها في SaleReturnForm.Designer.cs
        private const int COL_ITEM_ID = 0;
        private const int COL_ITEM_NAME = 1;
        private const int COL_PRICE = 2;
        private const int COL_ORIGINAL_QTY = 3;
        private const int COL_ALREADY_RETURNED = 4;
        private const int COL_REMAINING_QTY = 5;
        private const int COL_RETURN_QTY = 6;
        private const int COL_UNITID = 7;

        private readonly int _saleId;
        private readonly int _customerId;
        private readonly int _userId;
        private readonly SaleData _saleDal;
        private readonly UserLogData _userLogData;
        private readonly VoucherData _voucherData;
        private readonly CustomerData _customerData;
        private Voucher _voucher;

        // الفورم تستقبل بيانات الفاتورة الأصلية اللي رجعت من شاشة البحث عندك
        public SaleReturnForm(int saleId, int customerId, string customerName, int userId)
        {
            InitializeComponent();

            _saleId = saleId;
            _customerId = customerId;
            _userId = userId;
            _saleDal = new SaleData(UsefulMethods.ConnectionStringName());
            _userLogData = new UserLogData();
            _voucherData = new VoucherData();
            _customerData = new CustomerData();
            
            
            txtInvoiceNo.Text = saleId.ToString();
            txtCustomer.Text = customerName;

            this.Load += SaleReturnForm_Load;
            this.dgvReturnDetails.CellValidating += dgvReturnDetails_CellValidating;
            this.dgvReturnDetails.CellEndEdit += dgvReturnDetails_CellEndEdit;
            this.btnReturnAll.Click += btnReturnAll_Click;
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
        }

        private void SaleReturnForm_Load(object sender, EventArgs e)
        {
            LoadReturnableDetails();
        }

        // يجيب من الـ DAL كل سطر في الفاتورة الأصلية مع حساب "المتبقي القابل للإرجاع"
        private void LoadReturnableDetails()
        {
            dgvReturnDetails.Rows.Clear();

            List<ReturnableSaleDetail> details = _saleDal.GetReturnableSaleDetails(_saleId);

            foreach (var d in details)
            {
                // نخفي الأصناف اللي خلص مرتجعها بالكامل، ما فيه داعي نعرضها
                if (d.RemainingQuantity <= 0)
                    continue;

                int rowIndex = dgvReturnDetails.Rows.Add();
                var row = dgvReturnDetails.Rows[rowIndex];

                row.Cells[COL_ITEM_ID].Value = d.ItemId;
                row.Cells[COL_ITEM_NAME].Value = d.ItemName;
                row.Cells[COL_PRICE].Value = d.Price;
                row.Cells[COL_ORIGINAL_QTY].Value = d.OriginalQuantity;
                row.Cells[COL_ALREADY_RETURNED].Value = d.AlreadyReturned;
                row.Cells[COL_REMAINING_QTY].Value = d.RemainingQuantity;
                row.Cells[COL_RETURN_QTY].Value = 0;
                row.Cells[COL_UNITID].Value = d.UnitId;
            }

            UpdateReturnTotal();
        }

        // تحقق فوري: ما تتجاوز كمية الإرجاع المتبقي، وما تكون قيمة سالبة أو غير رقمية
        private void dgvReturnDetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex != COL_RETURN_QTY) return;

            if (!int.TryParse(e.FormattedValue.ToString(), out int enteredQty))
            {
                MessageBox.Show("الرجاء إدخال رقم صحيح");
                e.Cancel = true;
                return;
            }

            int remaining = Convert.ToInt32(dgvReturnDetails.Rows[e.RowIndex].Cells[COL_REMAINING_QTY].Value);

            if (enteredQty < 0)
            {
                MessageBox.Show("لا يمكن إدخال كمية سالبة");
                e.Cancel = true;
                return;
            }

            if (enteredQty > remaining)
            {
                MessageBox.Show($"الكمية المدخلة تتجاوز المتبقي القابل للإرجاع ({remaining})");
                e.Cancel = true;
            }
        }

        private void dgvReturnDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == COL_RETURN_QTY)
                UpdateReturnTotal();
        }

        // زر "إرجاع الفاتورة بالكامل" - يعبّي كل الصفوف بالكمية المتبقية كاملة دفعة وحدة
        private void btnReturnAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvReturnDetails.Rows)
            {
                if (row.IsNewRow) continue;
                row.Cells[COL_RETURN_QTY].Value = row.Cells[COL_REMAINING_QTY].Value;
            }
            UpdateReturnTotal();
        }

        private void UpdateReturnTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvReturnDetails.Rows)
            {
                if (row.IsNewRow) continue;
                int qty = Convert.ToInt32(row.Cells[COL_RETURN_QTY].Value ?? 0);
                decimal price = Convert.ToDecimal(row.Cells[COL_PRICE].Value ?? 0);
                total += qty * price;
            }
            txtReturnTotal.Text = total.ToString("N0");
        }

        // زر "حفظ المرتجع" - يجمع كل السطور اللي فيها كمية مرتجعة > 0 في فاتورة (Sale) واحدة بكمية سالبة
        private void btnSave_Click(object sender, EventArgs e)
        {
            var linesToReturn = dgvReturnDetails.Rows.Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow && Convert.ToInt32(r.Cells[COL_RETURN_QTY].Value ?? 0) > 0)
                .ToList();

            if (!linesToReturn.Any())
            {
                MessageBox.Show("لم تحدد أي كمية لإرجاعها");
                return;
            }

            if (MessageBox.Show(
                    $"سيتم إنشاء فاتورة مرتجع بقيمة {txtReturnTotal.Text}، هل تريد المتابعة؟",
                    "تأكيد المرتجع", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            // ملاحظة: هذا يفترض إضافة الخاصيتين OriginalSaleId و IsReturn
            // على كلاس Sale عندك (راجع ملف SaleReturn.sql المرفق لإضافة الأعمدة في القاعدة)
            var returnSale = new Sale
            {
                CustomerId = _customerId,
                SaleDate = DateTime.Now,
                OriginalSaleId = _saleId,
                IsReturn = true,
                UserId = _userId,
                Notes = $"مرتجع للفاتورة رقم {_saleId}"
            };

            decimal grandTotal = 0;

            foreach (var row in linesToReturn)
            {
                int itemId = Convert.ToInt32(row.Cells[COL_ITEM_ID].Value);
                int qty = Convert.ToInt32(row.Cells[COL_RETURN_QTY].Value);
                decimal price = Convert.ToDecimal(row.Cells[COL_PRICE].Value);
                decimal lineTotal = qty * price;
                int unitId = Convert.ToInt32(row.Cells[COL_UNITID].Value);

                returnSale.SaleDetails.Add(new SaleDetail
                {
                    // عدّل اسم الخاصية حسب الموجود فعلياً في SaleDetail عندك لو مختلف عن ItemId
                    ItemId = itemId,
                    Quantity = -qty,   // سالب - هذا هو أساس فكرة المرتجع المبسّط
                    Price = price,
                    UnitId = unitId
                });

                grandTotal += lineTotal;
            }

            returnSale.Total = -grandTotal;
            returnSale.IsReturn = true;
            try
            {
                bool created = _saleDal.CreateSale(returnSale);
                if (created)
                {
                    //_saleDal.CreateSaleDetails(returnSale.SaleDetails);
                    //LogHelper.Log(_userId, "SaleReturn",
                    //    $"إرجاع للفاتورة رقم {_saleId} بقيمة {grandTotal:N0}");
                    _userLogData.AddLog(LoginDataHelper.UserId, $"إرجاع للفاتورة رقم {_saleId} بقيمة {grandTotal}");
                    
                    MessageBox.Show("تم حفظ المرتجع بنجاح","تم حفظ المرتجع",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء حفظ المرتجع: " + ex.Message,"خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

   
    }
}
