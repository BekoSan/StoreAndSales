namespace StoreAndSalesUI.Forms
{
    partial class ChooseUnitForm
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
            this.itemUnitsListGroupBox = new System.Windows.Forms.GroupBox();
            this.itemUnitsDataGridView = new System.Windows.Forms.DataGridView();
            this.titleLabel = new System.Windows.Forms.Label();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.unitNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemUnitsListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemUnitsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemUnitsListGroupBox
            // 
            this.itemUnitsListGroupBox.Controls.Add(this.itemUnitsDataGridView);
            this.itemUnitsListGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.itemUnitsListGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.itemUnitsListGroupBox.Location = new System.Drawing.Point(0, 66);
            this.itemUnitsListGroupBox.Name = "itemUnitsListGroupBox";
            this.itemUnitsListGroupBox.Size = new System.Drawing.Size(339, 283);
            this.itemUnitsListGroupBox.TabIndex = 8;
            this.itemUnitsListGroupBox.TabStop = false;
            this.itemUnitsListGroupBox.Text = "وحدات الصنف";
            // 
            // itemUnitsDataGridView
            // 
            this.itemUnitsDataGridView.AllowUserToAddRows = false;
            this.itemUnitsDataGridView.AllowUserToDeleteRows = false;
            this.itemUnitsDataGridView.AllowUserToResizeColumns = false;
            this.itemUnitsDataGridView.AllowUserToResizeRows = false;
            this.itemUnitsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemUnitsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.itemUnitsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemUnitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemUnitsDataGridView.ColumnHeadersVisible = false;
            this.itemUnitsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.selectColumn,
            this.unitNameColumn});
            this.itemUnitsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemUnitsDataGridView.GridColor = System.Drawing.Color.Black;
            this.itemUnitsDataGridView.Location = new System.Drawing.Point(3, 25);
            this.itemUnitsDataGridView.Name = "itemUnitsDataGridView";
            this.itemUnitsDataGridView.ReadOnly = true;
            this.itemUnitsDataGridView.RowHeadersVisible = false;
            this.itemUnitsDataGridView.RowHeadersWidth = 51;
            this.itemUnitsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.itemUnitsDataGridView.RowTemplate.Height = 24;
            this.itemUnitsDataGridView.Size = new System.Drawing.Size(333, 255);
            this.itemUnitsDataGridView.TabIndex = 0;
            this.itemUnitsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemUnitsDataGridView_CellContentClick);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 25F);
            this.titleLabel.Location = new System.Drawing.Point(30, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(278, 47);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "إختر وحـدة الصنف";
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "Id";
            this.idColumn.HeaderText = "Id";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // selectColumn
            // 
            this.selectColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle1.NullValue = "إختيار";
            this.selectColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.selectColumn.HeaderText = "...";
            this.selectColumn.MinimumWidth = 6;
            this.selectColumn.Name = "selectColumn";
            this.selectColumn.ReadOnly = true;
            this.selectColumn.Width = 70;
            // 
            // unitNameColumn
            // 
            this.unitNameColumn.DataPropertyName = "UnitName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.unitNameColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.unitNameColumn.HeaderText = "إسم الوحدة";
            this.unitNameColumn.MinimumWidth = 6;
            this.unitNameColumn.Name = "unitNameColumn";
            this.unitNameColumn.ReadOnly = true;
            // 
            // ChooseUnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(339, 349);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.itemUnitsListGroupBox);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseUnitForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إختر وحـدة الصنف";
            this.Load += new System.EventHandler(this.ChooseUnitForm_Load);
            this.itemUnitsListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemUnitsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox itemUnitsListGroupBox;
        private System.Windows.Forms.DataGridView itemUnitsDataGridView;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewButtonColumn selectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitNameColumn;
    }
}