using System.ComponentModel;
using System.Windows.Forms;

namespace CarRentalApp.View.Forms
{
    partial class ClassificationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelEditButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.saveButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.validationLabel = new System.Windows.Forms.Label();
            this.classificationDescriptionTextBox = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.classificationNameTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.classificationDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.closeButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.RefreshDataGridViewButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.editButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classificationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classificationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.cancelEditButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.validationLabel);
            this.panel1.Controls.Add(this.classificationDescriptionTextBox);
            this.panel1.Controls.Add(this.classificationNameTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 290);
            this.panel1.TabIndex = 0;
            // 
            // cancelEditButton
            // 
            this.cancelEditButton.Location = new System.Drawing.Point(202, 252);
            this.cancelEditButton.Name = "cancelEditButton";
            this.cancelEditButton.Size = new System.Drawing.Size(90, 25);
            this.cancelEditButton.TabIndex = 13;
            this.cancelEditButton.Values.Text = "Cancel";
            this.cancelEditButton.Click += new System.EventHandler(this.CancelEditButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(31, 252);
            this.saveButton.Name = "saveButton";
            this.saveButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.saveButton.Size = new System.Drawing.Size(90, 25);
            this.saveButton.TabIndex = 12;
            this.saveButton.Values.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // validationLabel
            // 
            this.validationLabel.AutoSize = true;
            this.validationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validationLabel.ForeColor = System.Drawing.Color.Red;
            this.validationLabel.Location = new System.Drawing.Point(28, 233);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(192, 16);
            this.validationLabel.TabIndex = 11;
            this.validationLabel.Text = "* Informations are not valid";
            this.validationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.validationLabel.UseMnemonic = false;
            this.validationLabel.Visible = false;
            // 
            // classificationDescriptionTextBox
            // 
            this.classificationDescriptionTextBox.Location = new System.Drawing.Point(31, 103);
            this.classificationDescriptionTextBox.MaxLength = 2048;
            this.classificationDescriptionTextBox.Name = "classificationDescriptionTextBox";
            this.classificationDescriptionTextBox.Size = new System.Drawing.Size(262, 127);
            this.classificationDescriptionTextBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classificationDescriptionTextBox.TabIndex = 4;
            this.classificationDescriptionTextBox.Text = "";
            // 
            // classificationNameTextBox
            // 
            this.classificationNameTextBox.Location = new System.Drawing.Point(31, 39);
            this.classificationNameTextBox.Name = "classificationNameTextBox";
            this.classificationNameTextBox.Size = new System.Drawing.Size(262, 22);
            this.classificationNameTextBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classificationNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(28, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // classificationDataGridView
            // 
            this.classificationDataGridView.AllowUserToAddRows = false;
            this.classificationDataGridView.AutoGenerateColumns = false;
            this.classificationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.classificationDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.classificationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classificationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.classificationDataGridView.DataSource = this.classificationBindingSource;
            this.classificationDataGridView.Location = new System.Drawing.Point(12, 343);
            this.classificationDataGridView.MultiSelect = false;
            this.classificationDataGridView.Name = "classificationDataGridView";
            this.classificationDataGridView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.classificationDataGridView.ReadOnly = true;
            this.classificationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.classificationDataGridView.Size = new System.Drawing.Size(387, 231);
            this.classificationDataGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.classificationDataGridView.StateCommon.DataCell.Content.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.classificationDataGridView.StateCommon.DataCell.Content.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.classificationDataGridView.StateCommon.DataCell.Content.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.classificationDataGridView.TabIndex = 1;
            this.classificationDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassificationDataGridView_CellDoubleClick);
            this.classificationDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.ClassificationDataGridView_UserDeletedRow);
            this.classificationDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.ClassificationDataGridView_UserDeletingRow);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(282, 580);
            this.closeButton.Name = "closeButton";
            this.closeButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.closeButton.Size = new System.Drawing.Size(90, 25);
            this.closeButton.TabIndex = 2;
            this.closeButton.Values.Text = "Close";
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // RefreshDataGridViewButton
            // 
            this.RefreshDataGridViewButton.Location = new System.Drawing.Point(321, 308);
            this.RefreshDataGridViewButton.Name = "RefreshDataGridViewButton";
            this.RefreshDataGridViewButton.Size = new System.Drawing.Size(75, 25);
            this.RefreshDataGridViewButton.TabIndex = 6;
            this.RefreshDataGridViewButton.Values.Text = "Refesh";
            this.RefreshDataGridViewButton.Click += new System.EventHandler(this.RefreshDataGridViewButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(56, 295);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(90, 25);
            this.editButton.TabIndex = 13;
            this.editButton.Values.Text = "Edit";
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 68;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 96;
            // 
            // classificationBindingSource
            // 
            this.classificationBindingSource.DataSource = typeof(CarRentalApp.Core.domain.Classification);
            // 
            // ClassificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(408, 613);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.RefreshDataGridViewButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.classificationDataGridView);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClassificationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassificationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClassificationForm_FormClosing);
            this.Load += new System.EventHandler(this.ClassificationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classificationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classificationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView classificationDataGridView;
        private BindingSource classificationBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox classificationNameTextBox;
        private Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox classificationDescriptionTextBox;
        private Label label2;
        private Label validationLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton closeButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton saveButton;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton RefreshDataGridViewButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cancelEditButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton editButton;
    }

}