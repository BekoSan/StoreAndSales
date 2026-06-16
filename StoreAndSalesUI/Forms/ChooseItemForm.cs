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
    public partial class ChooseItemForm : Form
    {
        public ChooseItemForm()
        {
            InitializeComponent();
        }

        public ChooseItemForm(IItemRequester caller)
        {
            InitializeComponent();
            CallingForm = caller;
        }

        #region Private Members

        private ItemData _itemData = new ItemData();
        private Item _item = new Item();
        private List<Item> Items = new List<Item>();
        private IItemRequester CallingForm;

        #endregion

        #region Private Methods

        private void LoadItems()
        {
            Items  = _itemData.GetAllItems();
            itemsDataGridView.AutoGenerateColumns = false;
            itemsDataGridView.DataSource = Items;
        }

        private void SelectItem()
        {
            _item.Id = itemsDataGridView.CurrentRow.Cells[0].Value.ToString().ParseToInt();
            _item.ItemName = itemsDataGridView.CurrentRow.Cells[2].Value.ToString();
            if (CallingForm != null) CallingForm.AddItem(_item);
        }

        private void FilterByName(string itemName)
        {
            List<Item> filter = Items.Where(item => item.ItemName.Contains(itemName)).ToList();
            itemsDataGridView.AutoGenerateColumns = false;
            itemsDataGridView.DataSource = filter;
        }

        #endregion

        private void itemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 1) return;
            SelectItem();
            //Close();
        }

        private void ChooseItemForm_Load(object sender, System.EventArgs e)
        {
            LoadItems(); 
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterByName(searchTextBox.Text);
        }

    }
}
