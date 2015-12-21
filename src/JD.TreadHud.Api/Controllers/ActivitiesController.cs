using System.Collections.Generic;
using Microsoft.AspNet.Mvc;

namespace JD.TreadHud.Api.Controllers
{
    [Route("api/[controller]")]
    public class ActivitiesController : Controller
    {
        // GET: api/activity
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/activity/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/activity
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/activity/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/activity/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
