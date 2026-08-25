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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.storeViewDataGridView = new System.Windows.Forms.DataGridView();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pricesLabel = new System.Windows.Forms.Label();
            this.pricesDataGridView = new System.Windows.Forms.DataGridView();
            this.calculationsDataGridView = new System.Windows.Forms.DataGridView();
            this.calculationLabel = new System.Windows.Forms.Label();
            this.resetQuantityButton = new System.Windows.Forms.Button();
            this.inventoryTotalLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.quantityTabPage = new System.Windows.Forms.TabPage();
            this.pricesTabPage = new System.Windows.Forms.TabPage();
            this.calculationsTabPage = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.storeViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculationsDataGridView)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.quantityTabPage.SuspendLayout();
            this.pricesTabPage.SuspendLayout();
            this.calculationsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // storeViewDataGridView
            // 
            this.storeViewDataGridView.AllowUserToAddRows = false;
            this.storeViewDataGridView.AllowUserToDeleteRows = false;
            this.storeViewDataGridView.AllowUserToResizeColumns = false;
            this.storeViewDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.storeViewDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.storeViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.storeViewDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.storeViewDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.storeViewDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.storeViewDataGridView.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.storeViewDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.storeViewDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storeViewDataGridView.EnableHeadersVisualStyles = false;
            this.storeViewDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.storeViewDataGridView.Location = new System.Drawing.Point(18, 64);
            this.storeViewDataGridView.MultiSelect = false;
            this.storeViewDataGridView.Name = "storeViewDataGridView";
            this.storeViewDataGridView.ReadOnly = true;
            this.storeViewDataGridView.RowHeadersVisible = false;
            this.storeViewDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.storeViewDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.storeViewDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.storeViewDataGridView.Size = new System.Drawing.Size(1136, 510);
            this.storeViewDataGridView.TabIndex = 1;
            // 
            // quantityLabel
            // 
            this.quantityLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.quantityLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.quantityLabel.Location = new System.Drawing.Point(18, 16);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(1136, 48);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "كميات الأصناف حسب الوحدات";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(24, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1132, 62);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "استعراض المخزن";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pricesLabel
            // 
            this.pricesLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pricesLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.pricesLabel.Location = new System.Drawing.Point(18, 16);
            this.pricesLabel.Name = "pricesLabel";
            this.pricesLabel.Size = new System.Drawing.Size(1136, 48);
            this.pricesLabel.TabIndex = 0;
            this.pricesLabel.Text = "آخر أسعار الشراء";
            this.pricesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pricesDataGridView
            // 
            this.pricesDataGridView.AllowUserToAddRows = false;
            this.pricesDataGridView.AllowUserToDeleteRows = false;
            this.pricesDataGridView.AllowUserToResizeColumns = false;
            this.pricesDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.pricesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.pricesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pricesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.pricesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pricesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.pricesDataGridView.ColumnHeadersHeight = 29;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pricesDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.pricesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pricesDataGridView.EnableHeadersVisualStyles = false;
            this.pricesDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pricesDataGridView.Location = new System.Drawing.Point(18, 64);
            this.pricesDataGridView.MultiSelect = false;
            this.pricesDataGridView.Name = "pricesDataGridView";
            this.pricesDataGridView.ReadOnly = true;
            this.pricesDataGridView.RowHeadersVisible = false;
            this.pricesDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.pricesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.pricesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pricesDataGridView.Size = new System.Drawing.Size(1136, 562);
            this.pricesDataGridView.TabIndex = 1;
            // 
            // calculationsDataGridView
            // 
            this.calculationsDataGridView.AllowUserToAddRows = false;
            this.calculationsDataGridView.AllowUserToDeleteRows = false;
            this.calculationsDataGridView.AllowUserToResizeColumns = false;
            this.calculationsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.calculationsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.calculationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.calculationsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.calculationsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calculationsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.calculationsDataGridView.ColumnHeadersHeight = 29;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.calculationsDataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.calculationsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculationsDataGridView.EnableHeadersVisualStyles = false;
            this.calculationsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.calculationsDataGridView.Location = new System.Drawing.Point(18, 64);
            this.calculationsDataGridView.MultiSelect = false;
            this.calculationsDataGridView.Name = "calculationsDataGridView";
            this.calculationsDataGridView.ReadOnly = true;
            this.calculationsDataGridView.RowHeadersVisible = false;
            this.calculationsDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.calculationsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.calculationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.calculationsDataGridView.Size = new System.Drawing.Size(1136, 562);
            this.calculationsDataGridView.TabIndex = 1;
            // 
            // calculationLabel
            // 
            this.calculationLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.calculationLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.calculationLabel.Location = new System.Drawing.Point(18, 16);
            this.calculationLabel.Name = "calculationLabel";
            this.calculationLabel.Size = new System.Drawing.Size(1136, 48);
            this.calculationLabel.TabIndex = 0;
            this.calculationLabel.Text = "قيمة جرد البضاعة حسب الوحدة";
            this.calculationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resetQuantityButton
            // 
            this.resetQuantityButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(84)))), ((int)(((byte)(75)))));
            this.resetQuantityButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.resetQuantityButton.FlatAppearance.BorderSize = 0;
            this.resetQuantityButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(57)))), ((int)(((byte)(51)))));
            this.resetQuantityButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(104)))), ((int)(((byte)(95)))));
            this.resetQuantityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetQuantityButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetQuantityButton.ForeColor = System.Drawing.Color.White;
            this.resetQuantityButton.Location = new System.Drawing.Point(958, 12);
            this.resetQuantityButton.Margin = new System.Windows.Forms.Padding(0);
            this.resetQuantityButton.Name = "resetQuantityButton";
            this.resetQuantityButton.Size = new System.Drawing.Size(198, 62);
            this.resetQuantityButton.TabIndex = 2;
            this.resetQuantityButton.Text = "تصفير كميات المخزن";
            this.resetQuantityButton.UseVisualStyleBackColor = false;
            this.resetQuantityButton.Click += new System.EventHandler(this.resetQuantityButton_Click);
            // 
            // inventoryTotalLabel
            // 
            this.inventoryTotalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(79)))), ((int)(((byte)(122)))));
            this.inventoryTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryTotalLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.inventoryTotalLabel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryTotalLabel.ForeColor = System.Drawing.Color.White;
            this.inventoryTotalLabel.Location = new System.Drawing.Point(24, 12);
            this.inventoryTotalLabel.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.inventoryTotalLabel.Name = "inventoryTotalLabel";
            this.inventoryTotalLabel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.inventoryTotalLabel.Size = new System.Drawing.Size(394, 62);
            this.inventoryTotalLabel.TabIndex = 1;
            this.inventoryTotalLabel.Text = "إجمالي جرد المخزن: 0";
            this.inventoryTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.headerPanel.Controls.Add(this.resetQuantityButton);
            this.headerPanel.Controls.Add(this.inventoryTotalLabel);
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Padding = new System.Windows.Forms.Padding(24, 12, 24, 12);
            this.headerPanel.Size = new System.Drawing.Size(1180, 86);
            this.headerPanel.TabIndex = 0;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.searchLabel);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 86);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Padding = new System.Windows.Forms.Padding(24, 10, 24, 8);
            this.searchPanel.Size = new System.Drawing.Size(1180, 52);
            this.searchPanel.TabIndex = 1;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(24, 10);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(1002, 27);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.searchLabel.Location = new System.Drawing.Point(1026, 10);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(130, 34);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "بحث في الأصناف";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.quantityTabPage);
            this.tabControl.Controls.Add(this.pricesTabPage);
            this.tabControl.Controls.Add(this.calculationsTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ItemSize = new System.Drawing.Size(180, 42);
            this.tabControl.Location = new System.Drawing.Point(0, 138);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(22, 6);
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl.RightToLeftLayout = true;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1180, 642);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 1;
            // 
            // quantityTabPage
            // 
            this.quantityTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.quantityTabPage.Controls.Add(this.storeViewDataGridView);
            this.quantityTabPage.Controls.Add(this.quantityLabel);
            this.quantityTabPage.Location = new System.Drawing.Point(4, 46);
            this.quantityTabPage.Name = "quantityTabPage";
            this.quantityTabPage.Padding = new System.Windows.Forms.Padding(18, 16, 18, 18);
            this.quantityTabPage.Size = new System.Drawing.Size(1172, 592);
            this.quantityTabPage.TabIndex = 0;
            this.quantityTabPage.Text = "كميات الأصناف";
            // 
            // pricesTabPage
            // 
            this.pricesTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.pricesTabPage.Controls.Add(this.pricesDataGridView);
            this.pricesTabPage.Controls.Add(this.pricesLabel);
            this.pricesTabPage.Location = new System.Drawing.Point(4, 46);
            this.pricesTabPage.Name = "pricesTabPage";
            this.pricesTabPage.Padding = new System.Windows.Forms.Padding(18, 16, 18, 18);
            this.pricesTabPage.Size = new System.Drawing.Size(1172, 644);
            this.pricesTabPage.TabIndex = 1;
            this.pricesTabPage.Text = "أسعار الشراء";
            // 
            // calculationsTabPage
            // 
            this.calculationsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.calculationsTabPage.Controls.Add(this.calculationsDataGridView);
            this.calculationsTabPage.Controls.Add(this.calculationLabel);
            this.calculationsTabPage.Location = new System.Drawing.Point(4, 46);
            this.calculationsTabPage.Name = "calculationsTabPage";
            this.calculationsTabPage.Padding = new System.Windows.Forms.Padding(18, 16, 18, 18);
            this.calculationsTabPage.Size = new System.Drawing.Size(1172, 644);
            this.calculationsTabPage.TabIndex = 2;
            this.calculationsTabPage.Text = "قيمة الجرد";
            // 
            // StoreViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1180, 780);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "StoreViewForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "استعراض المخزن";
            ((System.ComponentModel.ISupportInitialize)(this.storeViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculationsDataGridView)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.quantityTabPage.ResumeLayout(false);
            this.pricesTabPage.ResumeLayout(false);
            this.calculationsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage quantityTabPage;
        private System.Windows.Forms.TabPage pricesTabPage;
        private System.Windows.Forms.TabPage calculationsTabPage;
    }
}
