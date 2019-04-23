using System;
using System.Globalization;
using System.Windows.Forms;

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
        }

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
    }
}
