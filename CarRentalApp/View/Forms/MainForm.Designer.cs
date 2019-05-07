using System.ComponentModel;
using System.Windows.Forms;

namespace CarRentalApp.View.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.billsMenuButton = new System.Windows.Forms.Button();
            this.settingsMenuButton = new System.Windows.Forms.Button();
            this.homeMenuButton = new System.Windows.Forms.Button();
            this.usersMenuButton = new System.Windows.Forms.Button();
            this.clientsMenuButton = new System.Windows.Forms.Button();
            this.carsMenuButton = new System.Windows.Forms.Button();
            this.rentsMenuButton = new System.Windows.Forms.Button();
            this.datetimeLabel = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.menuButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userInfoPanel = new System.Windows.Forms.Panel();
            this.appUserRoleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.appUsernameLabel = new System.Windows.Forms.Label();
            this.contentPannel = new System.Windows.Forms.Panel();
            this.menuTimer = new System.Windows.Forms.Timer(this.components);
            this.datetimeTimer = new System.Windows.Forms.Timer(this.components);
            this.leftPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.userInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.leftPanel.Controls.Add(this.menuPanel);
            this.leftPanel.Controls.Add(this.panel5);
            this.leftPanel.Controls.Add(this.infoPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(220, 712);
            this.leftPanel.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.menuPanel.Controls.Add(this.billsMenuButton);
            this.menuPanel.Controls.Add(this.settingsMenuButton);
            this.menuPanel.Controls.Add(this.homeMenuButton);
            this.menuPanel.Controls.Add(this.usersMenuButton);
            this.menuPanel.Controls.Add(this.clientsMenuButton);
            this.menuPanel.Controls.Add(this.carsMenuButton);
            this.menuPanel.Controls.Add(this.rentsMenuButton);
            this.menuPanel.Controls.Add(this.datetimeLabel);
            this.menuPanel.Controls.Add(this.sidePanel);
            this.menuPanel.Location = new System.Drawing.Point(2, 200);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(215, 509);
            this.menuPanel.TabIndex = 2;
            // 
            // billsMenuButton
            // 
            this.billsMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.billsMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.billsMenuButton.FlatAppearance.BorderSize = 0;
            this.billsMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.billsMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.billsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billsMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billsMenuButton.ForeColor = System.Drawing.Color.White;
            this.billsMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("billsMenuButton.Image")));
            this.billsMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billsMenuButton.Location = new System.Drawing.Point(5, 125);
            this.billsMenuButton.Name = "billsMenuButton";
            this.billsMenuButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.billsMenuButton.Size = new System.Drawing.Size(210, 60);
            this.billsMenuButton.TabIndex = 10;
            this.billsMenuButton.Text = "   Bills";
            this.billsMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.billsMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.billsMenuButton.UseVisualStyleBackColor = false;
            this.billsMenuButton.Click += new System.EventHandler(this.BillsMenuButton_Click);
            // 
            // settingsMenuButton
            // 
            this.settingsMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.settingsMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsMenuButton.FlatAppearance.BorderSize = 0;
            this.settingsMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.settingsMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.settingsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsMenuButton.ForeColor = System.Drawing.Color.White;
            this.settingsMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsMenuButton.Image")));
            this.settingsMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsMenuButton.Location = new System.Drawing.Point(5, 369);
            this.settingsMenuButton.Name = "settingsMenuButton";
            this.settingsMenuButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.settingsMenuButton.Size = new System.Drawing.Size(210, 60);
            this.settingsMenuButton.TabIndex = 5;
            this.settingsMenuButton.Text = "   Settings";
            this.settingsMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settingsMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsMenuButton.UseVisualStyleBackColor = false;
            this.settingsMenuButton.Click += new System.EventHandler(this.SettingsMenuButton_Click);
            // 
            // homeMenuButton
            // 
            this.homeMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.homeMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeMenuButton.FlatAppearance.BorderSize = 0;
            this.homeMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.homeMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.homeMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeMenuButton.ForeColor = System.Drawing.Color.White;
            this.homeMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("homeMenuButton.Image")));
            this.homeMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeMenuButton.Location = new System.Drawing.Point(5, 3);
            this.homeMenuButton.Name = "homeMenuButton";
            this.homeMenuButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.homeMenuButton.Size = new System.Drawing.Size(210, 60);
            this.homeMenuButton.TabIndex = 6;
            this.homeMenuButton.Text = "   Home";
            this.homeMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeMenuButton.UseVisualStyleBackColor = false;
            this.homeMenuButton.Click += new System.EventHandler(this.HomeMenuButton_Click);
            // 
            // usersMenuButton
            // 
            this.usersMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.usersMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersMenuButton.FlatAppearance.BorderSize = 0;
            this.usersMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.usersMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.usersMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersMenuButton.ForeColor = System.Drawing.Color.White;
            this.usersMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("usersMenuButton.Image")));
            this.usersMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersMenuButton.Location = new System.Drawing.Point(5, 308);
            this.usersMenuButton.Name = "usersMenuButton";
            this.usersMenuButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usersMenuButton.Size = new System.Drawing.Size(210, 60);
            this.usersMenuButton.TabIndex = 7;
            this.usersMenuButton.Text = "   Users";
            this.usersMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usersMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.usersMenuButton.UseVisualStyleBackColor = false;
            this.usersMenuButton.Click += new System.EventHandler(this.UsersMenuButton_Click);
            // 
            // clientsMenuButton
            // 
            this.clientsMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.clientsMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientsMenuButton.FlatAppearance.BorderSize = 0;
            this.clientsMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.clientsMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.clientsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsMenuButton.ForeColor = System.Drawing.Color.White;
            this.clientsMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("clientsMenuButton.Image")));
            this.clientsMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientsMenuButton.Location = new System.Drawing.Point(5, 247);
            this.clientsMenuButton.Name = "clientsMenuButton";
            this.clientsMenuButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clientsMenuButton.Size = new System.Drawing.Size(210, 60);
            this.clientsMenuButton.TabIndex = 8;
            this.clientsMenuButton.Text = "   Clients";
            this.clientsMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clientsMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clientsMenuButton.UseVisualStyleBackColor = false;
            this.clientsMenuButton.Click += new System.EventHandler(this.ClientsMenuButton_Click);
            // 
            // carsMenuButton
            // 
            this.carsMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.carsMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carsMenuButton.FlatAppearance.BorderSize = 0;
            this.carsMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.carsMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.carsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carsMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carsMenuButton.ForeColor = System.Drawing.Color.White;
            this.carsMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("carsMenuButton.Image")));
            this.carsMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.carsMenuButton.Location = new System.Drawing.Point(5, 186);
            this.carsMenuButton.Name = "carsMenuButton";
            this.carsMenuButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.carsMenuButton.Size = new System.Drawing.Size(210, 60);
            this.carsMenuButton.TabIndex = 9;
            this.carsMenuButton.Text = "   Cars";
            this.carsMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.carsMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.carsMenuButton.UseVisualStyleBackColor = false;
            this.carsMenuButton.Click += new System.EventHandler(this.CarsMenuButton_Click);
            // 
            // rentsMenuButton
            // 
            this.rentsMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.rentsMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rentsMenuButton.FlatAppearance.BorderSize = 0;
            this.rentsMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.rentsMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.rentsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentsMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentsMenuButton.ForeColor = System.Drawing.Color.White;
            this.rentsMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("rentsMenuButton.Image")));
            this.rentsMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rentsMenuButton.Location = new System.Drawing.Point(5, 64);
            this.rentsMenuButton.Name = "rentsMenuButton";
            this.rentsMenuButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rentsMenuButton.Size = new System.Drawing.Size(210, 60);
            this.rentsMenuButton.TabIndex = 10;
            this.rentsMenuButton.Text = "   Rents";
            this.rentsMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rentsMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rentsMenuButton.UseVisualStyleBackColor = false;
            this.rentsMenuButton.Click += new System.EventHandler(this.RentsMenuButton_Click);
            // 
            // datetimeLabel
            // 
            this.datetimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datetimeLabel.AutoSize = true;
            this.datetimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeLabel.ForeColor = System.Drawing.Color.Silver;
            this.datetimeLabel.Location = new System.Drawing.Point(38, 453);
            this.datetimeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.datetimeLabel.Name = "datetimeLabel";
            this.datetimeLabel.Size = new System.Drawing.Size(136, 16);
            this.datetimeLabel.TabIndex = 11;
            this.datetimeLabel.Text = "Tue 23 2019- 23:52";
            this.datetimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.White;
            this.sidePanel.Location = new System.Drawing.Point(0, 3);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 60);
            this.sidePanel.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 184);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 10);
            this.panel5.TabIndex = 1;
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.infoPanel.Controls.Add(this.menuButton);
            this.infoPanel.Controls.Add(this.pictureBox1);
            this.infoPanel.Controls.Add(this.userInfoPanel);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Location = new System.Drawing.Point(0, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(220, 178);
            this.infoPanel.TabIndex = 1;
            // 
            // menuButton
            // 
            this.menuButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(122)))), ((int)(((byte)(136)))));
            this.menuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(182, 3);
            this.menuButton.Name = "menuButton";
            this.menuButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuButton.Size = new System.Drawing.Size(38, 38);
            this.menuButton.TabIndex = 2;
            this.menuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 111);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // userInfoPanel
            // 
            this.userInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInfoPanel.Controls.Add(this.appUserRoleLabel);
            this.userInfoPanel.Controls.Add(this.label2);
            this.userInfoPanel.Controls.Add(this.appUsernameLabel);
            this.userInfoPanel.Location = new System.Drawing.Point(0, 115);
            this.userInfoPanel.Name = "userInfoPanel";
            this.userInfoPanel.Size = new System.Drawing.Size(220, 63);
            this.userInfoPanel.TabIndex = 1;
            // 
            // appUserRoleLabel
            // 
            this.appUserRoleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appUserRoleLabel.AutoSize = true;
            this.appUserRoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appUserRoleLabel.ForeColor = System.Drawing.Color.White;
            this.appUserRoleLabel.Location = new System.Drawing.Point(94, 48);
            this.appUserRoleLabel.Name = "appUserRoleLabel";
            this.appUserRoleLabel.Size = new System.Drawing.Size(118, 15);
            this.appUserRoleLabel.TabIndex = 3;
            this.appUserRoleLabel.Text = "ADMINISTRATOR";
            this.appUserRoleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rent Luxury";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // appUsernameLabel
            // 
            this.appUsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.appUsernameLabel.AutoSize = true;
            this.appUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appUsernameLabel.ForeColor = System.Drawing.Color.White;
            this.appUsernameLabel.Location = new System.Drawing.Point(0, 48);
            this.appUsernameLabel.Name = "appUsernameLabel";
            this.appUsernameLabel.Size = new System.Drawing.Size(66, 16);
            this.appUsernameLabel.TabIndex = 3;
            this.appUsernameLabel.Text = "Kowama";
            this.appUsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contentPannel
            // 
            this.contentPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPannel.Location = new System.Drawing.Point(220, 0);
            this.contentPannel.Name = "contentPannel";
            this.contentPannel.Size = new System.Drawing.Size(1052, 712);
            this.contentPannel.TabIndex = 1;
            // 
            // menuTimer
            // 
            this.menuTimer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // datetimeTimer
            // 
            this.datetimeTimer.Tick += new System.EventHandler(this.DatetimeTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1220, 700);
            this.ClientSize = new System.Drawing.Size(1272, 712);
            this.Controls.Add(this.contentPannel);
            this.Controls.Add(this.leftPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 576);
            this.Name = "MainForm";
            this.Opacity = 0.99D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Rent Luxury";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.leftPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.userInfoPanel.ResumeLayout(false);
            this.userInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel leftPanel;
        private Panel infoPanel;
        private Panel contentPannel;
        private PictureBox pictureBox1;
        private Label label2;
        private Label appUsernameLabel;
        private Label appUserRoleLabel;
        private Panel panel5;
        private Button menuButton;
        private Timer menuTimer;
        private Panel userInfoPanel;
        private Timer datetimeTimer;
        private Panel menuPanel;
        private Label datetimeLabel;
        private Panel sidePanel;
        private Button settingsMenuButton;
        private Button homeMenuButton;
        private Button usersMenuButton;
        private Button clientsMenuButton;
        private Button carsMenuButton;
        private Button rentsMenuButton;
        private Button billsMenuButton;
    }
}