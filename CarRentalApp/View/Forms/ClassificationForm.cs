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
        private readonly Action<bool> _onCloseCallBack;
        private bool _refreshParent;
        private Classification _classification;

        public ClassificationForm(Action<bool> onCloseCallBack)
        {
            InitializeComponent();
            _unitOfWork = UnitOfWork.Instance;
            _onCloseCallBack = onCloseCallBack;
            _classification = new Classification();
        }

        private void OnValidation(string message,bool error = true)
        {
            validationLabel.ForeColor = !error ? Color.ForestGreen : Color.Red;
            validationLabel.Text = message;
            validationLabel.Visible = true;
        }
       
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(newClassificationNameTextBox.Text))
            {
                OnValidation("Name not valid");
                return false;
            }

            if (string.IsNullOrWhiteSpace(newClassificationDescriptionTextBox.Text))
            {
                OnValidation("Description not valid");
                return false;
            }


            return true;
        }

        private bool ValidateInputsToClassification()
        {
            if (!ValidateInputs()) return false;

            _classification.Name = newClassificationNameTextBox.Text;
            _classification.Description = newClassificationDescriptionTextBox.Text;

            return true;

        }

        private void RefreshDataGridView()
        {
            classificationBindingSource.DataSource = _unitOfWork.Classifications.GetAll().ToList();
        }
        private void Reset()
        {
            _classification = new Classification();
            UpdateUi();
        }
        private void UpdateUi()
        {
            newClassificationNameTextBox.Text = _classification.Name;
            newClassificationDescriptionTextBox.Text = _classification.Description;
        }
      

        private void ClassificationForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
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

        private void ClassificationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _onCloseCallBack(_refreshParent);
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInputsToClassification()) return;
            try
            {
                _unitOfWork.Classifications.Add(_classification);
                _unitOfWork.Complete();
                Reset();
                OnValidation("Successfully saved", false);
                _refreshParent = true;
                RefreshDataGridView();
            }
            catch (FormattedDbEntityValidationException exception)
            {
                OnValidation(exception.Message);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
