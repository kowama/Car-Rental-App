using System;
using System.Windows.Forms;
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
            page.Dock = DockStyle.Fill;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(page);

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetPageToContentPanel(new RentUserControl(_unitOfWork,Next));

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }
        private void Next(Control nextControl=null)
        {
            if(nextControl != null)
                SetPageToContentPanel(nextControl);
        }
    }
}
