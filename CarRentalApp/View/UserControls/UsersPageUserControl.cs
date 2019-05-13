using System;
using System.Linq;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.Core.Utils;
using CarRentalApp.Persistence;
using CarRentalApp.Properties;
using CarRentalApp.View.Forms;

namespace CarRentalApp.View.UserControls
{
    public partial class UsersPageUserControl : UserControl
    {
        private readonly string _defaultSearchTextBoxText;
        private readonly UnitOfWork _unitOfWork;

        public UsersPageUserControl()
        {
            InitializeComponent();
            _unitOfWork = UnitOfWork.Instance;
            _defaultSearchTextBoxText = searchTextBox.Text;
        }

        private void RefreshDataGridView()
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
            RefreshDataGridView();
            UpdateUiChart();
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
            var keyWord = searchTextBox.Text;

            var users = _unitOfWork.Users.GetAll().ToList();
            var filteredUsers = users;

            if (!(keyWord == string.Empty || keyWord == _defaultSearchTextBoxText))
                filteredUsers = users.FindAll(u =>
                    u.Username.Contains(keyWord, StringComparison.OrdinalIgnoreCase)
                    || u.FirstName.Contains(keyWord, StringComparison.OrdinalIgnoreCase)
                    || u.LastName.Contains(keyWord, StringComparison.OrdinalIgnoreCase)
                    || u.Cin.Contains(keyWord, StringComparison.OrdinalIgnoreCase)
                    || u.Email.Contains(keyWord, StringComparison.OrdinalIgnoreCase)
                    || u.Phone.Contains(keyWord, StringComparison.OrdinalIgnoreCase));
            userBindingSource.DataSource = filteredUsers.ToList();
        }

        private void RefreshDataGrid_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
            UpdateUiChart();
        }

        private void OnUserFormClosed(User theUser)
        {
            if (theUser == null) return;

            RefreshDataGridView();
            foreach (DataGridViewRow row in userDataGridView.Rows)
            {
                var user = (User) row.DataBoundItem;
                if (user == null) continue;
                if (theUser.Id != user.Id) continue;

                row.Selected = true;
                return;
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            var userForm = new UserForm(FormMode.AddNew, OnUserFormClosed);
            userForm.Show();
        }

        private void UserDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (userDataGridView.Rows[e.RowIndex].DataBoundItem == null)
                return;

            //display row index
            var row = userDataGridView.Rows[e.RowIndex];
            row.HeaderCell.Value = $"{row.Index + 1}";

            var user = (User)userDataGridView.Rows[e.RowIndex].DataBoundItem;

            if (user == null) return;

            if (userDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(user.Roles)))
                e.Value = user.Roles.First().Name;



        }

        private void UserDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var user = (User) userDataGridView.Rows[e.RowIndex].DataBoundItem;

            if (user == null) return;

            var userForm = new UserForm(FormMode.View, OnUserFormClosed, user);

            userForm.Show();
        }

        private void UserDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var user = (User) e.Row.DataBoundItem;
            var count = user.Rents.Count;

            if (count > 0)
            {
                MessageBox.Show(
                    string.Format(Resources.User_0_has_managed_1_rents_2_Delete_Them_First,
                        user.Username + "," + user.FullName, count, Environment.NewLine),
                    Resources.Unauthorized_delete_action
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }

            var dialogResult = MessageBox.Show(
                string.Format(Resources.User_0_1_2__Will_be_deleted, user.Username, user.FullName, Environment.NewLine),
                Resources.Are_you_Sure_to_Delete, MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dialogResult != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }

            _unitOfWork.Users.Remove(user);
            _unitOfWork.Complete();
        }

        private void UserDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            RefreshDataGridView();
        }
    }
}