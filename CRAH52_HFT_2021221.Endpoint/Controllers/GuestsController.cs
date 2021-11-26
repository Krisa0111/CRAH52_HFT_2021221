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
    public class GuestsController : ControllerBase
    {
        IGuestsLogic logic;
        public GuestsController(IGuestsLogic logic)
        {
            this.logic = logic;
        }
        [HttpGet]
        public IEnumerable<Guests> Get()
        {
            return logic.ReadAll();
        }
        [HttpGet("{id}")]
        public Guests Get(int id)
        {
            return logic.ReadOne(id);
        }
        [HttpPost]
        public void Post([FromBody] Guests guest)
        {
            logic.Create(guest);
        }
        [HttpPut("{id}")]
        public void Put([FromBody] Guests guest)
        {
            logic.Update(guest);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            logic.Delete(id);
        }
    }
}
