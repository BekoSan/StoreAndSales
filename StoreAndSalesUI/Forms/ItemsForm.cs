using StoreAndSalesLibrary.DataAccess;
using StoreAndSalesLibrary.Models;
using StoreAndSalesUI.Helpers;
using StoreAndSalesUI.Interfaces;
using StoreAndSalesUI.ViewModels;
using System;
using System.Collections.Generic;
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
        
        #endregion

        #region Private Methods

        private void CollectData()
        {
            _item.ItemName = itemNameTextBox.Text;
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
            Items = _itemData.GetAllItems();
            itemsDataGridView.AutoGenerateColumns = false;
            itemsDataGridView.DataSource = Items;
        }

        private void SelectItem()
        {
            _item.Id = itemsDataGridView.CurrentRow.Cells[0].Value.ToString().ParseToInt();
            _item.ItemName = itemsDataGridView.CurrentRow.Cells[1].Value.ToString();
            _itemUnits = _itemUnitData.GetItemUnits<ItemUnitView>(_item.Id);
        }

        private void LoadItemData()
        {
            itemNameTextBox.Text = _item.ItemName;
        }

        private void LoadItemUnits()
        {
            itemUnitsDataGridView.Rows.Clear(); 
           
            _itemUnits.ForEach(itemUnit =>
            {
                itemUnitsDataGridView.Rows.Add(itemUnit.Id,itemUnit.ItemUnitId, itemUnit.UnitName, itemUnit.UnitPrice);
            });
        }

        private void ClearForm()
        {
            itemNameTextBox.Clear();
            itemUnitsDataGridView.Rows.Clear();
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

        private void Save()
        {

            try
            {
                if (_item.Id != 0)
                {
                    if (MessageBox.Show("سيتم تعديل البيانات ، هل أنت متأكد؟", "تأكيد التعديل",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                    _itemData.EditItem(_item);
                    MessageBox.Show("تم التعديل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _itemData.CreateItem(_item);
                    MessageBox.Show("تمت الإضافة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsefulMethods.LogException(ex);
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
                MessageBox.Show("تم الحذف بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                UsefulMethods.LogException(ex);
            }
        }

        private void ResetForm()
        {
            ClearForm();
            LoadItems();
            LoadDefaultUnit();
        }

        #endregion

        #region Public Methods

        public void AddUnit(Unit unit)
        {

            if (itemUnitsDataGridView.Rows.Count > 0)
            {
                if (IsUnitDublicated(unit.Id) == false)
                    itemUnitsDataGridView.Rows.Add(unit.Id,0, unit.UnitName, 0);
            }
            else
            {
                itemUnitsDataGridView.Rows.Add(unit.Id,0, unit.UnitName, 0);
            }
        }

        #endregion

        private void saveButton_Click(object sender, EventArgs e)
        {
            CollectData();
            if (IsValidData()) Save();
                ResetForm(); 
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

    }
}
