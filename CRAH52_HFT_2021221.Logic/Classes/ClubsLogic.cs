using CRAH52_HFT_2021221.Models;
using CRAH52_HFT_2021221.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRAH52_HFT_2021221.Logic
{
    class ClubsLogic : IClubsLogic
    {
        IClubsRepository repo;
        public ClubsLogic(IClubsRepository clubsRepository)
        {
            this.repo = clubsRepository;
        }
        public IEnumerable<Clubs> ClubsThatHeldEventsInTheSummer()
        {
            return repo.ReadAll().Where(x => x.Events.Date[5] == '0' && x.Events.Date[6] == '6' || x.Events.Date[6] == '7' || x.Events.Date[6] == '8')
                                 .Select(y => y);
        }

        public void Create(Clubs club)
        {
            repo.Create(club);
        }

        public void Delete(int id)
        {
            repo.Delete(id);
        }

        public IQueryable<Clubs> ReadAll()
        {
            return repo.ReadAll();
        }

        public Clubs ReadOne(int id)
        {
            return repo.ReadOne(id);
        }

        public IEnumerable<Clubs> TheMostPopularCLub()//TEST THIS
        {
            return repo.ReadAll()
                .Select(x => new
                {
                    _CLUB = x,
                    _Eventscount = repo.ReadAll()
                    .Where(y => y.Events.ClubID == x.ClubID)
                    .Count()
                })
                .OrderByDescending(x => x._Eventscount)
                .Select(x => x._CLUB);
        }
        public void Update(Clubs club)
        {
            repo.Update(club);
        }
    }
}
