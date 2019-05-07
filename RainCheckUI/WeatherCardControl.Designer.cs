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
            this.components = new System.ComponentModel.Container();
            this.lbMinTemp = new System.Windows.Forms.Label();
            this.lbMaxTemp = new System.Windows.Forms.Label();
            this.lbCityName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDate = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.forecastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMinTemp
            // 
            this.lbMinTemp.AutoSize = true;
            this.lbMinTemp.BackColor = System.Drawing.Color.Transparent;
            this.lbMinTemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbMinTemp.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbMinTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.lbMinTemp.Location = new System.Drawing.Point(15, 97);
            this.lbMinTemp.Name = "lbMinTemp";
            this.lbMinTemp.Size = new System.Drawing.Size(23, 20);
            this.lbMinTemp.TabIndex = 6;
            this.lbMinTemp.Text = "10";
            this.lbMinTemp.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.lbMinTemp.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // lbMaxTemp
            // 
            this.lbMaxTemp.BackColor = System.Drawing.Color.Transparent;
            this.lbMaxTemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbMaxTemp.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbMaxTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(81)))), ((int)(((byte)(118)))));
            this.lbMaxTemp.Location = new System.Drawing.Point(6, 42);
            this.lbMaxTemp.Name = "lbMaxTemp";
            this.lbMaxTemp.Size = new System.Drawing.Size(78, 52);
            this.lbMaxTemp.TabIndex = 8;
            this.lbMaxTemp.Text = "32";
            this.lbMaxTemp.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.lbMaxTemp.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // lbCityName
            // 
            this.lbCityName.AutoSize = true;
            this.lbCityName.BackColor = System.Drawing.Color.Transparent;
            this.lbCityName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCityName.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbCityName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.lbCityName.Location = new System.Drawing.Point(10, 23);
            this.lbCityName.Name = "lbCityName";
            this.lbCityName.Size = new System.Drawing.Size(55, 19);
            this.lbCityName.TabIndex = 7;
            this.lbCityName.Text = "Durban";
            this.lbCityName.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.lbCityName.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbDate);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 150);
            this.panel1.TabIndex = 10;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(81)))), ((int)(((byte)(118)))));
            this.lbDate.Location = new System.Drawing.Point(4, 128);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(112, 15);
            this.lbDate.TabIndex = 7;
            this.lbDate.Text = "Updated 6/05/2019";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIcon.Image = global::RainCheckUI.Properties.Resources._029_sunrise;
            this.picIcon.Location = new System.Drawing.Point(69, 44);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(72, 72);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 9;
            this.picIcon.TabStop = false;
            this.picIcon.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.picIcon.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // forecastBindingSource
            // 
            this.forecastBindingSource.DataSource = typeof(RainCheckUI.Model.Forecast);
            // 
            // WeatherCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.lbCityName);
            this.Controls.Add(this.lbMinTemp);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.lbMaxTemp);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.Name = "WeatherCardControl";
            this.Size = new System.Drawing.Size(162, 150);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lbMinTemp;
        private System.Windows.Forms.Label lbMaxTemp;
        private System.Windows.Forms.Label lbCityName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource forecastBindingSource;
        private System.Windows.Forms.Label lbDate;
    }
}
