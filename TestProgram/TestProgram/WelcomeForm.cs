using System;
using System.Windows.Forms;

namespace TestProgram
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Congrats on clicking the button";
        }
    }
}
