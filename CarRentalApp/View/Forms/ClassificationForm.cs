using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.Persistence;
using CarRentalApp.Properties;

namespace CarRentalApp.View.Forms
{
    public partial class ClassificationForm : Form
    {
        private readonly UnitOfWork _unitOfWork;

        public ClassificationForm()
        {
            InitializeComponent();
            _unitOfWork = UnitOfWork.Instance;
        }

        private void OnValidation(string message,bool error = true)
        {
            validationLabel.ForeColor = !error ? Color.ForestGreen : Color.Red;
            validationLabel.Text = message;
            validationLabel.Visible = true;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(newClassificationNameTextBox.Text))
            {
                OnValidation("Name not valid");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(newClassificationDescriptionTextBox.Text)) return true;

            OnValidation("Description not valid");

            return false;

        }

        private void RefreshDataGridView()
        {
            classificationBindingSource.DataSource = _unitOfWork.Classifications.GetAll().ToList();
        }
        private void ClassificationForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void NewClassificationSaveButton_Click(object sender, EventArgs e)
        {
            if(!ValidateInput()) return;
            try
            {
                _unitOfWork.Classifications.Add(new Classification
                {
                    Name = newClassificationNameTextBox.Text,
                    Description = newClassificationDescriptionTextBox.Text
                });
                _unitOfWork.Complete();
                OnValidation("Successfully saved",false);
                RefreshDataGridView();
            }
            catch (FormattedDbEntityValidationException exception)
            {
                OnValidation(exception.Message);
            }
            
        }
        private void RefreshDataGrid_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (classificationDataGridView.SelectedRows.Count == 0) return;

            var classification = (Classification)classificationDataGridView.SelectedRows[0].DataBoundItem;
            var text = new StringBuilder();
            text.Append($"{classification.Id}, {classification.Name}, {classification.Description}");

            var dialogResult = MessageBox.Show(text.ToString(),Resources.ClassificationForm_DeleteButton_Click_Are_you_Sure_to_Delete , MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult != DialogResult.Yes) return;

            _unitOfWork.Classifications.Remove(classification);
            _unitOfWork.Complete();
            RefreshDataGridView();
        }
    }
}
