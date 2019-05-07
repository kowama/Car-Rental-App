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

        public CarsPageUserControl()
        {
            InitializeComponent();
            _searchTextBoxDefaultText = searchTextBox.Text;
            _unitOfWork = UnitOfWork.Instance;
        }

        private void DisplaySelectedCar(Car car = null)
        {
            if (car == null)
            {
                selectedCarNameLabel.Text
                    = selectedCarClassificationLabel.Text
                        = selectedCarLicensePlateLabel.Text
                            = selectedCarDescriptionLabel.Text
                                = selectedCarPricePerDayLabel.Text
                                    = selectedCarNextDrainDateLabel.Text
                                        =selectedCarRentsCountLabel.Text
                                        = selectedCarPurchaseDateLabel.Text = string.Empty;
                return;
            }

            selectedCarNameLabel.Text = car.Name;
            selectedCarClassificationLabel.Text = car.Classification.Name;
            selectedCarLicensePlateLabel.Text = car.LicensePlate;
            selectedCarDescriptionLabel.Text = car.Description;
            selectedCarPricePerDayLabel.Text = $@"{car.PricePerDay:#,0.00} MAD /Day";
            selectedCarRentsCountLabel.Text = car.Rents.Count.ToString();
            selectedCarNextDrainDateLabel.Text = $@"{car.PurchaseDate:D}";
            selectedCarPurchaseDateLabel.Text = $@"{car.PurchaseDate:MM/dd/yyyy}";
        }

        private void RefreshCarsIndicator(List<Car> cars)
        {
            float total = cars.Count;
            float available = cars.FindAll(c => c.IsAvailable).Count;
            var unavailable = total - available;
            var ratio = available / total;

            carsCountLabel.Text = $@"{total:F0}";
            availableCarsCountLabel.Text = $@"{available:F0}";
            inavailableCarsCountLabel.Text = $@"{unavailable:F0}";
            carsAvailableCircleProgressBar.Value = (int)(ratio * 100);
        }

        private void Search(string keyword)
        {
            if (keyword == _searchTextBoxDefaultText)
                keyword = string.Empty;

            var cars = _unitOfWork.Cars.GetAll().ToList();
            var all = seachFilterDropdown.selectedIndex == seachFilterDropdown.items.Length - 1;
            var filterBy = seachFilterDropdown.selectedValue;

            var filteredCars = cars.FindAll(c =>
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

            carsBindingSource.DataSource = filteredCars;
        }

        private void RefreshDataGridView()
        {
            var cars = _unitOfWork.Cars.GetAll().ToList();
            carsBindingSource.DataSource = cars;
            RefreshCarsIndicator(cars);
        }

        private void OnChildFromClosed(Car theCar)
        {
            if (theCar == null) return;

            RefreshDataGridView();
            foreach (DataGridViewRow row in carsDataGridView.Rows)
            {
                var car = (Car)row.DataBoundItem;
                if (theCar.Id == car.Id)
                    row.Selected = true;
            }
        }


        protected override void OnLoad(EventArgs e)
        {
            RefreshDataGridView();
            seachFilterDropdown.items = new[]
            {
                nameDataGridViewTextBoxColumn.HeaderText,
                licensePlateDataGridViewTextBoxColumn.HeaderText,
                pricePerDayDataGridViewTextBoxColumn.HeaderText,
                classificationDataGridViewTextBoxColumn.HeaderText,
                "All"
            };
            seachFilterDropdown.selectedIndex = seachFilterDropdown.items.Length - 1;
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == _searchTextBoxDefaultText) searchTextBox.Text = string.Empty;
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text)) searchTextBox.Text = _searchTextBoxDefaultText;
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
        }

        private void CarsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (carsDataGridView.Rows[e.RowIndex].DataBoundItem == null) return;

            //display row index
            var row = carsDataGridView.Rows[e.RowIndex];
            row.HeaderCell.Value = $"{row.Index + 1}";

            var car = (Car) carsDataGridView.Rows[e.RowIndex].DataBoundItem;
            if (carsDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Car.Classification)))
                e.Value = car.Classification.Name;
        }

        private void CarsDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var car = (Car) carsDataGridView.Rows[e.RowIndex].DataBoundItem;
            DisplaySelectedCar(car);
        }

        private void SelectedCarDescriptionLabel_Paint(object sender, PaintEventArgs e)
        {
            selectedCarDescriptionLabel.MaximumSize = new Size(selectedCarCardPanel.Width, 0);
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search(searchTextBox.Text.Trim());
        }

        private void carsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var car = (Car)carsDataGridView.Rows[e.RowIndex].DataBoundItem;
            if (car == null) return;
            var carForm = new CarForm(FormMode.View, OnChildFromClosed, car);
            carForm.Show();

        }
    }
}