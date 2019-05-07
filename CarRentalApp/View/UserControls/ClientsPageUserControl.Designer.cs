using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace CarRentalApp.View.UserControls
{
    partial class ClientsPageUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsPageUserControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.refreshDataGrid = new Bunifu.Framework.UI.BunifuImageButton();
            this.searchButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.addNewClientButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.deleteButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.searchTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.seachFilterDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.exportToExelButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.printButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.clientsDataGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverLicenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewClientButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportToExelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.refreshDataGrid);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.addNewClientButton);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.seachFilterDropdown);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 104);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Double click on cell to view more details\r\nF2 to enter on Edit mode\r\nFill to add " +
    "new";
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(201, 24);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Manage your Clients";
            // 
            // refreshDataGrid
            // 
            this.refreshDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshDataGrid.Image = ((System.Drawing.Image)(resources.GetObject("refreshDataGrid.Image")));
            this.refreshDataGrid.ImageActive = ((System.Drawing.Image)(resources.GetObject("refreshDataGrid.ImageActive")));
            this.refreshDataGrid.Location = new System.Drawing.Point(974, 66);
            this.refreshDataGrid.Name = "refreshDataGrid";
            this.refreshDataGrid.Size = new System.Drawing.Size(32, 32);
            this.refreshDataGrid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshDataGrid.TabIndex = 4;
            this.refreshDataGrid.TabStop = false;
            this.refreshDataGrid.Zoom = 10;
            this.refreshDataGrid.Click += new System.EventHandler(this.RefreshDataGridButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("searchButton.ImageActive")));
            this.searchButton.Location = new System.Drawing.Point(288, 69);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(32, 32);
            this.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchButton.TabIndex = 4;
            this.searchButton.TabStop = false;
            this.searchButton.Zoom = 10;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // addNewClientButton
            // 
            this.addNewClientButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addNewClientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewClientButton.Image = ((System.Drawing.Image)(resources.GetObject("addNewClientButton.Image")));
            this.addNewClientButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("addNewClientButton.ImageActive")));
            this.addNewClientButton.Location = new System.Drawing.Point(862, 66);
            this.addNewClientButton.Name = "addNewClientButton";
            this.addNewClientButton.Size = new System.Drawing.Size(32, 32);
            this.addNewClientButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addNewClientButton.TabIndex = 4;
            this.addNewClientButton.TabStop = false;
            this.addNewClientButton.Zoom = 10;
            this.addNewClientButton.Click += new System.EventHandler(this.AddNewClientButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("deleteButton.ImageActive")));
            this.deleteButton.Location = new System.Drawing.Point(916, 66);
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
            this.searchTextBox.BorderColorMouseHover = System.Drawing.Color.Maroon;
            this.searchTextBox.BorderThickness = 3;
            this.searchTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchTextBox.isPassword = false;
            this.searchTextBox.Location = new System.Drawing.Point(31, 66);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.MaxLength = 32;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(250, 35);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.Text = "Enter a keyword";
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            this.searchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            // 
            // seachFilterDropdown
            // 
            this.seachFilterDropdown.BackColor = System.Drawing.SystemColors.Control;
            this.seachFilterDropdown.BorderRadius = 3;
            this.seachFilterDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.seachFilterDropdown.ForeColor = System.Drawing.Color.White;
            this.seachFilterDropdown.items = new string[] {
        "FirstName",
        "LastName",
        "Driver License",
        "CIN",
        "Phone",
        "Phone",
        "Address",
        "All"};
            this.seachFilterDropdown.Location = new System.Drawing.Point(326, 66);
            this.seachFilterDropdown.Name = "seachFilterDropdown";
            this.seachFilterDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(50)))));
            this.seachFilterDropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(55)))), ((int)(((byte)(48)))));
            this.seachFilterDropdown.selectedIndex = 7;
            this.seachFilterDropdown.Size = new System.Drawing.Size(154, 35);
            this.seachFilterDropdown.TabIndex = 2;
            // 
            // exportToExelButton
            // 
            this.exportToExelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportToExelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportToExelButton.Image = ((System.Drawing.Image)(resources.GetObject("exportToExelButton.Image")));
            this.exportToExelButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("exportToExelButton.ImageActive")));
            this.exportToExelButton.Location = new System.Drawing.Point(916, 3);
            this.exportToExelButton.Name = "exportToExelButton";
            this.exportToExelButton.Size = new System.Drawing.Size(32, 43);
            this.exportToExelButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exportToExelButton.TabIndex = 4;
            this.exportToExelButton.TabStop = false;
            this.exportToExelButton.Zoom = 10;
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
            this.printButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("printButton.ImageActive")));
            this.printButton.Location = new System.Drawing.Point(973, 0);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(32, 43);
            this.printButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.printButton.TabIndex = 4;
            this.printButton.TabStop = false;
            this.printButton.Zoom = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.printButton);
            this.panel2.Controls.Add(this.exportToExelButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 626);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 55);
            this.panel2.TabIndex = 5;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // clientsDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clientsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.clientsDataGridView.AutoGenerateColumns = false;
            this.clientsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientsDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.clientsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.cinDataGridViewTextBoxColumn,
            this.driverLicenseDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.clientsDataGridView.DataSource = this.clientBindingSource;
            this.clientsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsDataGridView.DoubleBuffered = true;
            this.clientsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.clientsDataGridView.EnableHeadersVisualStyles = false;
            this.clientsDataGridView.HeaderBgColor = System.Drawing.SystemColors.GrayText;
            this.clientsDataGridView.HeaderForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clientsDataGridView.Location = new System.Drawing.Point(0, 104);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.clientsDataGridView.RowHeadersWidth = 60;
            this.clientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsDataGridView.Size = new System.Drawing.Size(1044, 522);
            this.clientsDataGridView.TabIndex = 6;
            this.clientsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsDataGridView_CellDoubleClick);
            this.clientsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ClientsDataGridView_CellFormatting);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // cinDataGridViewTextBoxColumn
            // 
            this.cinDataGridViewTextBoxColumn.DataPropertyName = "Cin";
            this.cinDataGridViewTextBoxColumn.HeaderText = "Cin";
            this.cinDataGridViewTextBoxColumn.Name = "cinDataGridViewTextBoxColumn";
            // 
            // driverLicenseDataGridViewTextBoxColumn
            // 
            this.driverLicenseDataGridViewTextBoxColumn.DataPropertyName = "DriverLicense";
            this.driverLicenseDataGridViewTextBoxColumn.HeaderText = "Driver License";
            this.driverLicenseDataGridViewTextBoxColumn.Name = "driverLicenseDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(CarRentalApp.Core.domain.Client);
            // 
            // ClientsPageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clientsDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ClientsPageUserControl";
            this.Size = new System.Drawing.Size(1044, 681);
            this.Load += new System.EventHandler(this.ClientsPageUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewClientButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportToExelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private BunifuDropdown seachFilterDropdown;
        private BunifuMetroTextbox searchTextBox;
        private BunifuImageButton exportToExelButton;
        private BunifuImageButton printButton;
        private BunifuImageButton deleteButton;
        private BunifuCustomLabel bunifuCustomLabel1;
        private BunifuSeparator bunifuSeparator1;
        private BunifuImageButton refreshDataGrid;
        private Panel panel2;
        private BunifuImageButton addNewClientButton;
        private BunifuImageButton searchButton;
        private BindingSource clientBindingSource;
        private BunifuDragControl bunifuDragControl1;
        private BunifuCustomDataGrid clientsDataGridView;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn driverLicenseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private Label label1;
    }
}
