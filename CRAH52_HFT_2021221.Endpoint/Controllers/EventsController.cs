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
    public class EventsController : ControllerBase
    {
        IEventsLogic logic;
        public EventsController(IEventsLogic logic)
        {
            this.logic = logic;
        }
        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<Events> Get()
        {
            return logic.ReadAll();
        }
        [HttpGet("{id}")]
        public Events Get(int id)
        {
            return logic.ReadOne(id);
        }
        [HttpPost]
        public void Post([FromBody] Events events)
        {
            logic.Create(events);
        }
        [HttpPut("{id}")]
        public void Put([FromBody] Events events)
        {
            logic.Update(events);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            logic.Delete(id);
        }
    }
}
