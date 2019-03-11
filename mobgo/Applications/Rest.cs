using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mobgo.Models;
using RestSharp;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Web.Helpers;
using System.Collections;

namespace mobgo.Applications
{
    public class Rest
    {
        private String accessKey = "73aec86fd31ba205e1a5f924e542fd43";

        public List<Currency> call()
        {
            var rest = new RestClient("http://data.fixer.io");
            // client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest("api/latest?access_key="+ this.accessKey); // replaces matching token in request.Resource

            var data=rest.Get(request);


            dynamic stuff = JObject.Parse(data.Content);
            var dio = Json.Decode(data.Content);

            var rates = dio.rates;
            var d = rates;
            var properties = d.GetType().GetProperties();
            foreach (var property in properties)
            {
                var PropertyName = property.Name;
                //You get "Property1" as a result

                var PropetyValue = d.GetType().GetProperty(property.Name).GetValue(d, null);
                //You get "Value1" as a result

                // you can use the PropertyName and Value here
            }
            return new List<Currency>();
        }
    }
}