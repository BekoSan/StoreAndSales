using CrystalDecisions.CrystalReports.Engine;
using StoreAndSalesUI.Helpers;
using StoreAndSalesUI.Interfaces;
using StoreAndSalesUI.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreAndSalesUI.Forms
{
    public partial class ShowReportForm : Form , IPurchaseReportRequester
    {

        #region Private Members

        private PurchaseReport _purchaseReport = new PurchaseReport();
        
        private int _purchaseId = 0;
        
        
        #endregion

        #region Private Methods

        private void ViewReport(ReportDocument report, int parameterValue)
        {
            crystalReportViewer1.ReportSource = report;
           
            report.SetParameterValue(0, parameterValue);
            
            string serverName = UsefulMethods.GetServerName();
            if (serverName == "")
            {
                return;
            }
            else
            {
                report.DataSourceConnections[0].SetConnection(serverName, UsefulMethods.GetReportDBName(), true);

                crystalReportViewer1.Show();
            }
        }


        #endregion

        public ShowReportForm()
        {
            InitializeComponent();
        }

        private void ShowReportForm_Load(object sender, EventArgs e)
        {
            ViewReport(_purchaseReport, _purchaseId);
        }

        public void GetPurshaseId(int purchaseId)
        {
            _purchaseId = purchaseId;
        }

    }
}
