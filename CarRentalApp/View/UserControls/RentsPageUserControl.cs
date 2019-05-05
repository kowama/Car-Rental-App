using System;
using System.Windows.Forms;

namespace CarRentalApp.View.UserControls
{
    public partial class RentsPageUserControl : UserControl
    {
        public RentsPageUserControl()
        {
            InitializeComponent();
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
            SetPageToContentPanel(new RentUserControl());

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
