namespace StoreAndSalesUI.Forms
{
    partial class UsersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titleLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.userDataGroupBox = new System.Windows.Forms.GroupBox();
            this.rolesComboBox = new System.Windows.Forms.ComboBox();
            this.rolesLabel = new System.Windows.Forms.Label();
            this.usersListGroupBox = new System.Windows.Forms.GroupBox();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.userDataGroupBox.SuspendLayout();
            this.usersListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 25F);
            this.titleLabel.Location = new System.Drawing.Point(164, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(249, 47);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "إدارة المستخدمين";
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.userNameLabel.Location = new System.Drawing.Point(196, 27);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(85, 19);
            this.userNameLabel.TabIndex = 17;
            this.userNameLabel.Text = "إسم المستخدم";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameTextBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.userNameTextBox.Location = new System.Drawing.Point(15, 51);
            this.userNameTextBox.MaxLength = 10;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(266, 29);
            this.userNameTextBox.TabIndex = 16;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.Location = new System.Drawing.Point(206, 95);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(75, 19);
            this.passwordLabel.TabIndex = 19;
            this.passwordLabel.Text = "كلمة المرور";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.passwordTextBox.Location = new System.Drawing.Point(15, 117);
            this.passwordTextBox.MaxLength = 10;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(267, 29);
            this.passwordTextBox.TabIndex = 18;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.repeatPasswordLabel.Location = new System.Drawing.Point(181, 166);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(100, 19);
            this.repeatPasswordLabel.TabIndex = 21;
            this.repeatPasswordLabel.Text = "كرر كلمة المرور";
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.repeatPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.repeatPasswordTextBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(15, 188);
            this.repeatPasswordTextBox.MaxLength = 10;
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(267, 29);
            this.repeatPasswordTextBox.TabIndex = 20;
            this.repeatPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.deleteButton.Location = new System.Drawing.Point(354, 391);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(118, 33);
            this.deleteButton.TabIndex = 24;
            this.deleteButton.Text = "حـــذف";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(229, 391);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 33);
            this.saveButton.TabIndex = 23;
            this.saveButton.Text = "حفــــظ";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newButton
            // 
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.newButton.Location = new System.Drawing.Point(104, 391);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(118, 33);
            this.newButton.TabIndex = 22;
            this.newButton.Text = "جديد";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // userDataGroupBox
            // 
            this.userDataGroupBox.Controls.Add(this.showPasswordCheckBox);
            this.userDataGroupBox.Controls.Add(this.rolesComboBox);
            this.userDataGroupBox.Controls.Add(this.rolesLabel);
            this.userDataGroupBox.Controls.Add(this.userNameLabel);
            this.userDataGroupBox.Controls.Add(this.userNameTextBox);
            this.userDataGroupBox.Controls.Add(this.passwordTextBox);
            this.userDataGroupBox.Controls.Add(this.passwordLabel);
            this.userDataGroupBox.Controls.Add(this.repeatPasswordLabel);
            this.userDataGroupBox.Controls.Add(this.repeatPasswordTextBox);
            this.userDataGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.userDataGroupBox.Location = new System.Drawing.Point(8, 70);
            this.userDataGroupBox.Name = "userDataGroupBox";
            this.userDataGroupBox.Size = new System.Drawing.Size(293, 297);
            this.userDataGroupBox.TabIndex = 25;
            this.userDataGroupBox.TabStop = false;
            this.userDataGroupBox.Text = "بيانات المستخدم";
            // 
            // rolesComboBox
            // 
            this.rolesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rolesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rolesComboBox.FormattingEnabled = true;
            this.rolesComboBox.Location = new System.Drawing.Point(15, 257);
            this.rolesComboBox.Name = "rolesComboBox";
            this.rolesComboBox.Size = new System.Drawing.Size(267, 29);
            this.rolesComboBox.TabIndex = 23;
            // 
            // rolesLabel
            // 
            this.rolesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rolesLabel.AutoSize = true;
            this.rolesLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.rolesLabel.Location = new System.Drawing.Point(213, 233);
            this.rolesLabel.Name = "rolesLabel";
            this.rolesLabel.Size = new System.Drawing.Size(68, 19);
            this.rolesLabel.TabIndex = 22;
            this.rolesLabel.Text = "الصلاحيات";
            // 
            // usersListGroupBox
            // 
            this.usersListGroupBox.Controls.Add(this.usersDataGridView);
            this.usersListGroupBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.usersListGroupBox.Location = new System.Drawing.Point(309, 70);
            this.usersListGroupBox.Name = "usersListGroupBox";
            this.usersListGroupBox.Size = new System.Drawing.Size(258, 297);
            this.usersListGroupBox.TabIndex = 26;
            this.usersListGroupBox.TabStop = false;
            this.usersListGroupBox.Text = "قائمة المستخدمين";
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            this.usersDataGridView.AllowUserToResizeColumns = false;
            this.usersDataGridView.AllowUserToResizeRows = false;
            this.usersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.usersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.usersDataGridView.ColumnHeadersHeight = 29;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.userNameColumn});
            this.usersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersDataGridView.EnableHeadersVisualStyles = false;
            this.usersDataGridView.GridColor = System.Drawing.Color.Black;
            this.usersDataGridView.Location = new System.Drawing.Point(3, 25);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.RowHeadersVisible = false;
            this.usersDataGridView.RowHeadersWidth = 51;
            this.usersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.usersDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.usersDataGridView.RowTemplate.Height = 24;
            this.usersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDataGridView.Size = new System.Drawing.Size(252, 269);
            this.usersDataGridView.TabIndex = 0;
            this.usersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDataGridView_CellClick);
            // 
            // IdColumn
            // 
            this.IdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "الرقم";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Width = 50;
            // 
            // userNameColumn
            // 
            this.userNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.userNameColumn.DataPropertyName = "UserName";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.userNameColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.userNameColumn.HeaderText = "إسم المستخدم";
            this.userNameColumn.MinimumWidth = 6;
            this.userNameColumn.Name = "userNameColumn";
            this.userNameColumn.ReadOnly = true;
            this.userNameColumn.Width = 175;
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(15, 91);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(18, 17);
            this.showPasswordCheckBox.TabIndex = 24;
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 431);
            this.Controls.Add(this.usersListGroupBox);
            this.Controls.Add(this.userDataGroupBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsersForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "إدارة المستخدمين";
            this.userDataGroupBox.ResumeLayout(false);
            this.userDataGroupBox.PerformLayout();
            this.usersListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label repeatPasswordLabel;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.GroupBox userDataGroupBox;
        private System.Windows.Forms.GroupBox usersListGroupBox;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.Label rolesLabel;
        private System.Windows.Forms.ComboBox rolesComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameColumn;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
    }
}