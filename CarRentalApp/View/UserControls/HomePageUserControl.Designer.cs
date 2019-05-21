using System.ComponentModel;
using System.Windows.Forms;
namespace CarRentalApp.View.UserControls
{
    partial class HomePageUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageUserControl));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.rentsCountLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.rentsInPendingCountLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.clientsCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.monthlyTakingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.top3EmployeeListBox = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.top3CarListBox = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.top3ClientListBox = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.label3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyTakingChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.rentsCountLabel);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(124, 71);
            this.panel3.MaximumSize = new System.Drawing.Size(245, 110);
            this.panel3.MinimumSize = new System.Drawing.Size(245, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 110);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(165, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 52);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // rentsCountLabel
            // 
            this.rentsCountLabel.AutoSize = true;
            this.rentsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentsCountLabel.ForeColor = System.Drawing.Color.White;
            this.rentsCountLabel.Location = new System.Drawing.Point(35, 41);
            this.rentsCountLabel.Name = "rentsCountLabel";
            this.rentsCountLabel.Size = new System.Drawing.Size(46, 31);
            this.rentsCountLabel.TabIndex = 0;
            this.rentsCountLabel.Text = "35";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Rents";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.rentsInPendingCountLabel);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(408, 71);
            this.panel2.MaximumSize = new System.Drawing.Size(245, 110);
            this.panel2.MinimumSize = new System.Drawing.Size(245, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 110);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(165, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 52);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // rentsInPendingCountLabel
            // 
            this.rentsInPendingCountLabel.AutoSize = true;
            this.rentsInPendingCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentsInPendingCountLabel.ForeColor = System.Drawing.Color.White;
            this.rentsInPendingCountLabel.Location = new System.Drawing.Point(35, 41);
            this.rentsInPendingCountLabel.Name = "rentsInPendingCountLabel";
            this.rentsInPendingCountLabel.Size = new System.Drawing.Size(46, 31);
            this.rentsInPendingCountLabel.TabIndex = 0;
            this.rentsInPendingCountLabel.Text = "12";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rents in pending";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(129)))), ((int)(((byte)(200)))));
            this.label3.Controls.Add(this.pictureBox2);
            this.label3.Controls.Add(this.clientsCountLabel);
            this.label3.Controls.Add(this.label1);
            this.label3.Location = new System.Drawing.Point(692, 71);
            this.label3.MaximumSize = new System.Drawing.Size(245, 110);
            this.label3.MinimumSize = new System.Drawing.Size(245, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 110);
            this.label3.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(165, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 52);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // clientsCountLabel
            // 
            this.clientsCountLabel.AutoSize = true;
            this.clientsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsCountLabel.ForeColor = System.Drawing.Color.White;
            this.clientsCountLabel.Location = new System.Drawing.Point(35, 41);
            this.clientsCountLabel.Name = "clientsCountLabel";
            this.clientsCountLabel.Size = new System.Drawing.Size(62, 31);
            this.clientsCountLabel.TabIndex = 0;
            this.clientsCountLabel.Text = "200";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers";
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshButton.BackgroundImage")));
            this.refreshButton.Location = new System.Drawing.Point(978, 22);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(32, 32);
            this.refreshButton.TabIndex = 6;
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // monthlyTakingChart
            // 
            this.monthlyTakingChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.monthlyTakingChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.monthlyTakingChart.Legends.Add(legend1);
            this.monthlyTakingChart.Location = new System.Drawing.Point(63, 247);
            this.monthlyTakingChart.Name = "monthlyTakingChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Takings";
            this.monthlyTakingChart.Series.Add(series1);
            this.monthlyTakingChart.Size = new System.Drawing.Size(547, 382);
            this.monthlyTakingChart.TabIndex = 7;
            this.monthlyTakingChart.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(33, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Top 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(33, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "* Car";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(33, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "* Client";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(33, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "* Employee";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.top3EmployeeListBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.top3CarListBox);
            this.panel1.Controls.Add(this.top3ClientListBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(632, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 409);
            this.panel1.TabIndex = 10;
            // 
            // top3EmployeeListBox
            // 
            this.top3EmployeeListBox.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ContextMenuItemHighlight;
            this.top3EmployeeListBox.Items.AddRange(new object[] {
            "Karambiri Latif (17)",
            "Alethea Ivankov (8)",
            "Luther Prichet (7)"});
            this.top3EmployeeListBox.Location = new System.Drawing.Point(38, 314);
            this.top3EmployeeListBox.Name = "top3EmployeeListBox";
            this.top3EmployeeListBox.Size = new System.Drawing.Size(279, 81);
            this.top3EmployeeListBox.TabIndex = 9;
            // 
            // top3CarListBox
            // 
            this.top3CarListBox.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ContextMenuItemHighlight;
            this.top3CarListBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.top3CarListBox.Items.AddRange(new object[] {
            "Mercedes A3 (10)",
            "Toyota Lander (8)",
            "Sparky (5)"});
            this.top3CarListBox.Location = new System.Drawing.Point(38, 79);
            this.top3CarListBox.Name = "top3CarListBox";
            this.top3CarListBox.Size = new System.Drawing.Size(279, 81);
            this.top3CarListBox.TabIndex = 9;
            // 
            // top3ClientListBox
            // 
            this.top3ClientListBox.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ContextMenuItemHighlight;
            this.top3ClientListBox.Items.AddRange(new object[] {
            "Lillian Morgan (5)",
            "Kayiriko Alimatou (3)",
            "Bamon Safiatou (3)"});
            this.top3ClientListBox.Location = new System.Drawing.Point(38, 193);
            this.top3ClientListBox.Name = "top3ClientListBox";
            this.top3ClientListBox.Size = new System.Drawing.Size(279, 81);
            this.top3ClientListBox.TabIndex = 9;
            // 
            // HomePageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.monthlyTakingChart);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "HomePageUserControl";
            this.Size = new System.Drawing.Size(1044, 681);
            this.Load += new System.EventHandler(this.HomePageUserControl_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.label3.ResumeLayout(false);
            this.label3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyTakingChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel3;
        private PictureBox pictureBox4;
        private Label rentsCountLabel;
        private Label label7;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label rentsInPendingCountLabel;
        private Label label5;
        private Panel label3;
        private PictureBox pictureBox2;
        private Label clientsCountLabel;
        private Label label1;
        private Button refreshButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart monthlyTakingChart;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label8;
        private Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox top3EmployeeListBox;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox top3ClientListBox;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox top3CarListBox;
    }
}
