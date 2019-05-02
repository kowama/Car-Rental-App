using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.Core.Utils;
using CarRentalApp.Persistence;
using CarRentalApp.Properties;
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

        private void RefreshDataGridView()
        {
            var clients = _unitOfWork.Clients.GetAll().ToList();
            clientBindingSource.DataSource = clients;

        }

        private void Search(string keyWord)
        {
            var clients = _unitOfWork.Clients.GetAll().ToList();
            var filteredUsers = clients;

            if (!(keyWord == string.Empty || keyWord == _searchTextBoxDefaultText))
            {
                filteredUsers = clients.FindAll(c =>
                    c.FirstName.Contains(keyWord, StringComparison.OrdinalIgnoreCase)
                    || c.LastName.Contains(keyWord, StringComparison.OrdinalIgnoreCase)
                    || c.Cin.Contains(keyWord, StringComparison.OrdinalIgnoreCase)
                    || c.Email.Contains(keyWord, StringComparison.OrdinalIgnoreCase)
                    || c.Phone.Contains(keyWord, StringComparison.OrdinalIgnoreCase)
                    || c.Address.Contains(keyWord, StringComparison.OrdinalIgnoreCase)
                );
            }

            clientsDataGrid.DataSource = filteredUsers.ToList();
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
            RefreshDataGridView();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var selectedRowCount =
                clientsDataGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount <= 0) return;

            var clients = new List<Client>() ;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (var i = selectedRowCount - 1; i >= 0; i--)
            {
                sb.Append(clientsDataGrid.SelectedRows[i].Index + 1);
                sb.Append(" ");
                var client = (Client) clientsDataGrid.SelectedRows[i].DataBoundItem;
                clients.Add(client);
                sb.Append(client.Resume());
                sb.Append(Environment.NewLine);
            }

            sb.Append("Total: " + selectedRowCount);
            var dialogResult = MessageBox.Show(sb.ToString(), Resources.client_delete_confirm,MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult != DialogResult.Yes) return;
            _unitOfWork.Clients.RemoveRange(clients);
            _unitOfWork.Complete();
            RefreshDataGridView();
        }

        private void ClientsPageUserControl_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search(searchTextBox.Text);

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

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search(searchTextBox.Text.Trim());
        }
    }
}
