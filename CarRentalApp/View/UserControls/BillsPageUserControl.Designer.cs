using System.ComponentModel;

namespace CarRentalApp.View.UserControls
{
    partial class BillsPageUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillsPageUserControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.selectBillComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.selectedBillPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.billDetailsLabel = new System.Windows.Forms.Label();
            this.billAmountLabel = new System.Windows.Forms.Label();
            this.billDateLabel = new System.Windows.Forms.Label();
            this.billRentDateEndLabel = new System.Windows.Forms.Label();
            this.billRentDateStartLabel = new System.Windows.Forms.Label();
            this.billManagedByLabel = new System.Windows.Forms.Label();
            this.billCarLabel = new System.Windows.Forms.Label();
            this.billNumLabel = new System.Windows.Forms.Label();
            this.billRentIdLabel = new System.Windows.Forms.Label();
            this.billClientLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.printButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.billDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.billNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectBillComboBox)).BeginInit();
            this.selectedBillPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.kryptonPanel1);
            this.panel3.Controls.Add(this.kryptonHeader1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1044, 100);
            this.panel3.TabIndex = 2;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 87);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.kryptonPanel1.Size = new System.Drawing.Size(1044, 10);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Location = new System.Drawing.Point(19, 11);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kryptonHeader1.Size = new System.Drawing.Size(236, 70);
            this.kryptonHeader1.TabIndex = 0;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Manage your bills";
            this.kryptonHeader1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader1.Values.Image")));
            // 
            // selectBillComboBox
            // 
            this.selectBillComboBox.DropDownWidth = 121;
            this.selectBillComboBox.Location = new System.Drawing.Point(16, 3);
            this.selectBillComboBox.Name = "selectBillComboBox";
            this.selectBillComboBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.selectBillComboBox.Size = new System.Drawing.Size(268, 21);
            this.selectBillComboBox.TabIndex = 12;
            this.selectBillComboBox.Text = "All";
            this.selectBillComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectBillComboBox_SelectedIndexChanged);
            // 
            // selectedBillPanel
            // 
            this.selectedBillPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.selectedBillPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.selectedBillPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedBillPanel.Controls.Add(this.label9);
            this.selectedBillPanel.Controls.Add(this.billDetailsLabel);
            this.selectedBillPanel.Controls.Add(this.billAmountLabel);
            this.selectedBillPanel.Controls.Add(this.billDateLabel);
            this.selectedBillPanel.Controls.Add(this.billRentDateEndLabel);
            this.selectedBillPanel.Controls.Add(this.billRentDateStartLabel);
            this.selectedBillPanel.Controls.Add(this.billManagedByLabel);
            this.selectedBillPanel.Controls.Add(this.billCarLabel);
            this.selectedBillPanel.Controls.Add(this.billNumLabel);
            this.selectedBillPanel.Controls.Add(this.billRentIdLabel);
            this.selectedBillPanel.Controls.Add(this.billClientLabel);
            this.selectedBillPanel.Controls.Add(this.label3);
            this.selectedBillPanel.Controls.Add(this.label2);
            this.selectedBillPanel.Controls.Add(this.label14);
            this.selectedBillPanel.Controls.Add(this.label4);
            this.selectedBillPanel.Controls.Add(this.label12);
            this.selectedBillPanel.Controls.Add(this.label11);
            this.selectedBillPanel.Controls.Add(this.label1);
            this.selectedBillPanel.Controls.Add(this.label10);
            this.selectedBillPanel.Controls.Add(this.label5);
            this.selectedBillPanel.Location = new System.Drawing.Point(16, 30);
            this.selectedBillPanel.MinimumSize = new System.Drawing.Size(462, 444);
            this.selectedBillPanel.Name = "selectedBillPanel";
            this.selectedBillPanel.Size = new System.Drawing.Size(462, 452);
            this.selectedBillPanel.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(345, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "MAD";
            // 
            // billDetailsLabel
            // 
            this.billDetailsLabel.AutoSize = true;
            this.billDetailsLabel.BackColor = System.Drawing.SystemColors.Window;
            this.billDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billDetailsLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.billDetailsLabel.Location = new System.Drawing.Point(186, 356);
            this.billDetailsLabel.MinimumSize = new System.Drawing.Size(200, 50);
            this.billDetailsLabel.Name = "billDetailsLabel";
            this.billDetailsLabel.Size = new System.Drawing.Size(200, 50);
            this.billDetailsLabel.TabIndex = 21;
            // 
            // billAmountLabel
            // 
            this.billAmountLabel.AutoSize = true;
            this.billAmountLabel.BackColor = System.Drawing.SystemColors.Window;
            this.billAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billAmountLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.billAmountLabel.Location = new System.Drawing.Point(186, 306);
            this.billAmountLabel.MinimumSize = new System.Drawing.Size(150, 21);
            this.billAmountLabel.Name = "billAmountLabel";
            this.billAmountLabel.Size = new System.Drawing.Size(150, 21);
            this.billAmountLabel.TabIndex = 21;
            // 
            // billDateLabel
            // 
            this.billDateLabel.AutoSize = true;
            this.billDateLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.billDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billDateLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.billDateLabel.Location = new System.Drawing.Point(31, 423);
            this.billDateLabel.MinimumSize = new System.Drawing.Size(200, 21);
            this.billDateLabel.Name = "billDateLabel";
            this.billDateLabel.Size = new System.Drawing.Size(200, 21);
            this.billDateLabel.TabIndex = 21;
            // 
            // billRentDateEndLabel
            // 
            this.billRentDateEndLabel.AutoSize = true;
            this.billRentDateEndLabel.BackColor = System.Drawing.SystemColors.Window;
            this.billRentDateEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billRentDateEndLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.billRentDateEndLabel.Location = new System.Drawing.Point(183, 266);
            this.billRentDateEndLabel.MinimumSize = new System.Drawing.Size(200, 21);
            this.billRentDateEndLabel.Name = "billRentDateEndLabel";
            this.billRentDateEndLabel.Size = new System.Drawing.Size(200, 21);
            this.billRentDateEndLabel.TabIndex = 21;
            // 
            // billRentDateStartLabel
            // 
            this.billRentDateStartLabel.AutoSize = true;
            this.billRentDateStartLabel.BackColor = System.Drawing.SystemColors.Window;
            this.billRentDateStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billRentDateStartLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.billRentDateStartLabel.Location = new System.Drawing.Point(183, 225);
            this.billRentDateStartLabel.MinimumSize = new System.Drawing.Size(200, 21);
            this.billRentDateStartLabel.Name = "billRentDateStartLabel";
            this.billRentDateStartLabel.Size = new System.Drawing.Size(200, 21);
            this.billRentDateStartLabel.TabIndex = 21;
            // 
            // billManagedByLabel
            // 
            this.billManagedByLabel.AutoSize = true;
            this.billManagedByLabel.BackColor = System.Drawing.SystemColors.Window;
            this.billManagedByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billManagedByLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.billManagedByLabel.Location = new System.Drawing.Point(186, 177);
            this.billManagedByLabel.MinimumSize = new System.Drawing.Size(200, 21);
            this.billManagedByLabel.Name = "billManagedByLabel";
            this.billManagedByLabel.Size = new System.Drawing.Size(200, 21);
            this.billManagedByLabel.TabIndex = 21;
            // 
            // billCarLabel
            // 
            this.billCarLabel.AutoSize = true;
            this.billCarLabel.BackColor = System.Drawing.SystemColors.Window;
            this.billCarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billCarLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.billCarLabel.Location = new System.Drawing.Point(183, 136);
            this.billCarLabel.MinimumSize = new System.Drawing.Size(200, 21);
            this.billCarLabel.Name = "billCarLabel";
            this.billCarLabel.Size = new System.Drawing.Size(200, 21);
            this.billCarLabel.TabIndex = 22;
            // 
            // billNumLabel
            // 
            this.billNumLabel.AutoSize = true;
            this.billNumLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.billNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billNumLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.billNumLabel.Location = new System.Drawing.Point(118, 23);
            this.billNumLabel.MinimumSize = new System.Drawing.Size(200, 21);
            this.billNumLabel.Name = "billNumLabel";
            this.billNumLabel.Size = new System.Drawing.Size(200, 21);
            this.billNumLabel.TabIndex = 23;
            // 
            // billRentIdLabel
            // 
            this.billRentIdLabel.AutoSize = true;
            this.billRentIdLabel.BackColor = System.Drawing.SystemColors.Window;
            this.billRentIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billRentIdLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.billRentIdLabel.Location = new System.Drawing.Point(118, 60);
            this.billRentIdLabel.MinimumSize = new System.Drawing.Size(200, 21);
            this.billRentIdLabel.Name = "billRentIdLabel";
            this.billRentIdLabel.Size = new System.Drawing.Size(200, 21);
            this.billRentIdLabel.TabIndex = 24;
            // 
            // billClientLabel
            // 
            this.billClientLabel.AutoSize = true;
            this.billClientLabel.BackColor = System.Drawing.SystemColors.Window;
            this.billClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billClientLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.billClientLabel.Location = new System.Drawing.Point(183, 95);
            this.billClientLabel.MinimumSize = new System.Drawing.Size(200, 21);
            this.billClientLabel.Name = "billClientLabel";
            this.billClientLabel.Size = new System.Drawing.Size(200, 21);
            this.billClientLabel.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(33, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Managed By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(31, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Car";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label14.Location = new System.Drawing.Point(31, 271);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "Rent Date End";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(33, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Rent Date Start";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label12.Location = new System.Drawing.Point(31, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "`Bill Num";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(33, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Rent Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(31, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Client";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(31, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(31, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Amount";
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.Location = new System.Drawing.Point(388, 487);
            this.printButton.Name = "printButton";
            this.printButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.printButton.Size = new System.Drawing.Size(90, 25);
            this.printButton.TabIndex = 15;
            this.printButton.Values.Text = "print";
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.selectBillComboBox);
            this.panel1.Controls.Add(this.printButton);
            this.panel1.Controls.Add(this.selectedBillPanel);
            this.panel1.Location = new System.Drawing.Point(3, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 515);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.billDataGridView);
            this.panel2.Location = new System.Drawing.Point(525, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 534);
            this.panel2.TabIndex = 17;
            // 
            // billDataGridView
            // 
            this.billDataGridView.AllowUserToAddRows = false;
            this.billDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.billDataGridView.AutoGenerateColumns = false;
            this.billDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.billDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billNumberDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.rentDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn});
            this.billDataGridView.DataSource = this.billBindingSource;
            this.billDataGridView.Location = new System.Drawing.Point(3, 63);
            this.billDataGridView.Name = "billDataGridView";
            this.billDataGridView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.billDataGridView.ReadOnly = true;
            this.billDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billDataGridView.Size = new System.Drawing.Size(500, 408);
            this.billDataGridView.StateCommon.Background.Color1 = System.Drawing.SystemColors.ControlLight;
            this.billDataGridView.StateCommon.Background.Color2 = System.Drawing.SystemColors.ControlLight;
            this.billDataGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.billDataGridView.TabIndex = 14;
            this.billDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.BillDataGridView_CellFormatting);
            this.billDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillDataGridView_RowEnter);
            this.billDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.BillDataGridView_UserDeletedRow);
            this.billDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.BillDataGridView_UserDeletingRow);
            // 
            // billNumberDataGridViewTextBoxColumn
            // 
            this.billNumberDataGridViewTextBoxColumn.DataPropertyName = "BillNumber";
            this.billNumberDataGridViewTextBoxColumn.HeaderText = "BillNumber";
            this.billNumberDataGridViewTextBoxColumn.Name = "billNumberDataGridViewTextBoxColumn";
            this.billNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.billNumberDataGridViewTextBoxColumn.Width = 96;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 60;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 80;
            // 
            // rentDataGridViewTextBoxColumn
            // 
            this.rentDataGridViewTextBoxColumn.DataPropertyName = "Rent";
            this.rentDataGridViewTextBoxColumn.HeaderText = "Rent";
            this.rentDataGridViewTextBoxColumn.Name = "rentDataGridViewTextBoxColumn";
            this.rentDataGridViewTextBoxColumn.ReadOnly = true;
            this.rentDataGridViewTextBoxColumn.Width = 60;
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            this.detailsDataGridViewTextBoxColumn.ReadOnly = true;
            this.detailsDataGridViewTextBoxColumn.Width = 71;
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataSource = typeof(CarRentalApp.Core.domain.Bill);
            // 
            // BillsPageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "BillsPageUserControl";
            this.Size = new System.Drawing.Size(1044, 681);
            this.Load += new System.EventHandler(this.BillsPageUserControl_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectBillComboBox)).EndInit();
            this.selectedBillPanel.ResumeLayout(false);
            this.selectedBillPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.billDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox selectBillComboBox;
        private System.Windows.Forms.BindingSource billBindingSource;
        private System.Windows.Forms.Panel selectedBillPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label billAmountLabel;
        private System.Windows.Forms.Label billDateLabel;
        private System.Windows.Forms.Label billManagedByLabel;
        private System.Windows.Forms.Label billCarLabel;
        private System.Windows.Forms.Label billNumLabel;
        private System.Windows.Forms.Label billClientLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton printButton;
        private System.Windows.Forms.Label billDetailsLabel;
        private System.Windows.Forms.Label billRentIdLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label billRentDateEndLabel;
        private System.Windows.Forms.Label billRentDateStartLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView billDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn billNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
    }
}
