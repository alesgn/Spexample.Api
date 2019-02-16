using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Spektrix.Domain;

namespace SpektrixApi.Controllers
{
    [Route("api/v4/[controller]")]
    public class CustomersController : Controller
    {
        // GET api/customers
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return CustomerRepository.GetCustomers();
        }

        // GET api/customers/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/customers
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
    }
}
