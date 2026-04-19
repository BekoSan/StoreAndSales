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
    public partial class VouchersForm : Form
    {
        public VouchersForm()
        {
            InitializeComponent();
            GetFormData();
            LoadCustomerLists();
        }

        public VouchersForm(IVouchersRequetser caller)
        {
            InitializeComponent();
            GetFormData();
            LoadCustomerLists();
            CallingForm = caller;
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
        private decimal _remainAfterPaid = 0;
        private Voucher _voucher = new Voucher();
        private IVouchersRequetser CallingForm;

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
            peopleComboBox.SelectedIndexChanged-= peopleComboBox_SelectedIndexChanged;
            LoadListData(peopleComboBox, _customers, "Id", "CustomerName");
            peopleComboBox.SelectedIndexChanged += peopleComboBox_SelectedIndexChanged;
            invoicesComboBox.SelectedIndexChanged -= invoicesComboBox_SelectedIndexChanged;
            LoadListData(invoicesComboBox, _saleInvoices , "Id", "Id");
            invoicesComboBox.SelectedIndexChanged += invoicesComboBox_SelectedIndexChanged;
        }

        private void LoadSupplierLists()
        {
            peopleComboBox.SelectedIndexChanged -= peopleComboBox_SelectedIndexChanged;
            LoadListData(peopleComboBox, _suppliers, "Id", "SupplierName");
            peopleComboBox.SelectedIndexChanged += peopleComboBox_SelectedIndexChanged;
            invoicesComboBox.SelectedIndexChanged -= invoicesComboBox_SelectedIndexChanged;
            LoadListData(invoicesComboBox, _purchaseInvoices, "Id", "Id");
            invoicesComboBox.SelectedIndexChanged += invoicesComboBox_SelectedIndexChanged;
        }

        private void CallculateRemainnigAmount()
        {
            if (invoicesComboBox.SelectedIndex == -1) return;

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

        private void PreviewRemainingAmount(decimal amount) 
        {
            remainingTotalTextBox.Text = amount.ToString("#,0");
        }

        private void CalculatePaid()
        {
            decimal paid;
            decimal.TryParse(amountTextBox.Text,out paid);
            _remainAfterPaid = _remainingAmount - paid;
        }

        private void LoadPersonInvoices(int personId) 
        {

            if (customerVocuherRadioButton.Checked) 
            {
                List<Sale> customerInvoices = new List<Sale>();
                customerInvoices = _saleInvoices.Where(sale => sale.CustomerId == personId && sale.Status == false).ToList();
                LoadListData(invoicesComboBox, customerInvoices, "Id", "Id");
            }
            else
            {
                List<Purchase> supplierInvoices = new List<Purchase>();
                supplierInvoices = _purchaseInvoices.Where(purchase => purchase.SupplierId == personId && purchase.Status == false).ToList();
                LoadListData(invoicesComboBox, supplierInvoices, "Id", "Id");
            }

        }

        private void LoadNextVoucherId()
        {
            voucherIdTextBox.Text = (_voucherData.GetLastVoucherId() + 1).ToString();
        }

        private void ClearForm() 
        {
            LoadNextVoucherId();
            customerVocuherRadioButton.Checked = true;
            peopleComboBox.SelectedIndex = -1;
            invoicesComboBox.SelectedIndex = -1;
            amountTextBox.Clear();
            remainingTotalTextBox.Clear();
            balanceLabel.Text = string.Empty;
            notesTextBox.Text = string.Empty;
            ShowHideAccountDetailsLabel();
            ShowHideViewInvoiceLabel();
            VoucherTypeComboBox.SelectedIndex = -1;
            remainingTotalTextBox.Clear();
            amountTextBox.Clear(); 
        }

        private void CollectData() 
        {
            if (peopleComboBox.SelectedIndex == -1) return;

            if (customerVocuherRadioButton.Checked)
            {
                _voucher = new Voucher()
                {
                    VoucherType = VoucherTypeComboBox.SelectedIndex  == 0 ? "R" : "P",
                    CustomerId = peopleComboBox.SelectedValue.ToString().ParseToInt(),
                    SaleId = invoicesComboBox.SelectedValue.ToString().ParseToInt(),
                    Amount = amountTextBox.Text.ParseToDecimal(),
                    Notes = notesTextBox.Text
                };
            }
            else
            {
                _voucher = new Voucher()
                {
                    VoucherType = VoucherTypeComboBox.SelectedIndex == 0 ? "R" : "P",
                    SupplierId = peopleComboBox.SelectedValue.ToString().ParseToInt(),
                    PurchaseId = invoicesComboBox.SelectedValue.ToString().ParseToInt(),
                    Amount = amountTextBox.Text.ParseToDecimal(),
                    Notes = notesTextBox.Text
                };
            }
        }

        private bool IsValidData()
        {
            bool output = true;

            if (peopleComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("يجب إختيار شخص من القائمة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
                peopleComboBox.Focus();
            }
            else if (amountTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("يجب إدخال المبلغ المدفوع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
                peopleComboBox.Focus();
            }
            else if (VoucherTypeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("يجب إختيار نوع السنــد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
                VoucherTypeComboBox.Focus();
            }
            else if (invoicesComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("يجب إختيار الفاتورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
                invoicesComboBox.Focus();
            }
            else if (remainingTotalTextBox.Text.ParseToDecimal() < 0)
            {
                MessageBox.Show("المبلغ الذي تم إدخاله أكبر من إجمالي المتبقي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
                amountTextBox.Focus();
            }
            return output;
        }

        private void Save() 
        {
            try
            {
                decimal newBalance;
                decimal amount = amountTextBox.Text.ParseToDecimal();
                decimal newInvoiceDisscount = remainingTotalTextBox.Text.ParseToDecimal();
                int invoiceId = invoicesComboBox.SelectedValue.ToString().ParseToInt();

                if (customerVocuherRadioButton.Checked)
                {
                    int customerId = peopleComboBox.SelectedValue.ToString().ParseToInt();
                    decimal currentBalance = _customers.Find(c => c.Id == customerId).Balance;

                    if (_voucher.VoucherType.Equals("R"))
                        newBalance = currentBalance - amount;
                    else
                        newBalance = currentBalance + amount;

                    _customerData.UpdateBalance(customerId, newBalance);
                    _saleData.EditSaleDisscount(invoiceId, newInvoiceDisscount);
                    _voucherData.CreateSaleVoucher(_voucher);
                    UpdateInvoiceStauts();
                    _customers.Find(c => c.Id == customerId).Balance = newBalance;
                    if (CallingForm != null && CallingForm.GetType().ToString().Contains("Customer")) CallingForm.UpdatePersonBalance(customerId, newBalance);
                }
                else
                {
                    int supplierId = peopleComboBox.SelectedValue.ToString().ParseToInt();
                    decimal currentBalance = _suppliers.Find(c => c.Id == supplierId).Balance;
                        
                    
                    if (_voucher.VoucherType.Equals("R"))
                        newBalance = currentBalance + amount;
                    else
                        newBalance = currentBalance - amount;

                    _supplierData.UpdateBalance(supplierId, newBalance);
                    _purchaseData.EditPurchaseDisscount(invoiceId, newInvoiceDisscount); 
                    _voucherData.CreatePurchaseVoucher(_voucher);
                    UpdateInvoiceStauts();
                    _suppliers.Find(c => c.Id == supplierId).Balance = newBalance;
                    if (CallingForm != null && CallingForm.GetType().ToString().Contains("Supplier")) CallingForm.UpdatePersonBalance(supplierId, newBalance);

                }

                MessageBox.Show("تم تحديث الرصيد بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsefulMethods.LogException(ex);
            }
        }

        private void ShowBalance()
        {
            if (peopleComboBox.SelectedIndex == -1) return;

            if (customerVocuherRadioButton.Checked)
            {
                int customerId = peopleComboBox.SelectedValue.ToString().ParseToInt();
                balanceLabel.Text = _customers.Find(customer => customer.Id == customerId).Balance.ToString("#,0");
            }
            else
            {
                int supplierId = peopleComboBox.SelectedValue.ToString().ParseToInt();
                balanceLabel.Text = _suppliers.Find(supplier => supplier.Id == supplierId).Balance.ToString("#,0");
            }
        }

        private void ViewPersonAccountDetailsReport()
        {
            ShowReportForm reportViewerForm = new ShowReportForm();
            if (!customerVocuherRadioButton.Checked)
            {
                reportViewerForm.GetSupplierId(peopleComboBox.SelectedValue.ToString().ParseToInt());
            }
            else
            {
                reportViewerForm.GetCustomerId(peopleComboBox.SelectedValue.ToString().ParseToInt());
            }
            reportViewerForm.ShowDialog();
        }

        private void ViewInvoice()
        {
            ShowReportForm reportViewerForm = new ShowReportForm();
            if (!customerVocuherRadioButton.Checked)
            {
                reportViewerForm.GetPurshaseId(invoicesComboBox.SelectedValue.ToString().ParseToInt());
            }
            else
            {
                reportViewerForm.GetSaleId(invoicesComboBox.SelectedValue.ToString().ParseToInt());
            }
            reportViewerForm.ShowDialog();
        }


        private void ShowHideAccountDetailsLabel() 
        {
            if (peopleComboBox.SelectedValue != null)
                AccountDetailsLinkLabel.Visible = true;
            else
                AccountDetailsLinkLabel.Visible = false;
        }

        private void ShowHideViewInvoiceLabel()
        {
            if (invoicesComboBox.SelectedValue != null)
                viewInvoiceLinkLabel.Visible = true;
            else
                viewInvoiceLinkLabel.Visible = false;
        }

        private void UpdateInvoiceStauts()
        {
            int invoiceId = invoicesComboBox.SelectedValue.ToString().ParseToInt();
            bool status = remainingTotalTextBox.Text.ParseToDecimal() == 0 ? true : false;
            if (customerVocuherRadioButton.Checked) 
            {
                _saleData.EditSaleStatus(invoiceId, status);
            }
            else
            {
                _purchaseData.EditPurchaseStatus(invoiceId, status); 
            }
        }

        private void ResetAmountAndRemaining() 
        {
            amountTextBox.Clear();
            remainingTotalTextBox.Clear();
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
            balanceLabel.Text = string.Empty;
            remainingTotalTextBox.Text = string.Empty;
            VoucherTypeComboBox.SelectedIndex = -1;
            ShowHideAccountDetailsLabel();
            ShowHideViewInvoiceLabel();
        }

        private void invoicesComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (peopleComboBox.SelectedIndex == -1) return;
            CallculateRemainnigAmount();
            ResetAmountAndRemaining();
            PreviewRemainingAmount(_remainingAmount);
            ShowHideViewInvoiceLabel();
        }

        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            UsefulMethods.AcceptJustNumbers(e, amountTextBox); 
        }

        private void amountTextBox_TextChanged(object sender, System.EventArgs e)
        {
            CalculatePaid();
            PreviewRemainingAmount(_remainAfterPaid);
        }

        private void peopleComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (peopleComboBox.SelectedIndex == -1) return;
            invoicesComboBox.SelectedIndexChanged -= invoicesComboBox_SelectedIndexChanged;
            int personId = peopleComboBox.SelectedValue.ToString().ParseToInt();
            LoadPersonInvoices(personId);
            ShowBalance();
            ShowHideAccountDetailsLabel();
            invoicesComboBox.SelectedIndexChanged += invoicesComboBox_SelectedIndexChanged;
            ShowHideViewInvoiceLabel();
            ResetAmountAndRemaining();
        }

        private void VouchersForm_Load(object sender, System.EventArgs e)
        {
            LoadNextVoucherId();
        }

        private void newButton_Click(object sender, System.EventArgs e)
        {
            ClearForm();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                CollectData();
                Save();
                ClearForm();
                GetFormData();
            }
        }

        private void AccountDetailsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewPersonAccountDetailsReport();
        }

        private void viewInvoiceLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewInvoice();
        }

    }
}
