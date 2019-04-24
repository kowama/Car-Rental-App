namespace CarRentalApp.View.Forms
{
    partial class AddClientForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClientForm));
            this.fistnameTextbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.lastnameTextbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.CINTextbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox4 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddressTextbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.saveButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // fistnameTextbox
            // 
            this.fistnameTextbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.fistnameTextbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fistnameTextbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.fistnameTextbox.BorderThickness = 3;
            this.fistnameTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.fistnameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fistnameTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fistnameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fistnameTextbox.isPassword = false;
            this.fistnameTextbox.Location = new System.Drawing.Point(79, 106);
            this.fistnameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.fistnameTextbox.MaxLength = 32767;
            this.fistnameTextbox.Name = "fistnameTextbox";
            this.fistnameTextbox.Size = new System.Drawing.Size(370, 48);
            this.fistnameTextbox.TabIndex = 1;
            this.fistnameTextbox.Text = "Enter client first name";
            this.fistnameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fistnameTextbox.Enter += new System.EventHandler(this.FormTextBox_Enter);
            this.fistnameTextbox.Leave += new System.EventHandler(this.FormTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(79, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // lastnameTextbox
            // 
            this.lastnameTextbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.lastnameTextbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastnameTextbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.lastnameTextbox.BorderThickness = 3;
            this.lastnameTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.lastnameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastnameTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lastnameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastnameTextbox.isPassword = false;
            this.lastnameTextbox.Location = new System.Drawing.Point(79, 180);
            this.lastnameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.lastnameTextbox.MaxLength = 32767;
            this.lastnameTextbox.Name = "lastnameTextbox";
            this.lastnameTextbox.Size = new System.Drawing.Size(370, 48);
            this.lastnameTextbox.TabIndex = 2;
            this.lastnameTextbox.Text = "Enter client last name";
            this.lastnameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lastnameTextbox.Enter += new System.EventHandler(this.FormTextBox_Enter);
            this.lastnameTextbox.Leave += new System.EventHandler(this.FormTextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(79, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // CINTextbox
            // 
            this.CINTextbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.CINTextbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CINTextbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.CINTextbox.BorderThickness = 3;
            this.CINTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CINTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CINTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CINTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CINTextbox.isPassword = false;
            this.CINTextbox.Location = new System.Drawing.Point(79, 254);
            this.CINTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.CINTextbox.MaxLength = 32767;
            this.CINTextbox.Name = "CINTextbox";
            this.CINTextbox.Size = new System.Drawing.Size(370, 48);
            this.CINTextbox.TabIndex = 3;
            this.CINTextbox.Text = "Enter client CIN";
            this.CINTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CINTextbox.Enter += new System.EventHandler(this.FormTextBox_Enter);
            this.CINTextbox.Leave += new System.EventHandler(this.FormTextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(79, 233);
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
            this.emailTextbox.Location = new System.Drawing.Point(79, 328);
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
            this.label4.Location = new System.Drawing.Point(79, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            // 
            // bunifuMetroTextbox4
            // 
            this.bunifuMetroTextbox4.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox4.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox4.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox4.BorderThickness = 3;
            this.bunifuMetroTextbox4.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMetroTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox4.isPassword = false;
            this.bunifuMetroTextbox4.Location = new System.Drawing.Point(79, 402);
            this.bunifuMetroTextbox4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox4.MaxLength = 32767;
            this.bunifuMetroTextbox4.Name = "bunifuMetroTextbox4";
            this.bunifuMetroTextbox4.Size = new System.Drawing.Size(370, 48);
            this.bunifuMetroTextbox4.TabIndex = 5;
            this.bunifuMetroTextbox4.Text = "Enter client Phone Number";
            this.bunifuMetroTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMetroTextbox4.Enter += new System.EventHandler(this.FormTextBox_Enter);
            this.bunifuMetroTextbox4.Leave += new System.EventHandler(this.FormTextBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(79, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phone";
            // 
            // AddressTextbox
            // 
            this.AddressTextbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.AddressTextbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddressTextbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.AddressTextbox.BorderThickness = 3;
            this.AddressTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.AddressTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.AddressTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddressTextbox.isPassword = false;
            this.AddressTextbox.Location = new System.Drawing.Point(79, 476);
            this.AddressTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.AddressTextbox.MaxLength = 32767;
            this.AddressTextbox.Name = "AddressTextbox";
            this.AddressTextbox.Size = new System.Drawing.Size(370, 48);
            this.AddressTextbox.TabIndex = 6;
            this.AddressTextbox.Text = "Enter client Address";
            this.AddressTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddressTextbox.Enter += new System.EventHandler(this.FormTextBox_Enter);
            this.AddressTextbox.Leave += new System.EventHandler(this.FormTextBox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(79, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Address";
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BackColor = System.Drawing.SystemColors.Menu;
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderThickness = 3;
            this.bunifuMetroTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Enabled = false;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(79, 32);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.MaxLength = 64;
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(370, 48);
            this.bunifuMetroTextbox1.TabIndex = 0;
            this.bunifuMetroTextbox1.TabStop = false;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(79, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Id";
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
            this.saveButton.Location = new System.Drawing.Point(162, 533);
            this.saveButton.Margin = new System.Windows.Forms.Padding(5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(174, 53);
            this.saveButton.TabIndex = 7;
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(533, 625);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressTextbox);
            this.Controls.Add(this.bunifuMetroTextbox4);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.CINTextbox);
            this.Controls.Add(this.bunifuMetroTextbox1);
            this.Controls.Add(this.lastnameTextbox);
            this.Controls.Add(this.fistnameTextbox);
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

        private Bunifu.Framework.UI.BunifuMetroTextbox fistnameTextbox;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox lastnameTextbox;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox CINTextbox;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox emailTextbox;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox AddressTextbox;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuThinButton2 saveButton;
    }
}