using RainCheckUI.Helpers;
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
        //Prep-up the search textbox for autocomplete
        public void prepSearch()
        {
            txtGlobalSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtGlobalSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection suggestions = new AutoCompleteStringCollection();
            string[] cityNames = _context.Cities.Distinct().Select(c => c.CityName).ToArray();


            foreach (var item in cityNames)
            {
                suggestions.Add(item);
            }
            txtGlobalSearch.AutoCompleteCustomSource = suggestions;
        }
        public void populateWatchList()
        {
            foreach (var city in _context.Cities)
            {
                cities.Add(city.CityName);
            }

        }
        private void populateMainCard()
        {
            User activeUser = _context.Users.Where(user => user.isAdmin == false).FirstOrDefault();
            Forecast homeForecast = _context.Forecasts.Where(f => f.CityId == activeUser.CityId).FirstOrDefault();
            City userCity = _context.Cities.FirstOrDefault(c => c.CityId == activeUser.CityId);
            Province userProvice = _context.Provinces.Where(p => p.ProvinceId == userCity.ProvinceId).FirstOrDefault();

            string userProvinceShort = StringHelper.Initialize(userCity.Province.ProvinceName);
            string userCityStr = StringHelper.FirstCharToUpper(userCity.CityName);

            Func<string> speedUnit = () => getUnits() == null ? "km/h" : getUnits();

            homeTemp.Text = homeForecast.MaxTemp.ToString();
            lbHomeTown.Text = $"{userCityStr}, {userProvinceShort}";
            homeHumidity.Text = $"Humidity {homeForecast.Humidity}%";
            homeLastUpdated.Text = $"Last updated {homeForecast.ForecastDate.ToShortTimeString()}";
            homePrecip.Text = $"Precip {homeForecast.Precipitation}%";
            homeWindSpeed.Text = $"Wind {homeForecast.WindSpeed} {speedUnit()}";
            homeWeatherIcon.Image = GetRandomIcon();

        }
        //Implement unit switching logic
        private string getUnits()
        {
            return null;
        }

        //Determines which icon to use by checking avarage tempetures and precipation
        //Could save my energy if I just save the summary on db.
        public Image GetRandomIcon()
        {
            Random random = new Random();
            int chance = random.Next(1, 4);

            //Precipitation will take precedence
            switch (chance)
            {
                case 1:
                    return Resources.zcloud;
                case 2:
                    return Resources.sunny;
                case 3:
                    return Resources.rain;
                case 4:
                    return Resources.zcloud;
                default:
                    return Resources.cloud;
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
                    Icon = GetRandomIcon()
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
            populateMainCard();
            prepSearch();
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
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to quit application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbcurrTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            using(var dash = new FormDashboard())
            {
                dash.ShowDialog();
            }
            this.Hide();
        }
    }
}
