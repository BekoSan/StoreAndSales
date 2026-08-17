namespace StoreAndSalesUI.Forms
{
    partial class CustomersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titleLabel = new System.Windows.Forms.Label();
            this.customerDataGroupBox = new System.Windows.Forms.GroupBox();
            this.payDebtButton = new System.Windows.Forms.Button();
            this.creditLimitLabel = new System.Windows.Forms.Label();
            this.creditLimitTextBox = new System.Windows.Forms.TextBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.customersListGroupBox = new System.Windows.Forms.GroupBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditLimitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGroupBox.SuspendLayout();
            this.customersListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 35F);
            this.titleLabel.Location = new System.Drawing.Point(202, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(181, 66);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "العمــلاء";
            // 
            // customerDataGroupBox
            // 
            this.customerDataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerDataGroupBox.Controls.Add(this.payDebtButton);
            this.customerDataGroupBox.Controls.Add(this.creditLimitLabel);
            this.customerDataGroupBox.Controls.Add(this.creditLimitTextBox);
            this.customerDataGroupBox.Controls.Add(this.balanceLabel);
            this.customerDataGroupBox.Controls.Add(this.balanceTextBox);
            this.customerDataGroupBox.Controls.Add(this.addressLabel);
            this.customerDataGroupBox.Controls.Add(this.addressTextBox);
            this.customerDataGroupBox.Controls.Add(this.phoneLabel);
            this.customerDataGroupBox.Controls.Add(this.phoneTextBox);
            this.customerDataGroupBox.Controls.Add(this.customerNameLabel);
            this.customerDataGroupBox.Controls.Add(this.customerNameTextBox);
            this.customerDataGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.customerDataGroupBox.Location = new System.Drawing.Point(73, 81);
            this.customerDataGroupBox.Name = "customerDataGroupBox";
            this.customerDataGroupBox.Size = new System.Drawing.Size(596, 322);
            this.customerDataGroupBox.TabIndex = 0;
            this.customerDataGroupBox.TabStop = false;
            this.customerDataGroupBox.Text = "بيانات العميل";
            // 
            // payDebtButton
            // 
            this.payDebtButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.payDebtButton.Enabled = false;
            this.payDebtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payDebtButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.payDebtButton.Location = new System.Drawing.Point(63, 276);
            this.payDebtButton.Name = "payDebtButton";
            this.payDebtButton.Size = new System.Drawing.Size(82, 33);
            this.payDebtButton.TabIndex = 12;
            this.payDebtButton.Text = "تسديد دين";
            this.payDebtButton.UseVisualStyleBackColor = true;
            this.payDebtButton.Click += new System.EventHandler(this.payDebtButton_Click);
            // 
            // creditLimitLabel
            // 
            this.creditLimitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.creditLimitLabel.AutoSize = true;
            this.creditLimitLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.creditLimitLabel.Location = new System.Drawing.Point(508, 202);
            this.creditLimitLabel.Name = "creditLimitLabel";
            this.creditLimitLabel.Size = new System.Drawing.Size(57, 19);
            this.creditLimitLabel.TabIndex = 13;
            this.creditLimitLabel.Text = "حد الدين";
            // 
            // creditLimitTextBox
            // 
            this.creditLimitTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.creditLimitTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creditLimitTextBox.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.creditLimitTextBox.Location = new System.Drawing.Point(63, 225);
            this.creditLimitTextBox.MaxLength = 18;
            this.creditLimitTextBox.Name = "creditLimitTextBox";
            this.creditLimitTextBox.Size = new System.Drawing.Size(512, 29);
            this.creditLimitTextBox.TabIndex = 12;
            this.creditLimitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.creditLimitTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.creditLimitTextBox_KeyPress);
            // 
            // balanceLabel
            // 
            this.balanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.balanceLabel.Location = new System.Drawing.Point(529, 256);
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
            this.balanceTextBox.Location = new System.Drawing.Point(151, 279);
            this.balanceTextBox.MaxLength = 18;
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(424, 29);
            this.balanceTextBox.TabIndex = 10;
            this.balanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.balanceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.balanceTextBox_KeyPress);
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.addressLabel.Location = new System.Drawing.Point(528, 79);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(49, 19);
            this.addressLabel.TabIndex = 9;
            this.addressLabel.Text = "العنوان";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTextBox.Location = new System.Drawing.Point(63, 104);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(511, 29);
            this.addressTextBox.TabIndex = 1;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.phoneLabel.Location = new System.Drawing.Point(510, 146);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(69, 19);
            this.phoneLabel.TabIndex = 7;
            this.phoneLabel.Text = "رقم الجوال";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTextBox.Location = new System.Drawing.Point(63, 168);
            this.phoneTextBox.MaxLength = 13;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(511, 29);
            this.phoneTextBox.TabIndex = 2;
            this.phoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customerNameLabel.Location = new System.Drawing.Point(511, 25);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(68, 19);
            this.customerNameLabel.TabIndex = 5;
            this.customerNameLabel.Text = "إسم العميل";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerNameTextBox.Location = new System.Drawing.Point(63, 47);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(511, 29);
            this.customerNameTextBox.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(289, 680);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(103, 33);
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
            this.newButton.Location = new System.Drawing.Point(182, 680);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(103, 33);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "جديد";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // customersListGroupBox
            // 
            this.customersListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customersListGroupBox.Controls.Add(this.searchLabel);
            this.customersListGroupBox.Controls.Add(this.searchTextBox);
            this.customersListGroupBox.Controls.Add(this.customersDataGridView);
            this.customersListGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.customersListGroupBox.Location = new System.Drawing.Point(12, 409);
            this.customersListGroupBox.Name = "customersListGroupBox";
            this.customersListGroupBox.Size = new System.Drawing.Size(659, 265);
            this.customersListGroupBox.TabIndex = 12;
            this.customersListGroupBox.TabStop = false;
            this.customersListGroupBox.Text = "قائمة العملاء";
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.searchLabel.Location = new System.Drawing.Point(602, 32);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(34, 19);
            this.searchLabel.TabIndex = 12;
            this.searchLabel.Text = "بحث";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.searchTextBox.Location = new System.Drawing.Point(88, 28);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(509, 27);
            this.searchTextBox.TabIndex = 11;
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AllowUserToAddRows = false;
            this.customersDataGridView.AllowUserToDeleteRows = false;
            this.customersDataGridView.AllowUserToResizeColumns = false;
            this.customersDataGridView.AllowUserToResizeRows = false;
            this.customersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.customersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customersDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customersDataGridView.ColumnHeadersHeight = 29;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.unitNameColumn,
            this.addressColumn,
            this.phoneColumn,
            this.balanceColumn,
            this.creditLimitColumn});
            this.customersDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customersDataGridView.EnableHeadersVisualStyles = false;
            this.customersDataGridView.GridColor = System.Drawing.Color.Black;
            this.customersDataGridView.Location = new System.Drawing.Point(3, 74);
            this.customersDataGridView.MultiSelect = false;
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.ReadOnly = true;
            this.customersDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.customersDataGridView.RowHeadersVisible = false;
            this.customersDataGridView.RowHeadersWidth = 51;
            this.customersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.customersDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.customersDataGridView.RowTemplate.Height = 24;
            this.customersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersDataGridView.Size = new System.Drawing.Size(653, 188);
            this.customersDataGridView.TabIndex = 0;
            this.customersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDataGridView_CellContentClick);
            this.customersDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.customersDataGridView_CellFormatting);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.deleteButton.Location = new System.Drawing.Point(396, 680);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 33);
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
            this.unitNameColumn.DataPropertyName = "CustomerName";
            this.unitNameColumn.HeaderText = "الإســم";
            this.unitNameColumn.MinimumWidth = 6;
            this.unitNameColumn.Name = "unitNameColumn";
            this.unitNameColumn.ReadOnly = true;
            this.unitNameColumn.Width = 190;
            // 
            // addressColumn
            // 
            this.addressColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.addressColumn.DataPropertyName = "Address";
            this.addressColumn.HeaderText = "العنوان";
            this.addressColumn.MinimumWidth = 6;
            this.addressColumn.Name = "addressColumn";
            this.addressColumn.ReadOnly = true;
            this.addressColumn.Width = 60;
            // 
            // phoneColumn
            // 
            this.phoneColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.phoneColumn.DataPropertyName = "Phone";
            this.phoneColumn.HeaderText = "رقم الجوال";
            this.phoneColumn.MinimumWidth = 6;
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.ReadOnly = true;
            this.phoneColumn.Width = 85;
            // 
            // balanceColumn
            // 
            this.balanceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.balanceColumn.DataPropertyName = "Balance";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.balanceColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.balanceColumn.HeaderText = "الرصيد";
            this.balanceColumn.MinimumWidth = 6;
            this.balanceColumn.Name = "balanceColumn";
            this.balanceColumn.ReadOnly = true;
            this.balanceColumn.Width = 125;
            // 
            // creditLimitColumn
            // 
            this.creditLimitColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.creditLimitColumn.DataPropertyName = "CreditLimit";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            this.creditLimitColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.creditLimitColumn.HeaderText = "حد الدين";
            this.creditLimitColumn.MinimumWidth = 6;
            this.creditLimitColumn.Name = "creditLimitColumn";
            this.creditLimitColumn.ReadOnly = true;
            this.creditLimitColumn.Width = 125;
            // 
            // CustomersForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 725);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.customerDataGroupBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.customersListGroupBox);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomersForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "العمــلاء";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            this.customerDataGroupBox.ResumeLayout(false);
            this.customerDataGroupBox.PerformLayout();
            this.customersListGroupBox.ResumeLayout(false);
            this.customersListGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox customerDataGroupBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.GroupBox customersListGroupBox;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Label creditLimitLabel;
        private System.Windows.Forms.TextBox creditLimitTextBox;
        private System.Windows.Forms.Button payDebtButton;

        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditLimitColumn;
    }
}