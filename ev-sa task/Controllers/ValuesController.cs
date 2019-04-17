using ev_sa_task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ev_sa_task.Controllers
{
    public class ValuesController : ApiController
    {
        static List<Product> products = new List<Product>();
        // GET api/values
        public IEnumerable<Product> Get()
        {
            return products;
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return BadRequest("Invalid Product Id");
            }
            return Ok(product);
        }

        // POST api/values
        public IHttpActionResult Post([FromBody]Product value)
        {
            try
            {
                if (!ModelState.IsValid)
                {

                }
                products.Add(value);
                return Ok(value);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Product value)
        {
            Delete(id);
            products.Add(value);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var oldProduct = products.FirstOrDefault(p => p.Id == id);
            products.Remove(oldProduct);
        }
    }
}

