using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace CarRentalApp.View.UserControls
{
    partial class RentsPageUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentsPageUserControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentPageLabel = new System.Windows.Forms.Label();
            this.rentsTabPage = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.printButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.exportToExelButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rentsDataGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.rentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manageByUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.deleteButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.addNewCarsButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.refreshDataGrid = new Bunifu.Framework.UI.BunifuImageButton();
            this.searchButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.searchTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.seachFilterDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.rentsTabControl = new System.Windows.Forms.TabControl();
            this.newRentTabPage = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.rentsTabPage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportToExelButton)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewCarsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            this.rentsTabControl.SuspendLayout();
            this.newRentTabPage.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 36);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1044, 24);
            this.bunifuSeparator1.TabIndex = 6;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(27, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(144, 24);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Manage Rents";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.currentPageLabel);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 104);
            this.panel1.TabIndex = 13;
            // 
            // currentPageLabel
            // 
            this.currentPageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentPageLabel.AutoSize = true;
            this.currentPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPageLabel.ForeColor = System.Drawing.Color.DimGray;
            this.currentPageLabel.Location = new System.Drawing.Point(156, 63);
            this.currentPageLabel.Name = "currentPageLabel";
            this.currentPageLabel.Size = new System.Drawing.Size(249, 25);
            this.currentPageLabel.TabIndex = 7;
            this.currentPageLabel.Text = "Register AddNew Rent";
            this.currentPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rentsTabPage
            // 
            this.rentsTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.rentsTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rentsTabPage.Controls.Add(this.panel3);
            this.rentsTabPage.Location = new System.Drawing.Point(4, 25);
            this.rentsTabPage.Name = "rentsTabPage";
            this.rentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rentsTabPage.Size = new System.Drawing.Size(1036, 548);
            this.rentsTabPage.TabIndex = 1;
            this.rentsTabPage.Text = "Rents";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(1026, 538);
            this.panel3.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(10, 473);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1006, 55);
            this.panel6.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.printButton);
            this.panel7.Controls.Add(this.exportToExelButton);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, -9);
            this.panel7.MaximumSize = new System.Drawing.Size(0, 64);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1006, 64);
            this.panel7.TabIndex = 20;
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
            this.printButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("printButton.ImageActive")));
            this.printButton.Location = new System.Drawing.Point(933, 29);
            this.printButton.MaximumSize = new System.Drawing.Size(32, 32);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(32, 32);
            this.printButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.printButton.TabIndex = 18;
            this.printButton.TabStop = false;
            this.printButton.Zoom = 10;
            // 
            // exportToExelButton
            // 
            this.exportToExelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.exportToExelButton.Image = ((System.Drawing.Image)(resources.GetObject("exportToExelButton.Image")));
            this.exportToExelButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("exportToExelButton.ImageActive")));
            this.exportToExelButton.Location = new System.Drawing.Point(971, 29);
            this.exportToExelButton.MaximumSize = new System.Drawing.Size(32, 32);
            this.exportToExelButton.Name = "exportToExelButton";
            this.exportToExelButton.Size = new System.Drawing.Size(32, 32);
            this.exportToExelButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exportToExelButton.TabIndex = 19;
            this.exportToExelButton.TabStop = false;
            this.exportToExelButton.Zoom = 10;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rentsDataGridView);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 74);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1006, 454);
            this.panel5.TabIndex = 0;
            // 
            // rentsDataGridView
            // 
            this.rentsDataGridView.AllowUserToAddRows = false;
            this.rentsDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rentsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.rentsDataGridView.AutoGenerateColumns = false;
            this.rentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rentsDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.rentsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rentsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.rentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentIdDataGridViewTextBoxColumn,
            this.carDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.manageByUserDataGridViewTextBoxColumn,
            this.billDataGridViewTextBoxColumn,
            this.dateStartDataGridViewTextBoxColumn,
            this.dateEndDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn});
            this.rentsDataGridView.DataSource = this.rentBindingSource;
            this.rentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentsDataGridView.DoubleBuffered = true;
            this.rentsDataGridView.EnableHeadersVisualStyles = false;
            this.rentsDataGridView.HeaderBgColor = System.Drawing.SystemColors.GrayText;
            this.rentsDataGridView.HeaderForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rentsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.rentsDataGridView.Name = "rentsDataGridView";
            this.rentsDataGridView.ReadOnly = true;
            this.rentsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.rentsDataGridView.RowHeadersWidth = 60;
            this.rentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rentsDataGridView.Size = new System.Drawing.Size(1006, 454);
            this.rentsDataGridView.TabIndex = 17;
            this.rentsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.RentsDataGridView_CellFormatting);
            // 
            // rentIdDataGridViewTextBoxColumn
            // 
            this.rentIdDataGridViewTextBoxColumn.DataPropertyName = "RentId";
            this.rentIdDataGridViewTextBoxColumn.HeaderText = "RentId";
            this.rentIdDataGridViewTextBoxColumn.Name = "rentIdDataGridViewTextBoxColumn";
            this.rentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carDataGridViewTextBoxColumn
            // 
            this.carDataGridViewTextBoxColumn.DataPropertyName = "Car";
            this.carDataGridViewTextBoxColumn.HeaderText = "Car";
            this.carDataGridViewTextBoxColumn.Name = "carDataGridViewTextBoxColumn";
            this.carDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manageByUserDataGridViewTextBoxColumn
            // 
            this.manageByUserDataGridViewTextBoxColumn.DataPropertyName = "ManageBy";
            this.manageByUserDataGridViewTextBoxColumn.HeaderText = "ManageBy";
            this.manageByUserDataGridViewTextBoxColumn.Name = "manageByUserDataGridViewTextBoxColumn";
            this.manageByUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billDataGridViewTextBoxColumn
            // 
            this.billDataGridViewTextBoxColumn.DataPropertyName = "Bill";
            this.billDataGridViewTextBoxColumn.HeaderText = "Bill";
            this.billDataGridViewTextBoxColumn.Name = "billDataGridViewTextBoxColumn";
            this.billDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateStartDataGridViewTextBoxColumn
            // 
            this.dateStartDataGridViewTextBoxColumn.DataPropertyName = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.HeaderText = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.Name = "dateStartDataGridViewTextBoxColumn";
            this.dateStartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateEndDataGridViewTextBoxColumn
            // 
            this.dateEndDataGridViewTextBoxColumn.DataPropertyName = "DateEnd";
            this.dateEndDataGridViewTextBoxColumn.HeaderText = "DateEnd";
            this.dateEndDataGridViewTextBoxColumn.Name = "dateEndDataGridViewTextBoxColumn";
            this.dateEndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rentBindingSource
            // 
            this.rentBindingSource.DataSource = typeof(CarRentalApp.Core.domain.Rent);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.deleteButton);
            this.panel4.Controls.Add(this.addNewCarsButton);
            this.panel4.Controls.Add(this.refreshDataGrid);
            this.panel4.Controls.Add(this.searchButton);
            this.panel4.Controls.Add(this.searchTextBox);
            this.panel4.Controls.Add(this.seachFilterDropdown);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.MaximumSize = new System.Drawing.Size(0, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1006, 64);
            this.panel4.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("deleteButton.ImageActive")));
            this.deleteButton.Location = new System.Drawing.Point(971, 17);
            this.deleteButton.MaximumSize = new System.Drawing.Size(32, 32);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(32, 32);
            this.deleteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deleteButton.TabIndex = 7;
            this.deleteButton.TabStop = false;
            this.deleteButton.Zoom = 10;
            // 
            // addNewCarsButton
            // 
            this.addNewCarsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.addNewCarsButton.Image = ((System.Drawing.Image)(resources.GetObject("addNewCarsButton.Image")));
            this.addNewCarsButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("addNewCarsButton.ImageActive")));
            this.addNewCarsButton.Location = new System.Drawing.Point(895, 17);
            this.addNewCarsButton.MaximumSize = new System.Drawing.Size(32, 32);
            this.addNewCarsButton.Name = "addNewCarsButton";
            this.addNewCarsButton.Size = new System.Drawing.Size(32, 32);
            this.addNewCarsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addNewCarsButton.TabIndex = 8;
            this.addNewCarsButton.TabStop = false;
            this.addNewCarsButton.Zoom = 10;
            // 
            // refreshDataGrid
            // 
            this.refreshDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshDataGrid.Image = ((System.Drawing.Image)(resources.GetObject("refreshDataGrid.Image")));
            this.refreshDataGrid.ImageActive = ((System.Drawing.Image)(resources.GetObject("refreshDataGrid.ImageActive")));
            this.refreshDataGrid.Location = new System.Drawing.Point(933, 17);
            this.refreshDataGrid.MaximumSize = new System.Drawing.Size(32, 32);
            this.refreshDataGrid.Name = "refreshDataGrid";
            this.refreshDataGrid.Size = new System.Drawing.Size(32, 32);
            this.refreshDataGrid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshDataGrid.TabIndex = 10;
            this.refreshDataGrid.TabStop = false;
            this.refreshDataGrid.Zoom = 10;
            this.refreshDataGrid.Click += new System.EventHandler(this.RefreshDataGrid_Click);
            // 
            // searchButton
            // 
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("searchButton.ImageActive")));
            this.searchButton.Location = new System.Drawing.Point(181, 17);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(32, 32);
            this.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchButton.TabIndex = 9;
            this.searchButton.TabStop = false;
            this.searchButton.Zoom = 10;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderColorFocused = System.Drawing.Color.Blue;
            this.searchTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchTextBox.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.searchTextBox.BorderThickness = 3;
            this.searchTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchTextBox.isPassword = false;
            this.searchTextBox.Location = new System.Drawing.Point(6, 14);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.MaxLength = 32;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(168, 35);
            this.searchTextBox.TabIndex = 5;
            this.searchTextBox.Text = "Enter a keyword";
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // seachFilterDropdown
            // 
            this.seachFilterDropdown.BackColor = System.Drawing.Color.Transparent;
            this.seachFilterDropdown.BorderRadius = 3;
            this.seachFilterDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.seachFilterDropdown.ForeColor = System.Drawing.Color.White;
            this.seachFilterDropdown.items = new string[] {
        "First Name",
        "Last Name",
        "Email",
        "Phone",
        "Role",
        "All"};
            this.seachFilterDropdown.Location = new System.Drawing.Point(219, 14);
            this.seachFilterDropdown.Name = "seachFilterDropdown";
            this.seachFilterDropdown.NomalColor = System.Drawing.Color.Teal;
            this.seachFilterDropdown.onHoverColor = System.Drawing.Color.MediumBlue;
            this.seachFilterDropdown.selectedIndex = -1;
            this.seachFilterDropdown.Size = new System.Drawing.Size(165, 35);
            this.seachFilterDropdown.TabIndex = 6;
            // 
            // rentsTabControl
            // 
            this.rentsTabControl.Controls.Add(this.newRentTabPage);
            this.rentsTabControl.Controls.Add(this.rentsTabPage);
            this.rentsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentsTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentsTabControl.Location = new System.Drawing.Point(0, 0);
            this.rentsTabControl.Name = "rentsTabControl";
            this.rentsTabControl.SelectedIndex = 0;
            this.rentsTabControl.Size = new System.Drawing.Size(1044, 577);
            this.rentsTabControl.TabIndex = 7;
            this.rentsTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.RentsTabControl_Selected);
            // 
            // newRentTabPage
            // 
            this.newRentTabPage.AutoScroll = true;
            this.newRentTabPage.AutoScrollMinSize = new System.Drawing.Size(0, 520);
            this.newRentTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.newRentTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.newRentTabPage.Controls.Add(this.panel8);
            this.newRentTabPage.Location = new System.Drawing.Point(4, 25);
            this.newRentTabPage.Name = "newRentTabPage";
            this.newRentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.newRentTabPage.Size = new System.Drawing.Size(1036, 548);
            this.newRentTabPage.TabIndex = 0;
            this.newRentTabPage.Text = "AddNew Rent";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.contentPanel);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(2);
            this.panel8.Size = new System.Drawing.Size(1026, 538);
            this.panel8.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel10.Location = new System.Drawing.Point(524, 5);
            this.panel10.MinimumSize = new System.Drawing.Size(500, 520);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(500, 530);
            this.panel10.TabIndex = 1;
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.contentPanel.Location = new System.Drawing.Point(5, 5);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(4);
            this.contentPanel.Size = new System.Drawing.Size(509, 530);
            this.contentPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.rentsTabControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 577);
            this.panel2.TabIndex = 14;
            // 
            // RentsPageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RentsPageUserControl";
            this.Size = new System.Drawing.Size(1044, 681);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.rentsTabPage.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportToExelButton)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewCarsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            this.rentsTabControl.ResumeLayout(false);
            this.newRentTabPage.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuSeparator bunifuSeparator1;
        private BunifuCustomLabel bunifuCustomLabel1;
        private Panel panel1;
        private BindingSource rentBindingSource;
        private TabControl rentsTabControl;
        private TabPage newRentTabPage;
        private TabPage rentsTabPage;
        private Panel panel2;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private BunifuImageButton deleteButton;
        private BunifuImageButton addNewCarsButton;
        private BunifuImageButton searchButton;
        private BunifuMetroTextbox searchTextBox;
        private BunifuDropdown seachFilterDropdown;
        private BunifuImageButton refreshDataGrid;
        private BunifuCustomDataGrid rentsDataGridView;
        private BunifuImageButton printButton;
        private BunifuImageButton exportToExelButton;
        private Panel panel7;
        private DataGridViewTextBoxColumn rentIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn manageByUserDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn billDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateStartDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateEndDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private Panel panel8;
        private Panel panel10;
        private Panel contentPanel;
        private Label currentPageLabel;
    }
}
