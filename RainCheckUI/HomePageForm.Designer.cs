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
            this.btnToggleMenu = new System.Windows.Forms.Button();
            this.lbTemp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.isFarenheit = new System.Windows.Forms.Label();
            this.isCelcius = new System.Windows.Forms.Label();
            this.lbSummary = new System.Windows.Forms.Label();
            this.lbVisibility = new System.Windows.Forms.Label();
            this.lbHumidity = new System.Windows.Forms.Label();
            this.lbWindSpeed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPrecip = new System.Windows.Forms.Label();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconMore = new System.Windows.Forms.PictureBox();
            this.cardList.SuspendLayout();
            this.iconStrip.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.iconStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(108)))), ((int)(((byte)(254)))));
            this.iconStrip.Controls.Add(this.btnToggleMenu);
            this.iconStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconStrip.Location = new System.Drawing.Point(0, 0);
            this.iconStrip.Name = "iconStrip";
            this.iconStrip.Size = new System.Drawing.Size(49, 600);
            this.iconStrip.TabIndex = 16;
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
            this.btnToggleMenu.Click += new System.EventHandler(this.btnToggleMenu_Click);
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Font = new System.Drawing.Font("Segoe UI Black", 64F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.lbTemp.Location = new System.Drawing.Point(322, 34);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(106, 86);
            this.lbTemp.TabIndex = 1;
            this.lbTemp.Text = "18";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.label4.Location = new System.Drawing.Point(320, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Durban, KZN";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.isFarenheit);
            this.panel4.Controls.Add(this.isCelcius);
            this.panel4.Controls.Add(this.lbSummary);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.lbTemp);
            this.panel4.Controls.Add(this.lbVisibility);
            this.panel4.Controls.Add(this.lbHumidity);
            this.panel4.Controls.Add(this.lbWindSpeed);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lbPrecip);
            this.panel4.Location = new System.Drawing.Point(79, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(785, 251);
            this.panel4.TabIndex = 11;
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
            // lbVisibility
            // 
            this.lbVisibility.AutoSize = true;
            this.lbVisibility.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbVisibility.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.lbVisibility.Location = new System.Drawing.Point(422, 165);
            this.lbVisibility.Name = "lbVisibility";
            this.lbVisibility.Size = new System.Drawing.Size(83, 15);
            this.lbVisibility.TabIndex = 1;
            this.lbVisibility.Text = "Visibilty 16 km";
            // 
            // lbHumidity
            // 
            this.lbHumidity.AutoSize = true;
            this.lbHumidity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbHumidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.lbHumidity.Location = new System.Drawing.Point(337, 186);
            this.lbHumidity.Name = "lbHumidity";
            this.lbHumidity.Size = new System.Drawing.Size(82, 15);
            this.lbHumidity.TabIndex = 1;
            this.lbHumidity.Text = "Humidity 14%";
            // 
            // lbWindSpeed
            // 
            this.lbWindSpeed.AutoSize = true;
            this.lbWindSpeed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbWindSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.lbWindSpeed.Location = new System.Drawing.Point(250, 165);
            this.lbWindSpeed.Name = "lbWindSpeed";
            this.lbWindSpeed.Size = new System.Drawing.Size(82, 15);
            this.lbWindSpeed.TabIndex = 1;
            this.lbWindSpeed.Text = "Wind 14 km/h";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(318, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Llast updated 6/05/2019";
            // 
            // lbPrecip
            // 
            this.lbPrecip.AutoSize = true;
            this.lbPrecip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbPrecip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.lbPrecip.Location = new System.Drawing.Point(347, 165);
            this.lbPrecip.Name = "lbPrecip";
            this.lbPrecip.Size = new System.Drawing.Size(59, 15);
            this.lbPrecip.TabIndex = 1;
            this.lbPrecip.Text = "Precip 0%";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(672, 37);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Search";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(192, 29);
            this.metroTextBox1.TabIndex = 17;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Search";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconMore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 600);
            this.panel1.TabIndex = 18;
            // 
            // iconMore
            // 
            this.iconMore.Location = new System.Drawing.Point(595, 44);
            this.iconMore.Name = "iconMore";
            this.iconMore.Size = new System.Drawing.Size(68, 13);
            this.iconMore.TabIndex = 0;
            this.iconMore.TabStop = false;
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.iconStrip);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
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
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Label isFarenheit;
        private System.Windows.Forms.Label lbSummary;
        private System.Windows.Forms.Label lbVisibility;
        private System.Windows.Forms.Label lbHumidity;
        private System.Windows.Forms.Label lbWindSpeed;
        private System.Windows.Forms.Label lbPrecip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label isCelcius;
        private System.Windows.Forms.PictureBox iconMore;
    }
}