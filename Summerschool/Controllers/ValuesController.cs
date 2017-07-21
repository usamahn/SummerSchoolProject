using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Summerschool.Controllers
{
    public class ValuesController : ApiController
    {


        public double multiplication(double a, double b)
        {
            return a * b;
        }

        public double bmi(double w, double h)
        {
            //string msg = "incorrect";
            if (w < 0 || h <= 0)
            {
                throw new System.InvalidOperationException("Incorrect Value");
            }
            return w / (h * h);

        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
