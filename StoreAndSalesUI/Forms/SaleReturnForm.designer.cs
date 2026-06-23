namespace StoreAndSalesUI.Forms
{
    partial class SaleReturnForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblReturnTotal = new System.Windows.Forms.Label();
            this.txtReturnTotal = new System.Windows.Forms.TextBox();
            this.dgvReturnDetails = new System.Windows.Forms.DataGridView();
            this.colItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOriginalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlreadyReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemainingQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnReturnAll = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnDetails)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblInvoiceNo);
            this.pnlHeader.Controls.Add(this.txtInvoiceNo);
            this.pnlHeader.Controls.Add(this.lblCustomer);
            this.pnlHeader.Controls.Add(this.txtCustomer);
            this.pnlHeader.Controls.Add(this.lblReturnTotal);
            this.pnlHeader.Controls.Add(this.txtReturnTotal);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 104);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(280, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "مرتجع مبيعات";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Location = new System.Drawing.Point(703, 60);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(73, 19);
            this.lblInvoiceNo.TabIndex = 1;
            this.lblInvoiceNo.Text = "رقم الفاتورة";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(593, 57);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(100, 26);
            this.txtInvoiceNo.TabIndex = 2;
            this.txtInvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(524, 60);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(44, 19);
            this.lblCustomer.TabIndex = 3;
            this.lblCustomer.Text = "العميل";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(324, 57);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(190, 26);
            this.txtCustomer.TabIndex = 4;
            this.txtCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblReturnTotal
            // 
            this.lblReturnTotal.AutoSize = true;
            this.lblReturnTotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblReturnTotal.Location = new System.Drawing.Point(172, 60);
            this.lblReturnTotal.Name = "lblReturnTotal";
            this.lblReturnTotal.Size = new System.Drawing.Size(96, 19);
            this.lblReturnTotal.TabIndex = 5;
            this.lblReturnTotal.Text = "إجمالي المرتجع";
            // 
            // txtReturnTotal
            // 
            this.txtReturnTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtReturnTotal.Location = new System.Drawing.Point(12, 57);
            this.txtReturnTotal.Name = "txtReturnTotal";
            this.txtReturnTotal.ReadOnly = true;
            this.txtReturnTotal.Size = new System.Drawing.Size(154, 27);
            this.txtReturnTotal.TabIndex = 6;
            this.txtReturnTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvReturnDetails
            // 
            this.dgvReturnDetails.AllowUserToAddRows = false;
            this.dgvReturnDetails.AllowUserToDeleteRows = false;
            this.dgvReturnDetails.AllowUserToResizeRows = false;
            this.dgvReturnDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReturnDetails.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9.75F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturnDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvReturnDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemId,
            this.colItemName,
            this.colPrice,
            this.colOriginalQty,
            this.colAlreadyReturned,
            this.colRemainingQty,
            this.colReturnQty,
            this.colUnitID});
            this.dgvReturnDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReturnDetails.EnableHeadersVisualStyles = false;
            this.dgvReturnDetails.Location = new System.Drawing.Point(0, 104);
            this.dgvReturnDetails.Name = "dgvReturnDetails";
            this.dgvReturnDetails.RowHeadersVisible = false;
            this.dgvReturnDetails.RowHeadersWidth = 51;
            this.dgvReturnDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnDetails.Size = new System.Drawing.Size(800, 313);
            this.dgvReturnDetails.TabIndex = 1;
            // 
            // colItemId
            // 
            this.colItemId.HeaderText = "ItemId";
            this.colItemId.MinimumWidth = 6;
            this.colItemId.Name = "colItemId";
            this.colItemId.Visible = false;
            // 
            // colItemName
            // 
            this.colItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItemName.HeaderText = "الصنف";
            this.colItemName.MinimumWidth = 6;
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "السعر";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colOriginalQty
            // 
            this.colOriginalQty.HeaderText = "الكمية الأصلية";
            this.colOriginalQty.MinimumWidth = 6;
            this.colOriginalQty.Name = "colOriginalQty";
            this.colOriginalQty.ReadOnly = true;
            // 
            // colAlreadyReturned
            // 
            this.colAlreadyReturned.HeaderText = "مرتجع سابقاً";
            this.colAlreadyReturned.MinimumWidth = 6;
            this.colAlreadyReturned.Name = "colAlreadyReturned";
            this.colAlreadyReturned.ReadOnly = true;
            // 
            // colRemainingQty
            // 
            this.colRemainingQty.HeaderText = "المتبقي";
            this.colRemainingQty.MinimumWidth = 6;
            this.colRemainingQty.Name = "colRemainingQty";
            this.colRemainingQty.ReadOnly = true;
            // 
            // colReturnQty
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightYellow;
            this.colReturnQty.DefaultCellStyle = dataGridViewCellStyle10;
            this.colReturnQty.HeaderText = "الكمية المرتجعة";
            this.colReturnQty.MinimumWidth = 6;
            this.colReturnQty.Name = "colReturnQty";
            // 
            // colUnitID
            // 
            this.colUnitID.HeaderText = "UnitId";
            this.colUnitID.MinimumWidth = 6;
            this.colUnitID.Name = "colUnitID";
            this.colUnitID.Visible = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnReturnAll);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 417);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(800, 57);
            this.pnlFooter.TabIndex = 2;
            // 
            // btnReturnAll
            // 
            this.btnReturnAll.Location = new System.Drawing.Point(480, 13);
            this.btnReturnAll.Name = "btnReturnAll";
            this.btnReturnAll.Size = new System.Drawing.Size(180, 32);
            this.btnReturnAll.TabIndex = 0;
            this.btnReturnAll.Text = "إرجاع الفاتورة بالكامل";
            this.btnReturnAll.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(286, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 32);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "حفظ المرتجع";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(140, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 32);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // SaleReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.dgvReturnDetails);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.MinimumSize = new System.Drawing.Size(700, 429);
            this.Name = "SaleReturnForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مرتجع مبيعات";
            this.Load += new System.EventHandler(this.SaleReturnForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnDetails)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblReturnTotal;
        private System.Windows.Forms.TextBox txtReturnTotal;
        private System.Windows.Forms.DataGridView dgvReturnDetails;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnReturnAll;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOriginalQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlreadyReturned;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemainingQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturnQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitID;
    }
}
