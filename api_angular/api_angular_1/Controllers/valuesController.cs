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
    public class valuesController : ControllerBase
    {
        List<Employee> emp = new List<Employee>()
        {
            new Employee{eid=1,ename="arsh",edesig="dev" },
            new Employee{eid=2,ename="abhay",edesig="dev" },
            new Employee{eid=3,ename="piyush",edesig="dev" },
            new Employee{eid=4,ename="nikhil",edesig="operater" }

        };
        List<string> li = new List<string>()
        {
            "arsh","abhay","efrw","fdsfsd"
        };
        // GET: api/values
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            //return new string[] { "value1", "value2" };

            return emp;
        }

        //// GET: api/values/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    //return "value";

        //    return emp[id];
        //}

        //// POST: api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //    emp.Add(value);
        //}

        //// PUT: api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //    emp[id] = value;
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
            
        //}
    }
}
