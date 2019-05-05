using System;
using System.Linq;
using System.Windows.Forms;
using CarRentalApp.Persistence;

namespace CarRentalApp.View.UserControls
{
    public partial class RentUserControl : UserControl
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly Action<Control> _next;
        public RentUserControl(UnitOfWork unitOfWork, Action<Control> next)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _next = next;
        }

        private void RefreshDataBind()
        {
            var clients = _unitOfWork.Clients.GetAll().OrderBy(c => c.FirstName);
            var cars = _unitOfWork.Cars;
            clientsDropDown.items = clients.Select(c => c.Resume).ToArray();
            carsDropDown.items = cars.GetAll().OrderBy(c => c.Name).Select(c => c.Resume).ToArray();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RefreshDataBind();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            _next(new  RentBillUserControl(_unitOfWork,_next));
        }
    }
}
