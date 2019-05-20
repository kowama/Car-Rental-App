using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.Core.Utils;
using CarRentalApp.Persistence;
using CarRentalApp.View.UserControls.Components;
using ComponentFactory.Krypton.Navigator;

namespace CarRentalApp.View.UserControls
{
    public partial class RentsPageUserControl : UserControl
    {
        private readonly string _searchTextBoxDefaultText;
        private readonly UnitOfWork _unitOfWork;

        public RentsPageUserControl()
        {
            InitializeComponent();
            _unitOfWork = UnitOfWork.Instance;
            pageContentNavigator.SelectedPage = newRentPage;
            _searchTextBoxDefaultText = searchTextBox.Text;
        }

        private static void SetPageContentPanel(Control control, Control page)
        {
            page.Dock = DockStyle.Fill;
            control.Controls.Clear();
            control.Controls.Add(page);
        }

        private void Search(string keyword)
        {
            if (keyword == _searchTextBoxDefaultText)
                keyword = string.Empty;

            var allRents = _unitOfWork.Rents.GetAll().ToList();
            var all = searchFilterComboBox.SelectedIndex == searchFilterComboBox.Items.Count - 1;
            var filterBy = searchFilterComboBox.SelectedText;
            List<Rent> filteredRents;

            if (!string.IsNullOrWhiteSpace(keyword))
                filteredRents = allRents.FindAll(r =>
                    r.Car.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) &&
                    (filterBy == carDataGridViewTextBoxColumn.HeaderText || all)
                    || r.Client.FullName.Contains(keyword, StringComparison.OrdinalIgnoreCase) &&
                    (filterBy == clientDataGridViewTextBoxColumn.HeaderText || all)
                    || r.ManageBy.FullName.Contains(keyword, StringComparison.OrdinalIgnoreCase) &&
                    (filterBy == manageByDataGridViewTextBoxColumn.HeaderText || all)
                    || r.RentId.ToString("D").Contains(keyword, StringComparison.OrdinalIgnoreCase) &&
                    (filterBy == rentIdDataGridViewTextBoxColumn.HeaderText || all)
                    || r.Bill != null &&
                    r.Bill.BillNumber.ToString("D").Contains(keyword, StringComparison.OrdinalIgnoreCase) &&
                    (filterBy == billDataGridViewTextBoxColumn.HeaderText || all)
                    || r.DateStart.ToString("d").Contains(keyword, StringComparison.OrdinalIgnoreCase) &&
                    (filterBy == dateStartDataGridViewTextBoxColumn.HeaderText || all)
                    || r.State.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase) &&
                    (filterBy == stateDataGridViewTextBoxColumn.HeaderText || all)
                );
            else
                filteredRents = allRents;

            rentDataGridView.DataSource = filteredRents;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetPageContentPanel(newRentPageContentPanel,
                new RentUserControl(FormMode.AddNew, null, OnActionCompleted, Next));
            searchFilterComboBox.DataSource = new[]
            {
                rentIdDataGridViewTextBoxColumn.HeaderText,
                billDataGridViewTextBoxColumn.HeaderText,
                clientDataGridViewTextBoxColumn.HeaderText,
                carDataGridViewTextBoxColumn.HeaderText,
                manageByDataGridViewTextBoxColumn.HeaderText,
                dateStartDataGridViewTextBoxColumn.HeaderText,
                stateDataGridViewTextBoxColumn.HeaderText,
                "All"
            };
            searchFilterComboBox.SelectedIndex = searchFilterComboBox.Items.Count - 1;

            UpdateChartUi();
        }

        private void UpdateChartUi()
        {
            var allRentsThisYear = _unitOfWork.Rents.GetAll().Where(r => r.DateStart.Year == DateTime.Now.Year);

            var rentGroupedByMonths = allRentsThisYear.GroupBy(r => r.DateStart.Month, (k, rg) => new
            {
                month = k,
                rents = rg.ToList()
            }).ToList();

            foreach (var monthGroup in rentGroupedByMonths)
            foreach (var rent in monthGroup.rents)
            {
                rentsCalendar.SetSelectionRange(rent.DateStart, rent.DateEnd ?? rent.DateStart);
//                rentChart.Series[0].Points.AddXY(DateTimeFormatInfo.InvariantInfo.GetMonthName(monthGroup.month),
//                    rent.DateStart, rent.DateEnd);
                rentChart.Series[0].Points.AddXY(rent.DateStart, rent.DateEnd);
                }
        }

        private void Next(Control nextControl = null)
        {
            if (nextControl != null)
                SetPageContentPanel(newRentPageContentPanel, nextControl);
        }

        private void OnActionCompleted(Rent theRent)
        {
            if (theRent == null) return;
            pageContentNavigator.SelectedPage = rentsPage;
            for (var i = 0; i < rentDataGridView.RowCount; i++)
            {
                var rent = (Rent) rentDataGridView.Rows[i].DataBoundItem;

                if (rent.RentId != theRent.RentId) continue;

                rentDataGridView.ClearSelection();
                rentDataGridView.Rows[i].Selected = true;
                return;
            }
        }

        private void RefreshDataGridView()
        {
            rentBindingSource.DataSource = _unitOfWork.Rents.GetAll().ToList();
        }

        private void RentsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || rentDataGridView.Rows[e.RowIndex].DataBoundItem == null) return;

            var row = rentDataGridView.Rows[e.RowIndex];
            row.HeaderCell.Value = $"{row.Index + 1}";

            var rent = (Rent) rentDataGridView.Rows[e.RowIndex].DataBoundItem;

            if (rent == null) return;

            if (rentDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.RentId)))
            {
                e.Value = rent.RentId.ToString("D").ToUpper();
                return;
            }

            if (rentDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.Client)))
            {
                e.Value = rent.Client.FullName;
                return;
            }

            if (rentDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.Car)))
            {
                e.Value = rent.Car.Name;
                return;
            }

            if (rentDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.ManageBy)))
            {
                e.Value = rent.ManageBy.FullName;
                return;
            }

            if (rentDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.Bill)))
            {
                e.Value = rent.Bill != null ? rent.Bill.BillNumber.ToString("D").ToUpper() : string.Empty;

                return;
            }

            if (rentDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.State)))
            {
                e.Value = rent.State.ToString();

                return;
            }

            if (rentDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.DateStart)))
            {
                e.Value = rent.DateStart.ToString("dd/MM/yyyy");
                return;
            }

            if (rentDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.DateEnd)))
            {
                e.Value = rent.DateEnd != null ? rent.DateStart.ToString("dd/MM/yyyy") : string.Empty;
                return;
            }

            if (rentDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.NumberOfDays)))
                e.Value = rent.NumberOfDays.ToString("N0");
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search(searchTextBox.Text.Trim());
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Trim() == _searchTextBoxDefaultText)
                searchTextBox.Text = string.Empty;
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Trim() == string.Empty)
                searchTextBox.Text = _searchTextBoxDefaultText;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search(searchTextBox.Text.Trim());
        }

        private void PageContentNavigator_Selected(object sender, KryptonPageEventArgs e)
        {
            if (e.Item == rentsPage)
                RefreshDataGridView();

            if (e.Item == newRentPage)
                SetPageContentPanel(newRentPageContentPanel,
                    new RentUserControl(FormMode.AddNew, null, OnActionCompleted, Next));
        }

        private void RentDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex > rentDataGridView.RowCount)
                return;

            var rent = (Rent) rentDataGridView.Rows[e.RowIndex].DataBoundItem;
            pageContentNavigator.SelectedPage = viewRentPage;
            ViewRent(rent);
        }

        private void ViewRent(Rent rent)
        {
            SetPageContentPanel(viewRentContenPanel, new RentUserControl(FormMode.View, rent, OnActionCompleted));
            SetPageContentPanel(viewRentBillContenPanel,
                new RentBillUserControl(FormMode.View, rent, OnActionCompleted));
        }

        private void RefreshDataGridViewButton_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void AddNewRentButton_Click(object sender, EventArgs e)
        {
            pageContentNavigator.SelectedPage = newRentPage;
        }
    }
}