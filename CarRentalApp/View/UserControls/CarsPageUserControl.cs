using System;
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

        private void RefreshDataGridView()
        {
            carsBindingSource.DataSource = _unitOfWork.Cars.GetAll().ToList();
        }

        protected override void OnLoad(EventArgs e)
        {
            RefreshDataGridView();
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == _searchTextBoxDefaultText) searchTextBox.Text = string.Empty;
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
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
    }
}