using StoreAndSalesLibrary.DataAccess;
using StoreAndSalesLibrary.Models;
using StoreAndSalesUI.Helpers;
using StoreAndSalesUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreAndSalesUI.Forms
{
    public partial class ChooseItemForm : Form
    {
        private const int SearchDelayMilliseconds = 200;

        public ChooseItemForm()
        {
            InitializeComponent();
            InitializeItemList();
        }

        public ChooseItemForm(IItemRequester caller)
        {
            InitializeComponent();
            CallingForm = caller;
            InitializeItemList();
        }

        #region Private Members

        private readonly ItemData _itemData = new ItemData();
        private readonly Item _item = new Item();
        private readonly Timer _searchTimer = new Timer();
        private List<Item> _items = new List<Item>();
        private IItemRequester CallingForm;
        private bool _isLoading;

        #endregion

        #region Private Methods

        private void InitializeItemList()
        {
            itemsDataGridView.AutoGenerateColumns = false;
            itemsDataGridView.DataSource = _items;

            _searchTimer.Interval = SearchDelayMilliseconds;
            _searchTimer.Tick += SearchTimer_Tick;
        }

        private async Task LoadItemsAsync()
        {
            if (IsDisposed || _isLoading)
            {
                return;
            }

            _isLoading = true;
            searchTextBox.Enabled = false;
            Cursor = Cursors.WaitCursor;

            try
            {
                // تنفيذ الاستعلام خارج خيط واجهة المستخدم حتى لا تتجمد الشاشة.
                List<Item> loadedItems = await Task.Run(() => _itemData.GetAllItems());

                if (IsDisposed)
                {
                    return;
                }

                _items = loadedItems ?? new List<Item>();
                itemsDataGridView.DataSource = _items;
                //CallingForm?.GetCount(_items.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsefulMethods.LogException(ex);
            }
            finally
            {
                _isLoading = false;
                searchTextBox.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private void FilterByName(string itemName)
        {
            if (_items.Count == 0)
            {
                itemsDataGridView.DataSource = _items;
                //CallingForm?.GetCount(0);
                return;
            }

            if (string.IsNullOrWhiteSpace(itemName))
            {
                itemsDataGridView.DataSource = _items;
                //CallingForm?.GetCount(_items.Count);
                return;
            }

            string searchTerm = itemName.Trim();
            List<Item> filteredItems = _items
                .Where(item => !string.IsNullOrEmpty(item.ItemName)
                    && item.ItemName.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            itemsDataGridView.DataSource = filteredItems;
            //CallingForm?.GetCount(filteredItems.Count);
        }

        private void SelectItem()
        {
            if (itemsDataGridView.CurrentRow == null || itemsDataGridView.CurrentRow.IsNewRow)
            {
                return;
            }

            _item.Id = itemsDataGridView.CurrentRow.Cells[0].Value.ToString().ParseToInt();
            _item.ItemName = Convert.ToString(itemsDataGridView.CurrentRow.Cells[2].Value);
            CallingForm?.AddItem(_item);
        }

        #endregion

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            _searchTimer.Stop();
            FilterByName(searchTextBox.Text);
        }

        private void itemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 1)
            {
                return;
            }

            SelectItem();
        }

        private async void ChooseItemForm_Load(object sender, EventArgs e)
        {
            await LoadItemsAsync();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!searchTextBox.Enabled)
            {
                return;
            }

            _searchTimer.Stop();
            _searchTimer.Start();
        }

    }
}
