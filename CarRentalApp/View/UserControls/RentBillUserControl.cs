using System;
using System.Windows.Forms;
using CarRentalApp.Persistence;

namespace CarRentalApp.View.UserControls
{
    public partial class RentBillUserControl : UserControl
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly Action<Control> _next;
        public RentBillUserControl(UnitOfWork unitOfWork, Action<Control> next)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _next = next;
        }

        private void BackButtonLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _next(new RentUserControl(_unitOfWork,_next));
        }

        private void ValidateButton_Click(object sender, EventArgs e)
        {
            _next(new RentUserControl(_unitOfWork, _next));
        }
    }
}
