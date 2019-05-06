using System;
using System.Windows.Forms;
using CarRentalApp.Persistence;

namespace CarRentalApp.View.Forms
{
    public partial class LoginFom : Form
    {
        private readonly UnitOfWork _unitOfWork;
        public LoginFom( )
        {
            InitializeComponent();
            _unitOfWork =UnitOfWork.Instance;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Program.CurrentUser = _unitOfWork.Users.SingleOrDefault(u => u.Username == "kowama");
            var mainForm = new MainForm {Location = Location, StartPosition = FormStartPosition.Manual};
            mainForm.Show();
            Hide();
        }
    }
}
