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
            this.notesLabel = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.AccountDetailsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.remainingTotalLabel = new System.Windows.Forms.Label();
            this.remainingTotalTextBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.invoicesComboBox = new System.Windows.Forms.ComboBox();
            this.invoicesLabel = new System.Windows.Forms.Label();
            this.peopleComboBox = new System.Windows.Forms.ComboBox();
            this.peopleLabel = new System.Windows.Forms.Label();
            this.voucherIdLabel = new System.Windows.Forms.Label();
            this.voucherIdTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.voucherDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 35F);
            this.titleLabel.Location = new System.Drawing.Point(87, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(265, 66);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "سداد الــديون";
            // 
            // customerVocuherRadioButton
            // 
            this.customerVocuherRadioButton.AutoSize = true;
            this.customerVocuherRadioButton.Checked = true;
            this.customerVocuherRadioButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customerVocuherRadioButton.Location = new System.Drawing.Point(111, 90);
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
            this.supplierVocuherRadioButton.Location = new System.Drawing.Point(264, 90);
            this.supplierVocuherRadioButton.Name = "supplierVocuherRadioButton";
            this.supplierVocuherRadioButton.Size = new System.Drawing.Size(73, 23);
            this.supplierVocuherRadioButton.TabIndex = 1;
            this.supplierVocuherRadioButton.Text = "مـــــورد";
            this.supplierVocuherRadioButton.UseVisualStyleBackColor = true;
            // 
            // voucherDataGroupBox
            // 
            this.voucherDataGroupBox.Controls.Add(this.notesLabel);
            this.voucherDataGroupBox.Controls.Add(this.notesTextBox);
            this.voucherDataGroupBox.Controls.Add(this.AccountDetailsLinkLabel);
            this.voucherDataGroupBox.Controls.Add(this.balanceLabel);
            this.voucherDataGroupBox.Controls.Add(this.remainingTotalLabel);
            this.voucherDataGroupBox.Controls.Add(this.remainingTotalTextBox);
            this.voucherDataGroupBox.Controls.Add(this.amountLabel);
            this.voucherDataGroupBox.Controls.Add(this.amountTextBox);
            this.voucherDataGroupBox.Controls.Add(this.invoicesComboBox);
            this.voucherDataGroupBox.Controls.Add(this.invoicesLabel);
            this.voucherDataGroupBox.Controls.Add(this.peopleComboBox);
            this.voucherDataGroupBox.Controls.Add(this.peopleLabel);
            this.voucherDataGroupBox.Controls.Add(this.voucherIdLabel);
            this.voucherDataGroupBox.Controls.Add(this.voucherIdTextBox);
            this.voucherDataGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.voucherDataGroupBox.Location = new System.Drawing.Point(19, 117);
            this.voucherDataGroupBox.Name = "voucherDataGroupBox";
            this.voucherDataGroupBox.Size = new System.Drawing.Size(400, 334);
            this.voucherDataGroupBox.TabIndex = 10;
            this.voucherDataGroupBox.TabStop = false;
            // 
            // notesLabel
            // 
            this.notesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.notesLabel.Location = new System.Drawing.Point(329, 220);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(47, 19);
            this.notesLabel.TabIndex = 36;
            this.notesLabel.Text = "التعليق";
            // 
            // notesTextBox
            // 
            this.notesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesTextBox.Location = new System.Drawing.Point(17, 243);
            this.notesTextBox.MaxLength = 2000;
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(364, 82);
            this.notesTextBox.TabIndex = 2;
            // 
            // AccountDetailsLinkLabel
            // 
            this.AccountDetailsLinkLabel.AutoSize = true;
            this.AccountDetailsLinkLabel.Location = new System.Drawing.Point(23, 106);
            this.AccountDetailsLinkLabel.Name = "AccountDetailsLinkLabel";
            this.AccountDetailsLinkLabel.Size = new System.Drawing.Size(86, 22);
            this.AccountDetailsLinkLabel.TabIndex = 34;
            this.AccountDetailsLinkLabel.TabStop = true;
            this.AccountDetailsLinkLabel.Text = "كشف حساب";
            this.AccountDetailsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AccountDetailsLinkLabel_LinkClicked);
            // 
            // balanceLabel
            // 
            this.balanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balanceLabel.Font = new System.Drawing.Font("Consolas", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(6, 18);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(388, 90);
            this.balanceLabel.TabIndex = 33;
            this.balanceLabel.Text = "0";
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remainingTotalLabel
            // 
            this.remainingTotalLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.remainingTotalLabel.AutoSize = true;
            this.remainingTotalLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.remainingTotalLabel.Location = new System.Drawing.Point(282, 388);
            this.remainingTotalLabel.Name = "remainingTotalLabel";
            this.remainingTotalLabel.Size = new System.Drawing.Size(93, 19);
            this.remainingTotalLabel.TabIndex = 31;
            this.remainingTotalLabel.Text = "إجمالي المتبقي";
            this.remainingTotalLabel.Visible = false;
            // 
            // remainingTotalTextBox
            // 
            this.remainingTotalTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.remainingTotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.remainingTotalTextBox.Enabled = false;
            this.remainingTotalTextBox.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.remainingTotalTextBox.Location = new System.Drawing.Point(19, 410);
            this.remainingTotalTextBox.MaxLength = 13;
            this.remainingTotalTextBox.Name = "remainingTotalTextBox";
            this.remainingTotalTextBox.Size = new System.Drawing.Size(363, 29);
            this.remainingTotalTextBox.TabIndex = 30;
            this.remainingTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.remainingTotalTextBox.Visible = false;
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.amountLabel.Location = new System.Drawing.Point(326, 164);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(47, 19);
            this.amountLabel.TabIndex = 29;
            this.amountLabel.Text = "المبلــغ";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountTextBox.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.amountTextBox.Location = new System.Drawing.Point(17, 187);
            this.amountTextBox.MaxLength = 13;
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(363, 29);
            this.amountTextBox.TabIndex = 1;
            this.amountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amountTextBox.TextChanged += new System.EventHandler(this.amountTextBox_TextChanged);
            this.amountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountTextBox_KeyPress);
            // 
            // invoicesComboBox
            // 
            this.invoicesComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.invoicesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.invoicesComboBox.FormattingEnabled = true;
            this.invoicesComboBox.Location = new System.Drawing.Point(17, 354);
            this.invoicesComboBox.Name = "invoicesComboBox";
            this.invoicesComboBox.Size = new System.Drawing.Size(365, 29);
            this.invoicesComboBox.TabIndex = 1;
            this.invoicesComboBox.Visible = false;
            this.invoicesComboBox.SelectedIndexChanged += new System.EventHandler(this.invoicesComboBox_SelectedIndexChanged);
            // 
            // invoicesLabel
            // 
            this.invoicesLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.invoicesLabel.AutoSize = true;
            this.invoicesLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.invoicesLabel.Location = new System.Drawing.Point(298, 341);
            this.invoicesLabel.Name = "invoicesLabel";
            this.invoicesLabel.Size = new System.Drawing.Size(76, 19);
            this.invoicesLabel.TabIndex = 26;
            this.invoicesLabel.Text = "الفاتورة رقم";
            this.invoicesLabel.Visible = false;
            // 
            // peopleComboBox
            // 
            this.peopleComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.peopleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.peopleComboBox.FormattingEnabled = true;
            this.peopleComboBox.Location = new System.Drawing.Point(20, 130);
            this.peopleComboBox.Name = "peopleComboBox";
            this.peopleComboBox.Size = new System.Drawing.Size(361, 29);
            this.peopleComboBox.TabIndex = 0;
            this.peopleComboBox.SelectedIndexChanged += new System.EventHandler(this.peopleComboBox_SelectedIndexChanged);
            // 
            // peopleLabel
            // 
            this.peopleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.peopleLabel.AutoSize = true;
            this.peopleLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.peopleLabel.Location = new System.Drawing.Point(298, 108);
            this.peopleLabel.Name = "peopleLabel";
            this.peopleLabel.Size = new System.Drawing.Size(77, 19);
            this.peopleLabel.TabIndex = 24;
            this.peopleLabel.Text = "حساب السيد";
            // 
            // voucherIdLabel
            // 
            this.voucherIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.voucherIdLabel.AutoSize = true;
            this.voucherIdLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.voucherIdLabel.Location = new System.Drawing.Point(89, 341);
            this.voucherIdLabel.Name = "voucherIdLabel";
            this.voucherIdLabel.Size = new System.Drawing.Size(70, 19);
            this.voucherIdLabel.TabIndex = 7;
            this.voucherIdLabel.Text = "رقم السنـــد";
            this.voucherIdLabel.Visible = false;
            // 
            // voucherIdTextBox
            // 
            this.voucherIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.voucherIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.voucherIdTextBox.Enabled = false;
            this.voucherIdTextBox.Location = new System.Drawing.Point(-6, 363);
            this.voucherIdTextBox.Name = "voucherIdTextBox";
            this.voucherIdTextBox.Size = new System.Drawing.Size(169, 29);
            this.voucherIdTextBox.TabIndex = 6;
            this.voucherIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.voucherIdTextBox.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(221, 458);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 33);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "حفــــظ";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newButton
            // 
            this.newButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.newButton.Location = new System.Drawing.Point(99, 457);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(118, 33);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "جديد";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // VouchersForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 498);
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
    }
}