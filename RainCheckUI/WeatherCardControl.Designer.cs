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
            this.lbCityName = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbMaxTemp = new System.Windows.Forms.Label();
            this.lbMinTemp = new System.Windows.Forms.Label();
            this.pnlIcon = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCityName
            // 
            this.lbCityName.AutoSize = true;
            this.lbCityName.Location = new System.Drawing.Point(28, 11);
            this.lbCityName.Name = "lbCityName";
            this.lbCityName.Size = new System.Drawing.Size(42, 13);
            this.lbCityName.TabIndex = 0;
            this.lbCityName.Text = "Durban";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(17, 128);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(53, 13);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "12/12/12";
            // 
            // lbMaxTemp
            // 
            this.lbMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbMaxTemp.Location = new System.Drawing.Point(11, 29);
            this.lbMaxTemp.Name = "lbMaxTemp";
            this.lbMaxTemp.Size = new System.Drawing.Size(89, 84);
            this.lbMaxTemp.TabIndex = 1;
            this.lbMaxTemp.Text = "34";
            // 
            // lbMinTemp
            // 
            this.lbMinTemp.AutoSize = true;
            this.lbMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbMinTemp.Location = new System.Drawing.Point(16, 81);
            this.lbMinTemp.Name = "lbMinTemp";
            this.lbMinTemp.Size = new System.Drawing.Size(30, 22);
            this.lbMinTemp.TabIndex = 0;
            this.lbMinTemp.Text = "10";
            // 
            // pnlIcon
            // 
            this.pnlIcon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlIcon.Location = new System.Drawing.Point(79, 29);
            this.pnlIcon.Name = "pnlIcon";
            this.pnlIcon.Size = new System.Drawing.Size(78, 84);
            this.pnlIcon.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbDate);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 161);
            this.panel1.TabIndex = 3;
            // 
            // WeatherCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlIcon);
            this.Controls.Add(this.lbMinTemp);
            this.Controls.Add(this.lbMaxTemp);
            this.Controls.Add(this.lbCityName);
            this.Controls.Add(this.panel1);
            this.Name = "WeatherCardControl";
            this.Size = new System.Drawing.Size(171, 164);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCityName;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbMaxTemp;
        private System.Windows.Forms.Label lbMinTemp;
        private System.Windows.Forms.Panel pnlIcon;
        private System.Windows.Forms.Panel panel1;
    }
}
