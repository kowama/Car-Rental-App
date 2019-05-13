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
        private const int FullModeWidth = 822;
        private readonly UnitOfWork _unitOfWork;
        private readonly Client _client;
        private  FormMode _mode;
        private readonly Action<Client> _onCloseCallBack;
        private bool _refreshParent;
        private bool IsFullSizeMode => Width >= FullModeWidth;

        public sealed override Size MinimumSize
        {
            get => base.MinimumSize;
            set => base.MinimumSize = value;
        }

        private readonly Point _firstControlLocation = new Point(25, 449);

        public ClientForm(FormMode mode, Action<Client> onCloseCallBack =null, Client client = null)
        {
            InitializeComponent();
            _unitOfWork = UnitOfWork.Instance;
            _mode = mode;
            _onCloseCallBack = onCloseCallBack;
            _client = client ?? new Client();

            if (_mode != FormMode.AddNew) return;
            Width = MinimumSize.Width;
            detailsRightPanel.Visible = false;

        }

        private void OnValidating(string message, bool error = true)
        {
            validationLabel.ForeColor = !error ? Color.ForestGreen : Color.Red;
            validationLabel.Text = message;
            validationLabel.Visible = true;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(clientFirstNameTextBox.Text))
            {
                OnValidating("* First name is required");
                return false;
            }

            if (string.IsNullOrEmpty(clientLastNameTextBox.Text))
            {
                OnValidating("* Last name is required");
                return false;
            }

            if (clientCinTextBox.Text.Trim().Length < 6)
            {
                OnValidating("* Cin must be a least 6 char");
                return false;
            }

            if (clientDriverLicenseTextBox.Text.Trim().Length < 6)
            {
                OnValidating("* Driver License must be a least 6 char");
                return false;
            }

            if (!EmailUtils.IsValidEmail(clientEmailTextBox.Text.Trim()))
            {
                OnValidating("* Email address not valid");
                return false;
            }

            return true;
        }

        private bool ValidInputsToClient()
        {
            if (!ValidateInputs()) return false;

            _client.FirstName = clientFirstNameTextBox.Text.Trim();
            _client.LastName = clientLastNameTextBox.Text.Trim();
            _client.Cin = clientCinTextBox.Text.Trim();
            _client.Email = clientEmailTextBox.Text.Trim();
            _client.Phone = clientPhoneTextBox.Text.Trim();
            _client.DriverLicense = clientDriverLicenseTextBox.Text.Trim();
            _client.Address = clientAddressTextBox.Text.Trim();

            return true;
        }

        private void RefreshClientRentsInfo()
        {
            rentBindingSource.DataSource = _client.Rents;
            clientRentsCountLabel.Text = _client.Rents.Count.ToString("N0");
        }

        private void UpdateControlsUi()
        {
            validationLabel.Visible = false;

            switch (_mode)
            {
                case FormMode.View:
                    editButton.Visible = true;
                    editButton.Location = _firstControlLocation;
                    saveButton.Visible = false;
                    addMoreButton.Visible = false;
                    CancelEditButton.Visible = false;

                    break;
                case FormMode.Edit:
                    saveButton.Visible = true;
                    saveButton.Location = _firstControlLocation;
                    CancelEditButton.Visible = true;

                    addMoreButton.Visible = false;
                    editButton.Visible = false;
                    break;

                case FormMode.AddNew:
                    saveButton.Visible = true;
                    saveButton.Location = _firstControlLocation;
                    editButton.Visible = false;
                    addMoreButton.Visible = false;
                    CancelEditButton.Visible = false;

                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            //close button
           fullSizecloseButton.Visible = IsFullSizeMode;
           normalSizecloseButton.Visible = !IsFullSizeMode;

            var isEnabled = _mode != FormMode.View;
           clientFirstNameTextBox.Enabled = isEnabled;
           clientLastNameTextBox.Enabled = isEnabled;
           clientCinTextBox.Enabled = isEnabled;
           clientDriverLicenseTextBox.Enabled = isEnabled;
           clientEmailTextBox.Enabled = isEnabled;
           clientPhoneTextBox.Enabled = isEnabled;
           clientAddressTextBox.Enabled = isEnabled;
        }

        private void UpdateClientInfoUi()
        {
            clientFirstNameTextBox.Text = _client.FirstName;
            clientLastNameTextBox.Text = _client.LastName;
            clientCinTextBox.Text = _client.Cin;
            clientDriverLicenseTextBox.Text = _client.DriverLicense;
            clientEmailTextBox.Text = _client.Email;
            clientPhoneTextBox.Text = _client.Phone;
            clientAddressTextBox.Text = _client.Address;

            if (_mode != FormMode.AddNew && IsFullSizeMode)
            {
                detailsRightPanel.Visible = true;
                RefreshClientRentsInfo();


            }
            else
            {
                detailsRightPanel.Visible = false;
            }


        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {
            UpdateControlsUi();

            if (_mode != FormMode.AddNew)
                UpdateClientInfoUi();



        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(!ValidInputsToClient()) return;
            switch (_mode)
            {
                case FormMode.AddNew:
                    try
                    {
                       _unitOfWork.Clients.Add(_client);
                       _unitOfWork.Complete();
                       _refreshParent = true;
                       _mode = FormMode.View;
                       UpdateControlsUi();
                       OnValidating("Successfully saved !",false);

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
                        UpdateControlsUi();
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

        private void CancelEditButton_Click(object sender, EventArgs e)
        {
            _mode = FormMode.View;
            UpdateClientInfoUi();
            UpdateControlsUi();

        }

        private void RentsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (clientRentsDataGridView.Rows[e.RowIndex].DataBoundItem == null) return;

            var row = clientRentsDataGridView.Rows[e.RowIndex];
            row.HeaderCell.Value = $"{row.Index + 1}";

            var rent = (Rent)clientRentsDataGridView.Rows[e.RowIndex].DataBoundItem;

            if (rent == null) return;

            if (clientRentsDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.RentId)))
                e.Value = rent.RentId.ToString("D").ToUpper();

            if (clientRentsDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.Client)))
                e.Value = rent.Client.FullName;

            if (clientRentsDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.Car)))
                e.Value = rent.Car.Name;

            if (clientRentsDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.ManageBy)))
                e.Value = rent.ManageBy.FullName;

            if (clientRentsDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.Bill)))
                e.Value = rent.Bill != null ? rent.Bill.BillNumber.ToString("D").ToUpper() : string.Empty;

            if (clientRentsDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.State)))
                e.Value = rent.State.ToString();

            if (clientRentsDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.DateStart)))
                e.Value = rent.DateStart.ToString("dd/MM/yyyy");

            if (clientRentsDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.DateEnd)))
                e.Value = rent.DateEnd != null ? rent.DateStart.ToString("dd/MM/yyyy") : string.Empty;
            if (clientRentsDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.NumberOfDays)))
                e.Value = rent.NumberOfDays.ToString("N0");
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            _mode = FormMode.Edit;
            UpdateControlsUi();
        }

        private void AddMoreButton_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _onCloseCallBack(_refreshParent ? _client : null);
        }

        private void ClientRentsDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            
        }

        private void ClientRentsDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            UpdateClientInfoUi();

        }

       
    }


}