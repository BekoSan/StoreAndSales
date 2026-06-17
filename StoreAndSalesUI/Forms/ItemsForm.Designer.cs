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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titleLabel = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemUnitsDataGridView = new System.Windows.Forms.DataGridView();
            this.unitIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemUnitIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGroupBox = new System.Windows.Forms.GroupBox();
            this.addUnitButton = new System.Windows.Forms.Button();
            this.itemsListGroupBox = new System.Windows.Forms.GroupBox();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemUnitsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            this.itemDataGroupBox.SuspendLayout();
            this.itemsListGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 35F);
            this.titleLabel.Location = new System.Drawing.Point(143, 11);
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemUnitsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.itemUnitsDataGridView.ColumnHeadersHeight = 29;
            this.itemUnitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.itemUnitsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unitIdColumn,
            this.itemUnitIdColumn,
            this.unitNameColumn,
            this.unitPriceColumn});
            this.itemUnitsDataGridView.EnableHeadersVisualStyles = false;
            this.itemUnitsDataGridView.GridColor = System.Drawing.Color.Black;
            this.itemUnitsDataGridView.Location = new System.Drawing.Point(6, 121);
            this.itemUnitsDataGridView.Name = "itemUnitsDataGridView";
            this.itemUnitsDataGridView.RowHeadersVisible = false;
            this.itemUnitsDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.itemUnitsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = null;
            this.unitPriceColumn.DefaultCellStyle = dataGridViewCellStyle10;
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
            this.label3.Location = new System.Drawing.Point(352, 96);
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
            this.itemsDataGridView.ColumnHeadersVisible = false;
            this.itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.itemNameColumn});
            this.itemsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.itemsDataGridView.GridColor = System.Drawing.Color.Black;
            this.itemsDataGridView.Location = new System.Drawing.Point(3, 82);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.ReadOnly = true;
            this.itemsDataGridView.RowHeadersVisible = false;
            this.itemsDataGridView.RowHeadersWidth = 51;
            this.itemsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.itemsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.itemsDataGridView.RowTemplate.Height = 24;
            this.itemsDataGridView.Size = new System.Drawing.Size(444, 157);
            this.itemsDataGridView.TabIndex = 0;
            this.itemsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDataGridView_CellContentClick);
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
            // itemDataGroupBox
            // 
            this.itemDataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemDataGroupBox.Controls.Add(this.addUnitButton);
            this.itemDataGroupBox.Controls.Add(this.itemNameLabel);
            this.itemDataGroupBox.Controls.Add(this.itemNameTextBox);
            this.itemDataGroupBox.Controls.Add(this.label3);
            this.itemDataGroupBox.Controls.Add(this.itemUnitsDataGridView);
            this.itemDataGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.itemDataGroupBox.Location = new System.Drawing.Point(5, 84);
            this.itemDataGroupBox.Name = "itemDataGroupBox";
            this.itemDataGroupBox.Size = new System.Drawing.Size(450, 307);
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
            this.addUnitButton.Location = new System.Drawing.Point(320, 90);
            this.addUnitButton.Name = "addUnitButton";
            this.addUnitButton.Size = new System.Drawing.Size(25, 25);
            this.addUnitButton.TabIndex = 1;
            this.addUnitButton.Text = "+";
            this.addUnitButton.UseVisualStyleBackColor = true;
            this.addUnitButton.Click += new System.EventHandler(this.addUnitButton_Click);
            // 
            // itemsListGroupBox
            // 
            this.itemsListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsListGroupBox.Controls.Add(this.searchLabel);
            this.itemsListGroupBox.Controls.Add(this.searchTextBox);
            this.itemsListGroupBox.Controls.Add(this.itemsDataGridView);
            this.itemsListGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.itemsListGroupBox.Location = new System.Drawing.Point(5, 393);
            this.itemsListGroupBox.Name = "itemsListGroupBox";
            this.itemsListGroupBox.Size = new System.Drawing.Size(450, 242);
            this.itemsListGroupBox.TabIndex = 1;
            this.itemsListGroupBox.TabStop = false;
            this.itemsListGroupBox.Text = "قائمة الأصناف";
            // 
            // newButton
            // 
            this.newButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.newButton.Location = new System.Drawing.Point(60, 641);
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
            this.saveButton.Location = new System.Drawing.Point(182, 641);
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
            this.deleteButton.Location = new System.Drawing.Point(304, 641);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(118, 33);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "حـــذف";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
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
            // ItemsForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 684);
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
            this.itemDataGroupBox.ResumeLayout(false);
            this.itemDataGroupBox.PerformLayout();
            this.itemsListGroupBox.ResumeLayout(false);
            this.itemsListGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.DataGridView itemUnitsDataGridView;
        private System.Windows.Forms.Label itemNameLabel;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemUnitIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceColumn;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}