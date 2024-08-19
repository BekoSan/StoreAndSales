using System;
using System.Windows.Forms;

namespace StoreAndSalesUI.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
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
    }
}
