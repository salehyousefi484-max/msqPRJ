using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace msqPRJ
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblTxtResult.Text = "";
        }

        int id;
        int countOfEdit;

        public void PassData(int ID, decimal Amount, object Date, string Description, int CountOfEdit)
        {
            tbAmount.Text = Amount.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(Date);
            tbDescription.Text = Description.ToString();
            countOfEdit = CountOfEdit;
            id = ID;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (CBTransactionType.Text == "" || tbAmount.Text == "")
            {
                MessageBox.Show("لطفا نوع تراکنش و مبلغ را وارد کنید.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                string cs = "Data Source=.; Initial Catalog=msqPRJ; Integrated Security=true";
                try
                {
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE msqTable SET Amount=@Amount, Date=@Date, TransactionType=@TransactionType, Description=@Description, CountOfEdit=@CountOfEdit WHERE ID=@ID", con);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.Parameters.AddWithValue("@Amount", tbAmount.Text);
                        cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@TransactionType", CBTransactionType.Text);
                        cmd.Parameters.AddWithValue("@IsDeleted", false);
                        cmd.Parameters.AddWithValue("@Description", tbDescription.Text);
                        countOfEdit += 1;
                        cmd.Parameters.AddWithValue("@CountOfEdit", countOfEdit);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    lblTxtResult.Text = "با موفقیت ذخیره شد.";
                    timer1.Stop();
                    timer1.Start();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            lblTxtResult.Text = "";
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.LoadData();
        }
    }
}
