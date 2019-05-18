namespace CarRentalApp.View.UserControls.Components
{
    partial class UserUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.userPhoneTextBox = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.userLastNameTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.userCinTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.userEmailTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.userFirstNameTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.validationLabel = new System.Windows.Forms.Label();
            this.addMoreButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cancelEditButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.editButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.closeButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.saveButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.userPasswordVisibleCheckBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.userRoleComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.userPasswordTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.usernameTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.userPhoneTextBox);
            this.panel1.Controls.Add(this.userLastNameTextBox);
            this.panel1.Controls.Add(this.userCinTextBox);
            this.panel1.Controls.Add(this.userEmailTextBox);
            this.panel1.Controls.Add(this.userFirstNameTextBox);
            this.panel1.Controls.Add(this.validationLabel);
            this.panel1.Controls.Add(this.addMoreButton);
            this.panel1.Controls.Add(this.cancelEditButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.kryptonPanel1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 593);
            this.panel1.TabIndex = 1;
            // 
            // userPhoneTextBox
            // 
            this.userPhoneTextBox.Location = new System.Drawing.Point(220, 347);
            this.userPhoneTextBox.Mask = "+212 000-000000";
            this.userPhoneTextBox.Name = "userPhoneTextBox";
            this.userPhoneTextBox.Size = new System.Drawing.Size(161, 24);
            this.userPhoneTextBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPhoneTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.userPhoneTextBox.TabIndex = 6;
            this.userPhoneTextBox.Text = "+212    -";
            // 
            // userLastNameTextBox
            // 
            this.userLastNameTextBox.Location = new System.Drawing.Point(25, 294);
            this.userLastNameTextBox.MaxLength = 32;
            this.userLastNameTextBox.Name = "userLastNameTextBox";
            this.userLastNameTextBox.Size = new System.Drawing.Size(356, 23);
            this.userLastNameTextBox.TabIndex = 5;
            // 
            // userCinTextBox
            // 
            this.userCinTextBox.Location = new System.Drawing.Point(25, 347);
            this.userCinTextBox.MaxLength = 32;
            this.userCinTextBox.Name = "userCinTextBox";
            this.userCinTextBox.Size = new System.Drawing.Size(158, 23);
            this.userCinTextBox.TabIndex = 2;
            // 
            // userEmailTextBox
            // 
            this.userEmailTextBox.Location = new System.Drawing.Point(25, 400);
            this.userEmailTextBox.MaxLength = 32;
            this.userEmailTextBox.Name = "userEmailTextBox";
            this.userEmailTextBox.Size = new System.Drawing.Size(356, 23);
            this.userEmailTextBox.TabIndex = 2;
            // 
            // userFirstNameTextBox
            // 
            this.userFirstNameTextBox.Location = new System.Drawing.Point(25, 237);
            this.userFirstNameTextBox.MaxLength = 32;
            this.userFirstNameTextBox.Name = "userFirstNameTextBox";
            this.userFirstNameTextBox.Size = new System.Drawing.Size(356, 23);
            this.userFirstNameTextBox.TabIndex = 2;
            // 
            // validationLabel
            // 
            this.validationLabel.AutoSize = true;
            this.validationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validationLabel.ForeColor = System.Drawing.Color.Red;
            this.validationLabel.Location = new System.Drawing.Point(22, 432);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(179, 16);
            this.validationLabel.TabIndex = 4;
            this.validationLabel.Text = "*  information ar not valid";
            // 
            // addMoreButton
            // 
            this.addMoreButton.Location = new System.Drawing.Point(25, 516);
            this.addMoreButton.Name = "addMoreButton";
            this.addMoreButton.Size = new System.Drawing.Size(104, 37);
            this.addMoreButton.TabIndex = 2;
            this.addMoreButton.Values.Text = "Add more";
            this.addMoreButton.Click += new System.EventHandler(this.AddMoreButton_Click);
            // 
            // cancelEditButton
            // 
            this.cancelEditButton.Location = new System.Drawing.Point(149, 463);
            this.cancelEditButton.Name = "cancelEditButton";
            this.cancelEditButton.Size = new System.Drawing.Size(104, 37);
            this.cancelEditButton.TabIndex = 2;
            this.cancelEditButton.Values.Text = "Cancel";
            this.cancelEditButton.Click += new System.EventHandler(this.CancelEditButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(25, 463);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(104, 37);
            this.editButton.TabIndex = 2;
            this.editButton.Values.Text = "Edit";
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(277, 463);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(104, 37);
            this.closeButton.TabIndex = 2;
            this.closeButton.Values.Text = "Close";
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(149, 516);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(104, 37);
            this.saveButton.TabIndex = 2;
            this.saveButton.Values.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(217, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Phone*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(22, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(22, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "CIN*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(22, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(22, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name*";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.userPasswordVisibleCheckBox);
            this.kryptonPanel1.Controls.Add(this.userRoleComboBox);
            this.kryptonPanel1.Controls.Add(this.userPasswordTextBox);
            this.kryptonPanel1.Controls.Add(this.usernameTextBox);
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Controls.Add(this.label6);
            this.kryptonPanel1.Controls.Add(this.label8);
            this.kryptonPanel1.Location = new System.Drawing.Point(25, 31);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(356, 176);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.SystemColors.ControlDark;
            this.kryptonPanel1.TabIndex = 3;
            // 
            // userPasswordVisibleCheckBox
            // 
            this.userPasswordVisibleCheckBox.Location = new System.Drawing.Point(282, 85);
            this.userPasswordVisibleCheckBox.Name = "userPasswordVisibleCheckBox";
            this.userPasswordVisibleCheckBox.Size = new System.Drawing.Size(57, 20);
            this.userPasswordVisibleCheckBox.TabIndex = 4;
            this.userPasswordVisibleCheckBox.Values.Text = "visible";
            this.userPasswordVisibleCheckBox.CheckedChanged += new System.EventHandler(this.UserPasswordVisibleCheckBox_CheckedChanged);
            // 
            // userRoleComboBox
            // 
            this.userRoleComboBox.DropDownWidth = 207;
            this.userRoleComboBox.Location = new System.Drawing.Point(69, 142);
            this.userRoleComboBox.Name = "userRoleComboBox";
            this.userRoleComboBox.Size = new System.Drawing.Size(207, 21);
            this.userRoleComboBox.TabIndex = 3;
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.Location = new System.Drawing.Point(69, 85);
            this.userPasswordTextBox.MaxLength = 32;
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.Size = new System.Drawing.Size(207, 23);
            this.userPasswordTextBox.TabIndex = 2;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(69, 31);
            this.usernameTextBox.MaxLength = 32;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(207, 23);
            this.usernameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(69, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(69, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(69, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Role*";
            // 
            // UserUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserUserControl";
            this.Size = new System.Drawing.Size(430, 600);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleComboBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox userLastNameTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox userCinTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox userEmailTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox userFirstNameTextBox;
        private System.Windows.Forms.Label validationLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addMoreButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cancelEditButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton editButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton closeButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton saveButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox userRoleComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox userPasswordTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox usernameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox userPhoneTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox userPasswordVisibleCheckBox;
    }
}
