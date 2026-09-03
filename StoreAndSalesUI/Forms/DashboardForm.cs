using StoreAndSalesUI.Interfaces;
using System;
using System.Windows.Forms;

namespace StoreAndSalesUI.Forms
{
    public partial class DashboardForm : Form
    {
        private  int _userRoleId = -1;
        private ILogout _loginForm;

        public DashboardForm(int userRoleId = -1, ILogout logout = null)
        {
            InitializeComponent();
            _userRoleId = userRoleId;
            _loginForm = logout;
        }

        private void ConfigureUserSession()
        {
            // Check if user is adminstrator or user role not passed
            if (_userRoleId == -1 || _userRoleId == 1) return;

            foreach (Control control in Controls)
            {
                if (!typeof(Button).Equals(control.GetType())) continue;

                if (control.Tag == null)
                {
                    if (control.Name.Equals("signOutButton")) continue;
                    control.Enabled = false;
                    continue;
                }

                if (control.Tag.ToString().Equals(_userRoleId.ToString()))
                    control.Enabled = true; 
                else
                    control.Enabled = false;
            }
        }

        private void itemsButton_Click(object sender, EventArgs e)
        {
            new ItemsForm().ShowDialog();
        }

        private void unitsButton_Click(object sender, EventArgs e)
        {
            new UnitsForm().ShowDialog();
        }

        private void suppliersButton_Click(object sender, EventArgs e)
        {
            new SuppliersForm().ShowDialog();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            new CustomersForm().ShowDialog();
        }

        private void purchasesButton_Click(object sender, EventArgs e)
        {
            new PurchasesForm().ShowDialog();
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            new SalesForm().ShowDialog();
        }

        private void storePreviewButton_Click(object sender, EventArgs e)
        {
            new StoreViewForm().ShowDialog();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            ConfigureUserSession();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            _loginForm.Logout(this); 
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            new UsersForm().ShowDialog();   
        }

        private void backupFormButton_Click(object sender, EventArgs e)
        {
            new DatabaseAdminForm().ShowDialog();
        }

        private void userLogsButton_Click(object sender, EventArgs e)
        {
            new UserLogsForm().ShowDialog();
        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
