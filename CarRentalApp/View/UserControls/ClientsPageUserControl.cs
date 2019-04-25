using System;
using System.Windows.Forms;
using CarRentalApp.View.Forms;

namespace CarRentalApp.View.UserControls
{
    public partial class ClientsPageUserControl : UserControl
    {
        private readonly string _searchTextBoxDefaultText;
        public ClientsPageUserControl()
        {
            InitializeComponent();
            _searchTextBoxDefaultText = searchTextBox.Text.Trim();
        }

        private void PopulateDataGridView()
        {
           
        }



        /*****************************************
     /        Events handlers                 /
     ****************************************/

        private void AddNewClientButton_Click(object sender, EventArgs e)
        {
            var addNewClientForm = new AddClientForm();
            addNewClientForm.Show();
            
        }
        private void RefreshDataGridButton_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
        }
        private void ClientsPageUserControl_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
           

        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Trim() == _searchTextBoxDefaultText)
            {
                searchTextBox.Text = string.Empty;
            }
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Trim() == string.Empty)
            {
                searchTextBox.Text = _searchTextBoxDefaultText;
            }
        }

        private void clientsDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in clientsDataGrid.Rows)
                row.HeaderCell.Value = (row.Index + 1).ToString();

        }
    }
}
