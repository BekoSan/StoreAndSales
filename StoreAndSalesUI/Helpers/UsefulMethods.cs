using Microsoft.Win32;
using System;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace StoreAndSalesUI.Helpers
{
    public static class UsefulMethods
    {

        public static void AcceptJustNumbers(KeyPressEventArgs e, TextBox textBox)
        {
            if (char.IsControl(e.KeyChar) == false)
            {
                if (char.IsDigit(e.KeyChar) || e.KeyChar == '.')
                {
                    if (textBox.Text.Contains('.'))
                    {

                        if (textBox.Text.Split('.')[1].Length < 3)
                        {
                            if (char.IsDigit(e.KeyChar) == false) e.Handled = true;
                            else
                            {
                                e.Handled = true;
                            }
                        }
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }

        }

        public static string GetInstalledServerName()
        {
            string output = "";

            var instances = GetInstalledInstances();

            if (instances == null)
            {
                MessageBox.Show("لم يتم تنصيب السيرفر بعد", "تنصيب السيرفر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return output;
            }

            if (instances.Length > 0)
            {
                foreach (string element in instances)
                {
                    if (element == "MSSQLSERVER")
                    {
                        output = Environment.MachineName;
                    }
                    else
                    {
                        output = Environment.MachineName + @"\" + element;
                    }
                }
            }

            return output;
        }

        private static string[] GetInstalledInstances()
        {
            string[] output;

            var localMachine32 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
            var rk32 = localMachine32.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server");

            output = (string[])rk32.GetValue("InstalledInstances");

            if (output == null)
            {
                var localMachine64 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                var rk64 = localMachine64.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server");
                output = (string[])rk64.GetValue("InstalledInstances");
            }

            return output;
        }

        private static string Decrypt(string encreptedText)
        {
            string output = "";

            byte[] data = Convert.FromBase64String(encreptedText); // decrypt the incrypted text
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes("MAKV2SPBNI99212"));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    output = UTF8Encoding.UTF8.GetString(results);
                }
            }

            return output;
        }

        public static string GetServerID()
        {
            if (ConfigurationManager.AppSettings["ServerId"] == "N/A") return "N/A";

            string latestValue = "";

            for (int i = 1; i <= 3; i++)
            {
                if (i == 1)
                    latestValue = Decrypt(ConfigurationManager.AppSettings["ServerId"]);
                else
                    latestValue = Decrypt(latestValue);
            }

            return latestValue;
        }

        public static string ConnectionStringName()
        {
            return ConfigurationManager.AppSettings["ConnectionName"];
        }

        public static int GetDefaultUnitId()
        {
            return ConfigurationManager.AppSettings["DefaultUnitId"].ToString().ParseToInt();
        }

        public static string GetReportDBName()
        {
            return ConfigurationManager.AppSettings["DatabaseName"];
        }

        public static string GetReportUserName()
        {
            return ConfigurationManager.AppSettings["usr"];
        }

        public static string GetReportPassword()
        {
            return ConfigurationManager.AppSettings["pwd"];
        }

        public static bool IsLanConnection()
        {
            return bool.Parse(ConfigurationManager.AppSettings["isLan"]);
        }

        public static string GetServerName()
        {
            return ConfigurationManager.AppSettings["ServerName"];
        }


        public static int ParseToInt(this string str)
        {
            int output;
            int.TryParse(str, out output);
            return output;
        }

        public static decimal ParseToDecimal(this string str)
        {
            decimal  output;
            decimal.TryParse(str, out output);
            return output;
        }

        public static string GetLogFilePath()
        {
            return ConfigurationManager.AppSettings["logFile"];
        }


        public static void LogException(Exception ex)
        {
            int atIndex = ex.StackTrace.IndexOf("at Sto");
            int subStringLength = (ex.StackTrace.Length) - atIndex;

            new Logger().Log($"{ex.GetType().Name} \n \n {ex.Message} \n \n {ex.StackTrace.Substring(atIndex, subStringLength)}", GetLogFilePath());
        }

    }
}
