using System;
using System.Linq;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.Core.Utils;
using CarRentalApp.Persistence;

namespace CarRentalApp.View.UserControls
{
    public partial class UsersPageUserControl : UserControl
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly string _defaultSearchTextBoxText;

        public UsersPageUserControl()
        {
            InitializeComponent();
            _unitOfWork = UnitOfWork.Instance;
            _defaultSearchTextBoxText = searchTextBox.Text;

        }

        private void PopulateUserDataGrid()
        {
           var allUsers = _unitOfWork.Users.GetAll();
           userBindingSource.DataSource = allUsers.ToList();

        }

        private void UpdateUiChart()
        {
            var usersCount = userBindingSource.Count;
            var managersCount = userBindingSource.List
                .OfType<User>()
                .Count(u => u.HasRole(RoleName.Manager));
            var administratorCount = usersCount - managersCount;

            usersCountLabel.Text = usersCount.ToString();
            mangerUserCountLabel.Text = managersCount.ToString();
            administratorUserCountLabel.Text = administratorCount.ToString();
        }

        private void UsersPageUserControl_Load(object sender, EventArgs e)
        {
            PopulateUserDataGrid();
            UpdateUiChart();

        }

        private void UsersDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in userDataGridView.Rows)
                row.HeaderCell.Value = (row.Index + 1).ToString();

        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == _defaultSearchTextBoxText)
                searchTextBox.Text = string.Empty;
            

        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Trim() == string.Empty)
                searchTextBox.Text = _defaultSearchTextBoxText;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string keyWord = searchTextBox.Text;

            var users = _unitOfWork.Users.GetAll().ToList();
            var filteredUsers = users;

            if ( !(keyWord == string.Empty || keyWord == _defaultSearchTextBoxText))
            {
                 filteredUsers = users.FindAll(u =>
                    u.Username.Contains(keyWord, StringComparison.OrdinalIgnoreCase)
                    || u.FirstName.Contains(keyWord, StringComparison.OrdinalIgnoreCase)
                    || u.LastName.Contains(keyWord, StringComparison.OrdinalIgnoreCase)
                    || u.Cin.Contains(keyWord, StringComparison.OrdinalIgnoreCase)
                    || u.Email.Contains(keyWord, StringComparison.OrdinalIgnoreCase)
                    || u.Phone.Contains(keyWord, StringComparison.OrdinalIgnoreCase));
            }
           userBindingSource.DataSource = filteredUsers.ToList();

        }

        private void RefreshDataGrid_Click(object sender, EventArgs e)
        {
            PopulateUserDataGrid();
            UpdateUiChart();
        }

       
    }
}
