using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using mobgo.Models;
namespace mobgo.Controllers
{
    public class CurrencyController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Currency> Get()
        {
            var context = new Context();
            IEnumerable<Currency> currencies=context.Currencies.ToList<Currency>();

            return currencies;
        }

        // GET api/<controller>/5
        public Currency Get(int id)
        {

            var context = new Context();
            Currency currency= context.Currencies.Find(id);

            return currency;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}