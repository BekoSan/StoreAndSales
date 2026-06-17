namespace StoreAndSalesUI.Forms
{
    partial class ChooseSaleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.salesListGroupBox = new System.Windows.Forms.GroupBox();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            this.titleLabel = new System.Windows.Forms.Label();
            this.dateFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateFromLabel = new System.Windows.Forms.Label();
            this.dateToLabel = new System.Windows.Forms.Label();
            this.dateToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.periodTotalCostStatusStrip = new System.Windows.Forms.StatusStrip();
            this.periodTotalTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.periodTotalValueToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.selectColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.customerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disscountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            this.periodTotalCostStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // salesListGroupBox
            // 
            this.salesListGroupBox.Controls.Add(this.loadingLabel);
            this.salesListGroupBox.Controls.Add(this.salesDataGridView);
            this.salesListGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.salesListGroupBox.Location = new System.Drawing.Point(0, 134);
            this.salesListGroupBox.Name = "salesListGroupBox";
            this.salesListGroupBox.Size = new System.Drawing.Size(723, 351);
            this.salesListGroupBox.TabIndex = 9;
            this.salesListGroupBox.TabStop = false;
            this.salesListGroupBox.Text = "فواتير المبيعات";
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Location = new System.Drawing.Point(302, 164);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(119, 22);
            this.loadingLabel.TabIndex = 2;
            this.loadingLabel.Text = " جاري التحميل ...";
            this.loadingLabel.Visible = false;
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.AllowUserToAddRows = false;
            this.salesDataGridView.AllowUserToDeleteRows = false;
            this.salesDataGridView.AllowUserToResizeColumns = false;
            this.salesDataGridView.AllowUserToResizeRows = false;
            this.salesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.salesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.salesDataGridView.ColumnHeadersHeight = 29;
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.salesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectColumn,
            this.customerNameColumn,
            this.purchaseDateColumn,
            this.totalColumn,
            this.disscountColumn,
            this.saleIdColumn,
            this.coluserName});
            this.salesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesDataGridView.EnableHeadersVisualStyles = false;
            this.salesDataGridView.GridColor = System.Drawing.Color.Black;
            this.salesDataGridView.Location = new System.Drawing.Point(3, 25);
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.ReadOnly = true;
            this.salesDataGridView.RowHeadersVisible = false;
            this.salesDataGridView.RowHeadersWidth = 51;
            this.salesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.salesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.salesDataGridView.RowTemplate.Height = 24;
            this.salesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesDataGridView.Size = new System.Drawing.Size(717, 323);
            this.salesDataGridView.TabIndex = 0;
            this.salesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesDataGridView_CellContentClick);
            this.salesDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.salesDataGridView_RowPostPaint);
            this.salesDataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.salesDataGridView_RowPrePaint);
            this.salesDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.salesDataGridView_RowsAdded);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 25F);
            this.titleLabel.Location = new System.Drawing.Point(218, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(302, 47);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "إختيار فاتورة مبيعات";
            // 
            // dateFromDateTimePicker
            // 
            this.dateFromDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFromDateTimePicker.Location = new System.Drawing.Point(375, 106);
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
            this.dateFromLabel.Location = new System.Drawing.Point(306, 109);
            this.dateFromLabel.Name = "dateFromLabel";
            this.dateFromLabel.Size = new System.Drawing.Size(79, 22);
            this.dateFromLabel.TabIndex = 12;
            this.dateFromLabel.Text = "الفتره من :";
            // 
            // dateToLabel
            // 
            this.dateToLabel.AutoSize = true;
            this.dateToLabel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.dateToLabel.Location = new System.Drawing.Point(508, 109);
            this.dateToLabel.Name = "dateToLabel";
            this.dateToLabel.Size = new System.Drawing.Size(79, 22);
            this.dateToLabel.TabIndex = 14;
            this.dateToLabel.Text = "إلى تاريخ :";
            // 
            // dateToDateTimePicker
            // 
            this.dateToDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateToDateTimePicker.Location = new System.Drawing.Point(581, 106);
            this.dateToDateTimePicker.Name = "dateToDateTimePicker";
            this.dateToDateTimePicker.ShowUpDown = true;
            this.dateToDateTimePicker.Size = new System.Drawing.Size(132, 29);
            this.dateToDateTimePicker.TabIndex = 13;
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
            this.periodTotalCostStatusStrip.TabIndex = 16;
            this.periodTotalCostStatusStrip.Text = "statusStrip1";
            // 
            // periodTotalTextToolStripStatusLabel
            // 
            this.periodTotalTextToolStripStatusLabel.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.periodTotalTextToolStripStatusLabel.Name = "periodTotalTextToolStripStatusLabel";
            this.periodTotalTextToolStripStatusLabel.Size = new System.Drawing.Size(212, 29);
            this.periodTotalTextToolStripStatusLabel.Text = "إجمالي المبيعات خلال الفترة:";
            // 
            // periodTotalValueToolStripStatusLabel
            // 
            this.periodTotalValueToolStripStatusLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
            this.periodTotalValueToolStripStatusLabel.Name = "periodTotalValueToolStripStatusLabel";
            this.periodTotalValueToolStripStatusLabel.Size = new System.Drawing.Size(27, 29);
            this.periodTotalValueToolStripStatusLabel.Text = "0";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.customerNameLabel.Location = new System.Drawing.Point(9, 109);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(87, 22);
            this.customerNameLabel.TabIndex = 19;
            this.customerNameLabel.Text = "إسم العميل :";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerNameTextBox.Location = new System.Drawing.Point(95, 106);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(205, 29);
            this.customerNameTextBox.TabIndex = 18;
            this.customerNameTextBox.TextChanged += new System.EventHandler(this.customerNameTextBox_TextChanged);
            // 
            // selectColumn
            // 
            this.selectColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle2.NullValue = "إختيار";
            this.selectColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.selectColumn.HeaderText = "";
            this.selectColumn.MinimumWidth = 6;
            this.selectColumn.Name = "selectColumn";
            this.selectColumn.ReadOnly = true;
            this.selectColumn.Width = 70;
            // 
            // customerNameColumn
            // 
            this.customerNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.customerNameColumn.DataPropertyName = "CustomerName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customerNameColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.customerNameColumn.HeaderText = "إسم العميــل";
            this.customerNameColumn.MinimumWidth = 6;
            this.customerNameColumn.Name = "customerNameColumn";
            this.customerNameColumn.ReadOnly = true;
            this.customerNameColumn.Width = 250;
            // 
            // purchaseDateColumn
            // 
            this.purchaseDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.purchaseDateColumn.DataPropertyName = "SaleDate";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "d";
            this.purchaseDateColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.purchaseDateColumn.HeaderText = "التاريخ";
            this.purchaseDateColumn.MinimumWidth = 6;
            this.purchaseDateColumn.Name = "purchaseDateColumn";
            this.purchaseDateColumn.ReadOnly = true;
            this.purchaseDateColumn.Width = 149;
            // 
            // totalColumn
            // 
            this.totalColumn.DataPropertyName = "Total";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "N";
            this.totalColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.totalColumn.HeaderText = "الإجمالي";
            this.totalColumn.MinimumWidth = 6;
            this.totalColumn.Name = "totalColumn";
            this.totalColumn.ReadOnly = true;
            // 
            // disscountColumn
            // 
            this.disscountColumn.DataPropertyName = "Disscount";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "N";
            this.disscountColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.disscountColumn.HeaderText = "الخصم";
            this.disscountColumn.MinimumWidth = 6;
            this.disscountColumn.Name = "disscountColumn";
            this.disscountColumn.ReadOnly = true;
            // 
            // saleIdColumn
            // 
            this.saleIdColumn.DataPropertyName = "SaleId";
            this.saleIdColumn.HeaderText = "SaleId";
            this.saleIdColumn.MinimumWidth = 6;
            this.saleIdColumn.Name = "saleIdColumn";
            this.saleIdColumn.ReadOnly = true;
            this.saleIdColumn.Visible = false;
            // 
            // coluserName
            // 
            this.coluserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.coluserName.DataPropertyName = "UserName";
            this.coluserName.HeaderText = "المستخدم";
            this.coluserName.MinimumWidth = 6;
            this.coluserName.Name = "coluserName";
            this.coluserName.ReadOnly = true;
            this.coluserName.Width = 70;
            // 
            // ChooseSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 518);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.periodTotalCostStatusStrip);
            this.Controls.Add(this.dateToLabel);
            this.Controls.Add(this.dateToDateTimePicker);
            this.Controls.Add(this.dateFromLabel);
            this.Controls.Add(this.dateFromDateTimePicker);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.salesListGroupBox);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseSaleForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إختيار فاتورة مبيعات";
            this.Load += new System.EventHandler(this.ChooseSaleForm_Load);
            this.salesListGroupBox.ResumeLayout(false);
            this.salesListGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            this.periodTotalCostStatusStrip.ResumeLayout(false);
            this.periodTotalCostStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox salesListGroupBox;
        private System.Windows.Forms.DataGridView salesDataGridView;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DateTimePicker dateFromDateTimePicker;
        private System.Windows.Forms.Label dateFromLabel;
        private System.Windows.Forms.Label dateToLabel;
        private System.Windows.Forms.DateTimePicker dateToDateTimePicker;
        private System.Windows.Forms.StatusStrip periodTotalCostStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel periodTotalTextToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel periodTotalValueToolStripStatusLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.DataGridViewButtonColumn selectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disscountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluserName;
    }
}