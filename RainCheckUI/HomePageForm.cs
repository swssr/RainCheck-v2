using RainCheckUI.Model;
using RainCheckUI.Properties;
using System;
using System.Drawing;
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
            //Forecast data source
            Forecast[] forecasts = _context.Forecasts
                                   .OrderByDescending(f => f.ForecastDate)
                                   .ToArray();
            //Determines which to use by checking avarage tempetures and precipation
            Func<Forecast, Image> GetIcon = (obj) =>
            {
                string summary = "";
                
                if(obj.MaxTemp < 15)
                {
                    summary = "cloudy";
                }
                //Handle all weather cases
                switch (summary)
                {
                    case "hot":
                        return Resources.flash;
                    default: return Resources.cloud;
                }
            };
            //Clear out the flow layout before adding anything
            if (cardList.Controls.Count > 0)
            {
                cardList.Controls.Clear();
            }
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
                    Icon = GetIcon(forecast)
                };
                //Card width and height
                tempCard.Width = (cardList.Width / 4) - 10;
                tempCard.Height = (cardList.Height / 2) - 8;
                tempCard.BackColor = Color.WhiteSmoke;
                cardList.Controls.Add(tempCard);

            }
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {
            spawnCards();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show login screen
        }
    }
}
