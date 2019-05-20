using System;
using System.Linq;
using System.Windows.Forms;
using CarRentalApp.Core.Utils;
using CarRentalApp.View.UserControls.Components;

namespace CarRentalApp.View.UserControls
{
    public partial class SettingsPageUserControl : UserControl
    {
        public SettingsPageUserControl()
        {
            InitializeComponent();
        }

        private void UpdateChartUi()
        {
            myRentsCountLabel.Text = Program.CurrentUser.Rents.Count.ToString("N0");
            var amounts = Program.CurrentUser.Rents.Select(r => r.Bill).Where(b => b != null).Sum(b => b.Amount);
            myRentsIncomeLabel.Text = $@"{amounts:N2} MAD";
            myRentsCountLabel.MinimumSize = myRentsIncomeLabel.Size;
        }

        private void SettingsPageUserControl_Load(object sender, EventArgs e)
        {
            profilePanel.Controls.Clear();
            profilePanel.Controls.Add(new UserUserControl(FormMode.View, Program.CurrentUser));
            UpdateChartUi();

        }
    }
}