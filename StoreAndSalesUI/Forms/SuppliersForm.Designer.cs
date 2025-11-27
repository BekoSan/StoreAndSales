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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titleLabel = new System.Windows.Forms.Label();
            this.supplierDataGroupBox = new System.Windows.Forms.GroupBox();
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
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.Button();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.supplierDataGroupBox.SuspendLayout();
            this.suppliersListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 35F);
            this.titleLabel.Location = new System.Drawing.Point(162, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(218, 66);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "المــوردين";
            // 
            // supplierDataGroupBox
            // 
            this.supplierDataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.supplierDataGroupBox.Controls.Add(this.balanceLabel);
            this.supplierDataGroupBox.Controls.Add(this.balanceTextBox);
            this.supplierDataGroupBox.Controls.Add(this.addressLabel);
            this.supplierDataGroupBox.Controls.Add(this.addressTextBox);
            this.supplierDataGroupBox.Controls.Add(this.phoneLabel);
            this.supplierDataGroupBox.Controls.Add(this.phoneTextBox);
            this.supplierDataGroupBox.Controls.Add(this.supplierNameLabel);
            this.supplierDataGroupBox.Controls.Add(this.supplierNameTextBox);
            this.supplierDataGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.supplierDataGroupBox.Location = new System.Drawing.Point(14, 81);
            this.supplierDataGroupBox.Name = "supplierDataGroupBox";
            this.supplierDataGroupBox.Size = new System.Drawing.Size(503, 261);
            this.supplierDataGroupBox.TabIndex = 0;
            this.supplierDataGroupBox.TabStop = false;
            this.supplierDataGroupBox.Text = "بيانات المـــورد";
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.addressLabel.Location = new System.Drawing.Point(338, 81);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(49, 19);
            this.addressLabel.TabIndex = 9;
            this.addressLabel.Text = "العنوان";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTextBox.Location = new System.Drawing.Point(101, 104);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(288, 29);
            this.addressTextBox.TabIndex = 1;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.phoneLabel.Location = new System.Drawing.Point(318, 146);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(69, 19);
            this.phoneLabel.TabIndex = 7;
            this.phoneLabel.Text = "رقم الجوال";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTextBox.Location = new System.Drawing.Point(101, 168);
            this.phoneTextBox.MaxLength = 13;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(288, 29);
            this.phoneTextBox.TabIndex = 2;
            this.phoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // supplierNameLabel
            // 
            this.supplierNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.supplierNameLabel.AutoSize = true;
            this.supplierNameLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.supplierNameLabel.Location = new System.Drawing.Point(316, 25);
            this.supplierNameLabel.Name = "supplierNameLabel";
            this.supplierNameLabel.Size = new System.Drawing.Size(76, 19);
            this.supplierNameLabel.TabIndex = 5;
            this.supplierNameLabel.Text = "إسم المــورد";
            // 
            // supplierNameTextBox
            // 
            this.supplierNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.supplierNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.supplierNameTextBox.Location = new System.Drawing.Point(101, 47);
            this.supplierNameTextBox.Name = "supplierNameTextBox";
            this.supplierNameTextBox.Size = new System.Drawing.Size(288, 29);
            this.supplierNameTextBox.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(205, 573);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 33);
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
            this.newButton.Location = new System.Drawing.Point(80, 573);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(118, 33);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "جديد";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // suppliersListGroupBox
            // 
            this.suppliersListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.suppliersListGroupBox.Controls.Add(this.suppliersDataGridView);
            this.suppliersListGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.suppliersListGroupBox.Location = new System.Drawing.Point(14, 348);
            this.suppliersListGroupBox.Name = "suppliersListGroupBox";
            this.suppliersListGroupBox.Size = new System.Drawing.Size(506, 216);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suppliersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.suppliersDataGridView.ColumnHeadersHeight = 29;
            this.suppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.suppliersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.unitNameColumn,
            this.addressColumn,
            this.phoneColumn});
            this.suppliersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suppliersDataGridView.EnableHeadersVisualStyles = false;
            this.suppliersDataGridView.GridColor = System.Drawing.Color.Black;
            this.suppliersDataGridView.Location = new System.Drawing.Point(3, 25);
            this.suppliersDataGridView.Name = "suppliersDataGridView";
            this.suppliersDataGridView.ReadOnly = true;
            this.suppliersDataGridView.RowHeadersVisible = false;
            this.suppliersDataGridView.RowHeadersWidth = 51;
            this.suppliersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.suppliersDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.suppliersDataGridView.RowTemplate.Height = 24;
            this.suppliersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.suppliersDataGridView.Size = new System.Drawing.Size(500, 188);
            this.suppliersDataGridView.TabIndex = 0;
            this.suppliersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suppliersDataGridView_CellContentClick);
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
            this.unitNameColumn.Width = 175;
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
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.deleteButton.Location = new System.Drawing.Point(330, 573);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(118, 33);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "حـــذف";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // balanceLabel
            // 
            this.balanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.balanceLabel.Location = new System.Drawing.Point(339, 200);
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
            this.balanceTextBox.Location = new System.Drawing.Point(102, 222);
            this.balanceTextBox.MaxLength = 13;
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(288, 29);
            this.balanceTextBox.TabIndex = 10;
            this.balanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SuppliersForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 617);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.supplierDataGroupBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.suppliersListGroupBox);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox balanceTextBox;
    }
}