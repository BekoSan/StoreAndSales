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
        }

        #region Private Members

        private SupplierData _supplierData = new SupplierData();
        private List<Supplier> _suppliers = new List<Supplier>();
        private PurchaseData _purchaseData = new PurchaseData(UsefulMethods.ConnectionStringName());
        private Purchase _purchase = new Purchase();
        private PurchaseDetailData _purchaseDetailData = new PurchaseDetailData();
        private ItemUnitData _itemUnitData = new ItemUnitData();
        private UnitData _unitData = new UnitData();
        private ItemData _itemData = new ItemData();
        private decimal _totalCost = 0;
        private decimal _disscount = 0;
        private VoucherData _voucherData =  new VoucherData();
        private Voucher  _voucher = new Voucher();
        private bool isPurchasePreview = false;

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

        private void CollectData()
        {
            _purchase.SupplierId = (suppliersComboBox.SelectedValue == null) ? 0 : suppliersComboBox.SelectedValue.ToString().ParseToInt();
            _purchase.Total = totalTextBox.Text.ParseToDecimal();
            _purchase.Disscount = disscountTextBox.Text.ParseToDecimal();
            _purchase.Notes = notesTextBox.Text;
            _purchase.PaymentType = paymentTypeCheckBox.Checked;
            _purchase.IsDisscount = isDisscountCheckBox.Checked;
            _purchase.Status = isDisscountCheckBox.Checked ? true : false;

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
            new ChooseItemForm(this).ShowDialog();
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

        private void PreviewTotalCost(decimal totalCost)
        {
            totalTextBox.Text = totalCost.ToString("#,0");
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
                _purchaseData.CreatePurchase(_purchase);
                SavePurchaseVoucher(_purchase.Id); 
                MessageBox.Show("تمت الإضافة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            purchaseDetailsDataGridView.Columns[6].Visible = isEnabled;
            disscountTextBox.Enabled = isEnabled;
            suppliersComboBox.Enabled = isEnabled;
            notesTextBox.Enabled = isEnabled;
            isDisscountCheckBox.Enabled = isEnabled;
            paymentTypeCheckBox.Enabled = isEnabled;
            printButton.Enabled = !isEnabled;
        }

        private void LoadItemNameAndUnitFromRow(DataGridViewRow dgvRow)
        {
            int itemId = dgvRow.Cells[0].Value.ToString().ParseToInt();
            int unitId = dgvRow.Cells[5].Value.ToString().ParseToInt();

            string unitName = _unitData.GetUnitById(unitId).UnitName;
            string itemName = _itemData.GetItem(itemId).ItemName;

            dgvRow.Cells[1].Value = itemName;
            dgvRow.Cells[2].Value = unitName;
        }

        private void FindPurchaseToPreview()
        {
            new ChoosePurchaseForm(this).ShowDialog();
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
                    Notes= $"المتبقي من الفاتورة رقم { purchaseId }",
                };
                
                _voucherData.CreatePurchaseVoucher(_voucher);
                _supplierData.UpdateBalance(supplierId, newBalance);
            }
        }

        #endregion

        private void PurchasesForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            LoadNextPurchaseId();
        }

        public void AddItem(Item item)
        {
            //Get Default Unit Name            

            //decimal defaultUnitPrice = itemUnit.UnitPrice;
            string defaultUnitName = _unitData.GetUnitById(UsefulMethods.GetDefaultUnitId()).UnitName;
            // Get Default Unit Price
            purchaseDetailsDataGridView.Rows.Add
                (
                item.Id,
                item.ItemName,
                defaultUnitName,
                1,
                0,
                UsefulMethods.GetDefaultUnitId()
                );
        }

        public void PreviewPruchase(Purchase purchase)
        {
            isPurchasePreview = true;

            _purchase.Id = purchase.Id;
            purchaseIdTextBox.Text = purchase.Id.ToString();
            suppliersComboBox.SelectedValue = purchase.SupplierId;
            totalTextBox.Text = purchase.Total.ToString("#,0");
            disscountTextBox.Text = purchase.Disscount.ToString("#,0");
            notesTextBox.Text = purchase.Notes;
            isDisscountCheckBox.Checked = purchase.IsDisscount;
            paymentTypeCheckBox.Checked = purchase.PaymentType;
            purchase.PurchaseDetails = _purchaseDetailData.GetPurchasesDetails(purchase.Id);

            purchaseDetailsDataGridView.Rows.Clear();

            purchase.PurchaseDetails.ForEach(purchaseDetail =>
            {
                purchaseDetailsDataGridView.Rows.Add(purchaseDetail.ItemId, "", "", purchaseDetail.Quantity, purchaseDetail.Price, purchaseDetail.UnitId);
            });

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
                case 6:
                    DeleteRow(e.RowIndex);
                    CalculateTotalCost();
                    PreviewTotalCost(_totalCost); 
                    break;
            }
        }

        private void purchaseDetailsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_purchase.Id != 0) return;

            if (e.ColumnIndex == 4 || e.ColumnIndex == 3)
            {
                CalculateTotalCost();
                PreviewTotalCost(_totalCost);
            }
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
            if (IsValidData()){ Save(); ResetForm();}
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
    }
}
