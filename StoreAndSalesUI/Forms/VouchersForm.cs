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
            LoadListData(peopleComboBox, _customers, "Id", "CustomerName");
        }

        #region Private Members

        private readonly CustomerData  _customerData= new CustomerData();
        private List<Customer> _customers = new List<Customer>();
        private readonly SupplierData  _supplierData  = new SupplierData();
        private List<Supplier> _suppliers = new List<Supplier>();
        private SaleData _saleData = new SaleData();    
        private List<Sale> _saleInvoices = new List<Sale>();

        #endregion

        #region Private Methods


        private void LoadListData<T>(ComboBox comboBox,List<T>  list,string valueMember,string displayMember) 
        {
            comboBox.DataSource = null;
            comboBox.Items.Clear();
            comboBox.DataSource = list;
            comboBox.ValueMember = valueMember;
            comboBox.DisplayMember = displayMember;
            comboBox.SelectedIndex = -1;
        }

        private void GetFormData() 
        {
            _customers = _customerData.GetAllCustomers();
            _suppliers = _supplierData.GetAllSuppliers();
            _saleInvoices = _saleData.GetAllSales(); 
        }

        #endregion

        private void customerVocuherRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            if (customerVocuherRadioButton.Checked)
            {
                LoadListData(peopleComboBox,_customers, "Id", "CustomerName");
                LoadListData(invoicesComboBox, _saleInvoices, "Id", "Id");
            }
            else
            {
                LoadListData(peopleComboBox, _suppliers, "Id", "SupplierName");
            }
        }
    }
}
