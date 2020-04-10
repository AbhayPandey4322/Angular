using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_angular_1.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_angular_1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class customerController : ControllerBase
    {
        private readonly appDbContext _cont;

        public customerController(appDbContext cont)
        {
            _cont = cont;
        }

        [HttpGet]
        public IEnumerable<customers> Get()
        {
            //return new string[] { "value1", "value2" };
            var cust = _cont.cust.ToList();
            return cust;
        }
    }
}