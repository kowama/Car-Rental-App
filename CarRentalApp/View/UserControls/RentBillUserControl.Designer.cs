using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace CarRentalApp.View.UserControls
{
    partial class RentBillUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentBillUserControl));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.billDetailsTextBox = new System.Windows.Forms.RichTextBox();
            this.billAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.billManageByLabel = new System.Windows.Forms.Label();
            this.backButtonLabel = new System.Windows.Forms.LinkLabel();
            this.saveButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.billClientNameLabel = new System.Windows.Forms.Label();
            this.billNumLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.billDateDatePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.currencySymbolLabel = new System.Windows.Forms.Label();
            this.validationLabel = new System.Windows.Forms.Label();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billAmountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCards1.BorderRadius = 30;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkSlateGray;
            this.bunifuCards1.Controls.Add(this.billDetailsTextBox);
            this.bunifuCards1.Controls.Add(this.validationLabel);
            this.bunifuCards1.Controls.Add(this.billAmountNumericUpDown);
            this.bunifuCards1.Controls.Add(this.billManageByLabel);
            this.bunifuCards1.Controls.Add(this.backButtonLabel);
            this.bunifuCards1.Controls.Add(this.saveButton);
            this.bunifuCards1.Controls.Add(this.billClientNameLabel);
            this.bunifuCards1.Controls.Add(this.billNumLabel);
            this.bunifuCards1.Controls.Add(this.label6);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.label8);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.billDateDatePicker);
            this.bunifuCards1.Controls.Add(this.currencySymbolLabel);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(5, 5);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(499, 510);
            this.bunifuCards1.TabIndex = 2;
            // 
            // billDetailsTextBox
            // 
            this.billDetailsTextBox.Location = new System.Drawing.Point(187, 318);
            this.billDetailsTextBox.MaxLength = 2048;
            this.billDetailsTextBox.Name = "billDetailsTextBox";
            this.billDetailsTextBox.Size = new System.Drawing.Size(287, 64);
            this.billDetailsTextBox.TabIndex = 13;
            this.billDetailsTextBox.Text = "";
            // 
            // billAmountNumericUpDown
            // 
            this.billAmountNumericUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.billAmountNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.billAmountNumericUpDown.DecimalPlaces = 2;
            this.billAmountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billAmountNumericUpDown.ForeColor = System.Drawing.Color.Green;
            this.billAmountNumericUpDown.Location = new System.Drawing.Point(220, 148);
            this.billAmountNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.billAmountNumericUpDown.Name = "billAmountNumericUpDown";
            this.billAmountNumericUpDown.Size = new System.Drawing.Size(166, 29);
            this.billAmountNumericUpDown.TabIndex = 11;
            this.billAmountNumericUpDown.ThousandsSeparator = true;
            this.billAmountNumericUpDown.Value = new decimal(new int[] {
            69989,
            0,
            0,
            131072});
            // 
            // billManageByLabel
            // 
            this.billManageByLabel.AutoSize = true;
            this.billManageByLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.billManageByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billManageByLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.billManageByLabel.Location = new System.Drawing.Point(184, 269);
            this.billManageByLabel.MinimumSize = new System.Drawing.Size(290, 36);
            this.billManageByLabel.Name = "billManageByLabel";
            this.billManageByLabel.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.billManageByLabel.Size = new System.Drawing.Size(290, 36);
            this.billManageByLabel.TabIndex = 3;
            this.billManageByLabel.Text = "Latif Karambiri";
            this.billManageByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backButtonLabel
            // 
            this.backButtonLabel.AutoSize = true;
            this.backButtonLabel.Location = new System.Drawing.Point(127, 433);
            this.backButtonLabel.Name = "backButtonLabel";
            this.backButtonLabel.Size = new System.Drawing.Size(65, 16);
            this.backButtonLabel.TabIndex = 9;
            this.backButtonLabel.TabStop = true;
            this.backButtonLabel.Text = "go Back";
            this.backButtonLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackButtonLabel_LinkClicked);
            // 
            // saveButton
            // 
            this.saveButton.Active = false;
            this.saveButton.Activecolor = System.Drawing.Color.Blue;
            this.saveButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveButton.BorderRadius = 5;
            this.saveButton.ButtonText = "Save";
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.DisabledColor = System.Drawing.Color.Gray;
            this.saveButton.Iconcolor = System.Drawing.Color.Transparent;
            this.saveButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("saveButton.Iconimage")));
            this.saveButton.Iconimage_right = null;
            this.saveButton.Iconimage_right_Selected = null;
            this.saveButton.Iconimage_Selected = null;
            this.saveButton.IconMarginLeft = 0;
            this.saveButton.IconMarginRight = 0;
            this.saveButton.IconRightVisible = true;
            this.saveButton.IconRightZoom = 0D;
            this.saveButton.IconVisible = true;
            this.saveButton.IconZoom = 90D;
            this.saveButton.IsTab = false;
            this.saveButton.Location = new System.Drawing.Point(256, 417);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.MinimumSize = new System.Drawing.Size(182, 48);
            this.saveButton.Name = "saveButton";
            this.saveButton.Normalcolor = System.Drawing.SystemColors.ControlDarkDark;
            this.saveButton.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.saveButton.OnHoverTextColor = System.Drawing.Color.White;
            this.saveButton.selected = false;
            this.saveButton.Size = new System.Drawing.Size(182, 48);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Textcolor = System.Drawing.Color.White;
            this.saveButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // billClientNameLabel
            // 
            this.billClientNameLabel.AutoSize = true;
            this.billClientNameLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.billClientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billClientNameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.billClientNameLabel.Location = new System.Drawing.Point(184, 211);
            this.billClientNameLabel.MinimumSize = new System.Drawing.Size(290, 36);
            this.billClientNameLabel.Name = "billClientNameLabel";
            this.billClientNameLabel.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.billClientNameLabel.Size = new System.Drawing.Size(290, 36);
            this.billClientNameLabel.TabIndex = 3;
            this.billClientNameLabel.Text = "Marin Casali";
            this.billClientNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // billNumLabel
            // 
            this.billNumLabel.AutoSize = true;
            this.billNumLabel.BackColor = System.Drawing.Color.Gold;
            this.billNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billNumLabel.Location = new System.Drawing.Point(187, 19);
            this.billNumLabel.MinimumSize = new System.Drawing.Size(290, 36);
            this.billNumLabel.Name = "billNumLabel";
            this.billNumLabel.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.billNumLabel.Size = new System.Drawing.Size(290, 36);
            this.billNumLabel.TabIndex = 3;
            this.billNumLabel.Text = "cd26ccf6-75d6-4521-884f-1693c62ed303";
            this.billNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 19);
            this.label6.MinimumSize = new System.Drawing.Size(0, 36);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label6.Size = new System.Drawing.Size(72, 36);
            this.label6.TabIndex = 3;
            this.label6.Text = "Bill num";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 328);
            this.label3.MinimumSize = new System.Drawing.Size(0, 36);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label3.Size = new System.Drawing.Size(93, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bill Details";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 269);
            this.label4.MinimumSize = new System.Drawing.Size(0, 36);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label4.Size = new System.Drawing.Size(105, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Managed By";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 146);
            this.label8.MinimumSize = new System.Drawing.Size(0, 36);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label8.Size = new System.Drawing.Size(69, 36);
            this.label8.TabIndex = 3;
            this.label8.Text = "Amount";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 211);
            this.label1.MinimumSize = new System.Drawing.Size(0, 36);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label1.Size = new System.Drawing.Size(102, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Client Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 83);
            this.label2.MinimumSize = new System.Drawing.Size(0, 36);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label2.Size = new System.Drawing.Size(51, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // billDateDatePicker
            // 
            this.billDateDatePicker.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.billDateDatePicker.BorderRadius = 3;
            this.billDateDatePicker.ForeColor = System.Drawing.Color.White;
            this.billDateDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.billDateDatePicker.FormatCustom = "dd/MM/yyyy HH:mm";
            this.billDateDatePicker.Location = new System.Drawing.Point(188, 82);
            this.billDateDatePicker.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.billDateDatePicker.MaximumSize = new System.Drawing.Size(0, 49);
            this.billDateDatePicker.MinimumSize = new System.Drawing.Size(290, 36);
            this.billDateDatePicker.Name = "billDateDatePicker";
            this.billDateDatePicker.Size = new System.Drawing.Size(290, 36);
            this.billDateDatePicker.TabIndex = 2;
            this.billDateDatePicker.Value = new System.DateTime(2019, 5, 5, 8, 21, 28, 0);
            // 
            // currencySymbolLabel
            // 
            this.currencySymbolLabel.AutoSize = true;
            this.currencySymbolLabel.BackColor = System.Drawing.SystemColors.Window;
            this.currencySymbolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencySymbolLabel.ForeColor = System.Drawing.Color.Green;
            this.currencySymbolLabel.Location = new System.Drawing.Point(355, 142);
            this.currencySymbolLabel.MinimumSize = new System.Drawing.Size(135, 40);
            this.currencySymbolLabel.Name = "currencySymbolLabel";
            this.currencySymbolLabel.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.currencySymbolLabel.Size = new System.Drawing.Size(135, 40);
            this.currencySymbolLabel.TabIndex = 3;
            this.currencySymbolLabel.Text = "MAD";
            this.currencySymbolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // validationLabel
            // 
            this.validationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.validationLabel.AutoSize = true;
            this.validationLabel.BackColor = System.Drawing.Color.Transparent;
            this.validationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validationLabel.ForeColor = System.Drawing.Color.Crimson;
            this.validationLabel.Location = new System.Drawing.Point(36, 385);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(229, 16);
            this.validationLabel.TabIndex = 12;
            this.validationLabel.Text = "Rent information are not Valides";
            this.validationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.validationLabel.Visible = false;
            // 
            // RentBillUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards1);
            this.MinimumSize = new System.Drawing.Size(509, 520);
            this.Name = "RentBillUserControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(509, 520);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billAmountNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuCards bunifuCards1;
        private BunifuFlatButton saveButton;
        private Label billClientNameLabel;
        private Label billNumLabel;
        private Label label6;
        private Label label4;
        private Label label1;
        private Label label2;
        private BunifuDatepicker billDateDatePicker;
        private Label billManageByLabel;
        private LinkLabel backButtonLabel;
        private Label label8;
        private Label currencySymbolLabel;
        private NumericUpDown billAmountNumericUpDown;
        private RichTextBox billDetailsTextBox;
        private Label label3;
        private Label validationLabel;
    }
}
