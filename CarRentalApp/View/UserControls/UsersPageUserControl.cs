using System.Linq;
using System.Windows.Forms;
using CarRentalApp.Persistence;

namespace CarRentalApp.View.UserControls
{
    public partial class UsersPageUserControl : UserControl
    {
        private UnitOfWork _unitOfWork;
        public UsersPageUserControl()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
        }

        private void PopulateUserDataGrid()
        {
           var allUsers = _unitOfWork.Users.GetAll();
            usersDataGrid.DataSource = allUsers.ToList();

        }



        /*****************************************
       /        Events handlers                 /
       ****************************************/

        private void UsersPageUserControl_Load(object sender, System.EventArgs e)
        {
            PopulateUserDataGrid();
        }

        private void searchButton_Click(object sender, System.EventArgs e)
        {

        }

        private void refreshDataGrid_Click(object sender, System.EventArgs e)
        {
            PopulateUserDataGrid();
        }
    }
}
