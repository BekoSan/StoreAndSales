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
    public partial class ShowReportForm : Form , IPurchaseReportRequester,ISaleReportRequster,ISupplierAccountReportRequester
    {

        #region Private Members

        private PurchaseReport _purchaseReport = new PurchaseReport();
        
        private int _purchaseId = 0;
        
        private SaleReport _saleReport = new SaleReport();

        private int _saleId = 0;

        private SupplierAccountDetails _supplierAccountDetailsReport = new SupplierAccountDetails();
        
        private int _supplierId = 0;

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
            if (_purchaseId != 0)
            {
                ViewReport(_purchaseReport, _purchaseId);
            }
            else if (_saleId != 0)
            {
                ViewReport(_saleReport, _saleId);
            }
            else if (_supplierId  != 0)
            {
                ViewReport(_supplierAccountDetailsReport, _supplierId);
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
    }
}
