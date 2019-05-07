using Bunifu.Framework.UI;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRentalApp.View.Forms
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.validationLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.firstNameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lastNameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cinTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.emailTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.driverLicenseTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.editButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.closeButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuCards1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.label2.Location = new System.Drawing.Point(48, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.label3.Location = new System.Drawing.Point(291, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "CIN *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.label4.Location = new System.Drawing.Point(45, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(270, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.label6.Location = new System.Drawing.Point(45, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Address";
            // 
            // saveButton
            // 
            this.saveButton.ActiveBorderThickness = 1;
            this.saveButton.ActiveCornerRadius = 20;
            this.saveButton.ActiveFillColor = System.Drawing.Color.ForestGreen;
            this.saveButton.ActiveForecolor = System.Drawing.Color.White;
            this.saveButton.ActiveLineColor = System.Drawing.Color.Chartreuse;
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
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
            this.saveButton.Location = new System.Drawing.Point(151, 469);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 40);
            this.saveButton.TabIndex = 7;
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // validationLabel
            // 
            this.validationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.validationLabel.AutoSize = true;
            this.validationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validationLabel.ForeColor = System.Drawing.Color.Crimson;
            this.validationLabel.Location = new System.Drawing.Point(45, 448);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(246, 16);
            this.validationLabel.TabIndex = 8;
            this.validationLabel.Text = "* Client information are not Valides";
            this.validationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.validationLabel.Visible = false;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(273, 287);
            this.phoneTextBox.Mask = "+212 000-000000";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(127, 15);
            this.phoneTextBox.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.firstNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.firstNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.firstNameTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.firstNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.firstNameTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.firstNameTextBox.HintText = "Enter client first name";
            this.firstNameTextBox.isPassword = false;
            this.firstNameTextBox.LineFocusedColor = System.Drawing.SystemColors.ControlDarkDark;
            this.firstNameTextBox.LineIdleColor = System.Drawing.Color.Transparent;
            this.firstNameTextBox.LineMouseHoverColor = System.Drawing.SystemColors.ControlDark;
            this.firstNameTextBox.LineThickness = 3;
            this.firstNameTextBox.Location = new System.Drawing.Point(45, 42);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTextBox.MaxLength = 32;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(379, 31);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.lastNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.lastNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.lastNameTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.lastNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastNameTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.lastNameTextBox.HintText = "Enter client last name";
            this.lastNameTextBox.isPassword = false;
            this.lastNameTextBox.LineFocusedColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lastNameTextBox.LineIdleColor = System.Drawing.Color.Transparent;
            this.lastNameTextBox.LineMouseHoverColor = System.Drawing.SystemColors.ControlDark;
            this.lastNameTextBox.LineThickness = 3;
            this.lastNameTextBox.Location = new System.Drawing.Point(48, 115);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTextBox.MaxLength = 32767;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(379, 31);
            this.lastNameTextBox.TabIndex = 2;
            this.lastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cinTextBox
            // 
            this.cinTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cinTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cinTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.cinTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cinTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cinTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.cinTextBox.HintText = "Enter  CIN";
            this.cinTextBox.isPassword = false;
            this.cinTextBox.LineFocusedColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cinTextBox.LineIdleColor = System.Drawing.Color.Transparent;
            this.cinTextBox.LineMouseHoverColor = System.Drawing.SystemColors.ControlDark;
            this.cinTextBox.LineThickness = 3;
            this.cinTextBox.Location = new System.Drawing.Point(294, 185);
            this.cinTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cinTextBox.MaxLength = 32767;
            this.cinTextBox.Name = "cinTextBox";
            this.cinTextBox.Size = new System.Drawing.Size(131, 31);
            this.cinTextBox.TabIndex = 4;
            this.cinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // emailTextBox
            // 
            this.emailTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.emailTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.emailTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.emailTextBox.HintText = "exemple@email.com";
            this.emailTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.emailTextBox.isPassword = false;
            this.emailTextBox.LineFocusedColor = System.Drawing.SystemColors.ControlDarkDark;
            this.emailTextBox.LineIdleColor = System.Drawing.Color.Transparent;
            this.emailTextBox.LineMouseHoverColor = System.Drawing.SystemColors.ControlDark;
            this.emailTextBox.LineThickness = 3;
            this.emailTextBox.Location = new System.Drawing.Point(45, 279);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.MaxLength = 64;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(199, 31);
            this.emailTextBox.TabIndex = 5;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.label7.Location = new System.Drawing.Point(270, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.label8.Location = new System.Drawing.Point(48, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Driver License *";
            // 
            // driverLicenseTextBox
            // 
            this.driverLicenseTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.driverLicenseTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.driverLicenseTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.driverLicenseTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.driverLicenseTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.driverLicenseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverLicenseTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.driverLicenseTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.driverLicenseTextBox.HintText = "Enter Driver License";
            this.driverLicenseTextBox.isPassword = false;
            this.driverLicenseTextBox.LineFocusedColor = System.Drawing.SystemColors.ControlDarkDark;
            this.driverLicenseTextBox.LineIdleColor = System.Drawing.Color.Transparent;
            this.driverLicenseTextBox.LineMouseHoverColor = System.Drawing.SystemColors.ControlDark;
            this.driverLicenseTextBox.LineThickness = 3;
            this.driverLicenseTextBox.Location = new System.Drawing.Point(48, 185);
            this.driverLicenseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.driverLicenseTextBox.MaxLength = 32767;
            this.driverLicenseTextBox.Name = "driverLicenseTextBox";
            this.driverLicenseTextBox.Size = new System.Drawing.Size(131, 31);
            this.driverLicenseTextBox.TabIndex = 3;
            this.driverLicenseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(48, 348);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(379, 68);
            this.addressTextBox.TabIndex = 9;
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
            this.editButton.Location = new System.Drawing.Point(48, 481);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(120, 40);
            this.editButton.TabIndex = 7;
            this.editButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.ActiveBorderThickness = 1;
            this.closeButton.ActiveCornerRadius = 20;
            this.closeButton.ActiveFillColor = System.Drawing.Color.Crimson;
            this.closeButton.ActiveForecolor = System.Drawing.Color.White;
            this.closeButton.ActiveLineColor = System.Drawing.Color.Chartreuse;
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
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
            this.closeButton.Location = new System.Drawing.Point(279, 469);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(120, 40);
            this.closeButton.TabIndex = 7;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.closeButton);
            this.bunifuCards1.Controls.Add(this.saveButton);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(28, 12);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(420, 534);
            this.bunifuCards1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 582);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(480, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 450);
            this.panel2.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "User more datails";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(920, 582);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.driverLicenseTextBox);
            this.Controls.Add(this.cinTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.validationLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.AddClientForm_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private BunifuThinButton2 saveButton;
        private Label validationLabel;
        private MaskedTextBox phoneTextBox;
        private BunifuMaterialTextbox firstNameTextBox;
        private BunifuMaterialTextbox lastNameTextBox;
        private BunifuMaterialTextbox cinTextBox;
        private BunifuMaterialTextbox emailTextBox;
        private Label label7;
        private Label label8;
        private BunifuMaterialTextbox driverLicenseTextBox;
        private TextBox addressTextBox;
        private BunifuThinButton2 editButton;
        private BunifuThinButton2 closeButton;
        private BunifuCards bunifuCards1;
        private Panel panel1;
        private Panel panel2;
        private Label label9;
    }
}