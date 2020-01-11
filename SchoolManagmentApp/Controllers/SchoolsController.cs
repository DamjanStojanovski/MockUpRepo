using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagmentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolsController : ControllerBase
    {
        // GET: api/Schools
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new List<string> { "" };
        }

        // GET: api/Schools/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            
            return "value";
        }

        // POST: api/Schools
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Schools/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
