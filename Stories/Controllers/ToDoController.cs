using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Stories.Factory;

namespace Stories.Controllers
{
    public class ToDoController : ApiController
    {

        public response Get(int ID)
        {

            GetStories myStories = new GetStories();
            return myStories.GetSpecificStoryDropdownStatus(ID);



        }
    }
}
