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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.purchaseDataGroupBox = new System.Windows.Forms.GroupBox();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.suppliersComboBox = new System.Windows.Forms.ComboBox();
            this.disscountLabel = new System.Windows.Forms.Label();
            this.disscountTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.purchaseIdLabel = new System.Windows.Forms.Label();
            this.purchaseIdTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.purchaseDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.purchaseDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.purchaseDataGroupBox.SuspendLayout();
            this.purchaseDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // purchaseDataGroupBox
            // 
            this.purchaseDataGroupBox.Controls.Add(this.notesLabel);
            this.purchaseDataGroupBox.Controls.Add(this.notesTextBox);
            this.purchaseDataGroupBox.Controls.Add(this.supplierLabel);
            this.purchaseDataGroupBox.Controls.Add(this.suppliersComboBox);
            this.purchaseDataGroupBox.Controls.Add(this.disscountLabel);
            this.purchaseDataGroupBox.Controls.Add(this.disscountTextBox);
            this.purchaseDataGroupBox.Controls.Add(this.totalLabel);
            this.purchaseDataGroupBox.Controls.Add(this.totalTextBox);
            this.purchaseDataGroupBox.Controls.Add(this.purchaseIdLabel);
            this.purchaseDataGroupBox.Controls.Add(this.purchaseIdTextBox);
            this.purchaseDataGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.purchaseDataGroupBox.Location = new System.Drawing.Point(11, 74);
            this.purchaseDataGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.purchaseDataGroupBox.Name = "purchaseDataGroupBox";
            this.purchaseDataGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.purchaseDataGroupBox.Size = new System.Drawing.Size(609, 165);
            this.purchaseDataGroupBox.TabIndex = 0;
            this.purchaseDataGroupBox.TabStop = false;
            this.purchaseDataGroupBox.Text = "البيانات الأساسية";
            // 
            // supplierLabel
            // 
            this.supplierLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.supplierLabel.Location = new System.Drawing.Point(445, 26);
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
            this.suppliersComboBox.Location = new System.Drawing.Point(247, 48);
            this.suppliersComboBox.Name = "suppliersComboBox";
            this.suppliersComboBox.Size = new System.Drawing.Size(260, 27);
            this.suppliersComboBox.TabIndex = 12;
            // 
            // disscountLabel
            // 
            this.disscountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.disscountLabel.AutoSize = true;
            this.disscountLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.disscountLabel.Location = new System.Drawing.Point(54, 25);
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
            this.totalLabel.Location = new System.Drawing.Point(190, 26);
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
            this.purchaseIdLabel.Location = new System.Drawing.Point(516, 26);
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
            this.purchaseIdTextBox.Location = new System.Drawing.Point(513, 48);
            this.purchaseIdTextBox.MaxLength = 15;
            this.purchaseIdTextBox.Name = "purchaseIdTextBox";
            this.purchaseIdTextBox.ReadOnly = true;
            this.purchaseIdTextBox.Size = new System.Drawing.Size(78, 27);
            this.purchaseIdTextBox.TabIndex = 6;
            this.purchaseIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 35F);
            this.titleLabel.Location = new System.Drawing.Point(205, 11);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(219, 66);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "المشتريات";
            // 
            // purchaseDetailsGroupBox
            // 
            this.purchaseDetailsGroupBox.Controls.Add(this.addItemButton);
            this.purchaseDetailsGroupBox.Controls.Add(this.purchaseDetailsDataGridView);
            this.purchaseDetailsGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.purchaseDetailsGroupBox.Location = new System.Drawing.Point(8, 237);
            this.purchaseDetailsGroupBox.Name = "purchaseDetailsGroupBox";
            this.purchaseDetailsGroupBox.Size = new System.Drawing.Size(609, 323);
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
            this.addItemButton.Location = new System.Drawing.Point(576, 21);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(25, 25);
            this.addItemButton.TabIndex = 4;
            this.addItemButton.Text = "+";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // purchaseDetailsDataGridView
            // 
            this.purchaseDetailsDataGridView.AllowUserToAddRows = false;
            this.purchaseDetailsDataGridView.AllowUserToDeleteRows = false;
            this.purchaseDetailsDataGridView.AllowUserToResizeColumns = false;
            this.purchaseDetailsDataGridView.AllowUserToResizeRows = false;
            this.purchaseDetailsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purchaseDetailsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.purchaseDetailsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.purchaseDetailsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseDetailsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.purchaseDetailsDataGridView.ColumnHeadersHeight = 29;
            this.purchaseDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.purchaseDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.itemNameColumn,
            this.unitColumn,
            this.quantityColumn,
            this.unitPriceColumn,
            this.unitIdColumn});
            this.purchaseDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.purchaseDetailsDataGridView.EnableHeadersVisualStyles = false;
            this.purchaseDetailsDataGridView.GridColor = System.Drawing.Color.Black;
            this.purchaseDetailsDataGridView.Location = new System.Drawing.Point(3, 48);
            this.purchaseDetailsDataGridView.MultiSelect = false;
            this.purchaseDetailsDataGridView.Name = "purchaseDetailsDataGridView";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseDetailsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.purchaseDetailsDataGridView.RowHeadersVisible = false;
            this.purchaseDetailsDataGridView.RowHeadersWidth = 51;
            this.purchaseDetailsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            this.purchaseDetailsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.purchaseDetailsDataGridView.RowTemplate.Height = 24;
            this.purchaseDetailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchaseDetailsDataGridView.Size = new System.Drawing.Size(603, 272);
            this.purchaseDetailsDataGridView.TabIndex = 3;
            this.purchaseDetailsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseDetailsDataGridView_CellContentClick);
            this.purchaseDetailsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseDetailsDataGridView_CellValueChanged);
            this.purchaseDetailsDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.purchaseDetailsDataGridView_RowPostPaint);
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
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.NullValue = "N0";
            this.quantityColumn.DefaultCellStyle = dataGridViewCellStyle27;
            this.quantityColumn.HeaderText = "الكمــية";
            this.quantityColumn.MinimumWidth = 6;
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.Width = 90;
            // 
            // unitPriceColumn
            // 
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.Format = "N0";
            this.unitPriceColumn.DefaultCellStyle = dataGridViewCellStyle28;
            this.unitPriceColumn.HeaderText = "السعـــر";
            this.unitPriceColumn.MinimumWidth = 6;
            this.unitPriceColumn.Name = "unitPriceColumn";
            // 
            // unitIdColumn
            // 
            this.unitIdColumn.HeaderText = "UnitId";
            this.unitIdColumn.MinimumWidth = 6;
            this.unitIdColumn.Name = "unitIdColumn";
            this.unitIdColumn.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.searchButton.Location = new System.Drawing.Point(379, 565);
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
            this.saveButton.Location = new System.Drawing.Point(255, 565);
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
            this.newButton.Location = new System.Drawing.Point(131, 565);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(118, 33);
            this.newButton.TabIndex = 5;
            this.newButton.Text = "جديد";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // notesTextBox
            // 
            this.notesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesTextBox.Location = new System.Drawing.Point(14, 105);
            this.notesTextBox.MaxLength = 2000;
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(577, 52);
            this.notesTextBox.TabIndex = 14;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.notesLabel.Location = new System.Drawing.Point(528, 83);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(66, 19);
            this.notesLabel.TabIndex = 15;
            this.notesLabel.Text = "الملاحظات";
            // 
            // PurchasesForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 604);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.purchaseDetailsGroupBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.purchaseDataGroupBox);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox purchaseDataGroupBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label purchaseIdLabel;
        private System.Windows.Forms.TextBox purchaseIdTextBox;
        private System.Windows.Forms.Label disscountLabel;
        private System.Windows.Forms.TextBox disscountTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.ComboBox suppliersComboBox;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.GroupBox purchaseDetailsGroupBox;
        private System.Windows.Forms.DataGridView purchaseDetailsDataGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIdColumn;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Label notesLabel;
    }
}