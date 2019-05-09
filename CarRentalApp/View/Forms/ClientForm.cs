using System;
using System.Drawing;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.Core.Utils;
using CarRentalApp.Persistence;

namespace CarRentalApp.View.Forms
{
    public partial class ClientForm : Form
    {
        private const int AddModeWidth = 484;
        private readonly UnitOfWork _unitOfWork;
        private readonly Client _client;
        private  FormMode _mode;
        private readonly Action<Client> _onCloseCallBack;
        private bool _saved;

        public ClientForm(FormMode mode, Action<Client> onCloseCallBack =null, Client client = null)
        {
            InitializeComponent();
            _unitOfWork = UnitOfWork.Instance;
            _mode = mode;
            _onCloseCallBack = onCloseCallBack;
            _client = client ?? new Client();
            if (_mode == FormMode.AddNew)
                Width = AddModeWidth;

        }

        private void OnValidating(string message, bool error = true)
        {
//            validationLabel.ForeColor = !error ? Color.ForestGreen : Color.Red;
//            validationLabel.Text = message;
//            validationLabel.Visible = true;
//            validationLabel.Visible = true;
//
//            firstNameTextBox.Enabled = !error;
//            lastNameTextBox.Enabled = !error;
//            cinTextBox.Enabled = !error;
//            emailTextBox.Enabled = !error;
//            addressTextBox.Enabled = !error;
//            phoneTextBox.Enabled = !error;
        }

        private bool ValidateInputs()
        {
//            if (string.IsNullOrEmpty(firstNameTextBox.Text))
//            {
//                OnValidating("* First name is required");
//                return false;
//            }
//
//            if (string.IsNullOrEmpty(lastNameTextBox.Text))
//            {
//                OnValidating("* First name is required");
//                return false;
//            }
//
//            if (string.IsNullOrEmpty(cinTextBox.Text)
//            )
//            {
//                OnValidating("* First name is required");
//                return false;
//            }
//
//            if (string.IsNullOrEmpty(driverLicenseTextBox.Text))
//            {
//                OnValidating("* First name is required");
//                return false;
//            }
//
//            if (string.IsNullOrEmpty(emailTextBox.Text))
//            {
//                OnValidating("* First name is required");
//                return false;
//            }
//
//            if (string.IsNullOrEmpty(addressTextBox.Text)
//            )
//            {
//                OnValidating("* First name is required");
//                return false;
//            }
//
            return true;
        }

        private bool ValidInputsToClient()
        {
//            if (!ValidateInputs()) return false;
//
//            _client.FirstName = firstNameTextBox.Text.Trim();
//            _client.LastName = lastNameTextBox.Text.Trim();
//            _client.Cin = cinTextBox.Text.Trim();
//            _client.Email = emailTextBox.Text.Trim();
//            _client.Phone = phoneTextBox.Text.Trim();
//            _client.DriverLicense = driverLicenseTextBox.Text.Trim();
//            _client.Address = addressTextBox.Text.Trim();
            return true;
        }

        private void UpdateUi()
        {
//            firstNameTextBox.Text = _client.FirstName;
//            lastNameTextBox.Text = _client.LastName;
//            cinTextBox.Text = _client.Cin;
//            driverLicenseTextBox.Text = _client.DriverLicense;
//            emailTextBox.Text = _client.Email;
//            phoneTextBox.Text = _client.Phone;
//            addressTextBox.Text = _client.Address;
        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {
            if (_mode != FormMode.AddNew)
                UpdateUi();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!ValidInputsToClient()) return;

            try
            {
                _unitOfWork.Clients.Add(_client);
                _unitOfWork.Complete();
                OnValidating("Client Saved", false);
                _saved = true;
            }
            catch (FormattedDbEntityValidationException exception)
            {
                OnValidating(exception.Message);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _onCloseCallBack(_mode == FormMode.AddNew && _saved ? _client : null);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}