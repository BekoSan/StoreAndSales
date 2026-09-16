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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.salesListGroupBox = new System.Windows.Forms.GroupBox();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            this.selectColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.customerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disscountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.bankakToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.bankakToolStripStatusValueLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cashToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cashToolStripStatusValueLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sepratorToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.salesListGroupBox.Size = new System.Drawing.Size(939, 435);
            this.salesListGroupBox.TabIndex = 9;
            this.salesListGroupBox.TabStop = false;
            this.salesListGroupBox.Text = "فواتير المبيعات";
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Location = new System.Drawing.Point(410, 171);
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
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
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.salesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.salesDataGridView.RowTemplate.Height = 24;
            this.salesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesDataGridView.Size = new System.Drawing.Size(933, 407);
            this.salesDataGridView.TabIndex = 0;
            this.salesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesDataGridView_CellContentClick);
            this.salesDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.salesDataGridView_CellFormatting);
            this.salesDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.salesDataGridView_RowPostPaint);
            this.salesDataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.salesDataGridView_RowPrePaint);
            this.salesDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.salesDataGridView_RowsAdded);
            // 
            // selectColumn
            // 
            this.selectColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle16.NullValue = "إختيار";
            this.selectColumn.DefaultCellStyle = dataGridViewCellStyle16;
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
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customerNameColumn.DefaultCellStyle = dataGridViewCellStyle17;
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
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Format = "d";
            this.purchaseDateColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.purchaseDateColumn.HeaderText = "التاريخ";
            this.purchaseDateColumn.MinimumWidth = 6;
            this.purchaseDateColumn.Name = "purchaseDateColumn";
            this.purchaseDateColumn.ReadOnly = true;
            this.purchaseDateColumn.Width = 149;
            // 
            // totalColumn
            // 
            this.totalColumn.DataPropertyName = "Total";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Format = "N";
            this.totalColumn.DefaultCellStyle = dataGridViewCellStyle19;
            this.totalColumn.HeaderText = "الإجمالي";
            this.totalColumn.MinimumWidth = 6;
            this.totalColumn.Name = "totalColumn";
            this.totalColumn.ReadOnly = true;
            // 
            // disscountColumn
            // 
            this.disscountColumn.DataPropertyName = "Disscount";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Format = "N";
            this.disscountColumn.DefaultCellStyle = dataGridViewCellStyle20;
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
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 25F);
            this.titleLabel.Location = new System.Drawing.Point(318, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(302, 47);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "إختيار فاتورة مبيعات";
            // 
            // dateFromDateTimePicker
            // 
            this.dateFromDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateFromDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFromDateTimePicker.Location = new System.Drawing.Point(483, 106);
            this.dateFromDateTimePicker.Name = "dateFromDateTimePicker";
            this.dateFromDateTimePicker.ShowUpDown = true;
            this.dateFromDateTimePicker.Size = new System.Drawing.Size(132, 29);
            this.dateFromDateTimePicker.TabIndex = 11;
            this.dateFromDateTimePicker.ValueChanged += new System.EventHandler(this.dateFromDateTimePicker_ValueChanged);
            // 
            // dateFromLabel
            // 
            this.dateFromLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateFromLabel.AutoSize = true;
            this.dateFromLabel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.dateFromLabel.Location = new System.Drawing.Point(414, 109);
            this.dateFromLabel.Name = "dateFromLabel";
            this.dateFromLabel.Size = new System.Drawing.Size(79, 22);
            this.dateFromLabel.TabIndex = 12;
            this.dateFromLabel.Text = "الفتره من :";
            // 
            // dateToLabel
            // 
            this.dateToLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateToLabel.AutoSize = true;
            this.dateToLabel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.dateToLabel.Location = new System.Drawing.Point(616, 109);
            this.dateToLabel.Name = "dateToLabel";
            this.dateToLabel.Size = new System.Drawing.Size(79, 22);
            this.dateToLabel.TabIndex = 14;
            this.dateToLabel.Text = "إلى تاريخ :";
            // 
            // dateToDateTimePicker
            // 
            this.dateToDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateToDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateToDateTimePicker.Location = new System.Drawing.Point(689, 106);
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
            this.cashToolStripStatusLabel,
            this.cashToolStripStatusValueLabel,
            this.bankakToolStripStatusLabel,
            this.bankakToolStripStatusValueLabel,
            this.sepratorToolStripStatusLabel,
            this.periodTotalTextToolStripStatusLabel,
            this.periodTotalValueToolStripStatusLabel});
            this.periodTotalCostStatusStrip.Location = new System.Drawing.Point(0, 572);
            this.periodTotalCostStatusStrip.Name = "periodTotalCostStatusStrip";
            this.periodTotalCostStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.periodTotalCostStatusStrip.Size = new System.Drawing.Size(939, 35);
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
            this.customerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.customerNameLabel.Location = new System.Drawing.Point(117, 109);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(87, 22);
            this.customerNameLabel.TabIndex = 19;
            this.customerNameLabel.Text = "إسم العميل :";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customerNameTextBox.Location = new System.Drawing.Point(203, 106);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(205, 29);
            this.customerNameTextBox.TabIndex = 18;
            this.customerNameTextBox.TextChanged += new System.EventHandler(this.customerNameTextBox_TextChanged);
            // 
            // bankakToolStripStatusLabel
            // 
            this.bankakToolStripStatusLabel.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.bankakToolStripStatusLabel.Name = "bankakToolStripStatusLabel";
            this.bankakToolStripStatusLabel.Size = new System.Drawing.Size(56, 29);
            this.bankakToolStripStatusLabel.Text = "بنكك :";
            // 
            // bankakToolStripStatusValueLabel
            // 
            this.bankakToolStripStatusValueLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
            this.bankakToolStripStatusValueLabel.Name = "bankakToolStripStatusValueLabel";
            this.bankakToolStripStatusValueLabel.Size = new System.Drawing.Size(27, 29);
            this.bankakToolStripStatusValueLabel.Text = "0";
            // 
            // cashToolStripStatusLabel
            // 
            this.cashToolStripStatusLabel.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.cashToolStripStatusLabel.Name = "cashToolStripStatusLabel";
            this.cashToolStripStatusLabel.Size = new System.Drawing.Size(54, 29);
            this.cashToolStripStatusLabel.Text = "كاش :";
            // 
            // cashToolStripStatusValueLabel
            // 
            this.cashToolStripStatusValueLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
            this.cashToolStripStatusValueLabel.Name = "cashToolStripStatusValueLabel";
            this.cashToolStripStatusValueLabel.Size = new System.Drawing.Size(27, 29);
            this.cashToolStripStatusValueLabel.Text = "0";
            // 
            // sepratorToolStripStatusLabel
            // 
            this.sepratorToolStripStatusLabel.Name = "sepratorToolStripStatusLabel";
            this.sepratorToolStripStatusLabel.Size = new System.Drawing.Size(53, 29);
            this.sepratorToolStripStatusLabel.Text = "           ";
            // 
            // ChooseSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(939, 607);
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
        private System.Windows.Forms.ToolStripStatusLabel bankakToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel bankakToolStripStatusValueLabel;
        private System.Windows.Forms.ToolStripStatusLabel cashToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel cashToolStripStatusValueLabel;
        private System.Windows.Forms.ToolStripStatusLabel sepratorToolStripStatusLabel;
    }
}