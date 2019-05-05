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
            this.pnlCardList = new MetroFramework.Controls.MetroPanel();
            this.pnlWatchlist = new MetroFramework.Controls.MetroPanel();
            this.cardList = new System.Windows.Forms.FlowLayoutPanel();
            this.weatherCard = new RainCheckUI.WeatherCardControl();
            this.pnlCardList.SuspendLayout();
            this.cardList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCardList
            // 
            this.pnlCardList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlCardList.Controls.Add(this.cardList);
            this.pnlCardList.HorizontalScrollbarBarColor = true;
            this.pnlCardList.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlCardList.HorizontalScrollbarSize = 10;
            this.pnlCardList.Location = new System.Drawing.Point(24, 64);
            this.pnlCardList.Name = "pnlCardList";
            this.pnlCardList.Size = new System.Drawing.Size(736, 472);
            this.pnlCardList.TabIndex = 0;
            this.pnlCardList.VerticalScrollbarBarColor = true;
            this.pnlCardList.VerticalScrollbarHighlightOnWheel = false;
            this.pnlCardList.VerticalScrollbarSize = 10;
            // 
            // pnlWatchlist
            // 
            this.pnlWatchlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlWatchlist.HorizontalScrollbarBarColor = true;
            this.pnlWatchlist.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlWatchlist.HorizontalScrollbarSize = 10;
            this.pnlWatchlist.Location = new System.Drawing.Point(766, 64);
            this.pnlWatchlist.Name = "pnlWatchlist";
            this.pnlWatchlist.Size = new System.Drawing.Size(121, 472);
            this.pnlWatchlist.TabIndex = 1;
            this.pnlWatchlist.VerticalScrollbarBarColor = true;
            this.pnlWatchlist.VerticalScrollbarHighlightOnWheel = false;
            this.pnlWatchlist.VerticalScrollbarSize = 10;
            // 
            // cardList
            // 
            this.cardList.BackColor = System.Drawing.Color.White;
            this.cardList.Controls.Add(this.weatherCard);
            this.cardList.Location = new System.Drawing.Point(4, 4);
            this.cardList.Name = "cardList";
            this.cardList.Size = new System.Drawing.Size(729, 468);
            this.cardList.TabIndex = 2;
            // 
            // weatherCard
            // 
            this.weatherCard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.weatherCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weatherCard.CityName = "Hello";
            this.weatherCard.ForecastDate = new System.DateTime(2012, 12, 12, 0, 0, 0, 0);
            this.weatherCard.Location = new System.Drawing.Point(3, 3);
            this.weatherCard.MaxTemp = 0D;
            this.weatherCard.MinTemp = 0D;
            this.weatherCard.Name = "weatherCard";
            this.weatherCard.Size = new System.Drawing.Size(171, 164);
            this.weatherCard.TabIndex = 0;
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 559);
            this.Controls.Add(this.pnlWatchlist);
            this.Controls.Add(this.pnlCardList);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.Name = "HomePageForm";
            this.Text = "HomePageForm";
            this.Load += new System.EventHandler(this.HomePageForm_Load);
            this.pnlCardList.ResumeLayout(false);
            this.cardList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlCardList;
        private MetroFramework.Controls.MetroPanel pnlWatchlist;
        private System.Windows.Forms.FlowLayoutPanel cardList;
        private WeatherCardControl weatherCard;
    }
}