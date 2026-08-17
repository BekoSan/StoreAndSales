using StoreAndSalesLibrary.DataAccess;
using StoreAndSalesUI.Helpers;
using StoreAndSalesUI.Interfaces;
using StoreAndSalesUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreAndSalesUI.Forms
{
    public partial class ChoosePurchaseForm : Form
    {
        public ChoosePurchaseForm()
        {
            InitializeComponent();
        }

        public ChoosePurchaseForm(IPurchaseRequester caller)
        {
            InitializeComponent();
            CallingForm = caller;
        }

        #region Private Members

        private PurchaseData _purchaseData = new PurchaseData();
        private List<PurchaseView> _purchases = new List<PurchaseView>();
        private Dictionary<int, bool> _purchaseStatuses = new Dictionary<int, bool>();
        private IPurchaseRequester CallingForm;

        private decimal _currentPeriodTotalCost = 0;

        #endregion

        #region Private Methods

        private async Task LoadPurchasesByDate(DateTime dateFrom, DateTime dateTo)
        {
            loadingLabel.Visible = true;
            await Task.Run(() =>
            {
                _purchases =
_purchaseData.GetPurchasesByDate<PurchaseView>(dateFrom.Date,
dateTo.Date);
                _purchaseStatuses = _purchaseData.GetPurchasesByDate(dateFrom.Date, dateTo.Date)
                    .ToDictionary(purchase => purchase.Id, purchase => purchase.Status);

            });
            loadingLabel.Visible = false;

            purchasesDataGridView.AutoGenerateColumns = false;
            purchasesDataGridView.DataSource = _purchases;
            ApplyPurchaseRowColors();

            CalculatePeriodTotalCost(_purchases);

            ViewCurrentPeroidTotalCost();
        }

        private void SelectPurchase()
        {
            int purchaseId = purchasesDataGridView.CurrentRow.Cells[5].Value.ToString().ParseToInt();
            var purchase = _purchaseData.GetPurchaseById(purchaseId);

            if (CallingForm != null)
            {
                CallingForm.PreviewPruchase(purchase);
                Close();
            }
        }

        private void CalculatePeriodTotalCost(List<PurchaseView> currentPurchases)
        {
            _currentPeriodTotalCost = 0;

            foreach (PurchaseView purchaseView in currentPurchases)
            {
                _currentPeriodTotalCost += purchaseView.Total;
            }
        }

        private void ViewCurrentPeroidTotalCost()
        {
            periodTotalValueToolStripStatusLabel.Text = _currentPeriodTotalCost.ToString("#,0");
        }

        private void ApplyPurchaseRowColors()
        {
            foreach (DataGridViewRow row in purchasesDataGridView.Rows)
            {
                ApplyPurchaseRowColor(row);
            }
        }

        private void ApplyPurchaseRowColor(DataGridViewRow row)
        {
            if (row == null || row.IsNewRow) return;

            PurchaseView purchase = row.DataBoundItem as PurchaseView;
            bool isUnpaid = purchase != null
                && _purchaseStatuses.TryGetValue(purchase.PurchaseId, out bool status)
                && !status;

            if (isUnpaid)
            {
                row.DefaultCellStyle.BackColor = Color.MistyRose;
                row.DefaultCellStyle.ForeColor = Color.DarkRed;
                row.DefaultCellStyle.SelectionBackColor = Color.IndianRed;
                row.DefaultCellStyle.SelectionForeColor = Color.White;
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;
                row.DefaultCellStyle.SelectionBackColor = SystemColors.Control;
                row.DefaultCellStyle.SelectionForeColor = Color.Black;
            }
        }

        private void purchasesDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ApplyPurchaseRowColor(purchasesDataGridView.Rows[e.RowIndex]);
            }
        }

        private void FilterByName()

        {
            var filter = _purchases.Where(purchase => purchase.SupplierName.Contains(supplierNameTextBox.Text)).ToList();
            purchasesDataGridView.AutoGenerateColumns = false;
            purchasesDataGridView.DataSource = filter;
            ApplyPurchaseRowColors();
            CalculatePeriodTotalCost(filter);

            ViewCurrentPeroidTotalCost();
        }

        #endregion

        private async void ChoosePurchaseForm_Load(object sender, EventArgs e)
        {
            //await LoadPurchasesByDate(DateTime.Parse($"{DateTime.Now.Year}-{DateTime.Now.Month}-01").Date, DateTime.Today.Date);
            if (supplierNameTextBox.Text.Trim().Length != 0)
            {
                await LoadPurchasesByDate(dateFromDateTimePicker.Value, dateToDateTimePicker.Value);
                FilterByName();
            }
            else
            {
                await LoadPurchasesByDate(dateFromDateTimePicker.Value, dateToDateTimePicker.Value);
            }
        }

        private async void dateFromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            await LoadPurchasesByDate(dateFromDateTimePicker.Value.Date, dateToDateTimePicker.Value.Date);
        }

        private async void dateToDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            await LoadPurchasesByDate(dateFromDateTimePicker.Value.Date, dateToDateTimePicker.Value.Date);
        }

        private void purchasesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0) return;
            SelectPurchase();
        }

        private void supplierNameTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterByName();
        }
    }
}
