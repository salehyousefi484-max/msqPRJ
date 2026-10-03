
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
            this.tP2Reports = new System.Windows.Forms.TabPage();
            this.tP3Settings = new System.Windows.Forms.TabPage();
            this.BTNDeleteTexts = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.CBTransactionType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblResultant = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerMassage = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTxtResult = new System.Windows.Forms.Label();
            this.lblAssistant = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tP1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            // tP2Reports
            // 
            this.tP2Reports.Location = new System.Drawing.Point(4, 25);
            this.tP2Reports.Name = "tP2Reports";
            this.tP2Reports.Padding = new System.Windows.Forms.Padding(3);
            this.tP2Reports.Size = new System.Drawing.Size(898, 507);
            this.tP2Reports.TabIndex = 1;
            this.tP2Reports.Text = "جستجو و گزارش گیری";
            this.tP2Reports.UseVisualStyleBackColor = true;
            // 
            // tP3Settings
            // 
            this.tP3Settings.Location = new System.Drawing.Point(4, 25);
            this.tP3Settings.Name = "tP3Settings";
            this.tP3Settings.Size = new System.Drawing.Size(898, 507);
            this.tP3Settings.TabIndex = 2;
            this.tP3Settings.Text = "تنظیمات";
            this.tP3Settings.UseVisualStyleBackColor = true;
            // 
            // BTNDeleteTexts
            // 
            this.BTNDeleteTexts.Location = new System.Drawing.Point(567, 497);
            this.BTNDeleteTexts.Name = "BTNDeleteTexts";
            this.BTNDeleteTexts.Size = new System.Drawing.Size(113, 35);
            this.BTNDeleteTexts.TabIndex = 0;
            this.BTNDeleteTexts.Text = "پاک کردن فرم";
            this.BTNDeleteTexts.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(725, 497);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(113, 35);
            this.Save.TabIndex = 1;
            this.Save.Text = "ذخیره";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(105, 316);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(237, 76);
            this.tbDescription.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(523, 316);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(239, 214);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(100, 22);
            this.tbAmount.TabIndex = 4;
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
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Location = new System.Drawing.Point(86, 36);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(46, 17);
            this.lblProfit.TabIndex = 1;
            this.lblProfit.Text = "label8";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(86, 36);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(46, 17);
            this.lblCost.TabIndex = 1;
            this.lblCost.Text = "label8";
            // 
            // lblResultant
            // 
            this.lblResultant.AutoSize = true;
            this.lblResultant.Location = new System.Drawing.Point(86, 36);
            this.lblResultant.Name = "lblResultant";
            this.lblResultant.Size = new System.Drawing.Size(46, 17);
            this.lblResultant.TabIndex = 1;
            this.lblResultant.Text = "label8";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // timerMassage
            // 
            this.timerMassage.Interval = 3000;
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
            // lblAssistant
            // 
            this.lblAssistant.AutoSize = true;
            this.lblAssistant.ForeColor = System.Drawing.Color.Red;
            this.lblAssistant.Location = new System.Drawing.Point(173, 217);
            this.lblAssistant.Name = "lblAssistant";
            this.lblAssistant.Size = new System.Drawing.Size(46, 17);
            this.lblAssistant.TabIndex = 15;
            this.lblAssistant.Text = "label8";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(941, 639);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tP1.ResumeLayout(false);
            this.tP1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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

