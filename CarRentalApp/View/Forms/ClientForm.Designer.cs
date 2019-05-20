using System.ComponentModel;
using System.Windows.Forms;

namespace CarRentalApp.View.Forms
{
    partial class ClientForm
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
            this.detailsRightPanel = new System.Windows.Forms.Panel();
            this.kryptonMonthCalendar1 = new ComponentFactory.Krypton.Toolkit.KryptonMonthCalendar();
            this.fullSizecloseButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label10 = new System.Windows.Forms.Label();
            this.clientRentsCountLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.helpLabel = new System.Windows.Forms.Label();
            this.clientRentsDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.rentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manageByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.formLeftPanel = new System.Windows.Forms.Panel();
            this.clientAddressTextBox = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.normalSizecloseButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.validationLabel = new System.Windows.Forms.Label();
            this.editButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.addMoreButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.CancelEditButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.saveButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.clientPhoneTextBox = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.clientEmailTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.clientDriverLicenseTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.clientCinTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.clientLastNameTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.clientFirstNameTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.detailsRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientRentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).BeginInit();
            this.formLeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // detailsRightPanel
            // 
            this.detailsRightPanel.BackColor = System.Drawing.SystemColors.Control;
            this.detailsRightPanel.Controls.Add(this.kryptonMonthCalendar1);
            this.detailsRightPanel.Controls.Add(this.fullSizecloseButton);
            this.detailsRightPanel.Controls.Add(this.label10);
            this.detailsRightPanel.Controls.Add(this.clientRentsCountLabel);
            this.detailsRightPanel.Controls.Add(this.label9);
            this.detailsRightPanel.Controls.Add(this.label8);
            this.detailsRightPanel.Controls.Add(this.helpLabel);
            this.detailsRightPanel.Controls.Add(this.clientRentsDataGridView);
            this.detailsRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.detailsRightPanel.Location = new System.Drawing.Point(421, 0);
            this.detailsRightPanel.Name = "detailsRightPanel";
            this.detailsRightPanel.Size = new System.Drawing.Size(385, 551);
            this.detailsRightPanel.TabIndex = 0;
            // 
            // kryptonMonthCalendar1
            // 
            this.kryptonMonthCalendar1.Location = new System.Drawing.Point(63, 3);
            this.kryptonMonthCalendar1.Name = "kryptonMonthCalendar1";
            this.kryptonMonthCalendar1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonMonthCalendar1.Size = new System.Drawing.Size(230, 184);
            this.kryptonMonthCalendar1.TabIndex = 0;
            // 
            // fullSizecloseButton
            // 
            this.fullSizecloseButton.Location = new System.Drawing.Point(226, 498);
            this.fullSizecloseButton.Name = "fullSizecloseButton";
            this.fullSizecloseButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.fullSizecloseButton.Size = new System.Drawing.Size(129, 33);
            this.fullSizecloseButton.TabIndex = 8;
            this.fullSizecloseButton.Values.Text = "Close";
            this.fullSizecloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(122, 468);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "10 / 200";
            this.label10.Visible = false;
            // 
            // clientRentsCountLabel
            // 
            this.clientRentsCountLabel.AutoSize = true;
            this.clientRentsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientRentsCountLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.clientRentsCountLabel.Location = new System.Drawing.Point(122, 449);
            this.clientRentsCountLabel.Name = "clientRentsCountLabel";
            this.clientRentsCountLabel.Size = new System.Drawing.Size(23, 15);
            this.clientRentsCountLabel.TabIndex = 12;
            this.clientRentsCountLabel.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(3, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ranking";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(3, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Total of Rents :";
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpLabel.Location = new System.Drawing.Point(3, 202);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(184, 15);
            this.helpLabel.TabIndex = 11;
            this.helpLabel.Text = "* key del or suppr to delete a row\r\n";
            // 
            // clientRentsDataGridView
            // 
            this.clientRentsDataGridView.AllowUserToAddRows = false;
            this.clientRentsDataGridView.AutoGenerateColumns = false;
            this.clientRentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.clientRentsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.clientRentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientRentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentIdDataGridViewTextBoxColumn,
            this.carDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.manageByDataGridViewTextBoxColumn,
            this.billDataGridViewTextBoxColumn,
            this.dateStartDataGridViewTextBoxColumn,
            this.dateEndDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.numberOfDaysDataGridViewTextBoxColumn});
            this.clientRentsDataGridView.DataSource = this.rentBindingSource;
            this.clientRentsDataGridView.Location = new System.Drawing.Point(3, 241);
            this.clientRentsDataGridView.Name = "clientRentsDataGridView";
            this.clientRentsDataGridView.ReadOnly = true;
            this.clientRentsDataGridView.Size = new System.Drawing.Size(352, 191);
            this.clientRentsDataGridView.TabIndex = 9;
            this.clientRentsDataGridView.TabStop = false;
            this.clientRentsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.RentsDataGridView_CellFormatting);
            this.clientRentsDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.ClientRentsDataGridView_UserDeletedRow);
            this.clientRentsDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.ClientRentsDataGridView_UserDeletingRow);
            // 
            // rentIdDataGridViewTextBoxColumn
            // 
            this.rentIdDataGridViewTextBoxColumn.DataPropertyName = "RentId";
            this.rentIdDataGridViewTextBoxColumn.HeaderText = "RentId";
            this.rentIdDataGridViewTextBoxColumn.Name = "rentIdDataGridViewTextBoxColumn";
            this.rentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.rentIdDataGridViewTextBoxColumn.Width = 70;
            // 
            // carDataGridViewTextBoxColumn
            // 
            this.carDataGridViewTextBoxColumn.DataPropertyName = "Car";
            this.carDataGridViewTextBoxColumn.HeaderText = "Car";
            this.carDataGridViewTextBoxColumn.Name = "carDataGridViewTextBoxColumn";
            this.carDataGridViewTextBoxColumn.ReadOnly = true;
            this.carDataGridViewTextBoxColumn.Width = 54;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientDataGridViewTextBoxColumn.Width = 67;
            // 
            // manageByDataGridViewTextBoxColumn
            // 
            this.manageByDataGridViewTextBoxColumn.DataPropertyName = "ManageBy";
            this.manageByDataGridViewTextBoxColumn.HeaderText = "Manage By";
            this.manageByDataGridViewTextBoxColumn.Name = "manageByDataGridViewTextBoxColumn";
            this.manageByDataGridViewTextBoxColumn.ReadOnly = true;
            this.manageByDataGridViewTextBoxColumn.Width = 88;
            // 
            // billDataGridViewTextBoxColumn
            // 
            this.billDataGridViewTextBoxColumn.DataPropertyName = "Bill";
            this.billDataGridViewTextBoxColumn.HeaderText = "Bill";
            this.billDataGridViewTextBoxColumn.Name = "billDataGridViewTextBoxColumn";
            this.billDataGridViewTextBoxColumn.ReadOnly = true;
            this.billDataGridViewTextBoxColumn.Width = 52;
            // 
            // dateStartDataGridViewTextBoxColumn
            // 
            this.dateStartDataGridViewTextBoxColumn.DataPropertyName = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.HeaderText = "Date Start";
            this.dateStartDataGridViewTextBoxColumn.Name = "dateStartDataGridViewTextBoxColumn";
            this.dateStartDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateStartDataGridViewTextBoxColumn.Width = 81;
            // 
            // dateEndDataGridViewTextBoxColumn
            // 
            this.dateEndDataGridViewTextBoxColumn.DataPropertyName = "DateEnd";
            this.dateEndDataGridViewTextBoxColumn.HeaderText = "Date End";
            this.dateEndDataGridViewTextBoxColumn.Name = "dateEndDataGridViewTextBoxColumn";
            this.dateEndDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateEndDataGridViewTextBoxColumn.Width = 77;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateDataGridViewTextBoxColumn.Width = 62;
            // 
            // numberOfDaysDataGridViewTextBoxColumn
            // 
            this.numberOfDaysDataGridViewTextBoxColumn.DataPropertyName = "NumberOfDays";
            this.numberOfDaysDataGridViewTextBoxColumn.HeaderText = "Number Of Days";
            this.numberOfDaysDataGridViewTextBoxColumn.Name = "numberOfDaysDataGridViewTextBoxColumn";
            this.numberOfDaysDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberOfDaysDataGridViewTextBoxColumn.Width = 91;
            // 
            // rentBindingSource
            // 
            this.rentBindingSource.DataSource = typeof(CarRentalApp.Core.domain.Rent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(22, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CIN *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(228, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Driver License *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(22, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(22, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(228, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Phone *";
            // 
            // formLeftPanel
            // 
            this.formLeftPanel.BackColor = System.Drawing.SystemColors.Info;
            this.formLeftPanel.Controls.Add(this.clientAddressTextBox);
            this.formLeftPanel.Controls.Add(this.normalSizecloseButton);
            this.formLeftPanel.Controls.Add(this.validationLabel);
            this.formLeftPanel.Controls.Add(this.editButton);
            this.formLeftPanel.Controls.Add(this.addMoreButton);
            this.formLeftPanel.Controls.Add(this.CancelEditButton);
            this.formLeftPanel.Controls.Add(this.saveButton);
            this.formLeftPanel.Controls.Add(this.clientPhoneTextBox);
            this.formLeftPanel.Controls.Add(this.clientEmailTextBox);
            this.formLeftPanel.Controls.Add(this.clientDriverLicenseTextBox);
            this.formLeftPanel.Controls.Add(this.clientCinTextBox);
            this.formLeftPanel.Controls.Add(this.clientLastNameTextBox);
            this.formLeftPanel.Controls.Add(this.clientFirstNameTextBox);
            this.formLeftPanel.Controls.Add(this.label7);
            this.formLeftPanel.Controls.Add(this.label6);
            this.formLeftPanel.Controls.Add(this.label5);
            this.formLeftPanel.Controls.Add(this.label4);
            this.formLeftPanel.Controls.Add(this.label3);
            this.formLeftPanel.Controls.Add(this.label2);
            this.formLeftPanel.Controls.Add(this.label1);
            this.formLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.formLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.formLeftPanel.Name = "formLeftPanel";
            this.formLeftPanel.Size = new System.Drawing.Size(415, 551);
            this.formLeftPanel.TabIndex = 0;
            // 
            // clientAddressTextBox
            // 
            this.clientAddressTextBox.Location = new System.Drawing.Point(25, 297);
            this.clientAddressTextBox.MaxLength = 2048;
            this.clientAddressTextBox.Name = "clientAddressTextBox";
            this.clientAddressTextBox.Size = new System.Drawing.Size(348, 96);
            this.clientAddressTextBox.TabIndex = 7;
            this.clientAddressTextBox.Text = "";
            // 
            // normalSizecloseButton
            // 
            this.normalSizecloseButton.Location = new System.Drawing.Point(271, 449);
            this.normalSizecloseButton.Name = "normalSizecloseButton";
            this.normalSizecloseButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.normalSizecloseButton.Size = new System.Drawing.Size(102, 34);
            this.normalSizecloseButton.TabIndex = 8;
            this.normalSizecloseButton.Values.Text = "Close";
            this.normalSizecloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // validationLabel
            // 
            this.validationLabel.AutoSize = true;
            this.validationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validationLabel.ForeColor = System.Drawing.Color.Red;
            this.validationLabel.Location = new System.Drawing.Point(22, 405);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(192, 16);
            this.validationLabel.TabIndex = 11;
            this.validationLabel.Text = "* Informations are not valid";
            this.validationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.validationLabel.Visible = false;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(271, 497);
            this.editButton.Name = "editButton";
            this.editButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.editButton.Size = new System.Drawing.Size(102, 34);
            this.editButton.TabIndex = 9;
            this.editButton.Values.Text = "Edit";
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // addMoreButton
            // 
            this.addMoreButton.Location = new System.Drawing.Point(25, 498);
            this.addMoreButton.Name = "addMoreButton";
            this.addMoreButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.addMoreButton.Size = new System.Drawing.Size(102, 34);
            this.addMoreButton.TabIndex = 9;
            this.addMoreButton.Values.Text = "Add more";
            this.addMoreButton.Click += new System.EventHandler(this.AddMoreButton_Click);
            // 
            // CancelEditButton
            // 
            this.CancelEditButton.Location = new System.Drawing.Point(150, 449);
            this.CancelEditButton.Name = "CancelEditButton";
            this.CancelEditButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.CancelEditButton.Size = new System.Drawing.Size(102, 34);
            this.CancelEditButton.TabIndex = 10;
            this.CancelEditButton.Values.Text = "Cancel";
            this.CancelEditButton.Click += new System.EventHandler(this.CancelEditButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(25, 449);
            this.saveButton.Name = "saveButton";
            this.saveButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.saveButton.Size = new System.Drawing.Size(102, 34);
            this.saveButton.TabIndex = 10;
            this.saveButton.Values.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // clientPhoneTextBox
            // 
            this.clientPhoneTextBox.Location = new System.Drawing.Point(231, 205);
            this.clientPhoneTextBox.Mask = "+212 000-000000";
            this.clientPhoneTextBox.MinimumSize = new System.Drawing.Size(142, 23);
            this.clientPhoneTextBox.Name = "clientPhoneTextBox";
            this.clientPhoneTextBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.clientPhoneTextBox.Size = new System.Drawing.Size(142, 23);
            this.clientPhoneTextBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientPhoneTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.clientPhoneTextBox.TabIndex = 6;
            this.clientPhoneTextBox.Text = "+212    -";
            // 
            // clientEmailTextBox
            // 
            this.clientEmailTextBox.Location = new System.Drawing.Point(25, 205);
            this.clientEmailTextBox.MaxLength = 64;
            this.clientEmailTextBox.Name = "clientEmailTextBox";
            this.clientEmailTextBox.Size = new System.Drawing.Size(174, 23);
            this.clientEmailTextBox.TabIndex = 5;
            // 
            // clientDriverLicenseTextBox
            // 
            this.clientDriverLicenseTextBox.Location = new System.Drawing.Point(231, 152);
            this.clientDriverLicenseTextBox.MaxLength = 32;
            this.clientDriverLicenseTextBox.Name = "clientDriverLicenseTextBox";
            this.clientDriverLicenseTextBox.Size = new System.Drawing.Size(142, 23);
            this.clientDriverLicenseTextBox.TabIndex = 4;
            // 
            // clientCinTextBox
            // 
            this.clientCinTextBox.Location = new System.Drawing.Point(25, 152);
            this.clientCinTextBox.MaxLength = 32;
            this.clientCinTextBox.Name = "clientCinTextBox";
            this.clientCinTextBox.Size = new System.Drawing.Size(174, 23);
            this.clientCinTextBox.TabIndex = 3;
            // 
            // clientLastNameTextBox
            // 
            this.clientLastNameTextBox.Location = new System.Drawing.Point(25, 98);
            this.clientLastNameTextBox.MaxLength = 32;
            this.clientLastNameTextBox.Name = "clientLastNameTextBox";
            this.clientLastNameTextBox.Size = new System.Drawing.Size(259, 23);
            this.clientLastNameTextBox.TabIndex = 2;
            // 
            // clientFirstNameTextBox
            // 
            this.clientFirstNameTextBox.Location = new System.Drawing.Point(25, 38);
            this.clientFirstNameTextBox.MaxLength = 32;
            this.clientFirstNameTextBox.Name = "clientFirstNameTextBox";
            this.clientFirstNameTextBox.Size = new System.Drawing.Size(259, 23);
            this.clientFirstNameTextBox.TabIndex = 1;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(806, 551);
            this.Controls.Add(this.formLeftPanel);
            this.Controls.Add(this.detailsRightPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(418, 590);
            this.Name = "ClientForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.AddClientForm_Load);
            this.detailsRightPanel.ResumeLayout(false);
            this.detailsRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientRentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).EndInit();
            this.formLeftPanel.ResumeLayout(false);
            this.formLeftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private Panel detailsRightPanel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel formLeftPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox clientEmailTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox clientDriverLicenseTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox clientCinTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox clientLastNameTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox clientFirstNameTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox clientPhoneTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton normalSizecloseButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addMoreButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton saveButton;
        private ComponentFactory.Krypton.Toolkit.KryptonMonthCalendar kryptonMonthCalendar1;
        private Label validationLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton editButton;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox clientAddressTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton fullSizecloseButton;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView clientRentsDataGridView;
        private BindingSource rentBindingSource;
        private Label helpLabel;
        private Label label8;
        private Label label10;
        private Label clientRentsCountLabel;
        private Label label9;
        private ComponentFactory.Krypton.Toolkit.KryptonButton CancelEditButton;
        private DataGridViewTextBoxColumn rentIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn manageByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn billDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateStartDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateEndDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberOfDaysDataGridViewTextBoxColumn;
    }
}