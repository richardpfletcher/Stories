using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoriesCoreApi.Factory;
using Microsoft.AspNetCore.Cors;



namespace StoriesCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoralTypeController : ControllerBase
    {
       
        [HttpGet]
        public response Get()
        {

            GetStories myStories = new GetStories();
            return myStories.GetMoralType();



        }
    }
}