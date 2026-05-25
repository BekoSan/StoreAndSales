using StoreAndSalesLibrary.DataAccess;
using System.Collections.Generic;
using System.Windows.Forms;
using StoreAndSalesLibrary.Models;
using StoreAndSalesUI.Helpers;
using System.Drawing;

namespace StoreAndSalesUI.Forms
{
    public partial class StoreViewForm : Form
    {
        public StoreViewForm()
        {
            InitializeComponent();
            _items = _itemData.GetAllItems();
            _units = _unitData.GetAllUnits();

            AddItemColumnsToQuantityGrid();
            AddUnitColumnsToQuantityGrid();
            AddQuantityRows();

            AddItemColumnsToPricesGrid();
            AddUnitColumnsToPriceGrid();
            AddPriceRows();

            AddItemColumnsToCalculationsGrid();
            AddUnitColumnsToCalculationsGrid();
            AddCalculationsRows();
        }

        #region Private Members


        private ItemData _itemData = new ItemData();
        private List<Item> _items = new List<Item>();

        private UnitData _unitData = new UnitData();
        private List<Unit> _units = new List<Unit>();

        #endregion


        private void AddItemColumnsToQuantityGrid()
        {
            // Id Invisible column
            DataGridViewColumn itemIdColumn = new DataGridViewColumn();
            itemIdColumn.Visible = false;
            itemIdColumn.HeaderText = "Id";
            itemIdColumn.CellTemplate = new DataGridViewTextBoxCell();  

            storeViewDataGridView.Columns.Add(itemIdColumn);
            // item name column
            storeViewDataGridView.Columns.Add("itemNameColumn","إسم الصنف");
        }

        private void AddItemColumnsToPricesGrid()
        {
            // Id Invisible column
            DataGridViewColumn itemIdColumn = new DataGridViewColumn();
            itemIdColumn.Visible = false;
            itemIdColumn.HeaderText = "Id";
            itemIdColumn.CellTemplate = new DataGridViewTextBoxCell();

            pricesDataGridView.Columns.Add(itemIdColumn);
            // item name column
            pricesDataGridView.Columns.Add("itemNameColumn", "إسم الصنف");
        }

        private void AddItemColumnsToCalculationsGrid()
        {
            // Id Invisible column
            DataGridViewColumn itemIdColumn = new DataGridViewColumn();
            itemIdColumn.Visible = false;
            itemIdColumn.HeaderText = "Id";
            itemIdColumn.CellTemplate = new DataGridViewTextBoxCell();

            calculationsDataGridView.Columns.Add(itemIdColumn);
            // item name column
            calculationsDataGridView.Columns.Add("itemNameColumn", "إسم الصنف");
        }

        private void AddUnitColumnsToQuantityGrid()
        {
            
            int counter = 1;

            _units.ForEach(unit => 
            {
                DataGridViewColumn unitColumn = new DataGridViewColumn();
                unitColumn.Name = $"U{counter}";
                unitColumn.DefaultCellStyle.Font = new Font("Consolas", 9);
                unitColumn.HeaderText = unit.UnitName;
                unitColumn.Tag = unit.Id;
                unitColumn.CellTemplate = new DataGridViewTextBoxCell();
                unitColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                unitColumn.Width = 100;
                unitColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
               

                storeViewDataGridView.Columns.Add(unitColumn);
                counter++;
            }); 
        }

        private void AddUnitColumnsToPriceGrid()
        {
            int counter = 1;

            _units.ForEach(unit =>
            {
                DataGridViewColumn unitColumn = new DataGridViewColumn();
                unitColumn.Name = $"U{counter}";
                unitColumn.DefaultCellStyle.Font = new Font("Consolas", 9);
                unitColumn.HeaderText = unit.UnitName;
                unitColumn.Tag = unit.Id;
                unitColumn.CellTemplate = new DataGridViewTextBoxCell();
                unitColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                unitColumn.Width = 100;
                unitColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                unitColumn.DefaultCellStyle.Format = "N0";

                pricesDataGridView.Columns.Add(unitColumn);
                counter++;
            });
        }

        private void AddUnitColumnsToCalculationsGrid()
        {
            int counter = 1;

            _units.ForEach(unit =>
            {
                DataGridViewColumn unitColumn = new DataGridViewColumn();
                unitColumn.Name = $"U{counter}";
                unitColumn.DefaultCellStyle.Font = new Font("Consolas", 9);
                unitColumn.HeaderText = unit.UnitName;
                unitColumn.Tag = unit.Id;
                unitColumn.CellTemplate = new DataGridViewTextBoxCell();
                unitColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                unitColumn.Width = 100;
                unitColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                unitColumn.DefaultCellStyle.Format = "N0";

                calculationsDataGridView.Columns.Add(unitColumn);
                counter++;
            });

            DataGridViewColumn calculationColumn = new DataGridViewColumn();
            calculationColumn.Name = "calculationColumn";
            calculationColumn.DefaultCellStyle.Font = new Font("Consolas", 9);
            calculationColumn.HeaderText = "الإجمالي"; 
            calculationColumn.CellTemplate = new DataGridViewTextBoxCell();
            calculationColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            calculationColumn.Width = 100;
            calculationColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            calculationColumn.DefaultCellStyle.Format = "N0";

            calculationsDataGridView.Columns.Add(calculationColumn);
        }


        private void AddQuantityRows()
        {
           

            _items.ForEach(item => 
            {
                storeViewDataGridView.Rows.Add(item.Id,item.ItemName);
            });

            foreach (DataGridViewRow dgvRow in storeViewDataGridView.Rows)
            {
                foreach (DataGridViewCell dgvCell in dgvRow.Cells)
                {
                    if (dgvCell.OwningColumn.Tag == null) continue;

                    int itemId = dgvRow.Cells[0].Value.ToString().ParseToInt();
                    int unitId = dgvCell.OwningColumn.Tag.ToString().ParseToInt();

                    dgvCell.Value = _itemData.GetItemQuantity(itemId, unitId);
                }
            }
        }

        private void AddPriceRows()
        {

            _items.ForEach(item =>
            {
                pricesDataGridView.Rows.Add(item.Id, item.ItemName);
            });

            foreach (DataGridViewRow dgvRow in pricesDataGridView.Rows)
            {
                foreach (DataGridViewCell dgvCell in dgvRow.Cells)
                {
                    if (dgvCell.OwningColumn.Tag == null) continue;

                    int itemId = dgvRow.Cells[0].Value.ToString().ParseToInt();
                    int unitId = dgvCell.OwningColumn.Tag.ToString().ParseToInt();

                    dgvCell.Value = _itemData.GetItemLatestPurchasePrice(itemId, unitId);
                }
            }
        }

        private void AddCalculationsRows()
        {

            _items.ForEach(item =>
            {
                calculationsDataGridView.Rows.Add(item.Id, item.ItemName);
            });

            foreach (DataGridViewRow dgvRow in calculationsDataGridView.Rows)
            {
                foreach (DataGridViewCell dgvCell in dgvRow.Cells)
                {
                    if (dgvCell.OwningColumn.Name.Equals("calculationColumn"))
                        dgvCell.Value = CalculateItemUnitPrices(dgvRow);

                    if (dgvCell.OwningColumn.Tag == null) continue;

                    int itemId = dgvRow.Cells[0].Value.ToString().ParseToInt();
                    int unitId = dgvCell.OwningColumn.Tag.ToString().ParseToInt();

                    dgvCell.Value = _itemData.GetItemLatestPurchasePrice(itemId, unitId)
                        *
                        _itemData.GetItemQuantity(itemId, unitId);
                }
            }
        }

        private decimal CalculateItemUnitPrices(DataGridViewRow dgvRow)
        {
            decimal output = 0;

            foreach (DataGridViewCell dgvCell in dgvRow.Cells)
            {
                if (dgvCell.OwningColumn.Tag == null) continue;
                output += dgvCell.Value == null ? 0
                    :
                    dgvCell.Value.ToString().ParseToDecimal();
            }

            return output;
        }

    }

}
