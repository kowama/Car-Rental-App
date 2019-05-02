using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace CarRentalApp.View.Forms
{
    partial class AddClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClientForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.validationLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fistNameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lastNameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cinTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.addressTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.emailTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(45, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(45, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "CIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(45, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(270, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(45, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Address";
            // 
            // saveButton
            // 
            this.saveButton.ActiveBorderThickness = 1;
            this.saveButton.ActiveCornerRadius = 20;
            this.saveButton.ActiveFillColor = System.Drawing.Color.Blue;
            this.saveButton.ActiveForecolor = System.Drawing.Color.White;
            this.saveButton.ActiveLineColor = System.Drawing.Color.Chartreuse;
            this.saveButton.BackColor = System.Drawing.SystemColors.Control;
            this.saveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveButton.BackgroundImage")));
            this.saveButton.ButtonText = "Save";
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.saveButton.IdleBorderThickness = 1;
            this.saveButton.IdleCornerRadius = 20;
            this.saveButton.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.saveButton.IdleForecolor = System.Drawing.Color.DimGray;
            this.saveButton.IdleLineColor = System.Drawing.Color.Turquoise;
            this.saveButton.Location = new System.Drawing.Point(123, 473);
            this.saveButton.Margin = new System.Windows.Forms.Padding(5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(174, 53);
            this.saveButton.TabIndex = 7;
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // validationLabel
            // 
            this.validationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.validationLabel.AutoSize = true;
            this.validationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validationLabel.ForeColor = System.Drawing.Color.Crimson;
            this.validationLabel.Location = new System.Drawing.Point(45, 432);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(202, 16);
            this.validationLabel.TabIndex = 8;
            this.validationLabel.Text = "Client information are not Valides";
            this.validationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.validationLabel.Visible = false;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(273, 292);
            this.phoneTextBox.Mask = "(+212) 000-000000";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(127, 16);
            this.phoneTextBox.TabIndex = 9;
            // 
            // fistNameTextBox
            // 
            this.fistNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.fistNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.fistNameTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.fistNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fistNameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fistNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fistNameTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.fistNameTextBox.HintText = "Enter your first name";
            this.fistNameTextBox.isPassword = false;
            this.fistNameTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.fistNameTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.fistNameTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.fistNameTextBox.LineThickness = 3;
            this.fistNameTextBox.Location = new System.Drawing.Point(48, 45);
            this.fistNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fistNameTextBox.MaxLength = 32;
            this.fistNameTextBox.Name = "fistNameTextBox";
            this.fistNameTextBox.Size = new System.Drawing.Size(379, 33);
            this.fistNameTextBox.TabIndex = 11;
            this.fistNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.lastNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.lastNameTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.lastNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lastNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastNameTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.lastNameTextBox.HintText = "Enter your last name";
            this.lastNameTextBox.isPassword = false;
            this.lastNameTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.lastNameTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.lastNameTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.lastNameTextBox.LineThickness = 3;
            this.lastNameTextBox.Location = new System.Drawing.Point(48, 122);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTextBox.MaxLength = 32767;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(379, 33);
            this.lastNameTextBox.TabIndex = 12;
            this.lastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cinTextBox
            // 
            this.cinTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cinTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cinTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cinTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cinTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cinTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cinTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.cinTextBox.HintText = "";
            this.cinTextBox.isPassword = false;
            this.cinTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.cinTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.cinTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.cinTextBox.LineThickness = 3;
            this.cinTextBox.Location = new System.Drawing.Point(48, 199);
            this.cinTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cinTextBox.MaxLength = 32767;
            this.cinTextBox.Name = "cinTextBox";
            this.cinTextBox.Size = new System.Drawing.Size(379, 33);
            this.cinTextBox.TabIndex = 12;
            this.cinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // addressTextBox
            // 
            this.addressTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.addressTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.addressTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.addressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.addressTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addressTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.addressTextBox.HintText = "Enter your email address";
            this.addressTextBox.isPassword = false;
            this.addressTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.addressTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.addressTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.addressTextBox.LineThickness = 3;
            this.addressTextBox.Location = new System.Drawing.Point(48, 366);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.MaxLength = 255;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(379, 33);
            this.addressTextBox.TabIndex = 12;
            this.addressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // emailTextBox
            // 
            this.emailTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.emailTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.emailTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.emailTextBox.HintText = "exemple@email.com";
            this.emailTextBox.isPassword = false;
            this.emailTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.emailTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.emailTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.emailTextBox.LineThickness = 3;
            this.emailTextBox.Location = new System.Drawing.Point(48, 278);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.MaxLength = 64;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(199, 33);
            this.emailTextBox.TabIndex = 15;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(270, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Phone";
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(490, 582);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.cinTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.fistNameTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.validationLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddClientForm";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Add New Client";
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
        private BunifuMaterialTextbox fistNameTextBox;
        private BunifuMaterialTextbox lastNameTextBox;
        private BunifuMaterialTextbox cinTextBox;
        private BunifuMaterialTextbox addressTextBox;
        private BunifuMaterialTextbox emailTextBox;
        private Label label7;
    }
}