using System.Windows.Forms;

public class frmMain : Form
{
    private Label labelNumber;
    private TextBox textValue;
    private Button btnCalculate;
    private TextBox textResult;
    private Button btnExit;

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
            this.labelNumber = new System.Windows.Forms.Label();
            this.textValue = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(13, 13);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(82, 13);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Enter a number:";
            // 
            // textValue
            // 
            this.textValue.Location = new System.Drawing.Point(102, 13);
            this.textValue.Name = "textValue";
            this.textValue.Size = new System.Drawing.Size(170, 20);
            this.textValue.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(102, 48);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(16, 91);
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.Size = new System.Drawing.Size(256, 20);
            this.textResult.TabIndex = 3;
            this.textResult.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(102, 126);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(284, 164);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.textValue);
            this.Controls.Add(this.labelNumber);
            this.Name = "frmMain";
            this.Text = "Odd or Even";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void btnExit_Click(object sender, System.EventArgs e)
    {
        Close();
    }

    private void btnCalculate_Click(object sender, System.EventArgs e)
    {
        int value;

        var flag = int.TryParse(textValue.Text, out value);
        if (!flag)
        {
            MessageBox.Show("Please enter a whole number", "Input error");
            textValue.Focus();
            return;
        }

        if (IsOdd(value))
        {
            textResult.Text = value + " is an odd number";
            textResult.Visible = true;
        }
        else
        {
            textResult.Text = value + " is an even number";
            textResult.Visible = true;
        }

    }

    public bool IsOdd(int value)
    {
        return value % 2 == 1;
    }
}