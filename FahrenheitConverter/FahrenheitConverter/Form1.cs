using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private Label labelFahrenheit;
    private TextBox textFahrenheit;
    private Button btnConvert;
    private Button btnExit;
    private TextBox textResult;

    private const int fahrenheitOffSet = 32;
    private const double celciusDegree = 9.0;
    private const double fahrenheitDegree = 5.0;

    public frmMain()
    {
        InitializeComponent();
    }

    public static void Main()
    {
        var main = new frmMain();
        Application.Run(main);
    }

    private void InitializeComponent()
    {
            this.labelFahrenheit = new System.Windows.Forms.Label();
            this.textFahrenheit = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFahrenheit
            // 
            this.labelFahrenheit.AutoSize = true;
            this.labelFahrenheit.Location = new System.Drawing.Point(13, 13);
            this.labelFahrenheit.Name = "labelFahrenheit";
            this.labelFahrenheit.Size = new System.Drawing.Size(119, 13);
            this.labelFahrenheit.TabIndex = 0;
            this.labelFahrenheit.Text = "Fahrenheit temperature:";
            // 
            // textFahrenheit
            // 
            this.textFahrenheit.Location = new System.Drawing.Point(139, 5);
            this.textFahrenheit.Name = "textFahrenheit";
            this.textFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.textFahrenheit.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(101, 42);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(78, 81);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(120, 20);
            this.textResult.TabIndex = 3;
            this.textResult.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(101, 122);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(284, 157);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.textFahrenheit);
            this.Controls.Add(this.labelFahrenheit);
            this.Name = "frmMain";
            this.Text = "Fahrenheit To Celsius Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void btnConvert_Click(object sender, EventArgs e)
    {
        double fahrenheitTemp;

        var flag = double.TryParse(textFahrenheit.Text, out fahrenheitTemp);
        if (!flag)
        {
            MessageBox.Show("Please enter a number", "Input Error");
            textFahrenheit.Focus();
            return;
        }

        var answer = fahrenheitDegree/celciusDegree * (fahrenheitTemp - fahrenheitOffSet);
        textResult.Text = Math.Round(answer, 1) + " degrees celsius";
        textResult.Visible = true;

    }

    private void btnExit_Click(object sender, System.EventArgs e)
    {
        Close();
    }
}