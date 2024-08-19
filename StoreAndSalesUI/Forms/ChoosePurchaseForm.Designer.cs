namespace StoreAndSalesUI.Forms
{
    partial class ChoosePurchaseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            this.purchasesListGroupBox = new System.Windows.Forms.GroupBox();
            this.purchasesDataGridView = new System.Windows.Forms.DataGridView();
            this.selectColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.supplierNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disscountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleLabel = new System.Windows.Forms.Label();
            this.dateFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateFromLabel = new System.Windows.Forms.Label();
            this.dateToLabel = new System.Windows.Forms.Label();
            this.dateToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.periodTotalCostStatusStrip = new System.Windows.Forms.StatusStrip();
            this.periodTotalValueToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.periodTotalTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.supplierNameTextBox = new System.Windows.Forms.TextBox();
            this.supplierNameLabel = new System.Windows.Forms.Label();
            this.purchasesListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataGridView)).BeginInit();
            this.periodTotalCostStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // purchasesListGroupBox
            // 
            this.purchasesListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.purchasesListGroupBox.Controls.Add(this.purchasesDataGridView);
            this.purchasesListGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.purchasesListGroupBox.Location = new System.Drawing.Point(0, 134);
            this.purchasesListGroupBox.Name = "purchasesListGroupBox";
            this.purchasesListGroupBox.Size = new System.Drawing.Size(723, 359);
            this.purchasesListGroupBox.TabIndex = 9;
            this.purchasesListGroupBox.TabStop = false;
            this.purchasesListGroupBox.Text = "فواتير المشتريات";
            // 
            // purchasesDataGridView
            // 
            this.purchasesDataGridView.AllowUserToAddRows = false;
            this.purchasesDataGridView.AllowUserToDeleteRows = false;
            this.purchasesDataGridView.AllowUserToResizeColumns = false;
            this.purchasesDataGridView.AllowUserToResizeRows = false;
            this.purchasesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purchasesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.purchasesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.purchasesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchasesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.purchasesDataGridView.ColumnHeadersHeight = 29;
            this.purchasesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.purchasesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectColumn,
            this.supplierNameColumn,
            this.purchaseDateColumn,
            this.totalColumn,
            this.disscountColumn,
            this.IdColumn});
            this.purchasesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchasesDataGridView.EnableHeadersVisualStyles = false;
            this.purchasesDataGridView.GridColor = System.Drawing.Color.Black;
            this.purchasesDataGridView.Location = new System.Drawing.Point(3, 25);
            this.purchasesDataGridView.MultiSelect = false;
            this.purchasesDataGridView.Name = "purchasesDataGridView";
            this.purchasesDataGridView.ReadOnly = true;
            this.purchasesDataGridView.RowHeadersVisible = false;
            this.purchasesDataGridView.RowHeadersWidth = 51;
            this.purchasesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.Black;
            this.purchasesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle42;
            this.purchasesDataGridView.RowTemplate.Height = 24;
            this.purchasesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchasesDataGridView.Size = new System.Drawing.Size(717, 331);
            this.purchasesDataGridView.TabIndex = 0;
            this.purchasesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchasesDataGridView_CellContentClick);
            // 
            // selectColumn
            // 
            this.selectColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle37.NullValue = "إختيار";
            this.selectColumn.DefaultCellStyle = dataGridViewCellStyle37;
            this.selectColumn.HeaderText = "";
            this.selectColumn.MinimumWidth = 6;
            this.selectColumn.Name = "selectColumn";
            this.selectColumn.ReadOnly = true;
            this.selectColumn.Width = 70;
            // 
            // supplierNameColumn
            // 
            this.supplierNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.supplierNameColumn.DataPropertyName = "SupplierName";
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.supplierNameColumn.DefaultCellStyle = dataGridViewCellStyle38;
            this.supplierNameColumn.HeaderText = "إسم المــورد";
            this.supplierNameColumn.MinimumWidth = 6;
            this.supplierNameColumn.Name = "supplierNameColumn";
            this.supplierNameColumn.ReadOnly = true;
            this.supplierNameColumn.Width = 250;
            // 
            // purchaseDateColumn
            // 
            this.purchaseDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.purchaseDateColumn.DataPropertyName = "PurchaseDate";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.Format = "d";
            this.purchaseDateColumn.DefaultCellStyle = dataGridViewCellStyle39;
            this.purchaseDateColumn.HeaderText = "التاريخ";
            this.purchaseDateColumn.MinimumWidth = 6;
            this.purchaseDateColumn.Name = "purchaseDateColumn";
            this.purchaseDateColumn.ReadOnly = true;
            this.purchaseDateColumn.Width = 149;
            // 
            // totalColumn
            // 
            this.totalColumn.DataPropertyName = "Total";
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.Format = "N";
            this.totalColumn.DefaultCellStyle = dataGridViewCellStyle40;
            this.totalColumn.HeaderText = "الإجمالي";
            this.totalColumn.MinimumWidth = 6;
            this.totalColumn.Name = "totalColumn";
            this.totalColumn.ReadOnly = true;
            // 
            // disscountColumn
            // 
            this.disscountColumn.DataPropertyName = "Disscount";
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle41.Format = "N";
            this.disscountColumn.DefaultCellStyle = dataGridViewCellStyle41;
            this.disscountColumn.HeaderText = "الخصم";
            this.disscountColumn.MinimumWidth = 6;
            this.disscountColumn.Name = "disscountColumn";
            this.disscountColumn.ReadOnly = true;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "PurchaseId";
            this.IdColumn.HeaderText = "PurchaseId";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 25F);
            this.titleLabel.Location = new System.Drawing.Point(218, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(328, 47);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "إختيار فاتورة مشتريات";
            // 
            // dateFromDateTimePicker
            // 
            this.dateFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFromDateTimePicker.Location = new System.Drawing.Point(373, 96);
            this.dateFromDateTimePicker.Name = "dateFromDateTimePicker";
            this.dateFromDateTimePicker.ShowUpDown = true;
            this.dateFromDateTimePicker.Size = new System.Drawing.Size(132, 29);
            this.dateFromDateTimePicker.TabIndex = 11;
            this.dateFromDateTimePicker.ValueChanged += new System.EventHandler(this.dateFromDateTimePicker_ValueChanged);
            // 
            // dateFromLabel
            // 
            this.dateFromLabel.AutoSize = true;
            this.dateFromLabel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.dateFromLabel.Location = new System.Drawing.Point(301, 100);
            this.dateFromLabel.Name = "dateFromLabel";
            this.dateFromLabel.Size = new System.Drawing.Size(79, 22);
            this.dateFromLabel.TabIndex = 12;
            this.dateFromLabel.Text = "الفتره من :";
            // 
            // dateToLabel
            // 
            this.dateToLabel.AutoSize = true;
            this.dateToLabel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.dateToLabel.Location = new System.Drawing.Point(508, 99);
            this.dateToLabel.Name = "dateToLabel";
            this.dateToLabel.Size = new System.Drawing.Size(79, 22);
            this.dateToLabel.TabIndex = 14;
            this.dateToLabel.Text = "إلى تاريخ :";
            // 
            // dateToDateTimePicker
            // 
            this.dateToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateToDateTimePicker.Location = new System.Drawing.Point(581, 96);
            this.dateToDateTimePicker.Name = "dateToDateTimePicker";
            this.dateToDateTimePicker.ShowUpDown = true;
            this.dateToDateTimePicker.Size = new System.Drawing.Size(132, 29);
            this.dateToDateTimePicker.TabIndex = 13;
            this.dateToDateTimePicker.Value = new System.DateTime(2024, 7, 23, 15, 11, 0, 0);
            this.dateToDateTimePicker.ValueChanged += new System.EventHandler(this.dateToDateTimePicker_ValueChanged);
            // 
            // periodTotalCostStatusStrip
            // 
            this.periodTotalCostStatusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.periodTotalCostStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.periodTotalCostStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.periodTotalTextToolStripStatusLabel,
            this.periodTotalValueToolStripStatusLabel});
            this.periodTotalCostStatusStrip.Location = new System.Drawing.Point(0, 483);
            this.periodTotalCostStatusStrip.Name = "periodTotalCostStatusStrip";
            this.periodTotalCostStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.periodTotalCostStatusStrip.Size = new System.Drawing.Size(723, 35);
            this.periodTotalCostStatusStrip.TabIndex = 15;
            this.periodTotalCostStatusStrip.Text = "statusStrip1";
            // 
            // periodTotalValueToolStripStatusLabel
            // 
            this.periodTotalValueToolStripStatusLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
            this.periodTotalValueToolStripStatusLabel.Name = "periodTotalValueToolStripStatusLabel";
            this.periodTotalValueToolStripStatusLabel.Size = new System.Drawing.Size(27, 29);
            this.periodTotalValueToolStripStatusLabel.Text = "0";
            // 
            // periodTotalTextToolStripStatusLabel
            // 
            this.periodTotalTextToolStripStatusLabel.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.periodTotalTextToolStripStatusLabel.Name = "periodTotalTextToolStripStatusLabel";
            this.periodTotalTextToolStripStatusLabel.Size = new System.Drawing.Size(225, 29);
            this.periodTotalTextToolStripStatusLabel.Text = "إجمالي المشتريات خلال الفترة:";
            // 
            // supplierNameTextBox
            // 
            this.supplierNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.supplierNameTextBox.Location = new System.Drawing.Point(98, 96);
            this.supplierNameTextBox.Name = "supplierNameTextBox";
            this.supplierNameTextBox.Size = new System.Drawing.Size(205, 29);
            this.supplierNameTextBox.TabIndex = 16;
            this.supplierNameTextBox.TextChanged += new System.EventHandler(this.supplierNameTextBox_TextChanged);
            // 
            // supplierNameLabel
            // 
            this.supplierNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.supplierNameLabel.AutoSize = true;
            this.supplierNameLabel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.supplierNameLabel.Location = new System.Drawing.Point(12, 99);
            this.supplierNameLabel.Name = "supplierNameLabel";
            this.supplierNameLabel.Size = new System.Drawing.Size(89, 22);
            this.supplierNameLabel.TabIndex = 17;
            this.supplierNameLabel.Text = "إسم المـورد:";
            // 
            // ChoosePurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 518);
            this.Controls.Add(this.supplierNameLabel);
            this.Controls.Add(this.supplierNameTextBox);
            this.Controls.Add(this.periodTotalCostStatusStrip);
            this.Controls.Add(this.dateToLabel);
            this.Controls.Add(this.dateToDateTimePicker);
            this.Controls.Add(this.dateFromLabel);
            this.Controls.Add(this.dateFromDateTimePicker);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.purchasesListGroupBox);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoosePurchaseForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إختيار فاتورة مشتريات";
            this.Load += new System.EventHandler(this.ChoosePurchaseForm_Load);
            this.purchasesListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataGridView)).EndInit();
            this.periodTotalCostStatusStrip.ResumeLayout(false);
            this.periodTotalCostStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox purchasesListGroupBox;
        private System.Windows.Forms.DataGridView purchasesDataGridView;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DateTimePicker dateFromDateTimePicker;
        private System.Windows.Forms.Label dateFromLabel;
        private System.Windows.Forms.Label dateToLabel;
        private System.Windows.Forms.DateTimePicker dateToDateTimePicker;
        private System.Windows.Forms.DataGridViewButtonColumn selectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disscountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.StatusStrip periodTotalCostStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel periodTotalValueToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel periodTotalTextToolStripStatusLabel;
        private System.Windows.Forms.TextBox supplierNameTextBox;
        private System.Windows.Forms.Label supplierNameLabel;
    }
}