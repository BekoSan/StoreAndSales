using StoreAndSalesLibrary.DataAccess;
using StoreAndSalesUI.Helpers;
using StoreAndSalesUI.Interfaces;
using StoreAndSalesUI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreAndSalesUI.Forms
{
    public partial class ChooseSaleForm : Form
    {
        public ChooseSaleForm()
        {
            InitializeComponent();
        }

        public ChooseSaleForm(ISaleRequester caller)
        {
            InitializeComponent();
            CallingForm = caller;
        }

        #region Private Members

        private SaleData _saleData = new SaleData();
        private List<SaleView> _sales = new List<SaleView>();
        private Dictionary<int, bool> _saleStatuses = new Dictionary<int, bool>();
        private ISaleRequester CallingForm;

        private decimal _currentPeriodTotalCost = 0;

        #endregion

        #region Private Methods

        private async Task LoadSalesByDate(DateTime dateFrom, DateTime dateTo)
        {
            loadingLabel.Visible = true;
            await Task.Run(() =>
            {
                _sales = _saleData.GetSalesByDate<SaleView>(dateFrom.Date,
dateTo.Date);
                _saleStatuses = _saleData.GetSalesByDate(dateFrom.Date, dateTo.Date)
                    .ToDictionary(sale => sale.Id, sale => sale.Status);

            });
            loadingLabel.Visible = false;

            salesDataGridView.AutoGenerateColumns = false;
            salesDataGridView.DataSource = _sales;
            ApplySaleRowColors();
            CalculatePeriodTotalCost(_sales);

            ViewCurrentPeroidTotalCost();
        }

        private void SelectSale()
        {
            int saleId = salesDataGridView.CurrentRow.Cells[5].Value.ToString().ParseToInt();
            var sale = _saleData.GetSaleById(saleId);

            if (CallingForm != null)
            {
                CallingForm.PreviewSale(sale);
                Hide();
            }
        }

        private void CalculatePeriodTotalCost(List<SaleView> currentSales)
        {
            _currentPeriodTotalCost = 0;

            foreach (SaleView saleView in currentSales)
            {
                _currentPeriodTotalCost += saleView.Total;
            }
        }

        private void ViewCurrentPeroidTotalCost()
        {
            periodTotalValueToolStripStatusLabel.Text = _currentPeriodTotalCost.ToString("#,0");
        }

        private void ApplySaleRowColors()
        {
            foreach (DataGridViewRow row in salesDataGridView.Rows)
            {
                ApplySaleRowColor(row);
            }
        }

        private void ApplySaleRowColor(DataGridViewRow row)
        {
            if (row == null || row.IsNewRow) return;

            SaleView sale = row.DataBoundItem as SaleView;
            bool isUnpaid = sale != null
                && _saleStatuses.TryGetValue(sale.SaleId, out bool status)
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

        private void salesDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ApplySaleRowColor(salesDataGridView.Rows[e.RowIndex]);
            }
        }

        private void FilterByName()

        {
            var filter = _sales.Where(sale => sale.CustomerName.Contains(customerNameTextBox.Text)).ToList();
            salesDataGridView.AutoGenerateColumns = false;
            salesDataGridView.DataSource = filter;
            ApplySaleRowColors();

            CalculatePeriodTotalCost(filter);

            ViewCurrentPeroidTotalCost();
        }


        #endregion

        private async void ChooseSaleForm_Load(object sender, EventArgs e)
        {
            //await  LoadSalesByDate(DateTime.Parse($"{DateTime.Now.Year}-{DateTime.Now.Month}-01").Date, DateTime.Today.Date);
            if (customerNameTextBox.Text.Trim().Length != 0)
            {
                await LoadSalesByDate(dateFromDateTimePicker.Value, dateToDateTimePicker.Value);
                FilterByName();
            }
            else
            {
                await LoadSalesByDate(dateFromDateTimePicker.Value, dateToDateTimePicker.Value);
            }
        }

        private async void dateFromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            await LoadSalesByDate(dateFromDateTimePicker.Value.Date, dateToDateTimePicker.Value.Date);
        }

        private async void dateToDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            await LoadSalesByDate(dateFromDateTimePicker.Value.Date, dateToDateTimePicker.Value.Date);
        }

        private void salesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0) return;
            SelectSale();
        }

        private void customerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterByName();
        }

        private void salesDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void salesDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

        }

        private void salesDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //Thread.Sleep(70);
        }
    }
}
