using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;
using JD.Skeleton.Domain.Managers;

namespace JD.Skeleton.Api.Controllers
{
    [Route("api/[controller]")]
    public class SkeletonsController : Controller
    {
        private readonly ILogger<SkeletonsController> _logger;
        private readonly ISkeletonManager _skeletonManager;

        public SkeletonsController(ILogger<SkeletonsController> logger, ISkeletonManager skeletonManager)
        {
            _logger = logger;
            _skeletonManager = skeletonManager;
        }

        // GET: api/skeleton
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var bone = _skeletonManager.GetBone(Guid.NewGuid());
            var bones = _skeletonManager.GetAllBones();
            var success = _skeletonManager.AddBone(bone);
            return new string[] { "value1", "value2" };
        }

        // GET api/skeleton/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/skeleton
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/skeleton/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/skeleton/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
