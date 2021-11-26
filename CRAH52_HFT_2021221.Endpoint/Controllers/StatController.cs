using CRAH52_HFT_2021221.Logic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRAH52_HFT_2021221.Endpoint.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class StatController : ControllerBase
    {
        IClubsLogic cl;
        IGuestsLogic gl;
        IEventsLogic el;
        public StatController(IEventsLogic el, IGuestsLogic gl, IClubsLogic cl)
        {
            this.cl = cl;
            this.gl = gl;
            this.el = el;
        }
        //[HttpGet]
        //public 
    }
}
