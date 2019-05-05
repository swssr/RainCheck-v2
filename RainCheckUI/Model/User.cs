using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainCheckUI.Model
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        [Required, MinLength(8, ErrorMessage = "Password should have at least 8 characters")]
        public string Password { get; set; }
        public bool isAdmin { get; set; }
        public User()
        {
            isAdmin = false;
        }

        public bool hasElevatedPrivilages() => isAdmin;

        public int? CityId { get; set; }
        public virtual City HomeTown { get; set; }
    }
}
