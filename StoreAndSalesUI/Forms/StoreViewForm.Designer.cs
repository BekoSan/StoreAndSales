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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.storeViewDataGridView = new System.Windows.Forms.DataGridView();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pricesLabel = new System.Windows.Forms.Label();
            this.pricesDataGridView = new System.Windows.Forms.DataGridView();
            this.calculationsDataGridView = new System.Windows.Forms.DataGridView();
            this.calculationLabel = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.storeViewDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.storeViewDataGridView.ColumnHeadersHeight = 29;
            this.storeViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.storeViewDataGridView.EnableHeadersVisualStyles = false;
            this.storeViewDataGridView.GridColor = System.Drawing.Color.Black;
            this.storeViewDataGridView.Location = new System.Drawing.Point(43, 135);
            this.storeViewDataGridView.MultiSelect = false;
            this.storeViewDataGridView.Name = "storeViewDataGridView";
            this.storeViewDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.storeViewDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.storeViewDataGridView.RowHeadersVisible = false;
            this.storeViewDataGridView.RowHeadersWidth = 51;
            this.storeViewDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.storeViewDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.storeViewDataGridView.RowTemplate.Height = 24;
            this.storeViewDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.storeViewDataGridView.Size = new System.Drawing.Size(707, 290);
            this.storeViewDataGridView.TabIndex = 4;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Arial", 23F);
            this.quantityLabel.Location = new System.Drawing.Point(35, 88);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(220, 44);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "كميات الأصناف";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 35F);
            this.titleLabel.Location = new System.Drawing.Point(216, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(368, 66);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "إستعراض المخزن";
            // 
            // pricesLabel
            // 
            this.pricesLabel.AutoSize = true;
            this.pricesLabel.Font = new System.Drawing.Font("Arial", 23F);
            this.pricesLabel.Location = new System.Drawing.Point(48, 442);
            this.pricesLabel.Name = "pricesLabel";
            this.pricesLabel.Size = new System.Drawing.Size(242, 44);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pricesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.pricesDataGridView.ColumnHeadersHeight = 29;
            this.pricesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.pricesDataGridView.EnableHeadersVisualStyles = false;
            this.pricesDataGridView.GridColor = System.Drawing.Color.Black;
            this.pricesDataGridView.Location = new System.Drawing.Point(43, 489);
            this.pricesDataGridView.MultiSelect = false;
            this.pricesDataGridView.Name = "pricesDataGridView";
            this.pricesDataGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pricesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.pricesDataGridView.RowHeadersVisible = false;
            this.pricesDataGridView.RowHeadersWidth = 51;
            this.pricesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.pricesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.pricesDataGridView.RowTemplate.Height = 24;
            this.pricesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pricesDataGridView.Size = new System.Drawing.Size(707, 290);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calculationsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.calculationsDataGridView.ColumnHeadersHeight = 29;
            this.calculationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.calculationsDataGridView.EnableHeadersVisualStyles = false;
            this.calculationsDataGridView.GridColor = System.Drawing.Color.Black;
            this.calculationsDataGridView.Location = new System.Drawing.Point(43, 795);
            this.calculationsDataGridView.MultiSelect = false;
            this.calculationsDataGridView.Name = "calculationsDataGridView";
            this.calculationsDataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calculationsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.calculationsDataGridView.RowHeadersVisible = false;
            this.calculationsDataGridView.RowHeadersWidth = 51;
            this.calculationsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.calculationsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.calculationsDataGridView.RowTemplate.Height = 24;
            this.calculationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.calculationsDataGridView.Size = new System.Drawing.Size(707, 248);
            this.calculationsDataGridView.TabIndex = 9;
            // 
            // calculationLabel
            // 
            this.calculationLabel.AutoSize = true;
            this.calculationLabel.Font = new System.Drawing.Font("Arial", 23F);
            this.calculationLabel.Location = new System.Drawing.Point(48, 735);
            this.calculationLabel.Name = "calculationLabel";
            this.calculationLabel.Size = new System.Drawing.Size(212, 44);
            this.calculationLabel.TabIndex = 10;
            this.calculationLabel.Text = "جـــرد البضاعة";
            // 
            // StoreViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 1055);
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
    }
}