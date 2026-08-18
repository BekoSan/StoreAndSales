using StoreAndSalesLibrary.DataAccess;
using StoreAndSalesLibrary.Models;
using StoreAndSalesUI.Helpers;
using StoreAndSalesUI.Interfaces;
using StoreAndSalesUI.ViewModels;
using System;
using System.Drawing;

using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StoreAndSalesUI.Forms
{
    public partial class ItemsForm : Form, IUnitRequester
    {
        public ItemsForm()
        {
            InitializeComponent();
        }

        #region Private Members

        private ItemData _itemData = new ItemData(UsefulMethods.ConnectionStringName());
        private ItemUnitData _itemUnitData = new ItemUnitData();
        private Item _item = new Item();
        private List<ItemUnitView> _itemUnits = new List<ItemUnitView>();
        private List<Item> Items = new List<Item>();
        private UnitData _unitData = new UnitData();
        private UserLogData _userLogData = new UserLogData();
        private readonly Dictionary<int, int> _itemQuantities = new Dictionary<int, int>();
        private int _lastEditedItemId;

        #endregion

        #region Private Methods

        private void CollectData()
        {
            _item.ItemName = itemNameTextBox.Text;
            _item.ReorderLevel = reorderLevelTextBox.Text.ParseToInt();
            _item.ItemUnits.Clear();

            if (itemUnitsDataGridView.Rows.Count != 0)
            {
                foreach (DataGridViewRow dgvRow in itemUnitsDataGridView.Rows)
                {
                    _item.ItemUnits.Add(new ItemUnit
                    {
                        Id = dgvRow.Cells[1].Value.ToString().ParseToInt(),
                        ItemId = _item.Id,
                        UnitId = dgvRow.Cells[0].Value.ToString().ParseToInt(),
                        UnitPrice = dgvRow.Cells[3].Value.ToString().ParseToDecimal()
                    });
                }
            }
        }

        private void LoadItems()
        {
            Items = _itemData.GetAllItems() ?? new List<Item>();
            LoadItemQuantities();
            itemsDataGridView.AutoGenerateColumns = false;
            itemsDataGridView.DataSource = Items;

        }

        private void SelectItem()
        {
            Item selectedItem = itemsDataGridView.CurrentRow == null
                ? null
                : itemsDataGridView.CurrentRow.DataBoundItem as Item;

            if (selectedItem == null)
            {
                return;
            }

            _item.Id = selectedItem.Id;
            _item.ItemName = selectedItem.ItemName;
            _item.ReorderLevel = selectedItem.ReorderLevel;
            _itemUnits = _itemUnitData.GetItemUnits<ItemUnitView>(_item.Id);
        }

        private void LoadItemData()
        {
            itemNameTextBox.Text = _item.ItemName;
            reorderLevelTextBox.Text = _item.ReorderLevel.ToString();
        }

        private void LoadItemQuantities()
        {
            _itemQuantities.Clear();

            int defaultUnitId = UsefulMethods.GetDefaultUnitId();
            List<ItemUnitValue> allQuantities = Properties.Settings.Default.IsQuantityFilter
                    ? _itemData.GetAllItemQuantitiesAfterDate(Properties.Settings.Default.FilterDate)
                    : _itemData.GetAllItemQuantities()
                ?? new List<ItemUnitValue>();

            // تحميل الكميات باستعلام واحد ثم استخدام الوحدة الافتراضية فقط.
            foreach (ItemUnitValue itemQuantity in allQuantities)
            {
                if (itemQuantity.UnitId == defaultUnitId)
                {
                    _itemQuantities[itemQuantity.ItemId] = Math.Max(0, itemQuantity.ItemQuantity);
                }
            }

            // الأصناف التي لا يوجد لها سجل كمية تعرض صفراً بدلاً من تنفيذ استعلام إضافي.
            foreach (Item item in Items)
            {
                if (!_itemQuantities.ContainsKey(item.Id))
                {
                    _itemQuantities[item.Id] = 0;
                }
            }
        }

        private bool IsLowStock(Item item)
        {
            int quantity;
            return item != null
                && item.ReorderLevel > 0
                && _itemQuantities.TryGetValue(item.Id, out quantity)
                && quantity <= item.ReorderLevel;
        }

        private void itemsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // منع ظهور نافذة DataGridView الافتراضية عند فشل تحويل قيمة عرضية.
            e.ThrowException = false;
        }

        private void itemsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Item item = itemsDataGridView.Rows[e.RowIndex].DataBoundItem as Item;
            if (item == null)
            {
                return;
            }

            if (e.ColumnIndex == quantityColumn.Index)
            {
                int quantity;
                int displayQuantity = _itemQuantities.TryGetValue(item.Id, out quantity) ? quantity : 0;
                e.Value = displayQuantity.ToString("N0");
                e.FormattingApplied = true;
            }

            if (!IsLowStock(item))
            {
                return;
            }

            bool isSelected = itemsDataGridView.Rows[e.RowIndex].Selected;
            e.CellStyle.BackColor = isSelected ? Color.IndianRed : Color.MistyRose;
            e.CellStyle.ForeColor = isSelected ? Color.White : Color.DarkRed;
            e.CellStyle.SelectionBackColor = Color.IndianRed;
            e.CellStyle.SelectionForeColor = Color.White;
        }

        private void LoadItemUnits()
        {
            itemUnitsDataGridView.Rows.Clear();

            _itemUnits.ForEach(itemUnit =>
            {
                itemUnitsDataGridView.Rows.Add(itemUnit.Id, itemUnit.ItemUnitId, itemUnit.UnitName, itemUnit.UnitPrice);
            });
        }

        private void ClearForm()
        {
            itemNameTextBox.Clear();
            reorderLevelTextBox.Clear();
            itemUnitsDataGridView.Rows.Clear();

            searchTextBox.Clear();
            _item = new Item();
        }

        private void ChooseUnitToAdd()
        {
            new ChooseUnitForm(this).ShowDialog();
        }

        private void LoadDefaultUnit()
        {
            var unit = _unitData.GetUnitById(UsefulMethods.GetDefaultUnitId());
            itemUnitsDataGridView.Rows.Add(unit.Id, 0, unit.UnitName, 0);
        }

        private bool IsValidData()
        {
            bool output = true;

            if (_item.ItemName.Length == 0)
            {
                MessageBox.Show("يجب إدخال إسم الصنف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
                itemNameTextBox.Focus();
            }
            else if (_item.ReorderLevel < 0)
            {
                MessageBox.Show("يجب أن يكون حد إعادة الطلب صفرًا أو أكبر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
                reorderLevelTextBox.Focus();
            }
            else if (_item.ItemUnits.Count == 0)
            {

                MessageBox.Show("يجب إضافة وحدة على الأقل للصنف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
                addUnitButton.Focus();
            }

            return output;
        }

        private bool IsUnitDublicated(int unitId)
        {
            bool output = false;
            foreach (DataGridViewRow dgvRow in itemUnitsDataGridView.Rows)
            {
                if (dgvRow.Cells[0].Value.ToString().ParseToInt() == unitId)
                {
                    output = true;
                    break;
                }
            }

            return output;
        }

        private bool Save()
        {
            try
            {
                if (_item.Id != 0)
                {
                    if (MessageBox.Show("سيتم تعديل البيانات ، هل أنت متأكد؟", "تأكيد التعديل",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        return false;
                    }

                    _itemData.EditItem(_item);
                    _lastEditedItemId = _item.Id;
                    _userLogData.AddLog(LoginDataHelper.UserId, $"تم تعديل الصنــف {_item.ItemName}");

                    MessageBox.Show("تم التعديل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _lastEditedItemId = 0;
                    _itemData.CreateItem(_item);
                    _userLogData.AddLog(LoginDataHelper.UserId, $"تمت إضافة الصنـــف {_item.ItemName}");
                    MessageBox.Show("تمت الإضافة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsefulMethods.LogException(ex);
                return false;
            }
        }

        private void ArchiveItem()
        {
            if (_item.Id == 0) return;
            try
            {
                if (MessageBox.Show("هل أنت متأكد من الحــذف؟", "تأكيد الحــذف",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                _itemData.ArchiveItem(_item.Id);
                _userLogData.AddLog(LoginDataHelper.UserId, $"تم حـــذف الصنــف {_item.ItemName}");
                MessageBox.Show("تم الحذف بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsefulMethods.LogException(ex);
            }
        }

        private void ResetForm()
        {
            ClearForm();
            LoadItems();
            FocusItem(_lastEditedItemId);
            _lastEditedItemId = 0;
            LoadDefaultUnit();
        }

        private void FocusItem(int itemId)
        {
            if (itemId == 0 || itemsDataGridView.Rows.Count == 0)
            {
                return;
            }

            for (int rowIndex = 0; rowIndex < itemsDataGridView.Rows.Count; rowIndex++)
            {
                Item item = itemsDataGridView.Rows[rowIndex].DataBoundItem as Item;
                if (item == null || item.Id != itemId)
                {
                    continue;
                }

                itemsDataGridView.ClearSelection();
                itemsDataGridView.Rows[rowIndex].Selected = true;
                itemsDataGridView.CurrentCell = itemsDataGridView.Rows[rowIndex].Cells[itemNameColumn.Index];
                itemsDataGridView.FirstDisplayedScrollingRowIndex = rowIndex;
                return;
            }
        }

        private void Search(string searchText)
        {
            var filter = Items.Where(item => item.ItemName.Contains(searchText)).ToList();
            itemsDataGridView.AutoGenerateColumns = false;
            itemsDataGridView.DataSource = filter;
        }

        #endregion

        #region Public Methods

        public void AddUnit(Unit unit)
        {

            if (itemUnitsDataGridView.Rows.Count > 0)
            {
                if (IsUnitDublicated(unit.Id) == false)
                    itemUnitsDataGridView.Rows.Add(unit.Id, 0, unit.UnitName, 0);
            }
            else
            {
                itemUnitsDataGridView.Rows.Add(unit.Id, 0, unit.UnitName, 0);
            }
        }

        #endregion

        private void saveButton_Click(object sender, EventArgs e)
        {
            CollectData();
            if (!IsValidData())
            {
                return;
            }

            if (Save())
            {
                ResetForm();
            }
        }

        private void reorderLevelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            LoadItems();
            LoadDefaultUnit();
        }

        private void itemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectItem();
            LoadItemData();
            LoadItemUnits();
        }

        private void addUnitButton_Click(object sender, EventArgs e)
        {
            ChooseUnitToAdd();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ArchiveItem();
            ResetForm();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search(searchTextBox.Text);
        }
    }
}
