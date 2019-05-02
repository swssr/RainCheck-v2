using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainCheckUI.Model
{
    public class Province
    {
        public int ProvinceId { get; set; }
        public string Name { get; set; }
        public Province()
        {
            this.Cities = new List<City>();
        }

        public virtual ICollection<City> Cities { get; set; }
    }
}
