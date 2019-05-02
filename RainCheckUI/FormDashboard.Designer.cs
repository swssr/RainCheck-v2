using System;

namespace RainCheckUI
{
    partial class FormDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabShowAll = new MetroFramework.Controls.MetroTabPage();
            this.tabManageForecasts = new MetroFramework.Controls.MetroTabPage();
            this.tileDeleteForecast = new MetroFramework.Controls.MetroTile();
            this.tileUpdateForecast = new MetroFramework.Controls.MetroTile();
            this.tileAddForecast = new MetroFramework.Controls.MetroTile();
            this.panelRemoveForecast = new MetroFramework.Controls.MetroPanel();
            this.btnRemoveForecast = new System.Windows.Forms.Button();
            this.gridRemoveForecastPreview = new MetroFramework.Controls.MetroGrid();
            this.cmbCityToRemove = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabManageLocation = new MetroFramework.Controls.MetroTabPage();
            this.tabManageUsers = new MetroFramework.Controls.MetroTabPage();
            this.panelUpdateForecast = new MetroFramework.Controls.MetroPanel();
            this.btnUpdateForecast = new System.Windows.Forms.Button();
            this.gridForecastToUpdatePreview = new MetroFramework.Controls.MetroGrid();
            this.cmbForecastCityToUpdate = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cmdAddForecastCity = new MetroFramework.Controls.MetroComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAddMinTemp = new MetroFramework.Controls.MetroTextBox();
            this.txtAddPrecip = new MetroFramework.Controls.MetroTextBox();
            this.txtAddWindSpeed = new MetroFramework.Controls.MetroTextBox();
            this.txtAddHumidity = new MetroFramework.Controls.MetroTextBox();
            this.txtAddMaxTemp = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.panelAddForecast = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1.SuspendLayout();
            this.tabManageForecasts.SuspendLayout();
            this.panelRemoveForecast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRemoveForecastPreview)).BeginInit();
            this.panelUpdateForecast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridForecastToUpdatePreview)).BeginInit();
            this.panelAddForecast.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabShowAll);
            this.metroTabControl1.Controls.Add(this.tabManageForecasts);
            this.metroTabControl1.Controls.Add(this.tabManageLocation);
            this.metroTabControl1.Controls.Add(this.tabManageUsers);
            this.metroTabControl1.Location = new System.Drawing.Point(24, 64);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(753, 363);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabShowAll
            // 
            this.tabShowAll.HorizontalScrollbarBarColor = true;
            this.tabShowAll.HorizontalScrollbarHighlightOnWheel = false;
            this.tabShowAll.HorizontalScrollbarSize = 10;
            this.tabShowAll.Location = new System.Drawing.Point(4, 38);
            this.tabShowAll.Name = "tabShowAll";
            this.tabShowAll.Size = new System.Drawing.Size(745, 321);
            this.tabShowAll.Style = MetroFramework.MetroColorStyle.Black;
            this.tabShowAll.TabIndex = 0;
            this.tabShowAll.Text = "All Forecasts           ";
            this.tabShowAll.ToolTipText = "List all forecast";
            this.tabShowAll.VerticalScrollbarBarColor = true;
            this.tabShowAll.VerticalScrollbarHighlightOnWheel = false;
            this.tabShowAll.VerticalScrollbarSize = 10;
            // 
            // tabManageForecasts
            // 
            this.tabManageForecasts.Controls.Add(this.panelAddForecast);
            this.tabManageForecasts.Controls.Add(this.panelUpdateForecast);
            this.tabManageForecasts.Controls.Add(this.tileDeleteForecast);
            this.tabManageForecasts.Controls.Add(this.tileUpdateForecast);
            this.tabManageForecasts.Controls.Add(this.tileAddForecast);
            this.tabManageForecasts.Controls.Add(this.panelRemoveForecast);
            this.tabManageForecasts.HorizontalScrollbarBarColor = false;
            this.tabManageForecasts.HorizontalScrollbarHighlightOnWheel = false;
            this.tabManageForecasts.HorizontalScrollbarSize = 10;
            this.tabManageForecasts.Location = new System.Drawing.Point(4, 38);
            this.tabManageForecasts.Name = "tabManageForecasts";
            this.tabManageForecasts.Size = new System.Drawing.Size(745, 321);
            this.tabManageForecasts.TabIndex = 1;
            this.tabManageForecasts.Text = "Manage Forecasts";
            this.tabManageForecasts.ToolTipText = "Manage forecast data";
            this.tabManageForecasts.VerticalScrollbarBarColor = true;
            this.tabManageForecasts.VerticalScrollbarHighlightOnWheel = false;
            this.tabManageForecasts.VerticalScrollbarSize = 10;
            // 
            // tileDeleteForecast
            // 
            this.tileDeleteForecast.ActiveControl = null;
            this.tileDeleteForecast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileDeleteForecast.Location = new System.Drawing.Point(8, 214);
            this.tileDeleteForecast.Name = "tileDeleteForecast";
            this.tileDeleteForecast.Size = new System.Drawing.Size(108, 107);
            this.tileDeleteForecast.TabIndex = 7;
            this.tileDeleteForecast.Text = "Remove";
            this.tileDeleteForecast.UseSelectable = true;
            this.tileDeleteForecast.Click += new System.EventHandler(this.tileDeleteForecast_Click);
            // 
            // tileUpdateForecast
            // 
            this.tileUpdateForecast.ActiveControl = null;
            this.tileUpdateForecast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileUpdateForecast.Location = new System.Drawing.Point(8, 107);
            this.tileUpdateForecast.Name = "tileUpdateForecast";
            this.tileUpdateForecast.Size = new System.Drawing.Size(108, 107);
            this.tileUpdateForecast.TabIndex = 8;
            this.tileUpdateForecast.Text = "Update";
            this.tileUpdateForecast.UseSelectable = true;
            this.tileUpdateForecast.Click += new System.EventHandler(this.tileUpdateForecast_Click);
            // 
            // tileAddForecast
            // 
            this.tileAddForecast.ActiveControl = null;
            this.tileAddForecast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileAddForecast.Location = new System.Drawing.Point(8, 0);
            this.tileAddForecast.Name = "tileAddForecast";
            this.tileAddForecast.Size = new System.Drawing.Size(108, 107);
            this.tileAddForecast.TabIndex = 9;
            this.tileAddForecast.Text = "Add";
            this.tileAddForecast.UseSelectable = true;
            this.tileAddForecast.Click += new System.EventHandler(this.tileAddForecast_Click);
            // 
            // panelRemoveForecast
            // 
            this.panelRemoveForecast.Controls.Add(this.btnRemoveForecast);
            this.panelRemoveForecast.Controls.Add(this.gridRemoveForecastPreview);
            this.panelRemoveForecast.Controls.Add(this.cmbCityToRemove);
            this.panelRemoveForecast.Controls.Add(this.metroLabel2);
            this.panelRemoveForecast.Controls.Add(this.metroLabel1);
            this.panelRemoveForecast.HorizontalScrollbarBarColor = true;
            this.panelRemoveForecast.HorizontalScrollbarHighlightOnWheel = false;
            this.panelRemoveForecast.HorizontalScrollbarSize = 10;
            this.panelRemoveForecast.Location = new System.Drawing.Point(116, 15);
            this.panelRemoveForecast.Name = "panelRemoveForecast";
            this.panelRemoveForecast.Size = new System.Drawing.Size(636, 308);
            this.panelRemoveForecast.TabIndex = 3;
            this.panelRemoveForecast.VerticalScrollbarBarColor = true;
            this.panelRemoveForecast.VerticalScrollbarHighlightOnWheel = false;
            this.panelRemoveForecast.VerticalScrollbarSize = 10;
            // 
            // btnRemoveForecast
            // 
            this.btnRemoveForecast.BackColor = System.Drawing.Color.Tomato;
            this.btnRemoveForecast.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnRemoveForecast.FlatAppearance.BorderSize = 0;
            this.btnRemoveForecast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnRemoveForecast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveForecast.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnRemoveForecast.Location = new System.Drawing.Point(24, 262);
            this.btnRemoveForecast.Name = "btnRemoveForecast";
            this.btnRemoveForecast.Size = new System.Drawing.Size(114, 38);
            this.btnRemoveForecast.TabIndex = 5;
            this.btnRemoveForecast.Text = "Delete";
            this.btnRemoveForecast.UseVisualStyleBackColor = false;
            // 
            // gridRemoveForecastPreview
            // 
            this.gridRemoveForecastPreview.AllowUserToAddRows = false;
            this.gridRemoveForecastPreview.AllowUserToDeleteRows = false;
            this.gridRemoveForecastPreview.AllowUserToResizeRows = false;
            this.gridRemoveForecastPreview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.gridRemoveForecastPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridRemoveForecastPreview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridRemoveForecastPreview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRemoveForecastPreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridRemoveForecastPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridRemoveForecastPreview.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridRemoveForecastPreview.EnableHeadersVisualStyles = false;
            this.gridRemoveForecastPreview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridRemoveForecastPreview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridRemoveForecastPreview.Location = new System.Drawing.Point(24, 95);
            this.gridRemoveForecastPreview.Name = "gridRemoveForecastPreview";
            this.gridRemoveForecastPreview.ReadOnly = true;
            this.gridRemoveForecastPreview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRemoveForecastPreview.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridRemoveForecastPreview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridRemoveForecastPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRemoveForecastPreview.Size = new System.Drawing.Size(342, 150);
            this.gridRemoveForecastPreview.TabIndex = 4;
            this.gridRemoveForecastPreview.UseCustomBackColor = true;
            this.gridRemoveForecastPreview.UseCustomForeColor = true;
            // 
            // cmbCityToRemove
            // 
            this.cmbCityToRemove.FormattingEnabled = true;
            this.cmbCityToRemove.ItemHeight = 23;
            this.cmbCityToRemove.Location = new System.Drawing.Point(24, 32);
            this.cmbCityToRemove.Name = "cmbCityToRemove";
            this.cmbCityToRemove.Size = new System.Drawing.Size(342, 29);
            this.cmbCityToRemove.TabIndex = 3;
            this.cmbCityToRemove.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 70);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Preview";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(31, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "City";
            // 
            // tabManageLocation
            // 
            this.tabManageLocation.HorizontalScrollbarBarColor = true;
            this.tabManageLocation.HorizontalScrollbarHighlightOnWheel = false;
            this.tabManageLocation.HorizontalScrollbarSize = 10;
            this.tabManageLocation.Location = new System.Drawing.Point(4, 38);
            this.tabManageLocation.Name = "tabManageLocation";
            this.tabManageLocation.Size = new System.Drawing.Size(745, 321);
            this.tabManageLocation.TabIndex = 2;
            this.tabManageLocation.Text = "Manage Location";
            this.tabManageLocation.ToolTipText = "Manage Locations";
            this.tabManageLocation.VerticalScrollbarBarColor = true;
            this.tabManageLocation.VerticalScrollbarHighlightOnWheel = false;
            this.tabManageLocation.VerticalScrollbarSize = 10;
            // 
            // tabManageUsers
            // 
            this.tabManageUsers.HorizontalScrollbarBarColor = true;
            this.tabManageUsers.HorizontalScrollbarHighlightOnWheel = false;
            this.tabManageUsers.HorizontalScrollbarSize = 10;
            this.tabManageUsers.Location = new System.Drawing.Point(4, 38);
            this.tabManageUsers.Name = "tabManageUsers";
            this.tabManageUsers.Size = new System.Drawing.Size(745, 321);
            this.tabManageUsers.TabIndex = 3;
            this.tabManageUsers.Text = "Manage Users";
            this.tabManageUsers.ToolTipText = "Manage registered users";
            this.tabManageUsers.VerticalScrollbarBarColor = true;
            this.tabManageUsers.VerticalScrollbarHighlightOnWheel = false;
            this.tabManageUsers.VerticalScrollbarSize = 10;
            // 
            // panelUpdateForecast
            // 
            this.panelUpdateForecast.Controls.Add(this.btnUpdateForecast);
            this.panelUpdateForecast.Controls.Add(this.gridForecastToUpdatePreview);
            this.panelUpdateForecast.Controls.Add(this.cmbForecastCityToUpdate);
            this.panelUpdateForecast.Controls.Add(this.metroLabel3);
            this.panelUpdateForecast.Controls.Add(this.metroLabel4);
            this.panelUpdateForecast.HorizontalScrollbarBarColor = true;
            this.panelUpdateForecast.HorizontalScrollbarHighlightOnWheel = false;
            this.panelUpdateForecast.HorizontalScrollbarSize = 10;
            this.panelUpdateForecast.Location = new System.Drawing.Point(118, 14);
            this.panelUpdateForecast.Name = "panelUpdateForecast";
            this.panelUpdateForecast.Size = new System.Drawing.Size(575, 306);
            this.panelUpdateForecast.TabIndex = 11;
            this.panelUpdateForecast.VerticalScrollbarBarColor = true;
            this.panelUpdateForecast.VerticalScrollbarHighlightOnWheel = false;
            this.panelUpdateForecast.VerticalScrollbarSize = 10;
            // 
            // btnUpdateForecast
            // 
            this.btnUpdateForecast.BackColor = System.Drawing.Color.Gold;
            this.btnUpdateForecast.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnUpdateForecast.FlatAppearance.BorderSize = 0;
            this.btnUpdateForecast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnUpdateForecast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateForecast.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnUpdateForecast.Location = new System.Drawing.Point(24, 265);
            this.btnUpdateForecast.Name = "btnUpdateForecast";
            this.btnUpdateForecast.Size = new System.Drawing.Size(114, 38);
            this.btnUpdateForecast.TabIndex = 5;
            this.btnUpdateForecast.Text = "Update";
            this.btnUpdateForecast.UseVisualStyleBackColor = false;
            // 
            // gridForecastToUpdatePreview
            // 
            this.gridForecastToUpdatePreview.AllowUserToAddRows = false;
            this.gridForecastToUpdatePreview.AllowUserToDeleteRows = false;
            this.gridForecastToUpdatePreview.AllowUserToResizeRows = false;
            this.gridForecastToUpdatePreview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.gridForecastToUpdatePreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridForecastToUpdatePreview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridForecastToUpdatePreview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridForecastToUpdatePreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridForecastToUpdatePreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridForecastToUpdatePreview.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridForecastToUpdatePreview.EnableHeadersVisualStyles = false;
            this.gridForecastToUpdatePreview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridForecastToUpdatePreview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridForecastToUpdatePreview.Location = new System.Drawing.Point(24, 98);
            this.gridForecastToUpdatePreview.Name = "gridForecastToUpdatePreview";
            this.gridForecastToUpdatePreview.ReadOnly = true;
            this.gridForecastToUpdatePreview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridForecastToUpdatePreview.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridForecastToUpdatePreview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridForecastToUpdatePreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridForecastToUpdatePreview.Size = new System.Drawing.Size(342, 150);
            this.gridForecastToUpdatePreview.TabIndex = 4;
            this.gridForecastToUpdatePreview.UseCustomBackColor = true;
            this.gridForecastToUpdatePreview.UseCustomForeColor = true;
            // 
            // cmbForecastCityToUpdate
            // 
            this.cmbForecastCityToUpdate.FormattingEnabled = true;
            this.cmbForecastCityToUpdate.ItemHeight = 23;
            this.cmbForecastCityToUpdate.Location = new System.Drawing.Point(24, 31);
            this.cmbForecastCityToUpdate.Name = "cmbForecastCityToUpdate";
            this.cmbForecastCityToUpdate.Size = new System.Drawing.Size(342, 29);
            this.cmbForecastCityToUpdate.TabIndex = 3;
            this.cmbForecastCityToUpdate.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 73);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Preview";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 2);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(31, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "City";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(21, 16);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(31, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "City";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(21, 77);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(88, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Temperatures";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(251, 16);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(36, 19);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "Date";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(21, 143);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(99, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Precipication %";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(21, 205);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(81, 19);
            this.metroLabel10.TabIndex = 2;
            this.metroLabel10.Text = "Wind Speed";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(251, 143);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(61, 19);
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "Humidity";
            // 
            // cmdAddForecastCity
            // 
            this.cmdAddForecastCity.FormattingEnabled = true;
            this.cmdAddForecastCity.ItemHeight = 23;
            this.cmdAddForecastCity.Location = new System.Drawing.Point(21, 38);
            this.cmdAddForecastCity.Name = "cmdAddForecastCity";
            this.cmdAddForecastCity.Size = new System.Drawing.Size(200, 29);
            this.cmdAddForecastCity.TabIndex = 3;
            this.cmdAddForecastCity.UseSelectable = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtAddMinTemp
            // 
            // 
            // 
            // 
            this.txtAddMinTemp.CustomButton.Image = null;
            this.txtAddMinTemp.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txtAddMinTemp.CustomButton.Name = "";
            this.txtAddMinTemp.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtAddMinTemp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddMinTemp.CustomButton.TabIndex = 1;
            this.txtAddMinTemp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddMinTemp.CustomButton.UseSelectable = true;
            this.txtAddMinTemp.CustomButton.Visible = false;
            this.txtAddMinTemp.Lines = new string[0];
            this.txtAddMinTemp.Location = new System.Drawing.Point(21, 99);
            this.txtAddMinTemp.MaxLength = 32767;
            this.txtAddMinTemp.Name = "txtAddMinTemp";
            this.txtAddMinTemp.PasswordChar = '\0';
            this.txtAddMinTemp.PromptText = "Min";
            this.txtAddMinTemp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddMinTemp.SelectedText = "";
            this.txtAddMinTemp.SelectionLength = 0;
            this.txtAddMinTemp.SelectionStart = 0;
            this.txtAddMinTemp.ShortcutsEnabled = true;
            this.txtAddMinTemp.Size = new System.Drawing.Size(200, 29);
            this.txtAddMinTemp.TabIndex = 6;
            this.txtAddMinTemp.UseSelectable = true;
            this.txtAddMinTemp.WaterMark = "Min";
            this.txtAddMinTemp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddMinTemp.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtAddPrecip
            // 
            // 
            // 
            // 
            this.txtAddPrecip.CustomButton.Image = null;
            this.txtAddPrecip.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txtAddPrecip.CustomButton.Name = "";
            this.txtAddPrecip.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtAddPrecip.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddPrecip.CustomButton.TabIndex = 1;
            this.txtAddPrecip.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddPrecip.CustomButton.UseSelectable = true;
            this.txtAddPrecip.CustomButton.Visible = false;
            this.txtAddPrecip.Lines = new string[0];
            this.txtAddPrecip.Location = new System.Drawing.Point(21, 165);
            this.txtAddPrecip.MaxLength = 32767;
            this.txtAddPrecip.Name = "txtAddPrecip";
            this.txtAddPrecip.PasswordChar = '\0';
            this.txtAddPrecip.PromptText = "0";
            this.txtAddPrecip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddPrecip.SelectedText = "";
            this.txtAddPrecip.SelectionLength = 0;
            this.txtAddPrecip.SelectionStart = 0;
            this.txtAddPrecip.ShortcutsEnabled = true;
            this.txtAddPrecip.Size = new System.Drawing.Size(200, 29);
            this.txtAddPrecip.TabIndex = 6;
            this.txtAddPrecip.UseSelectable = true;
            this.txtAddPrecip.WaterMark = "0";
            this.txtAddPrecip.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddPrecip.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtAddWindSpeed
            // 
            // 
            // 
            // 
            this.txtAddWindSpeed.CustomButton.Image = null;
            this.txtAddWindSpeed.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txtAddWindSpeed.CustomButton.Name = "";
            this.txtAddWindSpeed.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtAddWindSpeed.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddWindSpeed.CustomButton.TabIndex = 1;
            this.txtAddWindSpeed.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddWindSpeed.CustomButton.UseSelectable = true;
            this.txtAddWindSpeed.CustomButton.Visible = false;
            this.txtAddWindSpeed.Lines = new string[0];
            this.txtAddWindSpeed.Location = new System.Drawing.Point(21, 227);
            this.txtAddWindSpeed.MaxLength = 32767;
            this.txtAddWindSpeed.Name = "txtAddWindSpeed";
            this.txtAddWindSpeed.PasswordChar = '\0';
            this.txtAddWindSpeed.PromptText = "0";
            this.txtAddWindSpeed.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddWindSpeed.SelectedText = "";
            this.txtAddWindSpeed.SelectionLength = 0;
            this.txtAddWindSpeed.SelectionStart = 0;
            this.txtAddWindSpeed.ShortcutsEnabled = true;
            this.txtAddWindSpeed.Size = new System.Drawing.Size(200, 29);
            this.txtAddWindSpeed.TabIndex = 6;
            this.txtAddWindSpeed.UseSelectable = true;
            this.txtAddWindSpeed.WaterMark = "0";
            this.txtAddWindSpeed.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddWindSpeed.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtAddHumidity
            // 
            // 
            // 
            // 
            this.txtAddHumidity.CustomButton.Image = null;
            this.txtAddHumidity.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txtAddHumidity.CustomButton.Name = "";
            this.txtAddHumidity.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtAddHumidity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddHumidity.CustomButton.TabIndex = 1;
            this.txtAddHumidity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddHumidity.CustomButton.UseSelectable = true;
            this.txtAddHumidity.CustomButton.Visible = false;
            this.txtAddHumidity.Lines = new string[0];
            this.txtAddHumidity.Location = new System.Drawing.Point(251, 165);
            this.txtAddHumidity.MaxLength = 32767;
            this.txtAddHumidity.Name = "txtAddHumidity";
            this.txtAddHumidity.PasswordChar = '\0';
            this.txtAddHumidity.PromptText = "0";
            this.txtAddHumidity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddHumidity.SelectedText = "";
            this.txtAddHumidity.SelectionLength = 0;
            this.txtAddHumidity.SelectionStart = 0;
            this.txtAddHumidity.ShortcutsEnabled = true;
            this.txtAddHumidity.Size = new System.Drawing.Size(200, 29);
            this.txtAddHumidity.TabIndex = 6;
            this.txtAddHumidity.UseSelectable = true;
            this.txtAddHumidity.WaterMark = "0";
            this.txtAddHumidity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddHumidity.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtAddMaxTemp
            // 
            // 
            // 
            // 
            this.txtAddMaxTemp.CustomButton.Image = null;
            this.txtAddMaxTemp.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txtAddMaxTemp.CustomButton.Name = "";
            this.txtAddMaxTemp.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtAddMaxTemp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddMaxTemp.CustomButton.TabIndex = 1;
            this.txtAddMaxTemp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddMaxTemp.CustomButton.UseSelectable = true;
            this.txtAddMaxTemp.CustomButton.Visible = false;
            this.txtAddMaxTemp.Lines = new string[0];
            this.txtAddMaxTemp.Location = new System.Drawing.Point(251, 99);
            this.txtAddMaxTemp.MaxLength = 32767;
            this.txtAddMaxTemp.Name = "txtAddMaxTemp";
            this.txtAddMaxTemp.PasswordChar = '\0';
            this.txtAddMaxTemp.PromptText = "Max";
            this.txtAddMaxTemp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddMaxTemp.SelectedText = "";
            this.txtAddMaxTemp.SelectionLength = 0;
            this.txtAddMaxTemp.SelectionStart = 0;
            this.txtAddMaxTemp.ShortcutsEnabled = true;
            this.txtAddMaxTemp.Size = new System.Drawing.Size(200, 29);
            this.txtAddMaxTemp.TabIndex = 6;
            this.txtAddMaxTemp.UseSelectable = true;
            this.txtAddMaxTemp.WaterMark = "Max";
            this.txtAddMaxTemp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddMaxTemp.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(251, 38);
            this.metroDateTime1.MinDate = new System.DateTime(2019, 5, 2, 18, 8, 8, 942);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 7;
            this.metroDateTime1.Value = new System.DateTime(2019, 5, 2, 18, 8, 8, 942);
            // 
            // panelAddForecast
            // 
            this.panelAddForecast.Controls.Add(this.metroDateTime1);
            this.panelAddForecast.Controls.Add(this.txtAddMaxTemp);
            this.panelAddForecast.Controls.Add(this.txtAddHumidity);
            this.panelAddForecast.Controls.Add(this.txtAddWindSpeed);
            this.panelAddForecast.Controls.Add(this.txtAddPrecip);
            this.panelAddForecast.Controls.Add(this.txtAddMinTemp);
            this.panelAddForecast.Controls.Add(this.button1);
            this.panelAddForecast.Controls.Add(this.cmdAddForecastCity);
            this.panelAddForecast.Controls.Add(this.metroLabel8);
            this.panelAddForecast.Controls.Add(this.metroLabel10);
            this.panelAddForecast.Controls.Add(this.metroLabel7);
            this.panelAddForecast.Controls.Add(this.metroLabel9);
            this.panelAddForecast.Controls.Add(this.metroLabel5);
            this.panelAddForecast.Controls.Add(this.metroLabel6);
            this.panelAddForecast.HorizontalScrollbarBarColor = true;
            this.panelAddForecast.HorizontalScrollbarHighlightOnWheel = false;
            this.panelAddForecast.HorizontalScrollbarSize = 10;
            this.panelAddForecast.Location = new System.Drawing.Point(117, 3);
            this.panelAddForecast.Name = "panelAddForecast";
            this.panelAddForecast.Size = new System.Drawing.Size(525, 317);
            this.panelAddForecast.TabIndex = 12;
            this.panelAddForecast.VerticalScrollbarBarColor = true;
            this.panelAddForecast.VerticalScrollbarHighlightOnWheel = false;
            this.panelAddForecast.VerticalScrollbarSize = 10;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RainCheckUI.Properties.Resources.BLURandrew_ruiz_1287537_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "FormDashboard";
            this.Text = "Dashboard";
            this.metroTabControl1.ResumeLayout(false);
            this.tabManageForecasts.ResumeLayout(false);
            this.panelRemoveForecast.ResumeLayout(false);
            this.panelRemoveForecast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRemoveForecastPreview)).EndInit();
            this.panelUpdateForecast.ResumeLayout(false);
            this.panelUpdateForecast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridForecastToUpdatePreview)).EndInit();
            this.panelAddForecast.ResumeLayout(false);
            this.panelAddForecast.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabShowAll;
        private MetroFramework.Controls.MetroTabPage tabManageForecasts;
        private MetroFramework.Controls.MetroTabPage tabManageLocation;
        private MetroFramework.Controls.MetroTabPage tabManageUsers;
        private MetroFramework.Controls.MetroPanel panelRemoveForecast;
        private MetroFramework.Controls.MetroComboBox cmbCityToRemove;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btnRemoveForecast;
        private MetroFramework.Controls.MetroGrid gridRemoveForecastPreview;
        private MetroFramework.Controls.MetroTile tileDeleteForecast;
        private MetroFramework.Controls.MetroTile tileUpdateForecast;
        private MetroFramework.Controls.MetroTile tileAddForecast;
        private MetroFramework.Controls.MetroPanel panelUpdateForecast;
        private System.Windows.Forms.Button btnUpdateForecast;
        private MetroFramework.Controls.MetroGrid gridForecastToUpdatePreview;
        private MetroFramework.Controls.MetroComboBox cmbForecastCityToUpdate;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroPanel panelAddForecast;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroTextBox txtAddMaxTemp;
        private MetroFramework.Controls.MetroTextBox txtAddHumidity;
        private MetroFramework.Controls.MetroTextBox txtAddWindSpeed;
        private MetroFramework.Controls.MetroTextBox txtAddPrecip;
        private MetroFramework.Controls.MetroTextBox txtAddMinTemp;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroComboBox cmdAddForecastCity;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}

