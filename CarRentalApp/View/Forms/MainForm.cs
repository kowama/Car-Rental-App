using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.Persistence;
using CarRentalApp.View.UserControls;

namespace CarRentalApp.View.Forms
{
    public partial class MainForm : Form
    {
        private const int LeftPanelExtendedWidth = 220;
        private const int LeftPanelCollapsedWidth = 62;
        private bool _isCollapsed;

        public MainForm()
        {
            InitializeComponent();
            _isCollapsed = false;
            datetimeTimer.Start();
            SetPageToContentPanel(new HomePageUserControl());
            var userIsAdmin = Program.CurrentUser.HasRole(RoleName.Administrator);
            usersMenuButton.Visible = userIsAdmin;
            appUserNameLabel.Text = Program.CurrentUser.Username;
            appUserRoleLabel.Text = userIsAdmin ? RoleName.Administrator: RoleName.Manager;

        }

        private void UpdateAppUi()
        {
            appUserRoleLabel.Text = Program.CurrentUser.Username;
            appUserRoleLabel.Text = Program.CurrentUser.Roles.First().Name;
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateAppUi();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            const int step = 20;

            if (_isCollapsed)
            {
                leftPanel.Width += step;
                if (leftPanel.Width > LeftPanelExtendedWidth)
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
                if (leftPanel.Width < LeftPanelCollapsedWidth)
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnitOfWork.Instance.Dispose();
            Application.Exit();
        }

       
    }
}