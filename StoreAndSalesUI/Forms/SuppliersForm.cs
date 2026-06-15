using StoreAndSalesLibrary.DataAccess;
using StoreAndSalesLibrary.Models;
using StoreAndSalesUI.Helpers;
using StoreAndSalesUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace StoreAndSalesUI.Forms
{
    public partial class SuppliersForm : Form , IVouchersRequetser
    {
        public SuppliersForm()
        {
            InitializeComponent();
        }

        #region Private Members

        private SupplierData _supplierData = new SupplierData();
        private Supplier _supplier = new Supplier();
        private List<Supplier> Suppliers = new List<Supplier>();
        private UserLogData _userLogData = new UserLogData();

        #endregion

        #region Private Methods

        private void LoadSuppliers()
        {
            Suppliers = _supplierData.GetAllSuppliers();
            suppliersDataGridView.AutoGenerateColumns = false;
            suppliersDataGridView.DataSource = Suppliers;
        }

        private void LoadSupplierData()
        {
            supplierNameTextBox.Text = _supplier.SupplierName;
            addressTextBox.Text = _supplier.Address;
            phoneTextBox.Text = _supplier.Phone;
            balanceTextBox.Text = _supplier.Balance.ToString("#,0");
        }

        private void SelectSupplier()
        {
            var currentRow = suppliersDataGridView.CurrentRow;
           
            _supplier.Id = currentRow.Cells[0].Value.ToString().ParseToInt();
            _supplier.SupplierName = currentRow.Cells[1].Value.ToString();
            _supplier.Address = currentRow.Cells[2].Value.ToString();
            _supplier.Phone  =  currentRow.Cells[3].Value.ToString();
            _supplier.Balance = decimal.Parse(currentRow.Cells[4].Value.ToString());
            BalanceFieldStatus();
        }

        private void CollectData()
        {
            _supplier.SupplierName = supplierNameTextBox.Text;
            _supplier.Address = addressTextBox.Text;
            _supplier.Phone = phoneTextBox.Text;
            decimal balance;
            _supplier.Balance = decimal.TryParse(balanceTextBox.Text, out balance) ? balance : 0;
        }

        private bool IsValidData()
        {
            bool output = true;

            if (_supplier.SupplierName.Length ==0)
            {
                MessageBox.Show("يجب إدخال إسم المــورد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
                supplierNameTextBox.Focus();
            }
            //else if (_supplier.Address.Length == 0)
            // {
            //     output = false;
            // }
            //else  if (_supplier.Phone.Length == 0)
            // {
            //     output = false;
            // }
            else if (_supplier.Id == 0 && _supplier.Balance == 0)
            {
                MessageBox.Show("يجب إدخال الرصيد الإفتتاحي للمورد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
                balanceTextBox.Focus();
            }

            return output;
        }

        private void Save()
        {
            try
            {
                if (_supplier.Id !=0)
                {
                    if (MessageBox.Show("سيتم تعديل البيانات ، هل أنت متأكد؟", "تأكيد التعديل",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                    _supplierData.EditSupplier(_supplier);
                    _userLogData.AddLog(LoginDataHelper.UserId, $"تم تعديل المورد {_supplier.SupplierName}");

                    MessageBox.Show("تم التعديل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _supplierData.CreateSupplier(_supplier);
                    _userLogData.AddLog(LoginDataHelper.UserId, $"تمت إضافة المورد {_supplier.SupplierName}");

                    MessageBox.Show("تمت الإضافة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsefulMethods.LogException(ex);
            }
        }

        private void ClearForm()
        {
            _supplier = new Supplier(); 
            supplierNameTextBox.Clear();
            addressTextBox.Clear();
            phoneTextBox.Clear();
            balanceTextBox.Clear();
            BalanceFieldStatus();
            searchTextBox.Clear(); 
        }

        private void ResetForm()
        {
            ClearForm();
            LoadSuppliers();
            supplierNameTextBox.Focus(); 
        }

        private void ArchiveSupplier()
        {
            if (_supplier.Id == 0) return;
            if (MessageBox.Show("سيتم حــذف البيانات ، هل أنت متأكد؟", "تأكيد الحــذف",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            try
            {
                _supplierData.ArchiveSupplier(_supplier.Id);
                _userLogData.AddLog(LoginDataHelper.UserId, $"تم حـــذف المورد {_supplier.SupplierName}");
                MessageBox.Show("تم الحذف بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsefulMethods.LogException(ex);
            }
        }

        private void BalanceFieldStatus()
        {
            balanceTextBox.Enabled = _supplier.Id == 0 ? true : false;
            payDebtButton.Enabled = _supplier.Id == 0 ? false  : true;
        }

        private void Search(string searchText)
        {
            var filter = Suppliers.Where(sup => sup.SupplierName.Contains(searchText)).ToList();
            suppliersDataGridView.AutoGenerateColumns = false;
            suppliersDataGridView.DataSource = filter;
        }

        #endregion

        private void newButton_Click(object sender, EventArgs e)
        {
            ResetForm(); 
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            CollectData();
            if (IsValidData()) Save();
            ResetForm(); 
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ArchiveSupplier();
            ResetForm(); 
        }

        private void suppliersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectSupplier();
            LoadSupplierData();
            BalanceFieldStatus();
        }

        private void SuppliersForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers(); 
        }

        private void balanceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            UsefulMethods.AcceptJustNumbers(e, balanceTextBox);
        }

        public void UpdatePersonBalance(int personId, decimal balance)
        {
            Suppliers.Find(x => x.Id == personId).Balance = balance;
            suppliersDataGridView.Refresh();
            if (_supplier.Id == personId) 
            {
                _supplier.Balance = balance;
                LoadSupplierData();
            }   
        }

        private void payDebtButton_Click(object sender, EventArgs e)
        {
            new VouchersForm(this).ShowDialog();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search(searchTextBox.Text);
        }
    }
}
