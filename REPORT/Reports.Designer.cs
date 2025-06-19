
namespace SilverTune.REPORT
{
    partial class Reports
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportOnNumberOfEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paseOneDS = new SilverTune.paseOneDS();
            this.reportOnNumberOfEntitiesTableAdapter = new SilverTune.paseOneDSTableAdapters.ReportOnNumberOfEntitiesTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.monthlyRevenueTableAdapter = new SilverTune.paseOneDSTableAdapters.MonthlyRevenueTableAdapter();
            this.top5TableAdapter = new SilverTune.paseOneDSTableAdapters.Top5TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportOnNumberOfEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paseOneDS)).BeginInit();
            this.SuspendLayout();
            // 
            // reportOnNumberOfEntitiesBindingSource
            // 
            this.reportOnNumberOfEntitiesBindingSource.DataMember = "ReportOnNumberOfEntities";
            this.reportOnNumberOfEntitiesBindingSource.DataSource = this.paseOneDS;
            // 
            // paseOneDS
            // 
            this.paseOneDS.DataSetName = "paseOneDS";
            this.paseOneDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportOnNumberOfEntitiesTableAdapter
            // 
            this.reportOnNumberOfEntitiesTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "dsNumberOfEntities";
            reportDataSource2.Value = this.reportOnNumberOfEntitiesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SilverTune.REPORT.ArtistBookingReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1335, 491);
            this.reportViewer1.TabIndex = 0;
            // 
            // monthlyRevenueTableAdapter
            // 
            this.monthlyRevenueTableAdapter.ClearBeforeFill = true;
            // 
            // top5TableAdapter
            // 
            this.top5TableAdapter.ClearBeforeFill = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 491);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportOnNumberOfEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paseOneDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private paseOneDSTableAdapters.ReportOnNumberOfEntitiesTableAdapter reportOnNumberOfEntitiesTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reportOnNumberOfEntitiesBindingSource;
        private paseOneDS paseOneDS;
        private paseOneDSTableAdapters.MonthlyRevenueTableAdapter monthlyRevenueTableAdapter;
        private paseOneDSTableAdapters.Top5TableAdapter top5TableAdapter;
    }
}