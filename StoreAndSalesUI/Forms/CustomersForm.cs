using StoreAndSalesLibrary.DataAccess;
using StoreAndSalesLibrary.Models;
using StoreAndSalesUI.Helpers;
using StoreAndSalesUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace StoreAndSalesUI.Forms
{
    public partial class CustomersForm : Form, IVouchersRequetser
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        #region Private Members

        private CustomerData _customerData = new CustomerData();
        private Customer _customer = new Customer();
        private List<Customer> Customers = new List<Customer>();
        private UserLogData _userLogData = new UserLogData();

        #endregion

        #region Private Methods

        private void LoadCustomers()
        {
            Customers = _customerData.GetAllCustomers();
            customersDataGridView.AutoGenerateColumns = false;
            customersDataGridView.DataSource = Customers;
            ApplyCustomerRowColors();

        }

        private void LoadCustomerData()
        {
            customerNameTextBox.Text = _customer.CustomerName;
            addressTextBox.Text = _customer.Address;
            phoneTextBox.Text = _customer.Phone;
            balanceTextBox.Text = _customer.Balance.ToString("#,0");
            creditLimitTextBox.Text = _customer.CreditLimit.ToString("#,0");

        }

        private void SelectCustomer()
        {
            var currentRow = customersDataGridView.CurrentRow;

            _customer.Id = currentRow.Cells[0].Value.ToString().ParseToInt();
            _customer.CustomerName = currentRow.Cells[1].Value.ToString();
            _customer.Address = currentRow.Cells[2].Value.ToString();
            _customer.Phone = currentRow.Cells[3].Value.ToString();
            _customer.Balance = decimal.Parse(currentRow.Cells[4].Value.ToString());
            _customer.CreditLimit = decimal.Parse(currentRow.Cells[5].Value.ToString());

        }

        private void CollectData()
        {
            _customer.CustomerName = customerNameTextBox.Text;
            _customer.Address = addressTextBox.Text;
            _customer.Phone = phoneTextBox.Text;
            decimal balance;
            _customer.Balance = decimal.TryParse(balanceTextBox.Text, out balance) ? balance : 0;

            decimal creditLimit;
            _customer.CreditLimit = decimal.TryParse(creditLimitTextBox.Text, out creditLimit) ? creditLimit : 0;

        }

        private bool IsValidData()
        {
            bool output = true;

            if (_customer.CustomerName.Length == 0)
            {
                MessageBox.Show("يجب إدخال إسم العمــيل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
                customerNameTextBox.Focus();
            }
            //else if (_supplier.Address.Length == 0)
            // {
            //     output = false;
            // }
            //else  if (_supplier.Phone.Length == 0)
            // {
            //     output = false;
            // }
            else if (_customer.CreditLimit < 0)
            {
                MessageBox.Show("يجب أن يكون حد الدين صفرًا أو قيمة موجبة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
                creditLimitTextBox.Focus();
            }
            else if (_customer.Id == 0 && _customer.Balance == 0)

            {
                MessageBox.Show("يجب إدخال الرصيد الإفتتاحي للعميل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
                balanceTextBox.Focus();
            }
            return output;
        }

        private void Save()
        {
            try
            {
                if (_customer.Id != 0)
                {
                    if (MessageBox.Show("سيتم تعديل البيانات ، هل أنت متأكد؟", "تأكيد التعديل",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                    _customerData.EditCustomer(_customer);
                    _userLogData.AddLog(LoginDataHelper.UserId, $"تم تعديل بانات العميل {_customer.CustomerName}");
                    MessageBox.Show("تم التعديل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _customerData.CreateCustomer(_customer);
                    _userLogData.AddLog(LoginDataHelper.UserId, $"تمت إضافة العميل {_customer.CustomerName}");
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
            _customer = new Customer();
            customerNameTextBox.Clear();
            addressTextBox.Clear();
            phoneTextBox.Clear();
            balanceTextBox.Clear();
            creditLimitTextBox.Clear();
            BalanceFieldStatus();

            searchTextBox.Clear();
        }

        private void ResetForm()
        {
            ClearForm();
            LoadCustomers();
            customerNameTextBox.Focus();
        }

        private void ArchiveCustomer()
        {
            if (_customer.Id == 0) return;
            if (MessageBox.Show("سيتم حــذف البيانات ، هل أنت متأكد؟", "تأكيد الحــذف",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            try
            {
                _customerData.ArchiveCustomer(_customer.Id);
                _userLogData.AddLog(LoginDataHelper.UserId, $"تم حـــذف العميل {_customer.CustomerName}");
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
            balanceTextBox.Enabled = _customer.Id == 0 ? true : false;
            creditLimitTextBox.Enabled = true;
            payDebtButton.Enabled = _customer.Id == 0 ? false : true;

        }

        private void Search(string searchText)
        {
            var filter = Customers.Where(cus => cus.CustomerName.Contains(searchText)).ToList();
            customersDataGridView.AutoGenerateColumns = false;
            customersDataGridView.DataSource = filter;
            ApplyCustomerRowColors();
        }

        private void ApplyCustomerRowColors()
        {
            foreach (DataGridViewRow row in customersDataGridView.Rows)
            {
                ApplyCustomerRowColor(row);
            }
        }

        private void ApplyCustomerRowColor(DataGridViewRow row)
        {
            if (row == null || row.IsNewRow) return;

            Customer customer = row.DataBoundItem as Customer;
            bool isOverCreditLimit = customer != null
                && customer.CreditLimit > 0
                && customer.Balance > customer.CreditLimit;

            if (isOverCreditLimit)
            {
                row.DefaultCellStyle.BackColor = Color.MistyRose;
                row.DefaultCellStyle.ForeColor = Color.DarkRed;
                row.DefaultCellStyle.SelectionBackColor = Color.IndianRed;
                row.DefaultCellStyle.SelectionForeColor = Color.White;
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 31, 55, 82);
                row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 0, 150, 136);
                row.DefaultCellStyle.SelectionForeColor = Color.White;
            }
        }

        private void customersDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ApplyCustomerRowColor(customersDataGridView.Rows[e.RowIndex]);
            }
        }

        #endregion


        private void CustomersForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void customersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectCustomer();
            LoadCustomerData();
            BalanceFieldStatus();
        }

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
            ArchiveCustomer();
        }

        private void balanceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            UsefulMethods.AcceptJustNumbers(e, balanceTextBox);
        }

        private void creditLimitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            UsefulMethods.AcceptJustNumbers(e, creditLimitTextBox);
        }

        private void payDebtButton_Click(object sender, EventArgs e)
        {
            new VouchersForm(this).ShowDialog();
        }

        public void UpdatePersonBalance(int personId, decimal balance)
        {
            Customers.Find(c => c.Id == personId).Balance = balance;
            customersDataGridView.Refresh();
            ApplyCustomerRowColors();

            if (_customer.Id == personId)
            {
                _customer.Balance = balance;
                LoadCustomerData();
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search(searchTextBox.Text);
        }
    }
}
