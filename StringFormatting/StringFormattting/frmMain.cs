using System;
using System.Windows.Forms;

namespace StringFormattting
{
    public class frmMain : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtCompleteDateAndTime;
        private TextBox txtLongTime;
        private TextBox txtGeneralDateAndTime;
        private TextBox txtShortDate;
        private TextBox txtLongDate;
        private TextBox txtDaysToNewYears;
        private TextBox txtShortTime;
        private Button btnRefresh;
        private Button btnClose;

        #region Windows Code
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCompleteDateAndTime = new System.Windows.Forms.TextBox();
            this.txtLongTime = new System.Windows.Forms.TextBox();
            this.txtGeneralDateAndTime = new System.Windows.Forms.TextBox();
            this.txtShortDate = new System.Windows.Forms.TextBox();
            this.txtLongDate = new System.Windows.Forms.TextBox();
            this.txtDaysToNewYears = new System.Windows.Forms.TextBox();
            this.txtShortTime = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Date and Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Long Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Short Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "General Date and Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Long Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Short Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Days until New Years Eve:";
            // 
            // txtCompleteDateAndTime
            // 
            this.txtCompleteDateAndTime.Location = new System.Drawing.Point(144, 6);
            this.txtCompleteDateAndTime.Name = "txtCompleteDateAndTime";
            this.txtCompleteDateAndTime.Size = new System.Drawing.Size(199, 20);
            this.txtCompleteDateAndTime.TabIndex = 7;
            // 
            // txtLongTime
            // 
            this.txtLongTime.Location = new System.Drawing.Point(144, 99);
            this.txtLongTime.Name = "txtLongTime";
            this.txtLongTime.Size = new System.Drawing.Size(199, 20);
            this.txtLongTime.TabIndex = 8;
            // 
            // txtGeneralDateAndTime
            // 
            this.txtGeneralDateAndTime.Location = new System.Drawing.Point(144, 76);
            this.txtGeneralDateAndTime.Name = "txtGeneralDateAndTime";
            this.txtGeneralDateAndTime.Size = new System.Drawing.Size(199, 20);
            this.txtGeneralDateAndTime.TabIndex = 9;
            // 
            // txtShortDate
            // 
            this.txtShortDate.Location = new System.Drawing.Point(144, 53);
            this.txtShortDate.Name = "txtShortDate";
            this.txtShortDate.Size = new System.Drawing.Size(199, 20);
            this.txtShortDate.TabIndex = 10;
            // 
            // txtLongDate
            // 
            this.txtLongDate.Location = new System.Drawing.Point(144, 29);
            this.txtLongDate.Name = "txtLongDate";
            this.txtLongDate.Size = new System.Drawing.Size(199, 20);
            this.txtLongDate.TabIndex = 11;
            // 
            // txtDaysToNewYears
            // 
            this.txtDaysToNewYears.Location = new System.Drawing.Point(144, 143);
            this.txtDaysToNewYears.Name = "txtDaysToNewYears";
            this.txtDaysToNewYears.Size = new System.Drawing.Size(199, 20);
            this.txtDaysToNewYears.TabIndex = 12;
            // 
            // txtShortTime
            // 
            this.txtShortTime.Location = new System.Drawing.Point(144, 121);
            this.txtShortTime.Name = "txtShortTime";
            this.txtShortTime.Size = new System.Drawing.Size(199, 20);
            this.txtShortTime.TabIndex = 13;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(15, 179);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(268, 179);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(368, 216);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtShortTime);
            this.Controls.Add(this.txtDaysToNewYears);
            this.Controls.Add(this.txtLongDate);
            this.Controls.Add(this.txtShortDate);
            this.Controls.Add(this.txtGeneralDateAndTime);
            this.Controls.Add(this.txtLongTime);
            this.Controls.Add(this.txtCompleteDateAndTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "DateTime Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public frmMain()
        {
            InitializeComponent();
            UpdateTimeInfo();
        }

        public static void Main()
        {
            var main = new frmMain();
            Application.Run(main);
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            UpdateTimeInfo();
        }

        private void UpdateTimeInfo() 
        { 
            int days;   
            DateTime myTime = new DateTime(); 
            myTime = DateTime.Now; 
            DateTime newYears = new DateTime( myTime.Year, 12, 31); 
            txtCompleteDateAndTime.Text = myTime.ToString("f"); 
            txtLongDate.Text = myTime.ToString("D"); 
            txtShortDate.Text = myTime.ToString("d"); 
            txtGeneralDateAndTime.Text = myTime.ToString("g"); 
            txtLongTime.Text = myTime.ToString("T"); 
            txtShortTime.Text = myTime.ToString("t"); 
            days = newYears.DayOfYear - myTime.DayOfYear; 
            txtDaysToNewYears.Text = days.ToString(); 
        }
    }
}
