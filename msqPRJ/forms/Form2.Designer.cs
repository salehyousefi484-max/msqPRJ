
namespace msqPRJ
{
    partial class Form2
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
            this.CBTransactionType = new System.Windows.Forms.ComboBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTxtResult = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CBTransactionType
            // 
            this.CBTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTransactionType.FormattingEnabled = true;
            this.CBTransactionType.Items.AddRange(new object[] {
            "ورودی",
            "خروجی"});
            this.CBTransactionType.Location = new System.Drawing.Point(526, 49);
            this.CBTransactionType.Name = "CBTransactionType";
            this.CBTransactionType.Size = new System.Drawing.Size(121, 24);
            this.CBTransactionType.TabIndex = 24;
            // 
            // tbDescription
            // 
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescription.Location = new System.Drawing.Point(125, 165);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(224, 71);
            this.tbDescription.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(483, 162);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // tbAmount
            // 
            this.tbAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAmount.Location = new System.Drawing.Point(188, 50);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(129, 22);
            this.tbAmount.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 167);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "توضیحات :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(710, 167);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "تاریخ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 52);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "مبلغ (ریال) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(679, 52);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "نوع تراکنش :";
            // 
            // lblTxtResult
            // 
            this.lblTxtResult.AutoSize = true;
            this.lblTxtResult.ForeColor = System.Drawing.Color.Red;
            this.lblTxtResult.Location = new System.Drawing.Point(438, 354);
            this.lblTxtResult.Name = "lblTxtResult";
            this.lblTxtResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTxtResult.Size = new System.Drawing.Size(81, 17);
            this.lblTxtResult.TabIndex = 27;
            this.lblTxtResult.Text = "lblTxtResult";
            // 
            // Save
            // 
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Save.Location = new System.Drawing.Point(580, 340);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(134, 44);
            this.Save.TabIndex = 25;
            this.Save.Text = "ذخیره";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTxtResult);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.CBTransactionType);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBTransactionType;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTxtResult;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Timer timer1;
    }
}