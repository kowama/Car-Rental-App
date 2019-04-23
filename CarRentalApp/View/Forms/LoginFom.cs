namespace CarRentalApp.View.Forms
{
    public partial class LoginFom : System.Windows.Forms.Form
    {
        public LoginFom()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }
    }
}
