using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.Persistence;

namespace CarRentalApp.View.UserControls
{
    public partial class RentUserControl : UserControl
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly Action<Control> _next;
        private readonly Rent _rent;
        private readonly bool _newRent;

        public RentUserControl(UnitOfWork unitOfWork, Action<Control> next, Rent rent = null)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _next = next;
            _rent = rent;

            if (_rent != null) return;

            _newRent = true;
            _rent= new Rent
            {
                RentId = Guid.NewGuid()
            };

        }

        private void RefreshDataBind()
        {
            var clients = _unitOfWork.Clients.GetAll().OrderBy(c => c.FirstName);
            var cars = _unitOfWork.Cars;
            clientsDropDown.items = clients.Select(c => c.Resume).ToArray();
            carsDropDown.items = cars.GetAll().OrderBy(c => c.Name).Select(c => c.Resume).ToArray();
            rentStateDropDown.items=  Enum.GetValues(typeof(RentState)).Cast<RentState>().Select(x=>x.ToString()).ToArray();

        }

        private void UpdateUi()
        {
            if (_newRent) return;

            startDatePicker.Value = _rent.DateStart;
            if (_rent.DateEnd != null) endDatePicker.Value = (DateTime) _rent.DateEnd;
            startDatePicker.Value = _rent.DateStart;
            clientsDropDown.SelectedItem(_rent.Client.Resume);
            carsDropDown.SelectedItem(_rent.Car.Resume);
            rentStateDropDown.SelectedItem(_rent.State.ToString());
            rentBillNumLabel.Text = _rent.Bill == null ? string.Empty : _rent.Bill.BillNumber.ToString("D");

        }

        private void OnValidating(string message, bool error = true)
        {
            validationLabel.ForeColor = !error ? Color.ForestGreen : Color.Red;
            validationLabel.Text = message;
            validationLabel.Visible = true;
            nextButton.Visible = !error;
            saveButton.Visible = !error;
        }

        private bool ValidateInputs()
        {
            if (clientsDropDown.selectedIndex < 0)
            {
                OnValidating("* You must select a client");
                return false;

            }
            if (carsDropDown.selectedIndex < 0)
            {
                OnValidating("* You must select a car");
                return false;

            }

            if (rentStateDropDown.selectedIndex < 0)
            {
                OnValidating("* You must select a state for The Rent");
                return false;
            }

           
            return true;
        }

        private void InputsToRent()
        {
            var selectedClient = _unitOfWork.Clients.GetByResume(clientsDropDown.selectedValue);
            var selectedCar = _unitOfWork.Cars.GetByResume(carsDropDown.selectedValue);
            Enum.TryParse(rentStateDropDown.selectedValue, out RentState rentState);
            _rent.Client = selectedClient;
            _rent.Car = selectedCar;
            _rent.ManageByUser = Program.CurrentUser;
            _rent.DateStart = startDatePicker.Value;
            _rent.DateEnd = endDatePicker.Value;
            _rent.State = rentState;

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RefreshDataBind();
            UpdateUi();

        }

        private bool ValidateRent()
        {
            if (!ValidateInputs()) return false;

            InputsToRent();
            //some validation logic
            return true;
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if(!ValidateRent()) return;
            OnValidating("Rent information are valid",false);
        }
      

        private void NextButton_Click(object sender, EventArgs e)
        {
            _next(new RentBillUserControl(_unitOfWork, _next, _rent));

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _unitOfWork.Rents.Add(_rent);
                _unitOfWork.Complete();
            }
            catch (FormattedDbEntityValidationException ex)
            {
                OnValidating(ex.Message);
            }
           
        }
    }
}
