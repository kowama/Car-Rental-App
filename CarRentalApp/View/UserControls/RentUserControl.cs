using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.Core.Utils;
using CarRentalApp.Persistence;
using CarRentalApp.View.Forms;

namespace CarRentalApp.View.UserControls
{
    public partial class RentUserControl : UserControl
    {
        private readonly Action<Control> _next;
        private readonly Action<Rent> _onActionCompleted;
        private readonly Rent _rent;
        private readonly UnitOfWork _unitOfWork;
        private readonly  Point _firstControlLocation = new Point(50, 450);
        private readonly  Point _secondControlLocation = new Point(184, 450);
        private readonly  Point _thirdControlLocation= new Point(303, 450);
        private readonly bool _rollBack;
        private FormMode _mode;

        public RentUserControl(FormMode mode, Rent rent = null, Action<Rent> onActionCompleted=null, Action<Control> next = null,  bool rollBack = false)
        {
            InitializeComponent();
            _unitOfWork = UnitOfWork.Instance;
            _next = next;
            _rent = rent;
            _mode = mode;
            _onActionCompleted = onActionCompleted;
            _rollBack = rollBack;

            if (_rent != null) return;

            _rent = new Rent
            {
                RentId = Guid.NewGuid()
            };
        }

        private void RefreshDataBind()
        {
            var clients = _unitOfWork.Clients.GetAll().OrderBy(c => c.FirstName);
            var cars = _unitOfWork.Cars;
            rentClientComboBox.DataSource = clients.OrderBy(c => c.Resume).Select(c => c.Resume).ToList();
            rentCarComboBox.DataSource = cars.GetAll().OrderBy(c => c.Name).Select(c => c.Resume).ToList();
            rentStatusComboBox.DataSource =
                Enum.GetValues(typeof(RentState)).Cast<RentState>().Select(x => x.ToString()).OrderBy(s=>s).ToList();
        }

        private void UpdateControlsUi(bool saveCompleted = false)
        {
            switch (_mode)
            {
                case FormMode.View:
                    editButton.Visible = true;
                    editButton.Location = _firstControlLocation;
                    finishedButton.Visible = saveCompleted;
                    finishedButton.Location = _thirdControlLocation;
                    
                    checkButton.Visible = false;
                    cancelEditButton.Visible = false;
                    
                    saveButton.Visible = false;
                    nextButton.Visible = false;
                    addNewClientButton.Visible = false;
                    carFilterCheckBox.Visible = false;
                    validationLabel.Visible = false;

                    rentClientComboBox.Enabled = false;
                    rentCarComboBox.Enabled = false;
                    rentStartDateTimePicker.Enabled = false;
                    rentEndDateTimePicker.Enabled = false;
                    rentStatusComboBox.Enabled = false;

                    break;
                case FormMode.Edit:
                    saveButton.Visible = true;
                    saveButton.Location = _firstControlLocation;
                    cancelEditButton.Visible = true;
                    cancelEditButton.Location = _thirdControlLocation;
                    nextButton.Visible = _rollBack;
                    nextButton.Location = _thirdControlLocation;

                    editButton.Visible = false;
                    checkButton.Visible = false;

                    addNewClientButton.Visible = true;
                    carFilterCheckBox.Visible = true;
                    rentCarComboBox.Enabled = true;
                    rentStartDateTimePicker.Enabled = true;
                    rentEndDateTimePicker.Enabled = true;
                    rentStatusComboBox.Enabled = true;
                    rentClientComboBox.Enabled = true;
                    validationLabel.Visible = false;

                    break;
                case FormMode.AddNew:

                    checkButton.Visible = !_rollBack;
                    checkButton.Location = _firstControlLocation;
                    saveButton.Visible = _rollBack;
                    saveButton.Location = _secondControlLocation;
                    nextButton.Visible = _rollBack;
                    nextButton.Location = _thirdControlLocation;

                    editButton.Visible = false;
                    cancelEditButton.Visible = false;
                    addNewClientButton.Visible = true;
                    carFilterCheckBox.Visible = true;
                    validationLabel.Visible = false;
                    rentClientComboBox.Enabled = true;
                    rentCarComboBox.Enabled = true;
                    rentStartDateTimePicker.Enabled = true;
                    rentEndDateTimePicker.Enabled = true;
                    rentStatusComboBox.Enabled = true;
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

        }

        private void UpdateRentInfoUi()
        {
            if (_mode == FormMode.AddNew && !_rollBack)
            {
                rentClientComboBox.SelectedIndex = -1;
                rentCarComboBox.SelectedIndex = -1;
                rentStatusComboBox.SelectedIndex = -1;
                return;
            }

            rentIdLabel.Text = _rent.RentId.ToString("N").ToUpper();
            rentStartDateTimePicker.Value = _rent.DateStart;
            if (_rent.DateEnd != null) rentEndDateTimePicker.Value = (DateTime) _rent.DateEnd;
            rentStartDateTimePicker.Value = _rent.DateStart;
            rentClientComboBox.Text = _rent.Client.Resume;
            rentCarComboBox.Text =  _rent.Car.Resume;
            rentStatusComboBox.Text = _rent.State.ToString();
        }

        private void OnValidating(string message, bool error = true)
        {
            validationLabel.ForeColor = !error ? Color.ForestGreen : Color.Red;
            validationLabel.Text = message;
            validationLabel.Visible = true;
            nextButton.Visible = (!error && _mode == FormMode.AddNew) || _rollBack && _mode != FormMode.View;
            saveButton.Visible = !error && _mode != FormMode.View;
            
        }

        private bool ValidateInputs()
        {
            if (rentClientComboBox.SelectedIndex < 0)
            {
                OnValidating("* You must select a client");
                return false;
            }

            if (rentCarComboBox.SelectedIndex < 0)
            {
                OnValidating("* You must select a car");
                return false;
            }
            if (rentStartDateTimePicker.Value > rentEndDateTimePicker.Value)
            {
                OnValidating("* Rent end day must be greater than start day");
                return false;

            }

            if (rentStatusComboBox.SelectedIndex < 0)
            {
                OnValidating("* You must select a state for The Rent");
                return false;
            }
            
            return true;
        }

        private bool ValidateInputsToRent()
        {
            if (!ValidateInputs()) return false;


            var selectedClient = _unitOfWork.Clients.GetByResume(rentClientComboBox.Text);
            var selectedCar = _unitOfWork.Cars.GetByResume(rentCarComboBox.Text);
            Enum.TryParse(rentStatusComboBox.Text, out RentState rentState);
            _rent.Client = selectedClient;
            _rent.Car = selectedCar;
            _rent.ManageBy = Program.CurrentUser;
            _rent.DateStart = rentStartDateTimePicker.Value;
            _rent.DateEnd = rentEndDateTimePicker.Value;
            _rent.State = rentState;

            return true;
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputsToRent()) return;
            OnValidating("Rent information are valid", false);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            _next(new RentBillUserControl(FormMode.AddNew, _rent,_onActionCompleted, _next));
        }

        private void FinishedButton_Click(object sender, EventArgs e)
        {
            _onActionCompleted(_rent);
        }


        private void CancelEditButton_Click(object sender, EventArgs e)
        {
            _mode = FormMode.View;
            UpdateControlsUi();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputsToRent()) return;
            switch (_mode)
            {
                case FormMode.AddNew:
                    try
                    {
                        _unitOfWork.Rents.Add(_rent);
                        _unitOfWork.Complete();
                        _mode = FormMode.View;
                        UpdateControlsUi(true);
                        OnValidating("Successfully saved !", false);
                    }
                    catch (FormattedDbEntityValidationException ex)
                    {
                        OnValidating(ex.Message);
                    }

                    break;
                case FormMode.Edit:
                    try
                    {
                        _unitOfWork.Complete();
                        _mode = FormMode.View;
                        UpdateControlsUi(true);
                        OnValidating("Successfully updated !", false);
                    }
                    catch (FormattedDbEntityValidationException ex)
                    {
                        OnValidating(ex.Message);
                    }

                    break;
                case FormMode.View:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void RentUserControl_Load(object sender, EventArgs e)
        {

            RefreshDataBind();
            UpdateRentInfoUi();
            UpdateControlsUi();
        }

        private void AddNewClient_Click(object sender, EventArgs e)
        {
            var clientForm = new ClientForm(FormMode.AddNew);
            clientForm.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            _mode = FormMode.Edit;
            UpdateControlsUi();
        }
    }
}