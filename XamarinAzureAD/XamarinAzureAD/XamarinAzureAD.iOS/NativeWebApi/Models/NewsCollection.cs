// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using XamarinAzureAD.iOS.Models;

namespace XamarinAzureAD.iOS.Models
{
    public static partial class NewsCollection
    {
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public static IList<News> DeserializeJson(JToken inputObject)
        {
            IList<News> deserializedObject = new List<News>();
            foreach (JToken iListValue in ((JArray)inputObject))
            {
                News news = new News();
                news.DeserializeJson(iListValue);
                deserializedObject.Add(news);
            }
            return deserializedObject;
        }
    }
}