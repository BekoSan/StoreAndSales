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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.storeLabel = new System.Windows.Forms.Label();
            this.storesComboBox = new System.Windows.Forms.ComboBox();
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
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.titleLabel.Location = new System.Drawing.Point(440, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(360, 48);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "المبيعات";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unpaidFlagLabel
            // 
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
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(57)))));
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
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
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
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
            // 
            // newButton
            // 
            this.newButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(110)))), ((int)(((byte)(145)))));
            this.newButton.FlatAppearance.BorderSize = 0;
            this.newButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(84)))), ((int)(((byte)(116)))));
            this.newButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(126)))));
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
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.printButton.Enabled = false;
            this.printButton.FlatAppearance.BorderSize = 0;
            this.printButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(56)))), ((int)(((byte)(110)))));
            this.printButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(68)))), ((int)(((byte)(129)))));
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
            // 
            // saleDetailsGroupBox
            // 
            this.saleDetailsGroupBox.BackColor = System.Drawing.Color.White;
            this.saleDetailsGroupBox.Controls.Add(this.addItemButton);
            this.saleDetailsGroupBox.Controls.Add(this.saleDetailsDataGridView);
            this.saleDetailsGroupBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.saleDetailsGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.saleDetailsGroupBox.Location = new System.Drawing.Point(405, 302);
            this.saleDetailsGroupBox.Name = "saleDetailsGroupBox";
            this.saleDetailsGroupBox.Padding = new System.Windows.Forms.Padding(10, 25, 10, 10);
            this.saleDetailsGroupBox.Size = new System.Drawing.Size(791, 390);
            this.saleDetailsGroupBox.TabIndex = 11;
            this.saleDetailsGroupBox.TabStop = false;
            this.saleDetailsGroupBox.Text = "تفاصيل الفاتورة";
            // 
            // addItemButton
            // 
            this.addItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
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
            // 
            // saleDetailsDataGridView
            // 
            this.saleDetailsDataGridView.AllowUserToAddRows = false;
            this.saleDetailsDataGridView.AllowUserToDeleteRows = false;
            this.saleDetailsDataGridView.AllowUserToResizeColumns = false;
            this.saleDetailsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.saleDetailsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.saleDetailsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.saleDetailsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.saleDetailsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.saleDetailsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.saleDetailsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.saleDetailsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.saleDetailsDataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.saleDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saleDetailsDataGridView.EnableHeadersVisualStyles = false;
            this.saleDetailsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.saleDetailsDataGridView.Location = new System.Drawing.Point(10, 45);
            this.saleDetailsDataGridView.MultiSelect = false;
            this.saleDetailsDataGridView.Name = "saleDetailsDataGridView";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.saleDetailsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.saleDetailsDataGridView.RowHeadersVisible = false;
            this.saleDetailsDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.saleDetailsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.saleDetailsDataGridView.RowTemplate.Height = 34;
            this.saleDetailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.saleDetailsDataGridView.Size = new System.Drawing.Size(771, 335);
            this.saleDetailsDataGridView.TabIndex = 3;
            this.saleDetailsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.saleDetailsDataGridView_CellContentClick);
            this.saleDetailsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.saleDetailsDataGridView_CellValueChanged);
            this.saleDetailsDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.saleDetailsDataGridView_RowPostPaint);
            // 
            // IdColumn
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.IdColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Visible = false;
            // 
            // itemNameColumn
            // 
            this.itemNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.itemNameColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.itemNameColumn.FillWeight = 250F;
            this.itemNameColumn.HeaderText = "الصنف";
            this.itemNameColumn.MinimumWidth = 120;
            this.itemNameColumn.Name = "itemNameColumn";
            this.itemNameColumn.ReadOnly = true;
            // 
            // unitColumn
            // 
            this.unitColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.unitColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.unitColumn.HeaderText = "الوحدة";
            this.unitColumn.MinimumWidth = 85;
            this.unitColumn.Name = "unitColumn";
            this.unitColumn.ReadOnly = true;
            this.unitColumn.Width = 115;
            // 
            // quantityColumn
            // 
            this.quantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = 0;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.quantityColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.quantityColumn.HeaderText = "الكمية";
            this.quantityColumn.MinimumWidth = 70;
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.Width = 85;
            // 
            // unitPriceColumn
            // 
            this.unitPriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.unitPriceColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.unitPriceColumn.HeaderText = "السعر";
            this.unitPriceColumn.MinimumWidth = 85;
            this.unitPriceColumn.Name = "unitPriceColumn";
            this.unitPriceColumn.ReadOnly = true;
            this.unitPriceColumn.Width = 105;
            // 
            // unitIdColumn
            // 
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.unitIdColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.unitIdColumn.HeaderText = "unitId";
            this.unitIdColumn.MinimumWidth = 6;
            this.unitIdColumn.Name = "unitIdColumn";
            this.unitIdColumn.Visible = false;
            // 
            // lineTotalColumn
            // 
            this.lineTotalColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "N2";
            this.lineTotalColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.lineTotalColumn.HeaderText = "الإجمالي";
            this.lineTotalColumn.MinimumWidth = 95;
            this.lineTotalColumn.Name = "lineTotalColumn";
            this.lineTotalColumn.ReadOnly = true;
            this.lineTotalColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.lineTotalColumn.Width = 115;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle10.NullValue = "حذف";
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle10;
            this.colDelete.HeaderText = "";
            this.colDelete.MinimumWidth = 55;
            this.colDelete.Name = "colDelete";
            this.colDelete.Width = 65;
            // 
            // saleDataGroupBox
            // 
            this.saleDataGroupBox.BackColor = System.Drawing.Color.White;
            this.saleDataGroupBox.Controls.Add(this.isDisscountCheckBox);
            this.saleDataGroupBox.Controls.Add(this.paymentTypeCheckBox);
            this.saleDataGroupBox.Controls.Add(this.notesLabel);
            this.saleDataGroupBox.Controls.Add(this.notesTextBox);
            this.saleDataGroupBox.Controls.Add(this.customerLabel);
            this.saleDataGroupBox.Controls.Add(this.customersComboBox);
            this.saleDataGroupBox.Controls.Add(this.storeLabel);
            this.saleDataGroupBox.Controls.Add(this.storesComboBox);
            this.saleDataGroupBox.Controls.Add(this.disscountLabel);
            this.saleDataGroupBox.Controls.Add(this.disscountTextBox);
            this.saleDataGroupBox.Controls.Add(this.totalLabel);
            this.saleDataGroupBox.Controls.Add(this.totalTextBox);
            this.saleDataGroupBox.Controls.Add(this.purchaseIdLabel);
            this.saleDataGroupBox.Controls.Add(this.saleIdTextBox);
            this.saleDataGroupBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.saleDataGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.saleDataGroupBox.Location = new System.Drawing.Point(405, 75);
            this.saleDataGroupBox.Name = "saleDataGroupBox";
            this.saleDataGroupBox.Padding = new System.Windows.Forms.Padding(10, 12, 10, 10);
            this.saleDataGroupBox.Size = new System.Drawing.Size(791, 214);
            this.saleDataGroupBox.TabIndex = 10;
            this.saleDataGroupBox.TabStop = false;
            this.saleDataGroupBox.Text = "بيانات الفاتورة";
            // 
            // isDisscountCheckBox
            // 
            this.isDisscountCheckBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.isDisscountCheckBox.Location = new System.Drawing.Point(7, 156);
            this.isDisscountCheckBox.Name = "isDisscountCheckBox";
            this.isDisscountCheckBox.Size = new System.Drawing.Size(73, 28);
            this.isDisscountCheckBox.TabIndex = 19;
            this.isDisscountCheckBox.Text = "مجاملة";
            this.isDisscountCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paymentTypeCheckBox
            // 
            this.paymentTypeCheckBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.paymentTypeCheckBox.Location = new System.Drawing.Point(14, 131);
            this.paymentTypeCheckBox.Name = "paymentTypeCheckBox";
            this.paymentTypeCheckBox.Size = new System.Drawing.Size(66, 28);
            this.paymentTypeCheckBox.TabIndex = 18;
            this.paymentTypeCheckBox.Text = "بنكك";
            this.paymentTypeCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.notesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.notesLabel.Location = new System.Drawing.Point(650, 111);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(66, 19);
            this.notesLabel.TabIndex = 17;
            this.notesLabel.Text = "الملاحظات";
            // 
            // notesTextBox
            // 
            this.notesTextBox.BackColor = System.Drawing.Color.White;
            this.notesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.notesTextBox.Location = new System.Drawing.Point(87, 133);
            this.notesTextBox.MaxLength = 2000;
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(673, 65);
            this.notesTextBox.TabIndex = 16;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.customerLabel.Location = new System.Drawing.Point(530, 22);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(43, 19);
            this.customerLabel.TabIndex = 13;
            this.customerLabel.Text = "العميل";
            // 
            // customersComboBox
            // 
            this.customersComboBox.BackColor = System.Drawing.Color.White;
            this.customersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customersComboBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.ItemHeight = 19;
            this.customersComboBox.Location = new System.Drawing.Point(315, 43);
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(315, 27);
            this.customersComboBox.TabIndex = 12;
            // 
            // storeLabel
            // 
            this.storeLabel.AutoSize = true;
            this.storeLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.storeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.storeLabel.Location = new System.Drawing.Point(528, 73);
            this.storeLabel.Name = "storeLabel";
            this.storeLabel.Size = new System.Drawing.Size(49, 19);
            this.storeLabel.TabIndex = 20;
            this.storeLabel.Text = "المخزن";
            // 
            // storesComboBox
            // 
            this.storesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storesComboBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.storesComboBox.FormattingEnabled = true;
            this.storesComboBox.Location = new System.Drawing.Point(315, 94);
            this.storesComboBox.Name = "storesComboBox";
            this.storesComboBox.Size = new System.Drawing.Size(313, 27);
            this.storesComboBox.TabIndex = 21;
            this.storesComboBox.SelectionChangeCommitted += new System.EventHandler(this.storesComboBox_SelectionChangeCommitted);
            // 
            // disscountLabel
            // 
            this.disscountLabel.AutoSize = true;
            this.disscountLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.disscountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.disscountLabel.Location = new System.Drawing.Point(65, 22);
            this.disscountLabel.Name = "disscountLabel";
            this.disscountLabel.Size = new System.Drawing.Size(45, 19);
            this.disscountLabel.TabIndex = 11;
            this.disscountLabel.Text = "الخصم";
            // 
            // disscountTextBox
            // 
            this.disscountTextBox.BackColor = System.Drawing.Color.White;
            this.disscountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.disscountTextBox.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.disscountTextBox.Location = new System.Drawing.Point(40, 43);
            this.disscountTextBox.MaxLength = 18;
            this.disscountTextBox.Name = "disscountTextBox";
            this.disscountTextBox.Size = new System.Drawing.Size(105, 29);
            this.disscountTextBox.TabIndex = 10;
            this.disscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.disscountTextBox.TextChanged += new System.EventHandler(this.disscountTextBox_TextChanged);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.totalLabel.Location = new System.Drawing.Point(198, 22);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(55, 19);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "الإجمالي";
            // 
            // totalTextBox
            // 
            this.totalTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.totalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.totalTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(90)))));
            this.totalTextBox.Location = new System.Drawing.Point(160, 43);
            this.totalTextBox.MaxLength = 18;
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(140, 31);
            this.totalTextBox.TabIndex = 8;
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // purchaseIdLabel
            // 
            this.purchaseIdLabel.AutoSize = true;
            this.purchaseIdLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.purchaseIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.purchaseIdLabel.Location = new System.Drawing.Point(650, 22);
            this.purchaseIdLabel.Name = "purchaseIdLabel";
            this.purchaseIdLabel.Size = new System.Drawing.Size(76, 19);
            this.purchaseIdLabel.TabIndex = 7;
            this.purchaseIdLabel.Text = "رقم الفاتورة";
            // 
            // saleIdTextBox
            // 
            this.saleIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.saleIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saleIdTextBox.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.saleIdTextBox.Location = new System.Drawing.Point(650, 44);
            this.saleIdTextBox.MaxLength = 15;
            this.saleIdTextBox.Name = "saleIdTextBox";
            this.saleIdTextBox.ReadOnly = true;
            this.saleIdTextBox.Size = new System.Drawing.Size(110, 29);
            this.saleIdTextBox.TabIndex = 6;
            this.saleIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(24, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 617);
            this.panel1.TabIndex = 12;
            // 
            // returnButton
            // 
            this.returnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.returnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(132)))), ((int)(((byte)(45)))));
            this.returnButton.Enabled = false;
            this.returnButton.FlatAppearance.BorderSize = 0;
            this.returnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(92)))), ((int)(((byte)(21)))));
            this.returnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(108)))), ((int)(((byte)(27)))));
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
            // 
            // SalesForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label storeLabel;
        private System.Windows.Forms.ComboBox storesComboBox;
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
