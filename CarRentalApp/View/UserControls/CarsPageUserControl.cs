using System;
using System.Windows.Forms;

namespace CarRentalApp.View.UserControls
{
    public partial class CarsPageUserControl : UserControl
    {
        private readonly string _searchTextBoxDefaultText;
        public CarsPageUserControl()
        {
            InitializeComponent();
            _searchTextBoxDefaultText = searchTextBox.Text;
            PopulateDataGridView();
        }
        private void PopulateDataGridView()
        {
            carsDataGrid.Rows.Clear();
            for (int i = 1; i <= 50; i++)
            {
                carsDataGrid.Rows.Add(i, "Super Cars", "BF-0335P", "Hummer", 1111, " The best you can find");
                carsDataGrid.DisplayedRowCount(true);

            }
        }



        /*****************************************
     /        Events handlers                 /
     ****************************************/

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == _searchTextBoxDefaultText)
            {
                searchTextBox.Text = string.Empty;
            }
        }
        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Trim() == string.Empty)
            {
                searchTextBox.Text = _searchTextBoxDefaultText;
            }

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
           
        }

        private void RefreshDataGrid_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();

        }
    }
}
