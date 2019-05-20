using CarRentalApp.Core.domain;
using CarRentalApp.Core.Utils;
using CarRentalApp.Persistence;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CarRentalApp.View.UserControls.Components
{
    public partial class UserUserControl : UserControl
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly Action<User> _closeParent;
        private User _user;
        private readonly Point _firstControlLocation = new Point(25, 463);
        private FormMode _mode;
        private bool _refreshParent;
        private readonly bool _allowAdd;

        public UserUserControl(FormMode mode,Action<User> closeParent = null,  User user = null)
        {
            InitializeComponent();
            _unitOfWork = UnitOfWork.Instance;
            _user = user;
            _closeParent = closeParent;
            _mode = mode;
            _user = user ?? new User();
            _allowAdd = true;
            userPasswordTextBox.UseSystemPasswordChar = true;
            userRoleComboBox.DataSource = _unitOfWork.Roles.GetAll().Select(r => r.Name).ToList();
        }

        public UserUserControl(FormMode mode, User user) : this(mode, null, user)
        {
            _allowAdd = false;
        }

        private void OnValidating(string message, bool error = true)
        {
            validationLabel.ForeColor = !error ? Color.ForestGreen : Color.Red;
            validationLabel.Text = message;
            validationLabel.Visible = true;
        }

        private bool ValidateInputs()
        {
            if (usernameTextBox.Text.Trim().Length < 4)
            {
                OnValidating("* Username must be a least 4 chars");
                return false;
            }

            if (userPasswordTextBox.Text.Trim().Length < 6)
            {
                OnValidating("* StoredPassword must be a least 6 chars");
                return false;
            }

            if (string.IsNullOrWhiteSpace(userCinTextBox.Text))
            {
                OnValidating("* CIN is required");
                return false;
            }

            if (string.IsNullOrWhiteSpace(userFirstNameTextBox.Text))
            {
                OnValidating("* First Name is required");
                return false;
            }

            if (string.IsNullOrWhiteSpace(userFirstNameTextBox.Text))
            {
                OnValidating("* Last Name is required");
                return false;
            }

            if (!EmailUtils.IsValidEmail(userEmailTextBox.Text))
            {
                OnValidating("* Email address not valid");
                return false;
            }

            if (userPhoneTextBox.Text.Trim().Length != 15)
            {
                OnValidating("*Phone number is not valid");
                return false;
            }


            return true;
        }

        private bool ValidateInputToUser()
        {
            if (!ValidateInputs()) return false;

            _user.Username = usernameTextBox.Text;
            _user.Password = userPasswordTextBox.Text;
            _user.Roles.Clear();
            _user.Roles.Add(_unitOfWork.Roles.GetRoleByName(userRoleComboBox.Text));
            _user.FirstName = userFirstNameTextBox.Text;
            _user.LastName = userLastNameTextBox.Text;
            _user.Cin = userCinTextBox.Text;
            _user.Email = userEmailTextBox.Text;
            _user.Phone = userPhoneTextBox.Text;

            return true;
        }

        private void UpdateControlsUi(bool saveCompleted = false)
        {
            validationLabel.Visible = false;

            switch (_mode)
            {
                case FormMode.View:
                    editButton.Visible = true;
                    editButton.Location = _firstControlLocation;
                    addMoreButton.Visible = saveCompleted && _allowAdd;
                    closeButton.Visible =  _allowAdd;
                    saveButton.Visible = false;
                    cancelEditButton.Visible = false;

                    break;

                case FormMode.Edit:
                    closeButton.Visible = _allowAdd;
                    saveButton.Visible = true;
                    saveButton.Location = _firstControlLocation;
                    cancelEditButton.Visible = true;
                    editButton.Visible = false;
                    addMoreButton.Visible = false;
                    break;

                case FormMode.AddNew:
                    closeButton.Visible = _allowAdd;
                    saveButton.Visible = true;
                    saveButton.Location = _firstControlLocation;
                    cancelEditButton.Visible = false;
                    editButton.Visible = false;
                    addMoreButton.Visible = false;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            var isEnabled = _mode != FormMode.View;
            usernameTextBox.Enabled = isEnabled;
            userPasswordTextBox.Enabled = isEnabled;
            userRoleComboBox.Enabled = isEnabled && _allowAdd;
            userFirstNameTextBox.Enabled = isEnabled;
            userLastNameTextBox.Enabled = isEnabled;
            userCinTextBox.Enabled = isEnabled;
            userEmailTextBox.Enabled = isEnabled;
            userPhoneTextBox.Enabled = isEnabled;
        }

        private void UpdateUserInfoUi()
        {
            usernameTextBox.Text = _user.Username??string.Empty;
            userPasswordTextBox.Text = _user.Password??string.Empty;
            userRoleComboBox.Text = _user.HasRole(RoleName.Administrator)? 
                RoleName.Administrator : RoleName.Manager;
            userFirstNameTextBox.Text = _user.FirstName??string.Empty;
            userLastNameTextBox.Text = _user.LastName??string.Empty;
            userCinTextBox.Text = _user.Cin??string.Empty;
            userPhoneTextBox.Text = _user.Phone??string.Empty;
            userEmailTextBox.Text = _user.Email??string.Empty;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlsUi();
            if (_mode != FormMode.AddNew)
                UpdateUserInfoUi();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputToUser())
                return;
            switch (_mode)
            {
                case FormMode.AddNew:
                    try
                    {
                        _unitOfWork.Users.Add(_user);
                        _unitOfWork.Complete();
                        _refreshParent = true;
                        _mode = FormMode.View;
                        UpdateControlsUi(true);
                        OnValidating("Successfully saved !", false);

                    }
                    catch (FormattedDbEntityValidationException exception)
                    {
                        OnValidating(exception.Message);
                    }
                    break;

                case FormMode.Edit:
                    try
                    {
                        _unitOfWork.Complete();
                        _refreshParent = true;
                        _mode = FormMode.View;
                        UpdateControlsUi(true);
                        OnValidating("Successfully updated !", false);

                    }
                    catch (FormattedDbEntityValidationException exception)
                    {
                        OnValidating(exception.Message);
                    }
                    break;

                case FormMode.View:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            _mode = FormMode.Edit;
            UpdateControlsUi();

        }

        private void AddMoreButton_Click(object sender, EventArgs e)
        {
            _user = new User();
            _mode = FormMode.AddNew;
            UpdateControlsUi();
            UpdateUserInfoUi();
        }

        private void CancelEditButton_Click(object sender, EventArgs e)
        {
            _mode = FormMode.View;
            UpdateUserInfoUi();
            UpdateControlsUi();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            _closeParent?.Invoke(_refreshParent ? _user : null);
        }
        private void UserPasswordVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            userPasswordTextBox.UseSystemPasswordChar = !userPasswordVisibleCheckBox.Checked;
        }
    }
}