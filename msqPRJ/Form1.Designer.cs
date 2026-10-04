
namespace msqPRJ
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tP1 = new System.Windows.Forms.TabPage();
            this.lblAssistant = new System.Windows.Forms.Label();
            this.lblTxtResult = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblResultant = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProfit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBTransactionType = new System.Windows.Forms.ComboBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.BTNDeleteTexts = new System.Windows.Forms.Button();
            this.tP2Reports = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.CheckBox();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.cbAmount = new System.Windows.Forms.CheckBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countOfEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msqTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.msqPRJDataSet1 = new msqPRJ.msqPRJDataSet();
            this.tP3Settings = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerMassage = new System.Windows.Forms.Timer(this.components);
            this.msqTableTableAdapter = new msqPRJ.msqPRJDataSetTableAdapters.msqTableTableAdapter();
            this.timerClearlblAssistant = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tP1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tP2Reports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msqTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msqPRJDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tP1);
            this.tabControl1.Controls.Add(this.tP2Reports);
            this.tabControl1.Controls.Add(this.tP3Settings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(941, 639);
            this.tabControl1.TabIndex = 0;
            // 
            // tP1
            // 
            this.tP1.Controls.Add(this.lblAssistant);
            this.tP1.Controls.Add(this.lblTxtResult);
            this.tP1.Controls.Add(this.lblTime);
            this.tP1.Controls.Add(this.panel3);
            this.tP1.Controls.Add(this.panel2);
            this.tP1.Controls.Add(this.panel1);
            this.tP1.Controls.Add(this.label4);
            this.tP1.Controls.Add(this.label3);
            this.tP1.Controls.Add(this.label2);
            this.tP1.Controls.Add(this.label1);
            this.tP1.Controls.Add(this.CBTransactionType);
            this.tP1.Controls.Add(this.tbAmount);
            this.tP1.Controls.Add(this.dateTimePicker1);
            this.tP1.Controls.Add(this.tbDescription);
            this.tP1.Controls.Add(this.Save);
            this.tP1.Controls.Add(this.BTNDeleteTexts);
            this.tP1.Location = new System.Drawing.Point(4, 25);
            this.tP1.Name = "tP1";
            this.tP1.Padding = new System.Windows.Forms.Padding(3);
            this.tP1.Size = new System.Drawing.Size(933, 610);
            this.tP1.TabIndex = 0;
            this.tP1.Text = "ثبت سود/هزینه";
            this.tP1.UseVisualStyleBackColor = true;
            // 
            // lblAssistant
            // 
            this.lblAssistant.AutoSize = true;
            this.lblAssistant.ForeColor = System.Drawing.Color.Red;
            this.lblAssistant.Location = new System.Drawing.Point(212, 182);
            this.lblAssistant.Name = "lblAssistant";
            this.lblAssistant.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAssistant.Size = new System.Drawing.Size(46, 17);
            this.lblAssistant.TabIndex = 15;
            this.lblAssistant.Text = "label8";
            // 
            // lblTxtResult
            // 
            this.lblTxtResult.AutoSize = true;
            this.lblTxtResult.ForeColor = System.Drawing.Color.Red;
            this.lblTxtResult.Location = new System.Drawing.Point(785, 474);
            this.lblTxtResult.Name = "lblTxtResult";
            this.lblTxtResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTxtResult.Size = new System.Drawing.Size(46, 17);
            this.lblTxtResult.TabIndex = 14;
            this.lblTxtResult.Text = "label8";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(353, 514);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(46, 17);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "label8";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblResultant);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(123, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 70);
            this.panel3.TabIndex = 12;
            // 
            // lblResultant
            // 
            this.lblResultant.AutoSize = true;
            this.lblResultant.Location = new System.Drawing.Point(86, 36);
            this.lblResultant.Name = "lblResultant";
            this.lblResultant.Size = new System.Drawing.Size(46, 17);
            this.lblResultant.TabIndex = 1;
            this.lblResultant.Text = "label8";
            this.lblResultant.Click += new System.EventHandler(this.lblResultant_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 10);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "برایند هزینه ها :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.lblCost);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(375, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 70);
            this.panel2.TabIndex = 11;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(86, 36);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(46, 17);
            this.lblCost.TabIndex = 1;
            this.lblCost.Text = "label8";
            this.lblCost.Click += new System.EventHandler(this.lblCost_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 10);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "هزینه امروز :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LawnGreen;
            this.panel1.Controls.Add(this.lblProfit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(622, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 70);
            this.panel1.TabIndex = 10;
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Location = new System.Drawing.Point(86, 36);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(46, 17);
            this.lblProfit.TabIndex = 1;
            this.lblProfit.Text = "label8";
            this.lblProfit.Click += new System.EventHandler(this.lblProfit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 10);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "سود امروز :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(759, 321);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "تاریخ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 316);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "توضیحات :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 217);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "مبلغ (ریال) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(728, 217);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "نوع تراکنش :";
            // 
            // CBTransactionType
            // 
            this.CBTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTransactionType.FormattingEnabled = true;
            this.CBTransactionType.Items.AddRange(new object[] {
            "ورودی",
            "خروجی"});
            this.CBTransactionType.Location = new System.Drawing.Point(568, 214);
            this.CBTransactionType.Name = "CBTransactionType";
            this.CBTransactionType.Size = new System.Drawing.Size(121, 24);
            this.CBTransactionType.TabIndex = 5;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(212, 214);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(130, 22);
            this.tbAmount.TabIndex = 4;
            this.tbAmount.Validated += new System.EventHandler(this.tbAmount_Validated);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(523, 316);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(105, 316);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(237, 76);
            this.tbDescription.TabIndex = 2;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(725, 497);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(113, 35);
            this.Save.TabIndex = 1;
            this.Save.Text = "ذخیره";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // BTNDeleteTexts
            // 
            this.BTNDeleteTexts.Location = new System.Drawing.Point(567, 497);
            this.BTNDeleteTexts.Name = "BTNDeleteTexts";
            this.BTNDeleteTexts.Size = new System.Drawing.Size(113, 35);
            this.BTNDeleteTexts.TabIndex = 0;
            this.BTNDeleteTexts.Text = "پاک کردن فرم";
            this.BTNDeleteTexts.UseVisualStyleBackColor = true;
            this.BTNDeleteTexts.Click += new System.EventHandler(this.BTNDeleteTexts_Click);
            // 
            // tP2Reports
            // 
            this.tP2Reports.Controls.Add(this.label11);
            this.tP2Reports.Controls.Add(this.cbType);
            this.tP2Reports.Controls.Add(this.cbDate);
            this.tP2Reports.Controls.Add(this.cbAmount);
            this.tP2Reports.Controls.Add(this.btnReport);
            this.tP2Reports.Controls.Add(this.btnSearch);
            this.tP2Reports.Controls.Add(this.textBox3);
            this.tP2Reports.Controls.Add(this.comboBox2);
            this.tP2Reports.Controls.Add(this.label10);
            this.tP2Reports.Controls.Add(this.dateTimePicker2);
            this.tP2Reports.Controls.Add(this.comboBox3);
            this.tP2Reports.Controls.Add(this.label9);
            this.tP2Reports.Controls.Add(this.comboBox1);
            this.tP2Reports.Controls.Add(this.label8);
            this.tP2Reports.Controls.Add(this.dataGridView1);
            this.tP2Reports.Location = new System.Drawing.Point(4, 25);
            this.tP2Reports.Name = "tP2Reports";
            this.tP2Reports.Padding = new System.Windows.Forms.Padding(3);
            this.tP2Reports.Size = new System.Drawing.Size(933, 610);
            this.tP2Reports.TabIndex = 1;
            this.tP2Reports.Text = "جستجو و گزارش گیری";
            this.tP2Reports.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(851, 93);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "نوع جستجو :";
            // 
            // cbType
            // 
            this.cbType.AutoSize = true;
            this.cbType.Location = new System.Drawing.Point(600, 92);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(85, 21);
            this.cbType.TabIndex = 13;
            this.cbType.Text = "نوع تراکنش";
            this.cbType.UseVisualStyleBackColor = true;
            // 
            // cbDate
            // 
            this.cbDate.AutoSize = true;
            this.cbDate.Location = new System.Drawing.Point(711, 92);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(54, 21);
            this.cbDate.TabIndex = 12;
            this.cbDate.Text = "تاریخ";
            this.cbDate.UseVisualStyleBackColor = true;
            // 
            // cbAmount
            // 
            this.cbAmount.AutoSize = true;
            this.cbAmount.Location = new System.Drawing.Point(795, 92);
            this.cbAmount.Name = "cbAmount";
            this.cbAmount.Size = new System.Drawing.Size(47, 21);
            this.cbAmount.TabIndex = 11;
            this.cbAmount.Text = "مبلغ";
            this.cbAmount.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(659, 126);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(130, 34);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "گزارش گیری";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(795, 126);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 34);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(682, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 22);
            this.textBox3.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            ">",
            ">=",
            "=",
            "<=",
            "<"});
            this.comboBox2.Location = new System.Drawing.Point(531, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(414, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "مبلغ (ریال) :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(281, 89);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            ">",
            ">=",
            "=",
            "<=",
            "<"});
            this.comboBox3.Location = new System.Drawing.Point(119, 86);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "تاریخ :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ورودی",
            "خروجی"});
            this.comboBox1.Location = new System.Drawing.Point(119, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "نوع تراکنش :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Update,
            this.amount,
            this.transactionType,
            this.date,
            this.description,
            this.countOfEdit,
            this.ID});
            this.dataGridView1.DataSource = this.msqTableBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(927, 441);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "حذف";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "حذف";
            this.Delete.ToolTipText = "حذف";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // Update
            // 
            this.Update.HeaderText = "ویرایش";
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Update.Text = "ویرایش";
            this.Update.ToolTipText = "ویرایش";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 125;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "Amount";
            this.amount.HeaderText = "مبلغ(ریال)";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 125;
            // 
            // transactionType
            // 
            this.transactionType.DataPropertyName = "TransactionType";
            this.transactionType.HeaderText = "نوع تراکنش";
            this.transactionType.MinimumWidth = 6;
            this.transactionType.Name = "transactionType";
            this.transactionType.ReadOnly = true;
            this.transactionType.Width = 125;
            // 
            // date
            // 
            this.date.DataPropertyName = "Date";
            this.date.HeaderText = "تاریخ";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 125;
            // 
            // description
            // 
            this.description.DataPropertyName = "Description";
            this.description.HeaderText = "توضیحات";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 125;
            // 
            // countOfEdit
            // 
            this.countOfEdit.DataPropertyName = "CountOfEdit";
            this.countOfEdit.HeaderText = "تعداد ویرایش";
            this.countOfEdit.MinimumWidth = 6;
            this.countOfEdit.Name = "countOfEdit";
            this.countOfEdit.ReadOnly = true;
            this.countOfEdit.Width = 125;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "شناسه";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // msqTableBindingSource
            // 
            this.msqTableBindingSource.DataMember = "msqTable";
            this.msqTableBindingSource.DataSource = this.msqPRJDataSet1;
            // 
            // msqPRJDataSet1
            // 
            this.msqPRJDataSet1.DataSetName = "msqPRJDataSet";
            this.msqPRJDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tP3Settings
            // 
            this.tP3Settings.Location = new System.Drawing.Point(4, 25);
            this.tP3Settings.Name = "tP3Settings";
            this.tP3Settings.Size = new System.Drawing.Size(933, 610);
            this.tP3Settings.TabIndex = 2;
            this.tP3Settings.Text = "تنظیمات";
            this.tP3Settings.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerMassage
            // 
            this.timerMassage.Interval = 3000;
            this.timerMassage.Tick += new System.EventHandler(this.timerMassage_Tick);
            // 
            // msqTableTableAdapter
            // 
            this.msqTableTableAdapter.ClearBeforeFill = true;
            // 
            // timerClearlblAssistant
            // 
            this.timerClearlblAssistant.Interval = 20000;
            this.timerClearlblAssistant.Tick += new System.EventHandler(this.timerClearlblAssistant_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(941, 639);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت مالی مسجد";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tP1.ResumeLayout(false);
            this.tP1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tP2Reports.ResumeLayout(false);
            this.tP2Reports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msqTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msqPRJDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tP1;
        private System.Windows.Forms.TabPage tP2Reports;
        private System.Windows.Forms.TabPage tP3Settings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBTransactionType;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button BTNDeleteTexts;
        private System.Windows.Forms.Label lblTxtResult;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblResultant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerMassage;
        private System.Windows.Forms.Label lblAssistant;
        private System.Windows.Forms.DataGridView dataGridView1;
        private msqPRJDataSet msqPRJDataSet1;
        private System.Windows.Forms.BindingSource msqTableBindingSource;
        private msqPRJDataSetTableAdapters.msqTableTableAdapter msqTableTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbType;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.CheckBox cbAmount;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn countOfEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Timer timerClearlblAssistant;

        #endregion

        //private System.Windows.Forms.TabControl tabControl1;
        //private System.Windows.Forms.TabPage tP1;
        //private System.Windows.Forms.TabPage tP2Reports;
        //private System.Windows.Forms.TabPage tP3Settings;
        //private System.Windows.Forms.Button BTNDeleteTexts;
        //private System.Windows.Forms.Button Save;
        //private System.Windows.Forms.TextBox tbDescription;
        //private System.Windows.Forms.DateTimePicker dateTimePicker1;
        //private System.Windows.Forms.TextBox tbAmount;
        //private System.Windows.Forms.Label label7;
        //private System.Windows.Forms.Label label6;
        //private System.Windows.Forms.Label label5;
        //private System.Windows.Forms.Label label4;
        //private System.Windows.Forms.Panel panel3;
        //private System.Windows.Forms.Label lblProfit;
        //private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.Panel panel2;
        //private System.Windows.Forms.Label lblCost;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Panel panel1;
        //private System.Windows.Forms.Label lblResultant;
        //private System.Windows.Forms.Label label3;
        //private System.Windows.Forms.Label lblTime;
        //private System.Windows.Forms.Timer timer1;
        //private System.Windows.Forms.Label lblTxtResult;
        //private System.Windows.Forms.Timer timerMassage;
        //private System.Windows.Forms.DataGridView dataGridView1;
        //private System.Windows.Forms.Label label9;
        //private System.Windows.Forms.ComboBox comboBox1;
        //private System.Windows.Forms.Label label8;
        //private System.Windows.Forms.DateTimePicker dateTimePicker2;
        //private System.Windows.Forms.ComboBox comboBox3;
        //private System.Windows.Forms.Label label10;
        //private System.Windows.Forms.ComboBox comboBox2;
        //private System.Windows.Forms.TextBox textBox3;
        //private System.Windows.Forms.ComboBox CBTransactionType;
        //private msqPRJDataSet1 msqPRJDataSet1;
        //private System.Windows.Forms.BindingSource msqTableBindingSource;
        //private msqPRJDataSet1TableAdapters.msqTableTableAdapter msqTableTableAdapter;
        //private System.Windows.Forms.Button btnSearch;
        //private System.Windows.Forms.DataGridViewButtonColumn Delete;
        //private System.Windows.Forms.DataGridViewButtonColumn Update;
        //private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        //private System.Windows.Forms.DataGridViewTextBoxColumn date;
        //private System.Windows.Forms.DataGridViewTextBoxColumn transactionType;
        //private System.Windows.Forms.DataGridViewTextBoxColumn description;
        //private System.Windows.Forms.DataGridViewTextBoxColumn CountOfEdit;
        //private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        //private System.Windows.Forms.Label lblAssistant;
        //private System.Windows.Forms.Button btnReport;
        //private System.Windows.Forms.Label label11;
        //private System.Windows.Forms.CheckBox cbDate;
        //private System.Windows.Forms.CheckBox cbAmount;
        //private System.Windows.Forms.CheckBox cbType;
    }
}

