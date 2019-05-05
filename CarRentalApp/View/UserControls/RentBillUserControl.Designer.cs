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
            this.backButtonLabel = new System.Windows.Forms.LinkLabel();
            this.validateButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.billManageByLabel = new System.Windows.Forms.Label();
            this.billAmountLabel = new System.Windows.Forms.Label();
            this.billClientNameLabel = new System.Windows.Forms.Label();
            this.billNumLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.billDateDatePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCards1.BorderRadius = 30;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkSlateGray;
            this.bunifuCards1.Controls.Add(this.backButtonLabel);
            this.bunifuCards1.Controls.Add(this.validateButton);
            this.bunifuCards1.Controls.Add(this.billManageByLabel);
            this.bunifuCards1.Controls.Add(this.billAmountLabel);
            this.bunifuCards1.Controls.Add(this.billClientNameLabel);
            this.bunifuCards1.Controls.Add(this.billNumLabel);
            this.bunifuCards1.Controls.Add(this.label6);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.label8);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.billDateDatePicker);
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
            // validateButton
            // 
            this.validateButton.Active = false;
            this.validateButton.Activecolor = System.Drawing.Color.Blue;
            this.validateButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.validateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.validateButton.BorderRadius = 5;
            this.validateButton.ButtonText = "Validate";
            this.validateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.validateButton.DisabledColor = System.Drawing.Color.Gray;
            this.validateButton.Iconcolor = System.Drawing.Color.Transparent;
            this.validateButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("validateButton.Iconimage")));
            this.validateButton.Iconimage_right = null;
            this.validateButton.Iconimage_right_Selected = null;
            this.validateButton.Iconimage_Selected = null;
            this.validateButton.IconMarginLeft = 0;
            this.validateButton.IconMarginRight = 0;
            this.validateButton.IconRightVisible = true;
            this.validateButton.IconRightZoom = 0D;
            this.validateButton.IconVisible = true;
            this.validateButton.IconZoom = 90D;
            this.validateButton.IsTab = false;
            this.validateButton.Location = new System.Drawing.Point(257, 417);
            this.validateButton.Margin = new System.Windows.Forms.Padding(4);
            this.validateButton.MinimumSize = new System.Drawing.Size(182, 48);
            this.validateButton.Name = "validateButton";
            this.validateButton.Normalcolor = System.Drawing.SystemColors.ControlDarkDark;
            this.validateButton.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.validateButton.OnHoverTextColor = System.Drawing.Color.White;
            this.validateButton.selected = false;
            this.validateButton.Size = new System.Drawing.Size(182, 48);
            this.validateButton.TabIndex = 8;
            this.validateButton.Text = "Validate";
            this.validateButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.validateButton.Textcolor = System.Drawing.Color.White;
            this.validateButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.Click += new System.EventHandler(this.ValidateButton_Click);
            // 
            // billManageByLabel
            // 
            this.billManageByLabel.AutoSize = true;
            this.billManageByLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.billManageByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billManageByLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.billManageByLabel.Location = new System.Drawing.Point(180, 312);
            this.billManageByLabel.MinimumSize = new System.Drawing.Size(290, 36);
            this.billManageByLabel.Name = "billManageByLabel";
            this.billManageByLabel.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.billManageByLabel.Size = new System.Drawing.Size(290, 36);
            this.billManageByLabel.TabIndex = 3;
            this.billManageByLabel.Text = "Latif Karambiri";
            this.billManageByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // billAmountLabel
            // 
            this.billAmountLabel.AutoSize = true;
            this.billAmountLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.billAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billAmountLabel.ForeColor = System.Drawing.Color.SpringGreen;
            this.billAmountLabel.Location = new System.Drawing.Point(180, 189);
            this.billAmountLabel.MinimumSize = new System.Drawing.Size(290, 36);
            this.billAmountLabel.Name = "billAmountLabel";
            this.billAmountLabel.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.billAmountLabel.Size = new System.Drawing.Size(290, 36);
            this.billAmountLabel.TabIndex = 3;
            this.billAmountLabel.Text = "678.00 MAD";
            this.billAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // billClientNameLabel
            // 
            this.billClientNameLabel.AutoSize = true;
            this.billClientNameLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.billClientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billClientNameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.billClientNameLabel.Location = new System.Drawing.Point(180, 254);
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
            this.billNumLabel.Location = new System.Drawing.Point(183, 62);
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
            this.label6.Location = new System.Drawing.Point(36, 62);
            this.label6.MinimumSize = new System.Drawing.Size(0, 36);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label6.Size = new System.Drawing.Size(72, 36);
            this.label6.TabIndex = 3;
            this.label6.Text = "Bill num";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 312);
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
            this.label8.Location = new System.Drawing.Point(36, 189);
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
            this.label1.Location = new System.Drawing.Point(36, 254);
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
            this.label2.Location = new System.Drawing.Point(36, 126);
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
            this.billDateDatePicker.Location = new System.Drawing.Point(183, 126);
            this.billDateDatePicker.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.billDateDatePicker.MaximumSize = new System.Drawing.Size(0, 49);
            this.billDateDatePicker.MinimumSize = new System.Drawing.Size(290, 36);
            this.billDateDatePicker.Name = "billDateDatePicker";
            this.billDateDatePicker.Size = new System.Drawing.Size(290, 36);
            this.billDateDatePicker.TabIndex = 2;
            this.billDateDatePicker.Value = new System.DateTime(2019, 5, 5, 8, 21, 28, 0);
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
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuCards bunifuCards1;
        private BunifuFlatButton validateButton;
        private Label billClientNameLabel;
        private Label billNumLabel;
        private Label label6;
        private Label label4;
        private Label label1;
        private Label label2;
        private BunifuDatepicker billDateDatePicker;
        private Label billManageByLabel;
        private LinkLabel backButtonLabel;
        private Label billAmountLabel;
        private Label label8;
    }
}
