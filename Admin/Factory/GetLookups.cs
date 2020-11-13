﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
using System.Configuration;

namespace Stories.Factory
{
    public class GetLookups
    {
        public DropdownModel GeLookupAnimal()
        {
            using (var client = new System.Net.Http.HttpClient())
            {

                var settings = ConfigurationManager.AppSettings["LocalWebApi"];
                var uri = new Uri(settings + "api/AnimalType/");

                //var uri = new Uri("http://localhost:5187/api/AnimalType/");

                var response = client.GetAsync(uri).Result;

                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;


                var x = JObject.Parse(responseString);

                XNode node = JsonConvert.DeserializeXNode(x.ToString(), "data");

                string a = node.ToString();
                string trima = a.Replace("\r\n", "");
                trima = a.Replace("{", "");
                trima = a.Replace("}", "");


                DropdownModel model = new DropdownModel();
                //Model.items.Add(new SelectListItem { Text = "Please Select ", Value = "0" });

                XDocument xml = XDocument.Parse(trima);

                foreach (var el in xml.Descendants("animalTypeLists"))
                {
                    string ID = el.Element("ID").Value;
                    string AnimalType = el.Element("AnimalType").Value;
                    model.items.Add(new SelectListItem { Text = AnimalType, Value = ID });
                }

                var animalType = "";

                foreach (SelectListItem s in model.items)
                {
                    if (s.Value == animalType)
                    {
                        s.Selected = true;
                    }
                }

                return model;
                //ViewData["animalTypeData"] = model.items;

            }
        }

        public DropdownModel GeLookupMoral()
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                var settings = ConfigurationManager.AppSettings["LocalWebApi"];
                var uri = new Uri(settings + "api/MoralType/");


                //var uri = new Uri("http://localhost:5187/api/MoralType/");

                var response = client.GetAsync(uri).Result;

                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;


                var x = JObject.Parse(responseString);

                XNode node = JsonConvert.DeserializeXNode(x.ToString(), "data");

                string a = node.ToString();
                string trima = a.Replace("\r\n", "");
                trima = a.Replace("{", "");
                trima = a.Replace("}", "");


                DropdownModel model = new DropdownModel();
                model.items.Add(new SelectListItem { Text = "Please Select ", Value = "0" });

                XDocument xml = XDocument.Parse(trima);

                foreach (var el in xml.Descendants("moralTypeLists"))
                {
                    string ID = el.Element("ID").Value;
                    string AnimalType = el.Element("MoralType").Value;
                    model.items.Add(new SelectListItem { Text = AnimalType, Value = ID });
                }

                var animalType = "";

                foreach (SelectListItem s in model.items)
                {
                    if (s.Value == animalType)
                    {
                        s.Selected = true;
                    }
                }

                return model;
                //ViewData["animalTypeData"] = model.items;

            }
        }

        public DropdownModel GeLookupPosted()
        {
            using (var client = new System.Net.Http.HttpClient())
            {

                var uri = new Uri("http://localhost:5187/api/Project/");

          
                var response = client.GetAsync(uri).Result;

                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;


                var x = JObject.Parse(responseString);

                XNode node = JsonConvert.DeserializeXNode(x.ToString(), "data");

                string a = node.ToString();
                string trima = a.Replace("\r\n", "");
                trima = a.Replace("{", "");
                trima = a.Replace("}", "");


                DropdownModel model = new DropdownModel();
                model.items.Add(new SelectListItem { Text = "Please Select ", Value = "0" });

                XDocument xml = XDocument.Parse(trima);

                foreach (var el in xml.Descendants("postedLists"))
                {
                    string ID = el.Element("ID").Value;
                    string Posted = el.Element("Posted").Value;
                    model.items.Add(new SelectListItem { Text = Posted, Value = ID });
                }

                var animalType = "";

                foreach (SelectListItem s in model.items)
                {
                    if (s.Value == animalType)
                    {
                        s.Selected = true;
                    }
                }

                return model;
                //ViewData["animalTypeData"] = model.items;

            }
        }

        public DropdownModel GeLookupStorySource()
        {
            using (var client = new System.Net.Http.HttpClient())
            {

                var settings = ConfigurationManager.AppSettings["LocalWebApi"];
                var uri = new Uri(settings + "api/StorySource/");

                //var uri = new Uri("http://localhost:5187/api/StorySource/");

                var response = client.GetAsync(uri).Result;

                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;


                var x = JObject.Parse(responseString);

                XNode node = JsonConvert.DeserializeXNode(x.ToString(), "data");

                string a = node.ToString();
                string trima = a.Replace("\r\n", "");
                trima = a.Replace("{", "");
                trima = a.Replace("}", "");


                DropdownModel model = new DropdownModel();
                model.items.Add(new SelectListItem { Text = "Please Select ", Value = "0" });

                XDocument xml = XDocument.Parse(trima);

                foreach (var el in xml.Descendants("storySourceLists"))
                {
                    string ID = el.Element("ID").Value;
                    string AnimalType = el.Element("StorySource").Value;
                    model.items.Add(new SelectListItem { Text = AnimalType, Value = ID });
                }

                var animalType = "";

                foreach (SelectListItem s in model.items)
                {
                    if (s.Value == animalType)
                    {
                        s.Selected = true;
                    }
                }

                return model;
                //ViewData["animalTypeData"] = model.items;

            }

        }

        public DropdownModel GeLookupJakataMaster()
        {
            using (var client = new System.Net.Http.HttpClient())
            {

                var settings = ConfigurationManager.AppSettings["LocalWebApi"];
                var uri = new Uri(settings + "api/JakataMaster/");


                //var uri = new Uri("http://localhost:5187/api/JakataMaster/");

                var response = client.GetAsync(uri).Result;

                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;


                var x = JObject.Parse(responseString);

                XNode node = JsonConvert.DeserializeXNode(x.ToString(), "data");

                string a = node.ToString();
                string trima = a.Replace("\r\n", "");
                trima = a.Replace("{", "");
                trima = a.Replace("}", "");


                DropdownModel model = new DropdownModel();
                //model.items.Add(new SelectListItem { Text = "Please Select ", Value = "0" });

                XDocument xml = XDocument.Parse(trima);

                foreach (var el in xml.Descendants("jakataMasterLists"))
                {
                    string ID = el.Element("ID").Value;
                    string title = el.Element("Title").Value;
                    model.items.Add(new SelectListItem { Text = title, Value = ID });
                }

                var animalType = "";

                foreach (SelectListItem s in model.items)
                {
                    if (s.Value == animalType)
                    {
                        s.Selected = true;
                    }
                }

                return model;
                //ViewData["animalTypeData"] = model.items;

            }
        }

        public DropdownModel GeLookupCatUsers(int id)
        {
            using (var client = new System.Net.Http.HttpClient())
            {

                var uri = new Uri("http://localhost:5187/api/MothersHelpers/getMothersHelpersTypeUsers?id=" + id);
                //var uri = new Uri("https://localhost:44302/api/MothersHelpers/getMothersHelpersTypeUsers?id=" + id);

                var response = client.GetAsync(uri).Result;

                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;


                var x = JObject.Parse(responseString);

                XNode node = JsonConvert.DeserializeXNode(x.ToString(), "data");

                string a = node.ToString();
                string trima = a.Replace("\r\n", "");
                trima = a.Replace("{", "");
                trima = a.Replace("}", "");


                DropdownModel model = new DropdownModel();
                
                if (id==2 || id==0)
                {
                    model.items.Add(new SelectListItem { Text = "Please Select ", Value = "0" });
                }
              

                XDocument xml = XDocument.Parse(trima);

                foreach (var el in xml.Descendants("mothersHelpersLists"))
                {
                    string ID = el.Element("ID").Value;
                    string Name = el.Element("Name").Value;
                    Name = Name.Trim();
                    model.items.Add(new SelectListItem { Text = Name, Value = ID });
                }

                var animalType = "";

                foreach (SelectListItem s in model.items)
                {
                    if (s.Value == animalType)
                    {
                        s.Selected = true;
                    }
                }

                return model;
                //ViewData["animalTypeData"] = model.items;

            }
        }

        public DropdownModel GetStoryCategorytName()
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                var settings = ConfigurationManager.AppSettings["LocalWebApi"];
                var uri = new Uri(settings + "api/StoryCategorytName/");


                //var uri = new Uri("http://localhost:5187/api/MoralType/");

                var response = client.GetAsync(uri).Result;

                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;


                var x = JObject.Parse(responseString);

                XNode node = JsonConvert.DeserializeXNode(x.ToString(), "data");

                string a = node.ToString();
                string trima = a.Replace("\r\n", "");
                trima = a.Replace("{", "");
                trima = a.Replace("}", "");


                DropdownModel model = new DropdownModel();
                model.items.Add(new SelectListItem { Text = "Please Select ", Value = "0" });

                XDocument xml = XDocument.Parse(trima);

                foreach (var el in xml.Descendants("storyCategorytNameLists"))
                {
                    string ID = el.Element("ID").Value;
                    string AnimalType = el.Element("StoryCategorytName").Value;
                    model.items.Add(new SelectListItem { Text = AnimalType, Value = ID });
                }

                var animalType = "";

                foreach (SelectListItem s in model.items)
                {
                    if (s.Value == animalType)
                    {
                        s.Selected = true;
                    }
                }

                return model;
                //ViewData["animalTypeData"] = model.items;

            }
        }

        public DropdownModel GeLookupSpecificStoryDropdown()
        {
            using (var client = new System.Net.Http.HttpClient())
            {


                var settings = ConfigurationManager.AppSettings["LocalWebApi"];
                var uri = new Uri(settings + "api/SpecificStoryDropdown/");

                //var uri = new Uri("http://localhost:5187/api/SpecificStoryDropdown/");

                var response = client.GetAsync(uri).Result;

                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;


                var x = JObject.Parse(responseString);

                XNode node = JsonConvert.DeserializeXNode(x.ToString(), "data");

                string a = node.ToString();
                string trima = a.Replace("\r\n", "");
                trima = a.Replace("{", "");
                trima = a.Replace("}", "");


                DropdownModel model = new DropdownModel();
                model.items.Add(new SelectListItem { Text = "Please Select ", Value = "0" });

                XDocument xml = XDocument.Parse(trima);

                foreach (var el in xml.Descendants("jakataMasterLists"))
                {
                    string ID = el.Element("ID").Value;
                    string title = el.Element("Title").Value;
                    model.items.Add(new SelectListItem { Text = title, Value = ID });
                }

                var animalType = "";

                foreach (SelectListItem s in model.items)
                {
                    if (s.Value == animalType)
                    {
                        s.Selected = true;
                    }
                }

                return model;
                //ViewData["animalTypeData"] = model.items;

            }
        }


        public DropdownModel GetStatus(int status1)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                var settings = ConfigurationManager.AppSettings["LocalWebApi"];
                var uri = new Uri(settings + "api/ToDo/" + status1);


                //var uri = new Uri("http://localhost:5187/api/ToDo/"+status1);
                
                var response = client.GetAsync(uri).Result;

                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;


                var x = JObject.Parse(responseString);

                XNode node = JsonConvert.DeserializeXNode(x.ToString(), "data");

                string a = node.ToString();
                string trima = a.Replace("\r\n", "");
                trima = a.Replace("{", "");
                trima = a.Replace("}", "");


                DropdownModel model = new DropdownModel();
                
                XDocument xml = XDocument.Parse(trima);

                foreach (var el in xml.Descendants("toDoLists"))
                {
                    string ID = el.Element("ID").Value;
                    string title = el.Element("Title").Value;
                    model.items.Add(new SelectListItem { Text = title, Value = ID });
                }

                var animalType = "";

                foreach (SelectListItem s in model.items)
                {
                    if (s.Value == animalType)
                    {
                        s.Selected = true;
                    }
                }

                return model;
                //ViewData["animalTypeData"] = model.items;

            }
        }


        public Story GetSpecificStory(int row,string mode)
        {
            using (var client = new System.Net.Http.HttpClient())
            {

                var settings = ConfigurationManager.AppSettings["LocalWebApi"];
                var uri = new Uri(settings + "api/Stories/getSpecificStory?ID=" + row + "&Mode="+mode);


                //var uri = new Uri("http://localhost:5187/api/Stories/getSpecificStory?ID=" + row + "&Mode=JakataID");
                var response = client.GetAsync(uri).Result;

                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;

                string s2 = "0 Records found";
                bool b = responseString.Contains(s2);

                if (b==true)
                {
                    uri = new Uri("http://localhost:5187/api/Stories/getSpecificStory?ID=" + row + "&Mode=ID");
                    response = client.GetAsync(uri).Result;
                    responseContent = response.Content;
                    responseString = responseContent.ReadAsStringAsync().Result;

                }


                var x = JObject.Parse(responseString);

                XNode node = JsonConvert.DeserializeXNode(x.ToString(), "data");

                string a = node.ToString();
                string trima = a.Replace("\r\n", "");
                trima = a.Replace("{", "");
                trima = a.Replace("}", "");


                Story modelStory = new Story();
                
                XDocument xml = XDocument.Parse(trima);

                foreach (var el in xml.Descendants("specificStory"))
                {
                    modelStory.ID = Convert.ToInt16(el.Element("ID").Value);
                    modelStory.JakataID = Convert.ToInt16(el.Element("JakataID").Value); 
                    modelStory.AnimalType = el.Element("AnimalType").Value; 
                    modelStory.Comments = el.Element("Comments").Value; ;
                    modelStory.MoralType = Convert.ToInt16(el.Element("MoralType").Value); 
                    modelStory.Stories =el.Element("Stories").Value;
                    modelStory.StoryCategorytName= Convert.ToInt16(el.Element("StoryCategorytName").Value) ;
                    modelStory.Title = Convert.ToInt16(el.Element("Title").Value);
                }



                return modelStory;
              
            }

        }

        public Story GetReaderstory(int JakataID,int userID)
        {
            using (var client = new System.Net.Http.HttpClient())
            {

                var uri = new Uri("http://localhost:5187/api/Project/getReaderstory?JakataID="+ JakataID+"&userID="+userID);
                var response = client.GetAsync(uri).Result;

                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;


                var x = JObject.Parse(responseString);

                XNode node = JsonConvert.DeserializeXNode(x.ToString(), "data");

                string a = node.ToString();
                string trima = a.Replace("\r\n", "");
                trima = a.Replace("{", "");
                trima = a.Replace("}", "");


                Story modelStory = new Story();

                XDocument xml = XDocument.Parse(trima);

                foreach (var el in xml.Descendants("readersStory"))
                {
                    modelStory.ID = Convert.ToInt16(el.Element("ID").Value);
                    modelStory.JakataID = Convert.ToInt16(el.Element("JakataID").Value);
                    modelStory.Comments = el.Element("Comments").Value; ;
                    modelStory.Title = Convert.ToInt16(el.Element("Title").Value);

                    modelStory.Name = el.Element("Name").Value;
                    modelStory.Illustrations = el.Element("Illustrations").Value;
                    modelStory.Music = el.Element("Music").Value;
                    modelStory.Dance = el.Element("Dance").Value; ;
                    modelStory.Admin = el.Element("Admin").Value;
                    modelStory.PostedString = el.Element("Posted").Value;
                    
                    modelStory.illustrationStartDate = el.Element("illustrationStartDate").Value; ;
                    modelStory.illustrationStopDate = el.Element("illustrationStopDate").Value; ;
                    modelStory.ReadersStartDate = el.Element("ReadersStartDate").Value; ;
                    modelStory.ReadersStopDate = el.Element("ReadersStopDate").Value; ;
                    modelStory.MusicStartDate = el.Element("MusicStartDate").Value; ;
                    modelStory.MusicStoptDate = el.Element("MusicStopDate").Value; ;
                    modelStory.DanceStartDate = el.Element("DanceStartDate").Value; ;
                    modelStory.DanceStopDate = el.Element("DanceStopDate").Value; ;


    }



                return modelStory;

            }

        }

        public DropdownModel GetYouTube(int row, int userID)
        {
            using (var client = new System.Net.Http.HttpClient())
            {

                var settings = ConfigurationManager.AppSettings["LocalWebApi"];
                var uri = new Uri(settings + "api/YouTube/getYouTube/?ID=" + row + "&UserID=" + userID);


                //var uri = new Uri("http://localhost:5187/api/YouTube/getYouTube/?ID=" + row + "&UserID=" + userID);
                var response = client.GetAsync(uri).Result;

                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;


                var x = JObject.Parse(responseString);

                XNode node = JsonConvert.DeserializeXNode(x.ToString(), "data");

                string a = node.ToString();
                string trima = a.Replace("\r\n", "");
                trima = a.Replace("{", "");
                trima = a.Replace("}", "");

                DropdownModel model = new DropdownModel();
               
                XDocument xml = XDocument.Parse(trima);

                foreach (var el in xml.Descendants("youTubeLists"))
                {
                    string ID = el.Element("JakataID").Value;
                    string title = el.Element("URL").Value;
                    model.items.Add(new SelectListItem { Text = title, Value = ID });
                }



                //youTubeModel modelStory = new youTubeModel();

                //XDocument xml = XDocument.Parse(trima);

                //foreach (var el in xml.Descendants("youTubeLists"))
                //{
                //    modelStory.ID = el.Element("ID").Value;
                //    modelStory.JakataID = el.Element("JakataID").Value;
                //    modelStory.URL = el.Element("URL").Value;


                //}



                return model;

            }
        }

    }
}