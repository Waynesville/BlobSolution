using Blog.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class postsController : ControllerBase
    {
        // GET: api/<postsController>
        [HttpGet]
        public List<BlogPost> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<postsController>/5
        [HttpGet("{id}")]
        public BlogPost Get(int id)
        {
            return "value";
        }

        // POST api/<postsController>
        [HttpPost]
        public void Post([FromBody] BlogPost value)
        {
        }

        // PUT api/<postsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] BlogPost value)
        {
        }

        // DELETE api/<postsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpDelete]
        public void Delete()
        {
        }
    }
}
