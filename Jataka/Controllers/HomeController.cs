using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Stories.Factory;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Text;
using System.Xml.XPath;
using Stories.Models;

namespace Jataka.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public ActionResult SearchAPI()
        //{


        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        public ActionResult Search()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.Message = "Your app description page.";

            DropdownModel model = new DropdownModel();
            DropdownModel modelAnimal = new DropdownModel();
            GetLookups myGetLookups = new GetLookups();
            model = myGetLookups.GeLookupAnimal();
            ViewData["animalTypeData"] = model.items;

            Story myStory = new Story();
            myStory.animalCombo = model;

            //modelAnimal = model;

            model = myGetLookups.GeLookupMoral();
            ViewData["moralTypeData"] = model.items;

            model = myGetLookups.GeLookupStorySource();
            ViewData["storySourceData"] = model.items;

            model = myGetLookups.GeLookupJakataMaster();
            ViewData["jakataMasterData"] = model.items;

            return View(myStory);
        }
    }

   

    }