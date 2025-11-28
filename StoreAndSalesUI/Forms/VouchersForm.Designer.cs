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
            this.titleLabel.Location = new System.Drawing.Point(2, 8);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(435, 66);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "سندات الدفع والإستلام";
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
            this.voucherDataGroupBox.Size = new System.Drawing.Size(400, 355);
            this.voucherDataGroupBox.TabIndex = 10;
            this.voucherDataGroupBox.TabStop = false;
            this.voucherDataGroupBox.Text = "بيانات السند";
            // 
            // remainingTotalLabel
            // 
            this.remainingTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.remainingTotalLabel.AutoSize = true;
            this.remainingTotalLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.remainingTotalLabel.Location = new System.Drawing.Point(282, 285);
            this.remainingTotalLabel.Name = "remainingTotalLabel";
            this.remainingTotalLabel.Size = new System.Drawing.Size(93, 19);
            this.remainingTotalLabel.TabIndex = 31;
            this.remainingTotalLabel.Text = "إجمالي المتبقي";
            // 
            // remainingTotalTextBox
            // 
            this.remainingTotalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.remainingTotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.remainingTotalTextBox.Enabled = false;
            this.remainingTotalTextBox.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.remainingTotalTextBox.Location = new System.Drawing.Point(19, 307);
            this.remainingTotalTextBox.MaxLength = 13;
            this.remainingTotalTextBox.Name = "remainingTotalTextBox";
            this.remainingTotalTextBox.Size = new System.Drawing.Size(363, 29);
            this.remainingTotalTextBox.TabIndex = 30;
            this.remainingTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.amountLabel.Location = new System.Drawing.Point(328, 225);
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
            this.amountTextBox.Location = new System.Drawing.Point(19, 248);
            this.amountTextBox.MaxLength = 13;
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(363, 29);
            this.amountTextBox.TabIndex = 2;
            this.amountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amountTextBox.TextChanged += new System.EventHandler(this.amountTextBox_TextChanged);
            this.amountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountTextBox_KeyPress);
            // 
            // invoicesComboBox
            // 
            this.invoicesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.invoicesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.invoicesComboBox.FormattingEnabled = true;
            this.invoicesComboBox.Location = new System.Drawing.Point(18, 189);
            this.invoicesComboBox.Name = "invoicesComboBox";
            this.invoicesComboBox.Size = new System.Drawing.Size(365, 29);
            this.invoicesComboBox.TabIndex = 1;
            this.invoicesComboBox.SelectedIndexChanged += new System.EventHandler(this.invoicesComboBox_SelectedIndexChanged);
            // 
            // invoicesLabel
            // 
            this.invoicesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.invoicesLabel.AutoSize = true;
            this.invoicesLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.invoicesLabel.Location = new System.Drawing.Point(299, 166);
            this.invoicesLabel.Name = "invoicesLabel";
            this.invoicesLabel.Size = new System.Drawing.Size(76, 19);
            this.invoicesLabel.TabIndex = 26;
            this.invoicesLabel.Text = "الفاتورة رقم";
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
            this.voucherIdLabel.Location = new System.Drawing.Point(305, 42);
            this.voucherIdLabel.Name = "voucherIdLabel";
            this.voucherIdLabel.Size = new System.Drawing.Size(70, 19);
            this.voucherIdLabel.TabIndex = 7;
            this.voucherIdLabel.Text = "رقم السنـــد";
            // 
            // voucherIdTextBox
            // 
            this.voucherIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.voucherIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.voucherIdTextBox.Enabled = false;
            this.voucherIdTextBox.Location = new System.Drawing.Point(210, 64);
            this.voucherIdTextBox.Name = "voucherIdTextBox";
            this.voucherIdTextBox.Size = new System.Drawing.Size(169, 29);
            this.voucherIdTextBox.TabIndex = 6;
            this.voucherIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(221, 483);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 33);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "حفــــظ";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // newButton
            // 
            this.newButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.newButton.Location = new System.Drawing.Point(99, 482);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(118, 33);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "جديد";
            this.newButton.UseVisualStyleBackColor = true;
            // 
            // VouchersForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 523);
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
            this.Text = "سندات الدفع والإستلام";
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
    }
}