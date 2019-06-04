using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frendzone.Models
{
    public class Event : BaseEntity
    {
        public Category Category { get; set; }

        public Photo Photo { get; set; }
        public string Description { get; set; }

        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public User Owner { get; set; }
        public List<User> Visitors { get; set; }
    }
}
