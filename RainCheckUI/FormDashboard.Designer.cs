using System;
using System.Drawing;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.forecastDate = new MetroFramework.Controls.MetroDateTime();
            this.cmbCityForecast = new MetroFramework.Controls.MetroComboBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteForecast = new System.Windows.Forms.Button();
            this.btnUpdateForecast = new System.Windows.Forms.Button();
            this.btnNewForecast = new System.Windows.Forms.Button();
            this.txtWindSpeed = new MetroFramework.Controls.MetroTextBox();
            this.txtHumidity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.txtPrecipitation = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.txtMaxTemp = new MetroFramework.Controls.MetroTextBox();
            this.txtMinTemp = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.gridPreviewForecast = new MetroFramework.Controls.MetroGrid();
            this.forecastDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minTempDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxTempDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precipitationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windSpeedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityIdDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabManageLocation = new MetroFramework.Controls.MetroTabPage();
            this.lbValidator = new MetroFramework.Controls.MetroLabel();
            this.gridCityPreview = new MetroFramework.Controls.MetroGrid();
            this.cityIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteCity = new System.Windows.Forms.Button();
            this.btnUpdateCity = new System.Windows.Forms.Button();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.txtSearchProvince = new MetroFramework.Controls.MetroTextBox();
            this.txtCityName = new MetroFramework.Controls.MetroTextBox();
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.provinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.iconStrip = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnToggleMenu = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dashboardTabControl.SuspendLayout();
            this.tabShowAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastBindingSource)).BeginInit();
            this.tabManageForecasts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPreviewForecast)).BeginInit();
            this.tabManageLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCityPreview)).BeginInit();
            this.tabManageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            this.panelAddForecast.SuspendLayout();
            this.metroContextMenu1.SuspendLayout();
            this.iconStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardTabControl
            // 
            this.dashboardTabControl.Controls.Add(this.tabShowAll);
            this.dashboardTabControl.Controls.Add(this.tabManageForecasts);
            this.dashboardTabControl.Controls.Add(this.tabManageLocation);
            this.dashboardTabControl.Controls.Add(this.tabManageUsers);
            this.dashboardTabControl.Location = new System.Drawing.Point(71, 55);
            this.dashboardTabControl.Name = "dashboardTabControl";
            this.dashboardTabControl.SelectedIndex = 0;
            this.dashboardTabControl.Size = new System.Drawing.Size(829, 483);
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
            this.tabShowAll.Size = new System.Drawing.Size(821, 441);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewAll.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewAll.EnableHeadersVisualStyles = false;
            this.gridViewAll.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridViewAll.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridViewAll.Location = new System.Drawing.Point(3, 2);
            this.gridViewAll.Name = "gridViewAll";
            this.gridViewAll.ReadOnly = true;
            this.gridViewAll.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewAll.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewAll.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewAll.Size = new System.Drawing.Size(822, 443);
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
            this.tabManageForecasts.Controls.Add(this.forecastDate);
            this.tabManageForecasts.Controls.Add(this.cmbCityForecast);
            this.tabManageForecasts.Controls.Add(this.btnDeleteForecast);
            this.tabManageForecasts.Controls.Add(this.btnUpdateForecast);
            this.tabManageForecasts.Controls.Add(this.btnNewForecast);
            this.tabManageForecasts.Controls.Add(this.txtWindSpeed);
            this.tabManageForecasts.Controls.Add(this.txtHumidity);
            this.tabManageForecasts.Controls.Add(this.metroLabel18);
            this.tabManageForecasts.Controls.Add(this.txtPrecipitation);
            this.tabManageForecasts.Controls.Add(this.metroLabel17);
            this.tabManageForecasts.Controls.Add(this.txtMaxTemp);
            this.tabManageForecasts.Controls.Add(this.txtMinTemp);
            this.tabManageForecasts.Controls.Add(this.metroLabel19);
            this.tabManageForecasts.Controls.Add(this.metroLabel4);
            this.tabManageForecasts.Controls.Add(this.metroLabel1);
            this.tabManageForecasts.Controls.Add(this.metroLabel2);
            this.tabManageForecasts.Controls.Add(this.metroLabel3);
            this.tabManageForecasts.Controls.Add(this.gridPreviewForecast);
            this.tabManageForecasts.HorizontalScrollbarBarColor = false;
            this.tabManageForecasts.HorizontalScrollbarHighlightOnWheel = false;
            this.tabManageForecasts.HorizontalScrollbarSize = 10;
            this.tabManageForecasts.Location = new System.Drawing.Point(4, 38);
            this.tabManageForecasts.Name = "tabManageForecasts";
            this.tabManageForecasts.Size = new System.Drawing.Size(821, 441);
            this.tabManageForecasts.TabIndex = 1;
            this.tabManageForecasts.Text = "Manage Forecasts       ";
            this.tabManageForecasts.ToolTipText = "Manage forecast data";
            this.tabManageForecasts.VerticalScrollbarBarColor = true;
            this.tabManageForecasts.VerticalScrollbarHighlightOnWheel = false;
            this.tabManageForecasts.VerticalScrollbarSize = 10;
            // 
            // forecastDate
            // 
            this.forecastDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.forecastBindingSource, "ForecastDate", true));
            this.forecastDate.Location = new System.Drawing.Point(4, 101);
            this.forecastDate.MinimumSize = new System.Drawing.Size(4, 29);
            this.forecastDate.Name = "forecastDate";
            this.forecastDate.Size = new System.Drawing.Size(340, 29);
            this.forecastDate.TabIndex = 0;
            // 
            // cmbCityForecast
            // 
            this.cmbCityForecast.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.forecastBindingSource, "CityId", true));
            this.cmbCityForecast.DataSource = this.cityBindingSource;
            this.cmbCityForecast.DisplayMember = "CityName";
            this.cmbCityForecast.FormattingEnabled = true;
            this.cmbCityForecast.ItemHeight = 23;
            this.cmbCityForecast.Location = new System.Drawing.Point(4, 47);
            this.cmbCityForecast.Name = "cmbCityForecast";
            this.cmbCityForecast.Size = new System.Drawing.Size(337, 29);
            this.cmbCityForecast.TabIndex = 0;
            this.cmbCityForecast.UseSelectable = true;
            this.cmbCityForecast.ValueMember = "CityId";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(RainCheckUI.Model.City);
            // 
            // btnDeleteForecast
            // 
            this.btnDeleteForecast.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteForecast.Cursor = System.Windows.Forms.Cursors.No;
            this.btnDeleteForecast.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnDeleteForecast.FlatAppearance.BorderSize = 0;
            this.btnDeleteForecast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteForecast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteForecast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteForecast.Location = new System.Drawing.Point(233, 401);
            this.btnDeleteForecast.Name = "btnDeleteForecast";
            this.btnDeleteForecast.Size = new System.Drawing.Size(114, 38);
            this.btnDeleteForecast.TabIndex = 11;
            this.btnDeleteForecast.Text = "Delete";
            this.btnDeleteForecast.UseVisualStyleBackColor = false;
            this.btnDeleteForecast.Click += new System.EventHandler(this.btnDeleteForecast_Click);
            // 
            // btnUpdateForecast
            // 
            this.btnUpdateForecast.BackColor = System.Drawing.Color.Gold;
            this.btnUpdateForecast.Cursor = System.Windows.Forms.Cursors.No;
            this.btnUpdateForecast.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnUpdateForecast.FlatAppearance.BorderSize = 0;
            this.btnUpdateForecast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnUpdateForecast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateForecast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateForecast.Location = new System.Drawing.Point(120, 401);
            this.btnUpdateForecast.Name = "btnUpdateForecast";
            this.btnUpdateForecast.Size = new System.Drawing.Size(107, 38);
            this.btnUpdateForecast.TabIndex = 10;
            this.btnUpdateForecast.Text = "Update";
            this.btnUpdateForecast.UseVisualStyleBackColor = false;
            // 
            // btnNewForecast
            // 
            this.btnNewForecast.BackColor = System.Drawing.Color.SpringGreen;
            this.btnNewForecast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewForecast.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnNewForecast.FlatAppearance.BorderSize = 0;
            this.btnNewForecast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnNewForecast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewForecast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewForecast.Location = new System.Drawing.Point(4, 401);
            this.btnNewForecast.Name = "btnNewForecast";
            this.btnNewForecast.Size = new System.Drawing.Size(108, 38);
            this.btnNewForecast.TabIndex = 9;
            this.btnNewForecast.Text = "Add ";
            this.btnNewForecast.UseVisualStyleBackColor = false;
            this.btnNewForecast.Click += new System.EventHandler(this.btnNewForecast_Click);
            // 
            // txtWindSpeed
            // 
            // 
            // 
            // 
            this.txtWindSpeed.CustomButton.Image = null;
            this.txtWindSpeed.CustomButton.Location = new System.Drawing.Point(313, 1);
            this.txtWindSpeed.CustomButton.Name = "";
            this.txtWindSpeed.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtWindSpeed.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWindSpeed.CustomButton.TabIndex = 1;
            this.txtWindSpeed.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWindSpeed.CustomButton.UseSelectable = true;
            this.txtWindSpeed.CustomButton.Visible = false;
            this.txtWindSpeed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forecastBindingSource, "WindSpeed", true));
            this.txtWindSpeed.Lines = new string[0];
            this.txtWindSpeed.Location = new System.Drawing.Point(4, 344);
            this.txtWindSpeed.MaxLength = 32767;
            this.txtWindSpeed.Name = "txtWindSpeed";
            this.txtWindSpeed.PasswordChar = '\0';
            this.txtWindSpeed.PromptText = "eg. 12";
            this.txtWindSpeed.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWindSpeed.SelectedText = "";
            this.txtWindSpeed.SelectionLength = 0;
            this.txtWindSpeed.SelectionStart = 0;
            this.txtWindSpeed.ShortcutsEnabled = true;
            this.txtWindSpeed.Size = new System.Drawing.Size(341, 29);
            this.txtWindSpeed.TabIndex = 7;
            this.txtWindSpeed.UseSelectable = true;
            this.txtWindSpeed.WaterMark = "eg. 12";
            this.txtWindSpeed.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWindSpeed.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtHumidity
            // 
            // 
            // 
            // 
            this.txtHumidity.CustomButton.Image = null;
            this.txtHumidity.CustomButton.Location = new System.Drawing.Point(313, 1);
            this.txtHumidity.CustomButton.Name = "";
            this.txtHumidity.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtHumidity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHumidity.CustomButton.TabIndex = 1;
            this.txtHumidity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHumidity.CustomButton.UseSelectable = true;
            this.txtHumidity.CustomButton.Visible = false;
            this.txtHumidity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forecastBindingSource, "Humidity", true));
            this.txtHumidity.Lines = new string[0];
            this.txtHumidity.Location = new System.Drawing.Point(5, 283);
            this.txtHumidity.MaxLength = 32767;
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.PasswordChar = '\0';
            this.txtHumidity.PromptText = "eg. 20";
            this.txtHumidity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHumidity.SelectedText = "";
            this.txtHumidity.SelectionLength = 0;
            this.txtHumidity.SelectionStart = 0;
            this.txtHumidity.ShortcutsEnabled = true;
            this.txtHumidity.Size = new System.Drawing.Size(341, 29);
            this.txtHumidity.TabIndex = 6;
            this.txtHumidity.UseSelectable = true;
            this.txtHumidity.WaterMark = "eg. 20";
            this.txtHumidity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHumidity.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(6, 322);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(116, 19);
            this.metroLabel18.TabIndex = 11;
            this.metroLabel18.Text = "Wind Speed KM/h";
            // 
            // txtPrecipitation
            // 
            // 
            // 
            // 
            this.txtPrecipitation.CustomButton.Image = null;
            this.txtPrecipitation.CustomButton.Location = new System.Drawing.Point(313, 1);
            this.txtPrecipitation.CustomButton.Name = "";
            this.txtPrecipitation.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPrecipitation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecipitation.CustomButton.TabIndex = 1;
            this.txtPrecipitation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecipitation.CustomButton.UseSelectable = true;
            this.txtPrecipitation.CustomButton.Visible = false;
            this.txtPrecipitation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forecastBindingSource, "Precipitation", true));
            this.txtPrecipitation.Lines = new string[0];
            this.txtPrecipitation.Location = new System.Drawing.Point(5, 227);
            this.txtPrecipitation.MaxLength = 32767;
            this.txtPrecipitation.Name = "txtPrecipitation";
            this.txtPrecipitation.PasswordChar = '\0';
            this.txtPrecipitation.PromptText = "eg. 80";
            this.txtPrecipitation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecipitation.SelectedText = "";
            this.txtPrecipitation.SelectionLength = 0;
            this.txtPrecipitation.SelectionStart = 0;
            this.txtPrecipitation.ShortcutsEnabled = true;
            this.txtPrecipitation.Size = new System.Drawing.Size(341, 29);
            this.txtPrecipitation.TabIndex = 5;
            this.txtPrecipitation.UseSelectable = true;
            this.txtPrecipitation.WaterMark = "eg. 80";
            this.txtPrecipitation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecipitation.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(7, 263);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(76, 19);
            this.metroLabel17.TabIndex = 11;
            this.metroLabel17.Text = "Humidity %";
            // 
            // txtMaxTemp
            // 
            // 
            // 
            // 
            this.txtMaxTemp.CustomButton.Image = null;
            this.txtMaxTemp.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.txtMaxTemp.CustomButton.Name = "";
            this.txtMaxTemp.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtMaxTemp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaxTemp.CustomButton.TabIndex = 1;
            this.txtMaxTemp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaxTemp.CustomButton.UseSelectable = true;
            this.txtMaxTemp.CustomButton.Visible = false;
            this.txtMaxTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forecastBindingSource, "MaxTemp", true));
            this.txtMaxTemp.Lines = new string[0];
            this.txtMaxTemp.Location = new System.Drawing.Point(173, 162);
            this.txtMaxTemp.MaxLength = 32767;
            this.txtMaxTemp.Name = "txtMaxTemp";
            this.txtMaxTemp.PasswordChar = '\0';
            this.txtMaxTemp.PromptText = "eg. 25";
            this.txtMaxTemp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaxTemp.SelectedText = "";
            this.txtMaxTemp.SelectionLength = 0;
            this.txtMaxTemp.SelectionStart = 0;
            this.txtMaxTemp.ShortcutsEnabled = true;
            this.txtMaxTemp.Size = new System.Drawing.Size(174, 29);
            this.txtMaxTemp.TabIndex = 4;
            this.txtMaxTemp.UseSelectable = true;
            this.txtMaxTemp.WaterMark = "eg. 25";
            this.txtMaxTemp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaxTemp.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtMinTemp
            // 
            // 
            // 
            // 
            this.txtMinTemp.CustomButton.Image = null;
            this.txtMinTemp.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.txtMinTemp.CustomButton.Name = "";
            this.txtMinTemp.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtMinTemp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMinTemp.CustomButton.TabIndex = 1;
            this.txtMinTemp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMinTemp.CustomButton.UseSelectable = true;
            this.txtMinTemp.CustomButton.Visible = false;
            this.txtMinTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forecastBindingSource, "MinTemp", true));
            this.txtMinTemp.Lines = new string[0];
            this.txtMinTemp.Location = new System.Drawing.Point(6, 162);
            this.txtMinTemp.MaxLength = 32767;
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.PasswordChar = '\0';
            this.txtMinTemp.PromptText = "eg. 0";
            this.txtMinTemp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMinTemp.SelectedText = "";
            this.txtMinTemp.SelectionLength = 0;
            this.txtMinTemp.SelectionStart = 0;
            this.txtMinTemp.ShortcutsEnabled = true;
            this.txtMinTemp.Size = new System.Drawing.Size(157, 29);
            this.txtMinTemp.TabIndex = 3;
            this.txtMinTemp.UseSelectable = true;
            this.txtMinTemp.WaterMark = "eg. 0";
            this.txtMinTemp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMinTemp.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(176, 134);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(70, 19);
            this.metroLabel19.TabIndex = 11;
            this.metroLabel19.Text = "Max Temp";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(9, 201);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Precipitation";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(9, 134);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Min Temp";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Date";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 17);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(31, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "City";
            // 
            // gridPreviewForecast
            // 
            this.gridPreviewForecast.AllowUserToAddRows = false;
            this.gridPreviewForecast.AllowUserToDeleteRows = false;
            this.gridPreviewForecast.AllowUserToResizeRows = false;
            this.gridPreviewForecast.AutoGenerateColumns = false;
            this.gridPreviewForecast.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.gridPreviewForecast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPreviewForecast.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridPreviewForecast.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPreviewForecast.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridPreviewForecast.ColumnHeadersHeight = 24;
            this.gridPreviewForecast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.forecastDateDataGridViewTextBoxColumn1,
            this.minTempDataGridViewTextBoxColumn1,
            this.maxTempDataGridViewTextBoxColumn1,
            this.precipitationDataGridViewTextBoxColumn1,
            this.humidityDataGridViewTextBoxColumn1,
            this.windSpeedDataGridViewTextBoxColumn1,
            this.cityIdDataGridViewTextBoxColumn3,
            this.cityDataGridViewTextBoxColumn1});
            this.gridPreviewForecast.DataSource = this.forecastBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPreviewForecast.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridPreviewForecast.EnableHeadersVisualStyles = false;
            this.gridPreviewForecast.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridPreviewForecast.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPreviewForecast.Location = new System.Drawing.Point(400, 1);
            this.gridPreviewForecast.Name = "gridPreviewForecast";
            this.gridPreviewForecast.ReadOnly = true;
            this.gridPreviewForecast.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPreviewForecast.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridPreviewForecast.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPreviewForecast.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPreviewForecast.Size = new System.Drawing.Size(443, 438);
            this.gridPreviewForecast.TabIndex = 10;
            this.gridPreviewForecast.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPreviewForecast_CellContentClick);
            // 
            // forecastDateDataGridViewTextBoxColumn1
            // 
            this.forecastDateDataGridViewTextBoxColumn1.DataPropertyName = "ForecastDate";
            this.forecastDateDataGridViewTextBoxColumn1.HeaderText = "ForecastDate";
            this.forecastDateDataGridViewTextBoxColumn1.Name = "forecastDateDataGridViewTextBoxColumn1";
            this.forecastDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // minTempDataGridViewTextBoxColumn1
            // 
            this.minTempDataGridViewTextBoxColumn1.DataPropertyName = "MinTemp";
            this.minTempDataGridViewTextBoxColumn1.HeaderText = "Min Temp";
            this.minTempDataGridViewTextBoxColumn1.Name = "minTempDataGridViewTextBoxColumn1";
            this.minTempDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // maxTempDataGridViewTextBoxColumn1
            // 
            this.maxTempDataGridViewTextBoxColumn1.DataPropertyName = "MaxTemp";
            this.maxTempDataGridViewTextBoxColumn1.HeaderText = "Max Temp";
            this.maxTempDataGridViewTextBoxColumn1.Name = "maxTempDataGridViewTextBoxColumn1";
            this.maxTempDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // precipitationDataGridViewTextBoxColumn1
            // 
            this.precipitationDataGridViewTextBoxColumn1.DataPropertyName = "Precipitation";
            this.precipitationDataGridViewTextBoxColumn1.HeaderText = "Precipitation";
            this.precipitationDataGridViewTextBoxColumn1.Name = "precipitationDataGridViewTextBoxColumn1";
            this.precipitationDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // humidityDataGridViewTextBoxColumn1
            // 
            this.humidityDataGridViewTextBoxColumn1.DataPropertyName = "Humidity";
            this.humidityDataGridViewTextBoxColumn1.HeaderText = "Humidity";
            this.humidityDataGridViewTextBoxColumn1.Name = "humidityDataGridViewTextBoxColumn1";
            this.humidityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // windSpeedDataGridViewTextBoxColumn1
            // 
            this.windSpeedDataGridViewTextBoxColumn1.DataPropertyName = "WindSpeed";
            this.windSpeedDataGridViewTextBoxColumn1.HeaderText = "WindSpeed";
            this.windSpeedDataGridViewTextBoxColumn1.Name = "windSpeedDataGridViewTextBoxColumn1";
            this.windSpeedDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cityIdDataGridViewTextBoxColumn3
            // 
            this.cityIdDataGridViewTextBoxColumn3.DataPropertyName = "CityId";
            this.cityIdDataGridViewTextBoxColumn3.HeaderText = "CityId";
            this.cityIdDataGridViewTextBoxColumn3.Name = "cityIdDataGridViewTextBoxColumn3";
            this.cityIdDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn1
            // 
            this.cityDataGridViewTextBoxColumn1.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn1.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn1.Name = "cityDataGridViewTextBoxColumn1";
            this.cityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tabManageLocation
            // 
            this.tabManageLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.tabManageLocation.Controls.Add(this.lbValidator);
            this.tabManageLocation.Controls.Add(this.gridCityPreview);
            this.tabManageLocation.Controls.Add(this.btnDeleteCity);
            this.tabManageLocation.Controls.Add(this.btnUpdateCity);
            this.tabManageLocation.Controls.Add(this.btnAddCity);
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
            this.tabManageLocation.Size = new System.Drawing.Size(821, 441);
            this.tabManageLocation.TabIndex = 2;
            this.tabManageLocation.Text = "Manage Location   ";
            this.tabManageLocation.ToolTipText = "Manage Locations";
            this.tabManageLocation.VerticalScrollbarBarColor = true;
            this.tabManageLocation.VerticalScrollbarHighlightOnWheel = false;
            this.tabManageLocation.VerticalScrollbarSize = 10;
            // 
            // lbValidator
            // 
            this.lbValidator.AutoSize = true;
            this.lbValidator.Location = new System.Drawing.Point(4, 285);
            this.lbValidator.Name = "lbValidator";
            this.lbValidator.Size = new System.Drawing.Size(0, 0);
            this.lbValidator.TabIndex = 24;
            // 
            // gridCityPreview
            // 
            this.gridCityPreview.AllowUserToAddRows = false;
            this.gridCityPreview.AllowUserToDeleteRows = false;
            this.gridCityPreview.AllowUserToResizeRows = false;
            this.gridCityPreview.AutoGenerateColumns = false;
            this.gridCityPreview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.gridCityPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCityPreview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridCityPreview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCityPreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridCityPreview.ColumnHeadersHeight = 24;
            this.gridCityPreview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityIdDataGridViewTextBoxColumn2,
            this.cityNameDataGridViewTextBoxColumn,
            this.provinceIdDataGridViewTextBoxColumn,
            this.provinceDataGridViewTextBoxColumn});
            this.gridCityPreview.DataSource = this.cityBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCityPreview.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridCityPreview.EnableHeadersVisualStyles = false;
            this.gridCityPreview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridCityPreview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridCityPreview.Location = new System.Drawing.Point(401, 0);
            this.gridCityPreview.Name = "gridCityPreview";
            this.gridCityPreview.ReadOnly = true;
            this.gridCityPreview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCityPreview.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridCityPreview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridCityPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCityPreview.Size = new System.Drawing.Size(424, 438);
            this.gridCityPreview.TabIndex = 23;
            this.gridCityPreview.UseCustomBackColor = true;
            // 
            // cityIdDataGridViewTextBoxColumn2
            // 
            this.cityIdDataGridViewTextBoxColumn2.DataPropertyName = "CityId";
            this.cityIdDataGridViewTextBoxColumn2.HeaderText = "CityId";
            this.cityIdDataGridViewTextBoxColumn2.Name = "cityIdDataGridViewTextBoxColumn2";
            this.cityIdDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // cityNameDataGridViewTextBoxColumn
            // 
            this.cityNameDataGridViewTextBoxColumn.DataPropertyName = "CityName";
            this.cityNameDataGridViewTextBoxColumn.HeaderText = "CityName";
            this.cityNameDataGridViewTextBoxColumn.Name = "cityNameDataGridViewTextBoxColumn";
            this.cityNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // provinceIdDataGridViewTextBoxColumn
            // 
            this.provinceIdDataGridViewTextBoxColumn.DataPropertyName = "ProvinceId";
            this.provinceIdDataGridViewTextBoxColumn.HeaderText = "ProvinceId";
            this.provinceIdDataGridViewTextBoxColumn.Name = "provinceIdDataGridViewTextBoxColumn";
            this.provinceIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // provinceDataGridViewTextBoxColumn
            // 
            this.provinceDataGridViewTextBoxColumn.DataPropertyName = "Province";
            this.provinceDataGridViewTextBoxColumn.HeaderText = "Province";
            this.provinceDataGridViewTextBoxColumn.Name = "provinceDataGridViewTextBoxColumn";
            this.provinceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnDeleteCity
            // 
            this.btnDeleteCity.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteCity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCity.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnDeleteCity.FlatAppearance.BorderSize = 0;
            this.btnDeleteCity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCity.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnDeleteCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.btnDeleteCity.Location = new System.Drawing.Point(230, 400);
            this.btnDeleteCity.Name = "btnDeleteCity";
            this.btnDeleteCity.Size = new System.Drawing.Size(114, 38);
            this.btnDeleteCity.TabIndex = 18;
            this.btnDeleteCity.Text = "DELETE";
            this.btnDeleteCity.UseVisualStyleBackColor = false;
            this.btnDeleteCity.Click += new System.EventHandler(this.btnDeleteCity_Click);
            // 
            // btnUpdateCity
            // 
            this.btnUpdateCity.BackColor = System.Drawing.Color.Gold;
            this.btnUpdateCity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateCity.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnUpdateCity.FlatAppearance.BorderSize = 0;
            this.btnUpdateCity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnUpdateCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCity.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnUpdateCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(118)))));
            this.btnUpdateCity.Location = new System.Drawing.Point(117, 400);
            this.btnUpdateCity.Name = "btnUpdateCity";
            this.btnUpdateCity.Size = new System.Drawing.Size(107, 38);
            this.btnUpdateCity.TabIndex = 19;
            this.btnUpdateCity.Text = "UPDATE";
            this.btnUpdateCity.UseVisualStyleBackColor = false;
            this.btnUpdateCity.Click += new System.EventHandler(this.btnUpdateCity_Click);
            // 
            // btnAddCity
            // 
            this.btnAddCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(195)))), ((int)(((byte)(175)))));
            this.btnAddCity.Cursor = System.Windows.Forms.Cursors.No;
            this.btnAddCity.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnAddCity.FlatAppearance.BorderSize = 0;
            this.btnAddCity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnAddCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCity.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAddCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.btnAddCity.Location = new System.Drawing.Point(3, 400);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(108, 38);
            this.btnAddCity.TabIndex = 20;
            this.btnAddCity.Text = "ADD";
            this.btnAddCity.UseVisualStyleBackColor = false;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // txtSearchProvince
            // 
            // 
            // 
            // 
            this.txtSearchProvince.CustomButton.Image = null;
            this.txtSearchProvince.CustomButton.Location = new System.Drawing.Point(312, 1);
            this.txtSearchProvince.CustomButton.Name = "";
            this.txtSearchProvince.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtSearchProvince.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchProvince.CustomButton.TabIndex = 1;
            this.txtSearchProvince.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchProvince.CustomButton.UseSelectable = true;
            this.txtSearchProvince.CustomButton.Visible = false;
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
            this.txtSearchProvince.Size = new System.Drawing.Size(340, 29);
            this.txtSearchProvince.TabIndex = 17;
            this.txtSearchProvince.UseSelectable = true;
            this.txtSearchProvince.WaterMark = "eg. Eastern Cape";
            this.txtSearchProvince.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchProvince.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tabManageUsers.Size = new System.Drawing.Size(821, 441);
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAllUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridAllUsers.ColumnHeadersHeight = 24;
            this.gridAllUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Password,
            this.HomeTown,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.homeTownDataGridViewTextBoxColumn});
            this.gridAllUsers.DataSource = this.userBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAllUsers.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridAllUsers.EnableHeadersVisualStyles = false;
            this.gridAllUsers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridAllUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridAllUsers.Location = new System.Drawing.Point(399, 0);
            this.gridAllUsers.Name = "gridAllUsers";
            this.gridAllUsers.ReadOnly = true;
            this.gridAllUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAllUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(185)))), ((int)(((byte)(239)))));
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.btnRefresh.Location = new System.Drawing.Point(721, 38);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(159, 33);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // provinceBindingSource
            // 
            this.provinceBindingSource.DataSource = typeof(RainCheckUI.Model.Province);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HomeTown";
            this.dataGridViewTextBoxColumn1.HeaderText = "Home Town";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // iconStrip
            // 
            this.iconStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(118)))));
            this.iconStrip.Controls.Add(this.btnDashboard);
            this.iconStrip.Controls.Add(this.btnToggleMenu);
            this.iconStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconStrip.Location = new System.Drawing.Point(0, 0);
            this.iconStrip.Name = "iconStrip";
            this.iconStrip.Size = new System.Drawing.Size(49, 561);
            this.iconStrip.TabIndex = 17;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackgroundImage = global::RainCheckUI.Properties.Resources.previous;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnDashboard.Location = new System.Drawing.Point(8, 511);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10);
            this.btnDashboard.Size = new System.Drawing.Size(33, 32);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.UseVisualStyleBackColor = true;
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
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(811, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 32);
            this.btnMinimize.TabIndex = 18;
            this.btnMinimize.Text = "➖";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Location = new System.Drawing.Point(855, 0);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(45, 32);
            this.btnQuit.TabIndex = 19;
            this.btnQuit.Text = "✖";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.panel1.Location = new System.Drawing.Point(-16, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 2);
            this.panel1.TabIndex = 20;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 561);
            this.Controls.Add(this.iconStrip);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.dashboardTabControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load_1);
            this.dashboardTabControl.ResumeLayout(false);
            this.tabShowAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastBindingSource)).EndInit();
            this.tabManageForecasts.ResumeLayout(false);
            this.tabManageForecasts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPreviewForecast)).EndInit();
            this.tabManageLocation.ResumeLayout(false);
            this.tabManageLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCityPreview)).EndInit();
            this.tabManageUsers.ResumeLayout(false);
            this.tabManageUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            this.panelAddForecast.ResumeLayout(false);
            this.panelAddForecast.PerformLayout();
            this.metroContextMenu1.ResumeLayout(false);
            this.iconStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl dashboardTabControl;
        private MetroFramework.Controls.MetroTabPage tabShowAll;
        private MetroFramework.Controls.MetroTabPage tabManageForecasts;
        private MetroFramework.Controls.MetroTabPage tabManageLocation;
        private MetroFramework.Controls.MetroTabPage tabManageUsers;
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
        private System.Windows.Forms.Button btnDeleteCity;
        private System.Windows.Forms.Button btnUpdateCity;
        private System.Windows.Forms.Button btnAddCity;
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
        private MetroFramework.Controls.MetroLabel lbValidator;
        private System.Windows.Forms.Button btnDeleteForecast;
        private System.Windows.Forms.Button btnUpdateForecast;
        private System.Windows.Forms.Button btnNewForecast;
        private MetroFramework.Controls.MetroTextBox txtMinTemp;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroGrid gridPreviewForecast;
        private System.Windows.Forms.DataGridViewTextBoxColumn forecastDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn minTempDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxTempDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn precipitationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn humidityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn windSpeedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityIdDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn1;
        private MetroFramework.Controls.MetroDateTime forecastDate;
        private MetroFramework.Controls.MetroComboBox cmbCityForecast;
        private MetroFramework.Controls.MetroTextBox txtWindSpeed;
        private MetroFramework.Controls.MetroTextBox txtHumidity;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroTextBox txtPrecipitation;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox txtMaxTemp;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Panel iconStrip;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnToggleMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel panel1;
    }
}

