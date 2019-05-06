using System;
using System.Drawing;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.Persistence;

namespace CarRentalApp.View.UserControls
{
    public partial class RentBillUserControl : UserControl
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly Action<Control> _next;
        private readonly Rent _rent;

        public RentBillUserControl(UnitOfWork unitOfWork, Action<Control> next, Rent rent)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _next = next;
            _rent = rent;
        }

        private void GenerateBill()
        {
            if (_rent != null && _rent.Bill == null)
            {
                _rent.Bill = new Bill
                {
                    BillNumber = Guid.NewGuid()
                };
            }
        }

        private void UpdateUi()
        {
            if (_rent.Bill == null) GenerateBill();
            if (_rent.Bill == null) return;
            billNumLabel.Text = _rent.Bill.BillNumber.ToString("D").ToUpper();
            billDetailsTextBox.Text = _rent.Bill.Details;
//          billDateDatePicker = 
            billClientNameLabel.Text = _rent.Client.FullName;
            billManageByLabel.Text = _rent.ManageBy.FullName;
            billAmountNumericUpDown.Value = _rent.Bill.Amount;
        }

        private void OnValidating(string message, bool error = true)
        {
            validationLabel.ForeColor = !error ? Color.ForestGreen : Color.Red;
            validationLabel.Text = message;
            validationLabel.Visible = true;
        }

        private bool ValidInputsToBill()
        {

            _rent.Bill.Amount = billAmountNumericUpDown.Value;
            _rent.Bill.Details = billDetailsTextBox.Text;
            _rent.Bill.Date = billDateDatePicker.Value;

            return true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateUi();
        }
        
        private void BackButtonLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _rent.Bill = null;
            _next(new RentUserControl(_unitOfWork,_next,_rent));
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(!ValidInputsToBill()) return;
            try
            {
                _unitOfWork.Rents.Add(_rent);
                _unitOfWork.Complete();
                _next(new RentUserControl(_unitOfWork, _next,_rent));
            }
            catch (FormattedDbEntityValidationException ex)
            {
                OnValidating(ex.Message);
            }
            
        }


    }
}
