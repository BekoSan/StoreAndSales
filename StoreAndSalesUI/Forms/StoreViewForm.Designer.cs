namespace StoreAndSalesUI.Forms
{
    partial class StoreViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.storeViewDataGridView = new System.Windows.Forms.DataGridView();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pricesLabel = new System.Windows.Forms.Label();
            this.pricesDataGridView = new System.Windows.Forms.DataGridView();
            this.calculationsDataGridView = new System.Windows.Forms.DataGridView();
            this.calculationLabel = new System.Windows.Forms.Label();
            this.resetQuantityButton = new System.Windows.Forms.Button();
            this.inventoryTotalLabel = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.storeViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // storeViewDataGridView
            // 
            this.storeViewDataGridView.AllowUserToAddRows = false;
            this.storeViewDataGridView.AllowUserToDeleteRows = false;
            this.storeViewDataGridView.AllowUserToResizeColumns = false;
            this.storeViewDataGridView.AllowUserToResizeRows = false;
            this.storeViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.storeViewDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.storeViewDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.storeViewDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.storeViewDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.storeViewDataGridView.ColumnHeadersHeight = 29;
            this.storeViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.storeViewDataGridView.EnableHeadersVisualStyles = false;
            this.storeViewDataGridView.GridColor = System.Drawing.Color.Black;
            this.storeViewDataGridView.Location = new System.Drawing.Point(38, 135);
            this.storeViewDataGridView.MultiSelect = false;
            this.storeViewDataGridView.Name = "storeViewDataGridView";
            this.storeViewDataGridView.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.storeViewDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.storeViewDataGridView.RowHeadersVisible = false;
            this.storeViewDataGridView.RowHeadersWidth = 51;
            this.storeViewDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.storeViewDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.storeViewDataGridView.RowTemplate.Height = 24;
            this.storeViewDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.storeViewDataGridView.Size = new System.Drawing.Size(619, 290);
            this.storeViewDataGridView.TabIndex = 4;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.quantityLabel.ForeColor = System.Drawing.Color.FromArgb(47, 84, 120);
            this.quantityLabel.Location = new System.Drawing.Point(31, 88);

            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(219, 44);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "كميات الأصناف";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(47, 84, 120);
            this.titleLabel.Location = new System.Drawing.Point(189, 9);

            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(368, 66);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "إستعراض المخزن";
            // 
            // pricesLabel
            // 
            this.pricesLabel.AutoSize = true;
            this.pricesLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.pricesLabel.ForeColor = System.Drawing.Color.FromArgb(47, 84, 120);
            this.pricesLabel.Location = new System.Drawing.Point(42, 442);

            this.pricesLabel.Name = "pricesLabel";
            this.pricesLabel.Size = new System.Drawing.Size(241, 44);
            this.pricesLabel.TabIndex = 8;
            this.pricesLabel.Text = "آخر أسعار الشراء";
            // 
            // pricesDataGridView
            // 
            this.pricesDataGridView.AllowUserToAddRows = false;
            this.pricesDataGridView.AllowUserToDeleteRows = false;
            this.pricesDataGridView.AllowUserToResizeColumns = false;
            this.pricesDataGridView.AllowUserToResizeRows = false;
            this.pricesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pricesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.pricesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pricesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pricesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.pricesDataGridView.ColumnHeadersHeight = 29;
            this.pricesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.pricesDataGridView.EnableHeadersVisualStyles = false;
            this.pricesDataGridView.GridColor = System.Drawing.Color.Black;
            this.pricesDataGridView.Location = new System.Drawing.Point(38, 489);
            this.pricesDataGridView.MultiSelect = false;
            this.pricesDataGridView.Name = "pricesDataGridView";
            this.pricesDataGridView.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pricesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.pricesDataGridView.RowHeadersVisible = false;
            this.pricesDataGridView.RowHeadersWidth = 51;
            this.pricesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.pricesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.pricesDataGridView.RowTemplate.Height = 24;
            this.pricesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pricesDataGridView.Size = new System.Drawing.Size(619, 290);
            this.pricesDataGridView.TabIndex = 7;
            // 
            // calculationsDataGridView
            // 
            this.calculationsDataGridView.AllowUserToAddRows = false;
            this.calculationsDataGridView.AllowUserToDeleteRows = false;
            this.calculationsDataGridView.AllowUserToResizeColumns = false;
            this.calculationsDataGridView.AllowUserToResizeRows = false;
            this.calculationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.calculationsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.calculationsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calculationsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calculationsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.calculationsDataGridView.ColumnHeadersHeight = 29;
            this.calculationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.calculationsDataGridView.EnableHeadersVisualStyles = false;
            this.calculationsDataGridView.GridColor = System.Drawing.Color.Black;
            this.calculationsDataGridView.Location = new System.Drawing.Point(38, 795);
            this.calculationsDataGridView.MultiSelect = false;
            this.calculationsDataGridView.Name = "calculationsDataGridView";
            this.calculationsDataGridView.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calculationsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.calculationsDataGridView.RowHeadersVisible = false;
            this.calculationsDataGridView.RowHeadersWidth = 51;
            this.calculationsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            this.calculationsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.calculationsDataGridView.RowTemplate.Height = 24;
            this.calculationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.calculationsDataGridView.Size = new System.Drawing.Size(619, 200);
            this.calculationsDataGridView.TabIndex = 9;
            // 
            // calculationLabel

            // 
            this.calculationLabel.AutoSize = true;
            this.calculationLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.calculationLabel.ForeColor = System.Drawing.Color.FromArgb(47, 84, 120);
            this.calculationLabel.Location = new System.Drawing.Point(42, 735);

            this.calculationLabel.Name = "calculationLabel";
            this.calculationLabel.Size = new System.Drawing.Size(211, 44);
            this.calculationLabel.TabIndex = 10;
            this.calculationLabel.Text = "جـــرد البضاعة";
            // 
            // resetQuantityButton
            // 
            this.resetQuantityButton.Location = new System.Drawing.Point(50, 29);
            this.resetQuantityButton.Name = "resetQuantityButton";
            this.resetQuantityButton.Size = new System.Drawing.Size(108, 27);
            this.resetQuantityButton.TabIndex = 11;
            this.resetQuantityButton.Text = "تصفير المخزن";
            this.resetQuantityButton.UseVisualStyleBackColor = true;
            this.resetQuantityButton.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.resetQuantityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetQuantityButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(47, 84, 120);
            this.resetQuantityButton.Click += new System.EventHandler(this.resetQuantityButton_Click);
            // 
            // inventoryTotalLabel
            // 
            this.inventoryTotalLabel.BackColor = System.Drawing.Color.FromArgb(235, 244, 252);
            this.inventoryTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryTotalLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.inventoryTotalLabel.ForeColor = System.Drawing.Color.FromArgb(47, 84, 120);
            this.inventoryTotalLabel.Location = new System.Drawing.Point(38, 1002);
            this.inventoryTotalLabel.Name = "inventoryTotalLabel";
            this.inventoryTotalLabel.Size = new System.Drawing.Size(619, 38);
            this.inventoryTotalLabel.TabIndex = 12;
            this.inventoryTotalLabel.Text = "إجمالي جرد المخزن: 0";
            this.inventoryTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StoreViewForm

            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 1055);
            this.Controls.Add(this.inventoryTotalLabel);
            this.Controls.Add(this.resetQuantityButton);
            this.Controls.Add(this.calculationLabel);

            this.Controls.Add(this.calculationsDataGridView);
            this.Controls.Add(this.pricesLabel);
            this.Controls.Add(this.pricesDataGridView);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.storeViewDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StoreViewForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إستعراض المخزن";
            ((System.ComponentModel.ISupportInitialize)(this.storeViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculationsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView storeViewDataGridView;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label pricesLabel;
        private System.Windows.Forms.DataGridView pricesDataGridView;
        private System.Windows.Forms.DataGridView calculationsDataGridView;
        private System.Windows.Forms.Label calculationLabel;
        private System.Windows.Forms.Button resetQuantityButton;
        private System.Windows.Forms.Label inventoryTotalLabel;

    }
}