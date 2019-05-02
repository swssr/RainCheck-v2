using System;
using System.ComponentModel.DataAnnotations;

namespace RainCheckUI.Model
{
    public class Forecast
    {
        [Key]
        public int ForecastId { get; set; }
        [Required]
        public DateTime ForecastDate { get; set; }
        [Required]
        public double MinTemp { get; set; }
        [Required]
        public double MaxTemp { get; set; }
        [Required]
        public double Precipitation { get; set; }
        [Required]
        public double Humidity { get; set; }
        [Required]
        public double WindSpeed { get; set; }

        public int CityId { get; set; }
        public virtual City City { get; set; }
    }
}
