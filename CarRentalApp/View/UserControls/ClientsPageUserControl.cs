using System;
using System.Linq;
using System.Windows.Forms;
using CarRentalApp.Core.Utils;
using CarRentalApp.Persistence;
using CarRentalApp.View.Forms;

namespace CarRentalApp.View.UserControls
{
    public partial class ClientsPageUserControl : UserControl
    {
        private readonly string _searchTextBoxDefaultText;
        private readonly UnitOfWork _unitOfWork;
   
        
        public ClientsPageUserControl()
        {
            InitializeComponent();
            _searchTextBoxDefaultText = searchTextBox.Text.Trim();
            _unitOfWork = new UnitOfWork();
        }

        private void PopulateDataGridView()
        {
            var clients = _unitOfWork.Clients.GetAll().ToList();
            clientBindingSource.DataSource = clients;

        }

        /*****************************************
                  Events handlers                 
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
            string keyWord = searchTextBox.Text;

            var clients = _unitOfWork.Clients.GetAll().ToList();
            var filteredUsers = clients;

            if (!(keyWord == string.Empty || keyWord == _searchTextBoxDefaultText))
            {
                filteredUsers = clients.FindAll(c =>
                        c.FirstName.Contains(keyWord,StringComparison.OrdinalIgnoreCase)
                        || c.LastName.Contains(keyWord,StringComparison.OrdinalIgnoreCase)
                        || c.Cin.Contains(keyWord,StringComparison.OrdinalIgnoreCase)
                        || c.Email.Contains(keyWord, StringComparison.OrdinalIgnoreCase)
                        || c.Phone.Contains(keyWord,StringComparison.OrdinalIgnoreCase)
                        || c.Address.Contains(keyWord,StringComparison.OrdinalIgnoreCase)
                );
            }
            clientsDataGrid.DataSource = filteredUsers.ToList();

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
