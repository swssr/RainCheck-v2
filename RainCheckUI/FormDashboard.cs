using MetroFramework;
using RainCheckUI.Model;
using RainCheckUI.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace RainCheckUI
{
    public partial class FormDashboard : Form
    {
        //Application context init.
        ModelContext _context = new ModelContext();

        //On form contruction perform the following, binding sources

        public FormDashboard()
        {
            InitializeComponent();

            bindStuff();
            isValidLocation();

        }


        #region Helper methods

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            using (var db = new ModelContext())
            {

                userBindingSource.DataSource = db.Users.ToList();
                cityBindingSource.DataSource = db.Cities.ToList();
                forecastBindingSource.DataSource = db.Forecasts.ToList();


                cmdAddForecastCity.DataSource = db.Cities.ToArray();
                cmdAddForecastCity.DisplayMember = "CityName";

                lbValidator.Text = "";

            }

        }


        public void bindStuff()
        {
            //Auto-complete services
            AutoCompleteService acService = new AutoCompleteService();
            acService.ProvinceAutoComplete(txtSearchProvince);
            acService.CityAutoComplete(txtSearchHomeTown);


            userBindingSource.DataSource = _context.Users.ToList();
            cityBindingSource.DataSource = _context.Cities.ToList();
            forecastBindingSource.DataSource = _context.Forecasts.ToList();
        }

        private bool isValidLocation()
        {
            string CityName = (txtCityName.Text).ToLower();
            string Province = (txtSearchProvince.Text).ToLower();
            Province province = _context.Provinces.Where(p => p.ProvinceName == Province).FirstOrDefault();

            Predicate<string> isCityIndexed = (cityStr) => _context.Cities
                                                      .Where(c => c.CityName == cityStr)
                                                      .Any();
            Predicate<string> validInput = str => !isCityIndexed(str) && province != null;

            if (CityName != "" && Province != "")
            {

                if (validInput(CityName))
                {
                    lbValidator.Text = $"Hooray 🎉🎉🎉!! Data updated successfully!";
                    return true;
                }
                else if (isCityIndexed(CityName))
                {
                    lbValidator.Text = "City already exists.";
                    return false;
                }

                if (province == null)
                {
                    lbValidator.Text = "Please enter valid Province";
                    return false;

                }
            }

            return false;
        }

        public void RefreshForm(object sender, EventArgs e) => FormDashboard_Load(sender, e);

        #endregion

        #region User event handling.

        private void gridAllUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            User user = userBindingSource.Current as User;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Add clicked");
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            using (var db = new ModelContext())
            {
                User user = userBindingSource.Current as User;

                if (MetroMessageBox.Show(this, $"Confirm to delete this user: {user.Username}", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (user != null)
                    {
                        User userToDelete = db.Users.Find(user.Username);
                        db.Users.Remove(userToDelete);
                        db.SaveChanges();

                        MetroMessageBox.Show(this, "User deleted successfully");
                        userBindingSource.RemoveCurrent();
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FormDashboard_Load(sender, e);
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            string strCityName = (txtCityName.Text).ToLower();
            string strProvince = (txtSearchProvince.Text).ToLower();

            Province province = _context.Provinces.Where(p => p.ProvinceName == strProvince).FirstOrDefault();

            Predicate<string> isCityIndexed = (cityStr) => _context.Cities
                                                      .Where(c => c.CityName == cityStr)
                                                      .Any();
            //Adding new city to db
            if (isValidLocation() &&
                    MessageBox.Show(this, $"Clicking yes will add {strCityName.ToUpper()} to the database, Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    Province cityProvince = _context.Provinces.Find(province.ProvinceId);
                    City city = new City() { CityName = strCityName, Province = cityProvince, ProvinceId = cityProvince.ProvinceId };
                    _context.Cities.Add(city);
                    _context.SaveChanges();

                    RefreshForm(sender, e);
                }
                catch (Exception ex)
                {

                    lbValidator.Text = $"Something went wrong. \n {ex}";
                }

            }

            if (strCityName == "" || strProvince == "")
            {
                lbValidator.Text = "Fill in the empty field";
            }
        }
        //TODO: fix this.
        private void btnUpdateCity_Click(object sender, EventArgs e)
        {
            string strCityName = (txtCityName.Text).ToLower();
            string strProvince = (txtSearchProvince.Text).ToLower();

            Province province = _context.Provinces.Where(p => p.ProvinceName == strProvince).FirstOrDefault();
            var cityToUpdate = _context.Cities.Where(c => c.CityName == strCityName);

            if (cityToUpdate.Any() == true &&
                    MessageBox.Show(this, $"Clicking yes will update {strCityName.ToUpper()}, Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //Update city
                try
                {
                    Province cityProvince = _context.Provinces.Find(province.ProvinceId);
                    City city = cityToUpdate.FirstOrDefault();
                    _context.Cities.Find(city);
                    _context.SaveChanges();

                    RefreshForm(sender, e);
                }
                catch (Exception ex)
                {

                    lbValidator.Text = $"Something went wrong. \n {ex}";
                }

            }

        }

        private void btnDeleteCity_Click(object sender, EventArgs e)
        {
            string strCityName = (txtCityName.Text).ToLower();
            string strProvince = (txtSearchProvince.Text).ToLower();
            var cityToDelete = _context.Cities.Where(c => c.CityName == strCityName);
            Province province = _context.Provinces.Where(p => p.ProvinceName == strProvince).FirstOrDefault();

            Predicate<string> isCityIndexed = (cityStr) => _context.Cities
                                                      .Where(c => c.CityName == cityStr)
                                                      .Any();
            //Adding new city to db
            if (cityToDelete.Any() == true &&
                    MessageBox.Show(this, $"Clicking yes Remove add {strCityName.ToUpper()} to the database, Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    Province cityProvince = _context.Provinces.Find(province.ProvinceId);
                    City city = cityToDelete.FirstOrDefault();
                    _context.Cities.Remove(city);
                    _context.SaveChanges();

                    RefreshForm(sender, e);
                }
                catch (Exception ex)
                {

                    lbValidator.Text = $"Something went wrong. \n {ex}";
                }

            }

            if (strCityName == "" || strProvince == "")
            {
                lbValidator.Text = "Fill in the empty field";
            }
        }

        #endregion

        private void gridPreviewForecast_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Forecast selectedForecast = forecastBindingSource.Current as Forecast;
            txtCityName.Text = _context.Cities.Where(c => c.CityId == selectedForecast.CityId)
                                .Select(city => city.CityName)
                                .FirstOrDefault();

        }

        private void btnNewForecast_Click(object sender, EventArgs e)
        {
            string output = "";

            Forecast forecastBound = forecastBindingSource.Current as Forecast;
            //Minimum req to pass check: City or Date should differ

            Func<Forecast, bool> isDuplicate = (obj) =>
            {
                if(_context.Forecasts.Where(f => f.CityId == obj.CityId && f.ForecastDate == obj.ForecastDate).Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            if (!isDuplicate(forecastBound))
            {
                try
                {
                    City forecastCity = _context.Cities.Find(forecastBound.City.CityId);
                    Forecast forecastToAdd = new Forecast() {
                        ForecastDate = forecastBound.ForecastDate,
                        MinTemp = forecastBound.MinTemp,
                        MaxTemp = forecastBound.MaxTemp,
                        Precipitation = forecastBound.Precipitation,
                        Humidity = forecastBound.Humidity,
                        CityId = forecastCity.CityId
                    };
                    _context.Forecasts.Add(forecastToAdd);
                    _context.SaveChanges();
                    RefreshForm(sender, e);
                    output = "Record added successfully!";
                }
                catch (Exception ex)
                {
                    output = $"Something went spectecularly wrong: /n {ex}";
                }
            }
            else if(isDuplicate(forecastBound))
            {
                output = "This is a duplicate, /n did you mean update?";
                if(MessageBox.Show(this, output, "Confirm Add", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //handle update

                    //Onsuccess
                    output = "Record updated successfully";
                }
            }
            MessageBox.Show(output);

        }

        private void btnDeleteForecast_Click(object sender, EventArgs e)
        {
            Forecast forecastBound = forecastBindingSource.Current as Forecast;
            string output = "";

            try
            {
                if (MessageBox.Show(this, $"Clicking yes Remove selected forecast record from the database, Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Forecast forecastToDelete = _context.Forecasts.Where(f => f.ForecastId == forecastBound.ForecastId).FirstOrDefault();
                    _context.Forecasts.Remove(forecastToDelete);
                    _context.SaveChanges();
                    RefreshForm(sender, e);
                    output = "Record deleted successsfully!";
                }
                else
                {
                    output = "deletion aborted";
                }
            }
            catch (Exception ex)
            {
                output = $"Something bad happened \n {ex}";
            }
            MessageBox.Show(output);
        }

        private void FormDashboard_Load_1(object sender, EventArgs e)
        {
            //dashboardTabControl.Appearance =  Color.FromArgb(45, 81, 118);

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Are you sure you want to quit application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

            using (var home = new HomePageForm())
            {
                home.ShowDialog();
            }
        }
    }
}
