using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace CarRentalApp.View.Forms
{
    partial class CarForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarForm));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.closeButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.saveButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.editButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.carNameTextBox = new System.Windows.Forms.TextBox();
            this.carLicensePlateTextBox = new System.Windows.Forms.TextBox();
            this.carDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addNewClassificationButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.carNextDrainDatepicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.carPurchaseDatepicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.carClassificationDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.carPricePerDayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.currencySymbolLabel = new System.Windows.Forms.Label();
            this.validationLabel = new System.Windows.Forms.Label();
            this.bunifuCards1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addNewClassificationButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carPricePerDayNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuCards1.BorderRadius = 0;
            this.bunifuCards1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Transparent;
            this.bunifuCards1.Controls.Add(this.closeButton);
            this.bunifuCards1.Controls.Add(this.panel1);
            this.bunifuCards1.Controls.Add(this.saveButton);
            this.bunifuCards1.Controls.Add(this.editButton);
            this.bunifuCards1.Controls.Add(this.carNameTextBox);
            this.bunifuCards1.Controls.Add(this.carLicensePlateTextBox);
            this.bunifuCards1.Controls.Add(this.carDescriptionTextBox);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.NameLabel);
            this.bunifuCards1.Controls.Add(this.label7);
            this.bunifuCards1.Controls.Add(this.label5);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.addNewClassificationButton);
            this.bunifuCards1.Controls.Add(this.carNextDrainDatepicker);
            this.bunifuCards1.Controls.Add(this.carPurchaseDatepicker);
            this.bunifuCards1.Controls.Add(this.carClassificationDropDown);
            this.bunifuCards1.Controls.Add(this.pictureBox1);
            this.bunifuCards1.Controls.Add(this.bunifuCards2);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(868, 632);
            this.bunifuCards1.TabIndex = 9;
            // 
            // closeButton
            // 
            this.closeButton.ActiveBorderThickness = 1;
            this.closeButton.ActiveCornerRadius = 20;
            this.closeButton.ActiveFillColor = System.Drawing.Color.Crimson;
            this.closeButton.ActiveForecolor = System.Drawing.Color.White;
            this.closeButton.ActiveLineColor = System.Drawing.Color.Chartreuse;
            this.closeButton.BackColor = System.Drawing.SystemColors.Control;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.ButtonText = "Close";
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.closeButton.IdleBorderThickness = 1;
            this.closeButton.IdleCornerRadius = 20;
            this.closeButton.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.closeButton.IdleForecolor = System.Drawing.Color.DimGray;
            this.closeButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.closeButton.Location = new System.Drawing.Point(285, 545);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(120, 40);
            this.closeButton.TabIndex = 19;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(457, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 528);
            this.panel1.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Car extra info";
            // 
            // saveButton
            // 
            this.saveButton.ActiveBorderThickness = 1;
            this.saveButton.ActiveCornerRadius = 20;
            this.saveButton.ActiveFillColor = System.Drawing.Color.ForestGreen;
            this.saveButton.ActiveForecolor = System.Drawing.Color.White;
            this.saveButton.ActiveLineColor = System.Drawing.Color.Chartreuse;
            this.saveButton.BackColor = System.Drawing.SystemColors.Control;
            this.saveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveButton.BackgroundImage")));
            this.saveButton.ButtonText = "Save";
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.saveButton.IdleBorderThickness = 1;
            this.saveButton.IdleCornerRadius = 20;
            this.saveButton.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.saveButton.IdleForecolor = System.Drawing.Color.DimGray;
            this.saveButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.saveButton.Location = new System.Drawing.Point(153, 545);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 40);
            this.saveButton.TabIndex = 20;
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // editButton
            // 
            this.editButton.ActiveBorderThickness = 1;
            this.editButton.ActiveCornerRadius = 20;
            this.editButton.ActiveFillColor = System.Drawing.Color.Blue;
            this.editButton.ActiveForecolor = System.Drawing.Color.White;
            this.editButton.ActiveLineColor = System.Drawing.Color.Chartreuse;
            this.editButton.BackColor = System.Drawing.SystemColors.Control;
            this.editButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editButton.BackgroundImage")));
            this.editButton.ButtonText = "Edit";
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.editButton.IdleBorderThickness = 1;
            this.editButton.IdleCornerRadius = 20;
            this.editButton.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.editButton.IdleForecolor = System.Drawing.Color.DimGray;
            this.editButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.editButton.Location = new System.Drawing.Point(11, 545);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(120, 40);
            this.editButton.TabIndex = 21;
            this.editButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // carNameTextBox
            // 
            this.carNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carNameTextBox.Location = new System.Drawing.Point(23, 60);
            this.carNameTextBox.Name = "carNameTextBox";
            this.carNameTextBox.Size = new System.Drawing.Size(199, 22);
            this.carNameTextBox.TabIndex = 21;
            // 
            // carLicensePlateTextBox
            // 
            this.carLicensePlateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carLicensePlateTextBox.Location = new System.Drawing.Point(23, 119);
            this.carLicensePlateTextBox.Name = "carLicensePlateTextBox";
            this.carLicensePlateTextBox.Size = new System.Drawing.Size(199, 22);
            this.carLicensePlateTextBox.TabIndex = 21;
            // 
            // carDescriptionTextBox
            // 
            this.carDescriptionTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carDescriptionTextBox.Location = new System.Drawing.Point(23, 407);
            this.carDescriptionTextBox.MaxLength = 2048;
            this.carDescriptionTextBox.Multiline = true;
            this.carDescriptionTextBox.Name = "carDescriptionTextBox";
            this.carDescriptionTextBox.Size = new System.Drawing.Size(428, 93);
            this.carDescriptionTextBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Next drain date";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(20, 40);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(58, 17);
            this.NameLabel.TabIndex = 19;
            this.NameLabel.Text = "Name *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "License Plate *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Classification *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Price Per Day *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Purchase date";
            // 
            // addNewClassificationButton
            // 
            this.addNewClassificationButton.Image = ((System.Drawing.Image)(resources.GetObject("addNewClassificationButton.Image")));
            this.addNewClassificationButton.ImageActive = null;
            this.addNewClassificationButton.Location = new System.Drawing.Point(207, 203);
            this.addNewClassificationButton.Name = "addNewClassificationButton";
            this.addNewClassificationButton.Size = new System.Drawing.Size(32, 32);
            this.addNewClassificationButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addNewClassificationButton.TabIndex = 17;
            this.addNewClassificationButton.TabStop = false;
            this.addNewClassificationButton.Zoom = 10;
            this.addNewClassificationButton.Click += new System.EventHandler(this.AddNewClassificationButton_Click);
            // 
            // carNextDrainDatepicker
            // 
            this.carNextDrainDatepicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.carNextDrainDatepicker.BorderRadius = 0;
            this.carNextDrainDatepicker.ForeColor = System.Drawing.Color.White;
            this.carNextDrainDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.carNextDrainDatepicker.FormatCustom = null;
            this.carNextDrainDatepicker.Location = new System.Drawing.Point(23, 332);
            this.carNextDrainDatepicker.Name = "carNextDrainDatepicker";
            this.carNextDrainDatepicker.Size = new System.Drawing.Size(428, 36);
            this.carNextDrainDatepicker.TabIndex = 15;
            this.carNextDrainDatepicker.Value = new System.DateTime(2019, 5, 3, 20, 14, 6, 18);
            // 
            // carPurchaseDatepicker
            // 
            this.carPurchaseDatepicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.carPurchaseDatepicker.BorderRadius = 0;
            this.carPurchaseDatepicker.ForeColor = System.Drawing.Color.White;
            this.carPurchaseDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.carPurchaseDatepicker.FormatCustom = null;
            this.carPurchaseDatepicker.Location = new System.Drawing.Point(23, 268);
            this.carPurchaseDatepicker.Name = "carPurchaseDatepicker";
            this.carPurchaseDatepicker.Size = new System.Drawing.Size(428, 36);
            this.carPurchaseDatepicker.TabIndex = 16;
            this.carPurchaseDatepicker.Value = new System.DateTime(2019, 5, 3, 20, 14, 6, 18);
            // 
            // carClassificationDropDown
            // 
            this.carClassificationDropDown.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.carClassificationDropDown.BorderRadius = 3;
            this.carClassificationDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.carClassificationDropDown.ForeColor = System.Drawing.Color.White;
            this.carClassificationDropDown.items = new string[0];
            this.carClassificationDropDown.Location = new System.Drawing.Point(23, 202);
            this.carClassificationDropDown.Name = "carClassificationDropDown";
            this.carClassificationDropDown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.carClassificationDropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.carClassificationDropDown.selectedIndex = -1;
            this.carClassificationDropDown.Size = new System.Drawing.Size(178, 35);
            this.carClassificationDropDown.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(253, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 116);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCards2.Controls.Add(this.carPricePerDayNumericUpDown);
            this.bunifuCards2.Controls.Add(this.currencySymbolLabel);
            this.bunifuCards2.Controls.Add(this.validationLabel);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(3, 10);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(457, 528);
            this.bunifuCards2.TabIndex = 25;
            // 
            // carPricePerDayNumericUpDown
            // 
            this.carPricePerDayNumericUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.carPricePerDayNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carPricePerDayNumericUpDown.DecimalPlaces = 2;
            this.carPricePerDayNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carPricePerDayNumericUpDown.ForeColor = System.Drawing.Color.Green;
            this.carPricePerDayNumericUpDown.Location = new System.Drawing.Point(250, 198);
            this.carPricePerDayNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.carPricePerDayNumericUpDown.Name = "carPricePerDayNumericUpDown";
            this.carPricePerDayNumericUpDown.Size = new System.Drawing.Size(121, 29);
            this.carPricePerDayNumericUpDown.TabIndex = 13;
            this.carPricePerDayNumericUpDown.ThousandsSeparator = true;
            // 
            // currencySymbolLabel
            // 
            this.currencySymbolLabel.AutoSize = true;
            this.currencySymbolLabel.BackColor = System.Drawing.SystemColors.Control;
            this.currencySymbolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencySymbolLabel.ForeColor = System.Drawing.Color.Green;
            this.currencySymbolLabel.Location = new System.Drawing.Point(377, 200);
            this.currencySymbolLabel.Name = "currencySymbolLabel";
            this.currencySymbolLabel.Size = new System.Drawing.Size(55, 24);
            this.currencySymbolLabel.TabIndex = 12;
            this.currencySymbolLabel.Text = "MAD";
            this.currencySymbolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // validationLabel
            // 
            this.validationLabel.AutoSize = true;
            this.validationLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validationLabel.ForeColor = System.Drawing.Color.Red;
            this.validationLabel.Location = new System.Drawing.Point(17, 505);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(169, 16);
            this.validationLabel.TabIndex = 23;
            this.validationLabel.Text = "* car information are invalid";
            this.validationLabel.Visible = false;
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 632);
            this.Controls.Add(this.bunifuCards1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CarForm_FormClosing);
            this.Load += new System.EventHandler(this.CarForm_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addNewClassificationButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carPricePerDayNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private OpenFileDialog openFileDialog;
        private BunifuCards bunifuCards1;
        private BunifuImageButton addNewClassificationButton;
        private BunifuDatepicker carNextDrainDatepicker;
        private BunifuDatepicker carPurchaseDatepicker;
        private BunifuDropdown carClassificationDropDown;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox carDescriptionTextBox;
        private Label label3;
        private Label label5;
        private Label label4;
        private TextBox carNameTextBox;
        private TextBox carLicensePlateTextBox;
        private Label NameLabel;
        private Label label7;
        private Label validationLabel;
        private Panel panel1;
        private BunifuCards bunifuCards2;
        private Label label6;
        private BunifuThinButton2 closeButton;
        private BunifuThinButton2 saveButton;
        private BunifuThinButton2 editButton;
        private NumericUpDown carPricePerDayNumericUpDown;
        private Label currencySymbolLabel;
    }
}