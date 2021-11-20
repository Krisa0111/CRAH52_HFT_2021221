using CRAH52_HFT_2021221.Models;
using CRAH52_HFT_2021221.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRAH52_HFT_2021221.Logic
{
    class GuestsLogic : IGuestsLogic
    {
        IGuestsRepository repo;
        public void Create(Guests guest)
        {
            repo.Create(guest);
        }

        public void Delete(int id)
        {
            repo.Delete(id);
        }

        public IQueryable<Guests> ReadAll()
        {
            return repo.ReadAll();
        }

        public Guests ReadOne(int id)
        {
            return repo.ReadOne(id);
        }

        public void Update(Guests guest)
        {
            repo.Update(guest);
        }
    }
}
