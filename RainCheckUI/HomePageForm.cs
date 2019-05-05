using RainCheckUI.Model;
using RainCheckUI.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RainCheckUI
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }
        private ModelContext _context = new ModelContext();

        List<string> watchList = new List<string>();
        ISet<string> cities = new SortedSet<string>();

        public void populateWatchList()
        {
            foreach (var city in _context.Cities)
            {
                cities.Add(city.CityName);
            }

        }

        public void spawnCards()
        {
            //int COUNT = 1;
            //Forecast data source
            //Changed forecast datasource to watch if it's not empty
            Forecast[] forecasts = _context.Forecasts
                                   .OrderByDescending(f => f.ForecastDate)
                                   .ToArray();
            //if watchlsit can
            //if (forecasts.Length >= 3 && watchList.Count >= 1)
            //{
            //    List<Forecast> toWatch = new List<Forecast>();

            //    foreach (var item in watchList)
            //    {
            //        toWatch.Add(forecasts.Where(f => f.City.CityName == item).FirstOrDefault());
            //    }
            //    forecasts = toWatch.ToArray();
            //}
            //Determines which to use by checking avarage tempetures and precipation
            Func<Forecast, Image> GetIcon = (obj) =>
            {
                string summary = "";

                if (obj.MaxTemp < 15)
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
                tempCard.Width = (cardList.Width / 4) - 12;
                tempCard.Height = (cardList.Height) - 8;
                tempCard.BackColor = Color.WhiteSmoke;
                cardList.Controls.Add(tempCard);

            }
        }
        
        private void HomePageForm_Load(object sender, EventArgs e)
        {
            spawnCards();
            populateWatchList();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show login screen
        }

        private void chklistCityWatch_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
        {
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //string output = "";
            //foreach (var item in chklistCityWatch.CheckedItems)
            //{
            //    //string cityName = chklistCityWatch.Items.AsQueryable;

            //    output += item;
            //    watchList.Add(item.ToString());
            //    //Refresh page
            //    HomePageForm_Load(sender, e);
            //}
            //lbWatchlist.Text = output;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if(MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to quit application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
