using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frendzone.Models
{
    public class User : IdentityUser
    {
        public DateTime BirthdayDate { get; set; }
        public Photo Avatar { get; set; }
        public List<Category> FavoriteCategories { get; set; }
        public string Location { get; set; }
    }
}
