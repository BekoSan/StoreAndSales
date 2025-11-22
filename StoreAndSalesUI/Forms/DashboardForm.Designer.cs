namespace StoreAndSalesUI.Forms
{
    partial class DashboardForm
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
            this.salesButton = new System.Windows.Forms.Button();
            this.purchasesButton = new System.Windows.Forms.Button();
            this.customersButton = new System.Windows.Forms.Button();
            this.suppliersButton = new System.Windows.Forms.Button();
            this.itemsButton = new System.Windows.Forms.Button();
            this.unitsButton = new System.Windows.Forms.Button();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.storePreviewButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.signOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 35F);
            this.titleLabel.Location = new System.Drawing.Point(208, 33);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(384, 66);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "نظام إدارة المخازن";
            // 
            // salesButton
            // 
            this.salesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.salesButton.Location = new System.Drawing.Point(217, 236);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(118, 33);
            this.salesButton.TabIndex = 1;
            this.salesButton.Tag = "2";
            this.salesButton.Text = "المبيعات";
            this.salesButton.UseVisualStyleBackColor = true;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // purchasesButton
            // 
            this.purchasesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchasesButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.purchasesButton.Location = new System.Drawing.Point(217, 197);
            this.purchasesButton.Name = "purchasesButton";
            this.purchasesButton.Size = new System.Drawing.Size(118, 33);
            this.purchasesButton.TabIndex = 2;
            this.purchasesButton.Tag = "3";
            this.purchasesButton.Text = "المشتريات";
            this.purchasesButton.UseVisualStyleBackColor = true;
            this.purchasesButton.Click += new System.EventHandler(this.purchasesButton_Click);
            // 
            // customersButton
            // 
            this.customersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customersButton.Location = new System.Drawing.Point(341, 236);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(118, 33);
            this.customersButton.TabIndex = 3;
            this.customersButton.Text = "العمـــلاء";
            this.customersButton.UseVisualStyleBackColor = true;
            this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
            // 
            // suppliersButton
            // 
            this.suppliersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suppliersButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.suppliersButton.Location = new System.Drawing.Point(341, 197);
            this.suppliersButton.Name = "suppliersButton";
            this.suppliersButton.Size = new System.Drawing.Size(118, 33);
            this.suppliersButton.TabIndex = 4;
            this.suppliersButton.Text = "الموردين";
            this.suppliersButton.UseVisualStyleBackColor = true;
            this.suppliersButton.Click += new System.EventHandler(this.suppliersButton_Click);
            // 
            // itemsButton
            // 
            this.itemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemsButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.itemsButton.Location = new System.Drawing.Point(465, 197);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Size = new System.Drawing.Size(118, 33);
            this.itemsButton.TabIndex = 5;
            this.itemsButton.Text = "الأصنــاف";
            this.itemsButton.UseVisualStyleBackColor = true;
            this.itemsButton.Click += new System.EventHandler(this.itemsButton_Click);
            // 
            // unitsButton
            // 
            this.unitsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unitsButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.unitsButton.Location = new System.Drawing.Point(465, 236);
            this.unitsButton.Name = "unitsButton";
            this.unitsButton.Size = new System.Drawing.Size(118, 33);
            this.unitsButton.TabIndex = 6;
            this.unitsButton.Text = "وحدات الأصناف";
            this.unitsButton.UseVisualStyleBackColor = true;
            this.unitsButton.Click += new System.EventHandler(this.unitsButton_Click);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyrightLabel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.copyrightLabel.Location = new System.Drawing.Point(6, 446);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(355, 22);
            this.copyrightLabel.TabIndex = 0;
            this.copyrightLabel.Text = "جميع الحقوق محفوظة لهاتسومي للبرمجيات 2024";
            // 
            // storePreviewButton
            // 
            this.storePreviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storePreviewButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.storePreviewButton.Location = new System.Drawing.Point(217, 275);
            this.storePreviewButton.Name = "storePreviewButton";
            this.storePreviewButton.Size = new System.Drawing.Size(118, 33);
            this.storePreviewButton.TabIndex = 7;
            this.storePreviewButton.Text = "إستعراض المخزن";
            this.storePreviewButton.UseVisualStyleBackColor = true;
            this.storePreviewButton.Click += new System.EventHandler(this.storePreviewButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.usersButton.Location = new System.Drawing.Point(465, 275);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(118, 33);
            this.usersButton.TabIndex = 8;
            this.usersButton.Text = "إدارة المستخدمين";
            this.usersButton.UseVisualStyleBackColor = true;
            // 
            // signOutButton
            // 
            this.signOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOutButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.signOutButton.Location = new System.Drawing.Point(678, 3);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(118, 33);
            this.signOutButton.TabIndex = 9;
            this.signOutButton.Text = "تسجيل الخروج";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.usersButton);
            this.Controls.Add(this.storePreviewButton);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.unitsButton);
            this.Controls.Add(this.itemsButton);
            this.Controls.Add(this.suppliersButton);
            this.Controls.Add(this.customersButton);
            this.Controls.Add(this.purchasesButton);
            this.Controls.Add(this.salesButton);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashboardForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "نظام إدارة المخـــازن";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button purchasesButton;
        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Button suppliersButton;
        private System.Windows.Forms.Button itemsButton;
        private System.Windows.Forms.Button unitsButton;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Button storePreviewButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button signOutButton;
    }
}

