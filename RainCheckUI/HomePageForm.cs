using RainCheckUI.Model;
using System;
using System.Linq;

namespace RainCheckUI
{
    public partial class HomePageForm : MetroFramework.Forms.MetroForm
    {
        public HomePageForm()
        {
            InitializeComponent();
        }
        private ModelContext _context = new ModelContext();

        public void spawnCards()
        {
            //int COUNT = 1;
            Forecast[] forecasts = _context.Forecasts.ToArray();

            for (int i = 0; i < 4; i++)
            {
                Forecast forecast = forecasts[i];
                City forecastCity = _context.Cities.Find(forecast.CityId);

                //Populate card with indexed data, configure the proceed to add to parent list
                WeatherCardControl tempCard = new WeatherCardControl()
                {
                    CityName = forecastCity.CityName,
                    MinTemp = forecast.MinTemp,
                    MaxTemp = forecast.MaxTemp,
                    ForecastDate = forecast.ForecastDate,
                };
                //Card width
                tempCard.Width = (cardList.Width / 4) - 4;
                cardList.Controls.Add(tempCard);

            }
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {
            spawnCards();
        }
    }
}
