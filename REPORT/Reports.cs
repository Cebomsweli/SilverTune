using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverTune.REPORT
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            

            //Table one
            reportOnNumberOfEntitiesTableAdapter.Fill(this.paseOneDS.ReportOnNumberOfEntities);
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsNumberOfEntities", paseOneDS.Tables[4]));

            //Second Table Report
            monthlyRevenueTableAdapter.Fill(this.paseOneDS.MonthlyRevenue);
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsRevenue", paseOneDS.Tables[5]));

            //Third table Result
            top5TableAdapter.Fill(this.paseOneDS.Top5);
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsTop5", paseOneDS.Tables[6]));

            // ✅ Set report to Page View
           
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;

            this.reportViewer1.RefreshReport();

            
        }
    }
}
