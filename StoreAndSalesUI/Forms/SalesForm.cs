using StoreAndSalesLibrary.DataAccess;
using StoreAndSalesLibrary.Models;
using StoreAndSalesUI.Helpers;
using StoreAndSalesUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StoreAndSalesUI.Forms
{
    public partial class SalesForm : Form, IItemRequester, IUnitRequester,ISaleRequester
    {
        public SalesForm()
        {
            InitializeComponent();
            _chooseSaleForm = new ChooseSaleForm(this);
        }


        #region Private Members

        private CustomerData _customerData = new CustomerData();
        private List<Customer> _customers = new List<Customer>();
        private SaleData _saleData = new SaleData(UsefulMethods.ConnectionStringName());
        private Sale _sale = new Sale();
        private SaleDetailData _saleDetailData = new SaleDetailData();
        private UnitData _unitData = new UnitData();
        private ItemUnitData _itemUnitData = new ItemUnitData();
        private ItemData _itemData = new ItemData();
        private decimal _totalCost = 0;
        private decimal _disscount = 0;
        private bool isEdit = false;
        private bool isSalePreview = false;
        private VoucherData _voucherData = new VoucherData();
        private Voucher _voucher = new Voucher();
        private ChooseSaleForm _chooseSaleForm;

        #endregion

        #region Private Methods

        private void LoadCustomers()
        {
            _customers = _customerData.GetAllCustomers();
            customersComboBox.DataSource = _customers;
            customersComboBox.ValueMember = "Id";
            customersComboBox.DisplayMember = "CustomerName";
            customersComboBox.SelectedIndex = -1;
        }

        private void CollectData()
        {
            _sale.CustomerId = (customersComboBox.SelectedValue == null) ? 0 : customersComboBox.SelectedValue.ToString().ParseToInt();
            _sale.Total = (_disscount == 0 ? _totalCost : _totalCost - _disscount); //totalTextBox.Text.ParseToDecimal();
            _sale.Disscount = _disscount;
            _sale.Notes = notesTextBox.Text;
            _sale.PaymentType = paymentTypeCheckBox.Checked;
            _sale.IsDisscount = isDisscountCheckBox.Checked;
            _sale.Status = false;

            CollectSaleDetails();
        }

        private void CollectSaleDetails()
        {
            _sale.SaleDetails.Clear();

            foreach (DataGridViewRow row in saleDetailsDataGridView.Rows)
            {
                _sale.SaleDetails.Add(new SaleDetail
                {
                    ItemId = row.Cells[0].Value.ToString().ParseToInt(),
                    Quantity = row.Cells[3].Value.ToString().ParseToInt(),
                    Price = row.Cells[4].Value.ToString().ParseToDecimal(),
                    UnitId = row.Cells[5].Value.ToString().ParseToInt()
                });
            }
        }

        private void AddItemToSale()
        {
            new ChooseItemForm(this).ShowDialog();
        }

        private void ChangeUnit()
        {
            if (_sale.Id != 0) return;
            new ChooseUnitForm(this).ShowDialog();
        }

        private void CalculateTotalCost()
        {
            _totalCost = 0;

            foreach (DataGridViewRow row in saleDetailsDataGridView.Rows)
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
            if (_totalCost == 0) return;
            PreviewTotalCost(totalAfterDisscount);
        }

        private void LoadNextSaleId()
        {
            if (isSalePreview) return;
            saleIdTextBox.Text = (_saleData.GetLastSaleId() + 1).ToString();
        }

        private void ClearForm()
        {
            saleDetailsDataGridView.Rows.Clear();
            customersComboBox.SelectedIndex = -1;
            notesTextBox.Clear();
            isDisscountCheckBox .Checked = false;
            paymentTypeCheckBox.Checked = false;
        }

        private void ResetForm()
        {
            ClearForm();
            LoadNextSaleId();
            _totalCost = 0;
            _sale = new Sale();
            PreviewTotalCost(0);
            disscountTextBox.Text = "0";
            EnableDissableEditing(true);
            isSalePreview = false;
        }

        private bool IsValidQuantity()
        {
            bool output = true;

            foreach (DataGridViewRow row in saleDetailsDataGridView.Rows)
            {
                if (row.Cells[3].Value.Equals("0") || row.Cells[3].Value.ToString().Trim().Equals(""))
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

            if (_sale.CustomerId == 0)
            {
                MessageBox.Show("يجب إختيار العمــيل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
            }
            else if (_sale.SaleDetails.Count == 0)
            {
                MessageBox.Show("يجب إضافة صنف واحد على الأقل في الفاتورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
            }
            else if (IsValidQuantity() == false)
            {
                MessageBox.Show("يجب إدخال جميع الكميات  بصورة صحيحة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
            }

            return output;
        }

        private void Save()
        {
            try
            {
                _saleData.CreateSale(_sale);
                SaveSaleVoucher(_sale.Id);
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
            saleDetailsDataGridView.ReadOnly  = !isEnabled;
            saleDetailsDataGridView.Columns[6].Visible = isEnabled;
            disscountTextBox.Enabled = isEnabled;
            customersComboBox.Enabled = isEnabled;
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

        private void FindSaleToPreview()
        {
            _chooseSaleForm.ShowDialog();
        }

        private bool isQuantityAvailable(int itemId, int unitId, int quantityToTake)
        {
            bool output = true;
            
            int itemQuantity = _itemData.GetItemQuantity(itemId,unitId);

            if (quantityToTake > itemQuantity) 
            {
                output = false;
            }
                
            return output;
        }

        private bool IsItemAdded(int itemId)
        {
            bool output = false;

            foreach (DataGridViewRow dgvRow in saleDetailsDataGridView.Rows)
            {
                if (dgvRow.Cells[0].Value.ToString().ParseToInt() == itemId)
                {
                    output = true;
                    break;
                }
            }

            return output;
        }

        private void DeleteRow(int rowIndex)
        {
            if (MessageBox.Show("سيتم حذف الصنف من الفاتورة ، تأكيد؟",
                "حذف الصنف", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2) == DialogResult.No) return;

            saleDetailsDataGridView.Rows.RemoveAt(rowIndex);
        }

        private void UpdateCustomerBalance() 
        {
            if (customersComboBox.SelectedIndex == -1) return;

            if (isDisscountCheckBox.Checked == false)
            {
                int customerId = customersComboBox.SelectedValue.ToString().ParseToInt();
                decimal currentBalance = _customers.Find(c => c.Id == customerId).Balance; 
                _customerData.UpdateBalance(customerId,(currentBalance + _disscount)); 
            }
        }


        private void ViewSaleReport()
        {
            ShowReportForm reportViewerForm = new ShowReportForm();
            reportViewerForm.GetSaleId(_sale.Id);
            reportViewerForm.ShowDialog();
        }

        private void SaveSaleVoucher(int saleId)
        {
            if (customersComboBox.SelectedIndex == -1) return;

            if (!isDisscountCheckBox.Checked)
            {
                int customerId = customersComboBox.SelectedValue.ToString().ParseToInt();
                decimal currentBalance = _customers.Find(c => c.Id == customerId).Balance;
                decimal newBalance = currentBalance + disscountTextBox.Text.ParseToDecimal();

                _voucher = new Voucher
                {
                    VoucherType = "R",
                    Amount = disscountTextBox.Text.ParseToDecimal(),
                    SaleId  = saleId,
                    CustomerId = customerId,
                    Notes = $"المتبقي من الفاتورة رقم {saleId}",
                };

                _voucherData.CreateSaleVoucher(_voucher);
                _customerData.UpdateBalance(customerId, newBalance);
            }
        }

        #endregion

        public void AddItem(Item item)
        {
            if (IsItemAdded(item.Id)) return;
            //Get Default Unit Name
            ItemUnit itemUnit = _itemUnitData.GetItemUnits(item.Id).First();
            decimal defaultUnitPrice = itemUnit.UnitPrice;
            string defaultUnitName = _unitData.GetUnitById(UsefulMethods.GetDefaultUnitId()).UnitName;
            
            // Get Default Unit Price
           int rowIndex = saleDetailsDataGridView.Rows.Add
                (
                item.Id,
                item.ItemName,
                defaultUnitName,
                1,
                defaultUnitPrice,
                UsefulMethods.GetDefaultUnitId());

            string unitName = saleDetailsDataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            if (!isQuantityAvailable(item.Id, itemUnit.UnitId,1))
            {
                MessageBox.Show($"لا تتوفر كمية كافية من الوحدة {unitName} قم بتغيير الوحدة!!!", "الكمية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<ItemUnit> itemUnits = _itemUnitData.GetItemUnits(item.Id).Where(_itemUnit => _itemUnit.UnitId == UsefulMethods.GetDefaultUnitId()).ToList();

            if (itemUnits.Count == 0)
            {
                MessageBox.Show($"الوحدة {defaultUnitName} لا تنتمي لهذا الصـنف", "وحدة الصنف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        public void AddUnit(Unit unit)
        {
            DataGridViewRow currentRow = saleDetailsDataGridView.CurrentRow;
            int itemId = currentRow.Cells[0].Value.ToString().ParseToInt();
            List<ItemUnit> itemUnits = _itemUnitData.GetItemUnits(itemId).Where(itemUnit => itemUnit.UnitId == unit.Id).ToList();
           
            if (itemUnits.Count == 0) 
            {
                MessageBox.Show($"الوحدة {unit.UnitName} لا تنتمي لهذا الصـنف","وحدة الصنف",MessageBoxButtons.OK ,MessageBoxIcon.Warning); 
                return;
            }
            if (!isQuantityAvailable(itemId,unit.Id,1))
            {
                MessageBox.Show($"لا تتوفر كمية كافية من الوحدة {unit.UnitName} قم بتغيير الوحدة!!!", "الكمية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            currentRow.Cells[2].Value = unit.UnitName;
            currentRow.Cells[5].Value = unit.Id;
            currentRow.Cells[4].Value = itemUnits.First().UnitPrice;
        }

        public void PreviewSale(Sale sale)
        {
            isSalePreview = true;

            _sale.Id = sale.Id;
            saleIdTextBox.Text = sale.Id.ToString();
            customersComboBox.SelectedValue = sale.CustomerId;
            totalTextBox.Text = sale.Total.ToString("#,0");
            disscountTextBox.Text = sale.Disscount.ToString("#,0");
            notesTextBox.Text = sale.Notes;
            isDisscountCheckBox.Checked = sale.IsDisscount;
            paymentTypeCheckBox.Checked = sale.PaymentType;
            sale.SaleDetails = _saleDetailData.GetSaleDetails(sale.Id);

            saleDetailsDataGridView.Rows.Clear();

            sale.SaleDetails.ForEach(saleDetail =>
            {
                saleDetailsDataGridView.Rows.Add(saleDetail.ItemId, "", "", saleDetail.Quantity, saleDetail.Price, saleDetail.UnitId);
            });

            saleDetailsDataGridView.ClearSelection(); 

            EnableDissableEditing(false);
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            AddItemToSale(); 
        }

        private void saleDetailsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void saleDetailsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (saleDetailsDataGridView.Rows.Count == 0) return;
            string unitName = saleDetailsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            int itemId = saleDetailsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString().ParseToInt();
            int unitId = saleDetailsDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString().ParseToInt();
            int quantity = saleDetailsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString().ParseToInt();

            if (e.ColumnIndex == 4 || e.ColumnIndex == 3)
            {
                if (_sale.Id == 0)
                {
                    isEdit = true;
                    if (!isQuantityAvailable(itemId,unitId, quantity))
                    {
                        MessageBox.Show($"لا تتوفر كمية كافية من الوحدة {unitName} قم بتغيير الوحدة!!!", "الكمية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    isEdit = false;
                }
                CalculateTotalCost();
                PreviewTotalCost(_totalCost);
            }
        }

        private void disscountTextBox_TextChanged(object sender, EventArgs e)
        {
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

        private void saleDetailsDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            LoadItemNameAndUnitFromRow(saleDetailsDataGridView.Rows[e.RowIndex]);
            
            if (_sale.Id != 0) return;
           
            CalculateTotalCost();
            PreviewTotalCost(_totalCost); 
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            FindSaleToPreview();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadNextSaleId();
        }

        private void saleDetailsDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //if (!isQuantityAvailable(saleDetailsDataGridView.Rows[e.RowIndex]))
            //{
            //    saleDetailsDataGridView.Rows.Remove(saleDetailsDataGridView.Rows[e.RowIndex]);
            //    return;
            //}
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            ViewSaleReport();
        }
    }
}
