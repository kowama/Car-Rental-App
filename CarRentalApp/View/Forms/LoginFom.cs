using System;
using System.Windows.Forms;

namespace CarRentalApp.View.Forms
{
    public partial class LoginFom : Form
    {
        public LoginFom()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }
    }
}
