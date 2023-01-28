using Microsoft.AspNetCore.Mvc;
using SportsCarnivalWeb.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SportsCarnivalWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        // GET: api/<Manager>
        [HttpGet]
        public IActionResult Get()
        {

            return NoContent();
        }

        // GET api/<Manager>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Manager>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Manager>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Manager>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
