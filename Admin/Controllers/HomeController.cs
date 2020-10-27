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

namespace Stories.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }


        public ActionResult Insert()
        {
            ViewBag.Message = "Your app description page.";

            DropdownModel model = new DropdownModel();
            DropdownModel modelAnimal = new DropdownModel();
            GetLookups myGetLookups = new GetLookups();
            model=myGetLookups.GeLookupAnimal();
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public ActionResult Update(int row)
        {
            Story myStory = new Story();
            DropdownModel model = new DropdownModel();
            GetLookups myGetLookups = new GetLookups();
            Story modelStory = new Story();
            modelStory = myGetLookups.GetSpecificStory(row);

            var ID1 = modelStory.ID.ToString();
            ViewData["id"] = ID1;

            var JakataID = modelStory.JakataID;
            var JakataIDString = modelStory.JakataID.ToString();
            ViewData["JakataID"] = JakataIDString;

            var Comments =modelStory.Comments;
            var Moraltype =modelStory.MoralType  ;
            var Stories =modelStory.Stories  ;
            var StoryCategorytName=modelStory.StoryCategorytName ;
            var Title =modelStory.Title ;

            ViewData["comments"] = Comments;
            ViewData["Stories"] = Stories;
            ViewData["searchResults"] = row;





            model = myGetLookups.GeLookupSpecificStoryDropdown();
            //DropdownModel model = new DropdownModel();
            model = myGetLookups.GeLookupAnimal();


            var AnimalType = modelStory.AnimalType;
            
            AnimalType = AnimalType.Trim();

            if (AnimalType.EndsWith(","))
            {
                AnimalType = AnimalType.Remove(AnimalType.Length - 1, 1);
            }

            string[] Animalchosen = AnimalType.Split(',');
            //model = new DropdownModel();

            model = myGetLookups.GeLookupAnimal();

            for (int i = 0; i < Animalchosen.Length; i++)
            {
                var x = Animalchosen[i];


                foreach (SelectListItem s in model.items)
                {
                    if (s.Value == x)
                    {
                        s.Selected = true;
                    }
                }


            }




            ViewData["animalTypeData"] = model.items;

            
            myStory.animalCombo = model;

            GetLookups myYouTubeGetLookups = new GetLookups();
            model = myYouTubeGetLookups.GetYouTube(JakataID);
            //ViewData["youTubeData"] = model.items;
            myStory.youTubeCombo = model;




            //modelAnimal = model;
            DropdownModel modelMoral = new DropdownModel();

           //modelMoral = myGetLookups.GeLookupMoral();
            model = myGetLookups.GeLookupMoral();

            var moral = Moraltype.ToString();

            foreach (SelectListItem s in model.items)
            {
                if (s.Value == moral)
                {
                    s.Selected = true;
                }
            }

           
            ViewData["moralTypeData1"] = model.items;

            myStory.moralCombo = model;



            model = myGetLookups.GeLookupStorySource();
            ViewData["storySourceData"] = model.items;

            model = myGetLookups.GeLookupJakataMaster();

            var title = JakataID.ToString();

            foreach (SelectListItem s in model.items)
            {
                if (s.Value == title)
                {
                    s.Selected = true;
                }
            }
                       

            ViewData["jakataMasterData"] = model.items;


            // titles done
            model = myGetLookups.GetStatus(1);
            ViewData["Done"] = model.items;
            myStory.done = model;

            model = myGetLookups.GetStatus(0);
            myStory.toDo= model;
            ViewData["ToDo"] = model.items;
            myStory.Stories = Stories;

            return View(myStory);
        }

        public ActionResult UpdateStory()
        {
            ViewBag.Message = "Your app description page.";
            DropdownModel model = new DropdownModel();
            GetLookups myGetLookups = new GetLookups();
            
            model = myGetLookups.GeLookupSpecificStoryDropdown();
            ViewData["jakataMasterData"] = model.items;



            return View();
        }

        public ActionResult UpdateProject()
        {
            ViewBag.Message = "Your app description page.";
            DropdownModel model = new DropdownModel();
            GetLookups myGetLookups = new GetLookups();

            model = myGetLookups.GeLookupSpecificStoryDropdown();
            ViewData["jakataMasterData"] = model.items;

            

            model = myGetLookups.GeLookupCatUsers(2);
            model.items.Add(new SelectListItem { Text = "Please Select ", Value = "0" });

            //model.items.Add

            ViewData["newReadersData"] = model.items;

            DropdownModel modelExisting = new DropdownModel();
            ViewData["existingReaderData"] = modelExisting.items;







            return View();
        }

        [HttpPost]

        public ActionResult Project(int row,int userID,string userName,string mode)
        {
            

            ViewBag.Title = "Project";
            Story myStory = new Story();
            myStory.userName = userName;
            myStory.userID = userID;
            ViewData["userID"] = userID;
            myStory.Mode = mode;
            ViewData["Mode"] = mode;

            DropdownModel model = new DropdownModel();
            DropdownModel modelAnimal = new DropdownModel();
            GetLookups myGetLookups = new GetLookups();
            model = myGetLookups.GeLookupPosted();
            myStory.Posted = model;
            myStory = myGetLookups.GetReaderstory(row, userID);

            //var title = JakataID.ToString();

            foreach (SelectListItem s in model.items)
            {
                if (s.Value == myStory.PostedString)
                {
                    s.Selected = true;
                }
            }



            ViewData["postedData"] = model.items;

            //ilustrators

            //model = myGetLookups.GeLookupCatUsers(1);
            model = myGetLookups.GeLookupCatUsers(1);

            if (mode == "edit")
            {

                var IllustrationType = myStory.Illustrations;

                IllustrationType = IllustrationType.Trim();

                if (IllustrationType.EndsWith(","))
                {
                    IllustrationType = IllustrationType.Remove(IllustrationType.Length - 1, 1);
                }

                string[] Illustrationchosen = IllustrationType.Split(',');
                //model = new DropdownModel();

                //model = myGetLookups.GeLookupAnimal();
               

                for (int i = 0; i < Illustrationchosen.Length; i++)
                {
                    var x = Illustrationchosen[i];


                    foreach (SelectListItem s in model.items)
                    {
                        if (s.Value == x)
                        {
                            s.Selected = true;
                        }
                    }


                }

                //ViewData["animalTypeData"] = model.items;

                myStory.IllustrationsCombo = model;

            }
            myStory.IllustrationsCombo = model;

            //ViewData["IllustrationsData"] = model.items;
            model = myGetLookups.GeLookupCatUsers(2);
            myStory.ReadersCombo = model;
            //ViewData["ReadersData"] = model.items;
            //model = myGetLookups.GeLookupCatUsers(3);
            model = myGetLookups.GeLookupCatUsers(3);

            if (mode == "edit")
            {

                var MusicType = myStory.Music;

                MusicType = MusicType.Trim();

                if (MusicType.EndsWith(","))
                {
                    MusicType = MusicType.Remove(MusicType.Length - 1, 1);
                }

                string[] Musicchosen = MusicType.Split(',');
                //model = new DropdownModel();

                //model = myGetLookups.GeLookupAnimal();
                //model = myGetLookups.GeLookupCatUsers(3);

                for (int i = 0; i < Musicchosen.Length; i++)
                {
                    var x = Musicchosen[i];


                    foreach (SelectListItem s in model.items)
                    {
                        if (s.Value == x)
                        {
                            s.Selected = true;
                        }
                    }


                }

                //ViewData["animalTypeData"] = model.items;

               

                myStory.MusicCombo = model;
            }

            myStory.MusicCombo = model;
            //ViewData["MusicData"] = model.items;
            model = myGetLookups.GeLookupCatUsers(4);
            if (mode == "edit")
            {

                myStory.DanceCombo = model;

                var DanceType = myStory.Dance;

                DanceType = DanceType.Trim();

                if (DanceType.EndsWith(","))
                {
                    DanceType = DanceType.Remove(DanceType.Length - 1, 1);
                }

                string[] Dancechosen = DanceType.Split(',');
                //model = new DropdownModel();

                //model = myGetLookups.GeLookupAnimal();
                //model = myGetLookups.GeLookupCatUsers(1);

                for (int i = 0; i < Dancechosen.Length; i++)
                {
                    var x = Dancechosen[i];


                    foreach (SelectListItem s in model.items)
                    {
                        if (s.Value == x)
                        {
                            s.Selected = true;
                        }
                    }


                }
            }
            //ViewData["animalTypeData"] = model.items;

            myStory.DanceCombo = model;



            //ViewData["DanceData"] = model.items;
            model = myGetLookups.GeLookupCatUsers(5);
            myStory.AdminCombo = model;
            //ViewData["AdminData"] = model.items;

            model = myGetLookups.GeLookupJakataMaster();
            ViewData["jakataMasterData"] = model.items;

            model = myGetLookups.GeLookupStorySource();
            ViewData["storySourceData"] = model.items;

            model = myGetLookups.GeLookupJakataMaster();

            
            Story modelStory = new Story();
            modelStory = myGetLookups.GetSpecificStory(row);

            var ID1 = modelStory.ID.ToString();
            ViewData["id"] = ID1;

            var JakataID = modelStory.JakataID;
            var JakataIDString = modelStory.JakataID.ToString();
            ViewData["JakataID"] = JakataIDString;

            var title = JakataID.ToString();

            foreach (SelectListItem s in model.items)
            {
                if (s.Value == title)
                {
                    s.Selected = true;
                }
            }


            ViewData["jakataMasterData"] = model.items;


            //myStory.Posted = "0";



            return View(myStory);
        }


        public ActionResult BookGenerator()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }
    }
}
