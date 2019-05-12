using System.ComponentModel;
using System.Windows.Forms;

namespace CarRentalApp.View.UserControls
{
    partial class CarsPageUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsPageUserControl));
            this.panel2 = new System.Windows.Forms.Panel();
            this.carDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.carImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensePlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAvailableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nextDrainDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.searchFilterComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.refreshDataGridViewButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.searchButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.searchTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.addNewCarButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.selectedCarEditButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.selectedCarRentsCountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectedCarPurchaseDateLabel = new System.Windows.Forms.Label();
            this.selectedCarPricePerDayLabel = new System.Windows.Forms.Label();
            this.selectedCarNextDrainDateLabel = new System.Windows.Forms.Label();
            this.selectedCarClassificationLabel = new System.Windows.Forms.Label();
            this.selectedCarLicensePlateLabel = new System.Windows.Forms.Label();
            this.selectedCarDescriptionLabel = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.selectedCarAvailabilityLabel = new System.Windows.Forms.Label();
            this.selectedCarNameLabel = new System.Windows.Forms.Label();
            this.selectedCarPictureBox = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchFilterComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedCarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.carDataGridView);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(5, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 571);
            this.panel2.TabIndex = 7;
            // 
            // carDataGridView
            // 
            this.carDataGridView.AllowUserToAddRows = false;
            this.carDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.carDataGridView.AutoGenerateColumns = false;
            this.carDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.carDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carImageDataGridViewImageColumn,
            this.nameDataGridViewTextBoxColumn,
            this.licensePlateDataGridViewTextBoxColumn,
            this.classificationDataGridViewTextBoxColumn,
            this.pricePerDayDataGridViewTextBoxColumn,
            this.isAvailableDataGridViewCheckBoxColumn,
            this.nextDrainDateDataGridViewTextBoxColumn});
            this.carDataGridView.DataSource = this.carBindingSource;
            this.carDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.carDataGridView.Location = new System.Drawing.Point(0, 61);
            this.carDataGridView.Name = "carDataGridView";
            this.carDataGridView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.carDataGridView.ReadOnly = true;
            this.carDataGridView.RowTemplate.Height = 50;
            this.carDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carDataGridView.Size = new System.Drawing.Size(583, 510);
            this.carDataGridView.TabIndex = 6;
            this.carDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarDataGridView_CellDoubleClick);
            this.carDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.CarsDataGridView_CellFormatting);
            this.carDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarsDataGridView_RowEnter);
            this.carDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.CarDataGridView_UserDeletedRow);
            this.carDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.CarDataGridView_UserDeletingRow);
            // 
            // carImageDataGridViewImageColumn
            // 
            this.carImageDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.carImageDataGridViewImageColumn.DataPropertyName = "CarImage";
            this.carImageDataGridViewImageColumn.HeaderText = "Car Image";
            this.carImageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.carImageDataGridViewImageColumn.MinimumWidth = 149;
            this.carImageDataGridViewImageColumn.Name = "carImageDataGridViewImageColumn";
            this.carImageDataGridViewImageColumn.ReadOnly = true;
            this.carImageDataGridViewImageColumn.Width = 149;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 68;
            // 
            // licensePlateDataGridViewTextBoxColumn
            // 
            this.licensePlateDataGridViewTextBoxColumn.DataPropertyName = "LicensePlate";
            this.licensePlateDataGridViewTextBoxColumn.HeaderText = "License Plate";
            this.licensePlateDataGridViewTextBoxColumn.Name = "licensePlateDataGridViewTextBoxColumn";
            this.licensePlateDataGridViewTextBoxColumn.ReadOnly = true;
            this.licensePlateDataGridViewTextBoxColumn.Width = 104;
            // 
            // classificationDataGridViewTextBoxColumn
            // 
            this.classificationDataGridViewTextBoxColumn.DataPropertyName = "Classification";
            this.classificationDataGridViewTextBoxColumn.HeaderText = "Classification";
            this.classificationDataGridViewTextBoxColumn.Name = "classificationDataGridViewTextBoxColumn";
            this.classificationDataGridViewTextBoxColumn.ReadOnly = true;
            this.classificationDataGridViewTextBoxColumn.Width = 106;
            // 
            // pricePerDayDataGridViewTextBoxColumn
            // 
            this.pricePerDayDataGridViewTextBoxColumn.DataPropertyName = "PricePerDay";
            this.pricePerDayDataGridViewTextBoxColumn.HeaderText = "Price Per Day";
            this.pricePerDayDataGridViewTextBoxColumn.Name = "pricePerDayDataGridViewTextBoxColumn";
            this.pricePerDayDataGridViewTextBoxColumn.ReadOnly = true;
            this.pricePerDayDataGridViewTextBoxColumn.Width = 105;
            // 
            // isAvailableDataGridViewCheckBoxColumn
            // 
            this.isAvailableDataGridViewCheckBoxColumn.DataPropertyName = "IsAvailable";
            this.isAvailableDataGridViewCheckBoxColumn.HeaderText = "Availability";
            this.isAvailableDataGridViewCheckBoxColumn.Name = "isAvailableDataGridViewCheckBoxColumn";
            this.isAvailableDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isAvailableDataGridViewCheckBoxColumn.Width = 75;
            // 
            // nextDrainDateDataGridViewTextBoxColumn
            // 
            this.nextDrainDateDataGridViewTextBoxColumn.DataPropertyName = "NextDrainDate";
            this.nextDrainDateDataGridViewTextBoxColumn.HeaderText = "Next Drain Date";
            this.nextDrainDateDataGridViewTextBoxColumn.Name = "nextDrainDateDataGridViewTextBoxColumn";
            this.nextDrainDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.nextDrainDateDataGridViewTextBoxColumn.Width = 118;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(CarRentalApp.Core.domain.Car);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.searchFilterComboBox);
            this.panel5.Controls.Add(this.refreshDataGridViewButton);
            this.panel5.Controls.Add(this.searchButton);
            this.panel5.Controls.Add(this.searchTextBox);
            this.panel5.Controls.Add(this.addNewCarButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(583, 61);
            this.panel5.TabIndex = 5;
            // 
            // searchFilterComboBox
            // 
            this.searchFilterComboBox.DropDownWidth = 121;
            this.searchFilterComboBox.Location = new System.Drawing.Point(262, 28);
            this.searchFilterComboBox.Name = "searchFilterComboBox";
            this.searchFilterComboBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.searchFilterComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchFilterComboBox.TabIndex = 3;
            this.searchFilterComboBox.Text = "All";
            // 
            // refreshDataGridViewButton
            // 
            this.refreshDataGridViewButton.Location = new System.Drawing.Point(511, 28);
            this.refreshDataGridViewButton.Name = "refreshDataGridViewButton";
            this.refreshDataGridViewButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.refreshDataGridViewButton.Size = new System.Drawing.Size(57, 25);
            this.refreshDataGridViewButton.TabIndex = 0;
            this.refreshDataGridViewButton.Values.Text = "refresh";
            this.refreshDataGridViewButton.Click += new System.EventHandler(this.RefreshDataGrid_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(166, 26);
            this.searchButton.Name = "searchButton";
            this.searchButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.searchButton.Size = new System.Drawing.Size(90, 25);
            this.searchButton.TabIndex = 2;
            this.searchButton.Values.Text = "Search";
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 26);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.searchTextBox.Size = new System.Drawing.Size(148, 23);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.Text = "Enter a Keyword";
            this.searchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            this.searchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            // 
            // addNewCarButton
            // 
            this.addNewCarButton.Location = new System.Drawing.Point(437, 28);
            this.addNewCarButton.Name = "addNewCarButton";
            this.addNewCarButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.addNewCarButton.Size = new System.Drawing.Size(57, 25);
            this.addNewCarButton.TabIndex = 0;
            this.addNewCarButton.Values.Text = "add";
            this.addNewCarButton.Click += new System.EventHandler(this.AddNewCarsButton_Click);
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Location = new System.Drawing.Point(23, 10);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kryptonHeader1.Size = new System.Drawing.Size(226, 56);
            this.kryptonHeader1.TabIndex = 2;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Manage your Cars";
            this.kryptonHeader1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader1.Values.Image")));
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 80);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.kryptonPanel1.Size = new System.Drawing.Size(1039, 10);
            this.kryptonPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kryptonPanel1);
            this.panel1.Controls.Add(this.kryptonHeader1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 100);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.selectedCarEditButton);
            this.panel3.Controls.Add(this.kryptonPanel2);
            this.panel3.Location = new System.Drawing.Point(612, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(432, 571);
            this.panel3.TabIndex = 8;
            // 
            // selectedCarEditButton
            // 
            this.selectedCarEditButton.Location = new System.Drawing.Point(317, 528);
            this.selectedCarEditButton.Name = "selectedCarEditButton";
            this.selectedCarEditButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.selectedCarEditButton.Size = new System.Drawing.Size(90, 25);
            this.selectedCarEditButton.TabIndex = 10;
            this.selectedCarEditButton.Values.Text = "Edit";
            this.selectedCarEditButton.Click += new System.EventHandler(this.SelectedCarEditButton_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.selectedCarRentsCountLabel);
            this.kryptonPanel2.Controls.Add(this.label4);
            this.kryptonPanel2.Controls.Add(this.label6);
            this.kryptonPanel2.Controls.Add(this.label5);
            this.kryptonPanel2.Controls.Add(this.label3);
            this.kryptonPanel2.Controls.Add(this.label2);
            this.kryptonPanel2.Controls.Add(this.label1);
            this.kryptonPanel2.Controls.Add(this.selectedCarPurchaseDateLabel);
            this.kryptonPanel2.Controls.Add(this.selectedCarPricePerDayLabel);
            this.kryptonPanel2.Controls.Add(this.selectedCarNextDrainDateLabel);
            this.kryptonPanel2.Controls.Add(this.selectedCarClassificationLabel);
            this.kryptonPanel2.Controls.Add(this.selectedCarLicensePlateLabel);
            this.kryptonPanel2.Controls.Add(this.selectedCarDescriptionLabel);
            this.kryptonPanel2.Controls.Add(this.selectedCarAvailabilityLabel);
            this.kryptonPanel2.Controls.Add(this.selectedCarNameLabel);
            this.kryptonPanel2.Controls.Add(this.selectedCarPictureBox);
            this.kryptonPanel2.Location = new System.Drawing.Point(16, 15);
            this.kryptonPanel2.MaximumSize = new System.Drawing.Size(391, 507);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(391, 507);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.SystemColors.Info;
            this.kryptonPanel2.TabIndex = 9;
            // 
            // selectedCarRentsCountLabel
            // 
            this.selectedCarRentsCountLabel.AutoSize = true;
            this.selectedCarRentsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCarRentsCountLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.selectedCarRentsCountLabel.Location = new System.Drawing.Point(317, 368);
            this.selectedCarRentsCountLabel.Name = "selectedCarRentsCountLabel";
            this.selectedCarRentsCountLabel.Size = new System.Drawing.Size(29, 20);
            this.selectedCarRentsCountLabel.TabIndex = 24;
            this.selectedCarRentsCountLabel.Text = "23";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Classification";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total of rents";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Purchase Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Next Drain Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Price (Daily)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "License Plate";
            // 
            // selectedCarPurchaseDateLabel
            // 
            this.selectedCarPurchaseDateLabel.AutoSize = true;
            this.selectedCarPurchaseDateLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.selectedCarPurchaseDateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedCarPurchaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCarPurchaseDateLabel.Location = new System.Drawing.Point(264, 336);
            this.selectedCarPurchaseDateLabel.Name = "selectedCarPurchaseDateLabel";
            this.selectedCarPurchaseDateLabel.Size = new System.Drawing.Size(82, 18);
            this.selectedCarPurchaseDateLabel.TabIndex = 13;
            this.selectedCarPurchaseDateLabel.Text = "2019-07-15";
            // 
            // selectedCarPricePerDayLabel
            // 
            this.selectedCarPricePerDayLabel.AutoSize = true;
            this.selectedCarPricePerDayLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.selectedCarPricePerDayLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedCarPricePerDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCarPricePerDayLabel.Location = new System.Drawing.Point(232, 238);
            this.selectedCarPricePerDayLabel.MinimumSize = new System.Drawing.Size(121, 18);
            this.selectedCarPricePerDayLabel.Name = "selectedCarPricePerDayLabel";
            this.selectedCarPricePerDayLabel.Size = new System.Drawing.Size(121, 18);
            this.selectedCarPricePerDayLabel.TabIndex = 14;
            this.selectedCarPricePerDayLabel.Text = "2000000.00 MAD";
            this.selectedCarPricePerDayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // selectedCarNextDrainDateLabel
            // 
            this.selectedCarNextDrainDateLabel.AutoSize = true;
            this.selectedCarNextDrainDateLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.selectedCarNextDrainDateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedCarNextDrainDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCarNextDrainDateLabel.Location = new System.Drawing.Point(264, 309);
            this.selectedCarNextDrainDateLabel.Name = "selectedCarNextDrainDateLabel";
            this.selectedCarNextDrainDateLabel.Size = new System.Drawing.Size(82, 18);
            this.selectedCarNextDrainDateLabel.TabIndex = 15;
            this.selectedCarNextDrainDateLabel.Text = "2019-07-15";
            // 
            // selectedCarClassificationLabel
            // 
            this.selectedCarClassificationLabel.AutoSize = true;
            this.selectedCarClassificationLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.selectedCarClassificationLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedCarClassificationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCarClassificationLabel.Location = new System.Drawing.Point(252, 275);
            this.selectedCarClassificationLabel.Name = "selectedCarClassificationLabel";
            this.selectedCarClassificationLabel.Size = new System.Drawing.Size(101, 18);
            this.selectedCarClassificationLabel.TabIndex = 16;
            this.selectedCarClassificationLabel.Text = "War Marchine";
            // 
            // selectedCarLicensePlateLabel
            // 
            this.selectedCarLicensePlateLabel.AutoSize = true;
            this.selectedCarLicensePlateLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.selectedCarLicensePlateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedCarLicensePlateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCarLicensePlateLabel.Location = new System.Drawing.Point(273, 210);
            this.selectedCarLicensePlateLabel.Name = "selectedCarLicensePlateLabel";
            this.selectedCarLicensePlateLabel.Size = new System.Drawing.Size(80, 18);
            this.selectedCarLicensePlateLabel.TabIndex = 17;
            this.selectedCarLicensePlateLabel.Text = "99985 W-4";
            // 
            // selectedCarDescriptionLabel
            // 
            this.selectedCarDescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.selectedCarDescriptionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectedCarDescriptionLabel.Location = new System.Drawing.Point(58, 399);
            this.selectedCarDescriptionLabel.MaximumSize = new System.Drawing.Size(300, 0);
            this.selectedCarDescriptionLabel.MinimumSize = new System.Drawing.Size(295, 90);
            this.selectedCarDescriptionLabel.Name = "selectedCarDescriptionLabel";
            this.selectedCarDescriptionLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.selectedCarDescriptionLabel.Size = new System.Drawing.Size(295, 90);
            this.selectedCarDescriptionLabel.Text = resources.GetString("selectedCarDescriptionLabel.Text");
            this.selectedCarDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectedCarAvailabilityLabel
            // 
            this.selectedCarAvailabilityLabel.AutoSize = true;
            this.selectedCarAvailabilityLabel.BackColor = System.Drawing.Color.Green;
            this.selectedCarAvailabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCarAvailabilityLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.selectedCarAvailabilityLabel.Location = new System.Drawing.Point(272, 173);
            this.selectedCarAvailabilityLabel.Name = "selectedCarAvailabilityLabel";
            this.selectedCarAvailabilityLabel.Size = new System.Drawing.Size(81, 20);
            this.selectedCarAvailabilityLabel.TabIndex = 11;
            this.selectedCarAvailabilityLabel.Text = "Available";
            // 
            // selectedCarNameLabel
            // 
            this.selectedCarNameLabel.AutoSize = true;
            this.selectedCarNameLabel.BackColor = System.Drawing.Color.Gold;
            this.selectedCarNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCarNameLabel.Location = new System.Drawing.Point(74, 173);
            this.selectedCarNameLabel.Name = "selectedCarNameLabel";
            this.selectedCarNameLabel.Size = new System.Drawing.Size(176, 25);
            this.selectedCarNameLabel.TabIndex = 12;
            this.selectedCarNameLabel.Text = "Mercedes-Benz";
            // 
            // selectedCarPictureBox
            // 
            this.selectedCarPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.selectedCarPictureBox.Image = global::CarRentalApp.Properties.Resources.car_picture_default;
            this.selectedCarPictureBox.Location = new System.Drawing.Point(58, 0);
            this.selectedCarPictureBox.Name = "selectedCarPictureBox";
            this.selectedCarPictureBox.Size = new System.Drawing.Size(291, 172);
            this.selectedCarPictureBox.TabIndex = 10;
            this.selectedCarPictureBox.TabStop = false;
            // 
            // CarsPageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CarsPageUserControl";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 0, 10);
            this.Size = new System.Drawing.Size(1044, 681);
            this.Load += new System.EventHandler(this.CarsPageUserControl_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchFilterComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedCarPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource carBindingSource;
        private Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Panel panel1;
        private Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView carDataGridView;
        private Panel panel5;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox searchFilterComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton refreshDataGridViewButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton searchButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox searchTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addNewCarButton;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Label selectedCarRentsCountLabel;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label selectedCarPurchaseDateLabel;
        private Label selectedCarPricePerDayLabel;
        private Label selectedCarNextDrainDateLabel;
        private Label selectedCarClassificationLabel;
        private Label selectedCarLicensePlateLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel selectedCarDescriptionLabel;
        private Label selectedCarAvailabilityLabel;
        private Label selectedCarNameLabel;
        private PictureBox selectedCarPictureBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton selectedCarEditButton;
        private DataGridViewImageColumn carImageDataGridViewImageColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn licensePlateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn classificationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pricePerDayDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isAvailableDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn nextDrainDateDataGridViewTextBoxColumn;
    }
}
