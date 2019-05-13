using System;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.Core.Utils;
using CarRentalApp.View.UserControls.Components;

namespace CarRentalApp.View.Forms
{
    public partial class UserForm : Form
    {
        private readonly Action<User> _onCloseCallBack;
        private  User _user;
        public UserForm(FormMode mode, Action<User> onCloseCallBack, User user=null)
        {
            _onCloseCallBack = onCloseCallBack;
            InitializeComponent();

            formContentPanel.Controls.Clear();
            var userUserControl = new UserUserControl(mode,Close,user) {Dock = DockStyle.Fill};
            formContentPanel.Controls.Add(userUserControl);

        }

        private void Close(User theUser)
        {
            if (theUser != null)
            {
                
                _user= theUser;

            }
            Close();

        }

        private void UserForm_Load(object sender, System.EventArgs e)
        {
           
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _onCloseCallBack(_user);

        }
    }
}
