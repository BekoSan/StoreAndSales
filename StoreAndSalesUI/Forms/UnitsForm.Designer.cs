namespace StoreAndSalesUI.Forms
{
    partial class UnitsForm
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
            this.unitNameTextBox = new System.Windows.Forms.TextBox();
            this.unitNameLabel = new System.Windows.Forms.Label();
            this.unitsDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.unitsListGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.unitsDataGridView)).BeginInit();
            this.unitDataGroupBox.SuspendLayout();
            this.unitsListGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 35F);
            this.titleLabel.Location = new System.Drawing.Point(90, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(218, 66);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "الوحـــدات";
            // 
            // unitNameTextBox
            // 
            this.unitNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unitNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unitNameTextBox.Location = new System.Drawing.Point(9, 52);
            this.unitNameTextBox.Name = "unitNameTextBox";
            this.unitNameTextBox.Size = new System.Drawing.Size(361, 29);
            this.unitNameTextBox.TabIndex = 0;
            // 
            // unitNameLabel
            // 
            this.unitNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unitNameLabel.AutoSize = true;
            this.unitNameLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.unitNameLabel.Location = new System.Drawing.Point(295, 30);
            this.unitNameLabel.Name = "unitNameLabel";
            this.unitNameLabel.Size = new System.Drawing.Size(71, 19);
            this.unitNameLabel.TabIndex = 5;
            this.unitNameLabel.Text = "إسم الوحدة";
            // 
            // unitsDataGridView
            // 
            this.unitsDataGridView.AllowUserToAddRows = false;
            this.unitsDataGridView.AllowUserToDeleteRows = false;
            this.unitsDataGridView.AllowUserToResizeColumns = false;
            this.unitsDataGridView.AllowUserToResizeRows = false;
            this.unitsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.unitsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.unitsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unitsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.unitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unitsDataGridView.ColumnHeadersVisible = false;
            this.unitsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.unitNameColumn});
            this.unitsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitsDataGridView.GridColor = System.Drawing.Color.Black;
            this.unitsDataGridView.Location = new System.Drawing.Point(3, 25);
            this.unitsDataGridView.Name = "unitsDataGridView";
            this.unitsDataGridView.ReadOnly = true;
            this.unitsDataGridView.RowHeadersVisible = false;
            this.unitsDataGridView.RowHeadersWidth = 51;
            this.unitsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.unitsDataGridView.RowTemplate.Height = 24;
            this.unitsDataGridView.Size = new System.Drawing.Size(375, 188);
            this.unitsDataGridView.TabIndex = 0;
            this.unitsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.unitsDataGridView_CellContentClick);
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "Id";
            this.idColumn.HeaderText = "ID";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // unitNameColumn
            // 
            this.unitNameColumn.DataPropertyName = "UnitName";
            this.unitNameColumn.HeaderText = "إسم الوحدة";
            this.unitNameColumn.MinimumWidth = 6;
            this.unitNameColumn.Name = "unitNameColumn";
            this.unitNameColumn.ReadOnly = true;
            // 
            // unitDataGroupBox
            // 
            this.unitDataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unitDataGroupBox.Controls.Add(this.unitNameLabel);
            this.unitDataGroupBox.Controls.Add(this.unitNameTextBox);
            this.unitDataGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.unitDataGroupBox.Location = new System.Drawing.Point(10, 82);
            this.unitDataGroupBox.Name = "unitDataGroupBox";
            this.unitDataGroupBox.Size = new System.Drawing.Size(381, 102);
            this.unitDataGroupBox.TabIndex = 5;
            this.unitDataGroupBox.TabStop = false;
            this.unitDataGroupBox.Text = "بيانات الوحدة";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(202, 412);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 33);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "حفــــظ";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newButton
            // 
            this.newButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.newButton.Location = new System.Drawing.Point(78, 412);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(118, 33);
            this.newButton.TabIndex = 8;
            this.newButton.Text = "جديد";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // unitsListGroupBox
            // 
            this.unitsListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unitsListGroupBox.Controls.Add(this.unitsDataGridView);
            this.unitsListGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.unitsListGroupBox.Location = new System.Drawing.Point(10, 190);
            this.unitsListGroupBox.Name = "unitsListGroupBox";
            this.unitsListGroupBox.Size = new System.Drawing.Size(381, 216);
            this.unitsListGroupBox.TabIndex = 7;
            this.unitsListGroupBox.TabStop = false;
            this.unitsListGroupBox.Text = "قائمة الوحدات";
            // 
            // UnitsForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(399, 453);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.unitDataGroupBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.unitsListGroupBox);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UnitsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الوحــدات";
            this.Load += new System.EventHandler(this.UnitsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unitsDataGridView)).EndInit();
            this.unitDataGroupBox.ResumeLayout(false);
            this.unitDataGroupBox.PerformLayout();
            this.unitsListGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox unitNameTextBox;
        private System.Windows.Forms.Label unitNameLabel;
        private System.Windows.Forms.DataGridView unitsDataGridView;
        private System.Windows.Forms.GroupBox unitDataGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.GroupBox unitsListGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitNameColumn;
    }
}