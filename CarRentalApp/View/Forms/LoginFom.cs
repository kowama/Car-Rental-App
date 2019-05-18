using System;
using System.Drawing;
using System.Windows.Forms;
using CarRentalApp.Persistence;

namespace CarRentalApp.View.Forms
{
    public partial class LoginFom : Form
    {
        private readonly UnitOfWork _unitOfWork;

        public LoginFom()
        {
            InitializeComponent();
            _unitOfWork = UnitOfWork.Instance;
        }

        private void OnValidating(string message, bool error = true)
        {
            validationLabel.ForeColor = !error ? Color.ForestGreen : Color.Red;
            validationLabel.Text = message;
            validationLabel.Visible = true;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                OnValidating("* Username is required");
                return false;
            }

            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                OnValidating("* StoredPassword is required");
                return false;
            }

            return true;
        }

        private void FakeLogin()
        {
            Program.CurrentUser = _unitOfWork.Users.SingleOrDefault(u=>u.Username == "kowama");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!AuthUser()) return;

            var mainForm = new MainForm {Location = Location, StartPosition = FormStartPosition.Manual};
            mainForm.Show();
            Hide();
        }

        private bool AuthUser()
        {
            if (!ValidateInputs()) return false;

            var theUser = _unitOfWork.Users.SingleOrDefault(u=>u.Username == usernameTextBox.Text.Trim());

            if (theUser == null)
            {
                OnValidating("Username Not Found");
                return false;
            }

            if (theUser.Password != passwordTextBox.Text.Trim())
            {
                OnValidating("Wrong password");
                return false;
            }

            Program.CurrentUser = theUser;

            return true;
        }
    }
}