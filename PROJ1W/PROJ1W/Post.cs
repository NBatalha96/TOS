using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJ1W
{
    class Post
    {
        public string ID { get; set; }
        public string post_title { get; set; }

        public Post(string json, int idx)
        {
            JObject jObject = JObject.Parse(json);
            JToken jUser = jObject["tos_posts"];
            ID = (string)jUser[idx]["ID"];
            post_title = (string)jUser[idx]["post_title"];
        }

        public class RootObject
        {
            public List<Post> tos_posts { get; set; }
        }
    }
}