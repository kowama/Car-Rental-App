using System;
using System.Linq;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.Core.Utils;
using CarRentalApp.Persistence;

namespace CarRentalApp.View.UserControls
{
    public partial class BillsPageUserControl : UserControl
    {
        private readonly UnitOfWork _unitOfWork;
        private Bill _bill;

        public BillsPageUserControl()
        {
            InitializeComponent();
            _unitOfWork = UnitOfWork.Instance;
        }

        private void RefreshDataGridView()
        {
            var bills = _unitOfWork.Bills.GetAll().ToList();
            billBindingSource.DataSource = bills;
            selectBillComboBox.DataSource = bills.Select(b => b.BillNumber.ToString("D").ToUpper()).ToList();
        }

        private void BillsPageUserControl_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void BillDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || billDataGridView.Rows[e.RowIndex].DataBoundItem == null) return;

            var row = billDataGridView.Rows[e.RowIndex];
            row.HeaderCell.Value = $"{row.Index + 1}";

            var bill = (Bill) billDataGridView.Rows[e.RowIndex].DataBoundItem;

            if (bill == null) return;

            if (billDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Bill.Rent)))
            {
                e.Value = bill.Rent.RentId.ToString("D").ToUpper();

                return;
            }

            if (billDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Bill.BillNumber)))
            {
                e.Value = bill.BillNumber.ToString("D").ToUpper();
                return;
            }

            if (billDataGridView.Columns[e.ColumnIndex].DataPropertyName.Equals(nameof(Bill.Amount)))
                e.Value = $"{bill.Amount:N0} MAD";
        }

        private void BillDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var bill = (Bill) e.Row.DataBoundItem;

            var rent = bill.Rent;
            rent.Bill = null;
            _unitOfWork.Bills.Remove(bill);
            _unitOfWork.Complete();
        }

        private void BillDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var bill = (Bill) billDataGridView.Rows[e.RowIndex].DataBoundItem;
            _bill = bill;
            DisplaySelectedBill();
        }

        private void DisplaySelectedBill()
        {
            billNumLabel.Text = _bill.BillNumber.ToString("D").ToUpper();
            billRentIdLabel.Text = _bill.Rent.RentId.ToString("D").ToUpper();
            billClientLabel.Text = _bill.Rent.Client.Resume;
            billManagedByLabel.Text = _bill.Rent.ManageBy.FullName;
            billCarLabel.Text = _bill.Rent.Car.Resume;
            billRentDateStartLabel.Text = _bill.Rent.DateStart.ToString("dd/MM/yyyy");
            billRentDateEndLabel.Text = _bill.Rent.DateEnd.ToString("dd/MM/yyyy");
            billAmountLabel.Text = _bill.Amount.ToString("N0");
            billDetailsLabel.Text = _bill.Details;
            billDateLabel.Text = _bill.Date.ToString("dd/MM/yyyy");
        }


        private void BillDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            RefreshDataGridView();
        }
        private void SelectBillComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bill = billBindingSource.OfType<Bill>().ToList()
                .SingleOrDefault(b => b.BillNumber.ToString("D").ToUpper() == selectBillComboBox.Text);
            if (bill == null) return;

            _bill = bill;
            DisplaySelectedBill();
        }
        private void PrintButton_Click(object sender, EventArgs e)
        {
            ExportUtils.ToPdf(_bill);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}