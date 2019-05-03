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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dashboardTabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabShowAll = new MetroFramework.Controls.MetroTabPage();
            this.gridViewAll = new MetroFramework.Controls.MetroGrid();
            this.forecastIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forecastDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minTempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxTempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precipitationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windSpeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forecastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabManageForecasts = new MetroFramework.Controls.MetroTabPage();
            this.panelUpdateForecast = new MetroFramework.Controls.MetroPanel();
            this.btnUpdateForecast = new System.Windows.Forms.Button();
            this.gridForecastToUpdatePreview = new MetroFramework.Controls.MetroGrid();
            this.cmbForecastCityToUpdate = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
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
            this.gridCityPreview = new MetroFramework.Controls.MetroGrid();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtSearchProvince = new MetroFramework.Controls.MetroTextBox();
            this.provinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCityName = new MetroFramework.Controls.MetroTextBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.tabManageUsers = new MetroFramework.Controls.MetroTabPage();
            this.chkMakeAdmin = new MetroFramework.Controls.MetroCheckBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtSearchHomeTown = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.gridAllUsers = new MetroFramework.Controls.MetroGrid();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeTown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeTownDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.panelAddForecast = new MetroFramework.Controls.MetroPanel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.txtAddMaxTemp = new MetroFramework.Controls.MetroTextBox();
            this.txtAddHumidity = new MetroFramework.Controls.MetroTextBox();
            this.txtAddWindSpeed = new MetroFramework.Controls.MetroTextBox();
            this.txtAddPrecip = new MetroFramework.Controls.MetroTextBox();
            this.txtAddMinTemp = new MetroFramework.Controls.MetroTextBox();
            this.btnAddForecast = new System.Windows.Forms.Button();
            this.cmdAddForecastCity = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dashboardTabControl.SuspendLayout();
            this.tabShowAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastBindingSource)).BeginInit();
            this.tabManageForecasts.SuspendLayout();
            this.panelUpdateForecast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridForecastToUpdatePreview)).BeginInit();
            this.panelRemoveForecast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRemoveForecastPreview)).BeginInit();
            this.tabManageLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCityPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            this.tabManageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllUsers)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            this.panelAddForecast.SuspendLayout();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardTabControl
            // 
            this.dashboardTabControl.Controls.Add(this.tabShowAll);
            this.dashboardTabControl.Controls.Add(this.tabManageForecasts);
            this.dashboardTabControl.Controls.Add(this.tabManageLocation);
            this.dashboardTabControl.Controls.Add(this.tabManageUsers);
            this.dashboardTabControl.Location = new System.Drawing.Point(24, 64);
            this.dashboardTabControl.Name = "dashboardTabControl";
            this.dashboardTabControl.SelectedIndex = 3;
            this.dashboardTabControl.Size = new System.Drawing.Size(853, 483);
            this.dashboardTabControl.TabIndex = 0;
            this.dashboardTabControl.UseSelectable = true;
            // 
            // tabShowAll
            // 
            this.tabShowAll.Controls.Add(this.gridViewAll);
            this.tabShowAll.HorizontalScrollbarBarColor = true;
            this.tabShowAll.HorizontalScrollbarHighlightOnWheel = false;
            this.tabShowAll.HorizontalScrollbarSize = 10;
            this.tabShowAll.Location = new System.Drawing.Point(4, 38);
            this.tabShowAll.Name = "tabShowAll";
            this.tabShowAll.Size = new System.Drawing.Size(845, 441);
            this.tabShowAll.Style = MetroFramework.MetroColorStyle.Black;
            this.tabShowAll.TabIndex = 0;
            this.tabShowAll.Text = "All Forecasts           ";
            this.tabShowAll.ToolTipText = "List all forecast";
            this.tabShowAll.VerticalScrollbarBarColor = true;
            this.tabShowAll.VerticalScrollbarHighlightOnWheel = false;
            this.tabShowAll.VerticalScrollbarSize = 10;
            // 
            // gridViewAll
            // 
            this.gridViewAll.AllowUserToAddRows = false;
            this.gridViewAll.AllowUserToDeleteRows = false;
            this.gridViewAll.AllowUserToResizeRows = false;
            this.gridViewAll.AutoGenerateColumns = false;
            this.gridViewAll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridViewAll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewAll.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridViewAll.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.gridViewAll.ColumnHeadersHeight = 24;
            this.gridViewAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.forecastIdDataGridViewTextBoxColumn,
            this.forecastDateDataGridViewTextBoxColumn,
            this.minTempDataGridViewTextBoxColumn,
            this.maxTempDataGridViewTextBoxColumn,
            this.precipitationDataGridViewTextBoxColumn,
            this.humidityDataGridViewTextBoxColumn,
            this.windSpeedDataGridViewTextBoxColumn,
            this.cityIdDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.gridViewAll.DataSource = this.forecastBindingSource;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewAll.DefaultCellStyle = dataGridViewCellStyle20;
            this.gridViewAll.EnableHeadersVisualStyles = false;
            this.gridViewAll.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridViewAll.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridViewAll.Location = new System.Drawing.Point(3, 2);
            this.gridViewAll.Name = "gridViewAll";
            this.gridViewAll.ReadOnly = true;
            this.gridViewAll.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewAll.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.gridViewAll.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewAll.Size = new System.Drawing.Size(846, 443);
            this.gridViewAll.TabIndex = 2;
            // 
            // forecastIdDataGridViewTextBoxColumn
            // 
            this.forecastIdDataGridViewTextBoxColumn.DataPropertyName = "ForecastId";
            this.forecastIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.forecastIdDataGridViewTextBoxColumn.Name = "forecastIdDataGridViewTextBoxColumn";
            this.forecastIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // forecastDateDataGridViewTextBoxColumn
            // 
            this.forecastDateDataGridViewTextBoxColumn.DataPropertyName = "ForecastDate";
            this.forecastDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.forecastDateDataGridViewTextBoxColumn.Name = "forecastDateDataGridViewTextBoxColumn";
            this.forecastDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minTempDataGridViewTextBoxColumn
            // 
            this.minTempDataGridViewTextBoxColumn.DataPropertyName = "MinTemp";
            this.minTempDataGridViewTextBoxColumn.HeaderText = "Minimum";
            this.minTempDataGridViewTextBoxColumn.Name = "minTempDataGridViewTextBoxColumn";
            this.minTempDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxTempDataGridViewTextBoxColumn
            // 
            this.maxTempDataGridViewTextBoxColumn.DataPropertyName = "MaxTemp";
            this.maxTempDataGridViewTextBoxColumn.HeaderText = "Maximum";
            this.maxTempDataGridViewTextBoxColumn.Name = "maxTempDataGridViewTextBoxColumn";
            this.maxTempDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precipitationDataGridViewTextBoxColumn
            // 
            this.precipitationDataGridViewTextBoxColumn.DataPropertyName = "Precipitation";
            this.precipitationDataGridViewTextBoxColumn.HeaderText = "Precipitation";
            this.precipitationDataGridViewTextBoxColumn.Name = "precipitationDataGridViewTextBoxColumn";
            this.precipitationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // humidityDataGridViewTextBoxColumn
            // 
            this.humidityDataGridViewTextBoxColumn.DataPropertyName = "Humidity";
            this.humidityDataGridViewTextBoxColumn.HeaderText = "Humidity";
            this.humidityDataGridViewTextBoxColumn.Name = "humidityDataGridViewTextBoxColumn";
            this.humidityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // windSpeedDataGridViewTextBoxColumn
            // 
            this.windSpeedDataGridViewTextBoxColumn.DataPropertyName = "WindSpeed";
            this.windSpeedDataGridViewTextBoxColumn.HeaderText = "Wind Speed";
            this.windSpeedDataGridViewTextBoxColumn.Name = "windSpeedDataGridViewTextBoxColumn";
            this.windSpeedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityIdDataGridViewTextBoxColumn
            // 
            this.cityIdDataGridViewTextBoxColumn.DataPropertyName = "CityId";
            this.cityIdDataGridViewTextBoxColumn.HeaderText = "City Id";
            this.cityIdDataGridViewTextBoxColumn.Name = "cityIdDataGridViewTextBoxColumn";
            this.cityIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // forecastBindingSource
            // 
            this.forecastBindingSource.DataSource = typeof(RainCheckUI.Model.Forecast);
            // 
            // tabManageForecasts
            // 
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
            this.tabManageForecasts.Size = new System.Drawing.Size(845, 441);
            this.tabManageForecasts.TabIndex = 1;
            this.tabManageForecasts.Text = "Manage Forecasts       ";
            this.tabManageForecasts.ToolTipText = "Manage forecast data";
            this.tabManageForecasts.VerticalScrollbarBarColor = true;
            this.tabManageForecasts.VerticalScrollbarHighlightOnWheel = false;
            this.tabManageForecasts.VerticalScrollbarSize = 10;
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
            this.panelUpdateForecast.Location = new System.Drawing.Point(151, 14);
            this.panelUpdateForecast.Name = "panelUpdateForecast";
            this.panelUpdateForecast.Size = new System.Drawing.Size(691, 424);
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
            this.btnUpdateForecast.Location = new System.Drawing.Point(17, 372);
            this.btnUpdateForecast.Name = "btnUpdateForecast";
            this.btnUpdateForecast.Size = new System.Drawing.Size(162, 49);
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridForecastToUpdatePreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.gridForecastToUpdatePreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridForecastToUpdatePreview.DefaultCellStyle = dataGridViewCellStyle23;
            this.gridForecastToUpdatePreview.EnableHeadersVisualStyles = false;
            this.gridForecastToUpdatePreview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridForecastToUpdatePreview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridForecastToUpdatePreview.Location = new System.Drawing.Point(17, 137);
            this.gridForecastToUpdatePreview.Name = "gridForecastToUpdatePreview";
            this.gridForecastToUpdatePreview.ReadOnly = true;
            this.gridForecastToUpdatePreview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridForecastToUpdatePreview.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.gridForecastToUpdatePreview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridForecastToUpdatePreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridForecastToUpdatePreview.Size = new System.Drawing.Size(433, 189);
            this.gridForecastToUpdatePreview.TabIndex = 4;
            this.gridForecastToUpdatePreview.UseCustomBackColor = true;
            this.gridForecastToUpdatePreview.UseCustomForeColor = true;
            // 
            // cmbForecastCityToUpdate
            // 
            this.cmbForecastCityToUpdate.FormattingEnabled = true;
            this.cmbForecastCityToUpdate.ItemHeight = 23;
            this.cmbForecastCityToUpdate.Location = new System.Drawing.Point(17, 45);
            this.cmbForecastCityToUpdate.Name = "cmbForecastCityToUpdate";
            this.cmbForecastCityToUpdate.Size = new System.Drawing.Size(430, 29);
            this.cmbForecastCityToUpdate.TabIndex = 3;
            this.cmbForecastCityToUpdate.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(17, 102);
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
            // tileDeleteForecast
            // 
            this.tileDeleteForecast.ActiveControl = null;
            this.tileDeleteForecast.BackColor = System.Drawing.Color.White;
            this.tileDeleteForecast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileDeleteForecast.Location = new System.Drawing.Point(3, 290);
            this.tileDeleteForecast.Name = "tileDeleteForecast";
            this.tileDeleteForecast.Size = new System.Drawing.Size(113, 148);
            this.tileDeleteForecast.TabIndex = 7;
            this.tileDeleteForecast.Text = "Remove";
            this.tileDeleteForecast.UseSelectable = true;
            this.tileDeleteForecast.Click += new System.EventHandler(this.tileDeleteForecast_Click);
            // 
            // tileUpdateForecast
            // 
            this.tileUpdateForecast.ActiveControl = null;
            this.tileUpdateForecast.BackColor = System.Drawing.Color.White;
            this.tileUpdateForecast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileUpdateForecast.Location = new System.Drawing.Point(3, 107);
            this.tileUpdateForecast.Name = "tileUpdateForecast";
            this.tileUpdateForecast.Size = new System.Drawing.Size(113, 183);
            this.tileUpdateForecast.TabIndex = 8;
            this.tileUpdateForecast.Text = "Update";
            this.tileUpdateForecast.UseSelectable = true;
            this.tileUpdateForecast.Click += new System.EventHandler(this.tileUpdateForecast_Click);
            // 
            // tileAddForecast
            // 
            this.tileAddForecast.ActiveControl = null;
            this.tileAddForecast.BackColor = System.Drawing.Color.White;
            this.tileAddForecast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileAddForecast.Location = new System.Drawing.Point(3, 0);
            this.tileAddForecast.Name = "tileAddForecast";
            this.tileAddForecast.Size = new System.Drawing.Size(113, 108);
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
            this.panelRemoveForecast.Location = new System.Drawing.Point(149, 15);
            this.panelRemoveForecast.Name = "panelRemoveForecast";
            this.panelRemoveForecast.Size = new System.Drawing.Size(842, 423);
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
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRemoveForecastPreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.gridRemoveForecastPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridRemoveForecastPreview.DefaultCellStyle = dataGridViewCellStyle26;
            this.gridRemoveForecastPreview.EnableHeadersVisualStyles = false;
            this.gridRemoveForecastPreview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridRemoveForecastPreview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridRemoveForecastPreview.Location = new System.Drawing.Point(24, 95);
            this.gridRemoveForecastPreview.Name = "gridRemoveForecastPreview";
            this.gridRemoveForecastPreview.ReadOnly = true;
            this.gridRemoveForecastPreview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRemoveForecastPreview.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
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
            this.tabManageLocation.Controls.Add(this.gridCityPreview);
            this.tabManageLocation.Controls.Add(this.button2);
            this.tabManageLocation.Controls.Add(this.button3);
            this.tabManageLocation.Controls.Add(this.button4);
            this.tabManageLocation.Controls.Add(this.txtSearchProvince);
            this.tabManageLocation.Controls.Add(this.txtCityName);
            this.tabManageLocation.Controls.Add(this.metroLabel14);
            this.tabManageLocation.Controls.Add(this.metroLabel15);
            this.tabManageLocation.Controls.Add(this.metroLabel16);
            this.tabManageLocation.HorizontalScrollbarBarColor = true;
            this.tabManageLocation.HorizontalScrollbarHighlightOnWheel = false;
            this.tabManageLocation.HorizontalScrollbarSize = 10;
            this.tabManageLocation.Location = new System.Drawing.Point(4, 38);
            this.tabManageLocation.Name = "tabManageLocation";
            this.tabManageLocation.Size = new System.Drawing.Size(845, 441);
            this.tabManageLocation.TabIndex = 2;
            this.tabManageLocation.Text = "Manage Location   ";
            this.tabManageLocation.ToolTipText = "Manage Locations";
            this.tabManageLocation.VerticalScrollbarBarColor = true;
            this.tabManageLocation.VerticalScrollbarHighlightOnWheel = false;
            this.tabManageLocation.VerticalScrollbarSize = 10;
            // 
            // gridCityPreview
            // 
            this.gridCityPreview.AllowUserToResizeRows = false;
            this.gridCityPreview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.gridCityPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCityPreview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridCityPreview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCityPreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.gridCityPreview.ColumnHeadersHeight = 24;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCityPreview.DefaultCellStyle = dataGridViewCellStyle29;
            this.gridCityPreview.EnableHeadersVisualStyles = false;
            this.gridCityPreview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridCityPreview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridCityPreview.Location = new System.Drawing.Point(401, 0);
            this.gridCityPreview.Name = "gridCityPreview";
            this.gridCityPreview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCityPreview.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.gridCityPreview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridCityPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCityPreview.Size = new System.Drawing.Size(441, 438);
            this.gridCityPreview.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(230, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 38);
            this.button2.TabIndex = 18;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(117, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 38);
            this.button3.TabIndex = 19;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SpringGreen;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 400);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 38);
            this.button4.TabIndex = 20;
            this.button4.Text = "Add User";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // txtSearchProvince
            // 
            // 
            // 
            // 
            this.txtSearchProvince.CustomButton.Image = null;
            this.txtSearchProvince.CustomButton.Location = new System.Drawing.Point(313, 1);
            this.txtSearchProvince.CustomButton.Name = "";
            this.txtSearchProvince.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtSearchProvince.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchProvince.CustomButton.TabIndex = 1;
            this.txtSearchProvince.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchProvince.CustomButton.UseSelectable = true;
            this.txtSearchProvince.CustomButton.Visible = false;
            this.txtSearchProvince.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.provinceBindingSource, "ProvinceName", true));
            this.txtSearchProvince.Lines = new string[0];
            this.txtSearchProvince.Location = new System.Drawing.Point(4, 233);
            this.txtSearchProvince.MaxLength = 32767;
            this.txtSearchProvince.Name = "txtSearchProvince";
            this.txtSearchProvince.PasswordChar = '\0';
            this.txtSearchProvince.PromptText = "eg. Eastern Cape";
            this.txtSearchProvince.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchProvince.SelectedText = "";
            this.txtSearchProvince.SelectionLength = 0;
            this.txtSearchProvince.SelectionStart = 0;
            this.txtSearchProvince.ShortcutsEnabled = true;
            this.txtSearchProvince.Size = new System.Drawing.Size(341, 29);
            this.txtSearchProvince.TabIndex = 17;
            this.txtSearchProvince.UseSelectable = true;
            this.txtSearchProvince.WaterMark = "eg. Eastern Cape";
            this.txtSearchProvince.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchProvince.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // provinceBindingSource
            // 
            this.provinceBindingSource.DataSource = typeof(RainCheckUI.Model.Province);
            // 
            // txtCityName
            // 
            // 
            // 
            // 
            this.txtCityName.CustomButton.Image = null;
            this.txtCityName.CustomButton.Location = new System.Drawing.Point(313, 1);
            this.txtCityName.CustomButton.Name = "";
            this.txtCityName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCityName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCityName.CustomButton.TabIndex = 1;
            this.txtCityName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCityName.CustomButton.UseSelectable = true;
            this.txtCityName.CustomButton.Visible = false;
            this.txtCityName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "CityName", true));
            this.txtCityName.Lines = new string[0];
            this.txtCityName.Location = new System.Drawing.Point(3, 99);
            this.txtCityName.MaxLength = 32767;
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.PasswordChar = '\0';
            this.txtCityName.PromptText = "eg. Durban";
            this.txtCityName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCityName.SelectedText = "";
            this.txtCityName.SelectionLength = 0;
            this.txtCityName.SelectionStart = 0;
            this.txtCityName.ShortcutsEnabled = true;
            this.txtCityName.Size = new System.Drawing.Size(341, 29);
            this.txtCityName.TabIndex = 17;
            this.txtCityName.UseSelectable = true;
            this.txtCityName.WaterMark = "eg. Durban";
            this.txtCityName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCityName.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(RainCheckUI.Model.City);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(4, 202);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(59, 19);
            this.metroLabel14.TabIndex = 13;
            this.metroLabel14.Text = "Province";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(4, 164);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(0, 0);
            this.metroLabel15.TabIndex = 14;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(3, 71);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(71, 19);
            this.metroLabel16.TabIndex = 15;
            this.metroLabel16.Text = "City Name";
            // 
            // tabManageUsers
            // 
            this.tabManageUsers.Controls.Add(this.chkMakeAdmin);
            this.tabManageUsers.Controls.Add(this.btnDeleteUser);
            this.tabManageUsers.Controls.Add(this.btnUpdateUser);
            this.tabManageUsers.Controls.Add(this.btnAddUser);
            this.tabManageUsers.Controls.Add(this.txtPassword);
            this.tabManageUsers.Controls.Add(this.txtSearchHomeTown);
            this.tabManageUsers.Controls.Add(this.txtUsername);
            this.tabManageUsers.Controls.Add(this.metroLabel13);
            this.tabManageUsers.Controls.Add(this.metroLabel12);
            this.tabManageUsers.Controls.Add(this.metroLabel11);
            this.tabManageUsers.Controls.Add(this.gridAllUsers);
            this.tabManageUsers.HorizontalScrollbarBarColor = true;
            this.tabManageUsers.HorizontalScrollbarHighlightOnWheel = false;
            this.tabManageUsers.HorizontalScrollbarSize = 10;
            this.tabManageUsers.Location = new System.Drawing.Point(4, 38);
            this.tabManageUsers.Name = "tabManageUsers";
            this.tabManageUsers.Size = new System.Drawing.Size(845, 441);
            this.tabManageUsers.TabIndex = 3;
            this.tabManageUsers.Text = "Manage Users";
            this.tabManageUsers.ToolTipText = "Manage registered users";
            this.tabManageUsers.VerticalScrollbarBarColor = true;
            this.tabManageUsers.VerticalScrollbarHighlightOnWheel = false;
            this.tabManageUsers.VerticalScrollbarSize = 10;
            // 
            // chkMakeAdmin
            // 
            this.chkMakeAdmin.AutoSize = true;
            this.chkMakeAdmin.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.userBindingSource, "isAdmin", true));
            this.chkMakeAdmin.Location = new System.Drawing.Point(5, 307);
            this.chkMakeAdmin.Name = "chkMakeAdmin";
            this.chkMakeAdmin.Size = new System.Drawing.Size(59, 15);
            this.chkMakeAdmin.TabIndex = 10;
            this.chkMakeAdmin.Text = "Admin";
            this.chkMakeAdmin.UseSelectable = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(RainCheckUI.Model.User);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(232, 400);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(114, 38);
            this.btnDeleteUser.TabIndex = 9;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.Gold;
            this.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUser.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.Location = new System.Drawing.Point(119, 400);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(107, 38);
            this.btnUpdateUser.TabIndex = 9;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(3, 400);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(108, 38);
            this.btnAddUser.TabIndex = 9;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(313, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Password", true));
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(5, 171);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '▪';
            this.txtPassword.PromptText = "password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(341, 29);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtSearchHomeTown
            // 
            // 
            // 
            // 
            this.txtSearchHomeTown.CustomButton.Image = null;
            this.txtSearchHomeTown.CustomButton.Location = new System.Drawing.Point(313, 1);
            this.txtSearchHomeTown.CustomButton.Name = "";
            this.txtSearchHomeTown.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtSearchHomeTown.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchHomeTown.CustomButton.TabIndex = 1;
            this.txtSearchHomeTown.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchHomeTown.CustomButton.UseSelectable = true;
            this.txtSearchHomeTown.CustomButton.Visible = false;
            this.txtSearchHomeTown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "CityName", true));
            this.txtSearchHomeTown.Lines = new string[0];
            this.txtSearchHomeTown.Location = new System.Drawing.Point(0, 252);
            this.txtSearchHomeTown.MaxLength = 32767;
            this.txtSearchHomeTown.Name = "txtSearchHomeTown";
            this.txtSearchHomeTown.PasswordChar = '\0';
            this.txtSearchHomeTown.PromptText = "eg. Durban";
            this.txtSearchHomeTown.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchHomeTown.SelectedText = "";
            this.txtSearchHomeTown.SelectionLength = 0;
            this.txtSearchHomeTown.SelectionStart = 0;
            this.txtSearchHomeTown.ShortcutsEnabled = true;
            this.txtSearchHomeTown.Size = new System.Drawing.Size(341, 29);
            this.txtSearchHomeTown.TabIndex = 8;
            this.txtSearchHomeTown.UseSelectable = true;
            this.txtSearchHomeTown.WaterMark = "eg. Durban";
            this.txtSearchHomeTown.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchHomeTown.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(313, 1);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Username", true));
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(3, 84);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PromptText = "username";
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(341, 29);
            this.txtUsername.TabIndex = 8;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMark = "username";
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(3, 224);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(78, 19);
            this.metroLabel13.TabIndex = 7;
            this.metroLabel13.Text = "Home Town";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(3, 138);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(63, 19);
            this.metroLabel12.TabIndex = 7;
            this.metroLabel12.Text = "Password";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(3, 57);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(68, 19);
            this.metroLabel11.TabIndex = 7;
            this.metroLabel11.Text = "Username";
            // 
            // gridAllUsers
            // 
            this.gridAllUsers.AllowUserToAddRows = false;
            this.gridAllUsers.AllowUserToDeleteRows = false;
            this.gridAllUsers.AllowUserToResizeRows = false;
            this.gridAllUsers.AutoGenerateColumns = false;
            this.gridAllUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.gridAllUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridAllUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridAllUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAllUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.gridAllUsers.ColumnHeadersHeight = 24;
            this.gridAllUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Password,
            this.HomeTown,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.homeTownDataGridViewTextBoxColumn});
            this.gridAllUsers.DataSource = this.userBindingSource;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAllUsers.DefaultCellStyle = dataGridViewCellStyle17;
            this.gridAllUsers.EnableHeadersVisualStyles = false;
            this.gridAllUsers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridAllUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridAllUsers.Location = new System.Drawing.Point(399, 0);
            this.gridAllUsers.Name = "gridAllUsers";
            this.gridAllUsers.ReadOnly = true;
            this.gridAllUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAllUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.gridAllUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridAllUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAllUsers.Size = new System.Drawing.Size(443, 438);
            this.gridAllUsers.TabIndex = 2;
            this.gridAllUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAllUsers_CellContentClick);
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // HomeTown
            // 
            this.HomeTown.DataPropertyName = "HomeTown";
            this.HomeTown.HeaderText = "Home Town";
            this.HomeTown.Name = "HomeTown";
            this.HomeTown.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // homeTownDataGridViewTextBoxColumn
            // 
            this.homeTownDataGridViewTextBoxColumn.DataPropertyName = "HomeTown";
            this.homeTownDataGridViewTextBoxColumn.HeaderText = "Home Town";
            this.homeTownDataGridViewTextBoxColumn.Name = "homeTownDataGridViewTextBoxColumn";
            this.homeTownDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HomeTown";
            this.dataGridViewTextBoxColumn1.HeaderText = "Home Town";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(281, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 33);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HomeTown";
            this.dataGridViewTextBoxColumn2.HeaderText = "Home Town";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HomeTown";
            this.dataGridViewTextBoxColumn3.HeaderText = "Home Town";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.panelAddForecast);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(0, 0);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(200, 100);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // panelAddForecast
            // 
            this.panelAddForecast.Controls.Add(this.metroDateTime1);
            this.panelAddForecast.Controls.Add(this.txtAddMaxTemp);
            this.panelAddForecast.Controls.Add(this.txtAddHumidity);
            this.panelAddForecast.Controls.Add(this.txtAddWindSpeed);
            this.panelAddForecast.Controls.Add(this.txtAddPrecip);
            this.panelAddForecast.Controls.Add(this.txtAddMinTemp);
            this.panelAddForecast.Controls.Add(this.btnAddForecast);
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
            this.panelAddForecast.Location = new System.Drawing.Point(110, 2);
            this.panelAddForecast.Name = "panelAddForecast";
            this.panelAddForecast.Size = new System.Drawing.Size(525, 317);
            this.panelAddForecast.TabIndex = 13;
            this.panelAddForecast.VerticalScrollbarBarColor = true;
            this.panelAddForecast.VerticalScrollbarHighlightOnWheel = false;
            this.panelAddForecast.VerticalScrollbarSize = 10;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.forecastBindingSource, "ForecastDate", true));
            this.metroDateTime1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forecastBindingSource, "ForecastDate", true));
            this.metroDateTime1.Location = new System.Drawing.Point(251, 38);
            this.metroDateTime1.MinDate = new System.DateTime(2019, 5, 2, 18, 8, 8, 942);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 7;
            this.metroDateTime1.Value = new System.DateTime(2019, 5, 2, 18, 8, 8, 942);
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
            this.txtAddMaxTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forecastBindingSource, "MaxTemp", true));
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
            this.txtAddHumidity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forecastBindingSource, "Humidity", true));
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
            this.txtAddWindSpeed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forecastBindingSource, "WindSpeed", true));
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
            this.txtAddPrecip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forecastBindingSource, "Precipitation", true));
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
            this.txtAddMinTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forecastBindingSource, "MinTemp", true));
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
            // btnAddForecast
            // 
            this.btnAddForecast.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAddForecast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddForecast.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnAddForecast.FlatAppearance.BorderSize = 0;
            this.btnAddForecast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnAddForecast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddForecast.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAddForecast.Location = new System.Drawing.Point(21, 274);
            this.btnAddForecast.Name = "btnAddForecast";
            this.btnAddForecast.Size = new System.Drawing.Size(114, 38);
            this.btnAddForecast.TabIndex = 5;
            this.btnAddForecast.Text = "Add";
            this.btnAddForecast.UseVisualStyleBackColor = false;
            // 
            // cmdAddForecastCity
            // 
            this.cmdAddForecastCity.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.forecastBindingSource, "City", true));
            this.cmdAddForecastCity.DataSource = this.forecastBindingSource;
            this.cmdAddForecastCity.DisplayMember = "CityId";
            this.cmdAddForecastCity.FormattingEnabled = true;
            this.cmdAddForecastCity.ItemHeight = 23;
            this.cmdAddForecastCity.Location = new System.Drawing.Point(21, 38);
            this.cmdAddForecastCity.Name = "cmdAddForecastCity";
            this.cmdAddForecastCity.Size = new System.Drawing.Size(200, 29);
            this.cmdAddForecastCity.TabIndex = 3;
            this.cmdAddForecastCity.UseSelectable = true;
            this.cmdAddForecastCity.ValueMember = "CityId";
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
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(21, 205);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(81, 19);
            this.metroLabel10.TabIndex = 2;
            this.metroLabel10.Text = "Wind Speed";
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
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(251, 16);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(36, 19);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "Date";
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
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(21, 16);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(31, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "City";
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.metroContextMenu1.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "HomeTown";
            this.dataGridViewTextBoxColumn4.HeaderText = "Home Town";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HomeTown";
            this.dataGridViewTextBoxColumn5.HeaderText = "Home Town";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "HomeTown";
            this.dataGridViewTextBoxColumn6.HeaderText = "Home Town";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "HomeTown";
            this.dataGridViewTextBoxColumn7.HeaderText = "Home Town";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RainCheckUI.Properties.Resources.BLURandrew_ruiz_1287537_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dashboardTabControl);
            this.MaximizeBox = false;
            this.Name = "FormDashboard";
            this.Text = "Dashboard";
            this.dashboardTabControl.ResumeLayout(false);
            this.tabShowAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastBindingSource)).EndInit();
            this.tabManageForecasts.ResumeLayout(false);
            this.panelUpdateForecast.ResumeLayout(false);
            this.panelUpdateForecast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridForecastToUpdatePreview)).EndInit();
            this.panelRemoveForecast.ResumeLayout(false);
            this.panelRemoveForecast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRemoveForecastPreview)).EndInit();
            this.tabManageLocation.ResumeLayout(false);
            this.tabManageLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCityPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            this.tabManageUsers.ResumeLayout(false);
            this.tabManageUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllUsers)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            this.panelAddForecast.ResumeLayout(false);
            this.panelAddForecast.PerformLayout();
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl dashboardTabControl;
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
        private MetroFramework.Controls.MetroPanel panelUpdateForecast;
        private System.Windows.Forms.Button btnUpdateForecast;
        private MetroFramework.Controls.MetroGrid gridForecastToUpdatePreview;
        private MetroFramework.Controls.MetroComboBox cmbForecastCityToUpdate;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroGrid gridViewAll;
        private System.Windows.Forms.BindingSource forecastBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn forecastIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forecastDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minTempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxTempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precipitationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn humidityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn windSpeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTile tileDeleteForecast;
        private MetroFramework.Controls.MetroTile tileUpdateForecast;
        private MetroFramework.Controls.MetroTile tileAddForecast;
        private MetroFramework.Controls.MetroGrid gridAllUsers;
        private System.Windows.Forms.BindingSource userBindingSource;
        private MetroFramework.Controls.MetroCheckBox chkMakeAdmin;
        private System.Windows.Forms.Button btnAddUser;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private MetroFramework.Controls.MetroTextBox txtCityName;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private System.Windows.Forms.BindingSource provinceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.Button btnRefresh;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroGrid gridCityPreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeTown;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeTownDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroPanel panelAddForecast;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroTextBox txtAddMaxTemp;
        private MetroFramework.Controls.MetroTextBox txtAddHumidity;
        private MetroFramework.Controls.MetroTextBox txtAddWindSpeed;
        private MetroFramework.Controls.MetroTextBox txtAddPrecip;
        private MetroFramework.Controls.MetroTextBox txtAddMinTemp;
        private System.Windows.Forms.Button btnAddForecast;
        private MetroFramework.Controls.MetroComboBox cmdAddForecastCity;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private MetroFramework.Controls.MetroTextBox txtSearchProvince;
        private MetroFramework.Controls.MetroTextBox txtSearchHomeTown;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

