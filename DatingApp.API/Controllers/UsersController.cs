using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DatingApp.API.Data;

namespace DatingApp.API.Controllers
{
    //http://localhost:5000/api/users
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
       // private readonly DataContext testdata;

        public UsersController(DataContext context)
        {
           
            _context = context;
            
        }

        // public ValuesController(DataContext _context)
        // {

        // }
        // GET api/users
        [HttpGet]
        public IActionResult GetValues()
        {
            var values = _context.Users.ToList();

            return Ok(values);
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public IActionResult GetValue(int id)
        {
            var value = _context.Values.FirstOrDefault(x =>x.ID ==id);
            return Ok(value);
        }

        // POST api/users
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
