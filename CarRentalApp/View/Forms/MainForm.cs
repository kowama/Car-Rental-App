using System;
using System.Globalization;
using System.Windows.Forms;
using CarRentalApp.View.UserControls;

namespace CarRentalApp.View.Forms
{
    public partial class MainForm : Form
    {
        private readonly int _leftPanelExtendedWidth = 220;
        private readonly int _leftPanelCollapsedWidth = 62;
        private bool _isCollapsed;

        public MainForm()
        {
            InitializeComponent();
            _isCollapsed = false;
            datetimeTimer.Start();
            SetPageToContentPanel(new HomePageUserControl());

        }

        private void MoveSidePanel(Control control)
        {
            sidePanel.Top = control.Top;
            sidePanel.Height = control.Height;
        }

        private void SetPageToContentPanel(Control page)
        {
            page.Dock = DockStyle.Fill;
            contentPannel.Controls.Clear();
            contentPannel.Controls.Add(page);

        }

        /*****************************************
       /        Events handlers                 /
       ****************************************/
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int step = 20;

            if (_isCollapsed)
            {
                leftPanel.Width += step;
                if (leftPanel.Width > _leftPanelExtendedWidth)
                {
                    menuTimer.Stop();
                    _isCollapsed = false;
                    userInfoPanel.Visible = true;
                    datetimeLabel.Visible = true;
                    Refresh();

                }
            }
            else
            {
                leftPanel.Width -= step;
                userInfoPanel.Visible = false;
                datetimeLabel.Visible = false;
                if (leftPanel.Width < _leftPanelCollapsedWidth)
                {
                    menuTimer.Stop();
                    _isCollapsed = true;
                    Refresh();
                }

            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            menuTimer.Start();
        }

        private void DatetimeTimer_Tick(object sender, EventArgs e)
        {
            datetimeLabel.Text = DateTime.Now.ToString(CultureInfo.InvariantCulture);
        }

        private void HomeMenuButton_Click(object sender, EventArgs e)
        {
            SetPageToContentPanel(new HomePageUserControl());
            MoveSidePanel(homeMenuButton);
        }

        private void RentsMenuButton_Click(object sender, EventArgs e)
        {
            SetPageToContentPanel(new RentsPageUserControl());
            MoveSidePanel(rentsMenuButton);
        }
        private void BillsMenuButton_Click(object sender, EventArgs e)
        {
            SetPageToContentPanel(new BillsPageUserControl());
            MoveSidePanel(billsMenuButton);
        }

        private void CarsMenuButton_Click(object sender, EventArgs e)
        {
            SetPageToContentPanel(new CarsPageUserControl());
            MoveSidePanel(carsMenuButton);
        }

        private void ClientsMenuButton_Click(object sender, EventArgs e)
        {
            SetPageToContentPanel(new ClientsPageUserControl());
            MoveSidePanel(clientsMenuButton);
        }

        private void UsersMenuButton_Click(object sender, EventArgs e)
        {
            SetPageToContentPanel(new UsersPageUserControl());
            MoveSidePanel(usersMenuButton);
        }

        private void SettingsMenuButton_Click(object sender, EventArgs e)
        {
            SetPageToContentPanel(new SettingsPageUserControl());
            MoveSidePanel(settingsMenuButton);
        }
    }
}
