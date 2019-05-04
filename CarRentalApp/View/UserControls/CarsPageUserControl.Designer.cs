using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.refreshDataGrid = new Bunifu.Framework.UI.BunifuImageButton();
            this.searchButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.addNewCarsButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.deleteButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.searchTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.seachFilterDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.carsDataGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.carsAvailableCircleProgressBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.availableCarsCountLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.inavailableCarsCountLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.carsCountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.printButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.exportToExelButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.selectedCarClassificationLabel = new System.Windows.Forms.Label();
            this.selectedCarNameLabel = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.selectedCarDescriptionLabel = new System.Windows.Forms.Label();
            this.selectedCarCardPanel = new System.Windows.Forms.Panel();
            this.selectedCarStatus = new System.Windows.Forms.Label();
            this.carImagePictureBox = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.selectedCarPricePerDayLabel = new System.Windows.Forms.Label();
            this.selectedCarPurchaseDateLabel = new System.Windows.Forms.Label();
            this.selectedCarNextDrainDateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.selectedCarRentsCountLabel = new System.Windows.Forms.Label();
            this.selectedCarLicensePlateLabel = new System.Windows.Forms.Label();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensePlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewCarsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportToExelButton)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.selectedCarCardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carImagePictureBox)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-25, 36);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1064, 24);
            this.bunifuSeparator1.TabIndex = 6;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 104);
            this.panel1.TabIndex = 5;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(27, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(180, 24);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Manage your Cars";
            // 
            // refreshDataGrid
            // 
            this.refreshDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshDataGrid.Image = ((System.Drawing.Image)(resources.GetObject("refreshDataGrid.Image")));
            this.refreshDataGrid.ImageActive = ((System.Drawing.Image)(resources.GetObject("refreshDataGrid.ImageActive")));
            this.refreshDataGrid.Location = new System.Drawing.Point(571, 57);
            this.refreshDataGrid.Name = "refreshDataGrid";
            this.refreshDataGrid.Size = new System.Drawing.Size(32, 32);
            this.refreshDataGrid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshDataGrid.TabIndex = 4;
            this.refreshDataGrid.TabStop = false;
            this.refreshDataGrid.Zoom = 10;
            this.refreshDataGrid.Click += new System.EventHandler(this.RefreshDataGrid_Click);
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("searchButton.ImageActive")));
            this.searchButton.Location = new System.Drawing.Point(179, 60);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(32, 32);
            this.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchButton.TabIndex = 4;
            this.searchButton.TabStop = false;
            this.searchButton.Zoom = 10;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // addNewCarsButton
            // 
            this.addNewCarsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addNewCarsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewCarsButton.Image = ((System.Drawing.Image)(resources.GetObject("addNewCarsButton.Image")));
            this.addNewCarsButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("addNewCarsButton.ImageActive")));
            this.addNewCarsButton.Location = new System.Drawing.Point(485, 57);
            this.addNewCarsButton.Name = "addNewCarsButton";
            this.addNewCarsButton.Size = new System.Drawing.Size(32, 32);
            this.addNewCarsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addNewCarsButton.TabIndex = 4;
            this.addNewCarsButton.TabStop = false;
            this.addNewCarsButton.Zoom = 10;
            this.addNewCarsButton.Click += new System.EventHandler(this.AddNewCarsButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("deleteButton.ImageActive")));
            this.deleteButton.Location = new System.Drawing.Point(533, 57);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(32, 32);
            this.deleteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deleteButton.TabIndex = 4;
            this.deleteButton.TabStop = false;
            this.deleteButton.Zoom = 10;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderColorFocused = System.Drawing.Color.Crimson;
            this.searchTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchTextBox.BorderColorMouseHover = System.Drawing.Color.IndianRed;
            this.searchTextBox.BorderThickness = 3;
            this.searchTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchTextBox.isPassword = false;
            this.searchTextBox.Location = new System.Drawing.Point(4, 57);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.MaxLength = 32;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(168, 35);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.Text = "Enter a keyword";
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            this.searchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            // 
            // seachFilterDropdown
            // 
            this.seachFilterDropdown.BackColor = System.Drawing.Color.Transparent;
            this.seachFilterDropdown.BorderRadius = 3;
            this.seachFilterDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.seachFilterDropdown.ForeColor = System.Drawing.Color.White;
            this.seachFilterDropdown.items = new string[] {
        "Name",
        "License Plate",
        "Price Per Day",
        "Description",
        "All"};
            this.seachFilterDropdown.Location = new System.Drawing.Point(217, 57);
            this.seachFilterDropdown.Name = "seachFilterDropdown";
            this.seachFilterDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.seachFilterDropdown.onHoverColor = System.Drawing.Color.Maroon;
            this.seachFilterDropdown.selectedIndex = 4;
            this.seachFilterDropdown.Size = new System.Drawing.Size(165, 35);
            this.seachFilterDropdown.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.carsDataGridView);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.addNewCarsButton);
            this.panel2.Controls.Add(this.searchButton);
            this.panel2.Controls.Add(this.searchTextBox);
            this.panel2.Controls.Add(this.seachFilterDropdown);
            this.panel2.Controls.Add(this.refreshDataGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(423, 104);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(621, 567);
            this.panel2.TabIndex = 8;
            // 
            // carsDataGridView
            // 
            this.carsDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.carsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.carsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carsDataGridView.AutoGenerateColumns = false;
            this.carsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.carsDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.carsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.carsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.carsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.licensePlateDataGridViewTextBoxColumn,
            this.pricePerDayDataGridViewTextBoxColumn,
            this.classificationDataGridViewTextBoxColumn});
            this.carsDataGridView.DataSource = this.carsBindingSource;
            this.carsDataGridView.DoubleBuffered = true;
            this.carsDataGridView.EnableHeadersVisualStyles = false;
            this.carsDataGridView.HeaderBgColor = System.Drawing.SystemColors.GrayText;
            this.carsDataGridView.HeaderForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.carsDataGridView.Location = new System.Drawing.Point(6, 104);
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.carsDataGridView.RowHeadersWidth = 60;
            this.carsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carsDataGridView.Size = new System.Drawing.Size(610, 357);
            this.carsDataGridView.TabIndex = 16;
            this.carsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.CarsDataGridView_CellFormatting);
            this.carsDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarsDataGridView_RowEnter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.carsAvailableCircleProgressBar);
            this.panel3.Controls.Add(this.availableCarsCountLabel);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.inavailableCarsCountLabel);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.carsCountLabel);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.printButton);
            this.panel3.Controls.Add(this.exportToExelButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 467);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(616, 100);
            this.panel3.TabIndex = 5;
            // 
            // carsAvailableCircleProgressBar
            // 
            this.carsAvailableCircleProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carsAvailableCircleProgressBar.animated = true;
            this.carsAvailableCircleProgressBar.animationIterval = 5;
            this.carsAvailableCircleProgressBar.animationSpeed = 300;
            this.carsAvailableCircleProgressBar.AutoSize = true;
            this.carsAvailableCircleProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.carsAvailableCircleProgressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("carsAvailableCircleProgressBar.BackgroundImage")));
            this.carsAvailableCircleProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carsAvailableCircleProgressBar.ForeColor = System.Drawing.Color.Black;
            this.carsAvailableCircleProgressBar.LabelVisible = true;
            this.carsAvailableCircleProgressBar.LineProgressThickness = 8;
            this.carsAvailableCircleProgressBar.LineThickness = 5;
            this.carsAvailableCircleProgressBar.Location = new System.Drawing.Point(335, 2);
            this.carsAvailableCircleProgressBar.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.carsAvailableCircleProgressBar.MaxValue = 100;
            this.carsAvailableCircleProgressBar.Name = "carsAvailableCircleProgressBar";
            this.carsAvailableCircleProgressBar.ProgressBackColor = System.Drawing.Color.Crimson;
            this.carsAvailableCircleProgressBar.ProgressColor = System.Drawing.Color.SeaGreen;
            this.carsAvailableCircleProgressBar.Size = new System.Drawing.Size(95, 95);
            this.carsAvailableCircleProgressBar.TabIndex = 18;
            this.carsAvailableCircleProgressBar.TabStop = false;
            this.carsAvailableCircleProgressBar.Value = 43;
            // 
            // availableCarsCountLabel
            // 
            this.availableCarsCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.availableCarsCountLabel.AutoSize = true;
            this.availableCarsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableCarsCountLabel.ForeColor = System.Drawing.Color.Green;
            this.availableCarsCountLabel.Location = new System.Drawing.Point(237, 34);
            this.availableCarsCountLabel.Name = "availableCarsCountLabel";
            this.availableCarsCountLabel.Size = new System.Drawing.Size(38, 25);
            this.availableCarsCountLabel.TabIndex = 15;
            this.availableCarsCountLabel.Text = "29";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(19, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Total Availables : ";
            // 
            // inavailableCarsCountLabel
            // 
            this.inavailableCarsCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inavailableCarsCountLabel.AutoSize = true;
            this.inavailableCarsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inavailableCarsCountLabel.ForeColor = System.Drawing.Color.Crimson;
            this.inavailableCarsCountLabel.Location = new System.Drawing.Point(237, 59);
            this.inavailableCarsCountLabel.Name = "inavailableCarsCountLabel";
            this.inavailableCarsCountLabel.Size = new System.Drawing.Size(38, 25);
            this.inavailableCarsCountLabel.TabIndex = 16;
            this.inavailableCarsCountLabel.Text = "38";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(19, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Total Rented(unavailable)";
            // 
            // carsCountLabel
            // 
            this.carsCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.carsCountLabel.AutoSize = true;
            this.carsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carsCountLabel.ForeColor = System.Drawing.Color.DarkViolet;
            this.carsCountLabel.Location = new System.Drawing.Point(237, 9);
            this.carsCountLabel.Name = "carsCountLabel";
            this.carsCountLabel.Size = new System.Drawing.Size(38, 25);
            this.carsCountLabel.TabIndex = 17;
            this.carsCountLabel.Text = "67";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total numers of Cars : ";
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
            this.printButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("printButton.ImageActive")));
            this.printButton.Location = new System.Drawing.Point(565, 9);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(32, 32);
            this.printButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.printButton.TabIndex = 10;
            this.printButton.TabStop = false;
            this.printButton.Zoom = 10;
            // 
            // exportToExelButton
            // 
            this.exportToExelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exportToExelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportToExelButton.Image = ((System.Drawing.Image)(resources.GetObject("exportToExelButton.Image")));
            this.exportToExelButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("exportToExelButton.ImageActive")));
            this.exportToExelButton.Location = new System.Drawing.Point(497, 9);
            this.exportToExelButton.Name = "exportToExelButton";
            this.exportToExelButton.Size = new System.Drawing.Size(32, 32);
            this.exportToExelButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exportToExelButton.TabIndex = 11;
            this.exportToExelButton.TabStop = false;
            this.exportToExelButton.Zoom = 10;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuCards1.BorderRadius = 30;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.SystemColors.Control;
            this.bunifuCards1.Controls.Add(this.panel6);
            this.bunifuCards1.Controls.Add(this.panel8);
            this.bunifuCards1.Controls.Add(this.selectedCarCardPanel);
            this.bunifuCards1.Controls.Add(this.panel4);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(5, 104);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(418, 567);
            this.bunifuCards1.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.selectedCarClassificationLabel);
            this.panel6.Controls.Add(this.selectedCarNameLabel);
            this.panel6.Location = new System.Drawing.Point(3, 194);
            this.panel6.MaximumSize = new System.Drawing.Size(0, 64);
            this.panel6.MinimumSize = new System.Drawing.Size(415, 64);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(415, 64);
            this.panel6.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.SystemColors.Window;
            this.panel7.Location = new System.Drawing.Point(3, 67);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(403, 132);
            this.panel7.TabIndex = 9;
            // 
            // selectedCarClassificationLabel
            // 
            this.selectedCarClassificationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedCarClassificationLabel.AutoSize = true;
            this.selectedCarClassificationLabel.BackColor = System.Drawing.Color.Blue;
            this.selectedCarClassificationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCarClassificationLabel.ForeColor = System.Drawing.Color.White;
            this.selectedCarClassificationLabel.Location = new System.Drawing.Point(283, 25);
            this.selectedCarClassificationLabel.MinimumSize = new System.Drawing.Size(80, 0);
            this.selectedCarClassificationLabel.Name = "selectedCarClassificationLabel";
            this.selectedCarClassificationLabel.Size = new System.Drawing.Size(80, 20);
            this.selectedCarClassificationLabel.TabIndex = 3;
            this.selectedCarClassificationLabel.Text = "Model  S";
            // 
            // selectedCarNameLabel
            // 
            this.selectedCarNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedCarNameLabel.AutoSize = true;
            this.selectedCarNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCarNameLabel.Location = new System.Drawing.Point(74, 25);
            this.selectedCarNameLabel.Name = "selectedCarNameLabel";
            this.selectedCarNameLabel.Size = new System.Drawing.Size(205, 25);
            this.selectedCarNameLabel.TabIndex = 2;
            this.selectedCarNameLabel.Text = "JEEP WRANGLER";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Window;
            this.panel8.Controls.Add(this.selectedCarDescriptionLabel);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 191);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(418, 211);
            this.panel8.TabIndex = 10;
            // 
            // selectedCarDescriptionLabel
            // 
            this.selectedCarDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedCarDescriptionLabel.AutoEllipsis = true;
            this.selectedCarDescriptionLabel.AutoSize = true;
            this.selectedCarDescriptionLabel.BackColor = System.Drawing.SystemColors.Window;
            this.selectedCarDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCarDescriptionLabel.Location = new System.Drawing.Point(0, 70);
            this.selectedCarDescriptionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.selectedCarDescriptionLabel.MaximumSize = new System.Drawing.Size(415, 0);
            this.selectedCarDescriptionLabel.Name = "selectedCarDescriptionLabel";
            this.selectedCarDescriptionLabel.Padding = new System.Windows.Forms.Padding(10);
            this.selectedCarDescriptionLabel.Size = new System.Drawing.Size(403, 132);
            this.selectedCarDescriptionLabel.TabIndex = 2;
            this.selectedCarDescriptionLabel.Text = resources.GetString("selectedCarDescriptionLabel.Text");
            this.selectedCarDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectedCarDescriptionLabel.UseMnemonic = false;
            this.selectedCarDescriptionLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.SelectedCarDescriptionLabel_Paint);
            // 
            // selectedCarCardPanel
            // 
            this.selectedCarCardPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.selectedCarCardPanel.Controls.Add(this.selectedCarLicensePlateLabel);
            this.selectedCarCardPanel.Controls.Add(this.selectedCarStatus);
            this.selectedCarCardPanel.Controls.Add(this.carImagePictureBox);
            this.selectedCarCardPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectedCarCardPanel.Location = new System.Drawing.Point(0, 0);
            this.selectedCarCardPanel.Margin = new System.Windows.Forms.Padding(0);
            this.selectedCarCardPanel.Name = "selectedCarCardPanel";
            this.selectedCarCardPanel.Size = new System.Drawing.Size(418, 191);
            this.selectedCarCardPanel.TabIndex = 9;
            // 
            // selectedCarStatus
            // 
            this.selectedCarStatus.AutoSize = true;
            this.selectedCarStatus.BackColor = System.Drawing.Color.SeaGreen;
            this.selectedCarStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCarStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.selectedCarStatus.Location = new System.Drawing.Point(320, 161);
            this.selectedCarStatus.Name = "selectedCarStatus";
            this.selectedCarStatus.Size = new System.Drawing.Size(95, 24);
            this.selectedCarStatus.TabIndex = 2;
            this.selectedCarStatus.Text = "Available";
            // 
            // carImagePictureBox
            // 
            this.carImagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carImagePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("carImagePictureBox.BackgroundImage")));
            this.carImagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.carImagePictureBox.Location = new System.Drawing.Point(51, 0);
            this.carImagePictureBox.MinimumSize = new System.Drawing.Size(315, 182);
            this.carImagePictureBox.Name = "carImagePictureBox";
            this.carImagePictureBox.Size = new System.Drawing.Size(315, 182);
            this.carImagePictureBox.TabIndex = 1;
            this.carImagePictureBox.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Controls.Add(this.selectedCarPricePerDayLabel);
            this.panel4.Controls.Add(this.selectedCarPurchaseDateLabel);
            this.panel4.Controls.Add(this.selectedCarNextDrainDateLabel);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.selectedCarRentsCountLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 402);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(418, 165);
            this.panel4.TabIndex = 9;
            // 
            // selectedCarPricePerDayLabel
            // 
            this.selectedCarPricePerDayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedCarPricePerDayLabel.AutoSize = true;
            this.selectedCarPricePerDayLabel.BackColor = System.Drawing.SystemColors.Info;
            this.selectedCarPricePerDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCarPricePerDayLabel.ForeColor = System.Drawing.Color.Green;
            this.selectedCarPricePerDayLabel.Location = new System.Drawing.Point(176, 9);
            this.selectedCarPricePerDayLabel.Name = "selectedCarPricePerDayLabel";
            this.selectedCarPricePerDayLabel.Padding = new System.Windows.Forms.Padding(10);
            this.selectedCarPricePerDayLabel.Size = new System.Drawing.Size(146, 40);
            this.selectedCarPricePerDayLabel.TabIndex = 3;
            this.selectedCarPricePerDayLabel.Text = "600 MAD / day";
            // 
            // selectedCarPurchaseDateLabel
            // 
            this.selectedCarPurchaseDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedCarPurchaseDateLabel.AutoSize = true;
            this.selectedCarPurchaseDateLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.selectedCarPurchaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCarPurchaseDateLabel.ForeColor = System.Drawing.Color.Blue;
            this.selectedCarPurchaseDateLabel.Location = new System.Drawing.Point(176, 128);
            this.selectedCarPurchaseDateLabel.Name = "selectedCarPurchaseDateLabel";
            this.selectedCarPurchaseDateLabel.Padding = new System.Windows.Forms.Padding(2);
            this.selectedCarPurchaseDateLabel.Size = new System.Drawing.Size(103, 24);
            this.selectedCarPurchaseDateLabel.TabIndex = 4;
            this.selectedCarPurchaseDateLabel.Text = "01/26/2019\t";
            // 
            // selectedCarNextDrainDateLabel
            // 
            this.selectedCarNextDrainDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedCarNextDrainDateLabel.AutoSize = true;
            this.selectedCarNextDrainDateLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.selectedCarNextDrainDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCarNextDrainDateLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.selectedCarNextDrainDateLabel.Location = new System.Drawing.Point(176, 99);
            this.selectedCarNextDrainDateLabel.Name = "selectedCarNextDrainDateLabel";
            this.selectedCarNextDrainDateLabel.Padding = new System.Windows.Forms.Padding(2);
            this.selectedCarNextDrainDateLabel.Size = new System.Drawing.Size(103, 24);
            this.selectedCarNextDrainDateLabel.TabIndex = 4;
            this.selectedCarNextDrainDateLabel.Text = "01/26/2019\t";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Puschase Date";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Next Drain";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total of Rents";
            // 
            // selectedCarRentsCountLabel
            // 
            this.selectedCarRentsCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedCarRentsCountLabel.AutoSize = true;
            this.selectedCarRentsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCarRentsCountLabel.ForeColor = System.Drawing.Color.Magenta;
            this.selectedCarRentsCountLabel.Location = new System.Drawing.Point(217, 54);
            this.selectedCarRentsCountLabel.Name = "selectedCarRentsCountLabel";
            this.selectedCarRentsCountLabel.Size = new System.Drawing.Size(41, 29);
            this.selectedCarRentsCountLabel.TabIndex = 5;
            this.selectedCarRentsCountLabel.Text = "43";
            // 
            // selectedCarLicensePlateLabel
            // 
            this.selectedCarLicensePlateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedCarLicensePlateLabel.AutoSize = true;
            this.selectedCarLicensePlateLabel.BackColor = System.Drawing.Color.Gold;
            this.selectedCarLicensePlateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCarLicensePlateLabel.ForeColor = System.Drawing.Color.Black;
            this.selectedCarLicensePlateLabel.Location = new System.Drawing.Point(2, 151);
            this.selectedCarLicensePlateLabel.MinimumSize = new System.Drawing.Size(80, 0);
            this.selectedCarLicensePlateLabel.Name = "selectedCarLicensePlateLabel";
            this.selectedCarLicensePlateLabel.Padding = new System.Windows.Forms.Padding(10);
            this.selectedCarLicensePlateLabel.Size = new System.Drawing.Size(122, 40);
            this.selectedCarLicensePlateLabel.TabIndex = 3;
            this.selectedCarLicensePlateLabel.Text = "38730 E-43";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // licensePlateDataGridViewTextBoxColumn
            // 
            this.licensePlateDataGridViewTextBoxColumn.DataPropertyName = "LicensePlate";
            this.licensePlateDataGridViewTextBoxColumn.HeaderText = "License Plate";
            this.licensePlateDataGridViewTextBoxColumn.Name = "licensePlateDataGridViewTextBoxColumn";
            // 
            // pricePerDayDataGridViewTextBoxColumn
            // 
            this.pricePerDayDataGridViewTextBoxColumn.DataPropertyName = "PricePerDay";
            dataGridViewCellStyle9.Format = "0,0.00 MAD";
            dataGridViewCellStyle9.NullValue = null;
            this.pricePerDayDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.pricePerDayDataGridViewTextBoxColumn.HeaderText = "Price Per Day";
            this.pricePerDayDataGridViewTextBoxColumn.Name = "pricePerDayDataGridViewTextBoxColumn";
            // 
            // classificationDataGridViewTextBoxColumn
            // 
            this.classificationDataGridViewTextBoxColumn.DataPropertyName = "Classification";
            this.classificationDataGridViewTextBoxColumn.HeaderText = "Classification";
            this.classificationDataGridViewTextBoxColumn.Name = "classificationDataGridViewTextBoxColumn";
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataSource = typeof(CarRentalApp.Core.domain.Car);
            // 
            // CarsPageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CarsPageUserControl";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 0, 10);
            this.Size = new System.Drawing.Size(1044, 681);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewCarsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportToExelButton)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.selectedCarCardPanel.ResumeLayout(false);
            this.selectedCarCardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carImagePictureBox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuSeparator bunifuSeparator1;
        private Panel panel1;
        private BunifuCustomLabel bunifuCustomLabel1;
        private BunifuImageButton refreshDataGrid;
        private BunifuImageButton searchButton;
        private BunifuImageButton addNewCarsButton;
        private BunifuImageButton deleteButton;
        private BunifuMetroTextbox searchTextBox;
        private BunifuDropdown seachFilterDropdown;
        private Panel panel2;
        private PictureBox carImagePictureBox;
        private Label selectedCarNameLabel;
        private Label selectedCarStatus;
        private Label selectedCarClassificationLabel;
        private Label label6;
        private Label selectedCarRentsCountLabel;
        private BunifuCards bunifuCards1;
        private Panel panel3;
        private Label availableCarsCountLabel;
        private Label label11;
        private Label inavailableCarsCountLabel;
        private Label label9;
        private Label carsCountLabel;
        private Label label4;
        private BunifuImageButton printButton;
        private BunifuImageButton exportToExelButton;
        private BunifuCircleProgressbar carsAvailableCircleProgressBar;
        private Label selectedCarPricePerDayLabel;
        private BindingSource carsBindingSource;
        private BunifuCustomDataGrid carsDataGridView;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn licensePlateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pricePerDayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn classificationDataGridViewTextBoxColumn;
        private Panel selectedCarCardPanel;
        private Panel panel4;
        private Panel panel6;
        private Panel panel7;
        private Label label2;
        private Label label1;
        private Label selectedCarPurchaseDateLabel;
        private Label selectedCarNextDrainDateLabel;
        private Label label3;
        private Panel panel8;
        private Label selectedCarDescriptionLabel;
        private Label selectedCarLicensePlateLabel;
    }
}
