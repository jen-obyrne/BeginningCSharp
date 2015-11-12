using System.Windows.Forms;

public class frmMain : Form
{
    private Label stringLengthLabel;
    private Label lblToUpper;
    private Label lblToLower;
    private Label lblSearchChar;
    private Label lastCharLabel;
    private Label extractSubstringLabel;
    private Label lblIndexOf;
    private Label lblLastIndexOf;
    private Label txtInputRemoveLabel;
    private Label findLabel;
    private Label lblReplace;
    private Label txtInputReplacelabel;
    private Button testButton;
    private Button closeButton;
    private TextBox txtInput;
    private TextBox txtLength;
    private TextBox txtStartIndex;
    private TextBox txtLastChar;
    private TextBox txtSearchChar;
    private TextBox txtToLower;
    private TextBox txtToUpper;
    private TextBox txtRemove;
    private TextBox txtReplaceChars;
    private TextBox txtReplaceResult;
    private TextBox txtSearchIndex;
    private TextBox txtLastIndexOf;
    private TextBox txtRemoveResult;
    private Label lblSubstring;
    private TextBox txtSubstringResult;
    private TextBox txtReplaceWith;
    private Label lblEndIndex;
    private TextBox txtEndIndex;
    private Label stringTestLabel;

    private void InitializeComponent()
    {
            this.stringTestLabel = new System.Windows.Forms.Label();
            this.stringLengthLabel = new System.Windows.Forms.Label();
            this.lblToUpper = new System.Windows.Forms.Label();
            this.lblToLower = new System.Windows.Forms.Label();
            this.lblSearchChar = new System.Windows.Forms.Label();
            this.lastCharLabel = new System.Windows.Forms.Label();
            this.extractSubstringLabel = new System.Windows.Forms.Label();
            this.lblIndexOf = new System.Windows.Forms.Label();
            this.lblLastIndexOf = new System.Windows.Forms.Label();
            this.txtInputRemoveLabel = new System.Windows.Forms.Label();
            this.findLabel = new System.Windows.Forms.Label();
            this.lblReplace = new System.Windows.Forms.Label();
            this.txtInputReplacelabel = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtStartIndex = new System.Windows.Forms.TextBox();
            this.txtLastChar = new System.Windows.Forms.TextBox();
            this.txtSearchChar = new System.Windows.Forms.TextBox();
            this.txtToLower = new System.Windows.Forms.TextBox();
            this.txtToUpper = new System.Windows.Forms.TextBox();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.txtReplaceChars = new System.Windows.Forms.TextBox();
            this.txtReplaceResult = new System.Windows.Forms.TextBox();
            this.txtSearchIndex = new System.Windows.Forms.TextBox();
            this.txtLastIndexOf = new System.Windows.Forms.TextBox();
            this.txtRemoveResult = new System.Windows.Forms.TextBox();
            this.lblSubstring = new System.Windows.Forms.Label();
            this.txtSubstringResult = new System.Windows.Forms.TextBox();
            this.txtReplaceWith = new System.Windows.Forms.TextBox();
            this.lblEndIndex = new System.Windows.Forms.Label();
            this.txtEndIndex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // stringTestLabel
            // 
            this.stringTestLabel.AutoSize = true;
            this.stringTestLabel.Location = new System.Drawing.Point(13, 13);
            this.stringTestLabel.Name = "stringTestLabel";
            this.stringTestLabel.Size = new System.Drawing.Size(73, 13);
            this.stringTestLabel.TabIndex = 0;
            this.stringTestLabel.Text = "String to Test:";
            // 
            // stringLengthLabel
            // 
            this.stringLengthLabel.AutoSize = true;
            this.stringLengthLabel.Location = new System.Drawing.Point(13, 40);
            this.stringLengthLabel.Name = "stringLengthLabel";
            this.stringLengthLabel.Size = new System.Drawing.Size(73, 13);
            this.stringLengthLabel.TabIndex = 1;
            this.stringLengthLabel.Text = "String Length:";
            // 
            // lblToUpper
            // 
            this.lblToUpper.AutoSize = true;
            this.lblToUpper.Location = new System.Drawing.Point(13, 65);
            this.lblToUpper.Name = "lblToUpper";
            this.lblToUpper.Size = new System.Drawing.Size(85, 13);
            this.lblToUpper.TabIndex = 2;
            this.lblToUpper.Text = "String.ToUpper()";
            // 
            // lblToLower
            // 
            this.lblToLower.AutoSize = true;
            this.lblToLower.Location = new System.Drawing.Point(13, 91);
            this.lblToLower.Name = "lblToLower";
            this.lblToLower.Size = new System.Drawing.Size(85, 13);
            this.lblToLower.TabIndex = 3;
            this.lblToLower.Text = "String.ToLower()";
            // 
            // lblSearchChar
            // 
            this.lblSearchChar.AutoSize = true;
            this.lblSearchChar.Location = new System.Drawing.Point(13, 117);
            this.lblSearchChar.Name = "lblSearchChar";
            this.lblSearchChar.Size = new System.Drawing.Size(104, 13);
            this.lblSearchChar.TabIndex = 4;
            this.lblSearchChar.Text = "Search for character";
            // 
            // lastCharLabel
            // 
            this.lastCharLabel.AutoSize = true;
            this.lastCharLabel.Location = new System.Drawing.Point(13, 141);
            this.lastCharLabel.Name = "lastCharLabel";
            this.lastCharLabel.Size = new System.Drawing.Size(123, 13);
            this.lastCharLabel.TabIndex = 5;
            this.lastCharLabel.Text = "Search for last character";
            // 
            // extractSubstringLabel
            // 
            this.extractSubstringLabel.AutoSize = true;
            this.extractSubstringLabel.Location = new System.Drawing.Point(12, 165);
            this.extractSubstringLabel.Name = "extractSubstringLabel";
            this.extractSubstringLabel.Size = new System.Drawing.Size(137, 13);
            this.extractSubstringLabel.TabIndex = 6;
            this.extractSubstringLabel.Text = "Extract substring from Index";
            // 
            // lblIndexOf
            // 
            this.lblIndexOf.AutoSize = true;
            this.lblIndexOf.Location = new System.Drawing.Point(431, 120);
            this.lblIndexOf.Name = "lblIndexOf";
            this.lblIndexOf.Size = new System.Drawing.Size(154, 13);
            this.lblIndexOf.TabIndex = 7;
            this.lblIndexOf.Text = "btnInput.Text.IndexOf(\"V\", 0) =";
            // 
            // lblLastIndexOf
            // 
            this.lblLastIndexOf.AutoSize = true;
            this.lblLastIndexOf.Location = new System.Drawing.Point(431, 143);
            this.lblLastIndexOf.Name = "lblLastIndexOf";
            this.lblLastIndexOf.Size = new System.Drawing.Size(160, 13);
            this.lblLastIndexOf.TabIndex = 8;
            this.lblLastIndexOf.Text = "btnInput.Text.LastIndexOf(\"s\") =";
            // 
            // txtInputRemoveLabel
            // 
            this.txtInputRemoveLabel.AutoSize = true;
            this.txtInputRemoveLabel.Location = new System.Drawing.Point(13, 188);
            this.txtInputRemoveLabel.Name = "txtInputRemoveLabel";
            this.txtInputRemoveLabel.Size = new System.Drawing.Size(99, 13);
            this.txtInputRemoveLabel.TabIndex = 9;
            this.txtInputRemoveLabel.Text = "txtinput.Remove() =";
            // 
            // findLabel
            // 
            this.findLabel.AutoSize = true;
            this.findLabel.Location = new System.Drawing.Point(13, 211);
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(30, 13);
            this.findLabel.TabIndex = 10;
            this.findLabel.Text = "Find:";
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(267, 214);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(72, 13);
            this.lblReplace.TabIndex = 11;
            this.lblReplace.Text = "Replace with:";
            // 
            // txtInputReplacelabel
            // 
            this.txtInputReplacelabel.AutoSize = true;
            this.txtInputReplacelabel.Location = new System.Drawing.Point(16, 237);
            this.txtInputReplacelabel.Name = "txtInputReplacelabel";
            this.txtInputReplacelabel.Size = new System.Drawing.Size(99, 13);
            this.txtInputReplacelabel.TabIndex = 12;
            this.txtInputReplacelabel.Text = "txtinput.Replace() =";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(120, 286);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 13;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(251, 286);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 14;
            this.closeButton.Text = "Close&";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(164, 6);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(460, 20);
            this.txtInput.TabIndex = 15;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(164, 33);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 16;
            // 
            // txtStartIndex
            // 
            this.txtStartIndex.Location = new System.Drawing.Point(164, 162);
            this.txtStartIndex.Name = "txtStartIndex";
            this.txtStartIndex.Size = new System.Drawing.Size(100, 20);
            this.txtStartIndex.TabIndex = 17;
            // 
            // txtLastChar
            // 
            this.txtLastChar.Location = new System.Drawing.Point(164, 136);
            this.txtLastChar.Name = "txtLastChar";
            this.txtLastChar.Size = new System.Drawing.Size(100, 20);
            this.txtLastChar.TabIndex = 18;
            // 
            // txtSearchChar
            // 
            this.txtSearchChar.Location = new System.Drawing.Point(164, 110);
            this.txtSearchChar.Name = "txtSearchChar";
            this.txtSearchChar.Size = new System.Drawing.Size(100, 20);
            this.txtSearchChar.TabIndex = 19;
            // 
            // txtToLower
            // 
            this.txtToLower.Location = new System.Drawing.Point(164, 84);
            this.txtToLower.Name = "txtToLower";
            this.txtToLower.Size = new System.Drawing.Size(460, 20);
            this.txtToLower.TabIndex = 20;
            // 
            // txtToUpper
            // 
            this.txtToUpper.Location = new System.Drawing.Point(164, 58);
            this.txtToUpper.Name = "txtToUpper";
            this.txtToUpper.Size = new System.Drawing.Size(460, 20);
            this.txtToUpper.TabIndex = 21;
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(164, 185);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(100, 20);
            this.txtRemove.TabIndex = 22;
            // 
            // txtReplaceChars
            // 
            this.txtReplaceChars.Location = new System.Drawing.Point(164, 211);
            this.txtReplaceChars.Name = "txtReplaceChars";
            this.txtReplaceChars.Size = new System.Drawing.Size(100, 20);
            this.txtReplaceChars.TabIndex = 23;
            // 
            // txtReplaceResult
            // 
            this.txtReplaceResult.Location = new System.Drawing.Point(164, 237);
            this.txtReplaceResult.Name = "txtReplaceResult";
            this.txtReplaceResult.Size = new System.Drawing.Size(460, 20);
            this.txtReplaceResult.TabIndex = 24;
            // 
            // txtSearchIndex
            // 
            this.txtSearchIndex.Location = new System.Drawing.Point(591, 117);
            this.txtSearchIndex.Name = "txtSearchIndex";
            this.txtSearchIndex.Size = new System.Drawing.Size(127, 20);
            this.txtSearchIndex.TabIndex = 25;
            // 
            // txtLastIndexOf
            // 
            this.txtLastIndexOf.Location = new System.Drawing.Point(591, 140);
            this.txtLastIndexOf.Name = "txtLastIndexOf";
            this.txtLastIndexOf.Size = new System.Drawing.Size(127, 20);
            this.txtLastIndexOf.TabIndex = 26;
            // 
            // txtRemoveResult
            // 
            this.txtRemoveResult.Location = new System.Drawing.Point(270, 185);
            this.txtRemoveResult.Name = "txtRemoveResult";
            this.txtRemoveResult.Size = new System.Drawing.Size(354, 20);
            this.txtRemoveResult.TabIndex = 27;
            // 
            // lblSubstring
            // 
            this.lblSubstring.AutoSize = true;
            this.lblSubstring.Location = new System.Drawing.Point(431, 165);
            this.lblSubstring.Name = "lblSubstring";
            this.lblSubstring.Size = new System.Drawing.Size(156, 13);
            this.lblSubstring.TabIndex = 28;
            this.lblSubstring.Text = "btnInput.Text.Substring(18, 7) =";
            // 
            // txtSubstringResult
            // 
            this.txtSubstringResult.Location = new System.Drawing.Point(591, 162);
            this.txtSubstringResult.Name = "txtSubstringResult";
            this.txtSubstringResult.Size = new System.Drawing.Size(125, 20);
            this.txtSubstringResult.TabIndex = 29;
            // 
            // txtReplaceWith
            // 
            this.txtReplaceWith.Location = new System.Drawing.Point(348, 211);
            this.txtReplaceWith.Name = "txtReplaceWith";
            this.txtReplaceWith.Size = new System.Drawing.Size(276, 20);
            this.txtReplaceWith.TabIndex = 30;
            // 
            // lblEndIndex
            // 
            this.lblEndIndex.AutoSize = true;
            this.lblEndIndex.Location = new System.Drawing.Point(271, 165);
            this.lblEndIndex.Name = "lblEndIndex";
            this.lblEndIndex.Size = new System.Drawing.Size(119, 13);
            this.lblEndIndex.TabIndex = 31;
            this.lblEndIndex.Text = "for this many characters";
            // 
            // txtEndIndex
            // 
            this.txtEndIndex.Location = new System.Drawing.Point(397, 162);
            this.txtEndIndex.Name = "txtEndIndex";
            this.txtEndIndex.Size = new System.Drawing.Size(28, 20);
            this.txtEndIndex.TabIndex = 32;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(811, 378);
            this.Controls.Add(this.txtEndIndex);
            this.Controls.Add(this.lblEndIndex);
            this.Controls.Add(this.txtReplaceWith);
            this.Controls.Add(this.txtSubstringResult);
            this.Controls.Add(this.lblSubstring);
            this.Controls.Add(this.txtRemoveResult);
            this.Controls.Add(this.txtLastIndexOf);
            this.Controls.Add(this.txtSearchIndex);
            this.Controls.Add(this.txtReplaceResult);
            this.Controls.Add(this.txtReplaceChars);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.txtToUpper);
            this.Controls.Add(this.txtToLower);
            this.Controls.Add(this.txtSearchChar);
            this.Controls.Add(this.txtLastChar);
            this.Controls.Add(this.txtStartIndex);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.txtInputReplacelabel);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.findLabel);
            this.Controls.Add(this.txtInputRemoveLabel);
            this.Controls.Add(this.lblLastIndexOf);
            this.Controls.Add(this.lblIndexOf);
            this.Controls.Add(this.extractSubstringLabel);
            this.Controls.Add(this.lastCharLabel);
            this.Controls.Add(this.lblSearchChar);
            this.Controls.Add(this.lblToLower);
            this.Controls.Add(this.lblToUpper);
            this.Controls.Add(this.stringLengthLabel);
            this.Controls.Add(this.stringTestLabel);
            this.Name = "frmMain";
            this.Text = "String Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    public frmMain()
    {
        InitializeComponent();
    }

    public static void Main()
    {
        var main = new frmMain();
        Application.Run(main);
    }

    private void closeButton_Click(object sender, System.EventArgs e)
    {
        Close();
    }

    private void testButton_Click(object sender, System.EventArgs e)
    {
        int start;
        int howMany;

        lblIndexOf.Text = "";

        // Find length 
        txtLength.Text = txtInput.Text.Length.ToString(); 
        
        // Change cases 
        txtToUpper.Text = txtInput.Text.ToUpper(); 
        txtToLower.Text = txtInput.Text.ToLower();

        //index of
        var index = txtInput.Text.IndexOf(txtSearchChar.Text, 0); 
        lblIndexOf.Text = "txtInput.Text.IndexOf(\"" + txtSearchChar.Text + "\", 0) = ";
        txtSearchIndex.Text = index.ToString(); 
        
        // LastIndexOf 
        index = txtInput.Text.LastIndexOf(txtLastChar.Text); 
        lblLastIndexOf.Text = "txtInput.Text.LastIndexOf(\"" + txtLastChar.Text + "\") = ";
        txtLastIndexOf.Text = index.ToString();

        //substring
        var flag = int.TryParse( txtStartIndex.Text, out start); 
        if (flag == false)
        {
            MessageBox.Show("Improper numeric input. Re-enter."); txtStartIndex.Focus(); return;
        }
        flag = int.TryParse( txtEndIndex.Text, out howMany);
        if (flag == false)
        {
            MessageBox.Show("Improper numeric input. Re-enter."); 
            txtEndIndex.Focus(); 
            return;
        } 
        
        lblSubstring.Text = "txtInput.Text.Substring(" + start.ToString() + ", " + howMany.ToString() + ") = ";
        txtSubstringResult.Text = txtInput.Text.Substring( start, howMany); 
        
        // Remove 
        var temp = txtInput.Text; 
        index = temp.IndexOf(txtRemove.Text);
        if (index > 0)
        {
            txtRemoveResult.Text = temp.Remove(index, txtRemove.Text.Length);
        } 
        
        // Replace 
        temp = txtInput.Text;
        if (txtReplaceChars.Text == "")
        {
            MessageBox.Show("Please enter a string");
            txtReplaceChars.Focus();
            return;
        }

        if (txtReplaceWith.Text == "")
        {
            MessageBox.Show("Please enter a string");
            txtReplaceWith.Focus();
            return;
        }
        txtReplaceResult.Text = temp.Replace(txtReplaceChars.Text, txtReplaceWith.Text);

    }
}