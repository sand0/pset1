using Frendzone.Data.Interfaces;
using Frendzone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frendzone.Data.Repositories
{
    public class EventRepository : Repository<Event>, IEventRepository
    {
        public EventRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<Event> GetEventsByOwnerId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
