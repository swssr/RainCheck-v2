using MetroFramework;
using RainCheckUI.Model;
using RainCheckUI.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
namespace RainCheckUI
{
    public partial class FormDashboard : MetroFramework.Forms.MetroForm
    {
        ModelContext _context = new ModelContext();
        public FormDashboard()
        {
            InitializeComponent();

            bindStuff();
            checkDbIndexing();

        }
        private void FormDashboard_Load(object sender, EventArgs e)
        {
            using (var db = new ModelContext())
            {

                userBindingSource.DataSource = db.Users.ToList();
                cityBindingSource.DataSource = db.Cities.ToList();
                forecastBindingSource.DataSource = db.Forecasts.ToList();

                panelAddForecast.Visible = true;
                panelUpdateForecast.Visible = false;
                panelRemoveForecast.Visible = false;

                cmdAddForecastCity.DataSource = db.Cities.ToArray();
                cmdAddForecastCity.DisplayMember = "CityName";

            }

        }
        private void tileAddForecast_Click(object sender, EventArgs e)
        {
            panelAddForecast.Visible = true;
            panelUpdateForecast.Visible = false;
            panelRemoveForecast.Visible = false;
            dashboardTabControl.TabIndex = 5;
        }

        private void tileUpdateForecast_Click(object sender, EventArgs e)
        {
            panelUpdateForecast.Visible = true;
            panelAddForecast.Visible = false;
            panelRemoveForecast.Visible = false;
        }

        private void tileDeleteForecast_Click(object sender, EventArgs e)
        {
            panelRemoveForecast.Visible = true;
            panelUpdateForecast.Visible = false;
            panelAddForecast.Visible = false;
        }

        private void gridAllUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            User user = userBindingSource.Current as User;
            //Func<bool> isIndexed = () => _context.Users.Find(user.Username) != null;
            if (_context.Users.Find(user.Username) != null)
            {
                btnAddUser.Enabled = false;
            }
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
        private void checkDbIndexing()
        {
            User user = userBindingSource.Current as User;
            List<User> usersInDB = _context.Users.ToList();
            //Func<bool> isIndexed = () => _context.Users.Find(user.Username) != null;
            if (usersInDB.IndexOf(user) != -1)
            {
                btnAddUser.Enabled = false;
            }
            else
            {
                btnAddUser.Enabled = true;
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

    }
}
