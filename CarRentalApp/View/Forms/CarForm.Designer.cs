using System.ComponentModel;
using System.Windows.Forms;
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
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddNewClassificationButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.validationLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.carChoosePicturButton = new System.Windows.Forms.Button();
            this.closeButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.addMoreButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.saveButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.carPictureBox = new System.Windows.Forms.PictureBox();
            this.carDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.carPricePerDayNumericUpDown = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.carClassificationComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.carNextDrainDateTimePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.carPurchaseDateTimePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.carLicensePlateTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.carNameTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carClassificationComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.AddNewClassificationButton);
            this.panel1.Controls.Add(this.validationLabel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.carChoosePicturButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.addMoreButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.carPictureBox);
            this.panel1.Controls.Add(this.carDescriptionTextBox);
            this.panel1.Controls.Add(this.carPricePerDayNumericUpDown);
            this.panel1.Controls.Add(this.carClassificationComboBox);
            this.panel1.Controls.Add(this.carNextDrainDateTimePicker);
            this.panel1.Controls.Add(this.carPurchaseDateTimePicker);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.carLicensePlateTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.carNameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 632);
            this.panel1.TabIndex = 0;
            // 
            // AddNewClassificationButton
            // 
            this.AddNewClassificationButton.Location = new System.Drawing.Point(236, 284);
            this.AddNewClassificationButton.Name = "AddNewClassificationButton";
            this.AddNewClassificationButton.Size = new System.Drawing.Size(42, 25);
            this.AddNewClassificationButton.TabIndex = 11;
            this.AddNewClassificationButton.Values.Text = "add";
            this.AddNewClassificationButton.Click += new System.EventHandler(this.AddNewClassificationButton_Click);
            // 
            // validationLabel
            // 
            this.validationLabel.AutoSize = true;
            this.validationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validationLabel.ForeColor = System.Drawing.Color.Red;
            this.validationLabel.Location = new System.Drawing.Point(37, 487);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(192, 16);
            this.validationLabel.TabIndex = 10;
            this.validationLabel.Text = "* Informations are not valid";
            this.validationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.validationLabel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SeaGreen;
            this.label8.Location = new System.Drawing.Point(460, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "MAD";
            // 
            // carChoosePicturButton
            // 
            this.carChoosePicturButton.BackColor = System.Drawing.Color.Transparent;
            this.carChoosePicturButton.ForeColor = System.Drawing.Color.Blue;
            this.carChoosePicturButton.Location = new System.Drawing.Point(431, 232);
            this.carChoosePicturButton.Name = "carChoosePicturButton";
            this.carChoosePicturButton.Size = new System.Drawing.Size(104, 23);
            this.carChoosePicturButton.TabIndex = 8;
            this.carChoosePicturButton.Text = "Choose picture";
            this.carChoosePicturButton.UseVisualStyleBackColor = false;
            this.carChoosePicturButton.Click += new System.EventHandler(this.CarChoosePictureButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(372, 541);
            this.closeButton.Name = "closeButton";
            this.closeButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.closeButton.Size = new System.Drawing.Size(129, 34);
            this.closeButton.TabIndex = 7;
            this.closeButton.Values.Text = "Close";
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // addMoreButton
            // 
            this.addMoreButton.Location = new System.Drawing.Point(40, 581);
            this.addMoreButton.Name = "addMoreButton";
            this.addMoreButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.addMoreButton.Size = new System.Drawing.Size(129, 34);
            this.addMoreButton.TabIndex = 7;
            this.addMoreButton.Values.Text = "Add more";
            this.addMoreButton.Click += new System.EventHandler(this.AddMoreButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(40, 541);
            this.saveButton.Name = "saveButton";
            this.saveButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.saveButton.Size = new System.Drawing.Size(129, 34);
            this.saveButton.TabIndex = 7;
            this.saveButton.Values.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // carPictureBox
            // 
            this.carPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.carPictureBox.BackgroundImage = global::CarRentalApp.Properties.Resources.car_picture_default;
            this.carPictureBox.Location = new System.Drawing.Point(244, 26);
            this.carPictureBox.Name = "carPictureBox";
            this.carPictureBox.Size = new System.Drawing.Size(291, 200);
            this.carPictureBox.TabIndex = 6;
            this.carPictureBox.TabStop = false;
            // 
            // carDescriptionTextBox
            // 
            this.carDescriptionTextBox.Location = new System.Drawing.Point(37, 359);
            this.carDescriptionTextBox.Name = "carDescriptionTextBox";
            this.carDescriptionTextBox.Size = new System.Drawing.Size(498, 116);
            this.carDescriptionTextBox.TabIndex = 5;
            this.carDescriptionTextBox.Text = "";
            // 
            // carPricePerDayNumericUpDown
            // 
            this.carPricePerDayNumericUpDown.Location = new System.Drawing.Point(303, 289);
            this.carPricePerDayNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.carPricePerDayNumericUpDown.Name = "carPricePerDayNumericUpDown";
            this.carPricePerDayNumericUpDown.Size = new System.Drawing.Size(138, 22);
            this.carPricePerDayNumericUpDown.TabIndex = 4;
            // 
            // carClassificationComboBox
            // 
            this.carClassificationComboBox.DropDownWidth = 192;
            this.carClassificationComboBox.Location = new System.Drawing.Point(37, 289);
            this.carClassificationComboBox.Name = "carClassificationComboBox";
            this.carClassificationComboBox.Size = new System.Drawing.Size(192, 21);
            this.carClassificationComboBox.TabIndex = 3;
            // 
            // carNextDrainDateTimePicker
            // 
            this.carNextDrainDateTimePicker.Location = new System.Drawing.Point(37, 218);
            this.carNextDrainDateTimePicker.Name = "carNextDrainDateTimePicker";
            this.carNextDrainDateTimePicker.Size = new System.Drawing.Size(192, 21);
            this.carNextDrainDateTimePicker.TabIndex = 2;
            // 
            // carPurchaseDateTimePicker
            // 
            this.carPurchaseDateTimePicker.Location = new System.Drawing.Point(37, 158);
            this.carPurchaseDateTimePicker.Name = "carPurchaseDateTimePicker";
            this.carPurchaseDateTimePicker.Size = new System.Drawing.Size(192, 21);
            this.carPurchaseDateTimePicker.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(34, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(300, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Price Per Day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(34, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Classification";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(34, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Next Drain Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(34, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Purchase Date";
            // 
            // carLicensePlateTextBox
            // 
            this.carLicensePlateTextBox.Location = new System.Drawing.Point(37, 102);
            this.carLicensePlateTextBox.Name = "carLicensePlateTextBox";
            this.carLicensePlateTextBox.Size = new System.Drawing.Size(192, 23);
            this.carLicensePlateTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(34, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "License Plate";
            // 
            // carNameTextBox
            // 
            this.carNameTextBox.Location = new System.Drawing.Point(37, 45);
            this.carNameTextBox.Name = "carNameTextBox";
            this.carNameTextBox.Size = new System.Drawing.Size(192, 23);
            this.carNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 632);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CarForm_FormClosing);
            this.Load += new System.EventHandler(this.CarForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carClassificationComboBox)).EndInit();
            this.ResumeLayout(false);

        }

        private Panel panel1;
        private Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox carNameTextBox;
        private Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox carLicensePlateTextBox;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox carPictureBox;
        private RichTextBox carDescriptionTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown carPricePerDayNumericUpDown;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox carClassificationComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker carNextDrainDateTimePicker;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker carPurchaseDateTimePicker;
        private ComponentFactory.Krypton.Toolkit.KryptonButton closeButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton saveButton;
        private Button carChoosePicturButton;
        private Label label8;
        private Label validationLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton AddNewClassificationButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addMoreButton;
    }
}