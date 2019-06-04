using Frendzone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frendzone.Data.Interfaces
{
    interface IEventRepository : IRepository<Event>
    {
        IEnumerable<Event> GetEventsByOwnerId(int id);
    }
}
