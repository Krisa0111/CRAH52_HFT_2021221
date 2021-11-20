using CRAH52_HFT_2021221.Models;
using CRAH52_HFT_2021221.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRAH52_HFT_2021221.Logic
{
    class EventsLogic : IEventsLogic
    {
        IEventsRepository repo;
        public void Create(Events events)
        {
            repo.Create(events);
        }

        public void Delete(int id)
        {
            repo.Delete(id);
        }

        public IEnumerable<Events> EventWithTheYoungestPerson()
        {
            //return repo.ReadAll()
            //    .Select(x=>x)
            //    .Where(y=>y.Guests)
                throw new NotImplementedException();
        }

        public IEnumerable<Events> MostExpensiveEvents()
        {
            //return repo.ReadAll()
            //    .Select(x=>x)
            //    .Where(y=>y.Clubs.BaseTicketPrice)
            throw new NotImplementedException();
        }

        public IQueryable<Events> ReadAll()
        {
            return repo.ReadAll();
        }

        public Events ReadOne(int id)
        {
            return repo.ReadOne(id);
        }

        public IEnumerable<Events> TheMostPopularEvent()
        {
            throw new NotImplementedException();
        }

        public void Update(Events events)
        {
            repo.Update(events);
        }
    }
}
