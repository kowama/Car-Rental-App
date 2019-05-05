using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        private void Search(string keyword)
        {
            if (keyword == _searchTextBoxDefaultText)
                keyword = string.Empty;

            var clients = _unitOfWork.Clients.GetAll().ToList();
            var all = seachFilterDropdown.selectedIndex == seachFilterDropdown.Items.Count - 1;
            var filterBy = seachFilterDropdown.selectedValue;

            var filteredUsers = clients.FindAll(c =>
                c.FirstName.Contains(keyword, StringComparison.OrdinalIgnoreCase) &&
                (filterBy == firstNameDataGridViewTextBoxColumn.HeaderText || all)
                || c.LastName.Contains(keyword, StringComparison.OrdinalIgnoreCase) &&
                (filterBy == lastNameDataGridViewTextBoxColumn.HeaderText || all)
                || c.Cin.Contains(keyword, StringComparison.OrdinalIgnoreCase) &&
                (filterBy == cinDataGridViewTextBoxColumn.HeaderText || all)
                || c.Email.Contains(keyword, StringComparison.OrdinalIgnoreCase) &&
                (filterBy == emailDataGridViewTextBoxColumn.HeaderText || all)
                || c.Phone.Contains(keyword, StringComparison.OrdinalIgnoreCase) &&
                (filterBy == phoneDataGridViewTextBoxColumn.HeaderText || all)
                || c.DriverLicense.Contains(keyword, StringComparison.OrdinalIgnoreCase) &&
                (filterBy == driverLicenseDataGridViewTextBoxColumn.HeaderText || all)
                || c.Address.Contains(keyword, StringComparison.OrdinalIgnoreCase) &&
                (filterBy == addressDataGridViewTextBoxColumn.HeaderText || all)
            );

            clientsDataGridView.DataSource = filteredUsers.ToList();
        }

        protected override void OnLoad(EventArgs e)
        {
            RefreshDataGridView();
            seachFilterDropdown.items = new[]
            {
                firstNameDataGridViewTextBoxColumn.HeaderText,
                lastNameDataGridViewTextBoxColumn.HeaderText,
                cinDataGridViewTextBoxColumn.HeaderText,
                driverLicenseDataGridViewTextBoxColumn.HeaderText,
                emailDataGridViewTextBoxColumn.HeaderText,
                phoneDataGridViewTextBoxColumn.HeaderText,
                addressDataGridViewTextBoxColumn.HeaderText,
                "All"
            };
            seachFilterDropdown.selectedIndex = seachFilterDropdown.items.Length - 1;
        }

        private void AddNewClientButton_Click(object sender, EventArgs e)
        {
            var addNewClientForm = new ClientForm();
            addNewClientForm.Show();
        }

        private void RefreshDataGridButton_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var selectedRowCount =
                clientsDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount <= 0) return;

            var clients = new List<Client>();
            var sb = new StringBuilder();
            for (var i = selectedRowCount - 1; i >= 0; i--)
            {
                sb.Append(clientsDataGridView.SelectedRows[i].Index + 1);
                sb.Append(" ");
                var client = (Client) clientsDataGridView.SelectedRows[i].DataBoundItem;
                clients.Add(client);
                sb.Append(client.Resume);
                sb.Append(Environment.NewLine);
            }

            sb.Append("Total: " + selectedRowCount);
            var dialogResult = MessageBox.Show(sb.ToString(), Resources.client_delete_confirm, MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
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
            Search(searchTextBox.Text.Trim());
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Trim() == _searchTextBoxDefaultText) searchTextBox.Text = string.Empty;
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text)) searchTextBox.Text = _searchTextBoxDefaultText;
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search(searchTextBox.Text.Trim());
        }

        private void ClientsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (clientsDataGridView.Rows[e.RowIndex].DataBoundItem == null) return;

            //display row index
            var row = clientsDataGridView.Rows[e.RowIndex];
            row.HeaderCell.Value = $"{row.Index + 1}";
        }
    }
}