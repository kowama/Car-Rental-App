using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.Core.Utils;
using CarRentalApp.Persistence;

namespace CarRentalApp.View.Forms
{
    public partial class CarForm : Form
    {
        private const int AddModeWidth = 484;
        private readonly Car _car;
        private readonly Action<Car> _onCloseCallBack;
        private readonly UnitOfWork _unitOfWork;
        private FormMode _mode;
        private bool _saved;

        public CarForm(FormMode mode, Action<Car> onCloseCallBack = null, Car car = null)
        {
            InitializeComponent();
            _unitOfWork = UnitOfWork.Instance;
            _mode = mode;
            _onCloseCallBack = onCloseCallBack;
            _car = car ?? new Car();
            if (_mode == FormMode.AddNew)
                Width = AddModeWidth;
        }

        private void OnValidation(string message, bool error = true)
        {
            validationLabel.ForeColor = !error ? Color.ForestGreen : Color.Red;
            validationLabel.Text = message;
            validationLabel.Visible = true;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(carNameTextBox.Text))
            {
                OnValidation("Car Name not Valid");
                return false;
            }

            if (string.IsNullOrWhiteSpace(carDescriptionTextBox.Text) || carDescriptionTextBox.Text.Trim().Length < 3)
            {
                OnValidation("Car Description may be a least 3 chars");
                return false;
            }

            if (carPricePerDayNumericUpDown.Value == 0)
            {
                OnValidation("Price Not Valid");
                return false;
            }

            return true;
        }

        private bool ValidateInputsToCar()
        {
            if (!ValidateInput()) return false;

            _car.Name = carNameTextBox.Text;
            _car.LicensePlate = carLicensePlateTextBox.Text;
            _car.Classification =
                _unitOfWork.Classifications.SingleOrDefault(c => c.Name == carClassificationDropDown.selectedValue);
            _car.PricePerDay = carPricePerDayNumericUpDown.Value;
            _car.PurchaseDate = carPurchaseDatepicker.Value;
            _car.NextDrainDate = carNextDrainDatepicker.Value;
            _car.Description = carDescriptionTextBox.Text;

            return true;
        }

        private void OnChildFromClosed(bool refresh = false)
        {
            if (refresh)
                RefreshClassificationsDropDown();
        }

        private void UpdateUi()
        {
            carNameTextBox.Text = _car.Name;
            carLicensePlateTextBox.Text = _car.LicensePlate;
            carPricePerDayNumericUpDown.Value = _car.PricePerDay;
            carClassificationDropDown.SelectedItem(_car.Classification.Name);
            carDescriptionTextBox.Text = _car.Description;
            if (_car.NextDrainDate != null) carNextDrainDatepicker.Value = (DateTime) _car.NextDrainDate;
            if (_car.PurchaseDate != null) carPurchaseDatepicker.Value = (DateTime) _car.PurchaseDate;
        }

        private void RefreshClassificationsDropDown()
        {
            var classifications = _unitOfWork.Classifications.GetAll().ToList();
            var classificationNames = new List<string>();
            classifications.ForEach(c => classificationNames.Add(c.Name));
            carClassificationDropDown.items = classificationNames.ToArray();
            if (carClassificationDropDown.items.Length != 0)
                carClassificationDropDown.SelectedItem(_car.Classification != null
                    ? _car.Classification.Name
                    : classificationNames.First());
        }

        private void AddNewClassificationButton_Click(object sender, EventArgs e)
        {
            var classificationForm = new ClassificationForm(OnChildFromClosed);
            classificationForm.Show();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            RefreshClassificationsDropDown();
            if (_mode != FormMode.AddNew)
                UpdateUi();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputsToCar()) return;

            try
            {
                _unitOfWork.Cars.Add(_car);
                _unitOfWork.Complete();
                OnValidation("Car Successfully saved", false);
                _saved = true;
            }
            catch (FormattedDbEntityValidationException exception)
            {
                OnValidation(exception.Message);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            _mode = FormMode.Edit;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _onCloseCallBack(_mode == FormMode.AddNew && _saved ? _car : null);
        }
    }
}