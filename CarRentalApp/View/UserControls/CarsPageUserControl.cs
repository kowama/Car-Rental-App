using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
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
            _unitOfWork = new UnitOfWork();
        }

        private void DisplaySelectedCar(Car car = null)
        {
            if (car == null && carsDataGridView.RowCount != 0)
                car = (Car) carsDataGridView.Rows[0].DataBoundItem;

            if (car == null) return;
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
            var total = cars.Count;
            var available = cars.FindAll(c=>c.IsAvailable()).Count;
            var unavailable = total - available;
            var ratio = available / total;

            carsCountLabel.Text = $@"{total:F0}";
            availableCarsCountLabel.Text = $@"{available:F0}";
            inavailableCarsCountLabel.Text = $@"{unavailable:F0}";
            carsAvailableCircleProgressBar.Value = ratio*100;

        }

        private void RefreshDataGridView()
        {
            var  cars = _unitOfWork.Cars.GetAll().ToList();
            carsBindingSource.DataSource = cars;
            RefreshCarsIndicator(cars);
        }

        protected override void OnLoad(EventArgs e)
        {
            RefreshDataGridView();
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == _searchTextBoxDefaultText) searchTextBox.Text = string.Empty;
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Trim() == string.Empty) searchTextBox.Text = _searchTextBoxDefaultText;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
        }


        private void RefreshDataGrid_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void AddNewCarsButton_Click(object sender, EventArgs e)
        {
            var carForm = new CarForm();
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
            {
                e.Value = car.Classification.Name;
            }
        }

        private void CarsDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var car = (Car) carsDataGridView.Rows[e.RowIndex].DataBoundItem;
            DisplaySelectedCar(car);
        }

        private void SelectedCarDescriptionLabel_Paint(object sender, PaintEventArgs e)
        {
            selectedCarDescriptionLabel.MaximumSize = new Size(selectedCarCardPanel.Width,0);

        }
    }
}