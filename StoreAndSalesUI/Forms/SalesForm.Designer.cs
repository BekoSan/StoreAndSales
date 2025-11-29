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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.saleDataGroupBox = new System.Windows.Forms.GroupBox();
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.saleDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.saleDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.searchButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.paymentTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.isDisscountCheckBox = new System.Windows.Forms.CheckBox();
            this.saleDataGroupBox.SuspendLayout();
            this.saleDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // saleDataGroupBox
            // 
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
            this.saleDataGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.saleDataGroupBox.Location = new System.Drawing.Point(11, 74);
            this.saleDataGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saleDataGroupBox.Name = "saleDataGroupBox";
            this.saleDataGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saleDataGroupBox.Size = new System.Drawing.Size(609, 162);
            this.saleDataGroupBox.TabIndex = 0;
            this.saleDataGroupBox.TabStop = false;
            this.saleDataGroupBox.Text = "البيانات الأساسية";
            // 
            // notesLabel
            // 
            this.notesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.notesLabel.Location = new System.Drawing.Point(522, 79);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(66, 19);
            this.notesLabel.TabIndex = 17;
            this.notesLabel.Text = "الملاحظات";
            // 
            // notesTextBox
            // 
            this.notesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesTextBox.Location = new System.Drawing.Point(14, 104);
            this.notesTextBox.MaxLength = 2000;
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(577, 52);
            this.notesTextBox.TabIndex = 16;
            // 
            // customerLabel
            // 
            this.customerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customerLabel.Location = new System.Drawing.Point(453, 25);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(49, 19);
            this.customerLabel.TabIndex = 13;
            this.customerLabel.Text = "العميــل";
            // 
            // customersComboBox
            // 
            this.customersComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customersComboBox.BackColor = System.Drawing.Color.White;
            this.customersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customersComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.customersComboBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.ItemHeight = 19;
            this.customersComboBox.Location = new System.Drawing.Point(247, 47);
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(260, 27);
            this.customersComboBox.TabIndex = 12;
            // 
            // disscountLabel
            // 
            this.disscountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.disscountLabel.AutoSize = true;
            this.disscountLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.disscountLabel.Location = new System.Drawing.Point(54, 24);
            this.disscountLabel.Name = "disscountLabel";
            this.disscountLabel.Size = new System.Drawing.Size(57, 19);
            this.disscountLabel.TabIndex = 11;
            this.disscountLabel.Text = "الخصــــم";
            // 
            // disscountTextBox
            // 
            this.disscountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.disscountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.disscountTextBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.disscountTextBox.Location = new System.Drawing.Point(14, 47);
            this.disscountTextBox.MaxLength = 6;
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
            this.totalLabel.Location = new System.Drawing.Point(190, 25);
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
            this.totalTextBox.Location = new System.Drawing.Point(116, 47);
            this.totalTextBox.MaxLength = 6;
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
            this.purchaseIdLabel.Location = new System.Drawing.Point(516, 25);
            this.purchaseIdLabel.Name = "purchaseIdLabel";
            this.purchaseIdLabel.Size = new System.Drawing.Size(76, 19);
            this.purchaseIdLabel.TabIndex = 7;
            this.purchaseIdLabel.Text = "رقم الفاتورة";
            // 
            // saleIdTextBox
            // 
            this.saleIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saleIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saleIdTextBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.saleIdTextBox.Location = new System.Drawing.Point(513, 47);
            this.saleIdTextBox.MaxLength = 15;
            this.saleIdTextBox.Name = "saleIdTextBox";
            this.saleIdTextBox.ReadOnly = true;
            this.saleIdTextBox.Size = new System.Drawing.Size(78, 27);
            this.saleIdTextBox.TabIndex = 6;
            this.saleIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 35F);
            this.titleLabel.Location = new System.Drawing.Point(223, 11);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(182, 66);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "المبيعات";
            // 
            // saleDetailsGroupBox
            // 
            this.saleDetailsGroupBox.Controls.Add(this.addItemButton);
            this.saleDetailsGroupBox.Controls.Add(this.saleDetailsDataGridView);
            this.saleDetailsGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.saleDetailsGroupBox.Location = new System.Drawing.Point(8, 243);
            this.saleDetailsGroupBox.Name = "saleDetailsGroupBox";
            this.saleDetailsGroupBox.Size = new System.Drawing.Size(609, 323);
            this.saleDetailsGroupBox.TabIndex = 2;
            this.saleDetailsGroupBox.TabStop = false;
            this.saleDetailsGroupBox.Text = "تفاصيل الفاتورة";
            // 
            // addItemButton
            // 
            this.addItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemButton.FlatAppearance.BorderSize = 0;
            this.addItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemButton.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.addItemButton.Location = new System.Drawing.Point(578, 21);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(25, 25);
            this.addItemButton.TabIndex = 4;
            this.addItemButton.Text = "+";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // saleDetailsDataGridView
            // 
            this.saleDetailsDataGridView.AllowUserToAddRows = false;
            this.saleDetailsDataGridView.AllowUserToDeleteRows = false;
            this.saleDetailsDataGridView.AllowUserToResizeColumns = false;
            this.saleDetailsDataGridView.AllowUserToResizeRows = false;
            this.saleDetailsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.saleDetailsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.saleDetailsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.saleDetailsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.saleDetailsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.saleDetailsDataGridView.ColumnHeadersHeight = 29;
            this.saleDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.saleDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.itemNameColumn,
            this.unitColumn,
            this.quantityColumn,
            this.unitPriceColumn,
            this.unitIdColumn,
            this.colDelete});
            this.saleDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saleDetailsDataGridView.EnableHeadersVisualStyles = false;
            this.saleDetailsDataGridView.GridColor = System.Drawing.Color.Black;
            this.saleDetailsDataGridView.Location = new System.Drawing.Point(3, 48);
            this.saleDetailsDataGridView.MultiSelect = false;
            this.saleDetailsDataGridView.Name = "saleDetailsDataGridView";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.saleDetailsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.saleDetailsDataGridView.RowHeadersVisible = false;
            this.saleDetailsDataGridView.RowHeadersWidth = 51;
            this.saleDetailsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.saleDetailsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.saleDetailsDataGridView.RowTemplate.Height = 24;
            this.saleDetailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.saleDetailsDataGridView.Size = new System.Drawing.Size(603, 272);
            this.saleDetailsDataGridView.TabIndex = 3;
            this.saleDetailsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.saleDetailsDataGridView_CellContentClick);
            this.saleDetailsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.saleDetailsDataGridView_CellValueChanged);
            this.saleDetailsDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.saleDetailsDataGridView_RowPostPaint);
            this.saleDetailsDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.saleDetailsDataGridView_RowsAdded);
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Visible = false;
            // 
            // itemNameColumn
            // 
            this.itemNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.itemNameColumn.HeaderText = "الصـــنف";
            this.itemNameColumn.MinimumWidth = 6;
            this.itemNameColumn.Name = "itemNameColumn";
            this.itemNameColumn.ReadOnly = true;
            this.itemNameColumn.Width = 290;
            // 
            // unitColumn
            // 
            this.unitColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.unitColumn.HeaderText = "الوحــدة";
            this.unitColumn.MinimumWidth = 6;
            this.unitColumn.Name = "unitColumn";
            this.unitColumn.ReadOnly = true;
            this.unitColumn.Width = 125;
            // 
            // quantityColumn
            // 
            this.quantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = "N0";
            this.quantityColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.quantityColumn.HeaderText = "الكمــية";
            this.quantityColumn.MinimumWidth = 6;
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.Width = 90;
            // 
            // unitPriceColumn
            // 
            this.unitPriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "N0";
            this.unitPriceColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.unitPriceColumn.HeaderText = "السعـــر";
            this.unitPriceColumn.MinimumWidth = 6;
            this.unitPriceColumn.Name = "unitPriceColumn";
            this.unitPriceColumn.ReadOnly = true;
            this.unitPriceColumn.Width = 53;
            // 
            // unitIdColumn
            // 
            this.unitIdColumn.HeaderText = "unitId";
            this.unitIdColumn.MinimumWidth = 6;
            this.unitIdColumn.Name = "unitIdColumn";
            this.unitIdColumn.Visible = false;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.NullValue = "حذف";
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle10;
            this.colDelete.HeaderText = "...";
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            this.colDelete.Width = 50;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.searchButton.Location = new System.Drawing.Point(379, 576);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(118, 33);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "بحـــث";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(255, 576);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 33);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "حفــــظ";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newButton
            // 
            this.newButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.newButton.Location = new System.Drawing.Point(131, 576);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(118, 33);
            this.newButton.TabIndex = 5;
            this.newButton.Text = "جديد";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // paymentTypeCheckBox
            // 
            this.paymentTypeCheckBox.AutoSize = true;
            this.paymentTypeCheckBox.Location = new System.Drawing.Point(179, 77);
            this.paymentTypeCheckBox.Name = "paymentTypeCheckBox";
            this.paymentTypeCheckBox.Size = new System.Drawing.Size(59, 26);
            this.paymentTypeCheckBox.TabIndex = 18;
            this.paymentTypeCheckBox.Text = "بنكك";
            this.paymentTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // isDisscountCheckBox
            // 
            this.isDisscountCheckBox.AutoSize = true;
            this.isDisscountCheckBox.Location = new System.Drawing.Point(36, 77);
            this.isDisscountCheckBox.Name = "isDisscountCheckBox";
            this.isDisscountCheckBox.Size = new System.Drawing.Size(74, 26);
            this.isDisscountCheckBox.TabIndex = 19;
            this.isDisscountCheckBox.Text = "مجاملة";
            this.isDisscountCheckBox.UseVisualStyleBackColor = true;
            // 
            // SalesForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 615);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.saleDetailsGroupBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.saleDataGroupBox);
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
            this.saleDataGroupBox.ResumeLayout(false);
            this.saleDataGroupBox.PerformLayout();
            this.saleDetailsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.saleDetailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox saleDataGroupBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label purchaseIdLabel;
        private System.Windows.Forms.TextBox saleIdTextBox;
        private System.Windows.Forms.Label disscountLabel;
        private System.Windows.Forms.TextBox disscountTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.ComboBox customersComboBox;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.GroupBox saleDetailsGroupBox;
        private System.Windows.Forms.DataGridView saleDetailsDataGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIdColumn;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.CheckBox paymentTypeCheckBox;
        private System.Windows.Forms.CheckBox isDisscountCheckBox;
    }
}