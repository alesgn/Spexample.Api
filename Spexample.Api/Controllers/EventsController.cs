using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Spektrix.Domain;

namespace SpektrixApi.Controllers
{
    [Route("api/v4/[controller]")]
    public class EventsController : Controller
    {
        // GET api/events
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return EventRepository.GetEvents();
        }

        // GET api/events/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST api/events
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
    }
}
