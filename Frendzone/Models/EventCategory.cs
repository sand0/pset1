using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frendzone.Models
{
    public class EventCategory
    {
        public int EventId { get; set; }
        public Event Event { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
