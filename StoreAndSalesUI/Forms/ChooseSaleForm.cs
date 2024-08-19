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
        private ISaleRequester CallingForm;
        private decimal _currentPeriodTotalCost = 0;

        #endregion

        #region Private Methods

        private void LoadSalesByDate()
        {
            _sales = _saleData.GetSalesByDate<SaleView>(dateFromDateTimePicker.Value.Date,
                dateToDateTimePicker.Value.Date);
            salesDataGridView.AutoGenerateColumns = false;
            salesDataGridView.DataSource = _sales;
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
                Close();
            }
        }

        private void CalculatePeriodTotalCost(List<SaleView> currentSales)
        {
            _currentPeriodTotalCost = 0;

            foreach (SaleView  saleView in currentSales)
            {
                _currentPeriodTotalCost += saleView.Total;
            }
        }

        private void ViewCurrentPeroidTotalCost()
        {
            periodTotalValueToolStripStatusLabel.Text = _currentPeriodTotalCost.ToString("#,0");
        }

        private void FilterByName()
        {
            var filter = _sales.Where(sale => sale.CustomerName.Contains(customerNameTextBox.Text)).ToList();
            salesDataGridView.AutoGenerateColumns = false;
            salesDataGridView.DataSource = filter;

            CalculatePeriodTotalCost(filter);
            ViewCurrentPeroidTotalCost();
        }


        #endregion

        private void ChooseSaleForm_Load(object sender, EventArgs e)
        {
            LoadSalesByDate(); 
        }

        private void dateFromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadSalesByDate();
        }

        private void dateToDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadSalesByDate();
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
