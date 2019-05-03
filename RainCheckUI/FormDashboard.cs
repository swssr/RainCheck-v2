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
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            using (var db = new ModelContext())
            {

                if (MetroMessageBox.Show(this, "Confirm to delete this user", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    User user = userBindingSource.Current as User;
                    if (user != null)
                    {
                        //if (db.Entry<User>(user).State == EntityState.Detached)
                        //{
                        //    db.Set<User>().Attach(user);
                        //}
                        //db.Entry<User>(user).State = EntityState.Deleted;
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
