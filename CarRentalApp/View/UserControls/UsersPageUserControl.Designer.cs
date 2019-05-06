using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace CarRentalApp.View.UserControls
{
    partial class UsersPageUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersPageUserControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mangerUserCountLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.administratorUserCountLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.usersCountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.printButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.exportToExelButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.addNewUserButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.searchButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.searchTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.seachFilterDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.refreshDataGrid = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.usersDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportToExelButton)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewUserButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mangerUserCountLabel
            // 
            this.mangerUserCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mangerUserCountLabel.AutoSize = true;
            this.mangerUserCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mangerUserCountLabel.ForeColor = System.Drawing.Color.Green;
            this.mangerUserCountLabel.Location = new System.Drawing.Point(237, 34);
            this.mangerUserCountLabel.Name = "mangerUserCountLabel";
            this.mangerUserCountLabel.Size = new System.Drawing.Size(25, 25);
            this.mangerUserCountLabel.TabIndex = 15;
            this.mangerUserCountLabel.Text = "9";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(19, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Total Managers : ";
            // 
            // administratorUserCountLabel
            // 
            this.administratorUserCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.administratorUserCountLabel.AutoSize = true;
            this.administratorUserCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administratorUserCountLabel.ForeColor = System.Drawing.Color.Crimson;
            this.administratorUserCountLabel.Location = new System.Drawing.Point(237, 59);
            this.administratorUserCountLabel.Name = "administratorUserCountLabel";
            this.administratorUserCountLabel.Size = new System.Drawing.Size(25, 25);
            this.administratorUserCountLabel.TabIndex = 16;
            this.administratorUserCountLabel.Text = "3";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(19, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Total Administrator";
            // 
            // usersCountLabel
            // 
            this.usersCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.usersCountLabel.AutoSize = true;
            this.usersCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersCountLabel.ForeColor = System.Drawing.Color.DarkViolet;
            this.usersCountLabel.Location = new System.Drawing.Point(237, 9);
            this.usersCountLabel.Name = "usersCountLabel";
            this.usersCountLabel.Size = new System.Drawing.Size(38, 25);
            this.usersCountLabel.TabIndex = 17;
            this.usersCountLabel.Text = "12";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total numers of User : ";
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
            this.printButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("printButton.ImageActive")));
            this.printButton.Location = new System.Drawing.Point(570, 9);
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
            this.exportToExelButton.Image = ((System.Drawing.Image)(resources.GetObject("exportToExelButton.Image")));
            this.exportToExelButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("exportToExelButton.ImageActive")));
            this.exportToExelButton.Location = new System.Drawing.Point(502, 9);
            this.exportToExelButton.Name = "exportToExelButton";
            this.exportToExelButton.Size = new System.Drawing.Size(32, 32);
            this.exportToExelButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exportToExelButton.TabIndex = 11;
            this.exportToExelButton.TabStop = false;
            this.exportToExelButton.Zoom = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mangerUserCountLabel);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.administratorUserCountLabel);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.usersCountLabel);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.printButton);
            this.panel3.Controls.Add(this.exportToExelButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 477);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(621, 100);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.usersDataGrid);
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.addNewUserButton);
            this.panel2.Controls.Add(this.searchButton);
            this.panel2.Controls.Add(this.searchTextBox);
            this.panel2.Controls.Add(this.seachFilterDropdown);
            this.panel2.Controls.Add(this.refreshDataGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(423, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 577);
            this.panel2.TabIndex = 11;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("deleteButton.ImageActive")));
            this.deleteButton.Location = new System.Drawing.Point(533, 57);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(32, 32);
            this.deleteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deleteButton.TabIndex = 4;
            this.deleteButton.TabStop = false;
            this.deleteButton.Zoom = 10;
            // 
            // addNewUserButton
            // 
            this.addNewUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addNewUserButton.Image = ((System.Drawing.Image)(resources.GetObject("addNewUserButton.Image")));
            this.addNewUserButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("addNewUserButton.ImageActive")));
            this.addNewUserButton.Location = new System.Drawing.Point(485, 57);
            this.addNewUserButton.Name = "addNewUserButton";
            this.addNewUserButton.Size = new System.Drawing.Size(32, 32);
            this.addNewUserButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addNewUserButton.TabIndex = 4;
            this.addNewUserButton.TabStop = false;
            this.addNewUserButton.Zoom = 10;
            // 
            // searchButton
            // 
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
        "First Name",
        "Last Name",
        "Email",
        "Phone",
        "Role",
        "All"};
            this.seachFilterDropdown.Location = new System.Drawing.Point(217, 57);
            this.seachFilterDropdown.Name = "seachFilterDropdown";
            this.seachFilterDropdown.NomalColor = System.Drawing.Color.Teal;
            this.seachFilterDropdown.onHoverColor = System.Drawing.Color.MediumBlue;
            this.seachFilterDropdown.selectedIndex = -1;
            this.seachFilterDropdown.Size = new System.Drawing.Size(165, 35);
            this.seachFilterDropdown.TabIndex = 2;
            // 
            // refreshDataGrid
            // 
            this.refreshDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 104);
            this.panel1.TabIndex = 10;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(27, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(244, 24);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Manage Application User";
            // 
            // usersDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usersDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usersDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersDataGrid.AutoGenerateColumns = false;
            this.usersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.usersDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.usersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.cinDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.usersDataGrid.DataSource = this.userBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.usersDataGrid.DoubleBuffered = true;
            this.usersDataGrid.EnableHeadersVisualStyles = false;
            this.usersDataGrid.HeaderBgColor = System.Drawing.Color.Silver;
            this.usersDataGrid.HeaderForeColor = System.Drawing.Color.Black;
            this.usersDataGrid.Location = new System.Drawing.Point(4, 105);
            this.usersDataGrid.Name = "usersDataGrid";
            this.usersDataGrid.ReadOnly = true;
            this.usersDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.usersDataGrid.RowHeadersWidth = 40;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.usersDataGrid.RowTemplate.ReadOnly = true;
            this.usersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDataGrid.Size = new System.Drawing.Size(614, 355);
            this.usersDataGrid.StandardTab = true;
            this.usersDataGrid.TabIndex = 2;
            this.usersDataGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.UsersDataGrid_DataBindingComplete);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(CarRentalApp.Core.domain.User);
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.FillWeight = 98.90017F;
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 98.90017F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.FillWeight = 98.90017F;
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cinDataGridViewTextBoxColumn
            // 
            this.cinDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cinDataGridViewTextBoxColumn.DataPropertyName = "Cin";
            this.cinDataGridViewTextBoxColumn.FillWeight = 98.90017F;
            this.cinDataGridViewTextBoxColumn.HeaderText = "Cin";
            this.cinDataGridViewTextBoxColumn.Name = "cinDataGridViewTextBoxColumn";
            this.cinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.FillWeight = 98.90017F;
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.FillWeight = 98.90017F;
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UsersPageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UsersPageUserControl";
            this.Size = new System.Drawing.Size(1044, 681);
            this.Load += new System.EventHandler(this.UsersPageUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportToExelButton)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewUserButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label mangerUserCountLabel;
        private Label label11;
        private Label administratorUserCountLabel;
        private Label label9;
        private Label usersCountLabel;
        private Label label4;
        private BunifuImageButton printButton;
        private BunifuImageButton exportToExelButton;
        private Panel panel3;
        private Panel panel2;
        private BunifuImageButton deleteButton;
        private BunifuImageButton addNewUserButton;
        private BunifuImageButton searchButton;
        private BunifuMetroTextbox searchTextBox;
        private BunifuDropdown seachFilterDropdown;
        private BunifuImageButton refreshDataGrid;
        private BunifuSeparator bunifuSeparator1;
        private Panel panel1;
        private BunifuCustomLabel bunifuCustomLabel1;
        private BindingSource userBindingSource;
        private BunifuCustomDataGrid usersDataGrid;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    }
}
