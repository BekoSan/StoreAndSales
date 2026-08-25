namespace StoreAndSalesUI.Forms
{
    partial class SalesForm
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
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowsStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle quantityStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle priceStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle deleteStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.titleLabel = new System.Windows.Forms.Label();
            this.unpaidFlagLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.saleDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.saleDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineTotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.saleDataGroupBox = new System.Windows.Forms.GroupBox();
            this.isDisscountCheckBox = new System.Windows.Forms.CheckBox();
            this.paymentTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.customerLabel = new System.Windows.Forms.Label();
            this.customersComboBox = new System.Windows.Forms.ComboBox();
            this.disscountLabel = new System.Windows.Forms.Label();
            this.disscountTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.purchaseIdLabel = new System.Windows.Forms.Label();
            this.saleIdTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.returnButton = new System.Windows.Forms.Button();

            this.saleDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetailsDataGridView)).BeginInit();
            this.saleDataGroupBox.SuspendLayout();
            this.SuspendLayout();

            // titleLabel
            this.titleLabel.AutoSize = false;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(31, 55, 82);
            this.titleLabel.Location = new System.Drawing.Point(440, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(360, 48);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "المبيعات";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // unpaidFlagLabel
            this.unpaidFlagLabel.BackColor = System.Drawing.Color.MistyRose;
            this.unpaidFlagLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unpaidFlagLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.unpaidFlagLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.unpaidFlagLabel.Location = new System.Drawing.Point(920, 20);
            this.unpaidFlagLabel.Name = "unpaidFlagLabel";
            this.unpaidFlagLabel.Size = new System.Drawing.Size(260, 34);
            this.unpaidFlagLabel.TabIndex = 20;
            this.unpaidFlagLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.unpaidFlagLabel.Visible = false;

            // saleDataGroupBox
            this.saleDataGroupBox.BackColor = System.Drawing.Color.White;
            this.saleDataGroupBox.Controls.Add(this.isDisscountCheckBox);
            this.saleDataGroupBox.Controls.Add(this.paymentTypeCheckBox);
            this.saleDataGroupBox.Controls.Add(this.notesLabel);
            this.saleDataGroupBox.Controls.Add(this.notesTextBox);
            this.saleDataGroupBox.Controls.Add(this.customerLabel);
            this.saleDataGroupBox.Controls.Add(this.customersComboBox);
            this.saleDataGroupBox.Controls.Add(this.disscountLabel);
            this.saleDataGroupBox.Controls.Add(this.disscountTextBox);
            this.saleDataGroupBox.Controls.Add(this.totalLabel);
            this.saleDataGroupBox.Controls.Add(this.totalTextBox);
            this.saleDataGroupBox.Controls.Add(this.purchaseIdLabel);
            this.saleDataGroupBox.Controls.Add(this.saleIdTextBox);
            this.saleDataGroupBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.saleDataGroupBox.ForeColor = System.Drawing.Color.FromArgb(31, 55, 82);
            this.saleDataGroupBox.Location = new System.Drawing.Point(405, 75);
            this.saleDataGroupBox.Name = "saleDataGroupBox";
            this.saleDataGroupBox.Padding = new System.Windows.Forms.Padding(10, 12, 10, 10);
            this.saleDataGroupBox.Size = new System.Drawing.Size(791, 214);
            this.saleDataGroupBox.TabIndex = 10;
            this.saleDataGroupBox.TabStop = false;
            this.saleDataGroupBox.Text = "بيانات الفاتورة";

            // saleIdTextBox
            this.saleIdTextBox.BackColor = System.Drawing.Color.FromArgb(244, 247, 250);
            this.saleIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saleIdTextBox.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.saleIdTextBox.Location = new System.Drawing.Point(650, 44);
            this.saleIdTextBox.MaxLength = 15;
            this.saleIdTextBox.Name = "saleIdTextBox";
            this.saleIdTextBox.ReadOnly = true;
            this.saleIdTextBox.Size = new System.Drawing.Size(110, 25);
            this.saleIdTextBox.TabIndex = 6;
            this.saleIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // purchaseIdLabel
            this.purchaseIdLabel.AutoSize = true;
            this.purchaseIdLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.purchaseIdLabel.ForeColor = System.Drawing.Color.FromArgb(31, 55, 82);
            this.purchaseIdLabel.Location = new System.Drawing.Point(650, 22);
            this.purchaseIdLabel.Name = "purchaseIdLabel";
            this.purchaseIdLabel.Size = new System.Drawing.Size(88, 16);
            this.purchaseIdLabel.TabIndex = 7;
            this.purchaseIdLabel.Text = "رقم الفاتورة";

            // customersComboBox
            this.customersComboBox.BackColor = System.Drawing.Color.White;
            this.customersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customersComboBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.ItemHeight = 24;
            this.customersComboBox.Location = new System.Drawing.Point(315, 43);
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(315, 30);
            this.customersComboBox.TabIndex = 12;

            // customerLabel
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customerLabel.ForeColor = System.Drawing.Color.FromArgb(31, 55, 82);
            this.customerLabel.Location = new System.Drawing.Point(530, 22);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(50, 16);
            this.customerLabel.TabIndex = 13;
            this.customerLabel.Text = "العميل";

            // totalTextBox
            this.totalTextBox.BackColor = System.Drawing.Color.FromArgb(230, 247, 241);
            this.totalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.totalTextBox.ForeColor = System.Drawing.Color.FromArgb(0, 110, 90);
            this.totalTextBox.Location = new System.Drawing.Point(160, 43);
            this.totalTextBox.MaxLength = 18;
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(140, 26);
            this.totalTextBox.TabIndex = 8;
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // totalLabel
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(31, 55, 82);
            this.totalLabel.Location = new System.Drawing.Point(198, 22);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(51, 16);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "الإجمالي";

            // disscountTextBox
            this.disscountTextBox.BackColor = System.Drawing.Color.White;
            this.disscountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.disscountTextBox.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.disscountTextBox.Location = new System.Drawing.Point(40, 43);
            this.disscountTextBox.MaxLength = 18;
            this.disscountTextBox.Name = "disscountTextBox";
            this.disscountTextBox.Size = new System.Drawing.Size(105, 25);
            this.disscountTextBox.TabIndex = 10;
            this.disscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.disscountTextBox.TextChanged += new System.EventHandler(this.disscountTextBox_TextChanged);

            // disscountLabel
            this.disscountLabel.AutoSize = true;
            this.disscountLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.disscountLabel.ForeColor = System.Drawing.Color.FromArgb(31, 55, 82);
            this.disscountLabel.Location = new System.Drawing.Point(65, 22);
            this.disscountLabel.Name = "disscountLabel";
            this.disscountLabel.Size = new System.Drawing.Size(56, 16);
            this.disscountLabel.TabIndex = 11;
            this.disscountLabel.Text = "الخصم";

            // notesTextBox
            this.notesTextBox.BackColor = System.Drawing.Color.White;
            this.notesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.notesTextBox.Location = new System.Drawing.Point(40, 112);
            this.notesTextBox.MaxLength = 2000;
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(720, 65);
            this.notesTextBox.TabIndex = 16;

            // notesLabel
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.notesLabel.ForeColor = System.Drawing.Color.FromArgb(31, 55, 82);
            this.notesLabel.Location = new System.Drawing.Point(650, 90);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(68, 16);
            this.notesLabel.TabIndex = 17;
            this.notesLabel.Text = "الملاحظات";

            // paymentTypeCheckBox
            this.paymentTypeCheckBox.AutoSize = false;
            this.paymentTypeCheckBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.paymentTypeCheckBox.Location = new System.Drawing.Point(215, 179);
            this.paymentTypeCheckBox.Name = "paymentTypeCheckBox";
            this.paymentTypeCheckBox.Size = new System.Drawing.Size(100, 28);
            this.paymentTypeCheckBox.TabIndex = 18;
            this.paymentTypeCheckBox.Text = "بنكك";
            this.paymentTypeCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // isDisscountCheckBox
            this.isDisscountCheckBox.AutoSize = false;
            this.isDisscountCheckBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.isDisscountCheckBox.Location = new System.Drawing.Point(105, 179);
            this.isDisscountCheckBox.Name = "isDisscountCheckBox";
            this.isDisscountCheckBox.Size = new System.Drawing.Size(100, 28);
            this.isDisscountCheckBox.TabIndex = 19;
            this.isDisscountCheckBox.Text = "مجاملة";
            this.isDisscountCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // saleDetailsGroupBox
            this.saleDetailsGroupBox.BackColor = System.Drawing.Color.White;
            this.saleDetailsGroupBox.Controls.Add(this.addItemButton);
            this.saleDetailsGroupBox.Controls.Add(this.saleDetailsDataGridView);
            this.saleDetailsGroupBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.saleDetailsGroupBox.ForeColor = System.Drawing.Color.FromArgb(31, 55, 82);
            this.saleDetailsGroupBox.Location = new System.Drawing.Point(405, 302);
            this.saleDetailsGroupBox.Name = "saleDetailsGroupBox";
            this.saleDetailsGroupBox.Padding = new System.Windows.Forms.Padding(10, 25, 10, 10);
            this.saleDetailsGroupBox.Size = new System.Drawing.Size(791, 390);
            this.saleDetailsGroupBox.TabIndex = 11;
            this.saleDetailsGroupBox.TabStop = false;
            this.saleDetailsGroupBox.Text = "تفاصيل الفاتورة";

            // addItemButton
            this.addItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemButton.BackColor = System.Drawing.Color.FromArgb(0, 148, 136);
            this.addItemButton.FlatAppearance.BorderSize = 0;
            this.addItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.addItemButton.ForeColor = System.Drawing.Color.White;
            this.addItemButton.Location = new System.Drawing.Point(740, 2);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(32, 28);
            this.addItemButton.TabIndex = 4;
            this.addItemButton.Text = "+";
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Visible = false;

            // saleDetailsDataGridView
            this.saleDetailsDataGridView.AllowUserToAddRows = false;
            this.saleDetailsDataGridView.AllowUserToDeleteRows = false;
            this.saleDetailsDataGridView.AllowUserToResizeColumns = false;
            this.saleDetailsDataGridView.AllowUserToResizeRows = false;
            this.saleDetailsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.saleDetailsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.saleDetailsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.saleDetailsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.saleDetailsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(31, 55, 82);
            headerStyle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.SelectionBackColor = System.Drawing.Color.FromArgb(31, 55, 82);
            headerStyle.SelectionForeColor = System.Drawing.Color.White;
            headerStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.saleDetailsDataGridView.ColumnHeadersDefaultCellStyle = headerStyle;
            this.saleDetailsDataGridView.ColumnHeadersHeight = 36;
            this.saleDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.saleDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.itemNameColumn,
            this.unitColumn,
            this.quantityColumn,
            this.unitPriceColumn,
            this.unitIdColumn,
            this.lineTotalColumn,
            this.colDelete});
            this.saleDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saleDetailsDataGridView.EnableHeadersVisualStyles = false;
            this.saleDetailsDataGridView.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.saleDetailsDataGridView.Location = new System.Drawing.Point(13, 38);
            this.saleDetailsDataGridView.MultiSelect = false;
            this.saleDetailsDataGridView.Name = "saleDetailsDataGridView";
            rowHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            rowHeaderStyle.BackColor = System.Drawing.Color.FromArgb(31, 55, 82);
            rowHeaderStyle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            rowHeaderStyle.ForeColor = System.Drawing.Color.White;
            rowHeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(31, 55, 82);
            rowHeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            rowHeaderStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.saleDetailsDataGridView.RowHeadersDefaultCellStyle = rowHeaderStyle;
            this.saleDetailsDataGridView.RowHeadersVisible = false;
            rowsStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            rowsStyle.BackColor = System.Drawing.Color.White;
            rowsStyle.Font = new System.Drawing.Font("Arial", 10F);
            rowsStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            rowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(211, 239, 235);
            rowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(31, 55, 82);
            this.saleDetailsDataGridView.RowsDefaultCellStyle = rowsStyle;
            this.saleDetailsDataGridView.RowTemplate.Height = 34;
            this.saleDetailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.saleDetailsDataGridView.Size = new System.Drawing.Size(765, 342);
            this.saleDetailsDataGridView.TabIndex = 3;
            this.saleDetailsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.saleDetailsDataGridView_CellContentClick);
            this.saleDetailsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.saleDetailsDataGridView_CellValueChanged);
            this.saleDetailsDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.saleDetailsDataGridView_RowPostPaint);

            // IdColumn
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Visible = false;

            // itemNameColumn
            this.itemNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemNameColumn.FillWeight = 250F;
            this.itemNameColumn.HeaderText = "الصنف";
            this.itemNameColumn.MinimumWidth = 120;
            this.itemNameColumn.Name = "itemNameColumn";
            this.itemNameColumn.ReadOnly = true;

            // unitColumn
            this.unitColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.unitColumn.HeaderText = "الوحدة";
            this.unitColumn.MinimumWidth = 85;
            this.unitColumn.Name = "unitColumn";
            this.unitColumn.ReadOnly = true;
            this.unitColumn.Width = 115;

            // quantityColumn
            this.quantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            quantityStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            quantityStyle.Format = "N0";
            quantityStyle.NullValue = 0;
            this.quantityColumn.DefaultCellStyle = quantityStyle;
            this.quantityColumn.HeaderText = "الكمية";
            this.quantityColumn.MinimumWidth = 70;
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.ValueType = typeof(int);
            this.quantityColumn.Width = 85;

            // unitPriceColumn
            this.unitPriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            priceStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            priceStyle.Format = "N0";
            this.unitPriceColumn.DefaultCellStyle = priceStyle;
            this.unitPriceColumn.HeaderText = "السعر";
            this.unitPriceColumn.MinimumWidth = 85;
            this.unitPriceColumn.Name = "unitPriceColumn";
            this.unitPriceColumn.ReadOnly = true;
            this.unitPriceColumn.Width = 105;

            // unitIdColumn
            this.unitIdColumn.HeaderText = "unitId";
            this.unitIdColumn.MinimumWidth = 6;
            this.unitIdColumn.Name = "unitIdColumn";
            this.unitIdColumn.Visible = false;

            // lineTotalColumn
            this.lineTotalColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lineTotalColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.lineTotalColumn.DefaultCellStyle.Format = "N2";
            this.lineTotalColumn.HeaderText = "الإجمالي";
            this.lineTotalColumn.MinimumWidth = 95;
            this.lineTotalColumn.Name = "lineTotalColumn";
            this.lineTotalColumn.ReadOnly = true;
            this.lineTotalColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.lineTotalColumn.Width = 115;

            // colDelete
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            deleteStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            deleteStyle.BackColor = System.Drawing.Color.FromArgb(255, 244, 244);
            deleteStyle.ForeColor = System.Drawing.Color.FromArgb(176, 48, 48);
            deleteStyle.NullValue = "حذف";
            this.colDelete.DefaultCellStyle = deleteStyle;
            this.colDelete.HeaderText = "";
            this.colDelete.MinimumWidth = 55;
            this.colDelete.Name = "colDelete";
            this.colDelete.Width = 65;

            // panel1
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(24, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 617);
            this.panel1.TabIndex = 12;

            // footer buttons
            this.newButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newButton.BackColor = System.Drawing.Color.FromArgb(79, 110, 145);
            this.newButton.FlatAppearance.BorderSize = 0;
            this.newButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(57, 84, 116);
            this.newButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 94, 126);
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.newButton.ForeColor = System.Drawing.Color.White;
            this.newButton.Location = new System.Drawing.Point(405, 710);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(138, 40);
            this.newButton.TabIndex = 5;
            this.newButton.Text = "جديد";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);

            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(0, 148, 136);
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 105, 92);
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 121, 107);
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(555, 710);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(138, 40);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "حفظ";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);

            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(31, 55, 82);
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(18, 36, 57);
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(25, 45, 68);
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(705, 710);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(138, 40);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "بحث عن فاتورة";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);

            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.BackColor = System.Drawing.Color.FromArgb(92, 80, 150);
            this.printButton.Enabled = false;
            this.printButton.FlatAppearance.BorderSize = 0;
            this.printButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(66, 56, 110);
            this.printButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(78, 68, 129);
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Location = new System.Drawing.Point(855, 710);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(138, 40);
            this.printButton.TabIndex = 9;
            this.printButton.Text = "طباعة";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);

            this.returnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.returnButton.BackColor = System.Drawing.Color.FromArgb(219, 132, 45);
            this.returnButton.Enabled = false;
            this.returnButton.FlatAppearance.BorderSize = 0;
            this.returnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(167, 92, 21);
            this.returnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(193, 108, 27);
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(1005, 710);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(138, 40);
            this.returnButton.TabIndex = 13;
            this.returnButton.Text = "مرتجع";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);

         
            // SalesForm
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1220, 770);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saleDetailsGroupBox);
            this.Controls.Add(this.saleDataGroupBox);
            this.Controls.Add(this.unpaidFlagLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المبيعات";
            this.Load += new System.EventHandler(this.SalesForm_Load);

            this.saleDetailsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.saleDetailsDataGridView)).EndInit();
            this.saleDataGroupBox.ResumeLayout(false);
            this.saleDataGroupBox.PerformLayout();

            // DIRECT_GRID_COLORS_BEGIN
            // ألوان مباشرة داخل المصمم لضمان ظهور النص بوضوح في Visual Studio Designer.
            this.saleDetailsDataGridView.EnableHeadersVisualStyles = false;
            this.saleDetailsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.saleDetailsDataGridView.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.saleDetailsDataGridView.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.saleDetailsDataGridView.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.saleDetailsDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.saleDetailsDataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.saleDetailsDataGridView.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.saleDetailsDataGridView.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.saleDetailsDataGridView.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.saleDetailsDataGridView.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.saleDetailsDataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.saleDetailsDataGridView.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.saleDetailsDataGridView.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.saleDetailsDataGridView.AlternatingRowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.saleDetailsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(31, 55, 82);
            this.saleDetailsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.saleDetailsDataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(31, 55, 82);
            this.saleDetailsDataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            // Direct column styles for Visual Studio WinForms Designer.
            this.IdColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.IdColumn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.IdColumn.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.itemNameColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.itemNameColumn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.itemNameColumn.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.unitColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.unitColumn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.unitColumn.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.quantityColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.quantityColumn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.quantityColumn.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.unitPriceColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.unitPriceColumn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.unitPriceColumn.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.unitIdColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.unitIdColumn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.unitIdColumn.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.colDelete.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.colDelete.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.colDelete.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.colDelete.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.colDelete.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(31, 55, 82);
            this.colDelete.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.colDelete.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            // DIRECT_GRID_COLORS_END
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label unpaidFlagLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.GroupBox saleDetailsGroupBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.DataGridView saleDetailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineTotalColumn;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.GroupBox saleDataGroupBox;
        private System.Windows.Forms.CheckBox isDisscountCheckBox;
        private System.Windows.Forms.CheckBox paymentTypeCheckBox;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.ComboBox customersComboBox;
        private System.Windows.Forms.Label disscountLabel;
        private System.Windows.Forms.TextBox disscountTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label purchaseIdLabel;
        private System.Windows.Forms.TextBox saleIdTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button returnButton;
    }
}
