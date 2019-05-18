using System.ComponentModel;
using System.Windows.Forms;

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


        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentsPageUserControl));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pageContentNavigator = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.newRentPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.kryptonMonthCalendar1 = new ComponentFactory.Krypton.Toolkit.KryptonMonthCalendar();
            this.rentChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.newRentPageContentPanel = new System.Windows.Forms.Panel();
            this.rentsPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.searchFilterComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.refreshDataGridViewButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.searchButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.searchTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.addNewCarButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.rentDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.rentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manageByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewRentPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.viewRentContenPanel = new System.Windows.Forms.Panel();
            this.viewRentBillContenPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageContentNavigator)).BeginInit();
            this.pageContentNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newRentPage)).BeginInit();
            this.newRentPage.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentsPage)).BeginInit();
            this.rentsPage.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchFilterComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewRentPage)).BeginInit();
            this.viewRentPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kryptonPanel1);
            this.panel1.Controls.Add(this.kryptonHeader1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 100);
            this.panel1.TabIndex = 7;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 80);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.kryptonPanel1.Size = new System.Drawing.Size(911, 10);
            this.kryptonPanel1.TabIndex = 3;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Location = new System.Drawing.Point(23, 10);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kryptonHeader1.Size = new System.Drawing.Size(237, 56);
            this.kryptonHeader1.TabIndex = 2;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Manage your Rents";
            this.kryptonHeader1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader1.Values.Image")));
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.pageContentNavigator);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 545);
            this.panel2.TabIndex = 8;
            // 
            // pageContentNavigator
            // 
            this.pageContentNavigator.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.ContextNextPrevious;
            this.pageContentNavigator.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.pageContentNavigator.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.pageContentNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageContentNavigator.Location = new System.Drawing.Point(0, 0);
            this.pageContentNavigator.Name = "pageContentNavigator";
            this.pageContentNavigator.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.HeaderGroupTab;
            this.pageContentNavigator.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabLowProfile;
            this.pageContentNavigator.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.newRentPage,
            this.rentsPage,
            this.viewRentPage});
            this.pageContentNavigator.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.pageContentNavigator.SelectedIndex = 1;
            this.pageContentNavigator.Size = new System.Drawing.Size(911, 545);
            this.pageContentNavigator.TabIndex = 0;
            this.pageContentNavigator.Text = "pageContentNavigator";
            this.pageContentNavigator.Selected += new System.EventHandler<ComponentFactory.Krypton.Navigator.KryptonPageEventArgs>(this.pageContentNavigator_Selected);
            // 
            // newRentPage
            // 
            this.newRentPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.newRentPage.Controls.Add(this.panel3);
            this.newRentPage.Controls.Add(this.newRentPageContentPanel);
            this.newRentPage.Flags = 63488;
            this.newRentPage.LastVisibleSet = true;
            this.newRentPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.newRentPage.Name = "newRentPage";
            this.newRentPage.Size = new System.Drawing.Size(909, 466);
            this.newRentPage.Text = "New";
            this.newRentPage.TextDescription = "register  new rents";
            this.newRentPage.TextTitle = "New rent";
            this.newRentPage.ToolTipTitle = "Create new rent";
            this.newRentPage.UniqueName = "4AF952CD9BD04B56308876872C8615CB";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.kryptonMonthCalendar1);
            this.panel3.Controls.Add(this.rentChart);
            this.panel3.Location = new System.Drawing.Point(574, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 466);
            this.panel3.TabIndex = 3;
            // 
            // kryptonMonthCalendar1
            // 
            this.kryptonMonthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonMonthCalendar1.Location = new System.Drawing.Point(29, 6);
            this.kryptonMonthCalendar1.Name = "kryptonMonthCalendar1";
            this.kryptonMonthCalendar1.Size = new System.Drawing.Size(230, 184);
            this.kryptonMonthCalendar1.TabIndex = 1;
            // 
            // rentChart
            // 
            this.rentChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.rentChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.rentChart.Legends.Add(legend1);
            this.rentChart.Location = new System.Drawing.Point(15, 205);
            this.rentChart.Name = "rentChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            series1.Legend = "Legend1";
            series1.Name = "Rents";
            series1.YValuesPerPoint = 6;
            this.rentChart.Series.Add(series1);
            this.rentChart.Size = new System.Drawing.Size(296, 241);
            this.rentChart.TabIndex = 2;
            this.rentChart.Text = "chart1";
            // 
            // newRentPageContentPanel
            // 
            this.newRentPageContentPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.newRentPageContentPanel.Location = new System.Drawing.Point(0, 0);
            this.newRentPageContentPanel.Name = "newRentPageContentPanel";
            this.newRentPageContentPanel.Size = new System.Drawing.Size(568, 466);
            this.newRentPageContentPanel.TabIndex = 2;
            // 
            // rentsPage
            // 
            this.rentsPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.rentsPage.Controls.Add(this.panel5);
            this.rentsPage.Controls.Add(this.rentDataGridView);
            this.rentsPage.Flags = 65534;
            this.rentsPage.LastVisibleSet = true;
            this.rentsPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.rentsPage.Name = "rentsPage";
            this.rentsPage.Size = new System.Drawing.Size(909, 466);
            this.rentsPage.Text = "Rent List";
            this.rentsPage.TextDescription = "view your rents and make update";
            this.rentsPage.TextTitle = "Rent list page";
            this.rentsPage.ToolTipTitle = "Page ToolTip";
            this.rentsPage.UniqueName = "AFF22DDBAF1A470EF79EF473FB02B051";
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
            this.panel5.Size = new System.Drawing.Size(909, 61);
            this.panel5.TabIndex = 6;
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
            this.refreshDataGridViewButton.Click += new System.EventHandler(this.RefreshDataGridViewButton_Click);
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
            // 
            // addNewCarButton
            // 
            this.addNewCarButton.Location = new System.Drawing.Point(437, 28);
            this.addNewCarButton.Name = "addNewCarButton";
            this.addNewCarButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.addNewCarButton.Size = new System.Drawing.Size(57, 25);
            this.addNewCarButton.TabIndex = 0;
            this.addNewCarButton.Values.Text = "add";
            this.addNewCarButton.Click += new System.EventHandler(this.AddNewCarButton_Click);
            // 
            // rentDataGridView
            // 
            this.rentDataGridView.AllowUserToAddRows = false;
            this.rentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rentDataGridView.AutoGenerateColumns = false;
            this.rentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.rentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentIdDataGridViewTextBoxColumn,
            this.carDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.manageByDataGridViewTextBoxColumn,
            this.billDataGridViewTextBoxColumn,
            this.dateStartDataGridViewTextBoxColumn,
            this.dateEndDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.NumberOfDays});
            this.rentDataGridView.DataSource = this.rentBindingSource;
            this.rentDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.rentDataGridView.Location = new System.Drawing.Point(2, 67);
            this.rentDataGridView.Name = "rentDataGridView";
            this.rentDataGridView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.rentDataGridView.ReadOnly = true;
            this.rentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rentDataGridView.Size = new System.Drawing.Size(904, 396);
            this.rentDataGridView.TabIndex = 0;
            this.rentDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentDataGridView_CellDoubleClick);
            this.rentDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.RentsDataGridView_CellFormatting);
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
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dateEndDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateEndDataGridViewTextBoxColumn.HeaderText = "Date End";
            this.dateEndDataGridViewTextBoxColumn.Name = "dateEndDataGridViewTextBoxColumn";
            this.dateEndDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateEndDataGridViewTextBoxColumn.Width = 77;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.stateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateDataGridViewTextBoxColumn.Width = 62;
            // 
            // NumberOfDays
            // 
            this.NumberOfDays.DataPropertyName = "NumberOfDays";
            this.NumberOfDays.HeaderText = "Number Of Days";
            this.NumberOfDays.Name = "NumberOfDays";
            this.NumberOfDays.ReadOnly = true;
            this.NumberOfDays.Width = 91;
            // 
            // rentBindingSource
            // 
            this.rentBindingSource.DataSource = typeof(CarRentalApp.Core.domain.Rent);
            // 
            // viewRentPage
            // 
            this.viewRentPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.viewRentPage.AutoScroll = true;
            this.viewRentPage.Controls.Add(this.viewRentContenPanel);
            this.viewRentPage.Controls.Add(this.viewRentBillContenPanel);
            this.viewRentPage.Flags = 65534;
            this.viewRentPage.LastVisibleSet = true;
            this.viewRentPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.viewRentPage.Name = "viewRentPage";
            this.viewRentPage.Size = new System.Drawing.Size(909, 466);
            this.viewRentPage.Text = "View";
            this.viewRentPage.TextDescription = "View rent in details, and make update";
            this.viewRentPage.TextTitle = "View a rent";
            this.viewRentPage.ToolTipTitle = "View a rent";
            this.viewRentPage.UniqueName = "F1CC5E67D899430D1AB6E3C2EA2B205E";
            // 
            // viewRentContenPanel
            // 
            this.viewRentContenPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.viewRentContenPanel.AutoScroll = true;
            this.viewRentContenPanel.Location = new System.Drawing.Point(12, 3);
            this.viewRentContenPanel.Name = "viewRentContenPanel";
            this.viewRentContenPanel.Size = new System.Drawing.Size(568, 297);
            this.viewRentContenPanel.TabIndex = 3;
            // 
            // viewRentBillContenPanel
            // 
            this.viewRentBillContenPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.viewRentBillContenPanel.AutoScroll = true;
            this.viewRentBillContenPanel.Location = new System.Drawing.Point(586, 3);
            this.viewRentBillContenPanel.Name = "viewRentBillContenPanel";
            this.viewRentBillContenPanel.Size = new System.Drawing.Size(568, 297);
            this.viewRentBillContenPanel.TabIndex = 3;
            // 
            // RentsPageUserControl
            // 
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RentsPageUserControl";
            this.Size = new System.Drawing.Size(911, 645);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageContentNavigator)).EndInit();
            this.pageContentNavigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newRentPage)).EndInit();
            this.newRentPage.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rentChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentsPage)).EndInit();
            this.rentsPage.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchFilterComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewRentPage)).EndInit();
            this.viewRentPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private Panel panel2;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator pageContentNavigator;
        private ComponentFactory.Krypton.Navigator.KryptonPage newRentPage;
        private ComponentFactory.Krypton.Navigator.KryptonPage rentsPage;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView rentDataGridView;
        private Panel panel5;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox searchFilterComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton refreshDataGridViewButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton searchButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox searchTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addNewCarButton;
        private BindingSource rentBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonMonthCalendar kryptonMonthCalendar1;
        private Panel newRentPageContentPanel;
        private Panel panel3;
        private ComponentFactory.Krypton.Navigator.KryptonPage viewRentPage;
        private Panel viewRentBillContenPanel;
        private Panel viewRentContenPanel;
        private DataGridViewTextBoxColumn rentIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn manageByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn billDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateStartDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateEndDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn NumberOfDays;
        private System.Windows.Forms.DataVisualization.Charting.Chart rentChart;
    }

}
