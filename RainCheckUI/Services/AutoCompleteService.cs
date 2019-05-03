using MetroFramework.Controls;
using RainCheckUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainCheckUI.Services
{
    public class AutoCompleteService
    {
        public void ProvinceAutoComplete(MetroTextBox txtSearchProvince)
        {
            txtSearchProvince.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearchProvince.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection provinceSuggestions = new AutoCompleteStringCollection();

            using (var db = new ModelContext())
            {
                var Provinces = db.Provinces;

                var provinces = db.Provinces.ToArray();

                foreach (var province in Provinces)
                {
                    provinceSuggestions.Add(province.ProvinceName);
                }

            }

            txtSearchProvince.AutoCompleteCustomSource = provinceSuggestions;
        }
        public void CityAutoComplete(MetroTextBox txtSearchCity)
        {
            txtSearchCity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearchCity.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection citySuggestions = new AutoCompleteStringCollection();

            using (var db = new ModelContext())
            {
                var Cities = db.Cities;

                var cities = db.Cities.ToArray();

                foreach (var city in Cities)
                {
                    citySuggestions.Add(city.CityName);
                }

            }

            txtSearchCity.AutoCompleteCustomSource = citySuggestions;
        }

    }
}
