using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoriesCoreApi.Models;
using StoriesCoreApi.Factory;
using System.Net.Http;
using System.Net;
using Microsoft.AspNetCore.Cors;

namespace StoriesCoreApi.Controllers
{

    //[EnableCors(origins: "http://localhost:44345", headers: "*", methods: "*")]
    [EnableCors()]

    [Route("api/[controller]")]
    [ApiController]
    public class StoriesapiController : ControllerBase
    {
        [EnableCors("Policy1")]
        [HttpPost]
        [Route("api/Storiesapi/insert")]

        public IActionResult Insert(Story myStoryies)
        {
            GetStories myStories = new GetStories();



            int lastRecord = myStories.Insert(myStoryies);
            MyOder order = new MyOder();
            order.MyData = lastRecord.ToString();


            return Ok(order);

            //return Request.CreateResponse<MyOder>(HttpStatusCode.Created, order);


        }

        [HttpPost]
        [Route("api/Storiesapi/inserturl")]

        public IActionResult InsertURL(youTubeModel myYoutube)
        {
            GetStories myStories = new GetStories();



            int lastRecord = myStories.InsertURL(myYoutube);
            MyOder order = new MyOder();
            order.MyData = lastRecord.ToString();
            return Ok(order);

        }



        [HttpPost]
        [Route("api/Storiesapi/update")]

        public IActionResult Update(Story myStoryies)
        {
            GetStories myStories = new GetStories();



            int lastRecord = myStories.Update(myStoryies);
            MyOder order = new MyOder();
            order.MyData = lastRecord.ToString();
            //order.MyData = "1";
            return Ok(order);

        }

        [HttpPost]
        [Route("api/Storiesapi/search")]



        public string Search(Story myStoryies)
        //public HttpResponseMessage Search(Story myStoryies)

        //public response Search(Story myStoryies)
        //public string Search(Story myStoryies)
        {

            //return "hello";

            GetStories myStories = new GetStories();
            //SpecificStoryList mySpecificStoryList = new SpecificStoryList();
            string xmlString = myStories.GetSpecificStory(myStoryies);

            //response myresponse = new response();
            //myresponse = myStories.GetSpecificStory(myStoryies);

            //return myresponse ;
            return xmlString;
            //return Request.CreateResponse<String>(HttpStatusCode.Created, xmlString);

            //HttpResponseMessage response = new HttpResponseMessage();
            //response.Content = new StringContent(xmlString);
            //return response;

            //return myStories.GetSpecificStory(myStoryies);


        }


    }
}

