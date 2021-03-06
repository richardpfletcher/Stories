﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JatakaCore.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using DocumentFormat.OpenXml.Presentation;

namespace JatakaCore.Factory
{
    public class GetLookups
    {

        //public async Task<object> GetAnimal()
        //{


        //    HttpClient client = new HttpClient { BaseAddress = new Uri("https://localhost:44302/") };

       
        //    try
        //    {
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        var response = await client.GetAsync("api/AnimalType");
        //        var httpContent = response.Content;

        //        var result = await httpContent.ReadAsStringAsync();
        //        var variables = JsonConvert.DeserializeObject(result);

        //        return variables;
        //        //return Ok(variables);
        //    }
        //    catch (Exception ex)
        //    {
        //        int o = 0;
        //        return null;
        //    }
        //}


        //public async Task<DropdownModel> BasicCallAsync()
        public DropdownModel GeLookupAnimal()
        {

         
            using (var client = new System.Net.Http.HttpClient())
            {

                //.net web api
                //var uri = new Uri("https://localhost:44302/api/AnimalType/");

                //.net core web api

                var uri = new Uri("https://localhost:44302/api/AnimalType/");


                
                var response = client.GetAsync(uri).Result;

                //var content = await client.GetStringAsync("https://localhost:44302/api/AnimalType");

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

                var uri = new Uri("https://localhost:44302/api/MoralType/");

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

        public DropdownModel GeLookupStorySource()
        {
            using (var client = new System.Net.Http.HttpClient())
            {

                var uri = new Uri("https://localhost:44302/api/StorySource/");

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

                var uri = new Uri("https://localhost:44302/api/JakataMaster/");

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

        public DropdownModel GeLookupSpecificStoryDropdown()
        {
            using (var client = new System.Net.Http.HttpClient())
            {

                var uri = new Uri("https://localhost:44302/api/SpecificStoryDropdown/");

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

                var uri = new Uri("https://localhost:44302/api/ToDo/" + status1);
                //var uri = new Uri("https://localhost:44302/api/Storiesapi/ToDo/"+status1);
                //var uri = new Uri("https://localhost:44302/api/JakataMaster/");

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


        public Story GetSpecificStory(int row)
        {
            using (var client = new System.Net.Http.HttpClient())
            {

                var uri = new Uri("https://localhost:44302/api/Stories/" + row);
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

                foreach (var el in xml.Descendants("specificStory"))
                {
                    modelStory.ID = Convert.ToInt16(el.Element("ID").Value);
                    modelStory.JakataID = Convert.ToInt16(el.Element("JakataID").Value);
                    modelStory.AnimalType = el.Element("AnimalType").Value;
                    modelStory.Comments = el.Element("Comments").Value; ;
                    modelStory.MoralType = Convert.ToInt16(el.Element("MoralType").Value);
                    modelStory.Stories = el.Element("Stories").Value;
                    modelStory.StoryCategorytName = Convert.ToInt16(el.Element("StoryCategorytName").Value);
                    modelStory.Title = Convert.ToInt16(el.Element("Title").Value);
                }



                return modelStory;

            }

        }

        public DropdownModel GetYouTube(int row)
        {
            using (var client = new System.Net.Http.HttpClient())
            {

                var uri = new Uri("https://localhost:44302/api/YouTube/" + row);
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