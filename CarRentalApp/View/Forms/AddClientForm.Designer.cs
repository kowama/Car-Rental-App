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
            this.fistNameTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.cinTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.addressTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.validationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fistNameTextBox
            // 
            this.fistNameTextBox.BorderColorFocused = System.Drawing.Color.Blue;
            this.fistNameTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fistNameTextBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.fistNameTextBox.BorderThickness = 3;
            this.fistNameTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.fistNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fistNameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fistNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fistNameTextBox.isPassword = false;
            this.fistNameTextBox.Location = new System.Drawing.Point(79, 48);
            this.fistNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fistNameTextBox.MaxLength = 32767;
            this.fistNameTextBox.Name = "fistNameTextBox";
            this.fistNameTextBox.Size = new System.Drawing.Size(370, 48);
            this.fistNameTextBox.TabIndex = 1;
            this.fistNameTextBox.Text = "Enter client first name";
            this.fistNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fistNameTextBox.Enter += new System.EventHandler(this.FormTextBox_Enter);
            this.fistNameTextBox.Leave += new System.EventHandler(this.FormTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(79, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BorderColorFocused = System.Drawing.Color.Blue;
            this.lastNameTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastNameTextBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.lastNameTextBox.BorderThickness = 3;
            this.lastNameTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.lastNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lastNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastNameTextBox.isPassword = false;
            this.lastNameTextBox.Location = new System.Drawing.Point(79, 122);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTextBox.MaxLength = 32767;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(370, 48);
            this.lastNameTextBox.TabIndex = 2;
            this.lastNameTextBox.Text = "Enter client last name";
            this.lastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lastNameTextBox.Enter += new System.EventHandler(this.FormTextBox_Enter);
            this.lastNameTextBox.Leave += new System.EventHandler(this.FormTextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(79, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // cinTextBox
            // 
            this.cinTextBox.BorderColorFocused = System.Drawing.Color.Blue;
            this.cinTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cinTextBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.cinTextBox.BorderThickness = 3;
            this.cinTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cinTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cinTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cinTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cinTextBox.isPassword = false;
            this.cinTextBox.Location = new System.Drawing.Point(79, 196);
            this.cinTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cinTextBox.MaxLength = 32767;
            this.cinTextBox.Name = "cinTextBox";
            this.cinTextBox.Size = new System.Drawing.Size(370, 48);
            this.cinTextBox.TabIndex = 3;
            this.cinTextBox.Text = "Enter client CIN";
            this.cinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cinTextBox.Enter += new System.EventHandler(this.FormTextBox_Enter);
            this.cinTextBox.Leave += new System.EventHandler(this.FormTextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(79, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "CIN";
            // 
            // emailTextbox
            // 
            this.emailTextbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.emailTextbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTextbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.emailTextbox.BorderThickness = 3;
            this.emailTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.emailTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTextbox.isPassword = false;
            this.emailTextbox.Location = new System.Drawing.Point(79, 270);
            this.emailTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextbox.MaxLength = 32767;
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(370, 48);
            this.emailTextbox.TabIndex = 4;
            this.emailTextbox.Text = "Enter client Email";
            this.emailTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailTextbox.Enter += new System.EventHandler(this.FormTextBox_Enter);
            this.emailTextbox.Leave += new System.EventHandler(this.FormTextBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(79, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BorderColorFocused = System.Drawing.Color.Blue;
            this.phoneTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phoneTextBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.phoneTextBox.BorderThickness = 3;
            this.phoneTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.phoneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.phoneTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phoneTextBox.isPassword = false;
            this.phoneTextBox.Location = new System.Drawing.Point(79, 344);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTextBox.MaxLength = 32767;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(370, 48);
            this.phoneTextBox.TabIndex = 5;
            this.phoneTextBox.Text = "Enter client Phone Number";
            this.phoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.phoneTextBox.Enter += new System.EventHandler(this.FormTextBox_Enter);
            this.phoneTextBox.Leave += new System.EventHandler(this.FormTextBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(79, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phone";
            // 
            // addressTextBox
            // 
            this.addressTextBox.BorderColorFocused = System.Drawing.Color.Blue;
            this.addressTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addressTextBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.addressTextBox.BorderThickness = 3;
            this.addressTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.addressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.addressTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addressTextBox.isPassword = false;
            this.addressTextBox.Location = new System.Drawing.Point(79, 418);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.MaxLength = 32767;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(370, 48);
            this.addressTextBox.TabIndex = 6;
            this.addressTextBox.Text = "Enter client Address";
            this.addressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addressTextBox.Enter += new System.EventHandler(this.FormTextBox_Enter);
            this.addressTextBox.Leave += new System.EventHandler(this.FormTextBox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(79, 397);
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
            this.saveButton.Location = new System.Drawing.Point(163, 523);
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
            this.validationLabel.Location = new System.Drawing.Point(79, 480);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(202, 16);
            this.validationLabel.TabIndex = 8;
            this.validationLabel.Text = "Client information are not Valides";
            this.validationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.validationLabel.Visible = false;
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(533, 625);
            this.Controls.Add(this.validationLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.cinTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.fistNameTextBox);
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

        private BunifuMetroTextbox fistNameTextBox;
        private Label label1;
        private BunifuMetroTextbox lastNameTextBox;
        private Label label2;
        private BunifuMetroTextbox cinTextBox;
        private Label label3;
        private BunifuMetroTextbox emailTextbox;
        private Label label4;
        private BunifuMetroTextbox phoneTextBox;
        private Label label5;
        private BunifuMetroTextbox addressTextBox;
        private Label label6;
        private BunifuThinButton2 saveButton;
        private Label validationLabel;
    }
}