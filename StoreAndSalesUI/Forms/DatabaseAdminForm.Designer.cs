namespace StoreAndSalesUI.Forms
{
    partial class DatabaseAdminForm
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
            this.backupButton = new System.Windows.Forms.Button();
            this.restoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 35F);
            this.titleLabel.Location = new System.Drawing.Point(123, 14);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(566, 66);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "النسخ الإحتياطي والإسترجاع";
            // 
            // backupButton
            // 
            this.backupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.backupButton.Location = new System.Drawing.Point(215, 165);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(194, 39);
            this.backupButton.TabIndex = 2;
            this.backupButton.Text = "نسخ إحتياطي";
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // restoreButton
            // 
            this.restoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.restoreButton.Location = new System.Drawing.Point(429, 164);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(181, 40);
            this.restoreButton.TabIndex = 3;
            this.restoreButton.Text = "إسترجاع";
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // DatabaseAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 221);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatabaseAdminForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "النسخ الإحتياطي والإسترجاع";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button backupButton;
        private System.Windows.Forms.Button restoreButton;
    }
}