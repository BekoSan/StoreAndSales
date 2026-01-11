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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backupFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 35F);
            this.titleLabel.Location = new System.Drawing.Point(160, 33);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(480, 66);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "المنقوري للمعدات الطبية";
            this.titleLabel.Visible = false;
            // 
            // salesButton
            // 
            this.salesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(219)))), ((int)(((byte)(106)))));
            this.salesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(82)))), ((int)(((byte)(46)))));
            this.salesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(251)))), ((int)(((byte)(234)))));
            this.salesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.salesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(82)))), ((int)(((byte)(46)))));
            this.salesButton.Location = new System.Drawing.Point(191, 236);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(144, 33);
            this.salesButton.TabIndex = 1;
            this.salesButton.Tag = "2";
            this.salesButton.Text = "المبيعات";
            this.salesButton.UseVisualStyleBackColor = false;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // purchasesButton
            // 
            this.purchasesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(219)))), ((int)(((byte)(106)))));
            this.purchasesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(82)))), ((int)(((byte)(46)))));
            this.purchasesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(251)))), ((int)(((byte)(234)))));
            this.purchasesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchasesButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.purchasesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(82)))), ((int)(((byte)(46)))));
            this.purchasesButton.Location = new System.Drawing.Point(191, 197);
            this.purchasesButton.Name = "purchasesButton";
            this.purchasesButton.Size = new System.Drawing.Size(144, 33);
            this.purchasesButton.TabIndex = 2;
            this.purchasesButton.Tag = "3";
            this.purchasesButton.Text = "المشتريات";
            this.purchasesButton.UseVisualStyleBackColor = false;
            this.purchasesButton.Click += new System.EventHandler(this.purchasesButton_Click);
            // 
            // customersButton
            // 
            this.customersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(219)))), ((int)(((byte)(106)))));
            this.customersButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(82)))), ((int)(((byte)(46)))));
            this.customersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(251)))), ((int)(((byte)(234)))));
            this.customersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.customersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(82)))), ((int)(((byte)(46)))));
            this.customersButton.Location = new System.Drawing.Point(341, 236);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(118, 33);
            this.customersButton.TabIndex = 3;
            this.customersButton.Text = "العمـــلاء";
            this.customersButton.UseVisualStyleBackColor = false;
            this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
            // 
            // suppliersButton
            // 
            this.suppliersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(219)))), ((int)(((byte)(106)))));
            this.suppliersButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(82)))), ((int)(((byte)(46)))));
            this.suppliersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(251)))), ((int)(((byte)(234)))));
            this.suppliersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suppliersButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.suppliersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(82)))), ((int)(((byte)(46)))));
            this.suppliersButton.Location = new System.Drawing.Point(341, 197);
            this.suppliersButton.Name = "suppliersButton";
            this.suppliersButton.Size = new System.Drawing.Size(118, 33);
            this.suppliersButton.TabIndex = 4;
            this.suppliersButton.Text = "الموردين";
            this.suppliersButton.UseVisualStyleBackColor = false;
            this.suppliersButton.Click += new System.EventHandler(this.suppliersButton_Click);
            // 
            // itemsButton
            // 
            this.itemsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(219)))), ((int)(((byte)(106)))));
            this.itemsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(82)))), ((int)(((byte)(46)))));
            this.itemsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(251)))), ((int)(((byte)(234)))));
            this.itemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemsButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.itemsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(82)))), ((int)(((byte)(46)))));
            this.itemsButton.Location = new System.Drawing.Point(465, 197);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Size = new System.Drawing.Size(148, 33);
            this.itemsButton.TabIndex = 5;
            this.itemsButton.Text = "الأصنــاف";
            this.itemsButton.UseVisualStyleBackColor = false;
            this.itemsButton.Click += new System.EventHandler(this.itemsButton_Click);
            // 
            // unitsButton
            // 
            this.unitsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(219)))), ((int)(((byte)(106)))));
            this.unitsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(82)))), ((int)(((byte)(46)))));
            this.unitsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(251)))), ((int)(((byte)(234)))));
            this.unitsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unitsButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.unitsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(82)))), ((int)(((byte)(46)))));
            this.unitsButton.Location = new System.Drawing.Point(465, 236);
            this.unitsButton.Name = "unitsButton";
            this.unitsButton.Size = new System.Drawing.Size(148, 33);
            this.unitsButton.TabIndex = 6;
            this.unitsButton.Text = "وحدات الأصناف";
            this.unitsButton.UseVisualStyleBackColor = false;
            this.unitsButton.Click += new System.EventHandler(this.unitsButton_Click);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyrightLabel.BackColor = System.Drawing.Color.Transparent;
            this.copyrightLabel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.copyrightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(82)))), ((int)(((byte)(46)))));
            this.copyrightLabel.Location = new System.Drawing.Point(1, 449);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(355, 22);
            this.copyrightLabel.TabIndex = 0;
            this.copyrightLabel.Text = "جميع الحقوق محفوظة لهاتسومي للبرمجيات 2025";
            // 
            // storePreviewButton
            // 
            this.storePreviewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(219)))), ((int)(((byte)(106)))));
            this.storePreviewButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(82)))), ((int)(((byte)(46)))));
            this.storePreviewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(251)))), ((int)(((byte)(234)))));
            this.storePreviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storePreviewButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.storePreviewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(82)))), ((int)(((byte)(46)))));
            this.storePreviewButton.Location = new System.Drawing.Point(191, 275);
            this.storePreviewButton.Name = "storePreviewButton";
            this.storePreviewButton.Size = new System.Drawing.Size(144, 33);
            this.storePreviewButton.TabIndex = 7;
            this.storePreviewButton.Text = "إستعراض المخزن";
            this.storePreviewButton.UseVisualStyleBackColor = false;
            this.storePreviewButton.Click += new System.EventHandler(this.storePreviewButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(219)))), ((int)(((byte)(106)))));
            this.usersButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(82)))), ((int)(((byte)(46)))));
            this.usersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(251)))), ((int)(((byte)(234)))));
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.usersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(82)))), ((int)(((byte)(46)))));
            this.usersButton.Location = new System.Drawing.Point(463, 275);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(150, 33);
            this.usersButton.TabIndex = 8;
            this.usersButton.Text = "إدارة المستخدمين";
            this.usersButton.UseVisualStyleBackColor = false;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // signOutButton
            // 
            this.signOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(219)))), ((int)(((byte)(106)))));
            this.signOutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(82)))), ((int)(((byte)(46)))));
            this.signOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(251)))), ((int)(((byte)(234)))));
            this.signOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOutButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.signOutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(82)))), ((int)(((byte)(46)))));
            this.signOutButton.Location = new System.Drawing.Point(678, 3);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(118, 33);
            this.signOutButton.TabIndex = 9;
            this.signOutButton.Text = "تسجيل الخروج";
            this.signOutButton.UseVisualStyleBackColor = false;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(795, 471);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // backupFormButton
            // 
            this.backupFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(219)))), ((int)(((byte)(106)))));
            this.backupFormButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(82)))), ((int)(((byte)(46)))));
            this.backupFormButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(251)))), ((int)(((byte)(234)))));
            this.backupFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupFormButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.backupFormButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(82)))), ((int)(((byte)(46)))));
            this.backupFormButton.Location = new System.Drawing.Point(341, 275);
            this.backupFormButton.Name = "backupFormButton";
            this.backupFormButton.Size = new System.Drawing.Size(118, 33);
            this.backupFormButton.TabIndex = 11;
            this.backupFormButton.Text = "نسخ إحتياطي";
            this.backupFormButton.UseVisualStyleBackColor = false;
            this.backupFormButton.Click += new System.EventHandler(this.backupFormButton_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.backupFormButton);
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
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashboardForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "المنقوري للمعدات الطبية";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backupFormButton;
    }
}

