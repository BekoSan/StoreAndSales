using FoxLearn.License;
using System.Windows.Forms;

namespace StoreAndSalesUI.Forms
{
    public partial class ActivationForm : Form
    {

        #region Private Members

        private string _processorId = ComputerInfo.GetComputerId();

        #endregion

        #region Private Methods

        private void ActivateApplication()
        {
            var km = new KeyManager(_processorId);
            string productKey = productKeyTextBox.Text;

            if (km.ValidKey(ProductKey: ref productKey))
            {
                var kv = new KeyValuesClass();
                if (km.DisassembleKey(productKey, KeyValues: ref kv))
                {
                    var lic = new LicenseInfo
                    {
                        ProductKey = productKey,
                        FullName = Application.ProductName
                    };

                    if (kv.Type == LicenseType.TRIAL)
                    {
                        lic.Day = kv.Expiration.Day;
                        lic.Month = kv.Expiration.Month;
                        lic.Year = kv.Expiration.Year;
                    }

                    km.SaveSuretyFile(string.Format(@"{0}\StoreAndSales.lic", Application.StartupPath), lic);
                    MessageBox.Show("تم تفعيل البرنامج بنجاح", "التفعيل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
            }
            else
            {
                MessageBox.Show("رقم التفعيل غير صالح", "خطأ في التفعيل", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        public ActivationForm()
        {
            InitializeComponent();
        }

        private void activateButton_Click(object sender, System.EventArgs e)
        {
            ActivateApplication();
        }

        private void ActivationForm_Load(object sender, System.EventArgs e)
        {
            pcCodeTextBox.Text = _processorId.ToString();
            productKeyTextBox.Focus();
        }

    }
}
