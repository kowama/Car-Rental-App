using System;
using System.Linq;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.Core.Utils;
using CarRentalApp.Persistence;
using ComponentFactory.Krypton.Navigator;

namespace CarRentalApp.View.UserControls
{
    public partial class RentsPageUserControl : UserControl
    {
        private readonly UnitOfWork _unitOfWork;

        public RentsPageUserControl()
        {
            InitializeComponent();
            _unitOfWork = UnitOfWork.Instance;
            pageContentNavigator.SelectedPage = newRentPage;
        }

        private static void SetPageContentPanel(Control control, Control page)
        {
            page.Dock = DockStyle.Fill;
            control.Controls.Clear();
            control.Controls.Add(page);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetPageContentPanel(newRentPageContentPanel, new RentUserControl(FormMode.AddNew,null, OnActionCompleted, Next));
        }

        private void Next(Control nextControl = null)
        {
            if (nextControl != null)
                SetPageContentPanel(newRentPageContentPanel, nextControl);
        }

        private void OnActionCompleted(Rent theRent)
        {
            if(theRent == null) return;
            pageContentNavigator.SelectedPage = rentsPage;

            //mark
            
        }

        private void RefreshDataGridView()
        {
            rentBindingSource.DataSource = _unitOfWork.Rents.GetAll().ToList();
        }

        private void RentsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (rentDataGridView.Rows[e.RowIndex].DataBoundItem == null) return;

            var row = rentDataGridView.Rows[e.RowIndex];
            row.HeaderCell.Value = $"{row.Index + 1}";

            var rent = (Rent)rentDataGridView.Rows[e.RowIndex].DataBoundItem;

            if (rent == null) return;

            if (rentDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.RentId)))
                e.Value = rent.RentId.ToString("D").ToUpper();

            if (rentDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.Client)))
                e.Value = rent.Client.FullName;

            if (rentDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.Car)))
                e.Value = rent.Car.Name;

            if (rentDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.ManageBy)))
                e.Value = rent.ManageBy.FullName;

            if (rentDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.Bill)))
                e.Value = rent.Bill != null ? rent.Bill.BillNumber.ToString("D").ToUpper() : string.Empty;

            if (rentDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.State)))
                e.Value = rent.State.ToString();

            if (rentDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.DateStart)))
                e.Value = rent.DateStart.ToString("dd/MM/yyyy");

            if (rentDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.DateEnd)))
                e.Value = rent.DateEnd != null ? rent.DateStart.ToString("dd/MM/yyyy") : string.Empty;
            if (rentDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.NumberOfDays)))
                e.Value = rent.NumberOfDays.ToString("N0");
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
        }

        private void pageContentNavigator_Selected(object sender, KryptonPageEventArgs e)
        {
            if (e.Item == rentsPage)
                RefreshDataGridView();

            if(e.Item == newRentPage)
                SetPageContentPanel(newRentPageContentPanel, new RentUserControl(FormMode.AddNew, null, OnActionCompleted, Next));


        }

        private void AddNewCarButton_Click(object sender, EventArgs e)
        {
        }
        private void RentDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.RowIndex > rentDataGridView.RowCount)
                return;

            var rent = (Rent)rentDataGridView.Rows[e.RowIndex].DataBoundItem;
            pageContentNavigator.SelectedPage = viewRentPage;
            ViewRent(rent);
        }

        private void ViewRent(Rent rent)
        {
            SetPageContentPanel(viewRentContenPanel, new RentUserControl(FormMode.View,rent ,OnActionCompleted));
            SetPageContentPanel(viewRentBillContenPanel, new RentBillUserControl(FormMode.View,rent, OnActionCompleted));
        }

        private void RefreshDataGridViewButton_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}