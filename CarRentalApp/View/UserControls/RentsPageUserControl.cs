using System;
using System.Linq;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.Persistence;

namespace CarRentalApp.View.UserControls
{
    public partial class RentsPageUserControl : UserControl
    {
        private readonly UnitOfWork _unitOfWork;

        public RentsPageUserControl()
        {
            InitializeComponent();
            _unitOfWork = UnitOfWork.Instance;
        }

        private void SetPageToContentPanel(Control page)
        {
//            page.Dock = DockStyle.Fill;
//            contentPanel.Controls.Clear();
//            contentPanel.Controls.Add(page);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetPageToContentPanel(new RentUserControl(_unitOfWork, Next));
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
        }

        private void Next(Control nextControl = null)
        {
            if (nextControl != null)
                SetPageToContentPanel(nextControl);
        }

        private void RentsTabControl_Selected(object sender, TabControlEventArgs e)
        {
//            if (e.TabPage == rentsTabPage) RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
//            rentBindingSource.DataSource = _unitOfWork.Rents.GetAll().ToList();
        }

        private void RefreshDataGrid_Click(object sender, EventArgs e)
        {
        }

        private void RentsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
//            if (rentsDataGridView.Rows[e.RowIndex].DataBoundItem == null) return;
//
//            var row = rentsDataGridView.Rows[e.RowIndex];
//            row.HeaderCell.Value = $"{row.Index + 1}";
//
//            var rent = (Rent) rentsDataGridView.Rows[e.RowIndex].DataBoundItem;
//
//            if (rent == null) return;
//
//            if (rentsDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.RentId)))
//                e.Value = rent.RentId.ToString("D").ToUpper();
//            if (rentsDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.Client)))
//                e.Value = rent.Client.FullName;
//            if (rentsDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.Car)))
//                e.Value = rent.Car.Name;
//            if (rentsDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.ManageBy)))
//                e.Value = rent.ManageBy.FullName;
//
//            if (rentsDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Rent.Bill)))
//                e.Value = rent.Bill !=null ? rent.Bill.BillNumber.ToString("D").ToUpper() : string.Empty;
        }

        
    }
}