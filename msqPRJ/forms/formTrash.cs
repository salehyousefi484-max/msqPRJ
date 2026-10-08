using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace msqPRJ.forms
{
    public partial class formTrash : Form
    {
        public formTrash()
        {
            InitializeComponent();
        }

        private void formTrash_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'msqPRJDataSet1.msqTable' table. You can move, or remove it, as needed.
            this.msqTableTableAdapter.Fill(this.msqPRJDataSet1.msqTable);
            dataGridView1.CellFormatting += DateHelper.GridCellFormatting;
            Loaddgv();
        }

        string cs = @"Data Source=.\SQLEXPRESS; Initial Catalog=msqPRJ; Integrated Security=true";

        private void Loaddgv()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM msqTable WHERE IsDeleted = 1", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Return")
            {
                if (MessageBox.Show("ایا از برگرداندن این اطلاعات اطمینان دارید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE msqTable SET isDeleted=0, DeletedDate=NULL WHERE ID=@ID", con);
                        cmd.Parameters.AddWithValue("@ID", ID);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                Loaddgv();
            }
        }
    }
}
