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

        private void SettingsPageUserControl_Load(object sender, System.EventArgs e)
        {
            profilePanel.Controls.Clear();
            profilePanel.Controls.Add(new UserUserControl(FormMode.View,Program.CurrentUser));
        }
    }
}
