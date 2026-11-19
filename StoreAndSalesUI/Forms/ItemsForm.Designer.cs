namespace StoreAndSalesUI.Forms
{
    partial class ItemsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titleLabel = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.itemUnitsDataGridView = new System.Windows.Forms.DataGridView();

            this.unitIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemUnitIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.reorderLevelLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();

            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemSerialColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGroupBox = new System.Windows.Forms.GroupBox();

            this.addUnitButton = new System.Windows.Forms.Button();
            this.itemsListGroupBox = new System.Windows.Forms.GroupBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.hasExpiryDateCheckBox = new System.Windows.Forms.CheckBox();
            this.expiryDateLabel = new System.Windows.Forms.Label();
            this.expiryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.expiryAlertDaysLabel = new System.Windows.Forms.Label();
            this.expiryAlertDaysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.itemUnitsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expiryAlertDaysNumericUpDown)).BeginInit();
            this.itemDataGroupBox.SuspendLayout();
            this.itemsListGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 35F);
            this.titleLabel.Location = new System.Drawing.Point(109, 11);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(245, 66);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "الأصنــــاف";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemNameTextBox.Location = new System.Drawing.Point(6, 52);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(433, 29);
            this.itemNameTextBox.TabIndex = 0;
            //
            // reorderLevelTextBox
            //
            this.reorderLevelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reorderLevelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reorderLevelTextBox.Location = new System.Drawing.Point(6, 88);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.Size = new System.Drawing.Size(130, 29);
            this.reorderLevelTextBox.TabIndex = 1;
            this.reorderLevelTextBox.Text = "0";
            this.reorderLevelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.reorderLevelTextBox_KeyPress);
            //
            // itemUnitsDataGridView

            // 
            this.itemUnitsDataGridView.AllowUserToAddRows = false;
            this.itemUnitsDataGridView.AllowUserToDeleteRows = false;
            this.itemUnitsDataGridView.AllowUserToResizeColumns = false;
            this.itemUnitsDataGridView.AllowUserToResizeRows = false;
            this.itemUnitsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemUnitsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemUnitsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.itemUnitsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemUnitsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemUnitsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.itemUnitsDataGridView.ColumnHeadersHeight = 29;
            this.itemUnitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.itemUnitsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unitIdColumn,
            this.itemUnitIdColumn,
            this.unitNameColumn,
            this.unitPriceColumn});
            this.itemUnitsDataGridView.EnableHeadersVisualStyles = false;
            this.itemUnitsDataGridView.GridColor = System.Drawing.Color.Black;
            this.itemUnitsDataGridView.Location = new System.Drawing.Point(6, 243);
            this.itemUnitsDataGridView.Name = "itemUnitsDataGridView";
            this.itemUnitsDataGridView.RowHeadersVisible = false;
            this.itemUnitsDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.itemUnitsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.itemUnitsDataGridView.RowTemplate.Height = 24;
            this.itemUnitsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemUnitsDataGridView.Size = new System.Drawing.Size(433, 180);
            this.itemUnitsDataGridView.TabIndex = 2;
            // 
            // unitIdColumn
            // 
            this.unitIdColumn.HeaderText = "ID";
            this.unitIdColumn.MinimumWidth = 6;
            this.unitIdColumn.Name = "unitIdColumn";
            this.unitIdColumn.Visible = false;
            // 
            // itemUnitIdColumn
            // 
            this.itemUnitIdColumn.HeaderText = "ItemUnitId";
            this.itemUnitIdColumn.MinimumWidth = 6;
            this.itemUnitIdColumn.Name = "itemUnitIdColumn";
            this.itemUnitIdColumn.Visible = false;
            // 
            // unitNameColumn
            // 
            this.unitNameColumn.HeaderText = "الوحدة";
            this.unitNameColumn.MinimumWidth = 6;
            this.unitNameColumn.Name = "unitNameColumn";
            this.unitNameColumn.ReadOnly = true;
            // 
            // unitPriceColumn
            // 
            this.unitPriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.unitPriceColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.unitPriceColumn.HeaderText = "السعـــر";
            this.unitPriceColumn.MinimumWidth = 6;
            this.unitPriceColumn.Name = "unitPriceColumn";
            this.unitPriceColumn.Width = 95;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.itemNameLabel.Location = new System.Drawing.Point(364, 30);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(73, 19);
            this.itemNameLabel.TabIndex = 5;
            this.itemNameLabel.Text = "إسم الصنف";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(352, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "وحدات الصنف";
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.AllowUserToAddRows = false;
            this.itemsDataGridView.AllowUserToDeleteRows = false;
            this.itemsDataGridView.AllowUserToResizeColumns = false;
            this.itemsDataGridView.AllowUserToResizeRows = false;
            this.itemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.itemsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.ColumnHeadersVisible = true;
            this.itemsDataGridView.ColumnHeadersHeight = 29;
            this.itemsDataGridView.EnableHeadersVisualStyles = false;

            this.itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.itemNameColumn,
            this.quantityColumn,
            this.expiryStatusColumn,
            this.itemSerialColumn});

            this.itemsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.itemsDataGridView.GridColor = System.Drawing.Color.FromArgb(225, 230, 235);
            this.itemsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(47, 84, 120);
            this.itemsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.itemsDataGridView.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.itemsDataGridView.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.itemsDataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);

            this.itemsDataGridView.Location = new System.Drawing.Point(3, 82);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.ReadOnly = true;
            this.itemsDataGridView.RowHeadersVisible = false;
            this.itemsDataGridView.RowHeadersWidth = 51;
            this.itemsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.itemsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.itemsDataGridView.RowTemplate.Height = 24;
            this.itemsDataGridView.Size = new System.Drawing.Size(444, 157);
            this.itemsDataGridView.TabIndex = 0;
            this.itemsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDataGridView_CellContentClick);
            this.itemsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.itemsDataGridView_CellFormatting);
            this.itemsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.itemsDataGridView_DataError);

            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "...";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            // 
            // itemNameColumn
            // 
            this.itemNameColumn.DataPropertyName = "ItemName";
            this.itemNameColumn.HeaderText = "إسم الصنف";
            this.itemNameColumn.MinimumWidth = 6;
            this.itemNameColumn.Name = "itemNameColumn";
            this.itemNameColumn.ReadOnly = true;
            //
            // quantityColumn
            //
            this.quantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.quantityColumn.HeaderText = "الكمية";
            this.quantityColumn.MinimumWidth = 6;
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.ValueType = typeof(string);
            this.quantityColumn.ReadOnly = true;
            this.quantityColumn.Width = 95;
            //
            // expiryStatusColumn
            //
            this.expiryStatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.expiryStatusColumn.HeaderText = "الصلاحية";
            this.expiryStatusColumn.MinimumWidth = 6;
            this.expiryStatusColumn.Name = "expiryStatusColumn";
            this.expiryStatusColumn.ReadOnly = true;
            this.expiryStatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.expiryStatusColumn.Width = 120;
            //
            // itemSerialColumn
            //
            this.itemSerialColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.itemSerialColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.itemSerialColumn.HeaderText = "م";
            this.itemSerialColumn.MinimumWidth = 6;
            this.itemSerialColumn.Name = "itemSerialColumn";
            this.itemSerialColumn.ReadOnly = true;
            this.itemSerialColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.itemSerialColumn.Width = 45;
            //
            // reorderLevelLabel
            //
            this.reorderLevelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reorderLevelLabel.AutoSize = true;
            this.reorderLevelLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.reorderLevelLabel.Location = new System.Drawing.Point(145, 95);
            this.reorderLevelLabel.Name = "reorderLevelLabel";
            this.reorderLevelLabel.Size = new System.Drawing.Size(198, 19);
            this.reorderLevelLabel.TabIndex = 10;
            this.reorderLevelLabel.Text = "حد إعادة الطلب";
            //
            // itemDataGroupBox

            // 
            this.itemDataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemDataGroupBox.Controls.Add(this.addUnitButton);
            this.itemDataGroupBox.Controls.Add(this.expiryAlertDaysNumericUpDown);
            this.itemDataGroupBox.Controls.Add(this.expiryAlertDaysLabel);
            this.itemDataGroupBox.Controls.Add(this.expiryDateTimePicker);
            this.itemDataGroupBox.Controls.Add(this.expiryDateLabel);
            this.itemDataGroupBox.Controls.Add(this.hasExpiryDateCheckBox);
            this.itemDataGroupBox.Controls.Add(this.reorderLevelLabel);
            this.itemDataGroupBox.Controls.Add(this.reorderLevelTextBox);
            this.itemDataGroupBox.Controls.Add(this.itemNameLabel);
            this.itemDataGroupBox.Controls.Add(this.itemNameTextBox);

            this.itemDataGroupBox.Controls.Add(this.label3);
            this.itemDataGroupBox.Controls.Add(this.itemUnitsDataGridView);
            this.itemDataGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.itemDataGroupBox.Location = new System.Drawing.Point(5, 84);
            this.itemDataGroupBox.Name = "itemDataGroupBox";
            this.itemDataGroupBox.Size = new System.Drawing.Size(450, 428);
            this.itemDataGroupBox.TabIndex = 0;
            this.itemDataGroupBox.TabStop = false;
            this.itemDataGroupBox.Text = "بيانات الصنف";
            // 
            // addUnitButton
            // 
            this.addUnitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addUnitButton.FlatAppearance.BorderSize = 0;
            this.addUnitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUnitButton.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.addUnitButton.Location = new System.Drawing.Point(320, 212);
            this.addUnitButton.Name = "addUnitButton";
            this.addUnitButton.Size = new System.Drawing.Size(25, 25);
            this.addUnitButton.TabIndex = 1;
            this.addUnitButton.Text = "+";
            this.addUnitButton.UseVisualStyleBackColor = true;
            this.addUnitButton.Click += new System.EventHandler(this.addUnitButton_Click);
            //
            // hasExpiryDateCheckBox
            //
            this.hasExpiryDateCheckBox.AutoSize = true;
            this.hasExpiryDateCheckBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.hasExpiryDateCheckBox.Location = new System.Drawing.Point(244, 121);
            this.hasExpiryDateCheckBox.Name = "hasExpiryDateCheckBox";
            this.hasExpiryDateCheckBox.Size = new System.Drawing.Size(195, 23);
            this.hasExpiryDateCheckBox.TabIndex = 12;
            this.hasExpiryDateCheckBox.Text = "هذا الصنف له تاريخ صلاحية";
            this.hasExpiryDateCheckBox.UseVisualStyleBackColor = true;
            this.hasExpiryDateCheckBox.CheckedChanged += new System.EventHandler(this.hasExpiryDateCheckBox_CheckedChanged);
            //
            // expiryDateLabel
            //
            this.expiryDateLabel.AutoSize = true;
            this.expiryDateLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.expiryDateLabel.Location = new System.Drawing.Point(285, 155);
            this.expiryDateLabel.Name = "expiryDateLabel";
            this.expiryDateLabel.Size = new System.Drawing.Size(153, 19);
            this.expiryDateLabel.TabIndex = 13;
            this.expiryDateLabel.Text = "تاريخ انتهاء الصلاحية";
            //
            // expiryDateTimePicker
            //
            this.expiryDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.expiryDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expiryDateTimePicker.Location = new System.Drawing.Point(79, 151);
            this.expiryDateTimePicker.Name = "expiryDateTimePicker";
            this.expiryDateTimePicker.RightToLeftLayout = true;
            this.expiryDateTimePicker.Size = new System.Drawing.Size(196, 29);
            this.expiryDateTimePicker.TabIndex = 13;
            //
            // expiryAlertDaysLabel
            //
            this.expiryAlertDaysLabel.AutoSize = true;
            this.expiryAlertDaysLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.expiryAlertDaysLabel.Location = new System.Drawing.Point(230, 188);
            this.expiryAlertDaysLabel.Name = "expiryAlertDaysLabel";
            this.expiryAlertDaysLabel.Size = new System.Drawing.Size(208, 19);
            this.expiryAlertDaysLabel.TabIndex = 14;
            this.expiryAlertDaysLabel.Text = "التنبيه قبل الانتهاء (بالأيام)";
            //
            // expiryAlertDaysNumericUpDown
            //
            this.expiryAlertDaysNumericUpDown.Location = new System.Drawing.Point(79, 184);
            this.expiryAlertDaysNumericUpDown.Maximum = new decimal(new int[] { 3650, 0, 0, 0 });
            this.expiryAlertDaysNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.expiryAlertDaysNumericUpDown.Name = "expiryAlertDaysNumericUpDown";
            this.expiryAlertDaysNumericUpDown.Size = new System.Drawing.Size(132, 29);
            this.expiryAlertDaysNumericUpDown.TabIndex = 14;
            this.expiryAlertDaysNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.expiryAlertDaysNumericUpDown.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // itemsListGroupBox
            // 
            this.itemsListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsListGroupBox.Controls.Add(this.searchLabel);
            this.itemsListGroupBox.Controls.Add(this.searchTextBox);
            this.itemsListGroupBox.Controls.Add(this.itemsDataGridView);
            this.itemsListGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.itemsListGroupBox.Location = new System.Drawing.Point(5, 514);
            this.itemsListGroupBox.Name = "itemsListGroupBox";
            this.itemsListGroupBox.Size = new System.Drawing.Size(450, 242);
            this.itemsListGroupBox.TabIndex = 1;
            this.itemsListGroupBox.TabStop = false;
            this.itemsListGroupBox.Text = "قائمة الأصناف";
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.searchLabel.Location = new System.Drawing.Point(409, 51);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(34, 19);
            this.searchLabel.TabIndex = 8;
            this.searchLabel.Text = "بحث";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Location = new System.Drawing.Point(25, 47);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(361, 29);
            this.searchTextBox.TabIndex = 7;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // newButton
            // 
            this.newButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.newButton.Location = new System.Drawing.Point(60, 762);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(118, 33);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "جديد";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(182, 762);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 33);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "حفــــظ";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.deleteButton.Location = new System.Drawing.Point(304, 762);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(118, 33);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "حـــذف";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ItemsForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 805);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.itemsListGroupBox);
            this.Controls.Add(this.itemDataGroupBox);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الأصنــــاف";
            this.Load += new System.EventHandler(this.ItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemUnitsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expiryAlertDaysNumericUpDown)).EndInit();
            this.itemDataGroupBox.ResumeLayout(false);
            this.itemDataGroupBox.PerformLayout();
            this.itemsListGroupBox.ResumeLayout(false);
            this.itemsListGroupBox.PerformLayout();

            // DIRECT_GRID_COLORS_BEGIN
            // ألوان مباشرة داخل المصمم لضمان ظهور النص بوضوح في Visual Studio Designer.
            this.itemUnitsDataGridView.EnableHeadersVisualStyles = false;
            this.itemUnitsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.itemUnitsDataGridView.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.itemUnitsDataGridView.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.itemUnitsDataGridView.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.itemUnitsDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.itemUnitsDataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.itemUnitsDataGridView.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.itemUnitsDataGridView.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.itemUnitsDataGridView.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.itemUnitsDataGridView.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.itemUnitsDataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.itemUnitsDataGridView.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.itemUnitsDataGridView.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.itemUnitsDataGridView.AlternatingRowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.itemUnitsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(31, 55, 82);
            this.itemUnitsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.itemUnitsDataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(31, 55, 82);
            this.itemUnitsDataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            // Direct column styles for Visual Studio WinForms Designer.
            this.unitIdColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.unitIdColumn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.unitIdColumn.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.itemUnitIdColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.itemUnitIdColumn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.itemUnitIdColumn.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.unitNameColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.unitNameColumn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.unitNameColumn.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.unitPriceColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.unitPriceColumn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.unitPriceColumn.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            // DIRECT_GRID_COLORS_END

            // DIRECT_GRID_COLORS_BEGIN
            // ألوان مباشرة داخل المصمم لضمان ظهور النص بوضوح في Visual Studio Designer.
            this.itemsDataGridView.EnableHeadersVisualStyles = false;
            this.itemsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.itemsDataGridView.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.itemsDataGridView.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.itemsDataGridView.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.itemsDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.itemsDataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.itemsDataGridView.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.itemsDataGridView.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.itemsDataGridView.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.itemsDataGridView.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.itemsDataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.itemsDataGridView.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.itemsDataGridView.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.itemsDataGridView.AlternatingRowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.itemsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(31, 55, 82);
            this.itemsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.itemsDataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(31, 55, 82);
            this.itemsDataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            // Direct column styles for Visual Studio WinForms Designer.
            this.IdColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.IdColumn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.IdColumn.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.itemNameColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.itemNameColumn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.itemNameColumn.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.quantityColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.quantityColumn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.quantityColumn.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.expiryStatusColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.expiryStatusColumn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.expiryStatusColumn.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.itemSerialColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.itemSerialColumn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.itemSerialColumn.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            // DIRECT_GRID_COLORS_END
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox reorderLevelTextBox;

        private System.Windows.Forms.DataGridView itemUnitsDataGridView;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label reorderLevelLabel;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.GroupBox itemDataGroupBox;
        private System.Windows.Forms.GroupBox itemsListGroupBox;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addUnitButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemSerialColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn unitIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemUnitIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceColumn;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.CheckBox hasExpiryDateCheckBox;
        private System.Windows.Forms.Label expiryDateLabel;
        private System.Windows.Forms.DateTimePicker expiryDateTimePicker;
        private System.Windows.Forms.Label expiryAlertDaysLabel;
        private System.Windows.Forms.NumericUpDown expiryAlertDaysNumericUpDown;
    }
}
