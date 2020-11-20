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
    public class StoryCategorytNameController : ApiController
    {
        [HttpGet]

        public response Get()
        {

            GetStories myStories = new GetStories();
            return myStories.GetStoryCategorytName();
        }

        [HttpGet]
        [Route("api/StoryCategorytName/GetStoryCategoryNameByID")]


        public response GetStoryCategoryNameByID(int id)

        {

            GetStories myStories = new GetStories();
            response StoryCategoryName = myStories.GetStoryCategoryNameByID(id);

            return StoryCategoryName;


        }

    }
}
