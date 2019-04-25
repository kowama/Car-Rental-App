using System.Windows.Forms;

namespace CarRentalApp.View.UserControls
{
    public partial class UsersPageUserControl : UserControl
    {
        public UsersPageUserControl()
        {
            InitializeComponent();
        }

        private void PopulateUserDataGrid()
        {
            usersDataGrid.Rows.Clear();
        }



        /*****************************************
       /        Events handlers                 /
       ****************************************/

        private void UsersPageUserControl_Load(object sender, System.EventArgs e)
        {
        }

        private void searchButton_Click(object sender, System.EventArgs e)
        {

        }
    }
}
