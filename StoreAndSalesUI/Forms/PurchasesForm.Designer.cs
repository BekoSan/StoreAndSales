using System.Windows.Forms;

namespace StoreAndSalesUI.Forms
{
    partial class PurchasesForm
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
            this.purchaseDataGroupBox = new System.Windows.Forms.GroupBox();
            this.isDisscountCheckBox = new System.Windows.Forms.CheckBox();
            this.paymentTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.suppliersComboBox = new System.Windows.Forms.ComboBox();
            this.storeLabel = new System.Windows.Forms.Label();
            this.storesComboBox = new System.Windows.Forms.ComboBox();
            this.disscountLabel = new System.Windows.Forms.Label();
            this.disscountTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.purchaseIdLabel = new System.Windows.Forms.Label();
            this.purchaseIdTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.unpaidFlagLabel = new System.Windows.Forms.Label();
            this.purchaseDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.purchaseDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineTotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.purchaseDataGroupBox.SuspendLayout();
            this.purchaseDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailsDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // purchaseDataGroupBox
            // 
            this.purchaseDataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseDataGroupBox.BackColor = System.Drawing.Color.White;
            this.purchaseDataGroupBox.Controls.Add(this.isDisscountCheckBox);
            this.purchaseDataGroupBox.Controls.Add(this.paymentTypeCheckBox);
            this.purchaseDataGroupBox.Controls.Add(this.notesLabel);
            this.purchaseDataGroupBox.Controls.Add(this.notesTextBox);
            this.purchaseDataGroupBox.Controls.Add(this.supplierLabel);
            this.purchaseDataGroupBox.Controls.Add(this.suppliersComboBox);
            this.purchaseDataGroupBox.Controls.Add(this.storeLabel);
            this.purchaseDataGroupBox.Controls.Add(this.storesComboBox);
            this.purchaseDataGroupBox.Controls.Add(this.disscountLabel);
            this.purchaseDataGroupBox.Controls.Add(this.disscountTextBox);
            this.purchaseDataGroupBox.Controls.Add(this.totalLabel);
            this.purchaseDataGroupBox.Controls.Add(this.totalTextBox);
            this.purchaseDataGroupBox.Controls.Add(this.purchaseIdLabel);
            this.purchaseDataGroupBox.Controls.Add(this.purchaseIdTextBox);
            this.purchaseDataGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.purchaseDataGroupBox.Location = new System.Drawing.Point(462, 79);
            this.purchaseDataGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.purchaseDataGroupBox.Name = "purchaseDataGroupBox";
            this.purchaseDataGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.purchaseDataGroupBox.Size = new System.Drawing.Size(746, 221);
            this.purchaseDataGroupBox.TabIndex = 0;
            this.purchaseDataGroupBox.TabStop = false;
            this.purchaseDataGroupBox.Text = "البيانات الأساسية";
            // 
            // isDisscountCheckBox
            // 
            this.isDisscountCheckBox.AutoSize = true;
            this.isDisscountCheckBox.Location = new System.Drawing.Point(94, 188);
            this.isDisscountCheckBox.Name = "isDisscountCheckBox";
            this.isDisscountCheckBox.Size = new System.Drawing.Size(74, 26);
            this.isDisscountCheckBox.TabIndex = 21;
            this.isDisscountCheckBox.Text = "مجاملة";
            this.isDisscountCheckBox.UseVisualStyleBackColor = true;
            // 
            // paymentTypeCheckBox
            // 
            this.paymentTypeCheckBox.AutoSize = true;
            this.paymentTypeCheckBox.Location = new System.Drawing.Point(108, 161);
            this.paymentTypeCheckBox.Name = "paymentTypeCheckBox";
            this.paymentTypeCheckBox.Size = new System.Drawing.Size(59, 26);
            this.paymentTypeCheckBox.TabIndex = 20;
            this.paymentTypeCheckBox.Text = "بنكك";
            this.paymentTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.notesLabel.Location = new System.Drawing.Point(660, 139);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(66, 19);
            this.notesLabel.TabIndex = 15;
            this.notesLabel.Text = "الملاحظات";
            // 
            // notesTextBox
            // 
            this.notesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesTextBox.Location = new System.Drawing.Point(173, 161);
            this.notesTextBox.MaxLength = 2000;
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(554, 52);
            this.notesTextBox.TabIndex = 14;
            // 
            // supplierLabel
            // 
            this.supplierLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.supplierLabel.Location = new System.Drawing.Point(582, 40);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(57, 19);
            this.supplierLabel.TabIndex = 13;
            this.supplierLabel.Text = "المــــورد";
            // 
            // suppliersComboBox
            // 
            this.suppliersComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.suppliersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suppliersComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.suppliersComboBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.suppliersComboBox.FormattingEnabled = true;
            this.suppliersComboBox.ItemHeight = 19;
            this.suppliersComboBox.Location = new System.Drawing.Point(384, 62);
            this.suppliersComboBox.Name = "suppliersComboBox";
            this.suppliersComboBox.Size = new System.Drawing.Size(260, 27);
            this.suppliersComboBox.TabIndex = 12;
            // 
            // storeLabel
            // 
            this.storeLabel.AutoSize = true;
            this.storeLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.storeLabel.Location = new System.Drawing.Point(592, 91);
            this.storeLabel.Name = "storeLabel";
            this.storeLabel.Size = new System.Drawing.Size(49, 19);
            this.storeLabel.TabIndex = 22;
            this.storeLabel.Text = "المخزن";
            // 
            // storesComboBox
            // 
            this.storesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storesComboBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.storesComboBox.FormattingEnabled = true;
            this.storesComboBox.Location = new System.Drawing.Point(383, 114);
            this.storesComboBox.Name = "storesComboBox";
            this.storesComboBox.Size = new System.Drawing.Size(261, 27);
            this.storesComboBox.TabIndex = 23;
            this.storesComboBox.SelectionChangeCommitted += new System.EventHandler(this.storesComboBox_SelectionChangeCommitted);
            // 
            // disscountLabel
            // 
            this.disscountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.disscountLabel.AutoSize = true;
            this.disscountLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.disscountLabel.Location = new System.Drawing.Point(190, 39);
            this.disscountLabel.Name = "disscountLabel";
            this.disscountLabel.Size = new System.Drawing.Size(57, 19);
            this.disscountLabel.TabIndex = 11;
            this.disscountLabel.Text = "الخصــــم";
            // 
            // disscountTextBox
            // 
            this.disscountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.disscountTextBox.BackColor = System.Drawing.Color.White;
            this.disscountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.disscountTextBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.disscountTextBox.Location = new System.Drawing.Point(150, 61);
            this.disscountTextBox.MaxLength = 18;
            this.disscountTextBox.Name = "disscountTextBox";
            this.disscountTextBox.Size = new System.Drawing.Size(96, 27);
            this.disscountTextBox.TabIndex = 10;
            this.disscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.disscountTextBox.TextChanged += new System.EventHandler(this.disscountTextBox_TextChanged);
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.totalLabel.Location = new System.Drawing.Point(326, 40);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(55, 19);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "الإجمالي";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalTextBox.BackColor = System.Drawing.Color.White;
            this.totalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalTextBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.totalTextBox.Location = new System.Drawing.Point(252, 61);
            this.totalTextBox.MaxLength = 18;
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(125, 27);
            this.totalTextBox.TabIndex = 8;
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // purchaseIdLabel
            // 
            this.purchaseIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseIdLabel.AutoSize = true;
            this.purchaseIdLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.purchaseIdLabel.Location = new System.Drawing.Point(655, 40);
            this.purchaseIdLabel.Name = "purchaseIdLabel";
            this.purchaseIdLabel.Size = new System.Drawing.Size(76, 19);
            this.purchaseIdLabel.TabIndex = 7;
            this.purchaseIdLabel.Text = "رقم الفاتورة";
            // 
            // purchaseIdTextBox
            // 
            this.purchaseIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseIdTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.purchaseIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purchaseIdTextBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.purchaseIdTextBox.Location = new System.Drawing.Point(652, 62);
            this.purchaseIdTextBox.MaxLength = 15;
            this.purchaseIdTextBox.Name = "purchaseIdTextBox";
            this.purchaseIdTextBox.ReadOnly = true;
            this.purchaseIdTextBox.Size = new System.Drawing.Size(78, 27);
            this.purchaseIdTextBox.TabIndex = 6;
            this.purchaseIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 35F);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.titleLabel.Location = new System.Drawing.Point(501, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(219, 66);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "المشتريات";
            // 
            // unpaidFlagLabel
            // 
            this.unpaidFlagLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            // purchaseDetailsGroupBox
            // 
            this.purchaseDetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseDetailsGroupBox.BackColor = System.Drawing.Color.White;
            this.purchaseDetailsGroupBox.Controls.Add(this.addItemButton);
            this.purchaseDetailsGroupBox.Controls.Add(this.purchaseDetailsDataGridView);
            this.purchaseDetailsGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.purchaseDetailsGroupBox.Location = new System.Drawing.Point(459, 304);
            this.purchaseDetailsGroupBox.Name = "purchaseDetailsGroupBox";
            this.purchaseDetailsGroupBox.Size = new System.Drawing.Size(749, 406);
            this.purchaseDetailsGroupBox.TabIndex = 2;
            this.purchaseDetailsGroupBox.TabStop = false;
            this.purchaseDetailsGroupBox.Text = "تفاصيل الفاتورة";
            // 
            // addItemButton
            // 
            this.addItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemButton.FlatAppearance.BorderSize = 0;
            this.addItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemButton.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.addItemButton.Location = new System.Drawing.Point(716, 21);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(25, 25);
            this.addItemButton.TabIndex = 4;
            this.addItemButton.Text = "+";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Visible = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // purchaseDetailsDataGridView
            // 
            this.purchaseDetailsDataGridView.AllowUserToAddRows = false;
            this.purchaseDetailsDataGridView.AllowUserToDeleteRows = false;
            this.purchaseDetailsDataGridView.AllowUserToResizeColumns = false;
            this.purchaseDetailsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.purchaseDetailsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.purchaseDetailsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.purchaseDetailsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.purchaseDetailsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.purchaseDetailsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseDetailsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.purchaseDetailsDataGridView.ColumnHeadersHeight = 36;
            this.purchaseDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.purchaseDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purchaseDetailsDataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.purchaseDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseDetailsDataGridView.EnableHeadersVisualStyles = false;
            this.purchaseDetailsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.purchaseDetailsDataGridView.Location = new System.Drawing.Point(3, 25);
            this.purchaseDetailsDataGridView.MultiSelect = false;
            this.purchaseDetailsDataGridView.Name = "purchaseDetailsDataGridView";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseDetailsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.purchaseDetailsDataGridView.RowHeadersVisible = false;
            this.purchaseDetailsDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.purchaseDetailsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.purchaseDetailsDataGridView.RowTemplate.Height = 34;
            this.purchaseDetailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchaseDetailsDataGridView.Size = new System.Drawing.Size(743, 378);
            this.purchaseDetailsDataGridView.TabIndex = 3;
            this.purchaseDetailsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseDetailsDataGridView_CellContentClick);
            this.purchaseDetailsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseDetailsDataGridView_CellValueChanged);
            this.purchaseDetailsDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.purchaseDetailsDataGridView_RowPostPaint);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(57)))));
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(469, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(138, 40);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "بحث عن فاتورة";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(613, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(138, 40);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "حفظ";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newButton
            // 
            this.newButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.newButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(110)))), ((int)(((byte)(145)))));
            this.newButton.FlatAppearance.BorderSize = 0;
            this.newButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(84)))), ((int)(((byte)(116)))));
            this.newButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(126)))));
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.newButton.ForeColor = System.Drawing.Color.White;
            this.newButton.Location = new System.Drawing.Point(757, 5);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(138, 40);
            this.newButton.TabIndex = 5;
            this.newButton.Text = "جديد";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // printButton
            // 
            this.printButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.printButton.Enabled = false;
            this.printButton.FlatAppearance.BorderSize = 0;
            this.printButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(56)))), ((int)(((byte)(110)))));
            this.printButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(68)))), ((int)(((byte)(129)))));
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Location = new System.Drawing.Point(325, 5);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(138, 40);
            this.printButton.TabIndex = 9;
            this.printButton.Text = "طباعة";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 707);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.newButton);
            this.panel2.Controls.Add(this.printButton);
            this.panel2.Controls.Add(this.searchButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 718);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 52);
            this.panel2.TabIndex = 21;
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
            this.IdColumn.Width = 125;
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
            this.unitIdColumn.Width = 125;
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
            this.lineTotalColumn.Width = 110;
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
            // PurchasesForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1220, 770);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.purchaseDetailsGroupBox);
            this.Controls.Add(this.unpaidFlagLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.purchaseDataGroupBox);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "PurchasesForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المشتريات";
            this.Load += new System.EventHandler(this.PurchasesForm_Load);
            this.purchaseDataGroupBox.ResumeLayout(false);
            this.purchaseDataGroupBox.PerformLayout();
            this.purchaseDetailsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailsDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox purchaseDataGroupBox;
        private System.Windows.Forms.Label unpaidFlagLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label purchaseIdLabel;
        private System.Windows.Forms.TextBox purchaseIdTextBox;
        private System.Windows.Forms.Label disscountLabel;
        private System.Windows.Forms.TextBox disscountTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.ComboBox suppliersComboBox;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.Label storeLabel;
        private System.Windows.Forms.ComboBox storesComboBox;
        private System.Windows.Forms.GroupBox purchaseDetailsGroupBox;
        private System.Windows.Forms.DataGridView purchaseDetailsDataGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.CheckBox isDisscountCheckBox;
        private System.Windows.Forms.CheckBox paymentTypeCheckBox;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Panel panel1;
        private Panel panel2;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn itemNameColumn;
        private DataGridViewTextBoxColumn unitColumn;
        private DataGridViewTextBoxColumn quantityColumn;
        private DataGridViewTextBoxColumn unitPriceColumn;
        private DataGridViewTextBoxColumn unitIdColumn;
        private DataGridViewTextBoxColumn lineTotalColumn;
        private DataGridViewButtonColumn colDelete;
    }
}