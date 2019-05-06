using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace CarRentalApp.View.UserControls
{
    partial class RentUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentUserControl));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.saveButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.nextButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.validationLabel = new System.Windows.Forms.Label();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.checkButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.rentStateDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.carsDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.clientsDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.rentBillNumLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.endDatePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.startDatePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCards1.BorderRadius = 30;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkSlateGray;
            this.bunifuCards1.Controls.Add(this.saveButton);
            this.bunifuCards1.Controls.Add(this.nextButton);
            this.bunifuCards1.Controls.Add(this.validationLabel);
            this.bunifuCards1.Controls.Add(this.bunifuCheckbox1);
            this.bunifuCards1.Controls.Add(this.checkButton);
            this.bunifuCards1.Controls.Add(this.bunifuImageButton1);
            this.bunifuCards1.Controls.Add(this.rentStateDropDown);
            this.bunifuCards1.Controls.Add(this.carsDropDown);
            this.bunifuCards1.Controls.Add(this.clientsDropDown);
            this.bunifuCards1.Controls.Add(this.rentBillNumLabel);
            this.bunifuCards1.Controls.Add(this.label6);
            this.bunifuCards1.Controls.Add(this.label5);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.endDatePicker);
            this.bunifuCards1.Controls.Add(this.startDatePicker);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(5, 5);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(499, 510);
            this.bunifuCards1.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.ActiveBorderThickness = 1;
            this.saveButton.ActiveCornerRadius = 20;
            this.saveButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.saveButton.ActiveForecolor = System.Drawing.Color.White;
            this.saveButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.saveButton.BackColor = System.Drawing.SystemColors.Window;
            this.saveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveButton.BackgroundImage")));
            this.saveButton.ButtonText = "Save";
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.saveButton.IdleBorderThickness = 1;
            this.saveButton.IdleCornerRadius = 20;
            this.saveButton.IdleFillColor = System.Drawing.Color.White;
            this.saveButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.saveButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.saveButton.Location = new System.Drawing.Point(373, 444);
            this.saveButton.Margin = new System.Windows.Forms.Padding(5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 48);
            this.saveButton.TabIndex = 12;
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.ActiveBorderThickness = 1;
            this.nextButton.ActiveCornerRadius = 20;
            this.nextButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.nextButton.ActiveForecolor = System.Drawing.Color.White;
            this.nextButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.nextButton.BackColor = System.Drawing.SystemColors.Window;
            this.nextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextButton.BackgroundImage")));
            this.nextButton.ButtonText = "Next";
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.nextButton.IdleBorderThickness = 1;
            this.nextButton.IdleCornerRadius = 20;
            this.nextButton.IdleFillColor = System.Drawing.Color.White;
            this.nextButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.nextButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.nextButton.Location = new System.Drawing.Point(290, 444);
            this.nextButton.Margin = new System.Windows.Forms.Padding(5);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 48);
            this.nextButton.TabIndex = 12;
            this.nextButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nextButton.Visible = false;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // validationLabel
            // 
            this.validationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.validationLabel.AutoSize = true;
            this.validationLabel.BackColor = System.Drawing.Color.Transparent;
            this.validationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validationLabel.ForeColor = System.Drawing.Color.Crimson;
            this.validationLabel.Location = new System.Drawing.Point(34, 412);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(229, 16);
            this.validationLabel.TabIndex = 10;
            this.validationLabel.Text = "Rent information are not Valides";
            this.validationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.validationLabel.Visible = false;
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.Lime;
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.Lime;
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(428, 223);
            this.bunifuCheckbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 9;
            // 
            // checkButton
            // 
            this.checkButton.Active = false;
            this.checkButton.Activecolor = System.Drawing.Color.Blue;
            this.checkButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkButton.BorderRadius = 5;
            this.checkButton.ButtonText = "Check";
            this.checkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkButton.DisabledColor = System.Drawing.Color.Gray;
            this.checkButton.Iconcolor = System.Drawing.Color.Transparent;
            this.checkButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("checkButton.Iconimage")));
            this.checkButton.Iconimage_right = null;
            this.checkButton.Iconimage_right_Selected = null;
            this.checkButton.Iconimage_Selected = null;
            this.checkButton.IconMarginLeft = 0;
            this.checkButton.IconMarginRight = 0;
            this.checkButton.IconRightVisible = true;
            this.checkButton.IconRightZoom = 0D;
            this.checkButton.IconVisible = true;
            this.checkButton.IconZoom = 90D;
            this.checkButton.IsTab = false;
            this.checkButton.Location = new System.Drawing.Point(37, 444);
            this.checkButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkButton.MinimumSize = new System.Drawing.Size(182, 48);
            this.checkButton.Name = "checkButton";
            this.checkButton.Normalcolor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkButton.OnHovercolor = System.Drawing.Color.Blue;
            this.checkButton.OnHoverTextColor = System.Drawing.Color.White;
            this.checkButton.selected = false;
            this.checkButton.Size = new System.Drawing.Size(182, 48);
            this.checkButton.TabIndex = 8;
            this.checkButton.Text = "Check";
            this.checkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkButton.Textcolor = System.Drawing.Color.White;
            this.checkButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(419, 159);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(36, 36);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // rentStateDropDown
            // 
            this.rentStateDropDown.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rentStateDropDown.BorderRadius = 3;
            this.rentStateDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.rentStateDropDown.ForeColor = System.Drawing.Color.White;
            this.rentStateDropDown.items = new string[] {
        "PEDDING",
        "CONFIRMED",
        "CANCELED"};
            this.rentStateDropDown.Location = new System.Drawing.Point(165, 295);
            this.rentStateDropDown.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.rentStateDropDown.MinimumSize = new System.Drawing.Size(290, 36);
            this.rentStateDropDown.Name = "rentStateDropDown";
            this.rentStateDropDown.NomalColor = System.Drawing.Color.Blue;
            this.rentStateDropDown.onHoverColor = System.Drawing.Color.SeaGreen;
            this.rentStateDropDown.selectedIndex = -1;
            this.rentStateDropDown.Size = new System.Drawing.Size(290, 36);
            this.rentStateDropDown.TabIndex = 4;
            // 
            // carsDropDown
            // 
            this.carsDropDown.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.carsDropDown.BorderRadius = 3;
            this.carsDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.carsDropDown.ForeColor = System.Drawing.Color.White;
            this.carsDropDown.items = new string[0];
            this.carsDropDown.Location = new System.Drawing.Point(165, 215);
            this.carsDropDown.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.carsDropDown.Name = "carsDropDown";
            this.carsDropDown.NomalColor = System.Drawing.Color.DimGray;
            this.carsDropDown.onHoverColor = System.Drawing.Color.Blue;
            this.carsDropDown.selectedIndex = -1;
            this.carsDropDown.Size = new System.Drawing.Size(248, 36);
            this.carsDropDown.TabIndex = 4;
            // 
            // clientsDropDown
            // 
            this.clientsDropDown.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clientsDropDown.BorderRadius = 3;
            this.clientsDropDown.DisabledColor = System.Drawing.Color.Gray;
            this.clientsDropDown.ForeColor = System.Drawing.Color.White;
            this.clientsDropDown.items = new string[0];
            this.clientsDropDown.Location = new System.Drawing.Point(165, 159);
            this.clientsDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.clientsDropDown.Name = "clientsDropDown";
            this.clientsDropDown.NomalColor = System.Drawing.Color.DimGray;
            this.clientsDropDown.onHoverColor = System.Drawing.Color.Blue;
            this.clientsDropDown.selectedIndex = -1;
            this.clientsDropDown.Size = new System.Drawing.Size(248, 36);
            this.clientsDropDown.TabIndex = 4;
            // 
            // rentBillNumLabel
            // 
            this.rentBillNumLabel.AutoSize = true;
            this.rentBillNumLabel.BackColor = System.Drawing.Color.Gold;
            this.rentBillNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentBillNumLabel.Location = new System.Drawing.Point(165, 361);
            this.rentBillNumLabel.MinimumSize = new System.Drawing.Size(255, 36);
            this.rentBillNumLabel.Name = "rentBillNumLabel";
            this.rentBillNumLabel.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.rentBillNumLabel.Size = new System.Drawing.Size(255, 36);
            this.rentBillNumLabel.TabIndex = 3;
            this.rentBillNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 360);
            this.label6.MinimumSize = new System.Drawing.Size(0, 36);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label6.Size = new System.Drawing.Size(72, 36);
            this.label6.TabIndex = 3;
            this.label6.Text = "Bill num";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 294);
            this.label5.MinimumSize = new System.Drawing.Size(0, 36);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label5.Size = new System.Drawing.Size(57, 36);
            this.label5.TabIndex = 3;
            this.label5.Text = "Statut";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 215);
            this.label4.MinimumSize = new System.Drawing.Size(0, 36);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label4.Size = new System.Drawing.Size(42, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Car";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 159);
            this.label3.MinimumSize = new System.Drawing.Size(0, 36);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label3.Size = new System.Drawing.Size(57, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Client";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 98);
            this.label2.MinimumSize = new System.Drawing.Size(0, 36);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label2.Size = new System.Drawing.Size(98, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date of end";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.MinimumSize = new System.Drawing.Size(0, 36);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label1.Size = new System.Drawing.Size(102, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date of start";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endDatePicker
            // 
            this.endDatePicker.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.endDatePicker.BorderRadius = 3;
            this.endDatePicker.ForeColor = System.Drawing.Color.White;
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDatePicker.FormatCustom = "dd/MM/yyyy HH:mm";
            this.endDatePicker.Location = new System.Drawing.Point(165, 98);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.endDatePicker.MaximumSize = new System.Drawing.Size(0, 49);
            this.endDatePicker.MinimumSize = new System.Drawing.Size(290, 36);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(290, 36);
            this.endDatePicker.TabIndex = 2;
            this.endDatePicker.Value = new System.DateTime(2019, 5, 5, 8, 21, 28, 0);
            // 
            // startDatePicker
            // 
            this.startDatePicker.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.startDatePicker.BorderRadius = 3;
            this.startDatePicker.ForeColor = System.Drawing.Color.White;
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.FormatCustom = "dd/MM/yyyy HH:mm";
            this.startDatePicker.Location = new System.Drawing.Point(165, 39);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.startDatePicker.MaximumSize = new System.Drawing.Size(0, 39);
            this.startDatePicker.MinimumSize = new System.Drawing.Size(290, 36);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(290, 36);
            this.startDatePicker.TabIndex = 2;
            this.startDatePicker.Value = new System.DateTime(2019, 5, 5, 8, 21, 28, 0);
            // 
            // RentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards1);
            this.MinimumSize = new System.Drawing.Size(509, 520);
            this.Name = "RentUserControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(509, 520);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuCards bunifuCards1;
        private BunifuCheckbox bunifuCheckbox1;
        private BunifuImageButton bunifuImageButton1;
        private BunifuDropdown rentStateDropDown;
        private BunifuDropdown carsDropDown;
        private BunifuDropdown clientsDropDown;
        private Label rentBillNumLabel;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private BunifuDatepicker endDatePicker;
        private BunifuDatepicker startDatePicker;
        private Label validationLabel;
        private BunifuFlatButton checkButton;
        private BunifuThinButton2 nextButton;
        private BunifuThinButton2 saveButton;
    }
}
