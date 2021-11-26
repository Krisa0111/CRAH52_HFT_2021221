using CRAH52_HFT_2021221.Logic;
using CRAH52_HFT_2021221.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRAH52_HFT_2021221.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClubsController : ControllerBase
    {
        private IClubsLogic logic;
        public ClubsController(IClubsLogic logic)
        {
            this.logic = logic;
        }
        // GET: api/<ClubsController>
        [HttpGet()]
        public IEnumerable<Clubs> GetAll()
        {
            return logic.ReadAll();
        }
        [HttpGet("{id}")]
        public Clubs Get(int id)
        {
            return logic.ReadOne(id);
        }
        [HttpPost]
        public void Post([FromBody] Clubs club)
        {
            logic.Create(club);
        }
        [HttpPut]
        public void Put([FromBody] Clubs club)
        {
            logic.Update(club);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            logic.Delete(id);
        }
    }
}
