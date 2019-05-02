using System;
using System.Drawing;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.Persistence;

namespace CarRentalApp.View.Forms
{
    public partial class AddClientForm : Form
    {
        private readonly UnitOfWork _unitOfWork;

        public AddClientForm()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
        }

        private bool ValidateInput()
        {
            return !(string.IsNullOrEmpty(fistNameTextBox.Text)
                     || string.IsNullOrEmpty(lastNameTextBox.Text)
                     || string.IsNullOrEmpty(cinTextBox.Text)
                     || string.IsNullOrEmpty(emailTextBox.Text)
                     || string.IsNullOrEmpty(addressTextBox.Text));
        }
        private void OnSaveCompleted()
        {
            validationLabel.Text = @"Successfully Saved";
            validationLabel.ForeColor = Color.SeaGreen;
            validationLabel.Visible = true;

        }
        private void OnValidationError(string message)
        {
            validationLabel.Text = message;
            validationLabel.ForeColor = Color.Red;
            validationLabel.Visible = true;
        }

        private void ClientToFormTextBox(Client client)
        {
            fistNameTextBox.Text = client.LastName;
            lastNameTextBox.Text = client.LastName;
            cinTextBox.Text = client.Cin;
            emailTextBox.Text = client.Email;
            phoneTextBox.Text = client.Phone;
            addressTextBox.Text = client.Address;
        }

        private Client TextBoxToClient()
        {
           return new Client
            {
                FirstName = fistNameTextBox.Text.Trim(),
                LastName = lastNameTextBox.Text.Trim(),
                Cin = cinTextBox.Text.Trim(),
                Email = emailTextBox.Text.Trim(),
                Phone = phoneTextBox.Text.Trim(),
                DriverLicense = driverLicenseTextBox.Text.Trim(),
                Address = addressTextBox.Text.Trim()
            };
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                OnValidationError(@"Client not Save , Please verify the given information");
                return;
            }
            
            try
            {
                var client = TextBoxToClient();
                _unitOfWork.Clients.Add(client);
                _unitOfWork.Complete();
                ClientToFormTextBox(client);
                OnSaveCompleted();

            }
            catch (FormattedDbEntityValidationException exception)
            {
                OnValidationError(exception.Message);

            }
        }

      
    }
}