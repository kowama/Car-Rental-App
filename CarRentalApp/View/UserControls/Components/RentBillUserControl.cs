using System;
using System.Drawing;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.Core.Utils;
using CarRentalApp.Persistence;

namespace CarRentalApp.View.UserControls
{
    public partial class RentBillUserControl : UserControl
    {
        private readonly Point _firstControlLocation = new Point(50, 450);
        private readonly Action<Control> _next;
        private readonly Action<Rent> _onActionCompleted;
        private readonly Rent _rent;
        private readonly Point _thirdControlLocation = new Point(316, 450);
        private readonly UnitOfWork _unitOfWork;
        private FormMode _mode;


        public RentBillUserControl(FormMode mode,Rent rent, Action<Rent> onActionCompleted = null, Action<Control> next = null)
        {
            InitializeComponent();
            _unitOfWork = UnitOfWork.Instance;
            _next = next;
            _rent = rent;
            _onActionCompleted = onActionCompleted;
            _mode = mode;
        }


        private void GenerateBill()
        {
            if (_rent != null && _rent.Bill == null)
                _rent.Bill = new Bill
                {
                    BillNumber = Guid.NewGuid(),
                    Amount = Math.Round((decimal) _rent.NumberOfDays * _rent.Car.PricePerDay, 2)
                };
        }

        private void UpdateControlsUi(bool saveCompleted = false)
        {
            switch (_mode)
            {
                case FormMode.View:
                    editButton.Visible = true;
                    editButton.Location = _firstControlLocation;
                    finishedButton.Visible = saveCompleted;
                    finishedButton.Location = _thirdControlLocation;

                    cancelEditButton.Visible = false;
                    saveButton.Visible = false;
                    validationLabel.Visible = false;
                    BackLinkLabelButton.Visible = false;


                    billcomputedPriceLabel.Visible = false;

                    billDateTimePicker.Enabled = false;
                    billDetailsTextBox.Enabled = false;
                    BillAmountNumericUpDown.Enabled = false;

                    break;
                case FormMode.Edit:
                    cancelEditButton.Visible = true;
                    cancelEditButton.Location = _thirdControlLocation;
                    saveButton.Visible = true;
                    saveButton.Location = _firstControlLocation;


                    billcomputedPriceLabel.Visible = true;
                    editButton.Visible = false;
                    validationLabel.Visible = false;
                    BackLinkLabelButton.Visible = false;
                    finishedButton.Visible = false;

                    billDateTimePicker.Enabled = true;
                    billDetailsTextBox.Enabled = true;
                    BillAmountNumericUpDown.Enabled = true;

                    break;
                case FormMode.AddNew:

                    BackLinkLabelButton.Visible = true;
                    BackLinkLabelButton.Location = _firstControlLocation;
                    cancelEditButton.Visible = false;
                    saveButton.Visible = true;
                    saveButton.Location = _thirdControlLocation;

                    billcomputedPriceLabel.Visible = true;
                    editButton.Visible = false;
                    validationLabel.Visible = false;
                    finishedButton.Visible = false;

                    billDateTimePicker.Enabled = true;
                    billDetailsTextBox.Enabled = true;
                    BillAmountNumericUpDown.Enabled = true;
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void UpdateRentBillInfoUi()
        {
            if (_rent.Bill == null) GenerateBill();
            if (_rent.Bill == null) return;
            billNumLabel.Text = _rent.Bill.BillNumber.ToString("D").ToUpper();
            billDetailsTextBox.Text = _rent.Bill.Details;
            billDateTimePicker.Value = _rent.Bill.Date;
            billClientLabel.Text = _rent.Client.FullName;
            billCarLabel.Text = _rent.Car.Name;
            billManagedByLabel.Text = _rent.ManageBy.FullName;
            BillAmountNumericUpDown.Value = _rent.Bill.Amount;

            billcomputedPriceLabel.Text =
                string.Format(
                    $"{_rent.NumberOfDays:N0} * {_rent.Car.PricePerDay:N} = {(decimal) _rent.NumberOfDays * _rent.Car.PricePerDay:N} (n * price per day)");
        }

        private void OnValidating(string message, bool error = true)
        {
            validationLabel.ForeColor = !error ? Color.ForestGreen : Color.Red;
            validationLabel.Text = message;
            validationLabel.Visible = true;
        }

        private bool ValidInputsToBill()
        {
            _rent.Bill.Amount = BillAmountNumericUpDown.Value;
            _rent.Bill.Details = billDetailsTextBox.Text;
            _rent.Bill.Date = billDateTimePicker.Value;

            return true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateRentBillInfoUi();
            UpdateControlsUi();
        }

        private void BackButtonLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _rent.Bill = null;
            _next(new RentUserControl(FormMode.AddNew,_rent,_onActionCompleted, _next,true));
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!ValidInputsToBill()) return;
            switch (_mode)
            {
                case FormMode.AddNew:
                    try
                    {
                        _unitOfWork.Rents.Add(_rent);
                        _unitOfWork.Complete();
                        _mode = FormMode.View;
                        UpdateControlsUi(true);
                        OnValidating("Successfully saved !", false);
                    }
                    catch (FormattedDbEntityValidationException ex)
                    {
                        OnValidating(ex.Message);
                    }

                    break;
                case FormMode.Edit:
                    try
                    {
                        _unitOfWork.Complete();
                        _mode = FormMode.View;
                        UpdateControlsUi(true);
                        OnValidating("Successfully updated !", false);
                    }
                    catch (FormattedDbEntityValidationException ex)
                    {
                        OnValidating(ex.Message);
                    }

                    break;
                case FormMode.View:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void CancelEditButton_Click(object sender, EventArgs e)
        {
            _mode = FormMode.View;
            UpdateRentBillInfoUi();
            UpdateControlsUi();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            _mode = FormMode.Edit;
            UpdateControlsUi();
        }


        private void RentBillUserControl_Load(object sender, EventArgs e)
        {
        }

        private void FinishedButton_Click(object sender, EventArgs e)
        {
            _onActionCompleted(_rent);

        }
    }
}