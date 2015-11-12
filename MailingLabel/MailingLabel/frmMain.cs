using System;
using System.Windows.Forms;
public class frmMain : Form
{
    private Label address;
    private Label city;
    private Label state;
    private Label zip;
    private TextBox txtName;
    private TextBox txtAddress;
    private TextBox txtCity;
    private TextBox txtState;
    private TextBox txtZip;
    private TextBox txtDisplayOutput;
    private Button btnDisplay;
    private Button btnExit;
    private Label name;
    #region Windows code

    private void InitializeComponent()
    {
        this.name = new Label();
        this.address = new Label();
        this.city = new Label();
        this.state = new Label();
        this.zip = new Label();
        this.txtName = new TextBox();
        this.txtAddress = new TextBox();
        this.txtCity = new TextBox();
        this.txtState = new TextBox();
        this.txtZip = new TextBox();
        this.txtDisplayOutput = new TextBox();
        this.btnDisplay = new Button();
        this.btnExit = new Button();
        this.SuspendLayout();
        // 
        // name
        // 
        this.name.BorderStyle = BorderStyle.Fixed3D;
        this.name.Location = new System.Drawing.Point(32, 36);
        this.name.Name = "name";
        this.name.Size = new System.Drawing.Size(75, 20);
        this.name.TabIndex = 0;
        this.name.Text = "Name:";
        // 
        // address
        // 
        this.address.BorderStyle = BorderStyle.Fixed3D;
        this.address.Location = new System.Drawing.Point(32, 88);
        this.address.Name = "address";
        this.address.Size = new System.Drawing.Size(72, 20);
        this.address.TabIndex = 1;
        this.address.Text = "Address:";
        // 
        // city
        // 
        this.city.BorderStyle = BorderStyle.Fixed3D;
        this.city.Location = new System.Drawing.Point(32, 139);
        this.city.Name = "city";
        this.city.Size = new System.Drawing.Size(75, 20);
        this.city.TabIndex = 2;
        this.city.Text = "City:";
        // 
        // state
        // 
        this.state.BorderStyle = BorderStyle.Fixed3D;
        this.state.Location = new System.Drawing.Point(226, 139);
        this.state.Name = "state";
        this.state.Size = new System.Drawing.Size(75, 20);
        this.state.TabIndex = 3;
        this.state.Text = "State:";
        // 
        // zip
        // 
        this.zip.BorderStyle = BorderStyle.Fixed3D;
        this.zip.Location = new System.Drawing.Point(414, 139);
        this.zip.Name = "zip";
        this.zip.Size = new System.Drawing.Size(75, 20);
        this.zip.TabIndex = 4;
        this.zip.Text = "Zip:";
        // 
        // txtName
        // 
        this.txtName.Location = new System.Drawing.Point(114, 36);
        this.txtName.Name = "txtName";
        this.txtName.Size = new System.Drawing.Size(100, 20);
        this.txtName.TabIndex = 5;
        // 
        // txtAddress
        // 
        this.txtAddress.Location = new System.Drawing.Point(114, 87);
        this.txtAddress.Name = "txtAddress";
        this.txtAddress.Size = new System.Drawing.Size(100, 20);
        this.txtAddress.TabIndex = 6;
        // 
        // txtCity
        // 
        this.txtCity.Location = new System.Drawing.Point(114, 139);
        this.txtCity.Name = "txtCity";
        this.txtCity.Size = new System.Drawing.Size(100, 20);
        this.txtCity.TabIndex = 7;
        // 
        // txtState
        // 
        this.txtState.Location = new System.Drawing.Point(308, 138);
        this.txtState.Name = "txtState";
        this.txtState.Size = new System.Drawing.Size(100, 20);
        this.txtState.TabIndex = 8;
        // 
        // txtZip
        // 
        this.txtZip.Location = new System.Drawing.Point(496, 138);
        this.txtZip.Name = "txtZip";
        this.txtZip.Size = new System.Drawing.Size(100, 20);
        this.txtZip.TabIndex = 9;
        // 
        // txtDisplayOutput
        // 
        this.txtDisplayOutput.Location = new System.Drawing.Point(32, 215);
        this.txtDisplayOutput.Multiline = true;
        this.txtDisplayOutput.Name = "txtDisplayOutput";
        this.txtDisplayOutput.ReadOnly = true;
        this.txtDisplayOutput.Size = new System.Drawing.Size(564, 132);
        this.txtDisplayOutput.TabIndex = 10;
        // 
        // btnDisplay
        // 
        this.btnDisplay.Location = new System.Drawing.Point(32, 180);
        this.btnDisplay.Name = "btnDisplay";
        this.btnDisplay.Size = new System.Drawing.Size(75, 23);
        this.btnDisplay.TabIndex = 11;
        this.btnDisplay.Text = "&Display";
        this.btnDisplay.UseVisualStyleBackColor = true;
        this.btnDisplay.Click += this.btnDisplay_Click;
        // 
        // btnExit
        // 
        this.btnExit.Location = new System.Drawing.Point(520, 179);
        this.btnExit.Name = "btnExit";
        this.btnExit.Size = new System.Drawing.Size(75, 23);
        this.btnExit.TabIndex = 12;
        this.btnExit.Text = "E&xit";
        this.btnExit.UseVisualStyleBackColor = true;
        // 
        // frmMain
        // 
        this.ClientSize = new System.Drawing.Size(637, 385);
        this.Controls.Add(this.btnExit);
        this.Controls.Add(this.btnDisplay);
        this.Controls.Add(this.txtDisplayOutput);
        this.Controls.Add(this.txtZip);
        this.Controls.Add(this.txtState);
        this.Controls.Add(this.txtCity);
        this.Controls.Add(this.txtAddress);
        this.Controls.Add(this.txtName);
        this.Controls.Add(this.zip);
        this.Controls.Add(this.state);
        this.Controls.Add(this.city);
        this.Controls.Add(this.address);
        this.Controls.Add(this.name);
        this.Name = "frmMain";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Mailing Label Program";
        this.ResumeLayout(false);
        this.PerformLayout();

    }
    #endregion

    public frmMain()
    {
        InitializeComponent();
    }

    public static void Main()
    {
        var main = new frmMain();
        Application.Run(main);
    }

    private void btnDisplay_Click(object sender, System.EventArgs e)
    {
        string buffer = "Mailing Label:" + Environment.NewLine + Environment.NewLine;
        buffer = buffer + "Name: " + txtName.Text + Environment.NewLine;
        buffer = buffer + "Address: " + txtAddress.Text + Environment.NewLine;
        buffer = buffer + "City: " + txtCity.Text + " State: " + txtState.Text + " Zip:" + txtZip.Text;

        txtDisplayOutput.Text = buffer;
    }
}