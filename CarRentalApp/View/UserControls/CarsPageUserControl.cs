using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.Core.Utils;
using CarRentalApp.Persistence;
using CarRentalApp.View.Forms;

namespace CarRentalApp.View.UserControls
{
    public partial class CarsPageUserControl : UserControl
    {
        private readonly string _searchTextBoxDefaultText;
        private readonly UnitOfWork _unitOfWork;
        private Car _selectedCar;

        public CarsPageUserControl()
        {
            InitializeComponent();
            _searchTextBoxDefaultText = searchTextBox.Text;
            _unitOfWork = UnitOfWork.Instance;
        }

        private void DisplaySelectedCar()
        {
            if (_selectedCar == null)
            {
                selectedCarNameLabel.Text
                    = selectedCarClassificationLabel.Text
                        = selectedCarLicensePlateLabel.Text
                            = selectedCarDescriptionLabel.Text
                                = selectedCarPricePerDayLabel.Text
                                    = selectedCarNextDrainDateLabel.Text
                                        = selectedCarRentsCountLabel.Text
                                            = selectedCarAvailabilityLabel.Text
                                                = selectedCarPurchaseDateLabel.Text = string.Empty;
                return;
            }

            selectedCarNameLabel.Text = _selectedCar.Name;
            selectedCarClassificationLabel.Text = _selectedCar.Classification.Name;
            selectedCarLicensePlateLabel.Text = _selectedCar.LicensePlate;
            selectedCarDescriptionLabel.Text = _selectedCar.Description;
            selectedCarPricePerDayLabel.Text = $@"{_selectedCar.PricePerDay:#,0.00} MAD /Day";
            selectedCarRentsCountLabel.Text = _selectedCar.Rents.Count.ToString();
            selectedCarNextDrainDateLabel.Text = $@"{_selectedCar.NextDrainDate:dd/MM/yyyy}";
            selectedCarPurchaseDateLabel.Text = $@"{_selectedCar.PurchaseDate:dd/MM/yyyy}";
            selectedCarAvailabilityLabel.Text = _selectedCar.IsAvailable ? "Available" : "Unavailable";
            selectedCarAvailabilityLabel.BackColor = _selectedCar.IsAvailable ? Color.Green : Color.Red;
        }


        private void Search(string keyword)
        {
            if (keyword == _searchTextBoxDefaultText)
                keyword = string.Empty;

            var cars = _unitOfWork.Cars.GetAll().ToList();
            var all = searchFilterComboBox.SelectedIndex == searchFilterComboBox.Items.Count - 1;
            var filterBy = searchFilterComboBox.SelectedText;
            List<Car> filteredCars;

            if (!string.IsNullOrEmpty(keyword))
                filteredCars = cars.FindAll(c =>
                    c.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) &&
                    (filterBy == nameDataGridViewTextBoxColumn.HeaderText || all)
                    || c.LicensePlate.Contains(keyword, StringComparison.OrdinalIgnoreCase) &&
                    (filterBy == licensePlateDataGridViewTextBoxColumn.HeaderText || all)
                    || c.Classification.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) &&
                    (filterBy == classificationDataGridViewTextBoxColumn.HeaderText || all)
                    || c.PricePerDay.ToString(CultureInfo.CurrentCulture)
                        .Contains(keyword, StringComparison.OrdinalIgnoreCase) &&
                    (filterBy == pricePerDayDataGridViewTextBoxColumn.HeaderText || all)
                );
            else
                filteredCars = cars;

            carBindingSource.DataSource = filteredCars;
        }

        private void RefreshDataGridView()
        {
            var cars = _unitOfWork.Cars.GetAll().ToList();
            carBindingSource.DataSource = cars;
        }

        private void OnChildFromClosed(Car theCar)
        {
            if (theCar == null) return;

            RefreshDataGridView();
            foreach (DataGridViewRow row in carDataGridView.Rows)
            {
                var car = (Car) row.DataBoundItem;
                if (theCar.Id == car.Id)
                    row.Selected = true;
            }
        }


        protected override void OnLoad(EventArgs e)
        {
            RefreshDataGridView();
            searchFilterComboBox.DataSource = new[]
            {
                nameDataGridViewTextBoxColumn.HeaderText,
                licensePlateDataGridViewTextBoxColumn.HeaderText,
                pricePerDayDataGridViewTextBoxColumn.HeaderText,
                classificationDataGridViewTextBoxColumn.HeaderText,
                "All"
            };
            searchFilterComboBox.SelectedIndex = searchFilterComboBox.Items.Count - 1;
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == _searchTextBoxDefaultText)
                searchTextBox.Text = string.Empty;
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
                searchTextBox.Text = _searchTextBoxDefaultText;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search(searchTextBox.Text.Trim());
        }

        private void RefreshDataGrid_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void AddNewCarsButton_Click(object sender, EventArgs e)
        {
            var carForm = new CarForm(FormMode.AddNew, OnChildFromClosed);
            carForm.Show();
        }

        private void CarsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (carDataGridView.Rows[e.RowIndex].DataBoundItem == null) return;

            //display row index
            var row = carDataGridView.Rows[e.RowIndex];
            row.HeaderCell.Value = $"{row.Index + 1}";

            var car = (Car) carDataGridView.Rows[e.RowIndex].DataBoundItem;
            if (carDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Car.CarImage)))
                e.Value = selectedCarPictureBox.Image;
            if (carDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Car.Classification)))
                e.Value = car.Classification.Name;
            if (carDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Car.NextDrainDate)))
                e.Value = string.Format($"{car.NextDrainDate:dd/MM/yyyy}");
            if (carDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Car.PricePerDay)))
                e.Value = string.Format($"{car.PricePerDay:N} MAD");
        }

        private void CarsDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var car = (Car) carDataGridView.Rows[e.RowIndex].DataBoundItem;
            _selectedCar = car;
            DisplaySelectedCar();
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search(searchTextBox.Text.Trim());
        }

        private void CarsPageUserControl_Load(object sender, EventArgs e)
        {
        }

        private void SelectedCarEditButton_Click(object sender, EventArgs e)
        {
            if (_selectedCar == null) return;
            var carForm = new CarForm(FormMode.View, OnChildFromClosed, _selectedCar);
            carForm.Show();
        }
    }
}