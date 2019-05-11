using System.ComponentModel;
using System.Windows.Forms;

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
            this.panel4 = new System.Windows.Forms.Panel();
            this.editButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.rentIdLabel = new System.Windows.Forms.Label();
            this.addNewClientButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.carFilterCheckBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.validationLabel = new System.Windows.Forms.Label();
            this.rentStatusComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.checkButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cancelEditButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.finishedButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.nextButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.rentCarComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rentEndDateTimePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rentClientComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rentStartDateTimePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentStatusComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentClientComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.Controls.Add(this.editButton);
            this.panel4.Controls.Add(this.rentIdLabel);
            this.panel4.Controls.Add(this.addNewClientButton);
            this.panel4.Controls.Add(this.carFilterCheckBox);
            this.panel4.Controls.Add(this.validationLabel);
            this.panel4.Controls.Add(this.rentStatusComboBox);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.saveButton);
            this.panel4.Controls.Add(this.checkButton);
            this.panel4.Controls.Add(this.cancelEditButton);
            this.panel4.Controls.Add(this.finishedButton);
            this.panel4.Controls.Add(this.nextButton);
            this.panel4.Controls.Add(this.rentCarComboBox);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.rentEndDateTimePicker);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.rentClientComboBox);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.rentStartDateTimePicker);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(8, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(493, 504);
            this.panel4.TabIndex = 1;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(50, 426);
            this.editButton.Name = "editButton";
            this.editButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.editButton.Size = new System.Drawing.Size(90, 25);
            this.editButton.TabIndex = 9;
            this.editButton.Values.Text = "Edit";
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // rentIdLabel
            // 
            this.rentIdLabel.AutoSize = true;
            this.rentIdLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.rentIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentIdLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rentIdLabel.Location = new System.Drawing.Point(121, 23);
            this.rentIdLabel.MinimumSize = new System.Drawing.Size(314, 21);
            this.rentIdLabel.Name = "rentIdLabel";
            this.rentIdLabel.Size = new System.Drawing.Size(314, 21);
            this.rentIdLabel.TabIndex = 8;
            this.rentIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addNewClientButton
            // 
            this.addNewClientButton.Location = new System.Drawing.Point(397, 72);
            this.addNewClientButton.Name = "addNewClientButton";
            this.addNewClientButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.addNewClientButton.Size = new System.Drawing.Size(60, 29);
            this.addNewClientButton.TabIndex = 7;
            this.addNewClientButton.Values.Text = "add";
            this.addNewClientButton.Click += new System.EventHandler(this.AddNewClient_Click);
            // 
            // carFilterCheckBox
            // 
            this.carFilterCheckBox.Location = new System.Drawing.Point(395, 122);
            this.carFilterCheckBox.Name = "carFilterCheckBox";
            this.carFilterCheckBox.Size = new System.Drawing.Size(98, 20);
            this.carFilterCheckBox.TabIndex = 6;
            this.carFilterCheckBox.Values.Text = "only available";
            // 
            // validationLabel
            // 
            this.validationLabel.AutoSize = true;
            this.validationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validationLabel.ForeColor = System.Drawing.Color.Red;
            this.validationLabel.Location = new System.Drawing.Point(45, 353);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(156, 16);
            this.validationLabel.TabIndex = 5;
            this.validationLabel.Text = "* infomation  not valid";
            this.validationLabel.Visible = false;
            // 
            // rentStatusComboBox
            // 
            this.rentStatusComboBox.DropDownWidth = 222;
            this.rentStatusComboBox.Location = new System.Drawing.Point(149, 300);
            this.rentStatusComboBox.Name = "rentStatusComboBox";
            this.rentStatusComboBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.rentStatusComboBox.Size = new System.Drawing.Size(244, 21);
            this.rentStatusComboBox.TabIndex = 4;
            this.rentStatusComboBox.Text = "Validated";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date start";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(184, 386);
            this.saveButton.Name = "saveButton";
            this.saveButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.saveButton.Size = new System.Drawing.Size(90, 25);
            this.saveButton.TabIndex = 3;
            this.saveButton.Values.Text = "Save";
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(50, 386);
            this.checkButton.Name = "checkButton";
            this.checkButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.checkButton.Size = new System.Drawing.Size(90, 25);
            this.checkButton.TabIndex = 3;
            this.checkButton.Values.Text = "Check";
            this.checkButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // cancelEditButton
            // 
            this.cancelEditButton.Location = new System.Drawing.Point(303, 386);
            this.cancelEditButton.Name = "cancelEditButton";
            this.cancelEditButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.cancelEditButton.Size = new System.Drawing.Size(90, 25);
            this.cancelEditButton.TabIndex = 3;
            this.cancelEditButton.Values.Text = "Cancel";
            this.cancelEditButton.Visible = false;
            this.cancelEditButton.Click += new System.EventHandler(this.CancelEditButton_Click);
            // 
            // finishedButton
            // 
            this.finishedButton.Location = new System.Drawing.Point(303, 457);
            this.finishedButton.Name = "finishedButton";
            this.finishedButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.finishedButton.Size = new System.Drawing.Size(90, 25);
            this.finishedButton.TabIndex = 3;
            this.finishedButton.Values.Text = "Finished";
            this.finishedButton.Visible = false;
            this.finishedButton.Click += new System.EventHandler(this.FinishedButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(303, 426);
            this.nextButton.Name = "nextButton";
            this.nextButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.nextButton.Size = new System.Drawing.Size(90, 25);
            this.nextButton.TabIndex = 3;
            this.nextButton.Values.Text = "Next";
            this.nextButton.Visible = false;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // rentCarComboBox
            // 
            this.rentCarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rentCarComboBox.DropDownWidth = 222;
            this.rentCarComboBox.Location = new System.Drawing.Point(149, 122);
            this.rentCarComboBox.Name = "rentCarComboBox";
            this.rentCarComboBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.rentCarComboBox.Size = new System.Drawing.Size(244, 21);
            this.rentCarComboBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car";
            // 
            // rentEndDateTimePicker
            // 
            this.rentEndDateTimePicker.Location = new System.Drawing.Point(149, 234);
            this.rentEndDateTimePicker.MaxDate = new System.DateTime(3000, 1, 31, 0, 0, 0, 0);
            this.rentEndDateTimePicker.MinDate = new System.DateTime(1945, 1, 1, 0, 0, 0, 0);
            this.rentEndDateTimePicker.Name = "rentEndDateTimePicker";
            this.rentEndDateTimePicker.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.rentEndDateTimePicker.Size = new System.Drawing.Size(244, 21);
            this.rentEndDateTimePicker.TabIndex = 2;
            this.rentEndDateTimePicker.ValueNullable = new System.DateTime(2019, 5, 11, 3, 55, 53, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date end";
            // 
            // rentClientComboBox
            // 
            this.rentClientComboBox.DropDownWidth = 222;
            this.rentClientComboBox.Location = new System.Drawing.Point(149, 72);
            this.rentClientComboBox.Name = "rentClientComboBox";
            this.rentClientComboBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.rentClientComboBox.Size = new System.Drawing.Size(244, 21);
            this.rentClientComboBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Rent Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client";
            // 
            // rentStartDateTimePicker
            // 
            this.rentStartDateTimePicker.Location = new System.Drawing.Point(149, 176);
            this.rentStartDateTimePicker.MaxDate = new System.DateTime(3000, 1, 31, 0, 0, 0, 0);
            this.rentStartDateTimePicker.MinDate = new System.DateTime(1945, 1, 1, 0, 0, 0, 0);
            this.rentStartDateTimePicker.Name = "rentStartDateTimePicker";
            this.rentStartDateTimePicker.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.rentStartDateTimePicker.Size = new System.Drawing.Size(244, 21);
            this.rentStartDateTimePicker.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Status";
            // 
            // RentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.MinimumSize = new System.Drawing.Size(509, 520);
            this.Name = "RentUserControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(509, 520);
            this.Load += new System.EventHandler(this.RentUserControl_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentStatusComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentClientComboBox)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Panel panel4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox rentStatusComboBox;
        private Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton nextButton;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox rentCarComboBox;
        private Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker rentEndDateTimePicker;
        private Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox rentClientComboBox;
        private Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker rentStartDateTimePicker;
        private Label label5;
        private Label validationLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton saveButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addNewClientButton;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox carFilterCheckBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton checkButton;
        private Label label6;
        private Label rentIdLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton editButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cancelEditButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton finishedButton;
    }
}
