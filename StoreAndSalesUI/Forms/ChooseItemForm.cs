using StoreAndSalesLibrary.DataAccess;
using StoreAndSalesLibrary.Models;
using StoreAndSalesUI.Helpers;
using StoreAndSalesUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;

using System.Globalization;
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

        public ChooseItemForm(IItemRequester caller, int storeId)
        {
            InitializeComponent();
            CallingForm = caller;
            _storeId = storeId;
            InitializeItemList();
        }

        #region Private Members

        private readonly ItemData _itemData = new ItemData();
        private readonly Item _item = new Item();
        private readonly Timer _searchTimer = new Timer();
        private List<Item> _items = new List<Item>();
        private readonly Dictionary<int, int> _itemQuantities = new Dictionary<int, int>();
        private IItemRequester CallingForm;
        private int _storeId;

        private bool _isLoading;
        private bool _isItemNameSortAscending = true;
        private static readonly StringComparer ItemNameComparer = StringComparer.Create(
            CultureInfo.GetCultureInfo("ar-SA"), true);

        #endregion

        #region Private Methods

        private void InitializeItemList()
        {
            itemsDataGridView.AutoGenerateColumns = false;
            itemsDataGridView.DataSource = _items;
            UpdateSortButtonText();

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
                // تنفيذ جلب الأصناف والكميات خارج خيط واجهة المستخدم.
                List<Item> loadedItems = null;
                Dictionary<int, int> loadedQuantities = null;

                await Task.Run(() =>
                {
                    loadedItems = _itemData.GetAllItems() ?? new List<Item>();
                    loadedQuantities = BuildItemQuantities(loadedItems);
                });

                if (IsDisposed)
                {
                    return;
                }

                _items = loadedItems ?? new List<Item>();
                _itemQuantities.Clear();
                foreach (KeyValuePair<int, int> itemQuantity in loadedQuantities
                    ?? new Dictionary<int, int>())
                {
                    _itemQuantities[itemQuantity.Key] = itemQuantity.Value;
                }

                itemsDataGridView.DataSource = SortItems(_items);

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

        private Dictionary<int, int> BuildItemQuantities(List<Item> items)
        {
            Dictionary<int, int> quantities = new Dictionary<int, int>();
            int defaultUnitId = UsefulMethods.GetDefaultUnitId();
            List<ItemUnitValue> allQuantities = _itemData.GetAllItemQuantities(_storeId)
                ?? new List<ItemUnitValue>();

            // استخدم الوحدة الافتراضية فقط؛ فهي نفس الوحدة المعتمدة
            // في فرق كميات فواتير المبيعات والمشتريات.
            foreach (ItemUnitValue itemQuantity in allQuantities)
            {
                if (itemQuantity.UnitId == defaultUnitId)
                {
                    quantities[itemQuantity.ItemId] = Math.Max(0, itemQuantity.ItemQuantity);
                }
            }

            foreach (Item item in items ?? new List<Item>())
            {
                if (!quantities.ContainsKey(item.Id))
                {
                    quantities[item.Id] = 0;
                }
            }

            return quantities;
        }

        private List<Item> SortItems(IEnumerable<Item> source)
        {
            IOrderedEnumerable<Item> orderedItems = (source ?? Enumerable.Empty<Item>())
                .OrderBy(item => item.ItemName ?? string.Empty, ItemNameComparer);

            return _isItemNameSortAscending
                ? orderedItems.ToList()
                : orderedItems.Reverse().ToList();
        }

        private void UpdateSortButtonText()
        {
            sortItemsButton.Text = _isItemNameSortAscending
                ? "أ → ي / A → Z"
                : "ي → أ / Z → A";
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

            bool isSelected = itemsDataGridView.Rows[e.RowIndex].Selected;
            e.CellStyle.BackColor = isSelected
                ? Color.FromArgb(0, 150, 136)
                : Color.White;
            e.CellStyle.ForeColor = isSelected
                ? Color.White
                : Color.FromArgb(48, 58, 70);
            e.CellStyle.SelectionBackColor = Color.FromArgb(0, 150, 136);
            e.CellStyle.SelectionForeColor = Color.White;

            if (e.ColumnIndex == itemSerialColumn.Index)
            {
                e.Value = (e.RowIndex + 1).ToString();
                e.FormattingApplied = true;
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

            isSelected = itemsDataGridView.Rows[e.RowIndex].Selected;
            e.CellStyle.BackColor = isSelected ? Color.IndianRed : Color.MistyRose;
            e.CellStyle.ForeColor = isSelected ? Color.White : Color.DarkRed;
            e.CellStyle.SelectionBackColor = Color.IndianRed;
            e.CellStyle.SelectionForeColor = Color.White;
        }

        private void FilterByName(string itemName)

        {
            if (_items.Count == 0)
            {
                itemsDataGridView.DataSource = SortItems(_items);
                return;
            }

            if (string.IsNullOrWhiteSpace(itemName))
            {
                itemsDataGridView.DataSource = SortItems(_items);
                return;
            }

            string searchTerm = itemName.Trim();
            List<Item> filteredItems = _items
                .Where(item => !string.IsNullOrEmpty(item.ItemName)
                    && item.ItemName.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            itemsDataGridView.DataSource = SortItems(filteredItems);
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

        private void sortItemsButton_Click(object sender, EventArgs e)
        {
            _isItemNameSortAscending = !_isItemNameSortAscending;
            UpdateSortButtonText();
            _searchTimer.Stop();
            FilterByName(searchTextBox.Text);
        }

    }
}
