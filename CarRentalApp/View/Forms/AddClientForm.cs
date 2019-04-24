using System;
using System.Windows.Forms;

namespace CarRentalApp.View.Forms
{
    public partial class AddClientForm : Form
    {
        private readonly string _defaultTextPref;
        private readonly string _genericString;

        public AddClientForm()
        {
            InitializeComponent();
            _defaultTextPref = fistnameTextbox.Text.Substring(0,10);
            _genericString = "Please fill the Text Box !";

        }

       
        private void FormTextBox_Enter(object sender, EventArgs e)
        {
            var senderTextBox = (Bunifu.Framework.UI.BunifuMetroTextbox) sender;
            if (senderTextBox.Text.StartsWith(_defaultTextPref))
            {
                senderTextBox.Text = string.Empty;

            }
        }

        private void FormTextBox_Leave(object sender, EventArgs e)
        {
            var senderTextBox = (Bunifu.Framework.UI.BunifuMetroTextbox)sender;
            if (senderTextBox.Text.Trim() == string.Empty)
            {
                senderTextBox.Text = _genericString;

            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

    }
}
