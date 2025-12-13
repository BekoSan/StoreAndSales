namespace StoreAndSalesUI.Forms
{
    partial class SuppliersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titleLabel = new System.Windows.Forms.Label();
            this.supplierDataGroupBox = new System.Windows.Forms.GroupBox();
            this.payDebtButton = new System.Windows.Forms.Button();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.supplierNameLabel = new System.Windows.Forms.Label();
            this.supplierNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.suppliersListGroupBox = new System.Windows.Forms.GroupBox();
            this.suppliersDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.supplierDataGroupBox.SuspendLayout();
            this.suppliersListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 35F);
            this.titleLabel.Location = new System.Drawing.Point(213, 9);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(218, 66);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "المــوردين";
            // 
            // supplierDataGroupBox
            // 
            this.supplierDataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.supplierDataGroupBox.Controls.Add(this.payDebtButton);
            this.supplierDataGroupBox.Controls.Add(this.balanceLabel);
            this.supplierDataGroupBox.Controls.Add(this.balanceTextBox);
            this.supplierDataGroupBox.Controls.Add(this.addressLabel);
            this.supplierDataGroupBox.Controls.Add(this.addressTextBox);
            this.supplierDataGroupBox.Controls.Add(this.phoneLabel);
            this.supplierDataGroupBox.Controls.Add(this.phoneTextBox);
            this.supplierDataGroupBox.Controls.Add(this.supplierNameLabel);
            this.supplierDataGroupBox.Controls.Add(this.supplierNameTextBox);
            this.supplierDataGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.supplierDataGroupBox.Location = new System.Drawing.Point(3, 79);
            this.supplierDataGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.supplierDataGroupBox.Name = "supplierDataGroupBox";
            this.supplierDataGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.supplierDataGroupBox.Size = new System.Drawing.Size(629, 273);
            this.supplierDataGroupBox.TabIndex = 0;
            this.supplierDataGroupBox.TabStop = false;
            this.supplierDataGroupBox.Text = "بيانات المـــورد";
            // 
            // payDebtButton
            // 
            this.payDebtButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.payDebtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payDebtButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.payDebtButton.Location = new System.Drawing.Point(5, 234);
            this.payDebtButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.payDebtButton.Name = "payDebtButton";
            this.payDebtButton.Size = new System.Drawing.Size(96, 29);
            this.payDebtButton.TabIndex = 13;
            this.payDebtButton.Text = "تسديد دين";
            this.payDebtButton.UseVisualStyleBackColor = true;
            this.payDebtButton.Click += new System.EventHandler(this.payDebtButton_Click);
            // 
            // balanceLabel
            // 
            this.balanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.balanceLabel.Location = new System.Drawing.Point(546, 213);
            this.balanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(48, 19);
            this.balanceLabel.TabIndex = 11;
            this.balanceLabel.Text = "الرصيد";
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceTextBox.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.balanceTextBox.Location = new System.Drawing.Point(104, 235);
            this.balanceTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.balanceTextBox.MaxLength = 18;
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(497, 29);
            this.balanceTextBox.TabIndex = 10;
            this.balanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.balanceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.balanceTextBox_KeyPress);
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.addressLabel.Location = new System.Drawing.Point(545, 98);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(49, 19);
            this.addressLabel.TabIndex = 9;
            this.addressLabel.Text = "العنوان";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTextBox.Location = new System.Drawing.Point(15, 119);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(586, 29);
            this.addressTextBox.TabIndex = 1;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.phoneLabel.Location = new System.Drawing.Point(525, 155);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(69, 19);
            this.phoneLabel.TabIndex = 7;
            this.phoneLabel.Text = "رقم الجوال";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTextBox.Location = new System.Drawing.Point(15, 178);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneTextBox.MaxLength = 13;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(586, 29);
            this.phoneTextBox.TabIndex = 2;
            this.phoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // supplierNameLabel
            // 
            this.supplierNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.supplierNameLabel.AutoSize = true;
            this.supplierNameLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.supplierNameLabel.Location = new System.Drawing.Point(518, 41);
            this.supplierNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.supplierNameLabel.Name = "supplierNameLabel";
            this.supplierNameLabel.Size = new System.Drawing.Size(76, 19);
            this.supplierNameLabel.TabIndex = 5;
            this.supplierNameLabel.Text = "إسم المــورد";
            // 
            // supplierNameTextBox
            // 
            this.supplierNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.supplierNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.supplierNameTextBox.Location = new System.Drawing.Point(15, 67);
            this.supplierNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.supplierNameTextBox.Name = "supplierNameTextBox";
            this.supplierNameTextBox.Size = new System.Drawing.Size(586, 29);
            this.supplierNameTextBox.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(274, 686);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 32);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "حفــــظ";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newButton
            // 
            this.newButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.newButton.Location = new System.Drawing.Point(174, 686);
            this.newButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(94, 32);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "جديد";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // suppliersListGroupBox
            // 
            this.suppliersListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.suppliersListGroupBox.Controls.Add(this.searchLabel);
            this.suppliersListGroupBox.Controls.Add(this.searchTextBox);
            this.suppliersListGroupBox.Controls.Add(this.suppliersDataGridView);
            this.suppliersListGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.suppliersListGroupBox.Location = new System.Drawing.Point(3, 356);
            this.suppliersListGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.suppliersListGroupBox.Name = "suppliersListGroupBox";
            this.suppliersListGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.suppliersListGroupBox.Size = new System.Drawing.Size(635, 326);
            this.suppliersListGroupBox.TabIndex = 12;
            this.suppliersListGroupBox.TabStop = false;
            this.suppliersListGroupBox.Text = "قائمة الموردين";
            // 
            // suppliersDataGridView
            // 
            this.suppliersDataGridView.AllowUserToAddRows = false;
            this.suppliersDataGridView.AllowUserToDeleteRows = false;
            this.suppliersDataGridView.AllowUserToResizeColumns = false;
            this.suppliersDataGridView.AllowUserToResizeRows = false;
            this.suppliersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suppliersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.suppliersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.suppliersDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suppliersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.suppliersDataGridView.ColumnHeadersHeight = 29;
            this.suppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.suppliersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.unitNameColumn,
            this.addressColumn,
            this.phoneColumn,
            this.balanceColumn});
            this.suppliersDataGridView.EnableHeadersVisualStyles = false;
            this.suppliersDataGridView.GridColor = System.Drawing.Color.Black;
            this.suppliersDataGridView.Location = new System.Drawing.Point(2, 64);
            this.suppliersDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.suppliersDataGridView.MultiSelect = false;
            this.suppliersDataGridView.Name = "suppliersDataGridView";
            this.suppliersDataGridView.ReadOnly = true;
            this.suppliersDataGridView.RowHeadersVisible = false;
            this.suppliersDataGridView.RowHeadersWidth = 51;
            this.suppliersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.suppliersDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.suppliersDataGridView.RowTemplate.Height = 24;
            this.suppliersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.suppliersDataGridView.Size = new System.Drawing.Size(630, 258);
            this.suppliersDataGridView.TabIndex = 0;
            this.suppliersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suppliersDataGridView_CellContentClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.deleteButton.Location = new System.Drawing.Point(374, 686);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 32);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "حـــذف";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            // 
            // unitNameColumn
            // 
            this.unitNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.unitNameColumn.DataPropertyName = "SupplierName";
            this.unitNameColumn.HeaderText = "الإســم";
            this.unitNameColumn.MinimumWidth = 6;
            this.unitNameColumn.Name = "unitNameColumn";
            this.unitNameColumn.ReadOnly = true;
            this.unitNameColumn.Width = 190;
            // 
            // addressColumn
            // 
            this.addressColumn.DataPropertyName = "Address";
            this.addressColumn.HeaderText = "العنوان";
            this.addressColumn.MinimumWidth = 6;
            this.addressColumn.Name = "addressColumn";
            this.addressColumn.ReadOnly = true;
            // 
            // phoneColumn
            // 
            this.phoneColumn.DataPropertyName = "Phone";
            this.phoneColumn.HeaderText = "رقم الجوال";
            this.phoneColumn.MinimumWidth = 6;
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.ReadOnly = true;
            // 
            // balanceColumn
            // 
            this.balanceColumn.DataPropertyName = "Balance";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            this.balanceColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.balanceColumn.HeaderText = "الرصيد";
            this.balanceColumn.MinimumWidth = 6;
            this.balanceColumn.Name = "balanceColumn";
            this.balanceColumn.ReadOnly = true;
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.searchLabel.Location = new System.Drawing.Point(580, 31);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(34, 19);
            this.searchLabel.TabIndex = 14;
            this.searchLabel.Text = "بحث";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.searchTextBox.Location = new System.Drawing.Point(49, 27);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(525, 27);
            this.searchTextBox.TabIndex = 13;
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // SuppliersForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 725);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.supplierDataGroupBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.suppliersListGroupBox);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SuppliersForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الموردين";
            this.Load += new System.EventHandler(this.SuppliersForm_Load);
            this.supplierDataGroupBox.ResumeLayout(false);
            this.supplierDataGroupBox.PerformLayout();
            this.suppliersListGroupBox.ResumeLayout(false);
            this.suppliersListGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox supplierDataGroupBox;
        private System.Windows.Forms.Label supplierNameLabel;
        private System.Windows.Forms.TextBox supplierNameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.GroupBox suppliersListGroupBox;
        private System.Windows.Forms.DataGridView suppliersDataGridView;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Button payDebtButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceColumn;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}