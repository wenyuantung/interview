using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employee.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace Employee.Controllers
{
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        public static List<Models.Employee> Engineers = new List<Models.Employee>();

        static EmployeesController()
        {
            // Load data from data file.
        }

        // GET api/Employees
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/Employees/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/Employees
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/Employees/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Employees/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
