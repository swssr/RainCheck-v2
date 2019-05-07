namespace RainCheckUI
{
    partial class HomePageForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cardList = new System.Windows.Forms.FlowLayoutPanel();
            this.weatherCard = new RainCheckUI.WeatherCardControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconStrip = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnToggleMenu = new System.Windows.Forms.Button();
            this.homeTemp = new System.Windows.Forms.Label();
            this.lbHomeTown = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.homeWeatherIcon = new System.Windows.Forms.PictureBox();
            this.isFarenheit = new System.Windows.Forms.Label();
            this.isCelcius = new System.Windows.Forms.Label();
            this.lbSummary = new System.Windows.Forms.Label();
            this.homeVisibility = new System.Windows.Forms.Label();
            this.homeHumidity = new System.Windows.Forms.Label();
            this.homeWindSpeed = new System.Windows.Forms.Label();
            this.homeLastUpdated = new System.Windows.Forms.Label();
            this.homePrecip = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGlobalSearch = new MetroFramework.Controls.MetroTextBox();
            this.iconMore = new System.Windows.Forms.PictureBox();
            this.lbcurrTime = new System.Windows.Forms.Label();
            this.cardList.SuspendLayout();
            this.iconStrip.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeWeatherIcon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMore)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Location = new System.Drawing.Point(19, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(880, 2);
            this.panel3.TabIndex = 10;
            // 
            // btnQuit
            // 
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Location = new System.Drawing.Point(851, -1);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(45, 32);
            this.btnQuit.TabIndex = 12;
            this.btnQuit.Text = "✖";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(807, -1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 32);
            this.btnMinimize.TabIndex = 12;
            this.btnMinimize.Text = "➖";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cardList
            // 
            this.cardList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.cardList.Controls.Add(this.weatherCard);
            this.cardList.Location = new System.Drawing.Point(70, 393);
            this.cardList.Name = "cardList";
            this.cardList.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.cardList.Size = new System.Drawing.Size(788, 172);
            this.cardList.TabIndex = 6;
            // 
            // weatherCard
            // 
            this.weatherCard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.weatherCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weatherCard.CityName = "Hello";
            this.weatherCard.ForecastDate = new System.DateTime(2012, 12, 12, 0, 0, 0, 0);
            this.weatherCard.Icon = null;
            this.weatherCard.Location = new System.Drawing.Point(3, 7);
            this.weatherCard.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.weatherCard.MaxTemp = 0D;
            this.weatherCard.MinTemp = 0D;
            this.weatherCard.Name = "weatherCard";
            this.weatherCard.Size = new System.Drawing.Size(165, 150);
            this.weatherCard.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Location = new System.Drawing.Point(49, 578);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(850, 22);
            this.panel5.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(73, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 55);
            this.label2.TabIndex = 13;
            this.label2.Text = "Recent Updates";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(446, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Your latest weather forecast";
            // 
            // iconStrip
            // 
            this.iconStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(118)))));
            this.iconStrip.Controls.Add(this.btnDashboard);
            this.iconStrip.Controls.Add(this.btnToggleMenu);
            this.iconStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconStrip.Location = new System.Drawing.Point(0, 0);
            this.iconStrip.Name = "iconStrip";
            this.iconStrip.Size = new System.Drawing.Size(49, 600);
            this.iconStrip.TabIndex = 16;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackgroundImage = global::RainCheckUI.Properties.Resources.settings;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnDashboard.Location = new System.Drawing.Point(8, 536);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10);
            this.btnDashboard.Size = new System.Drawing.Size(33, 32);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnToggleMenu
            // 
            this.btnToggleMenu.BackgroundImage = global::RainCheckUI.Properties.Resources.cloud;
            this.btnToggleMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnToggleMenu.FlatAppearance.BorderSize = 0;
            this.btnToggleMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnToggleMenu.Location = new System.Drawing.Point(8, 3);
            this.btnToggleMenu.Name = "btnToggleMenu";
            this.btnToggleMenu.Padding = new System.Windows.Forms.Padding(10);
            this.btnToggleMenu.Size = new System.Drawing.Size(33, 32);
            this.btnToggleMenu.TabIndex = 0;
            this.btnToggleMenu.UseVisualStyleBackColor = true;
            // 
            // homeTemp
            // 
            this.homeTemp.AutoSize = true;
            this.homeTemp.Font = new System.Drawing.Font("Segoe UI Black", 64F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.homeTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.homeTemp.Location = new System.Drawing.Point(322, 34);
            this.homeTemp.Name = "homeTemp";
            this.homeTemp.Size = new System.Drawing.Size(106, 86);
            this.homeTemp.TabIndex = 1;
            this.homeTemp.Text = "18";
            // 
            // lbHomeTown
            // 
            this.lbHomeTown.AutoSize = true;
            this.lbHomeTown.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbHomeTown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.lbHomeTown.Location = new System.Drawing.Point(320, 22);
            this.lbHomeTown.Name = "lbHomeTown";
            this.lbHomeTown.Size = new System.Drawing.Size(111, 25);
            this.lbHomeTown.TabIndex = 1;
            this.lbHomeTown.Text = "Durban, KZN";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.homeWeatherIcon);
            this.panel4.Controls.Add(this.isFarenheit);
            this.panel4.Controls.Add(this.isCelcius);
            this.panel4.Controls.Add(this.lbSummary);
            this.panel4.Controls.Add(this.lbHomeTown);
            this.panel4.Controls.Add(this.homeTemp);
            this.panel4.Controls.Add(this.homeVisibility);
            this.panel4.Controls.Add(this.homeHumidity);
            this.panel4.Controls.Add(this.homeWindSpeed);
            this.panel4.Controls.Add(this.homeLastUpdated);
            this.panel4.Controls.Add(this.homePrecip);
            this.panel4.Location = new System.Drawing.Point(79, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(785, 250);
            this.panel4.TabIndex = 11;
            // 
            // homeWeatherIcon
            // 
            this.homeWeatherIcon.Image = global::RainCheckUI.Properties.Resources.zcloud;
            this.homeWeatherIcon.Location = new System.Drawing.Point(226, 45);
            this.homeWeatherIcon.Name = "homeWeatherIcon";
            this.homeWeatherIcon.Size = new System.Drawing.Size(100, 87);
            this.homeWeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeWeatherIcon.TabIndex = 2;
            this.homeWeatherIcon.TabStop = false;
            // 
            // isFarenheit
            // 
            this.isFarenheit.AutoSize = true;
            this.isFarenheit.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.isFarenheit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.isFarenheit.Location = new System.Drawing.Point(426, 78);
            this.isFarenheit.Name = "isFarenheit";
            this.isFarenheit.Size = new System.Drawing.Size(18, 21);
            this.isFarenheit.TabIndex = 1;
            this.isFarenheit.Text = "F";
            // 
            // isCelcius
            // 
            this.isCelcius.AutoSize = true;
            this.isCelcius.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.isCelcius.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.isCelcius.Location = new System.Drawing.Point(423, 53);
            this.isCelcius.Name = "isCelcius";
            this.isCelcius.Size = new System.Drawing.Size(23, 25);
            this.isCelcius.TabIndex = 1;
            this.isCelcius.Text = "C";
            // 
            // lbSummary
            // 
            this.lbSummary.AutoSize = true;
            this.lbSummary.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.lbSummary.Location = new System.Drawing.Point(337, 104);
            this.lbSummary.Name = "lbSummary";
            this.lbSummary.Size = new System.Drawing.Size(82, 32);
            this.lbSummary.TabIndex = 1;
            this.lbSummary.Text = "Sunny";
            // 
            // homeVisibility
            // 
            this.homeVisibility.AutoSize = true;
            this.homeVisibility.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.homeVisibility.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.homeVisibility.Location = new System.Drawing.Point(422, 165);
            this.homeVisibility.Name = "homeVisibility";
            this.homeVisibility.Size = new System.Drawing.Size(83, 15);
            this.homeVisibility.TabIndex = 1;
            this.homeVisibility.Text = "Visibilty 16 km";
            // 
            // homeHumidity
            // 
            this.homeHumidity.AutoSize = true;
            this.homeHumidity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.homeHumidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.homeHumidity.Location = new System.Drawing.Point(337, 186);
            this.homeHumidity.Name = "homeHumidity";
            this.homeHumidity.Size = new System.Drawing.Size(82, 15);
            this.homeHumidity.TabIndex = 1;
            this.homeHumidity.Text = "Humidity 14%";
            // 
            // homeWindSpeed
            // 
            this.homeWindSpeed.AutoSize = true;
            this.homeWindSpeed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.homeWindSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.homeWindSpeed.Location = new System.Drawing.Point(250, 165);
            this.homeWindSpeed.Name = "homeWindSpeed";
            this.homeWindSpeed.Size = new System.Drawing.Size(82, 15);
            this.homeWindSpeed.TabIndex = 1;
            this.homeWindSpeed.Text = "Wind 14 km/h";
            // 
            // homeLastUpdated
            // 
            this.homeLastUpdated.AutoSize = true;
            this.homeLastUpdated.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.homeLastUpdated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.homeLastUpdated.Location = new System.Drawing.Point(318, 140);
            this.homeLastUpdated.Name = "homeLastUpdated";
            this.homeLastUpdated.Size = new System.Drawing.Size(135, 15);
            this.homeLastUpdated.TabIndex = 1;
            this.homeLastUpdated.Text = "Last updated 6/05/2019";
            // 
            // homePrecip
            // 
            this.homePrecip.AutoSize = true;
            this.homePrecip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.homePrecip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.homePrecip.Location = new System.Drawing.Point(347, 165);
            this.homePrecip.Name = "homePrecip";
            this.homePrecip.Size = new System.Drawing.Size(59, 15);
            this.homePrecip.TabIndex = 1;
            this.homePrecip.Text = "Precip 0%";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGlobalSearch);
            this.panel1.Controls.Add(this.iconMore);
            this.panel1.Controls.Add(this.lbcurrTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 600);
            this.panel1.TabIndex = 18;
            // 
            // txtGlobalSearch
            // 
            // 
            // 
            // 
            this.txtGlobalSearch.CustomButton.Image = null;
            this.txtGlobalSearch.CustomButton.Location = new System.Drawing.Point(210, 2);
            this.txtGlobalSearch.CustomButton.Name = "";
            this.txtGlobalSearch.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtGlobalSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGlobalSearch.CustomButton.TabIndex = 1;
            this.txtGlobalSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGlobalSearch.CustomButton.UseSelectable = true;
            this.txtGlobalSearch.CustomButton.Visible = false;
            this.txtGlobalSearch.Lines = new string[0];
            this.txtGlobalSearch.Location = new System.Drawing.Point(623, 38);
            this.txtGlobalSearch.MaxLength = 32767;
            this.txtGlobalSearch.Name = "txtGlobalSearch";
            this.txtGlobalSearch.PasswordChar = '\0';
            this.txtGlobalSearch.PromptText = "Search";
            this.txtGlobalSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGlobalSearch.SelectedText = "";
            this.txtGlobalSearch.SelectionLength = 0;
            this.txtGlobalSearch.SelectionStart = 0;
            this.txtGlobalSearch.ShortcutsEnabled = true;
            this.txtGlobalSearch.Size = new System.Drawing.Size(242, 34);
            this.txtGlobalSearch.TabIndex = 17;
            this.txtGlobalSearch.UseSelectable = true;
            this.txtGlobalSearch.WaterMark = "Search";
            this.txtGlobalSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGlobalSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            // 
            // iconMore
            // 
            this.iconMore.Location = new System.Drawing.Point(549, 48);
            this.iconMore.Name = "iconMore";
            this.iconMore.Size = new System.Drawing.Size(68, 13);
            this.iconMore.TabIndex = 0;
            this.iconMore.TabStop = false;
            // 
            // lbcurrTime
            // 
            this.lbcurrTime.AutoSize = true;
            this.lbcurrTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbcurrTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.lbcurrTime.Location = new System.Drawing.Point(76, 48);
            this.lbcurrTime.Name = "lbcurrTime";
            this.lbcurrTime.Size = new System.Drawing.Size(0, 15);
            this.lbcurrTime.TabIndex = 1;
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.iconStrip);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cardList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Name = "HomePageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePageForm";
            this.Load += new System.EventHandler(this.HomePageForm_Load);
            this.cardList.ResumeLayout(false);
            this.iconStrip.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeWeatherIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.FlowLayoutPanel cardList;
        private WeatherCardControl weatherCard;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnToggleMenu;
        private System.Windows.Forms.Panel iconStrip;
        private System.Windows.Forms.Label homeTemp;
        private System.Windows.Forms.Label lbHomeTown;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label isFarenheit;
        private System.Windows.Forms.Label lbSummary;
        private System.Windows.Forms.Label homeVisibility;
        private System.Windows.Forms.Label homeHumidity;
        private System.Windows.Forms.Label homeWindSpeed;
        private System.Windows.Forms.Label homePrecip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label homeLastUpdated;
        private System.Windows.Forms.Label isCelcius;
        private System.Windows.Forms.PictureBox iconMore;
        private System.Windows.Forms.PictureBox homeWeatherIcon;
        private MetroFramework.Controls.MetroTextBox txtGlobalSearch;
        private System.Windows.Forms.Label lbcurrTime;
        private System.Windows.Forms.Button btnDashboard;
    }
}