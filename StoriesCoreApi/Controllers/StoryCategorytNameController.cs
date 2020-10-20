﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoriesCoreApi.Factory;
using Microsoft.AspNetCore.Cors;


namespace StoriesCoreApi.Controllers
{
    [EnableCors()]
    [Route("api/[controller]")]
    [ApiController]
    public class StoryCategorytNameController : ControllerBase
    {
        [HttpGet]
        public response Get()
        {

            GetStories myStories = new GetStories();
            return myStories.GetStoryCategorytName();
        }
    }
}
