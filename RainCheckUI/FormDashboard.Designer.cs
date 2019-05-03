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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
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
            this.cityIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbProvince = new MetroFramework.Controls.MetroComboBox();
            this.provinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtCityName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.tabManageUsers = new MetroFramework.Controls.MetroTabPage();
            this.cmbHomeTowns = new MetroFramework.Controls.MetroComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkMakeAdmin = new MetroFramework.Controls.MetroCheckBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.gridAllUsers = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeTown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeTownDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.tabShowAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastBindingSource)).BeginInit();
            this.tabManageForecasts.SuspendLayout();
            this.panelAddForecast.SuspendLayout();
            this.panelUpdateForecast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridForecastToUpdatePreview)).BeginInit();
            this.panelRemoveForecast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRemoveForecastPreview)).BeginInit();
            this.tabManageLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCityPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).BeginInit();
            this.tabManageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllUsers)).BeginInit();
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
            this.metroTabControl1.SelectedIndex = 3;
            this.metroTabControl1.Size = new System.Drawing.Size(753, 363);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabShowAll
            // 
            this.tabShowAll.Controls.Add(this.gridViewAll);
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
            this.gridViewAll.Size = new System.Drawing.Size(739, 318);
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
            this.tabManageForecasts.Text = "Manage Forecasts       ";
            this.tabManageForecasts.ToolTipText = "Manage forecast data";
            this.tabManageForecasts.VerticalScrollbarBarColor = true;
            this.tabManageForecasts.VerticalScrollbarHighlightOnWheel = false;
            this.tabManageForecasts.VerticalScrollbarSize = 10;
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
            this.panelAddForecast.Location = new System.Drawing.Point(117, 3);
            this.panelAddForecast.Name = "panelAddForecast";
            this.panelAddForecast.Size = new System.Drawing.Size(525, 317);
            this.panelAddForecast.TabIndex = 12;
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
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(4, 29);
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
            this.cmdAddForecastCity.FormattingEnabled = true;
            this.cmdAddForecastCity.ItemHeight = 23;
            this.cmdAddForecastCity.Location = new System.Drawing.Point(21, 38);
            this.cmdAddForecastCity.Name = "cmdAddForecastCity";
            this.cmdAddForecastCity.Size = new System.Drawing.Size(200, 29);
            this.cmdAddForecastCity.TabIndex = 3;
            this.cmdAddForecastCity.UseSelectable = true;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridForecastToUpdatePreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridForecastToUpdatePreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridForecastToUpdatePreview.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridForecastToUpdatePreview.EnableHeadersVisualStyles = false;
            this.gridForecastToUpdatePreview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridForecastToUpdatePreview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridForecastToUpdatePreview.Location = new System.Drawing.Point(24, 98);
            this.gridForecastToUpdatePreview.Name = "gridForecastToUpdatePreview";
            this.gridForecastToUpdatePreview.ReadOnly = true;
            this.gridForecastToUpdatePreview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridForecastToUpdatePreview.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            // tileDeleteForecast
            // 
            this.tileDeleteForecast.ActiveControl = null;
            this.tileDeleteForecast.BackColor = System.Drawing.Color.White;
            this.tileDeleteForecast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileDeleteForecast.Location = new System.Drawing.Point(3, 208);
            this.tileDeleteForecast.Name = "tileDeleteForecast";
            this.tileDeleteForecast.Size = new System.Drawing.Size(113, 107);
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
            this.tileUpdateForecast.Size = new System.Drawing.Size(113, 101);
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
            this.tileAddForecast.Size = new System.Drawing.Size(113, 107);
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
            this.tabManageLocation.Controls.Add(this.gridCityPreview);
            this.tabManageLocation.Controls.Add(this.cmbProvince);
            this.tabManageLocation.Controls.Add(this.button2);
            this.tabManageLocation.Controls.Add(this.button3);
            this.tabManageLocation.Controls.Add(this.button4);
            this.tabManageLocation.Controls.Add(this.txtCityName);
            this.tabManageLocation.Controls.Add(this.metroLabel14);
            this.tabManageLocation.Controls.Add(this.metroLabel15);
            this.tabManageLocation.Controls.Add(this.metroLabel16);
            this.tabManageLocation.HorizontalScrollbarBarColor = true;
            this.tabManageLocation.HorizontalScrollbarHighlightOnWheel = false;
            this.tabManageLocation.HorizontalScrollbarSize = 10;
            this.tabManageLocation.Location = new System.Drawing.Point(4, 38);
            this.tabManageLocation.Name = "tabManageLocation";
            this.tabManageLocation.Size = new System.Drawing.Size(745, 321);
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
            this.gridCityPreview.AutoGenerateColumns = false;
            this.gridCityPreview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.gridCityPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCityPreview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridCityPreview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCityPreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridCityPreview.ColumnHeadersHeight = 24;
            this.gridCityPreview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityIdDataGridViewTextBoxColumn2,
            this.cityNameDataGridViewTextBoxColumn,
            this.provinceIdDataGridViewTextBoxColumn,
            this.provinceDataGridViewTextBoxColumn});
            this.gridCityPreview.DataSource = this.cityBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCityPreview.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridCityPreview.EnableHeadersVisualStyles = false;
            this.gridCityPreview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridCityPreview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridCityPreview.Location = new System.Drawing.Point(401, 0);
            this.gridCityPreview.Name = "gridCityPreview";
            this.gridCityPreview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCityPreview.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridCityPreview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridCityPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCityPreview.Size = new System.Drawing.Size(348, 318);
            this.gridCityPreview.TabIndex = 23;
            // 
            // cityIdDataGridViewTextBoxColumn2
            // 
            this.cityIdDataGridViewTextBoxColumn2.DataPropertyName = "CityId";
            this.cityIdDataGridViewTextBoxColumn2.HeaderText = "City Id";
            this.cityIdDataGridViewTextBoxColumn2.Name = "cityIdDataGridViewTextBoxColumn2";
            // 
            // cityNameDataGridViewTextBoxColumn
            // 
            this.cityNameDataGridViewTextBoxColumn.DataPropertyName = "CityName";
            this.cityNameDataGridViewTextBoxColumn.HeaderText = "City Name";
            this.cityNameDataGridViewTextBoxColumn.Name = "cityNameDataGridViewTextBoxColumn";
            // 
            // provinceIdDataGridViewTextBoxColumn
            // 
            this.provinceIdDataGridViewTextBoxColumn.DataPropertyName = "ProvinceId";
            this.provinceIdDataGridViewTextBoxColumn.HeaderText = "Province Id";
            this.provinceIdDataGridViewTextBoxColumn.Name = "provinceIdDataGridViewTextBoxColumn";
            // 
            // provinceDataGridViewTextBoxColumn
            // 
            this.provinceDataGridViewTextBoxColumn.DataPropertyName = "Province";
            this.provinceDataGridViewTextBoxColumn.HeaderText = "Province";
            this.provinceDataGridViewTextBoxColumn.Name = "provinceDataGridViewTextBoxColumn";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(RainCheckUI.Model.City);
            // 
            // cmbProvince
            // 
            this.cmbProvince.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cityBindingSource, "ProvinceId", true));
            this.cmbProvince.DataSource = this.provinceBindingSource;
            this.cmbProvince.DisplayMember = "HomeTown";
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.ItemHeight = 23;
            this.cmbProvince.Location = new System.Drawing.Point(3, 129);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(341, 29);
            this.cmbProvince.TabIndex = 22;
            this.cmbProvince.UseSelectable = true;
            this.cmbProvince.ValueMember = "HomeTown";
            // 
            // provinceBindingSource
            // 
            this.provinceBindingSource.DataSource = typeof(RainCheckUI.Model.Province);
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
            this.button2.Location = new System.Drawing.Point(230, 277);
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
            this.button3.Location = new System.Drawing.Point(117, 277);
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
            this.button4.Location = new System.Drawing.Point(3, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 38);
            this.button4.TabIndex = 20;
            this.button4.Text = "Add User";
            this.button4.UseVisualStyleBackColor = false;
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
            this.txtCityName.Location = new System.Drawing.Point(3, 59);
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
            this.metroLabel14.Location = new System.Drawing.Point(4, 104);
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
            this.metroLabel16.Location = new System.Drawing.Point(3, 34);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(71, 19);
            this.metroLabel16.TabIndex = 15;
            this.metroLabel16.Text = "City Name";
            // 
            // tabManageUsers
            // 
            this.tabManageUsers.Controls.Add(this.cmbHomeTowns);
            this.tabManageUsers.Controls.Add(this.chkMakeAdmin);
            this.tabManageUsers.Controls.Add(this.btnDeleteUser);
            this.tabManageUsers.Controls.Add(this.btnUpdateUser);
            this.tabManageUsers.Controls.Add(this.btnAddUser);
            this.tabManageUsers.Controls.Add(this.txtPassword);
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
            this.tabManageUsers.Size = new System.Drawing.Size(745, 321);
            this.tabManageUsers.TabIndex = 3;
            this.tabManageUsers.Text = "Manage Users";
            this.tabManageUsers.ToolTipText = "Manage registered users";
            this.tabManageUsers.VerticalScrollbarBarColor = true;
            this.tabManageUsers.VerticalScrollbarHighlightOnWheel = false;
            this.tabManageUsers.VerticalScrollbarSize = 10;
            // 
            // cmbHomeTowns
            // 
            this.cmbHomeTowns.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userBindingSource, "CityId", true));
            this.cmbHomeTowns.DataSource = this.userBindingSource;
            this.cmbHomeTowns.DisplayMember = "HomeTown";
            this.cmbHomeTowns.FormattingEnabled = true;
            this.cmbHomeTowns.ItemHeight = 23;
            this.cmbHomeTowns.Location = new System.Drawing.Point(3, 187);
            this.cmbHomeTowns.Name = "cmbHomeTowns";
            this.cmbHomeTowns.Size = new System.Drawing.Size(341, 29);
            this.cmbHomeTowns.TabIndex = 11;
            this.cmbHomeTowns.UseSelectable = true;
            this.cmbHomeTowns.ValueMember = "CityId";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(RainCheckUI.Model.User);
            // 
            // chkMakeAdmin
            // 
            this.chkMakeAdmin.AutoSize = true;
            this.chkMakeAdmin.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.userBindingSource, "isAdmin", true));
            this.chkMakeAdmin.Location = new System.Drawing.Point(4, 232);
            this.chkMakeAdmin.Name = "chkMakeAdmin";
            this.chkMakeAdmin.Size = new System.Drawing.Size(59, 15);
            this.chkMakeAdmin.TabIndex = 10;
            this.chkMakeAdmin.Text = "Admin";
            this.chkMakeAdmin.UseSelectable = true;
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
            this.btnDeleteUser.Location = new System.Drawing.Point(230, 276);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(114, 38);
            this.btnDeleteUser.TabIndex = 9;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
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
            this.btnUpdateUser.Location = new System.Drawing.Point(117, 276);
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
            this.btnAddUser.Location = new System.Drawing.Point(3, 276);
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
            this.txtPassword.Location = new System.Drawing.Point(3, 118);
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
            this.txtUsername.Location = new System.Drawing.Point(3, 49);
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
            this.metroLabel13.Location = new System.Drawing.Point(3, 161);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(78, 19);
            this.metroLabel13.TabIndex = 7;
            this.metroLabel13.Text = "Home Town";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(3, 93);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(63, 19);
            this.metroLabel12.TabIndex = 7;
            this.metroLabel12.Text = "Password";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(3, 24);
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAllUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.gridAllUsers.ColumnHeadersHeight = 24;
            this.gridAllUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Password,
            this.HomeTown,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.homeTownDataGridViewTextBoxColumn});
            this.gridAllUsers.DataSource = this.userBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAllUsers.DefaultCellStyle = dataGridViewCellStyle14;
            this.gridAllUsers.EnableHeadersVisualStyles = false;
            this.gridAllUsers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridAllUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridAllUsers.Location = new System.Drawing.Point(399, 0);
            this.gridAllUsers.Name = "gridAllUsers";
            this.gridAllUsers.ReadOnly = true;
            this.gridAllUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAllUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.gridAllUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridAllUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAllUsers.Size = new System.Drawing.Size(342, 314);
            this.gridAllUsers.TabIndex = 2;
            this.gridAllUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAllUsers_CellContentClick);
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
            this.btnRefresh.Location = new System.Drawing.Point(163, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 33);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RainCheckUI.Properties.Resources.BLURandrew_ruiz_1287537_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "FormDashboard";
            this.Text = "Dashboard";
            this.metroTabControl1.ResumeLayout(false);
            this.tabShowAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastBindingSource)).EndInit();
            this.tabManageForecasts.ResumeLayout(false);
            this.panelAddForecast.ResumeLayout(false);
            this.panelAddForecast.PerformLayout();
            this.panelUpdateForecast.ResumeLayout(false);
            this.panelUpdateForecast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridForecastToUpdatePreview)).EndInit();
            this.panelRemoveForecast.ResumeLayout(false);
            this.panelRemoveForecast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRemoveForecastPreview)).EndInit();
            this.tabManageLocation.ResumeLayout(false);
            this.tabManageLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCityPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).EndInit();
            this.tabManageUsers.ResumeLayout(false);
            this.tabManageUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllUsers)).EndInit();
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
        private System.Windows.Forms.Button btnAddForecast;
        private MetroFramework.Controls.MetroComboBox cmdAddForecastCity;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
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
        private MetroFramework.Controls.MetroComboBox cmbHomeTowns;
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
        private MetroFramework.Controls.MetroComboBox cmbProvince;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cityIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeTown;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeTownDataGridViewTextBoxColumn;
    }
}

