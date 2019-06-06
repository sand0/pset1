using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frendzone.Models
{
    public class Category : BaseEntity
    {
        public List<UserCategory> UserCategory { get; set; }
        public List<EventCategory> EventCategory { get; set; }
    }
}
