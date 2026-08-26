using StoreAndSalesLibrary.DataAccess;
using StoreAndSalesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StoreAndSalesUI.Forms
{
    public class StoresForm : Form
    {
        private readonly StoreData _storeData = new StoreData();
        private readonly DataGridView _grid = new DataGridView();
        private readonly TextBox _nameTextBox = new TextBox();
        private readonly TextBox _addressTextBox = new TextBox();
        private readonly CheckBox _defaultCheckBox = new CheckBox();
        private int _selectedStoreId;

        public StoresForm()
        {
            Text = "إدارة المخازن";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(740, 470);
            BackColor = Color.FromArgb(246, 248, 251);

            var title = new Label { Text = "إدارة المخازن", Dock = DockStyle.Top, Height = 48, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Arial", 18, FontStyle.Bold), ForeColor = Color.FromArgb(31, 55, 82) };
            var editor = new Panel { Dock = DockStyle.Top, Height = 118, Padding = new Padding(18), BackColor = Color.White };
            _nameTextBox.SetBounds(390, 28, 260, 26);
            _addressTextBox.SetBounds(90, 28, 260, 26);
            _defaultCheckBox.SetBounds(390, 64, 180, 26);
            _defaultCheckBox.Text = "المخزن الافتراضي";
            var save = new Button { Text = "حفظ", Location = new Point(200, 64), Size = new Size(85, 28) };
            var fresh = new Button { Text = "جديد", Location = new Point(105, 64), Size = new Size(85, 28) };
            var archive = new Button { Text = "إيقاف", Location = new Point(15, 64), Size = new Size(80, 28) };
            editor.Controls.AddRange(new Control[] { new Label { Text = "اسم المخزن", Location = new Point(655, 32), AutoSize = true }, _nameTextBox, new Label { Text = "العنوان", Location = new Point(355, 32), AutoSize = true }, _addressTextBox, _defaultCheckBox, save, fresh, archive });
            _grid.Dock = DockStyle.Fill;
            _grid.ReadOnly = true;
            _grid.AllowUserToAddRows = false;
            _grid.AutoGenerateColumns = true;
            _grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _grid.MultiSelect = false;
            _grid.CellClick += (s, e) => SelectStore();
            save.Click += (s, e) => SaveStore();
            fresh.Click += (s, e) => ClearEditor();
            archive.Click += (s, e) => ArchiveStore();
            Controls.Add(_grid);
            Controls.Add(editor);
            Controls.Add(title);
            Load += (s, e) => LoadStores();
        }

        private void LoadStores()
        {
            _grid.DataSource = _storeData.GetAllStores() ?? new List<Store>();
        }

        private void SelectStore()
        {
            var store = _grid.CurrentRow == null ? null : _grid.CurrentRow.DataBoundItem as Store;
            if (store == null) return;
            _selectedStoreId = store.Id;
            _nameTextBox.Text = store.StoreName;
            _addressTextBox.Text = store.StoreAddress;
            _defaultCheckBox.Checked = store.IsDefault;
        }

        private void ClearEditor()
        {
            _selectedStoreId = 0;
            _nameTextBox.Clear();
            _addressTextBox.Clear();
            _defaultCheckBox.Checked = false;
            _nameTextBox.Focus();
        }

        private void SaveStore()
        {
            if (string.IsNullOrWhiteSpace(_nameTextBox.Text))
            {
                MessageBox.Show("أدخل اسم المخزن.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var store = new Store { Id = _selectedStoreId, StoreName = _nameTextBox.Text.Trim(), StoreAddress = _addressTextBox.Text.Trim(), IsDefault = _defaultCheckBox.Checked };
            if (_selectedStoreId == 0) _storeData.CreateStore(store); else _storeData.EditStore(store);
            LoadStores();
            ClearEditor();
        }

        private void ArchiveStore()
        {
            if (_selectedStoreId == 0) return;
            if (MessageBox.Show("إيقاف هذا المخزن؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            _storeData.ArchiveStore(_selectedStoreId);
            LoadStores();
            ClearEditor();
        }
    }
}
