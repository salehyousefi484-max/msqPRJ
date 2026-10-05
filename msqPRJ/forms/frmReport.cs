using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace msqPRJ
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'msqPRJDataSet1.msqTable' table. You can move, or remove it, as needed.
            this.msqTableTableAdapter.Fill(this.msqPRJDataSet1.msqTable);

            LoadReportData();
            
            this.reportViewer1.RefreshReport();
        }

        public string cmdText { get; set; }
        public string tB3 { get; set; }
        public string cB1 { get; set; }
        public string cB2 { get; set; }
        public string cB3 { get; set; }
        public DateTime dtp { get; set; }


        private void LoadReportData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=msqPRJ; Integrated Security=true")) 
            {
                SqlDataAdapter da = new SqlDataAdapter(cmdText, con);
                da.SelectCommand.Parameters.AddWithValue("@Amount", tB3);
                da.SelectCommand.Parameters.AddWithValue("@TransactionType", cB1);
                da.SelectCommand.Parameters.Add("@Date", SqlDbType.Date).Value = dtp;
                da.Fill(dt);
            }

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
        }
    }
}
