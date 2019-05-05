﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RainCheckUI
{
    public partial class WeatherCardControl : UserControl
    {
        private string _cityName;
        private double _minTemp;
        private double _maxTemp;
        private DateTime _forecastDate;
        private Image _image;

        #region Properties
        [Category("Custom Properties")]
        public string CityName
        {
            get { return _cityName; }
            set { _cityName = value; lbCityName.Text = value.ToUpper(); }
        }
        [Category("Custom Properties")]
        public double MinTemp
        {
            get { return _minTemp; }
            set { _minTemp = value; lbMinTemp.Text = Convert.ToString(value);  }
        }
        [Category("Custom Properties")]
        public double MaxTemp
        {
            get { return _maxTemp; }
            set { _maxTemp = value; lbMaxTemp.Text = value.ToString(); }
        }
        [Category("Custom Properties")]
        public DateTime ForecastDate
        {
            get { return _forecastDate; }
            set { _forecastDate = value; lbDate.Text = value.ToString();  }
        }

        public Image Icon
        {
            get { return _image;  }
            set { _image = value; picIcon.Image = value; }
        }

        #endregion

        public WeatherCardControl()
        {
            InitializeComponent();
        }
    }
}
