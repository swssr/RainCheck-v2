using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainCheckUI.Model
{
    public class City
    {
        public int CityId { get; set; }
        [Required, MinLength(2, ErrorMessage = "City name should at least have 2 chars")]
        public string CityName { get; set; }

        public int ProvinceId { get; set; }
        public Province Province { get; set; }
    }
}
