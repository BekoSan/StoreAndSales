namespace StoreAndSalesUI.Forms
{
    partial class ActivationForm
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
            this.productKeyTextBox = new System.Windows.Forms.TextBox();
            this.activateButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pcCodeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productKeyTextBox
            // 
            this.productKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.productKeyTextBox.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.productKeyTextBox.Location = new System.Drawing.Point(41, 198);
            this.productKeyTextBox.Name = "productKeyTextBox";
            this.productKeyTextBox.Size = new System.Drawing.Size(556, 41);
            this.productKeyTextBox.TabIndex = 0;
            this.productKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // activateButton
            // 
            this.activateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.activateButton.Font = new System.Drawing.Font("Hacen Tunisia", 13F);
            this.activateButton.Location = new System.Drawing.Point(175, 250);
            this.activateButton.Name = "activateButton";
            this.activateButton.Size = new System.Drawing.Size(288, 51);
            this.activateButton.TabIndex = 1;
            this.activateButton.Text = "تفعيل";
            this.activateButton.UseVisualStyleBackColor = true;
            this.activateButton.Click += new System.EventHandler(this.activateButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Hacen Tunisia", 25F);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.titleLabel.Location = new System.Drawing.Point(198, 4);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(243, 66);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "تفعيل البرنامج";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(163)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(10, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "للحصول على ترخيص لإستخدام البرنامج قم بإرسال الرمز أدناه إلينا ليتم تزويدك برمز ا" +
    "لتفعيل";
            // 
            // pcCodeTextBox
            // 
            this.pcCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.pcCodeTextBox.Location = new System.Drawing.Point(41, 108);
            this.pcCodeTextBox.Name = "pcCodeTextBox";
            this.pcCodeTextBox.ReadOnly = true;
            this.pcCodeTextBox.Size = new System.Drawing.Size(556, 41);
            this.pcCodeTextBox.TabIndex = 4;
            this.pcCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hacen Tunisia", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(478, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "رمز التفعيل";
            // 
            // ActivationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(639, 304);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pcCodeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.activateButton);
            this.Controls.Add(this.productKeyTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActivationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ActivationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productKeyTextBox;
        private System.Windows.Forms.Button activateButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pcCodeTextBox;
        private System.Windows.Forms.Label label3;
    }
}