using StoreAndSalesLibrary.DataAccess;
using StoreAndSalesLibrary.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StoreAndSalesUI.Forms
{
    public partial class VouchersForm : Form
    {
        public VouchersForm()
        {
            InitializeComponent();
            GetFormData();
            LoadFormData();
        }

        #region Private Members

        private readonly CustomerData  _customerData= new CustomerData();
        private List<Customer> _customers = new List<Customer>();

        #endregion

        #region Private Methods

        private void GetCustomers()
        {
            _customers = _customerData.GetAllCustomers(); 
        }

        private void LoadCustomers() 
        {
            peopleComboBox.DataSource = _customers;
            peopleComboBox.ValueMember = "Id";
            peopleComboBox.DisplayMember = "CustomerName";
            peopleComboBox.SelectedIndex = -1;
        }

        private void GetFormData() 
        {
            GetCustomers();
        }

        private void LoadFormData() 
        {
            if (customerVocuherRadioButton.Checked)
            {
                LoadCustomers();
            }
        }

        #endregion

    }
}
