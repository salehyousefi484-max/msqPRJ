using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace msqPRJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string cs = "Data Source=.; Initial Catalog=msqPRJ; Integrated Security=true";

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'msqPRJDataSet.msqTable' table. You can move, or remove it, as needed.
            this.msqTableTableAdapter.Fill(this.msqPRJDataSet.msqTable);
            // TODO: This line of code loads data into the 'msqPRJDataSet1.msqTable' table. You can move, or remove it, as needed.
            this.msqTableTableAdapter.Fill(this.msqPRJDataSet.msqTable);
            //لیبل های 4 تا 6 که برای هزینه ها و سود هستش رو بنویس.
            lblTxtResult.Text = "";
            lblAssistant.Text = "";
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            LoadData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO msqTable(Amount,Date,TransactionType,IsDeleted,Description,CountOfEdit) VALUES(@Amount,@Date,@TransactionType,@IsDeleted,@Description,@CountOfEdit)", con);
                    cmd.Parameters.AddWithValue("@Amount", tbAmount.Text);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@TransactionType", CBTransactionType.Text);
                    cmd.Parameters.AddWithValue("@IsDeleted", false);
                    cmd.Parameters.AddWithValue("@Description", tbDescription.Text);
                    cmd.Parameters.AddWithValue("@CountOfEdit", 0);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                LoadData();
                lblTxtResult.Text = "با موفقیت ذخیره شد.";
                timerMassage.Stop();
                timerMassage.Start();
                tbAmount.Text = "";
                tbDescription.Text = "";
                lblAssistant.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timerMassage_Tick(object sender, EventArgs e)
        {
            timerMassage.Stop();
            lblTxtResult.Text = "";
        }

        private void BTNDeleteTexts_Click(object sender, EventArgs e)
        {
            tbAmount.Text = "";
            tbDescription.Text = "";
            lblAssistant.Text = "";
        }

        public void LoadData()
        {
            string cmdText = "SELECT * FROM msqTable WHERE IsDeleted=0";
            string cmdText1 = "SELECT ISNULL(SUM(Amount), 0) FROM msqTable WHERE TransactionType=N'ورودی' AND IsDeleted=0 AND CAST(Date AS date) = @Today;";
            string cmdText2 = "SELECT ISNULL(SUM(Amount), 0) FROM msqTable WHERE TransactionType=N'خروجی' AND IsDeleted=0 AND CAST(Date AS date) = @Today;";
            decimal Profit;
            decimal Cost;
            decimal Resultant;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(cmdText, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            using (SqlConnection con1 = new SqlConnection(cs))
            {
                SqlCommand cmd1 = new SqlCommand(cmdText1, con1);
                cmd1.Parameters.AddWithValue("@Today", DateTime.Now.ToString("yyyy/MM/dd"));
                con1.Open();
                Profit = Convert.ToDecimal(cmd1.ExecuteScalar());
                lblProfit.Text = Profit.ToString();
            }

            using (SqlConnection con2 = new SqlConnection(cs))
            {
                SqlCommand cmd2 = new SqlCommand(cmdText2, con2);
                cmd2.Parameters.AddWithValue("@Today", DateTime.Now.ToString("yyyy/MM/dd"));
                con2.Open();
                Cost = Convert.ToDecimal(cmd2.ExecuteScalar());
                lblCost.Text = Cost.ToString();
            }

            Resultant = Profit - Cost;
            lblResultant.Text = Resultant.ToString();
            if (Resultant < 0)
                panel3.BackColor = Color.Red;
            else if (Resultant > 0)
                panel3.BackColor = Color.LawnGreen;
            else
                panel3.BackColor = Color.White;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                int ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["iD"].Value);

                if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (MessageBox.Show("ایا از پاک کردن این اطلاعات اطمینان دارید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection(cs))
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE msqTable SET isDeleted=@IsDeleted, DeletedDate=@DeletedDate WHERE ID=@ID", con);
                            cmd.Parameters.AddWithValue("@IsDeleted", true);
                            cmd.Parameters.AddWithValue("@DeletedDate", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                            cmd.Parameters.AddWithValue("@ID", ID);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    LoadData();
                }

                if (dataGridView1.Columns[e.ColumnIndex].Name == "Update")
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["iD"].Value);
                    decimal amount = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["amount"].Value);
                    object date = dataGridView1.Rows[e.RowIndex].Cells["date"].Value;
                    string description = dataGridView1.Rows[e.RowIndex].Cells["description"].Value.ToString();
                    int countOfEdit = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CountOfEdit"].Value);

                    Form2 form2 = new Form2();
                    form2.PassData(id, amount, date, description, countOfEdit);
                    form2.ShowDialog();
                    LoadData();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbAmount_Validated(object sender, EventArgs e)
        {
            string amountSTR = tbAmount.Text;
            if (amountSTR != "")
            {
                long Amount = Convert.ToInt64(amountSTR);
                if (Amount >= 10000 && Amount < 10000000)
                {
                    long result = Amount / 10000;
                    lblAssistant.Text = result.ToString() + " هزار تومان";
                }

                if (Amount >= 10000000 && Amount < 10000000000)
                {
                    long result1 = Amount % 10000;
                    Amount /= 10000;
                    long result2 = Amount % 1000;
                    Amount /= 1000;

                    if (result1 != 0 && result2 != 0)
                        lblAssistant.Text = Amount.ToString() + " میلیون و " + result2.ToString() + " هزار و " + (result1 / 10).ToString() + " تومان";

                    else if (result2 != 0 && result1 == 0)
                        lblAssistant.Text = Amount.ToString() + " میلیون و " + result2.ToString() + " هزار تومان ";

                    else if (result1 != 0 && result2 == 0)
                        lblAssistant.Text = Amount.ToString() + " میلیون و " + (result1/10).ToString() + " تومان";

                    else if (result1 == 0 && result2 == 0)
                        lblAssistant.Text = Amount.ToString() + " میلیون تومان ";
                }

                if (Amount >= 10000000000)
                    lblAssistant.Text = "این دیگه خیلی زیادیه. منم نمیتونم صفراشو بشمرم:))";
            }

            else
                lblAssistant.Text = "";
        }

        private string cmdT = $"SELECT * FROM msqTable WHERE IsDeleted=0";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cbDate.Checked && !cbAmount.Checked && !cbType.Checked)
                {
                    MessageBox.Show("لطفا حداقل یکی از انواع جستجو را انتخاب کنید", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        SqlCommand cmd = new SqlCommand($"SELECT * FROM msqTable WHERE IsDeleted=0", con);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    cmdT = $"SELECT * FROM msqTable WHERE IsDeleted=0";
                }

                else if (!cbDate.Checked && cbAmount.Checked && !cbType.Checked)
                {

                    if (comboBox2.Text != "" && textBox3.Text != "")
                    {
                        using (SqlConnection con = new SqlConnection(cs))
                        {
                            SqlCommand cmd = new SqlCommand($"SELECT * FROM msqTable WHERE Amount {comboBox2.Text} @Amount AND IsDeleted=0", con);
                            cmd.Parameters.AddWithValue("@Amount", textBox3.Text);

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                        cmdT = $"SELECT * FROM msqTable WHERE Amount {comboBox2.Text} @Amount AND IsDeleted=0";
                        
                    }

                    else
                        MessageBox.Show("لطفا فیلد های خواسته شده را پر کنید", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (cbDate.Checked && !cbAmount.Checked && !cbType.Checked)
                {
                    if (comboBox3.Text != "")
                    {
                        using (SqlConnection con = new SqlConnection(cs))
                        {
                            SqlCommand cmd = new SqlCommand($"SELECT * FROM msqTable WHERE CAST([Date] AS Date) {comboBox3.Text} @Date AND IsDeleted=0", con);
                            cmd.Parameters.AddWithValue("@Date", SqlDbType.Date).Value = dateTimePicker2.Value.Date;

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                        cmdT = $"SELECT * FROM msqTable WHERE CAST([Date] AS Date) {comboBox3.Text} @Date AND IsDeleted=0";
                    }

                    else
                        MessageBox.Show("لطفا فیلد های خواسته شده را پر کنید", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (!cbDate.Checked && !cbAmount.Checked && cbType.Checked)
                {
                    if (comboBox1.Text != "")
                    {
                        using (SqlConnection con = new SqlConnection(cs))
                        {
                            SqlCommand cmd = new SqlCommand($"SELECT * FROM msqTable WHERE TransactionType=@TransactionType AND IsDeleted=0", con);
                            cmd.Parameters.AddWithValue("@TransactionType", comboBox1.Text);

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                        cmdT = $"SELECT * FROM msqTable WHERE TransactionType=@TransactionType AND IsDeleted=0";
                    }

                    else
                        MessageBox.Show("لطفا فیلد های خواسته شده را پر کنید", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (cbDate.Checked && cbAmount.Checked && !cbType.Checked)
                {
                    if (comboBox3.Text != "" && comboBox2.Text != "" && textBox3.Text != "")
                    {
                        using (SqlConnection con = new SqlConnection(cs))
                        {
                            SqlCommand cmd = new SqlCommand($"SELECT * FROM msqTable WHERE Amount {comboBox2.Text} @Amount AND CAST([Date] AS Date) {comboBox3.Text} @Date AND IsDeleted=0", con);
                            cmd.Parameters.AddWithValue("@Amount", textBox3.Text);
                            cmd.Parameters.AddWithValue("@Date", SqlDbType.Date).Value = dateTimePicker2.Value.Date;

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                        cmdT = $"SELECT * FROM msqTable WHERE Amount {comboBox2.Text} @Amount AND CAST([Date] AS Date) {comboBox3.Text} @Date AND IsDeleted=0";
                    }

                    else
                        MessageBox.Show("لطفا فیلد های خواسته شده را پر کنید", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (cbDate.Checked && !cbAmount.Checked && cbType.Checked)
                {
                    if (comboBox3.Text != "" && comboBox1.Text != "")
                    {
                        using (SqlConnection con = new SqlConnection(cs))
                        {
                            SqlCommand cmd = new SqlCommand($"SELECT * FROM msqTable WHERE CAST([Date] AS Date) {comboBox3.Text} @Date AND TransactionType=@TransactionType AND IsDeleted=0", con);
                            cmd.Parameters.AddWithValue("@Date", SqlDbType.Date).Value = dateTimePicker2.Value.Date;
                            cmd.Parameters.AddWithValue("@TransactionType", comboBox1.Text);

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                        cmdT = $"SELECT * FROM msqTable WHERE CAST([Date] AS Date) {comboBox3.Text} AND TransactionType=@TransactionType AND IsDeleted=0";
                    }

                    else
                        MessageBox.Show("لطفا فیلد های خواسته شده را پر کنید", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (!cbDate.Checked && cbAmount.Checked && cbType.Checked)
                {
                    if (comboBox1.Text != "" && comboBox2.Text != "" && textBox3.Text != "")
                    {
                        using (SqlConnection con = new SqlConnection(cs))
                        {
                            SqlCommand cmd = new SqlCommand($"SELECT * FROM msqTable WHERE TransactionType=@TransactionType AND Amount {comboBox2.Text} @Amount AND IsDeleted=0", con);
                            cmd.Parameters.AddWithValue("@Amount", textBox3.Text);
                            cmd.Parameters.AddWithValue("@TransactionType", comboBox1.Text);

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                        cmdT = $"SELECT * FROM msqTable WHERE TransactionType=@TransactionType AND Amount {comboBox2.Text} @Amount AND IsDeleted=0";
                    }

                    else
                        MessageBox.Show("لطفا فیلد های خواسته شده را پر کنید", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                else if (cbDate.Checked && cbAmount.Checked && cbType.Checked)
                {
                    if (comboBox1.Text != "" && comboBox3.Text != "" && comboBox2.Text != "" && textBox3.Text != "")
                    {
                        using (SqlConnection con = new SqlConnection(cs))
                        {
                            SqlCommand cmd = new SqlCommand($"SELECT * FROM msqTable WHERE Amount {comboBox2.Text} @Amount AND TransactionType=@TransactionType AND CAST([Date] AS Date) {comboBox3.Text} @Date AND IsDeleted=0", con);
                            cmd.Parameters.AddWithValue("@Amount", textBox3.Text);
                            cmd.Parameters.AddWithValue("@TransactionType", comboBox1.Text);
                            cmd.Parameters.AddWithValue("@Date", SqlDbType.Date).Value = dateTimePicker2.Value.Date;

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                        cmdT = $"SELECT * FROM msqTable WHERE Amount {comboBox2.Text} @Amount AND TransactionType=@TransactionType AND CAST([Date] AS Date) {comboBox3.Text} @Date AND IsDeleted=0";
                    }

                    else
                        MessageBox.Show("لطفا فیلد های خواسته شده را پر کنید", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                frmReport frm = new frmReport();

                frm.cmdText = cmdT;
                frm.tB3 = textBox3.Text;
                frm.cB1 = comboBox1.Text;
                frm.cB2 = comboBox2.Text;
                frm.cB3 = comboBox3.Text;
                frm.dtp = dateTimePicker2.Value.Date;

                frm.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblProfit_Click(object sender, EventArgs e)
        {
            string amountSTR = lblProfit.Text;
            if (amountSTR != "")
            {
                long Amount = Convert.ToInt64(amountSTR);
                if (Amount >= 10000 && Amount < 10000000)
                {
                    long result = Amount / 10000;
                    lblAssistant.Text = result.ToString() + " هزار تومان";
                }

                if (Amount >= 10000000 && Amount < 10000000000)
                {
                    long result1 = Amount % 10000;
                    Amount /= 10000;
                    long result2 = Amount % 1000;
                    Amount /= 1000;

                    if (result1 != 0 && result2 != 0)
                        lblAssistant.Text = Amount.ToString() + " میلیون و " + result2.ToString() + " هزار و " + (result1 / 10).ToString() + " تومان";

                    else if (result2 != 0 && result1 == 0)
                        lblAssistant.Text = Amount.ToString() + " میلیون و " + result2.ToString() + " هزار تومان ";

                    else if (result1 != 0 && result2 == 0)
                        lblAssistant.Text = Amount.ToString() + " میلیون و " + (result1 / 10).ToString() + " تومان";

                    else if (result1 == 0 && result2 == 0)
                        lblAssistant.Text = Amount.ToString() + " میلیون تومان ";
                }

                if (Amount >= 10000000000)
                    lblAssistant.Text = "این دیگه خیلی زیادیه. منم نمیتونم صفراشو بشمرم:))";

                timerClearlblAssistant.Stop();
                timerClearlblAssistant.Start();
            }

        }

        private void timerClearlblAssistant_Tick(object sender, EventArgs e)
        {
            timerClearlblAssistant.Stop();
            lblAssistant.Text = "";
        }

        private void lblCost_Click(object sender, EventArgs e)
        {
            string amountSTR = lblCost.Text;
            if (amountSTR != "")
            {
                long Amount = Convert.ToInt64(amountSTR);
                if (Amount >= 10000 && Amount < 10000000)
                {
                    long result = Amount / 10000;
                    lblAssistant.Text = result.ToString() + " هزار تومان";
                }

                if (Amount >= 10000000 && Amount < 10000000000)
                {
                    long result1 = Amount % 10000;
                    Amount /= 10000;
                    long result2 = Amount % 1000;
                    Amount /= 1000;

                    if (result1 != 0 && result2 != 0)
                        lblAssistant.Text = Amount.ToString() + " میلیون و " + result2.ToString() + " هزار و " + (result1 / 10).ToString() + " تومان";

                    else if (result2 != 0 && result1 == 0)
                        lblAssistant.Text = Amount.ToString() + " میلیون و " + result2.ToString() + " هزار تومان ";

                    else if (result1 != 0 && result2 == 0)
                        lblAssistant.Text = Amount.ToString() + " میلیون و " + (result1 / 10).ToString() + " تومان";

                    else if (result1 == 0 && result2 == 0)
                        lblAssistant.Text = Amount.ToString() + " میلیون تومان ";
                }

                if (Amount >= 10000000000)
                    lblAssistant.Text = "این دیگه خیلی زیادیه. منم نمیتونم صفراشو بشمرم:))";

                timerClearlblAssistant.Stop();
                timerClearlblAssistant.Start();
            }
        }

        private void lblResultant_Click(object sender, EventArgs e)
        {
            string amountSTR = lblResultant.Text;
            if (amountSTR != "")
            {
                long Amount = Convert.ToInt64(amountSTR);

                if (Amount < 0)
                    Amount *= (-1);

                if (Amount >= 10000 && Amount < 10000000)
                {
                    long result = Amount / 10000;
                    lblAssistant.Text = result.ToString() + " هزار تومان";
                }

                if (Amount >= 10000000 && Amount < 10000000000)
                {
                    long result1 = Amount % 10000;
                    Amount /= 10000;
                    long result2 = Amount % 1000;
                    Amount /= 1000;

                    if (result1 != 0 && result2 != 0)
                        lblAssistant.Text = Amount.ToString() + " میلیون و " + result2.ToString() + " هزار و " + (result1 / 10).ToString() + " تومان";

                    else if (result2 != 0 && result1 == 0)
                        lblAssistant.Text = Amount.ToString() + " میلیون و " + result2.ToString() + " هزار تومان ";

                    else if (result1 != 0 && result2 == 0)
                        lblAssistant.Text = Amount.ToString() + " میلیون و " + (result1 / 10).ToString() + " تومان";

                    else if (result1 == 0 && result2 == 0)
                        lblAssistant.Text = Amount.ToString() + " میلیون تومان ";
                }

                if (Amount >= 10000000000)
                    lblAssistant.Text = "این دیگه خیلی زیادیه. منم نمیتونم صفراشو بشمرم:))";

                timerClearlblAssistant.Stop();
                timerClearlblAssistant.Start();
            }
        }
    }
}
