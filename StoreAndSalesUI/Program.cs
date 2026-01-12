using FoxLearn.License;
using Microsoft.Win32;
using MicroVisionTrailMaker;
using StoreAndSalesUI.Forms;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace StoreAndSalesUI
{
    static class Program
    {
        private static TimeChange tmc = new TimeChange();
        private static Mutex mutex = new Mutex(true, "{2852D432-AD18-45B4-A4CA-F57341E99F13}");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // التحقق مما إذا كان التطبيق يعمل بالفعل
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                CheckActivation();
                //Application.Run(new DashboardForm());
                // تحرير الـ Mutex عند إغلاق التطبيق
                mutex.ReleaseMutex();
            }
            else
            {
                // رسالة اختيارية للمستخدم
                MessageBox.Show("البرنامج يعمل بالفعل!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private static void SystemDateChanged()
        {
            SystemEvents.TimeChanged += SystemEvents_TimeChanged;
        }

        private static void DateChangedAlert()
        {
            MessageBox.Show("لقد قمت بالتلاعب  بتاريخ الجهاز يرجى إعادة التاريخ كما كان!", "التلاعب بالتاريخ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static void SystemEvents_TimeChanged(object sender, EventArgs e)
        {
            SystemEvents.TimeChanged -= SystemEvents_TimeChanged;
            if (tmc.FileSytemMethod())
            {
                DateChangedAlert();
                Application.Exit();
            }
        }

        private static void CheckActivation()
        {
            try
            {
                string licFilePath = string.Format(@"{0}\StoreAndSales.lic", Application.StartupPath);

                if (!File.Exists(licFilePath)) Application.Run(new ActivationForm());

                string processorId = ComputerInfo.GetComputerId();

                //if (UsefulMethods.IsLanConnection() && UsefulMethods.GetServerID() != "N/A")
                //    processorId = UsefulMethods.GetServerID();

                KeyManager km = new KeyManager(processorId);
                LicenseInfo lic = new LicenseInfo();

                km.LoadSuretyFile(licFilePath, ref lic);
                string productkey = lic.ProductKey;

                if (km.ValidKey(ref productkey))
                {

                    KeyValuesClass kv = new KeyValuesClass();
                    if (km.DisassembleKey(productkey, ref kv))
                    {
                        if (kv.Type == LicenseType.TRIAL)
                        {
                            SystemDateChanged();

                            if (tmc.FileSytemMethod())
                            {
                                DateChangedAlert();
                                Application.Exit();
                            }
                            else if (DateTime.Today.Date <= kv.Expiration.Date)
                            {
                                //Application.Run(new SplashScreenForm());
                                new LoginForm().ShowDialog();
                            }
                            else if (DateTime.Today.Date > kv.Expiration.Date)
                            {
                                MessageBox.Show("لقد انتهت الفترة التجريبية لإستخدام البرنامج ، يرجى الحصول على رمز تفعيل جديد", "الفترة التجريبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //Application.Run(new ActivationForm());
                                new ActivationForm().ShowDialog();
                            }
                        }
                        else
                        {
                            new LoginForm().ShowDialog();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("حدث خطأ في تفعيل البرنامج، سيتم الإغلاق", "مشكلة في التفعيل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

    }
}
