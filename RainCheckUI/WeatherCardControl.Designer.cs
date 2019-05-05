namespace RainCheckUI
{
    partial class WeatherCardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbMinTemp = new System.Windows.Forms.Label();
            this.lbMaxTemp = new System.Windows.Forms.Label();
            this.lbCityName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picIcon.Location = new System.Drawing.Point(75, 35);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(83, 77);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 9;
            this.picIcon.TabStop = false;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(16, 130);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(53, 13);
            this.lbDate.TabIndex = 5;
            this.lbDate.Text = "12/12/12";
            // 
            // lbMinTemp
            // 
            this.lbMinTemp.AutoSize = true;
            this.lbMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbMinTemp.Location = new System.Drawing.Point(15, 87);
            this.lbMinTemp.Name = "lbMinTemp";
            this.lbMinTemp.Size = new System.Drawing.Size(30, 22);
            this.lbMinTemp.TabIndex = 6;
            this.lbMinTemp.Text = "10";
            // 
            // lbMaxTemp
            // 
            this.lbMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbMaxTemp.Location = new System.Drawing.Point(6, 35);
            this.lbMaxTemp.Name = "lbMaxTemp";
            this.lbMaxTemp.Size = new System.Drawing.Size(78, 52);
            this.lbMaxTemp.TabIndex = 8;
            this.lbMaxTemp.Text = "34";
            // 
            // lbCityName
            // 
            this.lbCityName.AutoSize = true;
            this.lbCityName.Location = new System.Drawing.Point(17, 17);
            this.lbCityName.Name = "lbCityName";
            this.lbCityName.Size = new System.Drawing.Size(42, 13);
            this.lbCityName.TabIndex = 7;
            this.lbCityName.Text = "Durban";
            // 
            // WeatherCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbMinTemp);
            this.Controls.Add(this.lbMaxTemp);
            this.Controls.Add(this.lbCityName);
            this.Name = "WeatherCardControl";
            this.Size = new System.Drawing.Size(171, 164);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbMinTemp;
        private System.Windows.Forms.Label lbMaxTemp;
        private System.Windows.Forms.Label lbCityName;
    }
}
