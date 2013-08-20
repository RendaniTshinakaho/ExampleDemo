using System;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Text = "Password Generator";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerator_Click(object sender, EventArgs e)
        {
            txtPasswordGenerator.Text = Guid.NewGuid().ToString();
        }
    }
}
