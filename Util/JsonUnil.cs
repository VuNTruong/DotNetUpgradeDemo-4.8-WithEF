using Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Util
{
    public class JsonUnil
    {

        public JsonUnil() { }

        /*
         * Generate Json from provided json string
         */
        public JObject GenerateJsonFromString(string jsonString)
        {
            return JObject.Parse(jsonString);
        }

        /*
         * Generate User object from json string
         */
        public User GenerateUserObjectFromJsonString(string jsonString)
        {
            return JsonConvert.DeserializeObject<User>(jsonString);
        }

        /*
         * Generate json string based on User object
         */
        public string GenerateJsonStringFromUserObject(User user)
        {
            return JsonConvert.SerializeObject(user, Formatting.Indented);
        }
    }
}
