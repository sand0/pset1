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

        public int PhotoId { get; set; }
        public Photo Photo { get; set; }

        public List<UserCategory> UserCategory { get; set; }
        //public List<EventUser> EventUser { get; set; }

        public List<Event> UsersEvents { get; set; }
        public Location Location { get; set; }
    }
}
