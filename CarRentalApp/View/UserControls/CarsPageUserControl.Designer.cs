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
            this.selectedCarPictureBox = new System.Windows.Forms.PictureBox();
            this.carImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensePlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAvailableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nextDrainDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchFilterComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedCarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.carDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.carDataGridView.Location = new System.Drawing.Point(0, 61);
            this.carDataGridView.Name = "carDataGridView";
            this.carDataGridView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.carDataGridView.ReadOnly = true;
            this.carDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carDataGridView.Size = new System.Drawing.Size(583, 510);
            this.carDataGridView.TabIndex = 6;
            this.carDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.CarsDataGridView_CellFormatting);
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
            this.panel3.Controls.Add(this.selectedCarPictureBox);
            this.panel3.Location = new System.Drawing.Point(612, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(432, 571);
            this.panel3.TabIndex = 8;
            // 
            // selectedCarPictureBox
            // 
            this.selectedCarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("selectedCarPictureBox.Image")));
            this.selectedCarPictureBox.Location = new System.Drawing.Point(72, 6);
            this.selectedCarPictureBox.Name = "selectedCarPictureBox";
            this.selectedCarPictureBox.Size = new System.Drawing.Size(291, 200);
            this.selectedCarPictureBox.TabIndex = 0;
            this.selectedCarPictureBox.TabStop = false;
            // 
            // carImageDataGridViewImageColumn
            // 
            this.carImageDataGridViewImageColumn.DataPropertyName = "CarImage";
            this.carImageDataGridViewImageColumn.HeaderText = "CarImage";
            this.carImageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.carImageDataGridViewImageColumn.Name = "carImageDataGridViewImageColumn";
            this.carImageDataGridViewImageColumn.ReadOnly = true;
            this.carImageDataGridViewImageColumn.Width = 68;
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
            this.licensePlateDataGridViewTextBoxColumn.HeaderText = "LicensePlate";
            this.licensePlateDataGridViewTextBoxColumn.Name = "licensePlateDataGridViewTextBoxColumn";
            this.licensePlateDataGridViewTextBoxColumn.ReadOnly = true;
            this.licensePlateDataGridViewTextBoxColumn.Width = 101;
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
            this.pricePerDayDataGridViewTextBoxColumn.HeaderText = "PricePerDay";
            this.pricePerDayDataGridViewTextBoxColumn.Name = "pricePerDayDataGridViewTextBoxColumn";
            this.pricePerDayDataGridViewTextBoxColumn.ReadOnly = true;
            this.pricePerDayDataGridViewTextBoxColumn.Width = 99;
            // 
            // isAvailableDataGridViewCheckBoxColumn
            // 
            this.isAvailableDataGridViewCheckBoxColumn.DataPropertyName = "IsAvailable";
            this.isAvailableDataGridViewCheckBoxColumn.HeaderText = "IsAvailable";
            this.isAvailableDataGridViewCheckBoxColumn.Name = "isAvailableDataGridViewCheckBoxColumn";
            this.isAvailableDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isAvailableDataGridViewCheckBoxColumn.Width = 73;
            // 
            // nextDrainDateDataGridViewTextBoxColumn
            // 
            this.nextDrainDateDataGridViewTextBoxColumn.DataPropertyName = "NextDrainDate";
            this.nextDrainDateDataGridViewTextBoxColumn.HeaderText = "NextDrainDate";
            this.nextDrainDateDataGridViewTextBoxColumn.Name = "nextDrainDateDataGridViewTextBoxColumn";
            this.nextDrainDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.nextDrainDateDataGridViewTextBoxColumn.Width = 112;
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
        private PictureBox selectedCarPictureBox;
        private DataGridViewImageColumn carImageDataGridViewImageColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn licensePlateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn classificationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pricePerDayDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isAvailableDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn nextDrainDateDataGridViewTextBoxColumn;
    }
}
