using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainCheckUI
{
    public partial class FormDashboard : MetroFramework.Forms.MetroForm
    {
        public FormDashboard()
        {
            InitializeComponent();
        }
        private void FormDashboard_Load(object sender, EventArgs e)
        {
            panelAddForecast.Visible = true;
            panelUpdateForecast.Visible = false;
            panelRemoveForecast.Visible = false;

        }
        private void tileAddForecast_Click(object sender, EventArgs e)
        {
            panelAddForecast.Visible = true;
            panelUpdateForecast.Visible = false;
            panelRemoveForecast.Visible = false;
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
    }
}
