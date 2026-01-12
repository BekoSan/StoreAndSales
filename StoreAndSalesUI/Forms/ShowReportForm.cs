using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using StoreAndSalesUI.Helpers;
using StoreAndSalesUI.Interfaces;
using StoreAndSalesUI.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StoreAndSalesUI.Forms
{
    public partial class ShowReportForm : Form , IPurchaseReportRequester,ISaleReportRequster,ISupplierAccountReportRequester,
        ICustomerAccountReportRequester
    {

        #region Private Members

        private PurchaseReport _purchaseReport = new PurchaseReport();
        
        private int _purchaseId = 0;
        
        private SaleReport _saleReport = new SaleReport();

        private int _saleId = 0;

        private SupplierAccountDetails _supplierAccountDetailsReport = new SupplierAccountDetails();
        
        private int _supplierId = 0;

        private CustomerAccountDetails _customerAccountDetailsReport = new CustomerAccountDetails();

        private int _customerId = 0;

        #endregion

        #region Private Methods

        private void ViewReport(ReportDocument report, int parameterValue)
        {
            report.SetParameterValue(0, parameterValue);
            crystalReportViewer1.ReportSource = report;
           
            string serverName = UsefulMethods.GetServerName();
            if (serverName == "")
            {
                return;
            }
            else
            {
                //ConnectionInfo crConnectionInfo = new ConnectionInfo();
                //crConnectionInfo.ServerName = serverName;
                //crConnectionInfo.DatabaseName = ""; // Leave blank for AttachDbFileName
                //crConnectionInfo.IntegratedSecurity = true; // THIS IS THE KEY

                //foreach (Table table in report.Database.Tables)
                //{
                //    TableLogOnInfo tableLogOnInfo = table.LogOnInfo;
                //    tableLogOnInfo.ConnectionInfo = crConnectionInfo;
                //    table.ApplyLogOnInfo(tableLogOnInfo);
                //}
                report.DataSourceConnections[0].SetConnection(serverName, UsefulMethods.GetReportDBName(), true);
                crystalReportViewer1.Show();
            }
        }

        public void FillReport(ReportDocument reportObj, Dictionary<string, string> queriesAndTables,int parameterValue)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[UsefulMethods.ConnectionStringName()].ConnectionString;

            crystalReportViewer1.ReportSource = reportObj;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // إنشاء الـ DataSet التي صممتها سابقاً
                using (StoreDataSet ds = new StoreDataSet())
                {

                    foreach (var item in queriesAndTables)
                    {
                        string sqlQuery = item.Key;   // جملة الـ SELECT
                        string tableName = item.Value; // اسم الجدول في الـ DataSet

                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con))
                            // ملء الجدول المحدد بالبيانات
                            da.Fill(ds, tableName);
                    }

                    // ربط الـ DataSet الممتلئة بالتقرير
                    reportObj.SetDataSource(ds);
                    reportObj.SetParameterValue(0, parameterValue);
                }
            }

            crystalReportViewer1.Show();
        }

        #endregion

        public ShowReportForm()
        {
            InitializeComponent();
        }

        private void ShowReportForm_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> tables;

            if (_purchaseId != 0)
            {
                tables = new Dictionary<string, string>
            {
                { "Select * from Purchase", "Purchase" },
                { "Select * From PurchaseDetail","PurchaseDetail"},
                { "Select * From Supplier","Supplier"},
                { "Select * From Item","Item"},
                { "Select * From Unit","Unit"}
            };
                //ViewReport(_purchaseReport, _purchaseId); 
                FillReport(_purchaseReport, tables, _purchaseId); 
            }
            else if (_saleId != 0)
            {
                tables = new Dictionary<string, string>
            {
                { "Select * from Sale", "Sale" },
                { "Select * From SaleDetail","SaleDetail"},
                { "Select * From Customer","Customer"},
                { "Select * From Item","Item"},
                { "Select * From Unit","Unit"}
            };
                //ViewReport(_saleReport, _saleId);
                FillReport(_saleReport, tables, _saleId);
            }
            else if (_supplierId  != 0)
            {
                tables = new Dictionary<string, string>
            {
                { "Select * from Voucher", "Voucher" },
                { "Select * From Supplier","Supplier"}
            };

                //ViewReport(_supplierAccountDetailsReport, _supplierId);
                FillReport(_supplierAccountDetailsReport, tables, _supplierId);
            }
            else if (_customerId != 0)
            {
                tables = new Dictionary<string, string>
            {
                { "Select * from Voucher", "Voucher" },
                { "Select * From Customer","Customer"}
            };
                //ViewReport(_customerAccountDetailsReport, _customerId);
                FillReport(_customerAccountDetailsReport, tables, _customerId);
            }
        }

        public void GetPurshaseId(int purchaseId)
        {
            _purchaseId = purchaseId;
        }

        public void GetSaleId(int saleId)
        {
           _saleId = saleId;
        }

        public void GetSupplierId(int supplierId)
        {
            _supplierId = supplierId;
        }

        public void GetCustomerId(int customerId)
        {
         _customerId = customerId;
        }
    }
}
