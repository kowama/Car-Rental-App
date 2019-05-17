using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CarRentalApp.Core.domain;
using CarRentalApp.Core.Utils;
using CarRentalApp.Persistence;
using CarRentalApp.Properties;

namespace CarRentalApp.View.Forms
{
    public partial class ClassificationForm : Form
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly Point _firstControlLocation = new Point(31, 252);
        private readonly Action<Classification> _onCloseCallBack;
        private Classification _classification;
        private FormMode _mode;
        private bool _refreshParent;

        public ClassificationForm(FormMode mode, Action<Classification> onCloseCallBack,

            Classification classification = null)
        {
            InitializeComponent();
            _unitOfWork = UnitOfWork.Instance;
            _mode = mode;
            _onCloseCallBack = onCloseCallBack;
            _classification = classification ?? new Classification();
        }

        private void OnValidating(string message, bool error = true)
        {
            validationLabel.ForeColor = !error ? Color.ForestGreen : Color.Red;
            validationLabel.Text = message;
            validationLabel.Visible = true;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(classificationNameTextBox.Text))
            {
                OnValidating("Name not valid");
                return false;
            }

            if (classificationDescriptionTextBox.Text.Trim().Length < 8)
            {
                OnValidating("Description may be a least 8 chars");
                return false;
            }


            return true;
        }

        private bool ValidateInputsToClassification()
        {
            if (!ValidateInputs()) return false;

            _classification.Name = classificationNameTextBox.Text.Trim();
            _classification.Description = classificationDescriptionTextBox.Text.Trim();
            return true;
        }
        private void Reset()
        {
            _mode = FormMode.AddNew;
            UpdateControlsUi();
            _classification = new Classification();
            UpdateClassificationInfoUi();
            validationLabel.Visible = true;
        }


        private void RefreshDataGridView()
        {
            classificationBindingSource.DataSource = _unitOfWork.Classifications.GetAll().ToList();
        }
        private void UpdateControlsUi()
        {
            validationLabel.Visible = false;

            switch (_mode)
            {
                case FormMode.View:
                    editButton.Visible = true;
                    editButton.Location = _firstControlLocation;
                    saveButton.Visible = false;
                    cancelEditButton.Visible = false;
                    break;

                case FormMode.Edit:
                    saveButton.Visible = true;
                    saveButton.Location = _firstControlLocation;
                    cancelEditButton.Visible = true;
                    editButton.Visible = false;
                    break;

                case FormMode.AddNew:
                    saveButton.Visible = true;
                    saveButton.Location = _firstControlLocation;
                    cancelEditButton.Visible = false;
                    editButton.Visible = false;
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            var isEnabled = _mode != FormMode.View;
            classificationNameTextBox.Enabled = isEnabled;
            classificationDescriptionTextBox.Enabled = isEnabled;
        }

        private void UpdateClassificationInfoUi()
        {
            classificationNameTextBox.Text = _classification.Name ?? string.Empty;
            classificationDescriptionTextBox.Text = _classification.Description ?? string.Empty;
        }

        private void ClassificationForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
            UpdateControlsUi();
            if(_mode != FormMode.AddNew)
                UpdateClassificationInfoUi();
        }
     
        private void RefreshDataGridViewButton_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputsToClassification()) return;

            switch (_mode)
            {
                case FormMode.AddNew:
                    try
                    {
                        _unitOfWork.Classifications.Add(_classification);
                        _unitOfWork.Complete();
                        _refreshParent = true;
                        RefreshDataGridView();
                        OnValidating("Successfully saved !", false);
                        Reset();
                    }
                    catch (FormattedDbEntityValidationException exception)
                    {
                        OnValidating(exception.Message);
                    }

                    break;
                case FormMode.Edit:
                    try
                    {
                        _unitOfWork.Complete();
                        _refreshParent = true;
                        RefreshDataGridView();
                        OnValidating("Successfully updated !", false);
                        Reset();
                    }
                    catch (FormattedDbEntityValidationException exception)
                    {
                        OnValidating(exception.Message);
                    }

                    break;
                case FormMode.View:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

           
       
           
        }
       
        private void ClassificationDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || classificationDataGridView.Rows[e.RowIndex].DataBoundItem == null)
                return;
            var classification = (Classification) classificationDataGridView.Rows[e.RowIndex].DataBoundItem;
            _classification = classification;
            _mode = FormMode.View;
            UpdateControlsUi();
            UpdateClassificationInfoUi();
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            _mode = FormMode.Edit;
            UpdateControlsUi();
        }

        private void CancelEditButton_Click(object sender, EventArgs e)
        {
            _mode = FormMode.View;
            UpdateControlsUi();
            UpdateClassificationInfoUi();
        }

        private void ClassificationDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var classification = (Classification) e.Row.DataBoundItem;

            var count = classification.Cars.Count;
            if (count > 0)
            {
                MessageBox.Show(string.Format(Resources.UserDeletingRow_Classification_0_have_1_delete_them_first, classification.Name, count),
                    Resources.Unauthorized_delete_action
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }

            var dialogResult = MessageBox.Show(
                string.Format(Resources.UserDeletingRow_0_1_will_be_deleted, nameof(Classification),
                    classification.Name),
                string.Format(Resources.UserDeletingRow__0__delete_confirm, nameof(Classification)),
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dialogResult != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }

            _unitOfWork.Classifications.Remove(classification);
            _unitOfWork.Complete();
        }

        private void ClassificationDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            RefreshDataGridView();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClassificationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _onCloseCallBack(_refreshParent ? _classification : null);
        }


        
    }
}