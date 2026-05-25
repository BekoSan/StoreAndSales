namespace StoreAndSalesUI.Forms
{
    partial class VouchersForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.customerVocuherRadioButton = new System.Windows.Forms.RadioButton();
            this.supplierVocuherRadioButton = new System.Windows.Forms.RadioButton();
            this.voucherDataGroupBox = new System.Windows.Forms.GroupBox();
            this.viewInvoiceLinkLabel = new System.Windows.Forms.LinkLabel();
            this.VoucherTypeComboBox = new System.Windows.Forms.ComboBox();
            this.VoucherTypeLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.AccountDetailsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.remainingTotalLabel = new System.Windows.Forms.Label();
            this.remainingTotalTextBox = new System.Windows.Forms.TextBox();
            this.voucherIdLabel = new System.Windows.Forms.Label();
            this.voucherIdTextBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.invoicesComboBox = new System.Windows.Forms.ComboBox();
            this.invoicesLabel = new System.Windows.Forms.Label();
            this.peopleComboBox = new System.Windows.Forms.ComboBox();
            this.peopleLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.voucherDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 35F);
            this.titleLabel.Location = new System.Drawing.Point(7, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(409, 66);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "سندات القبض والدفع";
            // 
            // customerVocuherRadioButton
            // 
            this.customerVocuherRadioButton.AutoSize = true;
            this.customerVocuherRadioButton.Checked = true;
            this.customerVocuherRadioButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customerVocuherRadioButton.Location = new System.Drawing.Point(97, 90);
            this.customerVocuherRadioButton.Name = "customerVocuherRadioButton";
            this.customerVocuherRadioButton.Size = new System.Drawing.Size(71, 23);
            this.customerVocuherRadioButton.TabIndex = 0;
            this.customerVocuherRadioButton.TabStop = true;
            this.customerVocuherRadioButton.Text = "عميــــل";
            this.customerVocuherRadioButton.UseVisualStyleBackColor = true;
            this.customerVocuherRadioButton.CheckedChanged += new System.EventHandler(this.customerVocuherRadioButton_CheckedChanged);
            // 
            // supplierVocuherRadioButton
            // 
            this.supplierVocuherRadioButton.AutoSize = true;
            this.supplierVocuherRadioButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.supplierVocuherRadioButton.Location = new System.Drawing.Point(231, 90);
            this.supplierVocuherRadioButton.Name = "supplierVocuherRadioButton";
            this.supplierVocuherRadioButton.Size = new System.Drawing.Size(73, 23);
            this.supplierVocuherRadioButton.TabIndex = 1;
            this.supplierVocuherRadioButton.Text = "مـــــورد";
            this.supplierVocuherRadioButton.UseVisualStyleBackColor = true;
            // 
            // voucherDataGroupBox
            // 
            this.voucherDataGroupBox.Controls.Add(this.viewInvoiceLinkLabel);
            this.voucherDataGroupBox.Controls.Add(this.VoucherTypeComboBox);
            this.voucherDataGroupBox.Controls.Add(this.VoucherTypeLabel);
            this.voucherDataGroupBox.Controls.Add(this.notesLabel);
            this.voucherDataGroupBox.Controls.Add(this.notesTextBox);
            this.voucherDataGroupBox.Controls.Add(this.AccountDetailsLinkLabel);
            this.voucherDataGroupBox.Controls.Add(this.balanceLabel);
            this.voucherDataGroupBox.Controls.Add(this.remainingTotalLabel);
            this.voucherDataGroupBox.Controls.Add(this.remainingTotalTextBox);
            this.voucherDataGroupBox.Controls.Add(this.voucherIdLabel);
            this.voucherDataGroupBox.Controls.Add(this.voucherIdTextBox);
            this.voucherDataGroupBox.Controls.Add(this.amountLabel);
            this.voucherDataGroupBox.Controls.Add(this.amountTextBox);
            this.voucherDataGroupBox.Controls.Add(this.invoicesComboBox);
            this.voucherDataGroupBox.Controls.Add(this.invoicesLabel);
            this.voucherDataGroupBox.Controls.Add(this.peopleComboBox);
            this.voucherDataGroupBox.Controls.Add(this.peopleLabel);
            this.voucherDataGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.voucherDataGroupBox.Location = new System.Drawing.Point(4, 119);
            this.voucherDataGroupBox.Name = "voucherDataGroupBox";
            this.voucherDataGroupBox.Size = new System.Drawing.Size(389, 586);
            this.voucherDataGroupBox.TabIndex = 10;
            this.voucherDataGroupBox.TabStop = false;
            // 
            // viewInvoiceLinkLabel
            // 
            this.viewInvoiceLinkLabel.AutoSize = true;
            this.viewInvoiceLinkLabel.Location = new System.Drawing.Point(40, 295);
            this.viewInvoiceLinkLabel.Name = "viewInvoiceLinkLabel";
            this.viewInvoiceLinkLabel.Size = new System.Drawing.Size(122, 22);
            this.viewInvoiceLinkLabel.TabIndex = 39;
            this.viewInvoiceLinkLabel.TabStop = true;
            this.viewInvoiceLinkLabel.Text = "إستعراض الفاتورة";
            this.viewInvoiceLinkLabel.Visible = false;
            this.viewInvoiceLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewInvoiceLinkLabel_LinkClicked);
            // 
            // VoucherTypeComboBox
            // 
            this.VoucherTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VoucherTypeComboBox.FormattingEnabled = true;
            this.VoucherTypeComboBox.Items.AddRange(new object[] {
            "سند إستلام",
            "سند دفع",
            "تصفية حساب",
            "إضافة نقدية"});
            this.VoucherTypeComboBox.Location = new System.Drawing.Point(35, 190);
            this.VoucherTypeComboBox.Name = "VoucherTypeComboBox";
            this.VoucherTypeComboBox.Size = new System.Drawing.Size(320, 29);
            this.VoucherTypeComboBox.TabIndex = 1;
            this.VoucherTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.VoucherTypeComboBox_SelectedIndexChanged);
            // 
            // VoucherTypeLabel
            // 
            this.VoucherTypeLabel.AutoSize = true;
            this.VoucherTypeLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.VoucherTypeLabel.Location = new System.Drawing.Point(285, 166);
            this.VoucherTypeLabel.Name = "VoucherTypeLabel";
            this.VoucherTypeLabel.Size = new System.Drawing.Size(77, 19);
            this.VoucherTypeLabel.TabIndex = 38;
            this.VoucherTypeLabel.Text = "نوع السنــــد";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.notesLabel.Location = new System.Drawing.Point(312, 469);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(47, 19);
            this.notesLabel.TabIndex = 36;
            this.notesLabel.Text = "التعليق";
            // 
            // notesTextBox
            // 
            this.notesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesTextBox.Location = new System.Drawing.Point(36, 493);
            this.notesTextBox.MaxLength = 2000;
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(319, 82);
            this.notesTextBox.TabIndex = 6;
            // 
            // AccountDetailsLinkLabel
            // 
            this.AccountDetailsLinkLabel.AutoSize = true;
            this.AccountDetailsLinkLabel.Location = new System.Drawing.Point(40, 235);
            this.AccountDetailsLinkLabel.Name = "AccountDetailsLinkLabel";
            this.AccountDetailsLinkLabel.Size = new System.Drawing.Size(86, 22);
            this.AccountDetailsLinkLabel.TabIndex = 34;
            this.AccountDetailsLinkLabel.TabStop = true;
            this.AccountDetailsLinkLabel.Text = "كشف حساب";
            this.AccountDetailsLinkLabel.Visible = false;
            this.AccountDetailsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AccountDetailsLinkLabel_LinkClicked);
            // 
            // balanceLabel
            // 
            this.balanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balanceLabel.Font = new System.Drawing.Font("Consolas", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(5, 18);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(374, 90);
            this.balanceLabel.TabIndex = 33;
            this.balanceLabel.Text = "0";
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remainingTotalLabel
            // 
            this.remainingTotalLabel.AutoSize = true;
            this.remainingTotalLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.remainingTotalLabel.Location = new System.Drawing.Point(271, 413);
            this.remainingTotalLabel.Name = "remainingTotalLabel";
            this.remainingTotalLabel.Size = new System.Drawing.Size(93, 19);
            this.remainingTotalLabel.TabIndex = 31;
            this.remainingTotalLabel.Text = "إجمالي المتبقي";
            // 
            // remainingTotalTextBox
            // 
            this.remainingTotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.remainingTotalTextBox.Enabled = false;
            this.remainingTotalTextBox.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.remainingTotalTextBox.Location = new System.Drawing.Point(37, 435);
            this.remainingTotalTextBox.MaxLength = 13;
            this.remainingTotalTextBox.Name = "remainingTotalTextBox";
            this.remainingTotalTextBox.Size = new System.Drawing.Size(318, 29);
            this.remainingTotalTextBox.TabIndex = 5;
            this.remainingTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // voucherIdLabel
            // 
            this.voucherIdLabel.AutoSize = true;
            this.voucherIdLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.voucherIdLabel.Location = new System.Drawing.Point(291, 112);
            this.voucherIdLabel.Name = "voucherIdLabel";
            this.voucherIdLabel.Size = new System.Drawing.Size(70, 19);
            this.voucherIdLabel.TabIndex = 7;
            this.voucherIdLabel.Text = "رقم السنـــد";
            // 
            // voucherIdTextBox
            // 
            this.voucherIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.voucherIdTextBox.Enabled = false;
            this.voucherIdTextBox.Location = new System.Drawing.Point(202, 134);
            this.voucherIdTextBox.Name = "voucherIdTextBox";
            this.voucherIdTextBox.Size = new System.Drawing.Size(148, 29);
            this.voucherIdTextBox.TabIndex = 0;
            this.voucherIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.amountLabel.Location = new System.Drawing.Point(312, 356);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(47, 19);
            this.amountLabel.TabIndex = 29;
            this.amountLabel.Text = "المبلــغ";
            // 
            // amountTextBox
            // 
            this.amountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountTextBox.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.amountTextBox.Location = new System.Drawing.Point(37, 379);
            this.amountTextBox.MaxLength = 13;
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(318, 29);
            this.amountTextBox.TabIndex = 4;
            this.amountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amountTextBox.TextChanged += new System.EventHandler(this.amountTextBox_TextChanged);
            this.amountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountTextBox_KeyPress);
            // 
            // invoicesComboBox
            // 
            this.invoicesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.invoicesComboBox.Enabled = false;
            this.invoicesComboBox.FormattingEnabled = true;
            this.invoicesComboBox.Location = new System.Drawing.Point(35, 322);
            this.invoicesComboBox.Name = "invoicesComboBox";
            this.invoicesComboBox.Size = new System.Drawing.Size(320, 29);
            this.invoicesComboBox.TabIndex = 3;
            this.invoicesComboBox.SelectedIndexChanged += new System.EventHandler(this.invoicesComboBox_SelectedIndexChanged);
            // 
            // invoicesLabel
            // 
            this.invoicesLabel.AutoSize = true;
            this.invoicesLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.invoicesLabel.Location = new System.Drawing.Point(286, 299);
            this.invoicesLabel.Name = "invoicesLabel";
            this.invoicesLabel.Size = new System.Drawing.Size(76, 19);
            this.invoicesLabel.TabIndex = 26;
            this.invoicesLabel.Text = "الفاتورة رقم";
            // 
            // peopleComboBox
            // 
            this.peopleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.peopleComboBox.FormattingEnabled = true;
            this.peopleComboBox.Location = new System.Drawing.Point(35, 260);
            this.peopleComboBox.Name = "peopleComboBox";
            this.peopleComboBox.Size = new System.Drawing.Size(320, 29);
            this.peopleComboBox.TabIndex = 2;
            this.peopleComboBox.SelectedIndexChanged += new System.EventHandler(this.peopleComboBox_SelectedIndexChanged);
            // 
            // peopleLabel
            // 
            this.peopleLabel.AutoSize = true;
            this.peopleLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.peopleLabel.Location = new System.Drawing.Point(285, 237);
            this.peopleLabel.Name = "peopleLabel";
            this.peopleLabel.Size = new System.Drawing.Size(77, 19);
            this.peopleLabel.TabIndex = 24;
            this.peopleLabel.Text = "حساب السيد";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(193, 712);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(103, 33);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "حفــــظ";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newButton
            // 
            this.newButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.newButton.Location = new System.Drawing.Point(87, 711);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(103, 33);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "جديد";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // VouchersForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 752);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.voucherDataGroupBox);
            this.Controls.Add(this.supplierVocuherRadioButton);
            this.Controls.Add(this.customerVocuherRadioButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VouchersForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سداد الديون";
            this.Load += new System.EventHandler(this.VouchersForm_Load);
            this.voucherDataGroupBox.ResumeLayout(false);
            this.voucherDataGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.RadioButton customerVocuherRadioButton;
        private System.Windows.Forms.RadioButton supplierVocuherRadioButton;
        private System.Windows.Forms.GroupBox voucherDataGroupBox;
        private System.Windows.Forms.Label voucherIdLabel;
        private System.Windows.Forms.TextBox voucherIdTextBox;
        private System.Windows.Forms.ComboBox peopleComboBox;
        private System.Windows.Forms.Label peopleLabel;
        private System.Windows.Forms.ComboBox invoicesComboBox;
        private System.Windows.Forms.Label invoicesLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label remainingTotalLabel;
        private System.Windows.Forms.TextBox remainingTotalTextBox;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.LinkLabel AccountDetailsLinkLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.ComboBox VoucherTypeComboBox;
        private System.Windows.Forms.Label VoucherTypeLabel;
        private System.Windows.Forms.LinkLabel viewInvoiceLinkLabel;
    }
}