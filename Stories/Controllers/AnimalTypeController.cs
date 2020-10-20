using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Stories.Factory;
using System.Web.Http.Cors;


namespace Stories.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AnimalTypeController : ApiController
    {

        //// GET: api/Storiesapi
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        public response Get()
        {

            GetStories myStories = new GetStories();
            return myStories.GetAnimal();



        }
    }
}
