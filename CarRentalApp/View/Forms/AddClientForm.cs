using System;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using CarRentalApp.Core.domain;
using CarRentalApp.Persistence;

namespace CarRentalApp.View.Forms
{
    public partial class AddClientForm : Form
    {
        private readonly string _defaultTextPref;
        private readonly UnitOfWork _unitOfWork;

        public AddClientForm()
        {
            InitializeComponent();
            _defaultTextPref = fistNameTextBox.Text.Substring(0, 12);
            _unitOfWork = new UnitOfWork();
        }

        private bool ValidateInput()
        {
           return !(string.IsNullOrEmpty(fistNameTextBox.Text)
                             || fistNameTextBox.Text.StartsWith(_defaultTextPref)
                             || string.IsNullOrEmpty(lastNameTextBox.Text)
                             || lastNameTextBox.Text.StartsWith(_defaultTextPref)
                             || string.IsNullOrEmpty(cinTextBox.Text)
                             || cinTextBox.Text.StartsWith(_defaultTextPref)
                             || string.IsNullOrEmpty(emailTextbox.Text)
                             || emailTextbox.Text.StartsWith(_defaultTextPref)
                             || string.IsNullOrEmpty(addressTextBox.Text)
                             || addressTextBox.Text.StartsWith(_defaultTextPref));
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
            emailTextbox.Text = client.Email;
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
                Email = emailTextbox.Text.Trim(),
                Address = addressTextBox.Text.Trim()
            };
        }
       private void FormTextBox_Enter(object sender, EventArgs e)
        {
            var senderTextBox = (BunifuMetroTextbox) sender;
            if (senderTextBox.Text.StartsWith(_defaultTextPref)) senderTextBox.Text = string.Empty;
        }

        private void FormTextBox_Leave(object sender, EventArgs e)
        {
            var senderTextBox = (BunifuMetroTextbox) sender;
            if (senderTextBox.Text.Trim() == string.Empty) senderTextBox.Text = string.Empty;
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
            catch (Exception)
            {
                OnValidationError(@"error Unable to Save the Client");

            }
        }

      
    }
}