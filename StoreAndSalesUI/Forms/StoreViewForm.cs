using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using StoreAndSalesLibrary.DataAccess;
using StoreAndSalesLibrary.Models;
using StoreAndSalesUI.Helpers;

namespace StoreAndSalesUI.Forms
{
    public partial class StoreViewForm : Form
    {
        public StoreViewForm()
        {
            InitializeComponent();
            ConfigureGrid(storeViewDataGridView);
            ConfigureGrid(pricesDataGridView);
            ConfigureGrid(calculationsDataGridView);
            FillGrids();
        }

        #region Private Members

        private readonly ItemData _itemData = new ItemData();
        private List<Item> _items = new List<Item>();
        private readonly UnitData _unitData = new UnitData();
        private List<Unit> _units = new List<Unit>();
        private decimal _totalInventoryValue;

        #endregion

        private static string BuildKey(int itemId, int unitId)
        {
            return itemId + ":" + unitId;
        }

        private static void AddValue(Dictionary<string, int> values, ItemUnitValue value)
        {
            values[BuildKey(value.ItemId, value.UnitId)] = value.ItemQuantity;
        }

        private static void AddValue(Dictionary<string, decimal> values, ItemUnitValue value)
        {
            values[BuildKey(value.ItemId, value.UnitId)] = value.ItemPrice;
        }

        private void ConfigureGrid(DataGridView grid)
        {
            grid.AllowUserToAddRows = false;
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            grid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.FixedSingle;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = Color.FromArgb(225, 230, 235);
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(47, 84, 120);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 84, 120);
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.ColumnHeadersHeight = 34;
            grid.RowTemplate.Height = 28;
            grid.RowsDefaultCellStyle.BackColor = Color.White;
            grid.RowsDefaultCellStyle.ForeColor = Color.FromArgb(35, 35, 35);
            grid.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(221, 235, 247);
            grid.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 20, 20);
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            grid.SuspendLayout();

            try
            {
                typeof(DataGridView)
                    .GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
                    ?.SetValue(grid, true, null);
            }
            catch (Exception)
            {
                // Double buffering is an optional UI optimization; ignore unsupported runtimes.
            }
        }

        private void ClearGrid(DataGridView grid)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();
        }

        private void FillGrids()
        {
            SuspendLayout();
            try
            {
                _items = _itemData.GetAllItems();
                _units = _unitData.GetAllUnits();

                List<ItemUnitValue> quantityRows = Properties.Settings.Default.IsQuantityFilter
                    ? _itemData.GetAllItemQuantitiesAfterDate(Properties.Settings.Default.FilterDate)
                    : _itemData.GetAllItemQuantities();
                List<ItemUnitValue> priceRows = _itemData.GetAllItemLatestPurchasePrices();

                var quantitiesByKey = new Dictionary<string, int>();
                foreach (ItemUnitValue value in quantityRows)
                {
                    AddValue(quantitiesByKey, value);
                }

                var pricesByKey = new Dictionary<string, decimal>();
                foreach (ItemUnitValue value in priceRows)
                {
                    AddValue(pricesByKey, value);
                }

                ClearGrid(storeViewDataGridView);
                ClearGrid(pricesDataGridView);
                ClearGrid(calculationsDataGridView);

                AddItemColumnsToQuantityGrid();
                AddUnitColumnsToQuantityGrid();
                AddQuantityRows(quantitiesByKey);

                AddItemColumnsToPricesGrid();
                AddUnitColumnsToPriceGrid();
                AddPriceRows(pricesByKey);

                AddItemColumnsToCalculationsGrid();
                AddUnitColumnsToCalculationsGrid();
                AddCalculationsRows(quantitiesByKey, pricesByKey);
                UpdateTotalInventoryLabel();
            }
            finally
            {
                storeViewDataGridView.ResumeLayout();
                pricesDataGridView.ResumeLayout();
                calculationsDataGridView.ResumeLayout();
                ResumeLayout();
            }
        }

        private void ResetStoreQuantity()
        {
            if (MessageBox.Show("هل أنت متأكد من تصفير جميع الكميات في المخزن؟!", "تأكيد تصفير المخزن", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;

            Properties.Settings.Default.IsQuantityFilter = true;
            Properties.Settings.Default.FilterDate = DateTime.Now;
            Properties.Settings.Default.Save();
            FillGrids();
            MessageBox.Show("تم تصفير كميات المخزن بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddItemColumnsToQuantityGrid()
        {
            DataGridViewColumn itemIdColumn = new DataGridViewColumn
            {
                Visible = false,
                HeaderText = "Id",
                CellTemplate = new DataGridViewTextBoxCell()
            };
            storeViewDataGridView.Columns.Add(itemIdColumn);
            storeViewDataGridView.Columns.Add("itemNameColumn", "إسم الصنف");
        }

        private void AddItemColumnsToPricesGrid()
        {
            DataGridViewColumn itemIdColumn = new DataGridViewColumn
            {
                Visible = false,
                HeaderText = "Id",
                CellTemplate = new DataGridViewTextBoxCell()
            };
            pricesDataGridView.Columns.Add(itemIdColumn);
            pricesDataGridView.Columns.Add("itemNameColumn", "إسم الصنف");
        }

        private void AddItemColumnsToCalculationsGrid()
        {
            DataGridViewColumn itemIdColumn = new DataGridViewColumn
            {
                Visible = false,
                HeaderText = "Id",
                CellTemplate = new DataGridViewTextBoxCell()
            };
            calculationsDataGridView.Columns.Add(itemIdColumn);
            calculationsDataGridView.Columns.Add("itemNameColumn", "إسم الصنف");
        }

        private DataGridViewColumn CreateUnitColumn(Unit unit, int counter, bool isPriceColumn)
        {
            var unitColumn = new DataGridViewColumn
            {
                Name = "U" + counter,
                HeaderText = unit.UnitName,
                Tag = unit.Id,
                CellTemplate = new DataGridViewTextBoxCell(),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 100
            };
            unitColumn.DefaultCellStyle.Font = new Font("Consolas", 9);
            unitColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (isPriceColumn)
            {
                unitColumn.DefaultCellStyle.Format = "N0";
            }
            return unitColumn;
        }

        private void AddUnitColumnsToQuantityGrid()
        {
            for (int index = 0; index < _units.Count; index++)
            {
                storeViewDataGridView.Columns.Add(CreateUnitColumn(_units[index], index + 1, false));
            }
        }

        private void AddUnitColumnsToPriceGrid()
        {
            for (int index = 0; index < _units.Count; index++)
            {
                pricesDataGridView.Columns.Add(CreateUnitColumn(_units[index], index + 1, true));
            }
        }

        private void AddUnitColumnsToCalculationsGrid()
        {
            for (int index = 0; index < _units.Count; index++)
            {
                calculationsDataGridView.Columns.Add(CreateUnitColumn(_units[index], index + 1, true));
            }

            var calculationColumn = new DataGridViewColumn
            {
                Name = "calculationColumn",
                HeaderText = "الإجمالي",
                CellTemplate = new DataGridViewTextBoxCell(),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 100
            };
            calculationColumn.DefaultCellStyle.Font = new Font("Consolas", 9);
            calculationColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            calculationColumn.DefaultCellStyle.Format = "N0";
            calculationsDataGridView.Columns.Add(calculationColumn);
        }

        private void AddQuantityRows(Dictionary<string, int> quantitiesByKey)
        {
            foreach (Item item in _items)
            {
                int rowIndex = storeViewDataGridView.Rows.Add(item.Id, item.ItemName);
                DataGridViewRow row = storeViewDataGridView.Rows[rowIndex];

                for (int unitIndex = 0; unitIndex < _units.Count; unitIndex++)
                {
                    int quantity;
                    quantitiesByKey.TryGetValue(BuildKey(item.Id, _units[unitIndex].Id), out quantity);
                    row.Cells[unitIndex + 2].Value = quantity;
                }
            }
        }

        private void AddPriceRows(Dictionary<string, decimal> pricesByKey)
        {
            foreach (Item item in _items)
            {
                int rowIndex = pricesDataGridView.Rows.Add(item.Id, item.ItemName);
                DataGridViewRow row = pricesDataGridView.Rows[rowIndex];

                for (int unitIndex = 0; unitIndex < _units.Count; unitIndex++)
                {
                    decimal price;
                    pricesByKey.TryGetValue(BuildKey(item.Id, _units[unitIndex].Id), out price);
                    row.Cells[unitIndex + 2].Value = price;
                }
            }
        }

        private void AddCalculationsRows(Dictionary<string, int> quantitiesByKey, Dictionary<string, decimal> pricesByKey)
        {
            _totalInventoryValue = 0;

            foreach (Item item in _items)
            {
                int rowIndex = calculationsDataGridView.Rows.Add(item.Id, item.ItemName);
                DataGridViewRow row = calculationsDataGridView.Rows[rowIndex];
                decimal total = 0;

                for (int unitIndex = 0; unitIndex < _units.Count; unitIndex++)
                {
                    string key = BuildKey(item.Id, _units[unitIndex].Id);
                    int quantity;
                    decimal price;
                    quantitiesByKey.TryGetValue(key, out quantity);
                    pricesByKey.TryGetValue(key, out price);

                    decimal value = price * quantity;
                    row.Cells[unitIndex + 2].Value = value;
                    total += value;
                }

                row.Cells[_units.Count + 2].Value = total;
                _totalInventoryValue += total;
            }
        }

        private void UpdateTotalInventoryLabel()
        {
            inventoryTotalLabel.Text = "إجمالي جرد المخزن: " + _totalInventoryValue.ToString("N0");
        }

        private void resetQuantityButton_Click(object sender, EventArgs e)
        {
            ResetStoreQuantity();
        }
    }
}
