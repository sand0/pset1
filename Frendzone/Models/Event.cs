using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frendzone.Models
{
    public class Event : BaseEntity
    {
        public List<EventCategory> EventCategory { get; set; }

        public int PhotoId { get; set; }
        public Photo Photo { get; set; }

        public string Description { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public User Owner { get; set; }

        //public List<EventUser> EventUser { get; set; }
    }
}
