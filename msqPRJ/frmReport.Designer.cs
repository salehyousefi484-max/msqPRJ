
namespace msqPRJ
{
    partial class frmReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.msqTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.msqPRJDataSet1 = new msqPRJ.msqPRJDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.msqTableTableAdapter = new msqPRJ.msqPRJDataSet1TableAdapters.msqTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.msqTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msqPRJDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // msqTableBindingSource
            // 
            this.msqTableBindingSource.DataMember = "msqTable";
            this.msqTableBindingSource.DataSource = this.msqPRJDataSet1;
            // 
            // msqPRJDataSet1
            // 
            this.msqPRJDataSet1.DataSetName = "msqPRJDataSet1";
            this.msqPRJDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.msqTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "msqPRJ.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(941, 639);
            this.reportViewer1.TabIndex = 0;
            // 
            // msqTableTableAdapter
            // 
            this.msqTableTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 639);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msqTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msqPRJDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource msqTableBindingSource;
        private msqPRJDataSet1 msqPRJDataSet1;
        private msqPRJDataSet1TableAdapters.msqTableTableAdapter msqTableTableAdapter;
    }
}