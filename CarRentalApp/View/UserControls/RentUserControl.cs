using System;
using System.Linq;
using System.Windows.Forms;
using CarRentalApp.Persistence;

namespace CarRentalApp.View.UserControls
{
    public partial class RentUserControl : UserControl
    {
        private readonly UnitOfWork _unitOfWork;
        public RentUserControl(UnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;

        }

        private void RefreshDataBind()
        {
            clientDropDown.items =  _unitOfWork.Clients.GetAll().OrderBy(c=>c.FirstName).Select(c => c.Resume()).ToArray();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RefreshDataBind();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

        }
    }
}
