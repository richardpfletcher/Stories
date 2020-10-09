using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Stories.Factory;

namespace Stories.Controllers
{
    public class RomanToArabicController : ApiController
    {

        public int Get(string roman)
        {

            GetStories myStories = new GetStories();
            return myStories.RomanToArabic(roman);



        }
    }
}
