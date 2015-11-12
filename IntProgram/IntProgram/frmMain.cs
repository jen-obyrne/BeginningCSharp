using System.Windows.Forms;

public class frmMain : Form
{
    private Label labelSecondProperty;
    private TextBox textOperand1;
    private TextBox textOperand2;
    private TextBox textResult;
    private Button calculate;
    private Button Exit;
    private Label labelFirstProperty;

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
            this.labelFirstProperty = new System.Windows.Forms.Label();
            this.labelSecondProperty = new System.Windows.Forms.Label();
            this.textOperand1 = new System.Windows.Forms.TextBox();
            this.textOperand2 = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFirstProperty
            // 
            this.labelFirstProperty.AutoSize = true;
            this.labelFirstProperty.Location = new System.Drawing.Point(13, 13);
            this.labelFirstProperty.Name = "labelFirstProperty";
            this.labelFirstProperty.Size = new System.Drawing.Size(118, 13);
            this.labelFirstProperty.TabIndex = 0;
            this.labelFirstProperty.Text = "Enter first integer value:";
            // 
            // labelSecondProperty
            // 
            this.labelSecondProperty.AutoSize = true;
            this.labelSecondProperty.Location = new System.Drawing.Point(13, 43);
            this.labelSecondProperty.Name = "labelSecondProperty";
            this.labelSecondProperty.Size = new System.Drawing.Size(137, 13);
            this.labelSecondProperty.TabIndex = 1;
            this.labelSecondProperty.Text = "Enter second integer value:";
            // 
            // textOperand1
            // 
            this.textOperand1.Location = new System.Drawing.Point(166, 13);
            this.textOperand1.Name = "textOperand1";
            this.textOperand1.Size = new System.Drawing.Size(100, 20);
            this.textOperand1.TabIndex = 2;
            // 
            // textOperand2
            // 
            this.textOperand2.Location = new System.Drawing.Point(166, 43);
            this.textOperand2.Name = "textOperand2";
            this.textOperand2.Size = new System.Drawing.Size(100, 20);
            this.textOperand2.TabIndex = 3;
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(16, 80);
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.Size = new System.Drawing.Size(300, 20);
            this.textResult.TabIndex = 4;
            this.textResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textResult.Visible = false;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(16, 118);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 5;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(121, 118);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "E&xit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(348, 262);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textOperand2);
            this.Controls.Add(this.textOperand1);
            this.Controls.Add(this.labelSecondProperty);
            this.Controls.Add(this.labelFirstProperty);
            this.Name = "frmMain";
            this.Text = "Integer Division";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void calculate_Click(object sender, System.EventArgs e)
    {
        bool flag;
        double operand1;
        double operand2;

        const string errorMessage = "Enter a whole number";
        const string errorType = "Input Error";

        flag = double.TryParse(textOperand1.Text, out operand1);
        if (!flag)
        {
            MessageBox.Show(errorMessage, errorType);
            textOperand1.Focus();
            return;
        }

        flag = double.TryParse(textOperand2.Text, out operand2);
        if (!flag)
        {
            MessageBox.Show(errorMessage, errorType);
            textOperand2.Focus();
            return;
        }

        double answer = operand1 * operand2;
        textResult.Text = operand1 + " times " + operand2 + " equals " + answer;
        textResult.Visible = true;
    }

    private void Exit_Click(object sender, System.EventArgs e)
    {
        Close();
    }
}