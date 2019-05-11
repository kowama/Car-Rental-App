using System.ComponentModel;
using System.Windows.Forms;

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

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.billcomputedPriceLabel = new System.Windows.Forms.Label();
            this.BackLinkLabelButton = new System.Windows.Forms.LinkLabel();
            this.billDetailsTextBox = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BillAmountNumericUpDown = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.billManagedByLabel = new System.Windows.Forms.Label();
            this.billCarLabel = new System.Windows.Forms.Label();
            this.billNumLabel = new System.Windows.Forms.Label();
            this.billClientLabel = new System.Windows.Forms.Label();
            this.validationLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.billDateTimePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.editButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cancelEditButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.finishedButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.Controls.Add(this.billcomputedPriceLabel);
            this.panel4.Controls.Add(this.BackLinkLabelButton);
            this.panel4.Controls.Add(this.billDetailsTextBox);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.BillAmountNumericUpDown);
            this.panel4.Controls.Add(this.billManagedByLabel);
            this.panel4.Controls.Add(this.billCarLabel);
            this.panel4.Controls.Add(this.billNumLabel);
            this.panel4.Controls.Add(this.billClientLabel);
            this.panel4.Controls.Add(this.validationLabel);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.editButton);
            this.panel4.Controls.Add(this.finishedButton);
            this.panel4.Controls.Add(this.cancelEditButton);
            this.panel4.Controls.Add(this.saveButton);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.billDateTimePicker);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(8, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(493, 504);
            this.panel4.TabIndex = 2;
            // 
            // billcomputedPriceLabel
            // 
            this.billcomputedPriceLabel.AutoSize = true;
            this.billcomputedPriceLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.billcomputedPriceLabel.Location = new System.Drawing.Point(204, 237);
            this.billcomputedPriceLabel.Name = "billcomputedPriceLabel";
            this.billcomputedPriceLabel.Size = new System.Drawing.Size(0, 13);
            this.billcomputedPriceLabel.TabIndex = 11;
            // 
            // BackLinkLabelButton
            // 
            this.BackLinkLabelButton.AutoSize = true;
            this.BackLinkLabelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackLinkLabelButton.Location = new System.Drawing.Point(51, 478);
            this.BackLinkLabelButton.Name = "BackLinkLabelButton";
            this.BackLinkLabelButton.Size = new System.Drawing.Size(39, 16);
            this.BackLinkLabelButton.TabIndex = 10;
            this.BackLinkLabelButton.TabStop = true;
            this.BackLinkLabelButton.Text = "Back";
            this.BackLinkLabelButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackButtonLabel_LinkClicked);
            // 
            // billDetailsTextBox
            // 
            this.billDetailsTextBox.Location = new System.Drawing.Point(50, 318);
            this.billDetailsTextBox.MaxLength = 2048;
            this.billDetailsTextBox.Name = "billDetailsTextBox";
            this.billDetailsTextBox.Size = new System.Drawing.Size(356, 82);
            this.billDetailsTextBox.TabIndex = 9;
            this.billDetailsTextBox.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(361, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "MAD";
            // 
            // BillAmountNumericUpDown
            // 
            this.BillAmountNumericUpDown.Location = new System.Drawing.Point(207, 259);
            this.BillAmountNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.BillAmountNumericUpDown.Name = "BillAmountNumericUpDown";
            this.BillAmountNumericUpDown.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.BillAmountNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.BillAmountNumericUpDown.TabIndex = 7;
            // 
            // billManagedByLabel
            // 
            this.billManagedByLabel.AutoSize = true;
            this.billManagedByLabel.BackColor = System.Drawing.SystemColors.Window;
            this.billManagedByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billManagedByLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.billManagedByLabel.Location = new System.Drawing.Point(202, 148);
            this.billManagedByLabel.MinimumSize = new System.Drawing.Size(200, 21);
            this.billManagedByLabel.Name = "billManagedByLabel";
            this.billManagedByLabel.Size = new System.Drawing.Size(200, 21);
            this.billManagedByLabel.TabIndex = 6;
            // 
            // billCarLabel
            // 
            this.billCarLabel.AutoSize = true;
            this.billCarLabel.BackColor = System.Drawing.SystemColors.Window;
            this.billCarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billCarLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.billCarLabel.Location = new System.Drawing.Point(199, 112);
            this.billCarLabel.MinimumSize = new System.Drawing.Size(200, 21);
            this.billCarLabel.Name = "billCarLabel";
            this.billCarLabel.Size = new System.Drawing.Size(200, 21);
            this.billCarLabel.TabIndex = 6;
            // 
            // billNumLabel
            // 
            this.billNumLabel.AutoSize = true;
            this.billNumLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.billNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billNumLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.billNumLabel.Location = new System.Drawing.Point(145, 15);
            this.billNumLabel.MinimumSize = new System.Drawing.Size(200, 21);
            this.billNumLabel.Name = "billNumLabel";
            this.billNumLabel.Size = new System.Drawing.Size(200, 21);
            this.billNumLabel.TabIndex = 6;
            // 
            // billClientLabel
            // 
            this.billClientLabel.AutoSize = true;
            this.billClientLabel.BackColor = System.Drawing.SystemColors.Window;
            this.billClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billClientLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.billClientLabel.Location = new System.Drawing.Point(199, 66);
            this.billClientLabel.MinimumSize = new System.Drawing.Size(200, 21);
            this.billClientLabel.Name = "billClientLabel";
            this.billClientLabel.Size = new System.Drawing.Size(200, 21);
            this.billClientLabel.TabIndex = 6;
            // 
            // validationLabel
            // 
            this.validationLabel.AutoSize = true;
            this.validationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validationLabel.ForeColor = System.Drawing.Color.Red;
            this.validationLabel.Location = new System.Drawing.Point(47, 413);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(156, 16);
            this.validationLabel.TabIndex = 5;
            this.validationLabel.Text = "* infomation  not valid";
            this.validationLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Managed By";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(188, 450);
            this.saveButton.Name = "saveButton";
            this.saveButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.saveButton.Size = new System.Drawing.Size(90, 25);
            this.saveButton.TabIndex = 3;
            this.saveButton.Values.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car";
            // 
            // billDateTimePicker
            // 
            this.billDateTimePicker.Location = new System.Drawing.Point(202, 201);
            this.billDateTimePicker.Name = "billDateTimePicker";
            this.billDateTimePicker.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.billDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.billDateTimePicker.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(47, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "`Bill Num";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Amount";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(50, 450);
            this.editButton.Name = "editButton";
            this.editButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.editButton.Size = new System.Drawing.Size(90, 25);
            this.editButton.TabIndex = 3;
            this.editButton.Values.Text = "edit";
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // cancelEditButton
            // 
            this.cancelEditButton.Location = new System.Drawing.Point(316, 450);
            this.cancelEditButton.Name = "cancelEditButton";
            this.cancelEditButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.cancelEditButton.Size = new System.Drawing.Size(90, 25);
            this.cancelEditButton.TabIndex = 3;
            this.cancelEditButton.Values.Text = "Cancel";
            this.cancelEditButton.Click += new System.EventHandler(this.CancelEditButton_Click);
            // 
            // finishedButton
            // 
            this.finishedButton.Location = new System.Drawing.Point(316, 479);
            this.finishedButton.Name = "finishedButton";
            this.finishedButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.finishedButton.Size = new System.Drawing.Size(90, 25);
            this.finishedButton.TabIndex = 3;
            this.finishedButton.Values.Text = "finished";
            this.finishedButton.Click += new System.EventHandler(this.FinishedButton_Click);
            // 
            // RentBillUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.MinimumSize = new System.Drawing.Size(509, 520);
            this.Name = "RentBillUserControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(509, 520);
            this.Load += new System.EventHandler(this.RentBillUserControl_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        private Panel panel4;
        private Label validationLabel;
        private Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton saveButton;
        private Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker billDateTimePicker;
        private Label label4;
        private Label label1;
        private Label label5;
        private Label label9;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown BillAmountNumericUpDown;
        private Label billManagedByLabel;
        private Label billCarLabel;
        private Label billClientLabel;
        private RichTextBox billDetailsTextBox;
        private Label label10;
        private Label billNumLabel;
        private Label label12;
        private Label label11;
        private LinkLabel BackLinkLabelButton;
        private Label billcomputedPriceLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton editButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cancelEditButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton finishedButton;
    }
}
