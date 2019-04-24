using System;
using System.Windows.Forms;
using CarRentalApp.View.Forms;

namespace CarRentalApp.View.UserControls
{
    public partial class ClientsPageUserControl : UserControl
    {
        public ClientsPageUserControl()
        {
            InitializeComponent();
        }

        private void PopulateDataGridView()
        {
            for (int i = 0; i < 100; i++)
            {
                clientsDataGrid.Rows.Add(new Object[]
                {
                    i.ToString(),
                    "John",
                    "Wick",
                    "L00335P",
                    "john.wick@mail.com",
                    "0633553543",
                    " 6 Rue Ch E Paris"
                });
                clientsDataGrid.DisplayedRowCount(true);

            }
        }



        /*****************************************
     /        Events handlers                 /
     ****************************************/

        private void AddNewClientButton_Click(object sender, EventArgs e)
        {
            var addNewClientForm = new AddClientForm();
            addNewClientForm.Show();
            
        }

        private void ClientsPageUserControl_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
    }
}
