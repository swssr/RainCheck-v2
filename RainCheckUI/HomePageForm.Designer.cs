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
            this.cardList = new System.Windows.Forms.FlowLayoutPanel();
            this.weatherCard = new RainCheckUI.WeatherCardControl();
            this.rightNavIconBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.cardList.SuspendLayout();
            this.rightNavIconBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardList
            // 
            this.cardList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.cardList.Controls.Add(this.weatherCard);
            this.cardList.Location = new System.Drawing.Point(198, 322);
            this.cardList.Name = "cardList";
            this.cardList.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.cardList.Size = new System.Drawing.Size(660, 150);
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
            this.weatherCard.MaxTemp = 0D;
            this.weatherCard.MinTemp = 0D;
            this.weatherCard.Name = "weatherCard";
            this.weatherCard.Size = new System.Drawing.Size(165, 150);
            this.weatherCard.TabIndex = 0;
            // 
            // rightNavIconBar
            // 
            this.rightNavIconBar.Controls.Add(this.panel1);
            this.rightNavIconBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.rightNavIconBar.Location = new System.Drawing.Point(0, 0);
            this.rightNavIconBar.Name = "rightNavIconBar";
            this.rightNavIconBar.Size = new System.Drawing.Size(49, 559);
            this.rightNavIconBar.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(108)))), ((int)(((byte)(254)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(49, 559);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(46, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 559);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Location = new System.Drawing.Point(174, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(718, 2);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(198, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(658, 227);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(185, 528);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(692, 31);
            this.panel5.TabIndex = 10;
            // 
            // btnQuit
            // 
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Location = new System.Drawing.Point(838, -1);
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
            this.btnMinimize.Location = new System.Drawing.Point(794, -1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 32);
            this.btnMinimize.TabIndex = 12;
            this.btnMinimize.Text = "➖";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(884, 559);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rightNavIconBar);
            this.Controls.Add(this.cardList);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.Name = "HomePageForm";
            this.Text = "HomePageForm";
            this.Load += new System.EventHandler(this.HomePageForm_Load);
            this.cardList.ResumeLayout(false);
            this.rightNavIconBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel cardList;
        private WeatherCardControl weatherCard;
        private System.Windows.Forms.Panel rightNavIconBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnMinimize;
    }
}