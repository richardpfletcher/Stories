using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Stories.Factory;

namespace Stories.Controllers
{
    public class RomanController : ApiController
    {
        public string Get(int number)
        {

            GetStories myStories = new GetStories();
            return myStories.ToRomanNumeral(number);



        }
    }
}
