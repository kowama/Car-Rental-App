using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.Persistence;

namespace CarRentalApp.View.Forms
{
    public partial class CarForm : Form
    {
        private readonly UnitOfWork _unitOfWork;
        public CarForm()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
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

            if (string.IsNullOrWhiteSpace(carPricePerDayTextBox.Text))
            {
                OnValidation("Price Not Valid");
                return false;
            }
            return true;
        }
        private Car InputsToCar()
        {
            return new Car()
            {
                Name = carNameTextBox.Text,
                LicensePlate = carLicensePlateTextBox.Text,
                Classification = _unitOfWork.Classifications.SingleOrDefault(
                    c=>c.Name == carClassificationDropDown.selectedValue),
                PricePerDay = int.Parse(carPricePerDayTextBox.Text),
                PurchaseDate = carPurchaseDatepicker.Value,
                NextDrainDate = carNextDrainDatepicker.Value,
                Description = carDescriptionTextBox.Text

            };
        }

        private void RefreshClassification()
        {
            var classifications = _unitOfWork.Classifications.GetAll().ToList();
            var classificationNames = new List<string>();
            classifications.ForEach(c => classificationNames.Add(c.Name));
            carClassificationDropDown.items = classificationNames.ToArray();
            carClassificationDropDown.selectedIndex = 0;
        }

        private void ClassificationButton_Click(object sender, EventArgs e)
        {
            var classificationForm = new ClassificationForm();
            classificationForm.Show();
            
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            RefreshClassification();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;          

            try
            {
                var car = InputsToCar();
                _unitOfWork.Cars.Add(car);
                _unitOfWork.Complete();
                OnValidation("Successfully saved",false);
                
            }
            catch (FormattedDbEntityValidationException exception)
            {
                OnValidation(exception.Message);
            }
        }
    }
}
