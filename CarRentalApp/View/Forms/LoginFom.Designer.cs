using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework;
using Bunifu.Framework.UI;

namespace CarRentalApp.View.Forms
{
    partial class LoginFom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFom));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.label1 = new System.Windows.Forms.Label();
            this.loginButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.usernameTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomTextbox1 = new Bunifu.Framework.BunifuCustomTextbox();
            this.bunifuCards1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Black;
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.loginButton);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards1.Controls.Add(this.Password);
            this.bunifuCards1.Controls.Add(this.usernameTextBox);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(67, 114);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(445, 300);
            this.bunifuCards1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(41, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "username or password not valide";
            // 
            // loginButton
            // 
            this.loginButton.Active = false;
            this.loginButton.Activecolor = System.Drawing.Color.Black;
            this.loginButton.BackColor = System.Drawing.Color.Black;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginButton.BorderRadius = 0;
            this.loginButton.ButtonText = "Login";
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.DisabledColor = System.Drawing.Color.Gray;
            this.loginButton.Iconcolor = System.Drawing.Color.Transparent;
            this.loginButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("loginButton.Iconimage")));
            this.loginButton.Iconimage_right = null;
            this.loginButton.Iconimage_right_Selected = null;
            this.loginButton.Iconimage_Selected = null;
            this.loginButton.IconMarginLeft = 0;
            this.loginButton.IconMarginRight = 0;
            this.loginButton.IconRightVisible = true;
            this.loginButton.IconRightZoom = 0D;
            this.loginButton.IconVisible = true;
            this.loginButton.IconZoom = 90D;
            this.loginButton.IsTab = false;
            this.loginButton.Location = new System.Drawing.Point(131, 231);
            this.loginButton.Name = "loginButton";
            this.loginButton.Normalcolor = System.Drawing.Color.Black;
            this.loginButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.loginButton.OnHoverTextColor = System.Drawing.Color.White;
            this.loginButton.selected = false;
            this.loginButton.Size = new System.Drawing.Size(168, 48);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.Textcolor = System.Drawing.Color.White;
            this.loginButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(41, 122);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(83, 18);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Password";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(38, 32);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(85, 18);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Username";
            // 
            // Password
            // 
            this.Password.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(160)))), ((int)(((byte)(184)))));
            this.Password.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(118)))), ((int)(((byte)(133)))));
            this.Password.BorderThickness = 3;
            this.Password.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password.isPassword = true;
            this.Password.Location = new System.Drawing.Point(41, 144);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.MaxLength = 64;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(370, 45);
            this.Password.TabIndex = 2;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(160)))), ((int)(((byte)(184)))));
            this.usernameTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameTextBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(118)))), ((int)(((byte)(133)))));
            this.usernameTextBox.BorderThickness = 3;
            this.usernameTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameTextBox.isPassword = false;
            this.usernameTextBox.Location = new System.Drawing.Point(38, 49);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.MaxLength = 64;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(370, 45);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(118)))), ((int)(((byte)(133)))));
            this.panel1.Controls.Add(this.bunifuCustomTextbox1);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Location = new System.Drawing.Point(204, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 553);
            this.panel1.TabIndex = 1;
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(3, 82);
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(588, 26);
            this.bunifuCustomTextbox1.TabIndex = 1;
            this.bunifuCustomTextbox1.TabStop = false;
            this.bunifuCustomTextbox1.Text = "Please login here";
            this.bunifuCustomTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginFom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 576);
            this.Name = "LoginFom";
            this.Opacity = 0.99D;
            this.Text = "Rent Luxury";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuCards bunifuCards1;
        private BunifuCustomLabel bunifuCustomLabel2;
        private BunifuCustomLabel bunifuCustomLabel1;
        private BunifuMetroTextbox Password;
        private BunifuMetroTextbox usernameTextBox;
        private BunifuFlatButton loginButton;
        private Label label1;
        private Panel panel1;
        private BunifuCustomTextbox bunifuCustomTextbox1;
    }
}

