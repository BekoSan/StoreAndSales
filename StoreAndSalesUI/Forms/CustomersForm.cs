using StoreAndSalesLibrary.DataAccess;
using StoreAndSalesLibrary.Models;
using StoreAndSalesUI.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StoreAndSalesUI.Forms
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        #region Private Members

        private CustomerData _customerData = new CustomerData();
        private Customer _customer = new Customer();
        private List<Customer> Customers = new List<Customer>();

        #endregion

        #region Private Methods

        private void LoadCustomers()
        {
            Customers = _customerData.GetAllCustomers();
            customersDataGridView.AutoGenerateColumns = false;
            customersDataGridView.DataSource = Customers;
        }

        private void LoadCustomerData()
        {
            customerNameTextBox.Text = _customer.CustomerName;
            addressTextBox.Text = _customer.Address;
            phoneTextBox.Text = _customer.Phone;
        }

        private void SelectCustomer()
        {
            var currentRow = customersDataGridView.CurrentRow;

            _customer.Id = currentRow.Cells[0].Value.ToString().ParseToInt();
            _customer.CustomerName = currentRow.Cells[1].Value.ToString();
            _customer.Address = currentRow.Cells[2].Value.ToString();
            _customer.Phone = currentRow.Cells[3].Value.ToString();
        }

        private void CollectData()
        {
            _customer.CustomerName = customerNameTextBox.Text;
            _customer.Address = addressTextBox.Text;
            _customer.Phone = phoneTextBox.Text;
            decimal balance;
            _customer.Balance = decimal.TryParse(balanceTextBox.Text, out balance) ? balance : 0;
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
                    MessageBox.Show("تم التعديل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _customerData.CreateCustomer(_customer);
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
                MessageBox.Show("تم الحذف بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsefulMethods.LogException(ex);
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
    }
}
