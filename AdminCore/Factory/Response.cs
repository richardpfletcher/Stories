﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;



namespace AdminCore.Factory
{
    public class animalType
    {
        public string ID { get; set; }
        public string AnimalType { get; set; }

    }

    public class AnimalTypeList
    {
        [System.Xml.Serialization.XmlArray("animalType")]
        [System.Xml.Serialization.XmlArrayItem("animalType")]
        public List<animalType> animalTypeLists { get; set; }
        public AnimalTypeList()
        {
            animalTypeLists = new List<animalType>();
        }
    }

    public class storySource
    {
        public string ID { get; set; }
        public string StorySource { get; set; }

    }

    public class StorySourceList
    {
        [XmlArray("storySource")]
        [XmlArrayItem("storySource")]
        public List<storySource> storySourceLists { get; set; }
        public StorySourceList()
        {
            storySourceLists = new List<storySource>();
        }
    }

    public class jakataMaster
    {
        public string ID { get; set; }
        public string Title { get; set; }

    }

    public class JakataMasterList
    {
        [XmlArray("jakataMaster")]
        [XmlArrayItem("jakataMaster")]
        public List<jakataMaster> jakataMasterLists { get; set; }
        public JakataMasterList()
        {
            jakataMasterLists = new List<jakataMaster>();
        }
    }

    public class toDo
    {
        public string ID { get; set; }
        public string Title { get; set; }

    }

    public class ToDoList
    {
        [XmlArray("toDo")]
        [XmlArrayItem("toDo")]
        public List<toDo> toDoLists { get; set; }
        public ToDoList()
        {
            toDoLists = new List<toDo>();
        }
    }




    public class youTube
    {
        public string ID { get; set; }
        public string JakataID { get; set; }
        public string URL { get; set; }
    }

    public class YouTubeList
    {
        [XmlArray("youTube")]
        [XmlArrayItem("youTube")]
        public List<youTube> youTubeLists { get; set; }
        public YouTubeList()
        {
            youTubeLists = new List<youTube>();
        }
    }

    public class moralType
    {
        public string ID { get; set; }
        public string MoralType { get; set; }

    }

    public class MoralTypeList
    {
        [XmlArray("moralType")]
        [XmlArrayItem("moralType")]
        public List<moralType> moralTypeLists { get; set; }
        public MoralTypeList()
        {
            moralTypeLists = new List<moralType>();
        }
    }


    public class storyCategorytName
    {
        public string ID { get; set; }
        public string StoryCategorytName { get; set; }

    }

    public class StoryCategorytNameList
    {
        [System.Xml.Serialization.XmlArray("storyCategorytName")]
        [XmlArrayItem("storyCategorytName")]
        public List<storyCategorytName> storyCategorytNameLists { get; set; }
        public StoryCategorytNameList()
        {
            storyCategorytNameLists = new List<storyCategorytName>();
        }
    }




    public class specificStory
    {
        public string ID { get; set; }
        public string JakataID { get; set; }
        public string StoryCategorytName { get; set; }
        public string Title { get; set; }
        public string AnimalType { get; set; }
        public string MoralType { get; set; }
        public string Comments { get; set; }
        public string Stories { get; set; }



    }

    public class SpecificStoryList
    {
        [System.Xml.Serialization.XmlArray("specificStory")]
        [XmlArrayItem("specificStory")]
        public List<specificStory> specificStory { get; set; }
        public SpecificStoryList()
        {
            specificStory = new List<specificStory>();
        }
    }



    ////We have to include any custom derived classes using XmlInclude
    [XmlRoot("response")]
    //[XmlInclude(typeof(ProductCertificatesList))]
    //[XmlInclude(typeof(AnimalTypeList))]

    public class response
    {
        [System.Xml.Serialization.XmlElement("result")]
        public int result;
        [XmlElement("xmlData")]
        public System.Xml.XmlDocument xmlData;
        //data will accept any type of primitive or strictly typed class object
        [XmlElement("data")]
        public List<object> data;
        [XmlArray("log")]
        [XmlArrayItem("entry")]
        public List<string> log;
        //Constructor (even if empty) is required for XmlSerializer to work as it needs to instantiate the class in order to serialize it
        public response()
        {
            //result = -1;
            data = new List<object>();
            log = new List<string>();
        }
        //Simply
        public System.Collections.IList AddSpecificStoryList(SpecificStoryList list)
        {
            data.Add(list);
            return data;
        }

        public System.Collections.IList AddAnimalTypeList(AnimalTypeList list)
        {
            data.Add(list);
            return data;
        }

        public System.Collections.IList AddStorySourceList(StorySourceList list)
        {
            data.Add(list);
            return data;
        }

        public System.Collections.IList AddJakataMasterList(JakataMasterList list)
        {
            data.Add(list);
            return data;
        }

        public System.Collections.IList AddToDoList(ToDoList list)
        {
            data.Add(list);
            return data;
        }


        public System.Collections.IList AddMoralTypeList(MoralTypeList list)
        {
            data.Add(list);
            return data;
        }

        public System.Collections.IList AddYouTubeList(YouTubeList list)
        {
            data.Add(list);
            return data;
        }

        public System.Collections.IList AddStoryCategorytNameList(StoryCategorytNameList list)
        {
            data.Add(list);
            return data;
        }


        public System.Collections.IList AddStringData(string strData)
        {
            data.Add(strData);
            return data;
        }
    }
}
