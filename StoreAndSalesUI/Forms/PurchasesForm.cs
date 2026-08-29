using StoreAndSalesLibrary.DataAccess;
using StoreAndSalesLibrary.Models;
using StoreAndSalesUI.Helpers;
using StoreAndSalesUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StoreAndSalesUI.Forms
{
    public partial class PurchasesForm : Form, IItemRequester, IUnitRequester, IPurchaseRequester
    {
        public PurchasesForm()
        {
            InitializeComponent();
            EnableGridDoubleBuffering(purchaseDetailsDataGridView);
            _choosePurchaseForm = new ChoosePurchaseForm(this);

        }

        #region Private Members

        private SupplierData _supplierData = new SupplierData();
        private List<Supplier> _suppliers = new List<Supplier>();
        private StoreData _storeData = new StoreData();
        private List<Store> _stores = new List<Store>();
        private PurchaseData _purchaseData = new PurchaseData(UsefulMethods.ConnectionStringName());
        private Purchase _purchase = new Purchase();
        private PurchaseDetailData _purchaseDetailData = new PurchaseDetailData();
        private ItemUnitData _itemUnitData = new ItemUnitData();
        private UnitData _unitData = new UnitData();
        private ItemData _itemData = new ItemData();
        private decimal _totalCost = 0;
        private decimal _disscount = 0;
        private VoucherData _voucherData = new VoucherData();
        private Voucher _voucher = new Voucher();
        private bool isPurchasePreview = false;
        private ChoosePurchaseForm _choosePurchaseForm;
        private UserLogData _userLogData = new UserLogData();
        private ChooseItemForm _chooseItemForm;
        private readonly Dictionary<int, string> _itemNameCache = new Dictionary<int, string>();
        private readonly Dictionary<int, string> _unitNameCache = new Dictionary<int, string>();

        #endregion

        #region Private Methods

        private void LoadSuppliers()
        {
            _suppliers = _supplierData.GetAllSuppliers();
            suppliersComboBox.DataSource = _suppliers;
            suppliersComboBox.ValueMember = "Id";
            suppliersComboBox.DisplayMember = "SupplierName";
            suppliersComboBox.SelectedIndex = -1;
        }

        private void LoadStores()
        {
            _stores = _storeData.GetAllStores() ?? new List<Store>();
            storesComboBox.DataSource = _stores;
            storesComboBox.ValueMember = "Id";
            storesComboBox.DisplayMember = "StoreName";
            storesComboBox.SelectedValue = _storeData.GetDefaultStoreId();
        }

        private int GetSelectedStoreId()
        {
            int selectedStoreId;
            return storesComboBox.SelectedValue != null
                && int.TryParse(storesComboBox.SelectedValue.ToString(), out selectedStoreId)
                ? selectedStoreId
                : _storeData.GetDefaultStoreId();
        }

        private void CollectData()
        {
            _purchase.SupplierId = (suppliersComboBox.SelectedValue == null) ? 0 : suppliersComboBox.SelectedValue.ToString().ParseToInt();
            _purchase.StoreId = GetSelectedStoreId();
            _purchase.Total = totalTextBox.Text.ParseToDecimal();
            _purchase.Disscount = disscountTextBox.Text.ParseToDecimal();
            _purchase.Notes = notesTextBox.Text;
            _purchase.PaymentType = paymentTypeCheckBox.Checked;
            _purchase.IsDisscount = isDisscountCheckBox.Checked;
            _purchase.Status = (disscountTextBox.Text.ParseToDecimal() != 0
               && !isDisscountCheckBox.Checked ? false : true);
            _purchase.UserId = LoginDataHelper.UserId;

            CollectPurchaseDetails();
        }

        private void CollectPurchaseDetails()
        {
            _purchase.PurchaseDetails.Clear();

            foreach (DataGridViewRow row in purchaseDetailsDataGridView.Rows)
            {
                _purchase.PurchaseDetails.Add(new PurchaseDetail
                {
                    ItemId = row.Cells[0].Value.ToString().ParseToInt(),
                    Quantity = row.Cells[3].Value.ToString().ParseToInt(),
                    Price = row.Cells[4].Value.ToString().ParseToDecimal(),
                    UnitId = row.Cells[5].Value.ToString().ParseToInt()
                });
            }
        }

        private void AddItemToPurchase()
        {
            if (_chooseItemForm == null || _chooseItemForm.IsDisposed)
            {
                _chooseItemForm = new ChooseItemForm(this, GetSelectedStoreId())
                {
                    TopLevel = false,
                    ControlBox = false,
                    Dock = DockStyle.Fill,
                    FormBorderStyle = FormBorderStyle.None
                };

                panel1.Controls.Add(_chooseItemForm);
                _chooseItemForm.Show();
            }
            else
            {
                _chooseItemForm.Visible = true;
                _chooseItemForm.BringToFront();
            }
        }

        private static void EnableGridDoubleBuffering(DataGridView grid)
        {
            try
            {
                typeof(DataGridView)
                    .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                    ?.SetValue(grid, true, null);
            }
            catch (Exception)
            {
                // Double buffering is an optional UI optimization.
            }
        }

        private void ChangeUnit()
        {
            if (_purchase.Id != 0) return;
            new ChooseUnitForm(this).ShowDialog();
        }

        private void CalculateTotalCost()
        {
            _totalCost = 0;

            foreach (DataGridViewRow row in purchaseDetailsDataGridView.Rows)
            {
                int quantity = row.Cells[3].Value.ToString().ParseToInt();
                decimal price = row.Cells[4].Value.ToString().ParseToDecimal();

                _totalCost += (quantity * price);
            }
        }

        private void UpdateLineTotal(DataGridViewRow row)
        {
            if (row == null || row.IsNewRow)
            {
                return;
            }

            int quantity = Convert.ToString(row.Cells[3].Value).ParseToInt();
            decimal price = Convert.ToString(row.Cells[4].Value).ParseToDecimal();
            row.Cells["lineTotalColumn"].Value = quantity * price;
        }

        private void UpdateAllLineTotals()
        {
            foreach (DataGridViewRow row in purchaseDetailsDataGridView.Rows)
            {
                UpdateLineTotal(row);
            }
        }

        private void PreviewTotalCost(decimal totalCost)
        {
            totalTextBox.Text = totalCost.ToString("#,0");
        }

        private void UpdateUnpaidFlag(bool isUnpaid)
        {
            unpaidFlagLabel.Visible = isUnpaid;
            unpaidFlagLabel.Text = isUnpaid ? "غير خالصة - عليها متبقي" : string.Empty;
        }

        private void CalculateDisscount()
        {
            decimal totalAfterDisscount;

            _disscount = disscountTextBox.Text.ParseToDecimal();
            totalAfterDisscount = _totalCost - _disscount;
            PreviewTotalCost(totalAfterDisscount);
        }

        private void LoadNextPurchaseId()
        {
            if (isPurchasePreview) return;
            purchaseIdTextBox.Text = (_purchaseData.GetLastPurchaseId() + 1).ToString();
        }

        private void ClearForm()
        {
            purchaseDetailsDataGridView.Rows.Clear();
            suppliersComboBox.SelectedIndex = -1;
            notesTextBox.Clear();
            paymentTypeCheckBox.Checked = false;
            isDisscountCheckBox.Checked = false;
        }

        private void ResetForm()
        {
            ClearForm();
            LoadNextPurchaseId();
            _totalCost = 0;
            _purchase = new Purchase();
            PreviewTotalCost(0);
            disscountTextBox.Text = "0";
            EnableDissableEditing(true);
            isPurchasePreview = false;
        }

        private bool IsValidPriceAndQuantity()
        {
            bool output = true;
            foreach (DataGridViewRow row in purchaseDetailsDataGridView.Rows)
            {
                if (row.Cells[3].Value.Equals(0)
                    || row.Cells[3].Value.ToString().Trim().Equals("")
                    || row.Cells[4].Value.Equals(0)
                    || row.Cells[4].Value.ToString().Trim().Equals(""))
                {
                    output = false;
                    break;
                }
            }

            return output;
        }

        private bool IsValidData()
        {
            bool output = true;

            if (_purchase.SupplierId == 0)
            {
                MessageBox.Show("يجب إختيار المـورد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
            }
            else if (_purchase.PurchaseDetails.Count == 0)
            {
                MessageBox.Show("يجب إضافة صنف واحد على الأقل في الفاتورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
            }
            else if (IsValidPriceAndQuantity() == false)
            {
                MessageBox.Show("يجب إدخال جميع الكميات والأسعار بصورة صحيحة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
            }

            return output;
        }

        private void Save()
        {
            try
            {
                if (_purchaseData.CreatePurchase(_purchase))
                {
                    SavePurchaseVoucher(_purchase.Id);
                    _userLogData.AddLog(LoginDataHelper.UserId, $"تم تسجيل عملية شراء أصناف من المورد {suppliersComboBox.Text} بقيمة {string.Format(totalTextBox.Text, "#,0")} ");
                    MessageBox.Show("تمت الإضافة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsefulMethods.LogException(ex);
            }
        }

        private void EnableDissableEditing(bool isEnabled)
        {
            saveButton.Enabled = isEnabled;
            addItemButton.Enabled = isEnabled;
            purchaseDetailsDataGridView.ReadOnly = !isEnabled;
            purchaseDetailsDataGridView.Columns["colDelete"].Visible = isEnabled;
            disscountTextBox.Enabled = isEnabled;
            suppliersComboBox.Enabled = isEnabled;
            notesTextBox.Enabled = isEnabled;
            isDisscountCheckBox.Enabled = isEnabled;
            paymentTypeCheckBox.Enabled = isEnabled;
            printButton.Enabled = !isEnabled;
        }

        private void LoadItemNameAndUnitFromRow(DataGridViewRow dgvRow)
        {
            if (dgvRow == null || dgvRow.IsNewRow)
            {
                return;
            }

            int itemId = dgvRow.Cells[0].Value.ToString().ParseToInt();
            int unitId = dgvRow.Cells[5].Value.ToString().ParseToInt();

            string itemName;
            if (!_itemNameCache.TryGetValue(itemId, out itemName))
            {
                itemName = _itemData.GetItem(itemId).ItemName;
                _itemNameCache[itemId] = itemName;
            }

            string unitName;
            if (!_unitNameCache.TryGetValue(unitId, out unitName))
            {
                unitName = _unitData.GetUnitById(unitId).UnitName;
                _unitNameCache[unitId] = unitName;
            }

            dgvRow.Cells[1].Value = itemName;
            dgvRow.Cells[2].Value = unitName;
        }

        private void FindPurchaseToPreview()
        {
            _choosePurchaseForm.ShowDialog();
        }

        private void DeleteRow(int rowIndex)
        {
            if (MessageBox.Show("سيتم حذف الصنف من الفاتورة ، تأكيد؟",
                "حذف الصنف",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No) return;

            purchaseDetailsDataGridView.Rows.RemoveAt(rowIndex);
        }

        private void UpdateSupplierBalance()
        {
            if (suppliersComboBox.SelectedIndex == -1) return;

            if (isDisscountCheckBox.Checked == false)
            {
                int supplierId = suppliersComboBox.SelectedValue.ToString().ParseToInt();
                decimal currentBalance = _suppliers.Find(c => c.Id == supplierId).Balance;
                _supplierData.UpdateBalance(supplierId, (currentBalance + _disscount));
            }
        }

        private void ViewPurchaseReport()
        {
            ShowReportForm reportViewerForm = new ShowReportForm();
            reportViewerForm.GetPurshaseId(_purchase.Id);
            reportViewerForm.ShowDialog();
        }

        private void SavePurchaseVoucher(int purchaseId)
        {
            if (suppliersComboBox.SelectedIndex == -1) return;

            if (!isDisscountCheckBox.Checked)
            {
                int supplierId = suppliersComboBox.SelectedValue.ToString().ParseToInt();
                decimal currentBalance = _suppliers.Find(c => c.Id == supplierId).Balance;
                decimal newBalance = currentBalance + disscountTextBox.Text.ParseToDecimal();

                _voucher = new Voucher
                {
                    VoucherType = "R",
                    Amount = disscountTextBox.Text.ParseToDecimal(),
                    PurchaseId = purchaseId,
                    SupplierId = supplierId,
                    Notes = $"المتبقي من الفاتورة رقم {purchaseId}",
                };

                _voucherData.CreatePurchaseVoucher(_voucher);
                _supplierData.UpdateBalance(supplierId, newBalance);
            }
        }

        private bool IsItemAdded(int itemId)
        {
            bool output = false;

            foreach (DataGridViewRow dgvRow in purchaseDetailsDataGridView.Rows)
            {
                if (dgvRow.Cells[0].Value.ToString().ParseToInt() == itemId)
                {
                    output = true;
                    break;
                }
            }

            return output;
        }

        #endregion

        private void PurchasesForm_Load(object sender, EventArgs e)
        {
            UpdateUnpaidFlag(false);
            LoadStores();
            LoadSuppliers();
            LoadNextPurchaseId();
            AddItemToPurchase();
        }

        public void AddItem(Item item)
        {
            if (item == null || isPurchasePreview || IsItemAdded(item.Id)) return;

            int defaultUnitId = UsefulMethods.GetDefaultUnitId();
            string defaultUnitName;
            if (!_unitNameCache.TryGetValue(defaultUnitId, out defaultUnitName))
            {
                defaultUnitName = _unitData.GetUnitById(defaultUnitId).UnitName;
                _unitNameCache[defaultUnitId] = defaultUnitName;
            }

            purchaseDetailsDataGridView.Rows.Add(
                item.Id,
                item.ItemName,
                defaultUnitName,
                1,
                0,
                defaultUnitId);
            UpdateLineTotal(purchaseDetailsDataGridView.Rows[purchaseDetailsDataGridView.Rows.Count - 1]);
        }

        public void PreviewPruchase(Purchase purchase)
        {
            isPurchasePreview = true;

            _purchase.Id = purchase.Id;
            purchaseIdTextBox.Text = purchase.Id.ToString();
            suppliersComboBox.SelectedValue = purchase.SupplierId;
            storesComboBox.SelectedValue = purchase.StoreId;
            totalTextBox.Text = purchase.Total.ToString("#,0");
            disscountTextBox.Text = purchase.Disscount.ToString("#,0");
            notesTextBox.Text = purchase.Notes;
            isDisscountCheckBox.Checked = purchase.IsDisscount;
            paymentTypeCheckBox.Checked = purchase.PaymentType;
            UpdateUnpaidFlag(!purchase.Status);
            purchase.PurchaseDetails = _purchaseDetailData.GetPurchasesDetails(purchase.Id);

            purchaseDetailsDataGridView.Rows.Clear();

            purchase.PurchaseDetails.ForEach(purchaseDetail =>
            {
                purchaseDetailsDataGridView.Rows.Add(purchaseDetail.ItemId, "", "", purchaseDetail.Quantity, purchaseDetail.Price, purchaseDetail.UnitId);
            });
            UpdateAllLineTotals();

            purchaseDetailsDataGridView.ClearSelection();

            EnableDissableEditing(false);
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            AddItemToPurchase();
        }

        public void AddUnit(Unit unit)
        {
            DataGridViewRow currentRow = purchaseDetailsDataGridView.CurrentRow;
            var unitsList = _itemUnitData.GetItemUnits(currentRow.Cells[0].Value.ToString().ParseToInt());

            if (unitsList.Count == 0)
            {
                MessageBox.Show($"الوحدة {unit.UnitName} لا تنتمي لهذا الصـنف", "وحدة الصنف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentRow.Cells[2].Value = unit.UnitName;
            currentRow.Cells[4].Value = 0;
            currentRow.Cells[5].Value = unit.Id;
            UpdateLineTotal(currentRow);
            //currentRow.Cells[4].Value = _itemUnitData.GetItemUnits(itemId)
            //    .Where(itemUnit => itemUnit.UnitId == unit.Id)
            //    .First().UnitPrice;   
        }

        private void purchaseDetailsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 2:
                    ChangeUnit();
                    break;
                case 7:
                    DeleteRow(e.RowIndex);
                    CalculateTotalCost();
                    PreviewTotalCost(_totalCost);
                    break;
            }
        }

        private void purchaseDetailsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_purchase.Id != 0 || e.RowIndex == -1) return;

            //if (e.ColumnIndex == 4 || e.ColumnIndex == 3)
            //{
                UpdateLineTotal(purchaseDetailsDataGridView.Rows[e.RowIndex]);
                CalculateTotalCost();
                PreviewTotalCost(_totalCost);
            //}
        }

        private void disscountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_purchase.Id != 0) return;
            CalculateDisscount();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            CollectData();
            if (IsValidData()) { Save(); ResetForm(); }
        }

        private void purchaseDetailsDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            LoadItemNameAndUnitFromRow(purchaseDetailsDataGridView.Rows[e.RowIndex]);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            FindPurchaseToPreview();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            ViewPurchaseReport();
        }

        private void storesComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _chooseItemForm.Dispose();
            AddItemToPurchase();
        }

    }
}
