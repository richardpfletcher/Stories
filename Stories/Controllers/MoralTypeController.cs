using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http;
using Stories.Factory;

namespace Stories.Controllers
{
    public class MoralTypeController : ApiController
    {
        public response Get()
        {

            GetStories myStories = new GetStories();
            return myStories.GetMoralType();



        }
    }
}
