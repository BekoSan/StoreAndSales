using StoreAndSalesLibrary.DataAccess;
using StoreAndSalesLibrary.Models;
using StoreAndSalesUI.Helpers;
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
            LoadCustomerLists();
        }

        #region Private Members

        private readonly CustomerData  _customerData= new CustomerData();
        private List<Customer> _customers = new List<Customer>();
        private readonly SupplierData  _supplierData  = new SupplierData();
        private List<Supplier> _suppliers = new List<Supplier>();
        private SaleData _saleData = new SaleData();    
        private List<Sale> _saleInvoices = new List<Sale>();
        private PurchaseData _purchaseData = new PurchaseData();
        private List<Purchase> _purchaseInvoices = new List<Purchase>();
        private decimal _remainingAmount = 0;
        private VoucherData _voucherData = new VoucherData();
        
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
            _purchaseInvoices = _purchaseData.GetAllPurchases();
        }

        private void LoadCustomerLists()
        {
            LoadListData(peopleComboBox, _customers, "Id", "CustomerName");
            LoadListData(invoicesComboBox, _saleInvoices, "Id", "Id");
        }

        private void LoadSupplierLists()
        {

            LoadListData(peopleComboBox, _suppliers, "Id", "SupplierName");
            LoadListData(invoicesComboBox, _purchaseInvoices, "Id", "Id");
        }

        private void CallculateRemainnigAmount()
        {
            if (customerVocuherRadioButton.Checked)
            {
                int saleInvoiceId;
                int.TryParse(invoicesComboBox.SelectedValue.ToString(),out saleInvoiceId);
                int customerId;
                int.TryParse(peopleComboBox.SelectedValue.ToString(), out customerId);
                decimal totalDisscount = _saleInvoices.Find(sale => sale.Id == saleInvoiceId).Disscount;
                decimal saleVouchersTotal = _voucherData.GetTotalSaleVoucher(saleInvoiceId, customerId, "P");
                _remainingAmount = totalDisscount - saleVouchersTotal;
            }
            else
            {
                int purchaseInvoiceId;
                int.TryParse(invoicesComboBox.SelectedValue.ToString(), out purchaseInvoiceId);
                int supplierId;
                int.TryParse(peopleComboBox.SelectedValue.ToString(), out supplierId);
                decimal totalDisscount = _purchaseInvoices.Find(purchase => purchase.Id == purchaseInvoiceId).Disscount;
                decimal purchaseVouchersTotal = _voucherData.GetTotalPurchaseVoucher(purchaseInvoiceId, supplierId, "P");
                _remainingAmount = totalDisscount - purchaseVouchersTotal;
            }

        }

        private void PreviewRemmainingAmount() 
        {
            remainingTotalTextBox.Text = _remainingAmount.ToString("#,0");
        }

        #endregion

        private void customerVocuherRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            if (customerVocuherRadioButton.Checked)
            {
                LoadCustomerLists();
            }
            else
            {
                LoadSupplierLists(); 
            }
        }

        private void invoicesComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (peopleComboBox.SelectedIndex == -1) return;
            CallculateRemainnigAmount();
            PreviewRemmainingAmount();
        }

        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            UsefulMethods.AcceptJustNumbers(e, amountTextBox); 
        }
    }
}
